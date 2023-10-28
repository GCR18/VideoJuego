using Microsoft.AspNetCore.Mvc;
using WebApplication2.Context;
using WebApplication2.Models;
namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class EmailController : ControllerBase
    {
        private readonly ILogger<EmailController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public EmailController(
            ILogger<EmailController> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        [Route("")]
        [HttpPost]
        public IActionResult PostEmail(
            [FromBody] Email email)
        {
            _aplicacionContexto.Email.Add(email);
            _aplicacionContexto.SaveChanges();
            return Ok(email);
        }
      
        [Route("")]
        [HttpGet]
        public IEnumerable<Email> GetEmail()
        {
            return _aplicacionContexto.Email.ToList();
        }
       
        [Route("id")]
        [HttpPut]
        public IActionResult PutDocente([FromBody] Email email)
        {
            _aplicacionContexto.Email.Update(email);
            _aplicacionContexto.SaveChanges();
            return Ok(email);
        }
        [Route("id")]
        [HttpDelete]
        public IActionResult DeleteDocente(int emailID)
        {
            _aplicacionContexto.Email.Remove(_aplicacionContexto.Email.ToList().Where(x => x.idEmail == emailID).FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(emailID);
        }
    }
}
