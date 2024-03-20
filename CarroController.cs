using Microsoft.AspNetCore.Mvc;
using ProjectMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjectMVC.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CarroController : Controller
{

    // GET: api/Carro
    [HttpGet]
            public IActionResult GetCarro()
            {
                using (var _context = new ProjectContext())
                {
                    if (_context.Carros.ToList().Count == 0)
                    {
                        return NotFound("Nenhum carro foi encontrado");
                    }
                    return Ok(_context.Carros.ToList());
                    
                }
                
            }

    // GET: api/Carro/5
    [HttpGet("{id}")]
    public IActionResult GetCarro(int id)
    {
        using (var _context = new ProjectContext())
        {
            var carro = _context.Carros.FirstOrDefault(e => e.CodCarro == id);

            if (carro == null)
            {
                return NotFound("Carro não encontrado");
            }

            return Ok(carro);
        }
    }

/*
    [HttpGet("{id}/{nome}")]
    public IActionResult AddAcessorio(int id, string nome)
    {
        using (var _context = new ProjectContext())
        {
            var carro = _context.Carros.FirstOrDefault(e => e.CodCarro == id);
            var acessorio = _context.Acessorios.FirstOrDefault(e => e.NomeAcessorio == nome);

            if (carro == null)
            {
                return NotFound("Carro não encontrado");
            }
            if (acessorio == null)
            {
                return NotFound("Acessorio não encontrado");
            }
            
            new AcessorioCarro(acessorio.CodAcessorio, carro.CodCarro);
            return Ok($"{acessorio.NomeAcessorio} adicionado em {carro.ModeloCarro}");
        }
    }
*/
    // POST: api/Carro
    [HttpPost]
    public IActionResult PostCarro(Carro carro)
    {
        using (var _context = new ProjectContext())
        {
            _context.Carros.Add(carro);
            _context.SaveChanges();

            return Ok($"O carro de nome '{carro.ModeloCarro}' foi criado com sucesso");
        }
    }

    // PUT: api/Carro/5
    [HttpPut("{id}")]
    public IActionResult PutCarro(int id, [FromBody] Carro carro)
    {
        using (var _context = new ProjectContext())
        {
            var item = _context.Carros.FirstOrDefault(e => e.CodCarro == id);
            if (item == null)
            {
                return BadRequest("Carro não encontrado");
            }
            _context.Entry(item).CurrentValues.SetValues(carro);
            _context.SaveChanges();
            return Ok($"Carro de id '{id}' editado com sucesso");
        }
    }

    // DELETE: api/Carro/5
    [HttpDelete("{id}")]
    public IActionResult DeleteCarro(int id)
    {
        using var _context = new ProjectContext();
        var carro = _context.Carros.FirstOrDefault(e => e.CodCarro == id);
        if (carro == null)
        {
            return NotFound($"Carro com id '{id}' não encontrado");
        }

        string chassi = carro.NumChassi;
        _context.Carros.Remove(carro);
        _context.SaveChanges();

        return Ok($"O carro com número de chassi '{chassi}' foi deletado com sucesso");
    }

}