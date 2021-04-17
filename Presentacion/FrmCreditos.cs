using System;
using Negocio;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmCreditos : Form
    {
        public FrmCreditos()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCreditos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dB_CreditosDataSet4.TblInteres' Puede moverla o quitarla según sea necesario.
            this.tblInteresTableAdapter.Fill(this.dB_CreditosDataSet4.TblInteres);
            // TODO: esta línea de código carga datos en la tabla 'dB_CreditosDataSet3.TblPlazo' Puede moverla o quitarla según sea necesario.
            this.tblPlazoTableAdapter.Fill(this.dB_CreditosDataSet3.TblPlazo);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected void Fnt_CalcularCuota()
        {
            ClsClientes_Negocio ObjCalcularCuota = new ClsClientes_Negocio();
            ObjCalcularCuota.Fnt_CalcularCuota(txtMonto.Text, Convert.ToInt32(cbxPlazo.Text));
            txtCuota.Text = Convert.ToString(ObjCalcularCuota.cuota2);
            txtValorTotal.Text = Convert.ToString(ObjCalcularCuota.total);
            cbxInteres.SelectedIndex = Convert.ToInt32(ObjCalcularCuota.pos);
        }


        private void txtMonto_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Fnt_CalcularCuota();
            }
        }
    }
}
