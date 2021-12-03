using System.ComponentModel.DataAnnotations.Schema;
using desafioBrunSker.DTOs;

namespace desafioBrunSker.Models
{
    [Table("tb_imobiliaria")]
    public class Imobiliaria
    { 
        [Column("id")] public int Id { get; set; } 
        [Column("cep")] public string Cep { get; set; } 
        [Column("logradouro")] public string Logradouro { get; set; }
        [Column("cidade")]  public string Cidade { get; set; }
        [Column("estado")] public string Estado { get; set; }
        [Column("bairro")] public string Bairro { get; set; }
        [Column("proprietario")] public string Proprietario { get; set; }

        public ImobiliariaDTO ToDTO()
        {
            return new ImobiliariaDTO{
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