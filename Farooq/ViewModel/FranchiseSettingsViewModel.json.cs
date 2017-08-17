using Starcounter;
using Farooq.Model;
using Starcounter.Advanced;
using Starcounter.Binding;
using System;

namespace Farooq.ViewModel
{
    partial class FranchiseSettingsViewModel : Json, IObjectView // Implementation of interface to view multiple objects returned by SQL query
    {

        // Computed property
        public string FullAddress => Street + " , " + Number + " , " + ZipCode + " , " + City + " , " + Country;
        
        // overriding base class function
        protected override void OnData()
        {
            base.OnData();
            FillFranchiseSetting();
            GetHomeTransactions();
        }

        #region Public Methods
        public void FillFranchiseSetting()
        {
            try
            {
                var settings = Db.SQL<Address>("Select f From Farooq.Model.Franchise f WHERE f.ObjectID = ?", this.Data.GetObjectID()).First;
                if(settings != null)
                {
                    Street = settings.Street;
                    this.Number = settings.Number;
                    this.ZipCode = settings.ZipCode;
                    this.City = settings.City;
                    this.Country = settings.Country;
                }
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public void GetHomeTransactions()
        {
            try
            {
                // getting records from tables Home and Transactions by using Inner Join and passign franchise ID in where clause
                var transactions = Db.SQL<Starcounter.Query.Execution.Row>("Select h,t FROM Farooq.Model.Home h INNER JOIN Farooq.Model.Transactions t on t.HomeID = h WHERE h.FranchiseID = ?", (Franchise)this.Data);
                this.TransactionsList.Clear(); // clearing all items before adding of previous ones
                if (transactions == null) return;
                
                foreach (var item in transactions)
                {
                    IObjectView iViewer = (IObjectView)item;
                    var home = ((Starcounter.Query.Execution.Row)iViewer).GetObject(0); // getting Home Object
                    var trans = ((Starcounter.Query.Execution.Row)iViewer).GetObject(1); // getting Transactions Object

                    string HomeFullAddress = ((Home)home).Street + " , " + ((Home)home).Number + " , " + ((Home)home).ZipCode + " , " + ((Home)home).City + " , " + ((Home)home).Country;
                    var json = new TransactionListViewModel();
                    json.Data = trans;
                    json.HomeFullAddress = HomeFullAddress;

                    this.TransactionsList.Add(json);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        
        #endregion
        
        #region Handler
        void Handle(Input.SaveFranchiseSettings action)
        {
            try
            {
                Transaction.Commit();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        
        void Handle(Input.RegisterTransaction action)
        {
            try
            {
                // Adding New Home Info
                var homeInfo = new Home
                {
                    Street = this.HomeStreet,
                    Number = this.HomeNumber,
                    ZipCode = this.HomeZipCode,
                    City = this.HomeCity,
                    Country = this.HomeCountry,
                    FranchiseID = (Franchise)this.Data,
                    HomeFullAddress = this.HomeStreet + " , " + this.HomeNumber + " , " + this.HomeZipCode + " , " + this.HomeCity + " , " + this.HomeCountry
                };
                
                // Adding New Home Transaction                       
                var transaction = new Transactions
                {
                    TransDate = this.Date,
                    Price = this.SalesPrice,
                    Commission = this.Commission,
                    HomeID = homeInfo
                };
                
                Transaction.Commit();
                GetHomeTransactions();

            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            
        }

        void Handle(Input.HomeStreet action)
        {
            if (action.Value != action.OldValue)
            {
                this.HomeFullAddress = action.Value + " , " + this.HomeNumber + " , " + this.HomeZipCode + " , " + this.HomeCity + " , " + this.HomeCountry;
                this.HomeStreet = action.Value;
            }
        }

        void Handle(Input.HomeNumber action)
        {
            if (action.Value != action.OldValue)
            {
                this.HomeFullAddress = this.HomeStreet + " , " + action.Value + " , " + this.HomeZipCode + " , " + this.HomeCity + " , " + this.HomeCountry;
                this.HomeNumber = action.Value;
            }
        }

        void Handle(Input.HomeZipCode action)
        {
            if (action.Value != action.OldValue)
            {
                this.HomeFullAddress = this.HomeStreet + " , " + this.HomeNumber + " , " + action.Value + " , " + this.HomeCity + " , " + this.HomeCountry;
                this.HomeZipCode = action.Value;
            }
        }

        void Handle(Input.HomeCity action)
        {
            if (action.Value != action.OldValue)
            {
                this.HomeFullAddress = this.HomeStreet + " , " + this.HomeNumber + " , " + this.HomeZipCode + " , " + action.Value + " , " + this.HomeCountry;
                this.HomeCity = action.Value;
            }
        }

        void Handle(Input.HomeCountry action)
        {
            if (action.Value != action.OldValue)
            {
                this.HomeFullAddress = this.HomeStreet + " , " + this.HomeNumber + " , " + this.HomeZipCode + " , " + this.HomeCity + " , " + action.Value;
                this.HomeCountry = action.Value;
            }
        }


        #endregion

        #region Interface
        ITypeBinding IObjectView.TypeBinding
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        ulong IBindable.Identity
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        IBindableRetriever IBindable.Retriever
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        bool IObjectView.EqualsOrIsDerivedFrom(IObjectView obj)
        {
            throw new NotImplementedException();
        }

        Binary? IObjectView.GetBinary(int index)
        {
            throw new NotImplementedException();
        }

        bool? IObjectView.GetBoolean(int index)
        {
            throw new NotImplementedException();
        }

        byte? IObjectView.GetByte(int index)
        {
            throw new NotImplementedException();
        }

        DateTime? IObjectView.GetDateTime(int index)
        {
            throw new NotImplementedException();
        }

        decimal? IObjectView.GetDecimal(int index)
        {
            throw new NotImplementedException();
        }

        double? IObjectView.GetDouble(int index)
        {
            throw new NotImplementedException();
        }

        short? IObjectView.GetInt16(int index)
        {
            throw new NotImplementedException();
        }

        int? IObjectView.GetInt32(int index)
        {
            throw new NotImplementedException();
        }

        long? IObjectView.GetInt64(int index)
        {
            throw new NotImplementedException();
        }

        IObjectView IObjectView.GetObject(int index)
        {
            throw new NotImplementedException();
        }

        sbyte? IObjectView.GetSByte(int index)
        {
            throw new NotImplementedException();
        }

        float? IObjectView.GetSingle(int index)
        {
            throw new NotImplementedException();
        }

        string IObjectView.GetString(int index)
        {
            throw new NotImplementedException();
        }

        ushort? IObjectView.GetUInt16(int index)
        {
            throw new NotImplementedException();
        }

        uint? IObjectView.GetUInt32(int index)
        {
            throw new NotImplementedException();
        }

        ulong? IObjectView.GetUInt64(int index)
        {
            throw new NotImplementedException();
        }

        #endregion

    }

}
