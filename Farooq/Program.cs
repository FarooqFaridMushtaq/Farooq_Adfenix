using System;
using Starcounter;
using Farooq.Model;
using Farooq.ViewModel;

namespace Farooq
{
    class Program
    {
        static void Main()
        {
            Application.Current.Use(new HtmlFromJsonProvider());
            Application.Current.Use(new PartialToStandaloneHtmlProvider());

            // Handler to start application
            Handle.GET("/Farooq/MainPage", () =>
            {
                return Db.Scope(() =>
                {
                    var corporations = Db.SQL<Corporations>("Select c From Farooq.Model.Corporations c");
                    var corporationJson = new ViewModel.MainPageViewModel
                    {
                        Data = corporations
                    };

                    if (Session.Current == null)
                        Session.Current = new Session(SessionOptions.PatchVersioning);

                    corporationJson.Session = Session.Current;
                    return corporationJson;
                });
                
            });
            
            // Getting Franchise Settings
            Handle.GET("/Farooq/FranchiseInfo/{?}", (string DetailID) => {
                
                return Db.Scope(() =>
                {
                    var json = new FranchiseSettingsViewModel();
                    json.Name = ((Franchise) DbHelper.FromID(DbHelper.Base64DecodeObjectID(DetailID))).Name;
                    json.Data = DbHelper.FromID(DbHelper.Base64DecodeObjectID(DetailID));

                    if (Session.Current == null)
                        Session.Current = new Session(SessionOptions.PatchVersioning);

                    json.Session = Session.Current;
                    return json;
                });
            });
            
        }
    }
}