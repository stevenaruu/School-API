using Bootcamp_CKres_Minor.Helper;
using Bootcamp_CKres_Minor.Output;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bootcamp_CKres_Minor.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class ReligionController : ControllerBase
    {
        private ReligionHelper religionHelper;
        public ReligionController(ReligionHelper religionHelper)
        {
            this.religionHelper = religionHelper;
        }

        [HttpGet]
        [Produces("application/json")]
        public IActionResult Get()
        {
            try
            {
                var objJSON = new ReligionOutput();
                objJSON.payload = religionHelper.GetAllReligions();
                return new OkObjectResult(objJSON);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
