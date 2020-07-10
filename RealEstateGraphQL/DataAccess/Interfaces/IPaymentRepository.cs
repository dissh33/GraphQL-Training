using Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Interfaces
{
    public interface IPaymentRepository
    {
        IEnumerable<Payment> GetAllForProperty(int propertyId);
        IEnumerable<Payment> GetAllForProperty(int propertyId, int lastAmount);
    }
}
