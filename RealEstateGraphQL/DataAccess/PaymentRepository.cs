using DataAccess.Interfaces;
using Database;
using Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly RealEstateDbContext _db;

        public PaymentRepository(RealEstateDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Payment> GetAllForProperty(int propertyId)
        {
            return _db.Payments.Where(x => x.PropertyId == propertyId);
        }

        public IEnumerable<Payment> GetAllForProperty(int propertyId, int lastAmount)
        {
            return _db.Payments.Where(x => x.PropertyId == propertyId)
                .OrderByDescending(x => x.DateCreated)
                .Take(lastAmount);
        }
    }
}
