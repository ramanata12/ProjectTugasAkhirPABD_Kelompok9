using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TokoPunakawan1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Pemesanan().Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DaftarMenu().Show();
        }

        private void KELUAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
