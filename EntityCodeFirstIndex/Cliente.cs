using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityCodeFirstIndex
{
    public class Cliente
    {
        public int Id { get; set; }
        [Index("NomeCliente", IsUnique = true, Order = 1)]
        [MaxLength(50)]
        public string Nome { get; set; }
        [Index("NomeCliente", IsUnique = true, Order = 2)]
        [MaxLength(50)]
        public string Sobrenome { get; set; }
    }
}
