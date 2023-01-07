using HMS.DAL.Interfaces.Repository;
using HMS.DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace HMS.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalTypeController : ControllerBase
    {
        private readonly IHospitalTypeRepository _hospitalTypeRepository;
        public HospitalTypeController(IHospitalTypeRepository hospitalTypeRepository)
        {
            _hospitalTypeRepository = hospitalTypeRepository;
        }
        [HttpPost]
        public IActionResult Create(HospitalType hospitalType)
        {
            if (hospitalType != null)
            {
                _hospitalTypeRepository.CreateHospitalType(hospitalType);
                return Ok(hospitalType);
            }
            return BadRequest();
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var hospitalTypeList = _hospitalTypeRepository.GetAllHospitalTypes();
            if (hospitalTypeList != null && hospitalTypeList.Any())
            {
                return Ok(hospitalTypeList);

            }
            return NoContent();
        }
        [HttpGet("{id}")]
        public IActionResult GetHospitalTypeById(int? id)
        {
            if (id!=null)
            {
                var hospitalType = _hospitalTypeRepository.GetHospitalTypeById(id);
                return Ok(hospitalType);
            }
            return NotFound();
        }
    }
}
