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
            this.tabCliente = new System.Windows.Forms.TabControl();
            this.tabConsulta = new System.Windows.Forms.TabPage();
            this.grdDados = new System.Windows.Forms.DataGridView();
            this.btnConsultaPesquisar = new System.Windows.Forms.Button();
            this.txtConsultaNome = new System.Windows.Forms.TextBox();
            this.lblConsultaNome = new System.Windows.Forms.Label();
            this.tabCadastro = new System.Windows.Forms.TabPage();
            this.tabImportacao = new System.Windows.Forms.TabPage();
            this.lblCadastroLimite = new System.Windows.Forms.Label();
            this.lblCadastroNome = new System.Windows.Forms.Label();
            this.lblCadastroTelefone = new System.Windows.Forms.Label();
            this.txtCadastroLimite = new System.Windows.Forms.TextBox();
            this.txtCadastroTelefone = new System.Windows.Forms.TextBox();
            this.txtCadastroEmail = new System.Windows.Forms.TextBox();
            this.lblCadastroEmail = new System.Windows.Forms.Label();
            this.btnCadastroSalvar = new System.Windows.Forms.Button();
            this.txtCadastroNome = new System.Windows.Forms.TextBox();
            this.tabCliente.SuspendLayout();
            this.tabConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).BeginInit();
            this.tabCadastro.SuspendLayout();
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
            this.btnConsultaPesquisar.TabIndex = 6;
            this.btnConsultaPesquisar.Text = "Pesquisar";
            this.btnConsultaPesquisar.UseVisualStyleBackColor = true;
            this.btnConsultaPesquisar.Click += new System.EventHandler(this.btnConsultaPesquisar_Click);
            // 
            // txtConsultaNome
            // 
            this.txtConsultaNome.Location = new System.Drawing.Point(12, 26);
            this.txtConsultaNome.Name = "txtConsultaNome";
            this.txtConsultaNome.Size = new System.Drawing.Size(338, 20);
            this.txtConsultaNome.TabIndex = 5;
            // 
            // lblConsultaNome
            // 
            this.lblConsultaNome.AutoSize = true;
            this.lblConsultaNome.Location = new System.Drawing.Point(9, 9);
            this.lblConsultaNome.Name = "lblConsultaNome";
            this.lblConsultaNome.Size = new System.Drawing.Size(38, 13);
            this.lblConsultaNome.TabIndex = 4;
            this.lblConsultaNome.Text = "Nome:";
            // 
            // tabCadastro
            // 
            this.tabCadastro.Controls.Add(this.lblCadastroLimite);
            this.tabCadastro.Controls.Add(this.lblCadastroNome);
            this.tabCadastro.Controls.Add(this.lblCadastroTelefone);
            this.tabCadastro.Controls.Add(this.txtCadastroLimite);
            this.tabCadastro.Controls.Add(this.txtCadastroTelefone);
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
            // tabImportacao
            // 
            this.tabImportacao.Location = new System.Drawing.Point(4, 22);
            this.tabImportacao.Name = "tabImportacao";
            this.tabImportacao.Padding = new System.Windows.Forms.Padding(3);
            this.tabImportacao.Size = new System.Drawing.Size(751, 410);
            this.tabImportacao.TabIndex = 2;
            this.tabImportacao.Text = "Importação";
            this.tabImportacao.UseVisualStyleBackColor = true;
            // 
            // lblCadastroLimite
            // 
            this.lblCadastroLimite.AutoSize = true;
            this.lblCadastroLimite.Location = new System.Drawing.Point(11, 108);
            this.lblCadastroLimite.Name = "lblCadastroLimite";
            this.lblCadastroLimite.Size = new System.Drawing.Size(87, 13);
            this.lblCadastroLimite.TabIndex = 18;
            this.lblCadastroLimite.Text = "Limite de compra";
            // 
            // lblCadastroNome
            // 
            this.lblCadastroNome.AutoSize = true;
            this.lblCadastroNome.Location = new System.Drawing.Point(63, 30);
            this.lblCadastroNome.Name = "lblCadastroNome";
            this.lblCadastroNome.Size = new System.Drawing.Size(35, 13);
            this.lblCadastroNome.TabIndex = 17;
            this.lblCadastroNome.Text = "Nome";
            // 
            // lblCadastroTelefone
            // 
            this.lblCadastroTelefone.AutoSize = true;
            this.lblCadastroTelefone.Location = new System.Drawing.Point(49, 82);
            this.lblCadastroTelefone.Name = "lblCadastroTelefone";
            this.lblCadastroTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblCadastroTelefone.TabIndex = 16;
            this.lblCadastroTelefone.Text = "Telefone";
            // 
            // txtCadastroLimite
            // 
            this.txtCadastroLimite.Location = new System.Drawing.Point(104, 105);
            this.txtCadastroLimite.Name = "txtCadastroLimite";
            this.txtCadastroLimite.Size = new System.Drawing.Size(137, 20);
            this.txtCadastroLimite.TabIndex = 15;
            // 
            // txtCadastroTelefone
            // 
            this.txtCadastroTelefone.Location = new System.Drawing.Point(104, 79);
            this.txtCadastroTelefone.Name = "txtCadastroTelefone";
            this.txtCadastroTelefone.Size = new System.Drawing.Size(137, 20);
            this.txtCadastroTelefone.TabIndex = 14;
            // 
            // txtCadastroEmail
            // 
            this.txtCadastroEmail.Location = new System.Drawing.Point(104, 53);
            this.txtCadastroEmail.Name = "txtCadastroEmail";
            this.txtCadastroEmail.Size = new System.Drawing.Size(633, 20);
            this.txtCadastroEmail.TabIndex = 13;
            // 
            // lblCadastroEmail
            // 
            this.lblCadastroEmail.AutoSize = true;
            this.lblCadastroEmail.Location = new System.Drawing.Point(66, 56);
            this.lblCadastroEmail.Name = "lblCadastroEmail";
            this.lblCadastroEmail.Size = new System.Drawing.Size(32, 13);
            this.lblCadastroEmail.TabIndex = 12;
            this.lblCadastroEmail.Text = "Email";
            // 
            // btnCadastroSalvar
            // 
            this.btnCadastroSalvar.Location = new System.Drawing.Point(662, 148);
            this.btnCadastroSalvar.Name = "btnCadastroSalvar";
            this.btnCadastroSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastroSalvar.TabIndex = 11;
            this.btnCadastroSalvar.Text = "Salvar";
            this.btnCadastroSalvar.UseVisualStyleBackColor = true;
            this.btnCadastroSalvar.Click += new System.EventHandler(this.btnCadastroSalvar_Click);
            // 
            // txtCadastroNome
            // 
            this.txtCadastroNome.Location = new System.Drawing.Point(104, 27);
            this.txtCadastroNome.Name = "txtCadastroNome";
            this.txtCadastroNome.Size = new System.Drawing.Size(633, 20);
            this.txtCadastroNome.TabIndex = 10;
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
        private System.Windows.Forms.TextBox txtCadastroLimite;
        private System.Windows.Forms.TextBox txtCadastroTelefone;
        private System.Windows.Forms.TextBox txtCadastroEmail;
        private System.Windows.Forms.Label lblCadastroEmail;
        private System.Windows.Forms.Button btnCadastroSalvar;
        private System.Windows.Forms.TextBox txtCadastroNome;
    }
}

