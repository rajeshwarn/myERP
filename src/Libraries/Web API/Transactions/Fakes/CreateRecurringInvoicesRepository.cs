// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Transactions.Data;
using MixERP.Net.Entities.Transactions;

namespace MixERP.Net.Api.Transactions.Fakes
{
    public class CreateRecurringInvoicesRepository : ICreateRecurringInvoicesRepository
    {
        public long PgArg0 { get; set; }

        public void Execute()
        {
            return;
        }
    }
}