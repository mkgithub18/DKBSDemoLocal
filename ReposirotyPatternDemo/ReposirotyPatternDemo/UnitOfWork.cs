using System;
using System.Collections.Generic;
using System.Text;

namespace ReposirotyPatternDemo
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DkbsContext _context;

        public ICustomerRepository Customers { get; }
        public IPartnerRespository Partners { get; }

        public UnitOfWork(DkbsContext context)
        {
            _context = context;
            Customers = new CustomerRepository(context);
            Partners = new PartnerRespository(context);
        }
        public int Complete()
        {
           return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
