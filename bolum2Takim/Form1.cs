using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bolum2Takim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTakim1_Click(object sender, EventArgs e)
        {
            lblTakim.BackColor = Color.Blue;
            lblTakim.ForeColor = Color.Blue;
            lblTakim.Text = "şampiyon fenerbahçe";
            


        }

        private void lblTakim_Click(object sender, EventArgs e)
        {

        }

        private void btnTakim2_Click(object sender, EventArgs e)
        {
            lblTakim.BackColor = Color.Red;
            lblTakim.ForeColor = Color.Yellow;
            lblTakim.Text = "şampiyon galatasaray";
        }

        private void btnTakim3_Click(object sender, EventArgs e)
        {
            lblTakim.BackColor = Color.Purple;
            lblTakim.ForeColor = Color.Blue;
            lblTakim.Text = "şampiyon trabzonspor";
        }

        private void btnTakim4_Click(object sender, EventArgs e)
        {
            lblTakim.BackColor = Color.Black;
            lblTakim.ForeColor = Color.White;
            lblTakim.Text = "şampiyon beşiktaş";
        }
    }
}
