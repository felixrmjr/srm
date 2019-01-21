using SRM.Domain.Entities;
using SRM.Domain.Interfaces.Applications;
using SRM.Repository;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SRM.App
{
    public partial class FrmCliente : Form
    {
        private readonly IClienteApplication<SRMContext> _clienteApplication;

        public FrmCliente(IClienteApplication<SRMContext> application)
        {
            _clienteApplication = application;

            InitializeComponent();
        }

        private void btnConsultaPesquisar_Click(object sender, EventArgs e)
        {
            var dados = _clienteApplication.GetClientes(txtConsultaNome.Text).ToList();
            grdDados.DataSource = dados;
        }

        private void btnCadastroSalvar_Click(object sender, EventArgs e)
        {
            var dados = new Cliente
            {
                Nome = txtCadastroNome.Text,
                Email = txtCadastroEmail.Text,
                Telefone = txtCadastroTelefone.Text,
                LimiteCompra = decimal.Parse(txtCadastroLimite.Text)
            };
            _clienteApplication.Salvar(dados);
        }
    }
}
