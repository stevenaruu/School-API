using Bootcamp_CKres_Minor.Helper;
using Bootcamp_CKres_Minor.Output;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bootcamp_CKres_Minor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradeController : ControllerBase
    {
        private GradeHelper gradeHelper;
        public GradeController(GradeHelper gradeHelper)
        {
            this.gradeHelper = gradeHelper;
        }

        [HttpGet]
        [Produces("application/json")]
        public IActionResult Get()
        {
            try
            {
                var objJSON = new GradeOutput();
                objJSON.payload = gradeHelper.GetAllGrades();
                return new OkObjectResult(objJSON);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
