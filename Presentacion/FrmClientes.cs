using System;
using Negocio;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Presentacion
{

    public partial class FrmClientes : Form
    {
        Dictionary<String, String> cliente = new Dictionary<string, String>();

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
            Fnt_Limpiar();
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

        protected void Fnt_ConsultarCliente()
        {
            ClsClientes_Negocio ObjetoConsultar = new ClsClientes_Negocio();
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
        public Dictionary<string, String> MapearInfo2()
        {
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

            return cliente;
        }
        public void MapearInfo()
        {
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
        }
        protected void Ftn_AgregarCliente()
        {
            ClsClientes_Negocio ObjetoCliente = new ClsClientes_Negocio();
            MapearInfo();
            ObjetoCliente.Fnt_AgregarCliente(cliente);
            lblMensaje.Text = ObjetoCliente.msn;
        }
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ftn_AgregarCliente();
        }

        protected void Fnt_Limpiar()
        {
            txtId.Clear();
            txtNombres.Clear();
            txtContacto.Clear();
            txtCorreo.Clear();
            txtEdad.Clear();
            txtIngresos.Clear();
            txtEmpresa.Clear();
            txtContacEmpresa.Clear();
            cbxSexo.SelectedIndex = 0;
            cbxCivil.SelectedIndex = 0;
            contador = 0;
            var = "";
            txtId.Focus();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fnt_Limpiar();
        }

        private void Fnt_ActualizarCliente()
        {
            ClsClientes_Negocio ObjetoActualizar = new ClsClientes_Negocio();
            ObjetoActualizar.Fnt_ActualizarCliente(txtId.Text, txtContacto.Text, txtCorreo.Text, txtEdad.Text, txtIngresos.Text, txtEmpresa.Text, txtContacEmpresa.Text, cbxCivil.SelectedIndex);
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fnt_ActualizarCliente();

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            ClsClientes_Negocio ObjetoNegocio = new ClsClientes_Negocio();
            MapearInfo();
            txtNombres.Text = cliente["id"];
            cliente = ObjetoNegocio.Fnt_ConsultarCliente(cliente);

            //MapearInfo();
            txtNombres.Text = cliente["nombres"];
            txtCorreo.Text = cliente["correo"];
            txtEdad.Text = cliente["edad"];
            txtContacto.Text = cliente["contacto"];
            txtIngresos.Text = cliente["ingresos"];
            txtEmpresa.Text = cliente["empresa"];
            txtContacEmpresa.Text = cliente["contactoE"];
            txtNombres.Text = cliente["nombres"];
            cbxSexo.SelectedIndex = Convert.ToInt32(cliente["sexo"]);
            cbxCivil.SelectedIndex = Convert.ToInt32(cliente["estado"]);
            lblMensaje.Text = ObjetoNegocio.msn;
        }
    }
}
