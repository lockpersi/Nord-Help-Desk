namespace ERP3
{
    partial class frmInserirSenha
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
            this.tb_senhaserial = new System.Windows.Forms.TextBox();
            this.bt_inserirsenha = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.tb_tempo = new System.Windows.Forms.TextBox();
            this.lb_fnn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_senhaserial
            // 
            this.tb_senhaserial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_senhaserial.Location = new System.Drawing.Point(117, 21);
            this.tb_senhaserial.Name = "tb_senhaserial";
            this.tb_senhaserial.Size = new System.Drawing.Size(210, 20);
            this.tb_senhaserial.TabIndex = 0;
            this.tb_senhaserial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_senhaserial.TextChanged += new System.EventHandler(this.tb_senhaserial_TextChanged);
            // 
            // bt_inserirsenha
            // 
            this.bt_inserirsenha.Location = new System.Drawing.Point(358, 6);
            this.bt_inserirsenha.Name = "bt_inserirsenha";
            this.bt_inserirsenha.Size = new System.Drawing.Size(75, 23);
            this.bt_inserirsenha.TabIndex = 1;
            this.bt_inserirsenha.Text = "ATUALIZAR";
            this.bt_inserirsenha.UseVisualStyleBackColor = true;
            this.bt_inserirsenha.Click += new System.EventHandler(this.bt_inserirsenha_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(358, 35);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(75, 23);
            this.bt_cancelar.TabIndex = 2;
            this.bt_cancelar.Text = "CANCELAR";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // tb_tempo
            // 
            this.tb_tempo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_tempo.Location = new System.Drawing.Point(30, 21);
            this.tb_tempo.Name = "tb_tempo";
            this.tb_tempo.Size = new System.Drawing.Size(67, 20);
            this.tb_tempo.TabIndex = 3;
            this.tb_tempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_fnn
            // 
            this.lb_fnn.AutoSize = true;
            this.lb_fnn.Location = new System.Drawing.Point(103, 24);
            this.lb_fnn.Name = "lb_fnn";
            this.lb_fnn.Size = new System.Drawing.Size(10, 13);
            this.lb_fnn.TabIndex = 4;
            this.lb_fnn.Text = "-";
            // 
            // frmInserirSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(445, 70);
            this.Controls.Add(this.lb_fnn);
            this.Controls.Add(this.tb_tempo);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_inserirsenha);
            this.Controls.Add(this.tb_senhaserial);
            this.Name = "frmInserirSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar Licença ";
            this.Load += new System.EventHandler(this.frmInserirSenha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_senhaserial;
        private System.Windows.Forms.Button bt_inserirsenha;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.TextBox tb_tempo;
        private System.Windows.Forms.Label lb_fnn;
    }
}