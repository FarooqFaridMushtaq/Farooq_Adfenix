using Starcounter;
using Farooq.Model;

namespace Farooq.ViewModel
{
    partial class CorporationViewModel : Json
    {
        //overriding OnData Method of Parent Class
        protected override void OnData()
        {
            base.OnData();
            // Fetching all existing corporations
            GetFranchises();
        }

        #region Handler
        void Handle(Input.AddNewFranchise action)
        {
            try
            {
                // Adding New Franchise to the database
                var franchise = new Franchise
                {
                    Name = FranchiseName,
                    CorporationID = (Corporations)this.Data
                };
                
                // Committing the transaction at the end
                Transaction.Commit();

                // Clearing text box
                this.FranchiseName = string.Empty;

                // Fetching all the franchises to show on the view
                GetFranchises();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        void Handle(Input.SortOnNumber action)
        {
            FillFranchiseList("TotalSoldHomes");
        }

        void Handle(Input.SortOnCommission action)
        {
            FillFranchiseList("TotalCommission");
        }
        void Handle(Input.SortOnAvgCommission action)
        {
            FillFranchiseList("AverageCommission");
        }

        void Handle(Input.SortOnTrend action)
        {
            FillFranchiseList("Trend");
        }
        

        #endregion

        #region Public Methods
        public void FillFranchiseList(string OrderBy)
        {
            // Getting Franchise List
            var listFranchise = Db.SQL<Franchise>("Select f From Farooq.Model.Franchise f WHERE f.CorporationID = ? Order BY " + OrderBy + " desc" , (Corporations)this.Data); // Fetching all Franchise 

            //Need empty list before populating it
            this.FranchiseList.Clear();

            foreach (var item in listFranchise)
            {
                var json = new FranchiseOfficeViewModel();
                json.Data = DbHelper.FromID(DbHelper.Base64DecodeObjectID(item.GetObjectID()));
                json.DetailID = item.GetObjectID();
                this.FranchiseList.Add(json); // Filling franchise list

            }
        }
        public void GetFranchises()
        {
            try
            {
                FillFranchiseList("Name");
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
