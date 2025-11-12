namespace AtividadeAPP_Pedros
{
    partial class frmmenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiexe1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiexe2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiexe3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiexit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programasToolStripMenuItem,
            this.tsmiexit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programasToolStripMenuItem
            // 
            this.programasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiexe1,
            this.tsmiexe2,
            this.tsmiexe3});
            this.programasToolStripMenuItem.Name = "programasToolStripMenuItem";
            this.programasToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.programasToolStripMenuItem.Text = "Programas";
            // 
            // tsmiexe1
            // 
            this.tsmiexe1.Name = "tsmiexe1";
            this.tsmiexe1.Size = new System.Drawing.Size(224, 26);
            this.tsmiexe1.Text = "Exercício 1";
            this.tsmiexe1.Click += new System.EventHandler(this.tsmiexe1_Click);
            // 
            // tsmiexe2
            // 
            this.tsmiexe2.Name = "tsmiexe2";
            this.tsmiexe2.Size = new System.Drawing.Size(224, 26);
            this.tsmiexe2.Text = "Exercício 2";
            this.tsmiexe2.Click += new System.EventHandler(this.tsmiexe2_Click);
            // 
            // tsmiexe3
            // 
            this.tsmiexe3.Name = "tsmiexe3";
            this.tsmiexe3.Size = new System.Drawing.Size(224, 26);
            this.tsmiexe3.Text = "Exercício 3";
            this.tsmiexe3.Click += new System.EventHandler(this.tsmiexe3_Click);
            // 
            // tsmiexit
            // 
            this.tsmiexit.Name = "tsmiexit";
            this.tsmiexit.Size = new System.Drawing.Size(48, 24);
            this.tsmiexit.Text = "Sair";
            this.tsmiexit.Click += new System.EventHandler(this.tsmiexit_Click);
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiexe1;
        private System.Windows.Forms.ToolStripMenuItem tsmiexe2;
        private System.Windows.Forms.ToolStripMenuItem tsmiexe3;
        private System.Windows.Forms.ToolStripMenuItem tsmiexit;
    }
}

