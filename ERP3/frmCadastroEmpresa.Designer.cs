namespace ERP3
{
    partial class frmCadastroEmpresa
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.gb_codigocnpj = new System.Windows.Forms.GroupBox();
            this.pb_pesquisa2 = new System.Windows.Forms.PictureBox();
            this.tb_cnpj = new System.Windows.Forms.TextBox();
            this.pb_pesquisa1 = new System.Windows.Forms.PictureBox();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.lb_cnpj = new System.Windows.Forms.Label();
            this.lb_codigo = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.gb_codigocnpj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pesquisa2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pesquisa1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::ERP3.Properties.Resources._1440129383_Add_Male_User;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // gb_codigocnpj
            // 
            this.gb_codigocnpj.Controls.Add(this.pb_pesquisa2);
            this.gb_codigocnpj.Controls.Add(this.tb_cnpj);
            this.gb_codigocnpj.Controls.Add(this.pb_pesquisa1);
            this.gb_codigocnpj.Controls.Add(this.tb_codigo);
            this.gb_codigocnpj.Controls.Add(this.lb_cnpj);
            this.gb_codigocnpj.Controls.Add(this.lb_codigo);
            this.gb_codigocnpj.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_codigocnpj.Location = new System.Drawing.Point(31, 43);
            this.gb_codigocnpj.Name = "gb_codigocnpj";
            this.gb_codigocnpj.Size = new System.Drawing.Size(709, 82);
            this.gb_codigocnpj.TabIndex = 1;
            this.gb_codigocnpj.TabStop = false;
            this.gb_codigocnpj.Text = "CODIGO/CNPJ";
            // 
            // pb_pesquisa2
            // 
            this.pb_pesquisa2.Image = global::ERP3.Properties.Resources._1440109443_system_search;
            this.pb_pesquisa2.Location = new System.Drawing.Point(544, 29);
            this.pb_pesquisa2.Name = "pb_pesquisa2";
            this.pb_pesquisa2.Size = new System.Drawing.Size(25, 25);
            this.pb_pesquisa2.TabIndex = 4;
            this.pb_pesquisa2.TabStop = false;
            this.pb_pesquisa2.Click += new System.EventHandler(this.pb_pesquisa2_Click);
            // 
            // tb_cnpj
            // 
            this.tb_cnpj.Location = new System.Drawing.Point(362, 29);
            this.tb_cnpj.Name = "tb_cnpj";
            this.tb_cnpj.Size = new System.Drawing.Size(176, 25);
            this.tb_cnpj.TabIndex = 3;
            // 
            // pb_pesquisa1
            // 
            this.pb_pesquisa1.Image = global::ERP3.Properties.Resources._1440109443_system_search;
            this.pb_pesquisa1.Location = new System.Drawing.Point(174, 29);
            this.pb_pesquisa1.Name = "pb_pesquisa1";
            this.pb_pesquisa1.Size = new System.Drawing.Size(25, 25);
            this.pb_pesquisa1.TabIndex = 5;
            this.pb_pesquisa1.TabStop = false;
            // 
            // tb_codigo
            // 
            this.tb_codigo.Location = new System.Drawing.Point(93, 29);
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.Size = new System.Drawing.Size(75, 25);
            this.tb_codigo.TabIndex = 2;
            // 
            // lb_cnpj
            // 
            this.lb_cnpj.AutoSize = true;
            this.lb_cnpj.Location = new System.Drawing.Point(302, 32);
            this.lb_cnpj.Name = "lb_cnpj";
            this.lb_cnpj.Size = new System.Drawing.Size(54, 17);
            this.lb_cnpj.TabIndex = 1;
            this.lb_cnpj.Text = "CNPJ:";
            // 
            // lb_codigo
            // 
            this.lb_codigo.AutoSize = true;
            this.lb_codigo.Location = new System.Drawing.Point(11, 32);
            this.lb_codigo.Name = "lb_codigo";
            this.lb_codigo.Size = new System.Drawing.Size(76, 17);
            this.lb_codigo.TabIndex = 0;
            this.lb_codigo.Text = "CÓDIGO:";
            // 
            // frmCadastroEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gb_codigocnpj);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmCadastroEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Empresa";
            this.Load += new System.EventHandler(this.frmCadastroEmpresa_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gb_codigocnpj.ResumeLayout(false);
            this.gb_codigocnpj.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pesquisa2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pesquisa1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.GroupBox gb_codigocnpj;
        private System.Windows.Forms.TextBox tb_cnpj;
        private System.Windows.Forms.TextBox tb_codigo;
        private System.Windows.Forms.Label lb_cnpj;
        private System.Windows.Forms.Label lb_codigo;
        private System.Windows.Forms.PictureBox pb_pesquisa2;
        private System.Windows.Forms.PictureBox pb_pesquisa1;
    }
}