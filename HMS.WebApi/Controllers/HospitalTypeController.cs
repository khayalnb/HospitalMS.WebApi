using HMS.DAL.Interfaces.Repository;
using HMS.DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace HMS.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalTypeController : ControllerBase
    {
        private readonly IHospitalTypeRepository _hospitalTypeRepository;
        public HospitalTypeController(IHospitalTypeRepository hospitalTypeRepository)
        {
            _hospitalTypeRepository= hospitalTypeRepository;
        }
        [HttpPost]
        public IActionResult Create(HospitalType hospitalType)
        {
            if (hospitalType!=null)
            {
                _hospitalTypeRepository.AddHospitalType(hospitalType);
                return Ok(hospitalType);
            }
            return BadRequest();    
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var hospitalTypeList = _hospitalTypeRepository.GetAllHospitalTypes();
            if (hospitalTypeList!=null && hospitalTypeList.Any())
            {
                return Ok(hospitalTypeList);

            }
            return NoContent();
        }
    }
}
