namespace AtividadeAPP_Pedros
{
    partial class frmexe2
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
            this.btnlimpar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnvolt = new System.Windows.Forms.Button();
            this.btnfor = new System.Windows.Forms.Button();
            this.brndow = new System.Windows.Forms.Button();
            this.btnw = new System.Windows.Forms.Button();
            this.txtf = new System.Windows.Forms.TextBox();
            this.txtc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(340, 325);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(102, 36);
            this.btnlimpar.TabIndex = 17;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(477, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "F°";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "C°";
            // 
            // btnvolt
            // 
            this.btnvolt.Location = new System.Drawing.Point(340, 390);
            this.btnvolt.Name = "btnvolt";
            this.btnvolt.Size = new System.Drawing.Size(102, 36);
            this.btnvolt.TabIndex = 12;
            this.btnvolt.Text = "Voltar";
            this.btnvolt.UseVisualStyleBackColor = true;
            this.btnvolt.Click += new System.EventHandler(this.btnvolt_Click);
            // 
            // btnfor
            // 
            this.btnfor.Location = new System.Drawing.Point(525, 256);
            this.btnfor.Name = "btnfor";
            this.btnfor.Size = new System.Drawing.Size(102, 36);
            this.btnfor.TabIndex = 11;
            this.btnfor.Text = "For";
            this.btnfor.UseVisualStyleBackColor = true;
            this.btnfor.Click += new System.EventHandler(this.btnfor_Click);
            // 
            // brndow
            // 
            this.brndow.Location = new System.Drawing.Point(340, 256);
            this.brndow.Name = "brndow";
            this.brndow.Size = new System.Drawing.Size(102, 36);
            this.brndow.TabIndex = 10;
            this.brndow.Text = "Do While";
            this.brndow.UseVisualStyleBackColor = true;
            this.brndow.Click += new System.EventHandler(this.brndow_Click);
            // 
            // btnw
            // 
            this.btnw.Location = new System.Drawing.Point(162, 256);
            this.btnw.Name = "btnw";
            this.btnw.Size = new System.Drawing.Size(102, 36);
            this.btnw.TabIndex = 9;
            this.btnw.Text = "While";
            this.btnw.UseVisualStyleBackColor = true;
            this.btnw.Click += new System.EventHandler(this.btnw_Click);
            // 
            // txtf
            // 
            this.txtf.Enabled = false;
            this.txtf.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtf.Location = new System.Drawing.Point(468, 60);
            this.txtf.Margin = new System.Windows.Forms.Padding(4);
            this.txtf.Multiline = true;
            this.txtf.Name = "txtf";
            this.txtf.Size = new System.Drawing.Size(37, 179);
            this.txtf.TabIndex = 19;
            // 
            // txtc
            // 
            this.txtc.Enabled = false;
            this.txtc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtc.Location = new System.Drawing.Point(293, 60);
            this.txtc.Margin = new System.Windows.Forms.Padding(4);
            this.txtc.Multiline = true;
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(37, 179);
            this.txtc.TabIndex = 18;
            this.txtc.TabStop = false;
            // 
            // frmexe2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.txtf);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnvolt);
            this.Controls.Add(this.btnfor);
            this.Controls.Add(this.brndow);
            this.Controls.Add(this.btnw);
            this.Name = "frmexe2";
            this.Text = "Exercício 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnvolt;
        private System.Windows.Forms.Button btnfor;
        private System.Windows.Forms.Button brndow;
        private System.Windows.Forms.Button btnw;
        private System.Windows.Forms.TextBox txtf;
        private System.Windows.Forms.TextBox txtc;
    }
}