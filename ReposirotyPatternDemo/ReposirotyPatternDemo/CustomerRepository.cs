using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReposirotyPatternDemo
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(DbContext context): base(context)
        {
        }
        public IEnumerable<Customer> GetTopTenCustomers(int count)
        {
            return DkbsContext.Customers.OrderByDescending(c=> c.OrderName).Take(count).ToList();
        }

        public DkbsContext DkbsContext
        {
            get
            {
                return _context as DkbsContext;
            }
        }
    }
}
