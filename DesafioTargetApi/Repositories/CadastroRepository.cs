using DesafioTargetApi.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DesafioTargetApi.Repositories
{
    public class CadastroRepository : BaseRepository, ICadastroRepository
    {
        public CadastroRepository(DesafioTargetContext context) : base(context)
        {
        }

        //Função inserir cliente
        public void SaveCliente(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        //Função Atualizar cliente
        public void UpdateCliente(Cliente cliente)
        {
            if(cliente.Id != 0) {
                _context.Clientes.Update(cliente);
                _context.SaveChanges();
            }
        }

        //Função deletar um único cliente
        public void DeleteCliente(int? id)
        {
            Cliente cliente = new Cliente();
            List<Endereco> enderecos = new List<Endereco>();
            cliente = _context.Clientes.SingleOrDefault(c => c.Id == id);
            enderecos = _context.Enderecos.Where(e => e.Cliente == cliente).ToList();

            _context.Enderecos.RemoveRange(enderecos);
            _context.Clientes.Remove(cliente);
            _context.SaveChanges();
        }

        //Função Deletar um único endereço do cliente
        public void DeleteEndereco(int? id)
        {
            Endereco endereco = new Endereco();
            endereco = _context.Enderecos.SingleOrDefault(e => e.Id == id);

            _context.Enderecos.Remove(endereco);
            _context.SaveChanges();
        }

        //Função obter Cliente
        public Cliente GetCliente(int? id)
        {
            return _context.Clientes.Include(e => e.Enderecos).SingleOrDefault(c => c.Id == id);
        }

        //Função Obter todos os clientes
        public List<Cliente> GetClientes()
        {
            return _context.Clientes.Include(e => e.Enderecos).ToList();
        }


    }
}
