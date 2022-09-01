using Application.Abstract.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProductService service;
        public ProductController(IProductService _service)
        {
            service = _service;
        }

        [HttpGet]
        [Route("GetList")]
        public IActionResult Get()
        {
            var result = service.getAll();
            return Ok(result);
        }


        [HttpPost]
        [Route("Add")]
        public IActionResult Add([FromBody] Product record)
        {
            var result =service.add(record);
            return Ok(result);
        }
    }
}
