using System.ComponentModel.DataAnnotations.Schema;
using desafioBrunSker.Models;

namespace desafioBrunSker.DTOs
{
    public class ImobiliariaDTO
    { 
        public int Id { get; set; } 
        public string Cep { get; set; } 
        public string Logradouro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Bairro { get; set; }
        public string Proprietario { get; set; }

        public Imobiliaria ToEntity()
        {
            return new Imobiliaria{
                Id = Id,
                Cep = Cep,
                Logradouro = Logradouro,
                Cidade = Cidade,
                Estado = Estado,
                Bairro = Bairro,
                Proprietario = Proprietario
            };
        }
    }
}