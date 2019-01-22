using System;
using System.Text.RegularExpressions;

namespace SRM.Domain.Entities
{
    public class Cliente : EntityBase
    {
        #region [ Propriedades ]

        public int Id { get; protected set; }
        public string Nome { get; protected set; }
        public string Email { get; protected set; }
        public string Telefone { get; protected set; }
        public decimal LimiteCompra { get; protected set; }
        public DateTime DataCadastro { get; protected set; }

        #endregion

        #region [ Construtores ]

        public Cliente()
        {
            LimiteCompra = 0;
            DataCadastro = DateTime.Now;
        }

        public Cliente(string nome, string email, string telefone, decimal limite) : this()
        {
            AtualizarNome(nome);
            AtualizarEmail(email);
            AtualizarTelefone(telefone);
            AtualizarLimiteCompra(limite);
        }

        public Cliente(string nome, string email, string telefone, string limite) : this()
        {
            AtualizarNome(nome);
            AtualizarEmail(email);
            AtualizarTelefone(telefone);
            AtualizarLimiteCompra(limite);
        }

        #endregion

        #region [ Métodos ]

        public void AtualizarNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                AddException(nameof(Cliente), nameof(AtualizarNome), "campoObrigatorio", nameof(nome));

            var regex = new Regex(@"^[a-zA-Z\u00C0-\u017F´]+\s+[a-zA-Z\u00C0-\u017F´]{0,}$");

            if (!regex.IsMatch(nome))
                AddException(nameof(Cliente), nameof(AtualizarNome), "formatoInvalido", nameof(nome));

            Nome = nome;
        }

        public void AtualizarEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                AddException(nameof(Cliente), nameof(AtualizarEmail), "campoObrigatorio", nameof(email));

            var regex = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (!regex.IsMatch(email))
                AddException(nameof(Cliente), nameof(AtualizarEmail), "formatoInvalido", nameof(email));

            Email = email;
        }

        public void AtualizarTelefone(string telefone)
        {
            if (string.IsNullOrWhiteSpace(telefone))
                AddException(nameof(Cliente), nameof(AtualizarTelefone), "campoObrigatorio", nameof(telefone));

            var regex = new Regex(@"^\([1-9]{2}\) (?:[2-8]|9[1-9])[0-9]{3}\-[0-9]{4}$");

            if (!regex.IsMatch(telefone))
                AddException(nameof(Cliente), nameof(AtualizarTelefone), "formatoInvalido", nameof(telefone));

            Telefone = telefone;
        }

        public void AtualizarLimiteCompra(decimal limite)
        {
            LimiteCompra = limite;
        }

        public void AtualizarLimiteCompra(string limite)
        {
            decimal l = 0;

            if (string.IsNullOrWhiteSpace(limite))
                AtualizarLimiteCompra(0);
            else if (!decimal.TryParse(limite, out l))
                AddException(nameof(Cliente), nameof(AtualizarLimiteCompra), "formatoInvalido", nameof(limite));
            else
                AtualizarLimiteCompra(l);
        }

        #endregion
    }
}
