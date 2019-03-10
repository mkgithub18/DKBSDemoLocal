using Microsoft.EntityFrameworkCore;
using ReposirotyPatternDemo;
using System;

namespace DKBS_Console
{
    // Old way without DI. This is a console example
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var optionsBuilder = new DbContextOptionsBuilder<DkbsContext>();            
            using (var unitOfWork = new UnitOfWork(new DkbsContext(optionsBuilder.Options)))
            {
                var res = unitOfWork.Customers.GetAll();

                foreach (var item in res)
                {
                    Console.WriteLine($"Name of the customer : {item.Name}");
                }
            }
        }
    }
}
