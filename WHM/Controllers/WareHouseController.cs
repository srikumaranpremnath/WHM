using ApplicationLayer.Modules.WareHouseApplication;
using BusinessObjects.RequestObjects;
using Microsoft.AspNetCore.Mvc;
using static WHM.ActionResultResponse.ActionResultResponse;

namespace WHM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WareHouseController : Controller
    {
        private readonly WareHouseApplication _wareHouseApplication;

        public WareHouseController(WareHouseApplication wareHouseApplication)
        {
            _wareHouseApplication = wareHouseApplication;
        }

        [HttpGet("Get")]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _wareHouseApplication.GetAllAsync());
        }

        [HttpGet("Get/{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {

            var wareHouse = await _wareHouseApplication.GetByIdAsync(id);
            return this.PopulateResult(wareHouse);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Post(CreateWareHouse wareHouse)
        {
            var response = await _wareHouseApplication.Create(wareHouse);
            return this.PopulateResult(response);
        }
    }
}
