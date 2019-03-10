using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReposirotyPatternDemo
{
    public class PartnerRespository : Repository<Partner>, IPartnerRespository
    {
        public PartnerRespository(DkbsContext context): base(context)
        {

        }
        public IEnumerable<Partner> GetAllPartnersByZipCode(int zipCode)
        {
            return DkbsContext.Partners.Where(p => p.ZipCode == zipCode);
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
