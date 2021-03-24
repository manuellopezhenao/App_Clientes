using System;
using Negocio;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Presentacion
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }
        String var = "";
        int contador = 0;

        private void btn1_Click(object sender, EventArgs e)
        {
            if (contador == 10)
            {
                return;
            }
            else
            {
                var = var + "1";
                txtId.Text = var;
                contador++;

            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (contador == 10)
            {
                return;
            }
            else
            {
                var = var + "2";
                txtId.Text = var;
                contador++;

            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (contador == 10)
            {
                return;
            }
            else
            {
                var = var + "3";
                txtId.Text = var;
                contador++;

            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (contador == 10)
            {
                return;
            }
            else
            {
                var = var + "4";
                txtId.Text = var;
                contador++;

            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (contador == 10)
            {
                return;
            }
            else
            {
                var = var + "5";
                txtId.Text = var;
                contador++;

            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (contador == 10)
            {
                return;
            }
            else
            {
                var = var + "6";
                txtId.Text = var;
                contador++;

            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (contador == 10)
            {
                return;
            }
            else
            {
                var = var + "7";
                txtId.Text = var;
                contador++;

            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (contador == 10)
            {
                return;
            }
            else
            {
                var = var + "8";
                txtId.Text = var;
                contador++;

            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (contador == 10)
            {
                return;
            }
            else
            {
                var = var + "9";
                txtId.Text = var;
                contador++;

            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (contador == 10)
            {
                return;
            }
            else
            {
                var = var + "0";
                txtId.Text = var;
                contador++;

            }
        }

        private void btnSupri_Click(object sender, EventArgs e)
        {
            var = "";
            txtId.Clear();
            contador = 0;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dB_CreditosDataSet2.TblSexo' Puede moverla o quitarla según sea necesario.
            this.tblSexoTableAdapter.Fill(this.dB_CreditosDataSet2.TblSexo);
            // TODO: esta línea de código carga datos en la tabla 'dB_CreditosDataSet1.TblEstadoCivil' Puede moverla o quitarla según sea necesario.
            this.tblEstadoCivilTableAdapter.Fill(this.dB_CreditosDataSet1.TblEstadoCivil);

        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void txtContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void txtIngresos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void txtEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

        }

        private void txtContacEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }
        protected void Ftn_AgregarCliente()
        {
            ClsClientes_Negocio ObjetoCliente = new ClsClientes_Negocio();
            var cliente = new Dictionary<string, String>();
            cliente["id"] = txtId.Text;
            cliente["nombres"] = txtNombres.Text;
            cliente["contacto"] = txtContacto.Text;
            cliente["correo"] = txtCorreo.Text;
            cliente["edad"] = txtEdad.Text;
            cliente["ingresos"] = txtIngresos.Text;
            cliente["empresa"] = txtEmpresa.Text;
            cliente["contactoE"] = txtContacEmpresa.Text;
            cliente["sexo"] = Convert.ToString(cbxSexo.SelectedValue);
            cliente["estado"] = Convert.ToString(cbxCivil.SelectedValue);
            ObjetoCliente.Fnt_AgregarCliente(cliente);
            lblMensaje.Text = ObjetoCliente.msn;
        }
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ftn_AgregarCliente();
        }
    }
}
