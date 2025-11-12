namespace AtividadeAPP_Pedros
{
    partial class frmexe1
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
            this.btnw = new System.Windows.Forms.Button();
            this.brndow = new System.Windows.Forms.Button();
            this.btnfor = new System.Windows.Forms.Button();
            this.btnvolt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnw
            // 
            this.btnw.Location = new System.Drawing.Point(170, 244);
            this.btnw.Name = "btnw";
            this.btnw.Size = new System.Drawing.Size(102, 36);
            this.btnw.TabIndex = 0;
            this.btnw.Text = "While";
            this.btnw.UseVisualStyleBackColor = true;
            this.btnw.Click += new System.EventHandler(this.btnw_Click);
            // 
            // brndow
            // 
            this.brndow.Location = new System.Drawing.Point(348, 244);
            this.brndow.Name = "brndow";
            this.brndow.Size = new System.Drawing.Size(102, 36);
            this.brndow.TabIndex = 1;
            this.brndow.Text = "Do While";
            this.brndow.UseVisualStyleBackColor = true;
            this.brndow.Click += new System.EventHandler(this.brndow_Click);
            // 
            // btnfor
            // 
            this.btnfor.Location = new System.Drawing.Point(533, 244);
            this.btnfor.Name = "btnfor";
            this.btnfor.Size = new System.Drawing.Size(102, 36);
            this.btnfor.TabIndex = 2;
            this.btnfor.Text = "For";
            this.btnfor.UseVisualStyleBackColor = true;
            this.btnfor.Click += new System.EventHandler(this.btnfor_Click);
            // 
            // btnvolt
            // 
            this.btnvolt.Location = new System.Drawing.Point(348, 378);
            this.btnvolt.Name = "btnvolt";
            this.btnvolt.Size = new System.Drawing.Size(102, 36);
            this.btnvolt.TabIndex = 3;
            this.btnvolt.Text = "Voltar";
            this.btnvolt.UseVisualStyleBackColor = true;
            this.btnvolt.Click += new System.EventHandler(this.btnvolt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Digite um número:";
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(372, 96);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(204, 22);
            this.txtnum.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "A tabuada dele até o 9 é:";
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(372, 154);
            this.txtresult.Name = "txtresult";
            this.txtresult.ReadOnly = true;
            this.txtresult.Size = new System.Drawing.Size(204, 22);
            this.txtresult.TabIndex = 7;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(348, 313);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(102, 36);
            this.btnlimpar.TabIndex = 8;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // frmexe1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnvolt);
            this.Controls.Add(this.btnfor);
            this.Controls.Add(this.brndow);
            this.Controls.Add(this.btnw);
            this.Name = "frmexe1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercício 1";
            this.Load += new System.EventHandler(this.frmexe1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnw;
        private System.Windows.Forms.Button brndow;
        private System.Windows.Forms.Button btnfor;
        private System.Windows.Forms.Button btnvolt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Button btnlimpar;
    }
}