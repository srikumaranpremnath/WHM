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
            return this.PopulateResult(await _wareHouseApplication.GetAllAsync());
        }

        [HttpGet("Get/{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {

            var wareHouse = await _wareHouseApplication.GetByIdAsync(id);
            return this.PopulateResult(wareHouse);
        }

        [HttpPost("Post")]
        public async Task<IActionResult> Post(WareHouseRequest wareHouse)
        {
            var response = await _wareHouseApplication.CreateAsync(wareHouse);
            return this.PopulateResult(response);
        }

        [HttpPut("Put/{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] WareHouseRequest wareHouse)
        {
            var response = await _wareHouseApplication.UpdateAsync(id, wareHouse);
            return this.PopulateResult(response);
        }

        [HttpPut("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _wareHouseApplication.DeleteAsync(id);
            return this.PopulateResult(response);
        }
    }
}
