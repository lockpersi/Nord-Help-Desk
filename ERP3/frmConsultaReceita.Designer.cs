namespace ERP3
{
    partial class frmConsultaReceita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaReceita));
            this.picLetras = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_letras = new System.Windows.Forms.TextBox();
            this.tb_cnpj = new System.Windows.Forms.TextBox();
            this.lb_cnpj = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_consultar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLetras)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLetras
            // 
            this.picLetras.Location = new System.Drawing.Point(42, 76);
            this.picLetras.Name = "picLetras";
            this.picLetras.Size = new System.Drawing.Size(166, 77);
            this.picLetras.TabIndex = 0;
            this.picLetras.TabStop = false;
            this.picLetras.Click += new System.EventHandler(this.picLetras_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_letras);
            this.groupBox1.Controls.Add(this.tb_cnpj);
            this.groupBox1.Controls.Add(this.lb_cnpj);
            this.groupBox1.Controls.Add(this.picLetras);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 200);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta CNPJ";
            // 
            // tb_letras
            // 
            this.tb_letras.Location = new System.Drawing.Point(114, 159);
            this.tb_letras.Name = "tb_letras";
            this.tb_letras.Size = new System.Drawing.Size(113, 25);
            this.tb_letras.TabIndex = 2;
            // 
            // tb_cnpj
            // 
            this.tb_cnpj.Location = new System.Drawing.Point(61, 37);
            this.tb_cnpj.Name = "tb_cnpj";
            this.tb_cnpj.Size = new System.Drawing.Size(166, 25);
            this.tb_cnpj.TabIndex = 1;
            // 
            // lb_cnpj
            // 
            this.lb_cnpj.AutoSize = true;
            this.lb_cnpj.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cnpj.Location = new System.Drawing.Point(6, 40);
            this.lb_cnpj.Name = "lb_cnpj";
            this.lb_cnpj.Size = new System.Drawing.Size(54, 17);
            this.lb_cnpj.TabIndex = 0;
            this.lb_cnpj.Text = "CNPJ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "CAPTCHA:";
            // 
            // bt_consultar
            // 
            this.bt_consultar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_consultar.Location = new System.Drawing.Point(23, 221);
            this.bt_consultar.Name = "bt_consultar";
            this.bt_consultar.Size = new System.Drawing.Size(111, 29);
            this.bt_consultar.TabIndex = 2;
            this.bt_consultar.Text = "CONSULTAR";
            this.bt_consultar.UseVisualStyleBackColor = true;
            this.bt_consultar.Click += new System.EventHandler(this.bt_consultar_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(156, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 26);
            this.button2.TabIndex = 3;
            this.button2.Text = "CANCELAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmConsultaReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 267);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bt_consultar);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaReceita";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Receita CNPJ";
            this.Load += new System.EventHandler(this.frmConsultaReceita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLetras)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLetras;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_letras;
        private System.Windows.Forms.TextBox tb_cnpj;
        private System.Windows.Forms.Label lb_cnpj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_consultar;
        private System.Windows.Forms.Button button2;
    }
}