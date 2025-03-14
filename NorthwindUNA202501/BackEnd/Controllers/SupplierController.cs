using BackEnd.DTO;
using BackEnd.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        ISupplierService _supplierService;
        public SupplierController(ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }
        // GET: api/<SupplierController>
        [HttpGet]
        public IEnumerable<SupplierDTO> Get()
        {
            return _supplierService.GetCategories();
        }   

        // GET api/<SupplierController>/5
        [HttpGet("{id}")]
        public SupplierDTO Get(int id)
        {
            return _supplierService.GetSupplierById(id);
        }

        // POST api/<SupplierController>
        [HttpPost]
        public void Post([FromBody] SupplierDTO supplier)
        {
            _supplierService.AddSupplier(supplier);

        }

        // PUT api/<SupplierController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] SupplierDTO supplier)
        {
            _supplierService.UpdateSupplier(supplier);
        }

        // DELETE api/<SupplierController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _supplierService.DeleteSupplier(id);
        }
    }
}
