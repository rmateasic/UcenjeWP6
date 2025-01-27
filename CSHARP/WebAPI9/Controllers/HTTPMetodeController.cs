using Microsoft.AspNetCore.Mvc;
using WebAPI9.Models;

namespace WebAPI9.Controllers
{


   
    [ApiController]
    [Route("api/v1/[controller]")]
    public class HTTPMetodeController : ControllerBase
    {

        // Počinje ruta

        
        [HttpGet]
        public string HelloWorld()
        {
            return "Hello World!";
        }

        // Završava ruta



        // Počinje ruta

        
        [HttpGet]
        [Route("Hello world")]
        public string HelloWorld(string ime)
        {
            return $"Hello {ime}!";
        }

        // Završava ruta


        // Počinje ruta

       
        [HttpGet]
        [Route("json")]
        public IActionResult Json(int sifra, string ime)
        {
            return Ok(new { sifra = sifra, ime = ime });
        }

        // Završava ruta


        // Počinje ruta

        
        [HttpPost]
        public IActionResult Post(Osoba osoba)
        {
            osoba.Ime = "Hello " + osoba.Ime;
            return StatusCode(201, osoba);
        }

        // Završava ruta



        // Počinje ruta

        
        [HttpPut]
        public IActionResult Put(Osoba osoba)
        {
            osoba.Ime = "Hello " + osoba.Ime;
            return StatusCode(StatusCodes.Status206PartialContent, osoba);
        }

        // Završava ruta



        // Počinje ruta

        
        [HttpDelete]
        public IActionResult Delete(int sifra)
        {
            if (sifra <= 0)
            {
                return StatusCode(StatusCodes.Status400BadRequest, new { poruka = "Šifra mora biti veća od 0" });
            }

            return StatusCode(StatusCodes.Status204NoContent);
        }

        // Završava ruta
    }
}
