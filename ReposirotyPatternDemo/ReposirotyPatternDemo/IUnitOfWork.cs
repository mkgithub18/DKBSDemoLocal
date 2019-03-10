using System;
using System.Collections.Generic;
using System.Text;

namespace ReposirotyPatternDemo
{
    public interface IUnitOfWork : IDisposable
    {
        ICustomerRepository Customers { get; }
        int Complete();

    }
}
