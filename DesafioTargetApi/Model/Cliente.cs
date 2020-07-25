using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioTargetApi.Model
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public DateTime DataNascimento{ get; set; }

        public List<Endereco> Enderecos { get; set; }


    }
}
