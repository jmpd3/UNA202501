using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using Entities.Entities;

namespace DAL.Implementations
{
    public class SupplierDALImpl: GenericDALImpl<Supplier>, ISupplierDAL
    {
        NorthWindContext _context;
        public SupplierDALImpl(NorthWindContext context)
            : base(context)
        {
            _context = context;
        }


    }
}
