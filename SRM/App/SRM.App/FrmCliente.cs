using SRM.Domain.Entities;
using SRM.Domain.Interfaces.Applications;
using SRM.Repository;
using System;
using System.Collections.Generic;
using System.IO;
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

        private void btnImportacaoImportar_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Selecionar Planilha",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "csv",
                Filter = "csv files (*.csv)|*.csv",
                FilterIndex = 2,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };


            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var linhas = File.ReadAllLines(dialog.FileName).Skip(1).Select(x => x.Split(';'));

                var lista = linhas.Select(x => new 
                {
                    Nome = x[0],
                    Email = x[1],
                    Telefone = x[2],
                    LimiteCompra = decimal.Parse(x[3])
                }).ToList();

                grdImportacao.DataSource = lista;
            }
        }

        private void btnImportacaoGravar_Click(object sender, EventArgs e)
        {
            var teste = grdImportacao.DataSource as List<Cliente>;
        }
    }
}
