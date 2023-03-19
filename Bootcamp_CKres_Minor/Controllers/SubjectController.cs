﻿using Bootcamp_CKres_Minor.Helper;
using Bootcamp_CKres_Minor.Output;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bootcamp_CKres_Minor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private SubjectHelper subjectHelper;
        public SubjectController(SubjectHelper subjectHelper)
        {
            this.subjectHelper = subjectHelper;
        }

        [HttpGet]
        [Produces("application/json")]
        public IActionResult Get()
        {
            try
            {
                var objJSON = new SubjectOutput();
                objJSON.payload = subjectHelper.GetAllSubjects();
                return new OkObjectResult(objJSON);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
