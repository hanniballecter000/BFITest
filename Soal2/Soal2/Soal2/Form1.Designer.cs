namespace Soal2
{
    partial class frmMain
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
            this.btnGenRand = new System.Windows.Forms.Button();
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.LabelTgl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGenRand
            // 
            this.btnGenRand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenRand.Location = new System.Drawing.Point(180, 20);
            this.btnGenRand.Name = "btnGenRand";
            this.btnGenRand.Size = new System.Drawing.Size(75, 41);
            this.btnGenRand.TabIndex = 0;
            this.btnGenRand.Text = "Generate Random";
            this.btnGenRand.UseVisualStyleBackColor = true;
            this.btnGenRand.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtHasil
            // 
            this.txtHasil.Location = new System.Drawing.Point(18, 67);
            this.txtHasil.Multiline = true;
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.Size = new System.Drawing.Size(237, 182);
            this.txtHasil.TabIndex = 1;
            // 
            // LabelTgl
            // 
            this.LabelTgl.AutoSize = true;
            this.LabelTgl.Location = new System.Drawing.Point(15, 48);
            this.LabelTgl.Name = "LabelTgl";
            this.LabelTgl.Size = new System.Drawing.Size(88, 13);
            this.LabelTgl.TabIndex = 2;
            this.LabelTgl.Text = "Tanggal : ,Bulan:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Jumlah random :";
            // 
            // txtJumlah
            // 
            this.txtJumlah.Location = new System.Drawing.Point(109, 18);
            this.txtJumlah.MaxLength = 2;
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(43, 20);
            this.txtJumlah.TabIndex = 4;
            this.txtJumlah.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJumlah_KeyPress);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtJumlah);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelTgl);
            this.Controls.Add(this.txtHasil);
            this.Controls.Add(this.btnGenRand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Generate Random";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenRand;
        private System.Windows.Forms.TextBox txtHasil;
        private System.Windows.Forms.Label LabelTgl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJumlah;
    }
}

