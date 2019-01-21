using System;

namespace SRM.Domain.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public decimal LimiteCompra { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
