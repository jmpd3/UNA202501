using BackEnd.DTO;

namespace BackEnd.Services.Interfaces
{
    public interface ISupplierService
    {

        List<SupplierDTO> GetCategories();
        SupplierDTO GetSupplierById(int id);
        SupplierDTO AddSupplier(SupplierDTO supplier);
        SupplierDTO UpdateSupplier(SupplierDTO supplier);
        SupplierDTO DeleteSupplier(int id);
    }
}
