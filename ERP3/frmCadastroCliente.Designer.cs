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
            this.cdtempresasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroClienteEmpresa = new ERP3.CadastroClienteEmpresa();
            this.cdtempresasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nordDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cdt_empresasTableAdapter = new ERP3.CadastroClienteEmpresaTableAdapters.cdt_empresasTableAdapter();
            this.Cliente = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_cod = new System.Windows.Forms.Label();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.gb_DadosCadastrais = new System.Windows.Forms.GroupBox();
            this.lb_nome = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_novo = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_empresa = new System.Windows.Forms.Label();
            this.cb_empresa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.cdtempresasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroClienteEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdtempresasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nordDataSetBindingSource)).BeginInit();
            this.Cliente.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gb_DadosCadastrais.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // Cliente
            // 
            this.Cliente.AllowDrop = true;
            this.Cliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cliente.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.Cliente.Controls.Add(this.tabPage1);
            this.Cliente.Controls.Add(this.tabPage2);
            this.Cliente.Controls.Add(this.tabPage3);
            this.Cliente.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente.Location = new System.Drawing.Point(0, 34);
            this.Cliente.Name = "Cliente";
            this.Cliente.SelectedIndex = 0;
            this.Cliente.Size = new System.Drawing.Size(785, 526);
            this.Cliente.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Controls.Add(this.tb_email);
            this.tabPage1.Controls.Add(this.gb_DadosCadastrais);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(777, 493);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = " Dados Cliente";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.lb_cod);
            this.flowLayoutPanel1.Controls.Add(this.tb_codigo);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(31, 22);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(178, 36);
            this.flowLayoutPanel1.TabIndex = 15;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // lb_cod
            // 
            this.lb_cod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_cod.AutoSize = true;
            this.lb_cod.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lb_cod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_cod.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cod.ForeColor = System.Drawing.Color.Black;
            this.lb_cod.Location = new System.Drawing.Point(3, 7);
            this.lb_cod.Name = "lb_cod";
            this.lb_cod.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_cod.Size = new System.Drawing.Size(76, 17);
            this.lb_cod.TabIndex = 12;
            this.lb_cod.Text = "CÓDIGO:";
            this.lb_cod.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_codigo
            // 
            this.tb_codigo.Location = new System.Drawing.Point(85, 3);
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.Size = new System.Drawing.Size(55, 25);
            this.tb_codigo.TabIndex = 13;
            this.tb_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_codigo_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ERP3.Properties.Resources._1440109443_system_search;
            this.pictureBox1.Location = new System.Drawing.Point(146, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 25);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(402, 256);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(206, 25);
            this.tb_email.TabIndex = 8;
            this.tb_email.TextChanged += new System.EventHandler(this.tb_email_TextChanged);
            // 
            // gb_DadosCadastrais
            // 
            this.gb_DadosCadastrais.BackColor = System.Drawing.SystemColors.Control;
            this.gb_DadosCadastrais.Controls.Add(this.lb_nome);
            this.gb_DadosCadastrais.Controls.Add(this.tb_nome);
            this.gb_DadosCadastrais.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_DadosCadastrais.Location = new System.Drawing.Point(31, 89);
            this.gb_DadosCadastrais.Name = "gb_DadosCadastrais";
            this.gb_DadosCadastrais.Size = new System.Drawing.Size(709, 136);
            this.gb_DadosCadastrais.TabIndex = 15;
            this.gb_DadosCadastrais.TabStop = false;
            this.gb_DadosCadastrais.Text = "Dados Cadastrais";
            this.gb_DadosCadastrais.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.ForeColor = System.Drawing.Color.Black;
            this.lb_nome.Location = new System.Drawing.Point(23, 35);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(58, 18);
            this.lb_nome.TabIndex = 8;
            this.lb_nome.Text = "NOME:";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(87, 32);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(442, 25);
            this.tb_nome.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(777, 493);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Empresa";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(777, 493);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_novo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 31);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_novo
            // 
            this.tsb_novo.AutoSize = false;
            this.tsb_novo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_novo.Image = global::ERP3.Properties.Resources._1440129383_Add_Male_User;
            this.tsb_novo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_novo.Name = "tsb_novo";
            this.tsb_novo.Size = new System.Drawing.Size(28, 28);
            this.tsb_novo.Text = "toolStripButton1";
            this.tsb_novo.ToolTipText = "Novo";
            this.tsb_novo.Click += new System.EventHandler(this.tsb_novo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_empresa);
            this.groupBox1.Controls.Add(this.lb_empresa);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empresa";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // lb_empresa
            // 
            this.lb_empresa.AutoSize = true;
            this.lb_empresa.ForeColor = System.Drawing.Color.Black;
            this.lb_empresa.Location = new System.Drawing.Point(6, 40);
            this.lb_empresa.Name = "lb_empresa";
            this.lb_empresa.Size = new System.Drawing.Size(85, 18);
            this.lb_empresa.TabIndex = 6;
            this.lb_empresa.Text = "EMPRESA:";
            // 
            // cb_empresa
            // 
            this.cb_empresa.DataSource = this.cdtempresasBindingSource1;
            this.cb_empresa.DisplayMember = "nome";
            this.cb_empresa.FormattingEnabled = true;
            this.cb_empresa.Location = new System.Drawing.Point(97, 37);
            this.cb_empresa.Name = "cb_empresa";
            this.cb_empresa.Size = new System.Drawing.Size(279, 26);
            this.cb_empresa.TabIndex = 12;
            this.cb_empresa.ValueMember = "nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(420, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "FILIAL:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(482, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 26);
            this.comboBox1.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(31, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(709, 167);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Empresa";
            // 
            // frmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Cliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroCliente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Cliente";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmCadastroCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cdtempresasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroClienteEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdtempresasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nordDataSetBindingSource)).EndInit();
            this.Cliente.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gb_DadosCadastrais.ResumeLayout(false);
            this.gb_DadosCadastrais.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource nordDataSetBindingSource;
        private System.Windows.Forms.BindingSource cdtempresasBindingSource;
        private CadastroClienteEmpresa cadastroClienteEmpresa;
        private System.Windows.Forms.BindingSource cdtempresasBindingSource1;
        private CadastroClienteEmpresaTableAdapters.cdt_empresasTableAdapter cdt_empresasTableAdapter;
        private System.Windows.Forms.TabControl Cliente;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lb_cod;
        private System.Windows.Forms.TextBox tb_codigo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gb_DadosCadastrais;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_novo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_empresa;
        private System.Windows.Forms.ComboBox cb_empresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}