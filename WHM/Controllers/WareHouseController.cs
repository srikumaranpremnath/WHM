using ApplicationLayer.Modules.WareHouseApplication;
using Microsoft.AspNetCore.Mvc;

namespace WHM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WareHouseController : Controller
    {
        private readonly WareHouseApplication wareHouseApplication;

        public WareHouseController(WareHouseApplication wareHouseApplication)
        {
            this.wareHouseApplication = wareHouseApplication;
        }

        [HttpGet("Get")]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await wareHouseApplication.GetAllAsync());
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetAllAsync(int id)
        {
            return Ok(await wareHouseApplication.GetByIdAsync(id));
        }
    }
}
