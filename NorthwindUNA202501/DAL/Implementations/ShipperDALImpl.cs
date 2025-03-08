using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using Entities.Entities;

namespace DAL.Implementations
{
    public class ShipperDALImpl: GenericDALImpl<Shipper>, IShipperDAL
    {
        NorthWindContext _context;
        public ShipperDALImpl(NorthWindContext context)
            : base(context)
        {
            _context = context;
        }


    }
}
