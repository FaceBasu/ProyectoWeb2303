using BackEnd.Models;
using BackEnd.Services.Interfaces;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipperController : ControllerBase
    {

        public IShipperService _ShipperService;

        private Shipper Convertir(ShipperModel Shipper)
        {
            return new Shipper
            {
                ShipperId = Shipper.ShipperId,
                CompanyName = Shipper.CompanyName,
                Phone = Shipper.Phone
            };
        
        }


        private ShipperModel Convertir(Shipper Shipper)
        {
            return new ShipperModel
            {
                ShipperId = Shipper.ShipperId,
                CompanyName = Shipper.CompanyName,
                Phone = Shipper.Phone
            };

        }

        public ShipperController(IShipperService ShipperService)
        {
                _ShipperService = ShipperService;
        }

        // GET: api/<ShipperController>
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Shipper> lista =  _ShipperService.GetCategoriesAsync().Result; 
            List<ShipperModel> categories =  new List<ShipperModel>();

            foreach (var item in lista)
            {
                categories.Add(Convertir(item));

            }

            return Ok(categories);
        }

        // GET api/<ShipperController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Shipper Shipper = _ShipperService.GetById(id);
            ShipperModel ShipperModel = Convertir(Shipper);

            return Ok(ShipperModel);
        }

        // POST api/<ShipperController>
        [HttpPost]
        public IActionResult Post([FromBody] ShipperModel Shipper)
        {
            Shipper entity = Convertir(Shipper);
            _ShipperService.AddShipper(entity);
            return Ok(Convertir(entity));

        }

        // PUT api/<ShipperController>/5
        [HttpPut]
        public IActionResult Put( [FromBody] ShipperModel Shipper)
        {
            Shipper entity = Convertir(Shipper);
            _ShipperService.UpdateShipper(entity);
            return Ok(Convertir(entity));
        }



        // DELETE api/<ShipperController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Shipper Shipper = new Shipper
            {
                ShipperId = id
            };

            _ShipperService.DeteleShipper(Shipper);

            return Ok();
        }
    }
}
