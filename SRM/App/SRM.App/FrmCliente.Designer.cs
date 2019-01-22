namespace SRM.App
{
    partial class FrmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabCliente = new System.Windows.Forms.TabControl();
            this.tabConsulta = new System.Windows.Forms.TabPage();
            this.grdDados = new System.Windows.Forms.DataGridView();
            this.btnConsultaPesquisar = new System.Windows.Forms.Button();
            this.txtConsultaNome = new System.Windows.Forms.TextBox();
            this.lblConsultaNome = new System.Windows.Forms.Label();
            this.tabCadastro = new System.Windows.Forms.TabPage();
            this.lblCadastroLimite = new System.Windows.Forms.Label();
            this.lblCadastroNome = new System.Windows.Forms.Label();
            this.lblCadastroTelefone = new System.Windows.Forms.Label();
            this.txtCadastroEmail = new System.Windows.Forms.TextBox();
            this.lblCadastroEmail = new System.Windows.Forms.Label();
            this.btnCadastroSalvar = new System.Windows.Forms.Button();
            this.txtCadastroNome = new System.Windows.Forms.TextBox();
            this.tabImportacao = new System.Windows.Forms.TabPage();
            this.btnImportacaoGravar = new System.Windows.Forms.Button();
            this.grdImportacao = new System.Windows.Forms.DataGridView();
            this.btnImportacaoImportar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LimiteCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblImportacaoArquivoNome = new System.Windows.Forms.Label();
            this.lblImportacaoRegistrosSucesso = new System.Windows.Forms.Label();
            this.lblImportacaoRegistrosErro = new System.Windows.Forms.Label();
            this.lblImportacaoRegistrosTotal = new System.Windows.Forms.Label();
            this.txtCadastroTelefone = new System.Windows.Forms.MaskedTextBox();
            this.toolTipTelefone = new System.Windows.Forms.ToolTip(this.components);
            this.txtCadastroLimite = new System.Windows.Forms.NumericUpDown();
            this.tabCliente.SuspendLayout();
            this.tabConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).BeginInit();
            this.tabCadastro.SuspendLayout();
            this.tabImportacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdImportacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCadastroLimite)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCliente
            // 
            this.tabCliente.Controls.Add(this.tabConsulta);
            this.tabCliente.Controls.Add(this.tabCadastro);
            this.tabCliente.Controls.Add(this.tabImportacao);
            this.tabCliente.Location = new System.Drawing.Point(13, 13);
            this.tabCliente.Name = "tabCliente";
            this.tabCliente.SelectedIndex = 0;
            this.tabCliente.Size = new System.Drawing.Size(759, 361);
            this.tabCliente.TabIndex = 0;
            // 
            // tabConsulta
            // 
            this.tabConsulta.Controls.Add(this.grdDados);
            this.tabConsulta.Controls.Add(this.btnConsultaPesquisar);
            this.tabConsulta.Controls.Add(this.txtConsultaNome);
            this.tabConsulta.Controls.Add(this.lblConsultaNome);
            this.tabConsulta.Location = new System.Drawing.Point(4, 22);
            this.tabConsulta.Name = "tabConsulta";
            this.tabConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsulta.Size = new System.Drawing.Size(751, 335);
            this.tabConsulta.TabIndex = 0;
            this.tabConsulta.Text = "Consulta";
            this.tabConsulta.UseVisualStyleBackColor = true;
            // 
            // grdDados
            // 
            this.grdDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDados.Location = new System.Drawing.Point(12, 53);
            this.grdDados.Name = "grdDados";
            this.grdDados.Size = new System.Drawing.Size(730, 274);
            this.grdDados.TabIndex = 7;
            // 
            // btnConsultaPesquisar
            // 
            this.btnConsultaPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaPesquisar.Location = new System.Drawing.Point(356, 25);
            this.btnConsultaPesquisar.Name = "btnConsultaPesquisar";
            this.btnConsultaPesquisar.Size = new System.Drawing.Size(75, 22);
            this.btnConsultaPesquisar.TabIndex = 3;
            this.btnConsultaPesquisar.Text = "Pesquisar";
            this.btnConsultaPesquisar.UseVisualStyleBackColor = true;
            this.btnConsultaPesquisar.Click += new System.EventHandler(this.btnConsultaPesquisar_Click);
            // 
            // txtConsultaNome
            // 
            this.txtConsultaNome.Location = new System.Drawing.Point(12, 26);
            this.txtConsultaNome.Name = "txtConsultaNome";
            this.txtConsultaNome.Size = new System.Drawing.Size(338, 20);
            this.txtConsultaNome.TabIndex = 2;
            // 
            // lblConsultaNome
            // 
            this.lblConsultaNome.AutoSize = true;
            this.lblConsultaNome.Location = new System.Drawing.Point(9, 9);
            this.lblConsultaNome.Name = "lblConsultaNome";
            this.lblConsultaNome.Size = new System.Drawing.Size(38, 13);
            this.lblConsultaNome.TabIndex = 1;
            this.lblConsultaNome.Text = "Nome:";
            // 
            // tabCadastro
            // 
            this.tabCadastro.Controls.Add(this.txtCadastroLimite);
            this.tabCadastro.Controls.Add(this.txtCadastroTelefone);
            this.tabCadastro.Controls.Add(this.lblCadastroLimite);
            this.tabCadastro.Controls.Add(this.lblCadastroNome);
            this.tabCadastro.Controls.Add(this.lblCadastroTelefone);
            this.tabCadastro.Controls.Add(this.txtCadastroEmail);
            this.tabCadastro.Controls.Add(this.lblCadastroEmail);
            this.tabCadastro.Controls.Add(this.btnCadastroSalvar);
            this.tabCadastro.Controls.Add(this.txtCadastroNome);
            this.tabCadastro.Location = new System.Drawing.Point(4, 22);
            this.tabCadastro.Name = "tabCadastro";
            this.tabCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastro.Size = new System.Drawing.Size(751, 335);
            this.tabCadastro.TabIndex = 1;
            this.tabCadastro.Text = "Cadastro";
            this.tabCadastro.UseVisualStyleBackColor = true;
            // 
            // lblCadastroLimite
            // 
            this.lblCadastroLimite.AutoSize = true;
            this.lblCadastroLimite.Location = new System.Drawing.Point(11, 108);
            this.lblCadastroLimite.Name = "lblCadastroLimite";
            this.lblCadastroLimite.Size = new System.Drawing.Size(87, 13);
            this.lblCadastroLimite.TabIndex = 10;
            this.lblCadastroLimite.Text = "Limite de compra";
            // 
            // lblCadastroNome
            // 
            this.lblCadastroNome.AutoSize = true;
            this.lblCadastroNome.Location = new System.Drawing.Point(63, 30);
            this.lblCadastroNome.Name = "lblCadastroNome";
            this.lblCadastroNome.Size = new System.Drawing.Size(35, 13);
            this.lblCadastroNome.TabIndex = 4;
            this.lblCadastroNome.Text = "Nome";
            // 
            // lblCadastroTelefone
            // 
            this.lblCadastroTelefone.AutoSize = true;
            this.lblCadastroTelefone.Location = new System.Drawing.Point(49, 82);
            this.lblCadastroTelefone.Name = "lblCadastroTelefone";
            this.lblCadastroTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblCadastroTelefone.TabIndex = 8;
            this.lblCadastroTelefone.Text = "Telefone";
            // 
            // txtCadastroEmail
            // 
            this.txtCadastroEmail.Location = new System.Drawing.Point(104, 53);
            this.txtCadastroEmail.Name = "txtCadastroEmail";
            this.txtCadastroEmail.Size = new System.Drawing.Size(633, 20);
            this.txtCadastroEmail.TabIndex = 7;
            // 
            // lblCadastroEmail
            // 
            this.lblCadastroEmail.AutoSize = true;
            this.lblCadastroEmail.Location = new System.Drawing.Point(66, 56);
            this.lblCadastroEmail.Name = "lblCadastroEmail";
            this.lblCadastroEmail.Size = new System.Drawing.Size(32, 13);
            this.lblCadastroEmail.TabIndex = 6;
            this.lblCadastroEmail.Text = "Email";
            // 
            // btnCadastroSalvar
            // 
            this.btnCadastroSalvar.Location = new System.Drawing.Point(662, 148);
            this.btnCadastroSalvar.Name = "btnCadastroSalvar";
            this.btnCadastroSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastroSalvar.TabIndex = 12;
            this.btnCadastroSalvar.Text = "Salvar";
            this.btnCadastroSalvar.UseVisualStyleBackColor = true;
            this.btnCadastroSalvar.Click += new System.EventHandler(this.btnCadastroSalvar_Click);
            // 
            // txtCadastroNome
            // 
            this.txtCadastroNome.Location = new System.Drawing.Point(104, 27);
            this.txtCadastroNome.Name = "txtCadastroNome";
            this.txtCadastroNome.Size = new System.Drawing.Size(633, 20);
            this.txtCadastroNome.TabIndex = 5;
            // 
            // tabImportacao
            // 
            this.tabImportacao.Controls.Add(this.lblImportacaoRegistrosTotal);
            this.tabImportacao.Controls.Add(this.lblImportacaoRegistrosErro);
            this.tabImportacao.Controls.Add(this.lblImportacaoRegistrosSucesso);
            this.tabImportacao.Controls.Add(this.lblImportacaoArquivoNome);
            this.tabImportacao.Controls.Add(this.btnImportacaoGravar);
            this.tabImportacao.Controls.Add(this.grdImportacao);
            this.tabImportacao.Controls.Add(this.btnImportacaoImportar);
            this.tabImportacao.Location = new System.Drawing.Point(4, 22);
            this.tabImportacao.Name = "tabImportacao";
            this.tabImportacao.Padding = new System.Windows.Forms.Padding(3);
            this.tabImportacao.Size = new System.Drawing.Size(751, 335);
            this.tabImportacao.TabIndex = 2;
            this.tabImportacao.Text = "Importação";
            this.tabImportacao.UseVisualStyleBackColor = true;
            // 
            // btnImportacaoGravar
            // 
            this.btnImportacaoGravar.Location = new System.Drawing.Point(569, 13);
            this.btnImportacaoGravar.Name = "btnImportacaoGravar";
            this.btnImportacaoGravar.Size = new System.Drawing.Size(176, 23);
            this.btnImportacaoGravar.TabIndex = 14;
            this.btnImportacaoGravar.Text = "Gravar";
            this.btnImportacaoGravar.UseVisualStyleBackColor = true;
            this.btnImportacaoGravar.Click += new System.EventHandler(this.btnImportacaoGravar_Click);
            // 
            // grdImportacao
            // 
            this.grdImportacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdImportacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Email,
            this.Telefone,
            this.LimiteCompra,
            this.Id,
            this.DataCadastro});
            this.grdImportacao.Location = new System.Drawing.Point(7, 86);
            this.grdImportacao.Name = "grdImportacao";
            this.grdImportacao.Size = new System.Drawing.Size(738, 243);
            this.grdImportacao.TabIndex = 1;
            // 
            // btnImportacaoImportar
            // 
            this.btnImportacaoImportar.Location = new System.Drawing.Point(6, 13);
            this.btnImportacaoImportar.Name = "btnImportacaoImportar";
            this.btnImportacaoImportar.Size = new System.Drawing.Size(176, 23);
            this.btnImportacaoImportar.TabIndex = 13;
            this.btnImportacaoImportar.Text = "Importar";
            this.btnImportacaoImportar.UseVisualStyleBackColor = true;
            this.btnImportacaoImportar.Click += new System.EventHandler(this.btnImportacaoImportar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "Telefone";
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            // 
            // LimiteCompra
            // 
            this.LimiteCompra.DataPropertyName = "LimiteCompra";
            this.LimiteCompra.HeaderText = "Limite Compra";
            this.LimiteCompra.Name = "LimiteCompra";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // DataCadastro
            // 
            this.DataCadastro.DataPropertyName = "DataCadastro";
            this.DataCadastro.HeaderText = "DataCadastro";
            this.DataCadastro.Name = "DataCadastro";
            this.DataCadastro.Visible = false;
            // 
            // lblImportacaoArquivoNome
            // 
            this.lblImportacaoArquivoNome.AutoSize = true;
            this.lblImportacaoArquivoNome.Location = new System.Drawing.Point(6, 48);
            this.lblImportacaoArquivoNome.Name = "lblImportacaoArquivoNome";
            this.lblImportacaoArquivoNome.Size = new System.Drawing.Size(46, 13);
            this.lblImportacaoArquivoNome.TabIndex = 3;
            this.lblImportacaoArquivoNome.Text = "Arquivo:";
            // 
            // lblImportacaoRegistrosSucesso
            // 
            this.lblImportacaoRegistrosSucesso.AutoSize = true;
            this.lblImportacaoRegistrosSucesso.Location = new System.Drawing.Point(6, 68);
            this.lblImportacaoRegistrosSucesso.Name = "lblImportacaoRegistrosSucesso";
            this.lblImportacaoRegistrosSucesso.Size = new System.Drawing.Size(173, 13);
            this.lblImportacaoRegistrosSucesso.TabIndex = 4;
            this.lblImportacaoRegistrosSucesso.Text = "Registros importados com sucesso:";
            // 
            // lblImportacaoRegistrosErro
            // 
            this.lblImportacaoRegistrosErro.AutoSize = true;
            this.lblImportacaoRegistrosErro.Location = new System.Drawing.Point(380, 68);
            this.lblImportacaoRegistrosErro.Name = "lblImportacaoRegistrosErro";
            this.lblImportacaoRegistrosErro.Size = new System.Drawing.Size(98, 13);
            this.lblImportacaoRegistrosErro.TabIndex = 5;
            this.lblImportacaoRegistrosErro.Text = "Registros com erro:";
            // 
            // lblImportacaoRegistrosTotal
            // 
            this.lblImportacaoRegistrosTotal.AutoSize = true;
            this.lblImportacaoRegistrosTotal.Location = new System.Drawing.Point(380, 48);
            this.lblImportacaoRegistrosTotal.Name = "lblImportacaoRegistrosTotal";
            this.lblImportacaoRegistrosTotal.Size = new System.Drawing.Size(91, 13);
            this.lblImportacaoRegistrosTotal.TabIndex = 6;
            this.lblImportacaoRegistrosTotal.Text = "Total de registros:";
            // 
            // txtCadastroTelefone
            // 
            this.txtCadastroTelefone.Location = new System.Drawing.Point(104, 79);
            this.txtCadastroTelefone.Mask = "(99) 00000-0000";
            this.txtCadastroTelefone.Name = "txtCadastroTelefone";
            this.txtCadastroTelefone.Size = new System.Drawing.Size(137, 20);
            this.txtCadastroTelefone.TabIndex = 9;
            this.txtCadastroTelefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCadastroTelefone_MaskInputRejected);
            this.txtCadastroTelefone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCadastroTelefone_KeyDown);
            // 
            // txtCadastroLimite
            // 
            this.txtCadastroLimite.Location = new System.Drawing.Point(104, 105);
            this.txtCadastroLimite.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtCadastroLimite.Name = "txtCadastroLimite";
            this.txtCadastroLimite.Size = new System.Drawing.Size(137, 20);
            this.txtCadastroLimite.TabIndex = 11;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 386);
            this.Controls.Add(this.tabCliente);
            this.Name = "FrmCliente";
            this.Text = "SRM - Clientes";
            this.tabCliente.ResumeLayout(false);
            this.tabConsulta.ResumeLayout(false);
            this.tabConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).EndInit();
            this.tabCadastro.ResumeLayout(false);
            this.tabCadastro.PerformLayout();
            this.tabImportacao.ResumeLayout(false);
            this.tabImportacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdImportacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCadastroLimite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCliente;
        private System.Windows.Forms.TabPage tabConsulta;
        private System.Windows.Forms.TabPage tabCadastro;
        private System.Windows.Forms.TabPage tabImportacao;
        private System.Windows.Forms.DataGridView grdDados;
        private System.Windows.Forms.Button btnConsultaPesquisar;
        private System.Windows.Forms.TextBox txtConsultaNome;
        private System.Windows.Forms.Label lblConsultaNome;
        private System.Windows.Forms.Label lblCadastroLimite;
        private System.Windows.Forms.Label lblCadastroNome;
        private System.Windows.Forms.Label lblCadastroTelefone;
        private System.Windows.Forms.TextBox txtCadastroEmail;
        private System.Windows.Forms.Label lblCadastroEmail;
        private System.Windows.Forms.Button btnCadastroSalvar;
        private System.Windows.Forms.TextBox txtCadastroNome;
        private System.Windows.Forms.Button btnImportacaoImportar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView grdImportacao;
        private System.Windows.Forms.Button btnImportacaoGravar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn LimiteCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCadastro;
        private System.Windows.Forms.Label lblImportacaoRegistrosTotal;
        private System.Windows.Forms.Label lblImportacaoRegistrosErro;
        private System.Windows.Forms.Label lblImportacaoRegistrosSucesso;
        private System.Windows.Forms.Label lblImportacaoArquivoNome;
        private System.Windows.Forms.MaskedTextBox txtCadastroTelefone;
        private System.Windows.Forms.ToolTip toolTipTelefone;
        private System.Windows.Forms.NumericUpDown txtCadastroLimite;
    }
}

