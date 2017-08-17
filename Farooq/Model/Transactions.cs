using System;
using Starcounter;

namespace Farooq.Model
{
    [Database]
    public class Transactions
    {
        public Home HomeID;
        public string TransDate;
        public long Price;
        public long Commission;
    }
}
