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
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDMINISTRARToolStripMenuItem,
            this.cADASTROToolStripMenuItem,
            this.cONTROLEToolStripMenuItem});
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
            this.hELPDESKToolStripMenuItem});
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
            this.cLIENTEToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
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
            this.pRODUTOSToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.pRODUTOSToolStripMenuItem.Text = "RAT";
            this.pRODUTOSToolStripMenuItem.Click += new System.EventHandler(this.pRODUTOSToolStripMenuItem_Click);
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
            this.hELPDESKToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
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
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton,
            this.toolStripSeparator1,
            this.toolStripButton1});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 94);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(784, 25);
            this.fillByToolStrip.TabIndex = 5;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.fillByToolStrip);
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
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
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
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

