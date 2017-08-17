using System;
using Starcounter;

namespace Farooq.Model
{
    public class Corporations : RealEstate
    {
        public QueryResultRows<Franchise> Franchises => Db.SQL<Franchise>("Select f FROM Farooq.Model.Franchise f WHERE f.CorporationID = ?", this);

    }
}
