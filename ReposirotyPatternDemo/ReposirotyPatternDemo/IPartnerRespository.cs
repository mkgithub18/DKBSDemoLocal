using System;
using System.Collections.Generic;
using System.Text;

namespace ReposirotyPatternDemo
{
    public interface IPartnerRespository : IRepository<Partner>
    {
        IEnumerable<Partner> GetAllPartnersByZipCode(int zipCode);
    }
}
