
namespace TugasTiga1
{
    partial class frmTugasTiga1
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
            this.lblNim = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblKelas = new System.Windows.Forms.Label();
            this.btnKosongkan = new System.Windows.Forms.Button();
            this.btnTampilkan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNim
            // 
            this.lblNim.AutoSize = true;
            this.lblNim.Location = new System.Drawing.Point(53, 62);
            this.lblNim.Name = "lblNim";
            this.lblNim.Size = new System.Drawing.Size(140, 20);
            this.lblNim.TabIndex = 0;
            this.lblNim.Text = "Nim    : 20.11.3560";
            this.lblNim.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(53, 116);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(109, 20);
            this.lblNama.TabIndex = 1;
            this.lblNama.Text = "Nama : irsandi";
            // 
            // lblKelas
            // 
            this.lblKelas.AutoSize = true;
            this.lblKelas.Location = new System.Drawing.Point(53, 171);
            this.lblKelas.Name = "lblKelas";
            this.lblKelas.Size = new System.Drawing.Size(93, 20);
            this.lblKelas.TabIndex = 2;
            this.lblKelas.Text = "Kelas : IF05";
            // 
            // btnKosongkan
            // 
            this.btnKosongkan.Location = new System.Drawing.Point(300, 253);
            this.btnKosongkan.Name = "btnKosongkan";
            this.btnKosongkan.Size = new System.Drawing.Size(148, 38);
            this.btnKosongkan.TabIndex = 4;
            this.btnKosongkan.Text = "Kosongkan";
            this.btnKosongkan.UseVisualStyleBackColor = true;
            this.btnKosongkan.Click += new System.EventHandler(this.btnKosongkan_Click);
            // 
            // btnTampilkan
            // 
            this.btnTampilkan.Location = new System.Drawing.Point(57, 253);
            this.btnTampilkan.Name = "btnTampilkan";
            this.btnTampilkan.Size = new System.Drawing.Size(158, 38);
            this.btnTampilkan.TabIndex = 5;
            this.btnTampilkan.Text = "Tampilkan";
            this.btnTampilkan.UseVisualStyleBackColor = true;
            this.btnTampilkan.Click += new System.EventHandler(this.btnTampilkan_Click);
            // 
            // frmTugasTiga1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 450);
            this.Controls.Add(this.btnTampilkan);
            this.Controls.Add(this.btnKosongkan);
            this.Controls.Add(this.lblKelas);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.lblNim);
            this.Name = "frmTugasTiga1";
            this.Text = "Tugas 3.1";
            this.Load += new System.EventHandler(this.frmTugasTiga1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNim;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblKelas;
        private System.Windows.Forms.Button btnKosongkan;
        private System.Windows.Forms.Button btnTampilkan;
    }
}

