using Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphQL.Types
{
    public class PaymentType : ObjectGraphType<Payment>
    {
        public PaymentType()
        {
            Field(x => x.Id);
            Field(x => x.Value);
            Field(x => x.DateCreated);
            Field(x => x.DateOverdue);
            Field(x => x.Paid);
        }
    }
}
