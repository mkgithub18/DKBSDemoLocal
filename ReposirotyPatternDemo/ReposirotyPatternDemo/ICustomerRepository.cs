using System;
using System.Collections.Generic;
using System.Text;

namespace ReposirotyPatternDemo
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        IEnumerable<Customer> GetTopTenCustomers(int count);
    }
}
