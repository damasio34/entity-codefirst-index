using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityCodeFirstIndex
{
    public class Cliente
    {
        public int Id { get; set; }
        [Index("NomeCliente", IsUnique = true)]        
        [MaxLength(100)]
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
    }
}
