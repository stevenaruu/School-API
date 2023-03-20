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
    public class GenderController : ControllerBase
    {
        private GenderHelper genderHelper;
        public GenderController(GenderHelper genderHelper)
        {
            this.genderHelper = genderHelper;
        }

        [HttpGet]
        [Produces("application/json")]
        public IActionResult Get()
        {
            try
            {
                var objJSON = new GenderOutput();
                objJSON.payload = genderHelper.GetAllGenders();
                return new OkObjectResult(objJSON);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
