using FinanceSavings.API.Entities;
using FinanceSavings.API.Models;
using FinanceSavings.API.Persistence;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FinanceSavings.API.Controllers
{
    [ApiController]
    [Route("api/objetivos-financeiros")]
    public class ObjetivosFinanceirosController : ControllerBase
    {
        private readonly FinanceSavingsContext _context;
        public ObjetivosFinanceirosController(FinanceSavingsContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var objetivos = _context.Objetivos;


            return Ok(objetivos);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {

            var objetivo = _context.Objetivos.SingleOrDefault(p => p.Id == id);

            if (objetivo == null)
                return NotFound("Objetive not found");

            return Ok(objetivo);
        }

        [HttpPost]
        public IActionResult Create(ObjetivoFinanceiroInputModel model)
        {
            var objetivo = new ObjetivoFinanceiro(model.Titulo, model.Descricao, model.ValorObjetivo);

            _context.Objetivos.Add(objetivo);

            var id = objetivo.Id;

            return CreatedAtAction("GetById", new { id = id }, model );
        }

        [HttpPost("{id}/operacoes")]
        public IActionResult CreateOperations(int id, OperacaoInputModel model)
        {
            var operacao = new Operacao(model.Valor, model.Operacao);

            var objetivo = _context.Objetivos.SingleOrDefault(p => p.Id == id);

            objetivo.RealizarOperacao(operacao);

            if (objetivo == null)
                return NotFound();

            return NoContent();
        }

    }
}
