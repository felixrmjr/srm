using SRM.Domain.Entities;
using SRM.Domain.Exceptions;
using SRM.Domain.Interfaces.Applications;
using SRM.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

            pesquisar();
        }

        private void btnConsultaPesquisar_Click(object sender, EventArgs e)
        {
            pesquisar();
        }

        private void btnCadastroSalvar_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente();
            cliente.AtualizarNome(txtCadastroNome.Text);
            cliente.AtualizarEmail(txtCadastroEmail.Text);
            cliente.AtualizarTelefone(txtCadastroTelefone.Text);
            cliente.AtualizarLimiteCompra(txtCadastroLimite.Text);

            try
            {
                cliente.Validate();
                _clienteApplication.Salvar(cliente);
                MessageBox.Show("Dados inseridos com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpar();
                pesquisar();
            }
            catch (DomainSummaryException ex)
            {
                var erro = new StringBuilder("Corrija os erros abaixo: \n\n");

                foreach (var item in ex.Exceptions)
                {
                    switch (item.Message)
                    {
                        case "campoObrigatorio":
                            erro.AppendFormat("O campo {0} não pode ser vázio.\n", item.Arguments[0]);
                            break;
                        case "formatoInvalido":
                            erro.AppendFormat("O campo {0} está em formato inválido.\n", item.Arguments[0]);
                            break;
                    }
                }

                MessageBox.Show(erro.ToString(), "Dados inconsistentes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImportacaoImportar_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Selecionar CSV",
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
                var dados = _clienteApplication.LerArquivo(dialog.FileName);
                grdImportacao.DataSource = dados.Dados;

                lblImportacaoArquivoNome.Text = $"Arquivo: {dialog.FileName}";
                lblImportacaoRegistrosTotal.Text = $"Total de registros: {(dados.Sucessos + dados.Falhas)}";
                lblImportacaoRegistrosSucesso.Text = $"Registros importados com sucesso: {dados.Sucessos}";
                lblImportacaoRegistrosErro.Text = $"Registros com erro: {dados.Falhas}";
            }
        }

        private void btnImportacaoGravar_Click(object sender, EventArgs e)
        {
            var clientes = grdImportacao.DataSource as List<Cliente>;
            _clienteApplication.Salvar(clientes);

            lblImportacaoArquivoNome.Text = "Arquivo: ";
            lblImportacaoRegistrosTotal.Text = "Total de registros: ";
            lblImportacaoRegistrosSucesso.Text = "Registros importados com sucesso: ";
            lblImportacaoRegistrosErro.Text = "Registros com erro: ";

            grdImportacao.DataSource = null;

            pesquisar();
        }

        private void txtCadastroTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (txtCadastroTelefone.MaskFull)
            {
                toolTipTelefone.ToolTipTitle = "Telefone inválido";
                toolTipTelefone.Show("Número muito grande", txtCadastroTelefone, 0, -20, 5000);
            }
            else if (e.Position == txtCadastroTelefone.Mask.Length)
            {
                toolTipTelefone.ToolTipTitle = "Telefone inválido";
                toolTipTelefone.Show("Você não pode adicionar caracteres extras ao final deste campo.", txtCadastroTelefone, 0, -20, 5000);
            }
            else
            {
                toolTipTelefone.ToolTipTitle = "Telefone inválido";
                toolTipTelefone.Show("Você só pode adicionar caracteres numéricos (0 a 9)", txtCadastroTelefone, 0, -20, 5000);
            }
        }

        private void txtCadastroTelefone_KeyDown(object sender, KeyEventArgs e)
        {
            toolTipTelefone.Hide(txtCadastroTelefone);
        }

        private void pesquisar()
        {
            var dados = _clienteApplication.GetClientes(txtConsultaNome.Text).ToList();
            grdDados.DataSource = dados;
            tabCliente.SelectedIndex = 0;
        }

        private void limpar()
        {
            txtCadastroNome.Text = string.Empty;
            txtCadastroEmail.Text = string.Empty;
            txtCadastroTelefone.Text = string.Empty;
            txtCadastroLimite.Text = string.Empty;
        }

    }
}
