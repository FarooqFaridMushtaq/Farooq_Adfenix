using Starcounter;
using Farooq.Model;

namespace Farooq.ViewModel
{
    partial class MainPageViewModel : Json
    {
        //overriding OnData Method of Parent Class
        protected override void OnData()
        {
            base.OnData();
            // Fetching all existing corporations
            GetCorporations();
        }
                
        #region Handler
        void Handle(Input.AddNewCorporation action)
        {
            // Adding new corporation and commiting transaction
            Db.Transact(() =>
            {
                new Corporations
                {
                    Name = Name
                };
            });
            GetCorporations();
            Transaction.Commit();
        }
        #endregion

        #region Public Methods
        public void GetCorporations()
        {
            // Getting Corporation List
            var listCorporation = Db.SQL<Corporations>("Select c From Farooq.Model.Corporations c"); // Fetching all corporations 
            foreach (var item in listCorporation)
            {
                var json = new CorporationViewModel();
                json.Data = DbHelper.FromID(DbHelper.Base64DecodeObjectID(item.GetObjectID()));
                this.Corporations.Add(json);
            }
        }

        #endregion

    }
}
