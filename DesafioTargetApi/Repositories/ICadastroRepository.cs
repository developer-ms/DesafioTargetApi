using DesafioTargetApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioTargetApi.Repositories
{
    public interface ICadastroRepository
    {
        void SaveCliente(Cliente cliente);
        void UpdateCliente(Cliente cliente);
        void DeleteCliente(int? id);
        void DeleteEndereco(int? id);
        Cliente GetCliente(int? id);
        List<Cliente> GetClientes();
    }
}
