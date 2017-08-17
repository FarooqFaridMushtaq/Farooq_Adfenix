using Starcounter;
using Farooq.Model;
using System;

namespace Farooq.ViewModel
{
    partial class TransactionListViewModel : Json
    {
        protected override void OnData()
        {
            base.OnData();
            this.Date = Convert.ToDateTime(((Transactions)this.Data).TransDate).ToString("yyyy-MM-dd hh:mm:ss");
        }
    }
}
