using desafioBrunSker.Services;
using desafioBrunSker.DTOs;
using desafioBrunSker.Models;
using Microsoft.AspNetCore.Mvc;

namespace desafioBrunSker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ImobiliariaController : ControllerBase
    {
        private readonly IImobiliariaService _imobiliariaService;

        public ImobiliariaController(IImobiliariaService imobiliariaService)
        {
            _imobiliariaService = imobiliariaService;
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            return Ok(_imobiliariaService.GetById(id));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_imobiliariaService.GetAll());
        }

        [HttpPost]
        public IActionResult Create([FromBody] ImobiliariaDTO imobiliariaDTO)
        {
            Imobiliaria imobiliaria = imobiliariaDTO.ToEntity();

            return Ok(_imobiliariaService.Create(imobiliaria));
        }
    }
}