using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HitungBelanja
{
    public partial class FrmTampilSignIn : Form
    {
        public FrmTampilSignIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmTampilBarang frm = new FrmTampilBarang();
            frm.ShowDialog();
            
        }

        private void TextUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
