﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using Entities.Entities;

namespace DAL.Implementations
{
    public class UnidadDeTrabajo : IUnidadDeTrabajo
    {
        public ICategoryDAL CategoryDAL { get; set; }
        public IShipperDAL ShipperDAL { get; set; } 
        public ISupplierDAL SupplierDAL { get; set; }
        NorthWindContext context;

        public UnidadDeTrabajo(ICategoryDAL categoryDAL, NorthWindContext context
            , IShipperDAL shipperDAL, ISupplierDAL supplierDAL)
        {
            CategoryDAL = categoryDAL;
            this.context = context;
            ShipperDAL = shipperDAL;
            SupplierDAL = supplierDAL;
        }
        public void Dispose()
        {
            this.context.Dispose();
        }

        public void Complete()
        {
            context.SaveChanges();
        }
    }
}
