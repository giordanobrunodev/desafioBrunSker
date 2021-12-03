using System.ComponentModel.DataAnnotations.Schema;

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
    }
}