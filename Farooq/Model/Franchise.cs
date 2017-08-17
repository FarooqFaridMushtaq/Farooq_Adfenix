using System;
using Starcounter;
using Starcounter.Advanced;
using Starcounter.Binding;
using System.Collections;

namespace Farooq.Model
{
    public class Franchise : Address
    {
        public Corporations CorporationID;
        public QueryResultRows<Home> HomeID => Db.SQL<Home>("Select h From Farooq.Model.Home h WHERE h.FranchiseID = ?", this);
        [Transient]
        public string DetailID;
        public long TotalSoldHomes => Db.SQL<long>("Select Count(h) From Farooq.Model.Home h WHERE h.FranchiseID = ? ", this).First;
        public long TotalCommission => Db.SQL<long>("Select SUM(t.Commission) From Farooq.Model.Home h, Farooq.Model.Transactions t WHERE h.FranchiseID = ? AND t.HomeID = h", this).First;
        public decimal AverageCommission => Db.SQL<decimal>("Select SUM(t.Commission)/Count(h) From Farooq.Model.Home h, Farooq.Model.Transactions t WHERE h.FranchiseID = ? AND t.HomeID = h", this).First;
        public decimal Trend
        {
            get
            {
                string Query = "Select SUM(t.Price) From Farooq.Model.Transactions t";
                Query += " INNER JOIN Farooq.Model.Home h ON t.HomeID = h";
                Query += " INNER JOIN Farooq.Model.Franchise f ON h.FranchiseID = f";
                Query += " INNER JOIN Farooq.Model.Corporations c ON f.CorporationID = c";
                Query += " WHERE h.FranchiseID = ? ";
                Query += " Group BY f.ObjectNo, t.TransDate Order BY t.TransDate";

                decimal BaseSales = Db.SQL<decimal>(Query, (Franchise)this).First;

                Query = "Select t.TransDate From Farooq.Model.Transactions t";
                Query += " INNER JOIN Farooq.Model.Home h ON t.HomeID = h";
                Query += " INNER JOIN Farooq.Model.Franchise f ON h.FranchiseID = f";
                Query += " INNER JOIN Farooq.Model.Corporations c ON f.CorporationID = c";
                Query += " WHERE h.FranchiseID = ? ";
                Query += " Group BY f.ObjectNo, t.TransDate Order BY t.TransDate";

                string BaseTransDate = Db.SQL<string>(Query, (Franchise)this).First;

                Query = "Select SUM(t.Price) From Farooq.Model.Transactions t";
                Query += " INNER JOIN Farooq.Model.Home h ON t.HomeID = h";
                Query += " INNER JOIN Farooq.Model.Franchise f ON h.FranchiseID = f";
                Query += " INNER JOIN Farooq.Model.Corporations c ON f.CorporationID = c";
                Query += " WHERE h.FranchiseID = ? AND t.TransDate > ? ";
                Query += " Group BY f.ObjectNo, t.TransDate Order BY t.TransDate";

                object[] obj = new object[] { (Franchise)this, BaseTransDate };
                decimal RunningSales = Db.SQL<decimal>(Query, obj).First;

                return (((RunningSales - BaseSales) / (BaseSales == 0 ? 1 : BaseSales))) * 100;

            }

            set { }
        }
        
    }
}
