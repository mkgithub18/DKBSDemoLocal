using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReposirotyPatternDemo;

namespace DKBS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        IUnitOfWork _unitOfWork;

        public CustomerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET api/Customer/{name of the customer}
        [HttpGet("{name}")]
        public ActionResult<IEnumerable<Customer>> GetCustomer(string name)
        {
                return _unitOfWork.Customers.Find(c => c.Name.StartsWith(name)).ToList();
        }

    }
}