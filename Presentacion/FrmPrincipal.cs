using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        protected void Ftn_ModuloClientes()
        {
            FrmClientes ObjetoCliente = new FrmClientes();
            ObjetoCliente.lblUsuario.Text = lblUsuario.Text;
            ObjetoCliente.ShowDialog();

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Ftn_ModuloClientes();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FrmLogin ObjeLogin = new FrmLogin();
            ObjeLogin.Show();
            this.Close();
        }
    }
}
