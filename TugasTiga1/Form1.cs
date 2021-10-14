using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasTiga1
{
    public partial class frmTugasTiga1 : Form
    {
        public frmTugasTiga1()
        {
            InitializeComponent();
        }

       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmTugasTiga1_Load(object sender, EventArgs e)
        {

        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            lblNim.Text = "Nim : 20.11.3560";
            lblNama.Text = "Nama : irsandi";
            lblKelas.Text = "Kelas : IF05";
        }

        private void btnKosongkan_Click(object sender, EventArgs e)
        {
            lblNim.Text = "Nim :";
            lblNama.Text = "Nama :";
            lblKelas.Text = "Kelas :";
        }

    }
}
