using BackEnd.DTO;
using BackEnd.Services.Interfaces;
using DAL.Interfaces;
using Entities.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace BackEnd.Services.Implementations
{
    public class SupplierService : ISupplierService
    {

        IUnidadDeTrabajo _unidadDeTrabajo;
        public SupplierService(IUnidadDeTrabajo unidad)
        {
            _unidadDeTrabajo = unidad;
        }

        SupplierDTO Convertir(Supplier supplier)
        {
            return new SupplierDTO
            {
                SupplierId = supplier.SupplierId,
                CompanyName = supplier.CompanyName
            };
        } 
        
        Supplier Convertir(SupplierDTO supplier)
        {
            return new Supplier
            {
                SupplierId = supplier.SupplierId,
                CompanyName = supplier.CompanyName
            };
        }

        public SupplierDTO AddSupplier(SupplierDTO supplier)
        {

            
            _unidadDeTrabajo.SupplierDAL.Add(Convertir(supplier));
            _unidadDeTrabajo.Complete();
            return supplier;
        }

        public SupplierDTO DeleteSupplier(int id)
        {
            var Supplier = new Supplier { SupplierId = id };
            _unidadDeTrabajo.SupplierDAL.Remove(Supplier);
            _unidadDeTrabajo.Complete();
            return Convertir(Supplier);
        }

        public List<SupplierDTO> GetCategories()
        {
            var categories = _unidadDeTrabajo.SupplierDAL.Get(); 
            List<SupplierDTO> SupplierDTOs = new List<SupplierDTO>();
            foreach (var supplier in categories)
            {
                SupplierDTOs.Add(this.Convertir(supplier)); 
            }
            return SupplierDTOs;
        }

        public SupplierDTO GetSupplierById(int id)
        {
            var result = _unidadDeTrabajo.SupplierDAL.FindById(id);
            return Convertir(result);
        }

        public SupplierDTO UpdateSupplier(SupplierDTO supplier)
        {
            var entity = Convertir(supplier);
            _unidadDeTrabajo.SupplierDAL.Update(entity);
            _unidadDeTrabajo.Complete();

          

            return supplier;
        }
    }
}
