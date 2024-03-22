using imcApp5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void aptSaudacoes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá");
        }

        private void aptSobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("App developed by Jhou1607");
        }

        private void aptSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EndSession_Click(object sender, EventArgs e)
        {
            FrmLogin log = new FrmLogin();
            log.Show();
            this.Hide();
        }

        private void aptCalcIMC_Click(object sender, EventArgs e)
        {

            ImcApp imc = new ImcApp();
            imc.Show();
            this.Hide();

        }
    }
}
