using NORD.Modelos;

namespace ERP3
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aDMINISTRARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSUARIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cADASTROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nOVOCLIENTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aLTERARCADASTROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nOVARATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aLTERARRATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hELPDESKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nOVOCHAMADOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aLTERARCHAMADOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONTROLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vENDASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eMPRESAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDMINISTRARToolStripMenuItem,
            this.cADASTROToolStripMenuItem,
            this.cONTROLEToolStripMenuItem,
            this.rATToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 94);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aDMINISTRARToolStripMenuItem
            // 
            this.aDMINISTRARToolStripMenuItem.AutoSize = false;
            this.aDMINISTRARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uSUARIOSToolStripMenuItem,
            this.sAIRToolStripMenuItem});
            this.aDMINISTRARToolStripMenuItem.Image = global::ERP3.Properties.Resources._1439595254_administrator;
            this.aDMINISTRARToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.aDMINISTRARToolStripMenuItem.Name = "aDMINISTRARToolStripMenuItem";
            this.aDMINISTRARToolStripMenuItem.Size = new System.Drawing.Size(94, 90);
            this.aDMINISTRARToolStripMenuItem.Text = "ADMINISTRAR";
            this.aDMINISTRARToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.aDMINISTRARToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // uSUARIOSToolStripMenuItem
            // 
            this.uSUARIOSToolStripMenuItem.Image = global::ERP3.Properties.Resources._1439608624_user_alt;
            this.uSUARIOSToolStripMenuItem.Name = "uSUARIOSToolStripMenuItem";
            this.uSUARIOSToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.uSUARIOSToolStripMenuItem.Text = "USUARIOS";
            this.uSUARIOSToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.uSUARIOSToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // sAIRToolStripMenuItem
            // 
            this.sAIRToolStripMenuItem.Image = global::ERP3.Properties.Resources._1439608732_exit_thin_output;
            this.sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
            this.sAIRToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.sAIRToolStripMenuItem.Text = "SAIR";
            this.sAIRToolStripMenuItem.Click += new System.EventHandler(this.sAIRToolStripMenuItem_Click);
            // 
            // cADASTROToolStripMenuItem
            // 
            this.cADASTROToolStripMenuItem.AutoSize = false;
            this.cADASTROToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLIENTEToolStripMenuItem,
            this.pRODUTOSToolStripMenuItem,
            this.hELPDESKToolStripMenuItem,
            this.eMPRESAToolStripMenuItem});
            this.cADASTROToolStripMenuItem.Image = global::ERP3.Properties.Resources._1439629284_1_1;
            this.cADASTROToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cADASTROToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cADASTROToolStripMenuItem.Name = "cADASTROToolStripMenuItem";
            this.cADASTROToolStripMenuItem.Size = new System.Drawing.Size(94, 90);
            this.cADASTROToolStripMenuItem.Text = "CADASTRO";
            this.cADASTROToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cADASTROToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // cLIENTEToolStripMenuItem
            // 
            this.cLIENTEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nOVOCLIENTEToolStripMenuItem,
            this.aLTERARCADASTROToolStripMenuItem});
            this.cLIENTEToolStripMenuItem.Name = "cLIENTEToolStripMenuItem";
            this.cLIENTEToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cLIENTEToolStripMenuItem.Text = "CLIENTE";
            // 
            // nOVOCLIENTEToolStripMenuItem
            // 
            this.nOVOCLIENTEToolStripMenuItem.Name = "nOVOCLIENTEToolStripMenuItem";
            this.nOVOCLIENTEToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.nOVOCLIENTEToolStripMenuItem.Text = "NOVO CLIENTE";
            this.nOVOCLIENTEToolStripMenuItem.Click += new System.EventHandler(this.nOVOCLIENTEToolStripMenuItem_Click);
            // 
            // aLTERARCADASTROToolStripMenuItem
            // 
            this.aLTERARCADASTROToolStripMenuItem.Name = "aLTERARCADASTROToolStripMenuItem";
            this.aLTERARCADASTROToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.aLTERARCADASTROToolStripMenuItem.Text = "ALTERAR CADASTRO";
            // 
            // pRODUTOSToolStripMenuItem
            // 
            this.pRODUTOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nOVARATToolStripMenuItem,
            this.aLTERARRATToolStripMenuItem});
            this.pRODUTOSToolStripMenuItem.Name = "pRODUTOSToolStripMenuItem";
            this.pRODUTOSToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pRODUTOSToolStripMenuItem.Text = "RAT";
            // 
            // nOVARATToolStripMenuItem
            // 
            this.nOVARATToolStripMenuItem.Name = "nOVARATToolStripMenuItem";
            this.nOVARATToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.nOVARATToolStripMenuItem.Text = "NOVA RAT";
            // 
            // aLTERARRATToolStripMenuItem
            // 
            this.aLTERARRATToolStripMenuItem.Name = "aLTERARRATToolStripMenuItem";
            this.aLTERARRATToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.aLTERARRATToolStripMenuItem.Text = "ALTERAR RAT";
            // 
            // hELPDESKToolStripMenuItem
            // 
            this.hELPDESKToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nOVOCHAMADOToolStripMenuItem,
            this.aLTERARCHAMADOToolStripMenuItem});
            this.hELPDESKToolStripMenuItem.Name = "hELPDESKToolStripMenuItem";
            this.hELPDESKToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hELPDESKToolStripMenuItem.Text = "HELP DESK";
            // 
            // nOVOCHAMADOToolStripMenuItem
            // 
            this.nOVOCHAMADOToolStripMenuItem.Name = "nOVOCHAMADOToolStripMenuItem";
            this.nOVOCHAMADOToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.nOVOCHAMADOToolStripMenuItem.Text = "NOVO CHAMADO";
            // 
            // aLTERARCHAMADOToolStripMenuItem
            // 
            this.aLTERARCHAMADOToolStripMenuItem.Name = "aLTERARCHAMADOToolStripMenuItem";
            this.aLTERARCHAMADOToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.aLTERARCHAMADOToolStripMenuItem.Text = "ALTERAR CHAMADO";
            // 
            // cONTROLEToolStripMenuItem
            // 
            this.cONTROLEToolStripMenuItem.AutoSize = false;
            this.cONTROLEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vENDASToolStripMenuItem});
            this.cONTROLEToolStripMenuItem.Image = global::ERP3.Properties.Resources._1439629946_database_gear;
            this.cONTROLEToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cONTROLEToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cONTROLEToolStripMenuItem.Name = "cONTROLEToolStripMenuItem";
            this.cONTROLEToolStripMenuItem.Size = new System.Drawing.Size(94, 90);
            this.cONTROLEToolStripMenuItem.Text = "CONTROLE";
            this.cONTROLEToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cONTROLEToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // vENDASToolStripMenuItem
            // 
            this.vENDASToolStripMenuItem.Name = "vENDASToolStripMenuItem";
            this.vENDASToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.vENDASToolStripMenuItem.Text = "VENDAS";
            // 
            // rATToolStripMenuItem
            // 
            this.rATToolStripMenuItem.AutoSize = false;
            this.rATToolStripMenuItem.Image = global::ERP3.Properties.Resources._1439678727_maintenance;
            this.rATToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rATToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.rATToolStripMenuItem.Name = "rATToolStripMenuItem";
            this.rATToolStripMenuItem.Size = new System.Drawing.Size(94, 90);
            this.rATToolStripMenuItem.Text = "RAT";
            this.rATToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rATToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // eMPRESAToolStripMenuItem
            // 
            this.eMPRESAToolStripMenuItem.Name = "eMPRESAToolStripMenuItem";
            this.eMPRESAToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eMPRESAToolStripMenuItem.Text = "EMPRESA";
            this.eMPRESAToolStripMenuItem.Click += new System.EventHandler(this.eMPRESAToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aDMINISTRARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cADASTROToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLIENTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRODUTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONTROLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vENDASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nOVOCLIENTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aLTERARCADASTROToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSUARIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nOVARATToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aLTERARRATToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hELPDESKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nOVOCHAMADOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aLTERARCHAMADOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rATToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eMPRESAToolStripMenuItem;
    }
}

