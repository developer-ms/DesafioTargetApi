using System.Collections.Generic;
using DesafioTargetApi.Model;
using DesafioTargetApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DesafioTargetApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CadastroController : ControllerBase
    {
        private readonly ICadastroRepository _cadastroRepository;

        public CadastroController(ICadastroRepository cadastroRepository)
        {
            _cadastroRepository = cadastroRepository;
        }

        //POST - Cadastro
        //Salva cadastro do cliente
        [HttpPost]
        public void Save([FromBody] Cliente cliente)
        {
            _cadastroRepository.SaveCliente(cliente);
        }

        //PUT - Cadastro
        //Atualiza cadastro do cliente
        [HttpPut]
        public void Update([FromBody] Cliente cliente)
        {
            _cadastroRepository.UpdateCliente(cliente);
        }

        //DELETE - Cadastro
        //Deleta cadastro do cliente
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _cadastroRepository.DeleteCliente(id);
        }

        //DELETE - Cadastro/id 
        //Remove endereço do cliente
        [HttpDelete("{idCliente}/{idEndereco}")]
        public void DeleteEndereco(int idEndereco)
        {
            _cadastroRepository.DeleteEndereco(idEndereco);
        }

        //GET - Cadastro/id
        //Consulta detalhes do cliente
        [HttpGet("{id}")]
        public Cliente GetOne(int id)
        {
            return _cadastroRepository.GetCliente(id);
        }

        //GET - Cadastro
        //Obtém lista de todos os clientes
        [HttpGet]
        public List<Cliente> GetAll()
        {
            return _cadastroRepository.GetClientes();
        }
    }
}
