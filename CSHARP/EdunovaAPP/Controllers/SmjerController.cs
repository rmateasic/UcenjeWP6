using EdunovaAPP.Data;
using Microsoft.AspNetCore.Mvc;

namespace EdunovaAPP.Controllers
{

    [ApiController]
    [Route("api/[controller]")]

    public class SmjerController : ControllerBase
    {
        private readonly EdunovaContekst _context;

        public SmjerController(EdunovaContekst context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_context.Smjerovi);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }

        }


    }

}
