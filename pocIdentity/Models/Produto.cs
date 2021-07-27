using System;

namespace pocIdentity.Models
{
    public class Produto
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataInclusao { get; set; }
    }
}
