namespace ERP3
{
    partial class frmCadastroCliente
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.tb_codigocliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_telefone = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.bt_InserirCliente = new System.Windows.Forms.Button();
            this.cb_empresa = new System.Windows.Forms.ComboBox();
            this.cdtempresasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroClienteEmpresa = new ERP3.CadastroClienteEmpresa();
            this.cdtempresasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nordDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cdt_empresasTableAdapter = new ERP3.CadastroClienteEmpresaTableAdapters.cdt_empresasTableAdapter();
            this.bt_cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cdtempresasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroClienteEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdtempresasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nordDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(12, 24);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(65, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo";
            // 
            // tb_codigocliente
            // 
            this.tb_codigocliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_codigocliente.Enabled = false;
            this.tb_codigocliente.Location = new System.Drawing.Point(0, 0);
            this.tb_codigocliente.Name = "tb_codigocliente";
            this.tb_codigocliente.Size = new System.Drawing.Size(474, 20);
            this.tb_codigocliente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Empresa";
            // 
            // tb_telefone
            // 
            this.tb_telefone.Location = new System.Drawing.Point(83, 197);
            this.tb_telefone.Name = "tb_telefone";
            this.tb_telefone.Size = new System.Drawing.Size(140, 20);
            this.tb_telefone.TabIndex = 7;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(83, 140);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(206, 20);
            this.tb_email.TabIndex = 8;
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(83, 83);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(292, 20);
            this.tb_nome.TabIndex = 9;
            // 
            // bt_InserirCliente
            // 
            this.bt_InserirCliente.Location = new System.Drawing.Point(83, 311);
            this.bt_InserirCliente.Name = "bt_InserirCliente";
            this.bt_InserirCliente.Size = new System.Drawing.Size(116, 31);
            this.bt_InserirCliente.TabIndex = 10;
            this.bt_InserirCliente.Text = "Cadastrar Cliente";
            this.bt_InserirCliente.UseVisualStyleBackColor = true;
            this.bt_InserirCliente.Click += new System.EventHandler(this.bt_InserirCliente_Click);
            // 
            // cb_empresa
            // 
            this.cb_empresa.DataSource = this.cdtempresasBindingSource1;
            this.cb_empresa.DisplayMember = "nome";
            this.cb_empresa.FormattingEnabled = true;
            this.cb_empresa.Location = new System.Drawing.Point(83, 256);
            this.cb_empresa.Name = "cb_empresa";
            this.cb_empresa.Size = new System.Drawing.Size(121, 21);
            this.cb_empresa.TabIndex = 11;
            this.cb_empresa.ValueMember = "nome";
            // 
            // cdtempresasBindingSource1
            // 
            this.cdtempresasBindingSource1.DataMember = "cdt_empresas";
            this.cdtempresasBindingSource1.DataSource = this.cadastroClienteEmpresa;
            // 
            // cadastroClienteEmpresa
            // 
            this.cadastroClienteEmpresa.DataSetName = "CadastroClienteEmpresa";
            this.cadastroClienteEmpresa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cdt_empresasTableAdapter
            // 
            this.cdt_empresasTableAdapter.ClearBeforeFill = true;
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(232, 315);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(75, 23);
            this.bt_cancelar.TabIndex = 12;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // frmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(474, 367);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.cb_empresa);
            this.Controls.Add(this.bt_InserirCliente);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_telefone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_codigocliente);
            this.Controls.Add(this.lblCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroCliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrando Cliente";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmCadastroCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cdtempresasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroClienteEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdtempresasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nordDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox tb_codigocliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_telefone;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Button bt_InserirCliente;
        private System.Windows.Forms.ComboBox cb_empresa;
        private System.Windows.Forms.BindingSource nordDataSetBindingSource;
        private System.Windows.Forms.BindingSource cdtempresasBindingSource;
        private CadastroClienteEmpresa cadastroClienteEmpresa;
        private System.Windows.Forms.BindingSource cdtempresasBindingSource1;
        private CadastroClienteEmpresaTableAdapters.cdt_empresasTableAdapter cdt_empresasTableAdapter;
        private System.Windows.Forms.Button bt_cancelar;
    }
}