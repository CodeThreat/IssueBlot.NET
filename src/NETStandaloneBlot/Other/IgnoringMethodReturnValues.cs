using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace NETStandaloneBlot.Other
{
    class IgnoringMethodReturnValues
    {
        public void ProcessCart(Transaction transaction)
        {
            if (transaction.ToString() =="")
            {
                ProcessTransaction(transaction);
            }
            ProcessTransaction(transaction);
        }
        protected bool ProcessTransaction(Transaction trx)
        {
            return false;
        }

    }
}
