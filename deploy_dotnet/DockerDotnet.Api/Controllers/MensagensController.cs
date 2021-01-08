using System.Threading.Tasks;
using DockerDotnet.Api.Context;
using DockerDotnet.Api.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DockerDotnet.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class MensagensController : ControllerBase
    {

       // private readonly MyContext _context;

        // public MensagensController(MyContext context)
        // {
        //     _context = context;
        // }

        [HttpPost]
        [Route("")]
        public IActionResult Post(Mensagem mensagem)
        {
            // await _context.AddAsync(mensagem);
            // await _context.SaveChangesAsync();
            mensagem.Id = 1;
            return Created("", mensagem);
        }

        [HttpGet]
        [Route("")]
        public IActionResult Get()
        {
            //var mensagens = await _context.Mensagens.ToListAsync();
            //return Ok(mensagens);
            return Ok(new Mensagem { Id = 1, Texto = "sda" });
        }

    }
}
