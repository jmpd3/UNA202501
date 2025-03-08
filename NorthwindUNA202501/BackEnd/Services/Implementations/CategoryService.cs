using BackEnd.DTO;
using BackEnd.Services.Interfaces;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace BackEnd.Services.Implementations
{
    public class CategoryService : ICategoryService
    {

        IUnidadDeTrabajo _unidadDeTrabajo;
        public CategoryService(IUnidadDeTrabajo unidad)
        {
            _unidadDeTrabajo = unidad;
        }
        public List<CategoryDTO> GetCategories()
        {
            var categories = _unidadDeTrabajo.CategoryDAL.Get(); 
            List<CategoryDTO> categoryDTOs = new List<CategoryDTO>();
            foreach (var category in categories)
            {
                categoryDTOs.Add(new CategoryDTO
                {
                    CategoryId = category.CategoryId,
                    CategoryName = category.CategoryName
                }); 
            }
            return categoryDTOs;
        }
    }
}
