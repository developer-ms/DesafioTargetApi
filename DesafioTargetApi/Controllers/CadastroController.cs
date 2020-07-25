using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using DesafioTargetApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace DesafioTargetApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CadastroController : ControllerBase
    {
        private DesafioTargetContext _context;

        public CadastroController(DesafioTargetContext context)
        {
            _context = context;
        }

        [HttpPost]
        public void Inserir([FromBody] Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        [HttpPut]
        public void Atualizar([FromBody] Cliente cliente)
        {
            _context.Clientes.Update(cliente);
            _context.SaveChanges();
        }

        [HttpGet("{id}")]
        public Cliente Consultar(long id)
        {
            return _context.Clientes.Include(e => e.Enderecos).SingleOrDefault(c => c.Id == id);
        }

        [HttpGet()]
        public async Task<ActionResult<List<Cliente>>> Todos()
        {
            return await _context.Clientes.Include(e => e.Enderecos).ToListAsync();
        }
    }
}
