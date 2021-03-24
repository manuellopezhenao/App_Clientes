using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using Negocio;
using System.Linq;

namespace Presentacion
{

    public partial class FrmLogin : Form
    {
        public String[] Numeros = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        public FrmLogin()
        {
            Numeros = RandomizeStrings(Numeros);
            InitializeComponent();
            Ftn_CrearCuadricula();
        }
        String var = "";
        int contador = 0;
        public void Ftn_CrearCuadricula(){
            btn1.Text = Numeros[1];
            btn2.Text = Numeros[2];
            btn3.Text = Numeros[3];
            btn4.Text = Numeros[4];
            btn5.Text = Numeros[5];
            btn6.Text = Numeros[6];
            btn7.Text = Numeros[7];
            btn8.Text = Numeros[8];
            btn9.Text = Numeros[9];
            btn0.Text = Numeros[0];
        }

        static Random _random = new Random();

        public static string[] RandomizeStrings(string[] arr)
        {
            List<KeyValuePair<int, string>> list = new List<KeyValuePair<int, string>>();
            // Add all strings from array
            // Add new random int each time
            foreach (string s in arr)
            {
                list.Add(new KeyValuePair<int, string>(_random.Next(), s));
            }
            // Sort the list by the random number
            var sorted = from item in list
                         orderby item.Key
                         select item;
            // Allocate new string array
            string[] result = new string[arr.Length];
            // Copy values to array
            int index = 0;
            foreach (KeyValuePair<int, string> pair in sorted)
            {
                result[index] = pair.Value;
                index++;
            }
            // Return copied array
            return result;
        }


        protected void Ftn_IngresarClave(String X) {
            
            if (contador == 4)
            {
                return;
            }
            else
            {
                var = var + X;
                txtClave.Text = var;
                contador++;

            }

            Numeros = RandomizeStrings(Numeros);

        }

        private void btn1_Click(object sender, EventArgs e)
        {

            Ftn_IngresarClave(Numeros[1]);

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Ftn_IngresarClave(Numeros[2]);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Ftn_IngresarClave(Numeros[3]);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Ftn_IngresarClave(Numeros[4]);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Ftn_IngresarClave(Numeros[5]);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Ftn_IngresarClave(Numeros[6]);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Ftn_IngresarClave(Numeros[7]);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Ftn_IngresarClave(Numeros[8]);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Ftn_IngresarClave(Numeros[9]);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Ftn_IngresarClave(Numeros[0]);
        }

        private void btnSupri_Click(object sender, EventArgs e)
        {
            var = "";
            txtClave.Clear();
            contador = 0;
        }

        private void ChMostrar_CheckedChanged(object sender, EventArgs e)
        {
            txtClave.PasswordChar = (ChMostrar.Checked==true) ?  '\0' :  '＊';
        }

        protected void Ftn_NumAsteriscos()
        {
            btn1.Text = "＊";
            btn2.Text = "＊";
            btn3.Text = "＊";
            btn4.Text = "＊";
            btn5.Text = "＊";
            btn6.Text = "＊";
            btn7.Text = "＊";
            btn8.Text = "＊";
            btn9.Text = "＊";
            btn0.Text = "＊";
        }

        protected void Ftn_Num()
        {
            Ftn_CrearCuadricula();
        }
        private void btn1_MouseHover(object sender, EventArgs e)
        {
            Ftn_NumAsteriscos();

        }

        private void btn2_MouseHover(object sender, EventArgs e)
        {
            Ftn_NumAsteriscos();
        }

        private void btn3_MouseHover(object sender, EventArgs e)
        {
            Ftn_NumAsteriscos();
        }

        private void btn4_MouseHover(object sender, EventArgs e)
        {
            Ftn_NumAsteriscos();
        }

        private void btn5_MouseHover(object sender, EventArgs e)
        {
            Ftn_NumAsteriscos();
        }

        private void btn1_MouseLeave(object sender, EventArgs e)
        {
            Ftn_NumAsteriscos();
        }

        private void btn6_MouseHover(object sender, EventArgs e)
        {
            Ftn_NumAsteriscos();
        }

        private void btn7_MouseHover(object sender, EventArgs e)
        {
            Ftn_NumAsteriscos();
        }

        private void btn8_MouseHover(object sender, EventArgs e)
        {
            Ftn_NumAsteriscos();
        }

        private void btn9_MouseHover(object sender, EventArgs e)
        {
            Ftn_NumAsteriscos();
        }

        private void btn0_MouseHover(object sender, EventArgs e)
        {
            Ftn_NumAsteriscos();
        }

        private void btn2_MouseLeave(object sender, EventArgs e)
        {
            Ftn_Num();
        }

        private void btn3_MouseLeave(object sender, EventArgs e)
        {
            Ftn_Num();
        }

        private void btn4_MouseLeave(object sender, EventArgs e)
        {
            Ftn_Num();
        }

        private void btn5_MouseLeave(object sender, EventArgs e)
        {
            Ftn_Num();
        }

        private void btn6_MouseLeave(object sender, EventArgs e)
        {
            Ftn_Num();
        }

        private void btn7_MouseLeave(object sender, EventArgs e)
        {
            Ftn_Num();
        }

        private void btn8_MouseLeave(object sender, EventArgs e)
        {
            Ftn_Num();
        }

        private void btn9_MouseLeave(object sender, EventArgs e)
        {
            Ftn_Num();
        }

        private void btn0_MouseLeave(object sender, EventArgs e)
        {
            Ftn_Num();
        }

        protected void Ftn_EnviarParametros()
        {
            ClsLogin_Negocio ObjEnviar = new ClsLogin_Negocio();
            ObjEnviar.Ftn_Ingresar(CbxUsuario.Text, txtClave.Text);

            if (ObjEnviar.sw == 1)
            {
                FrmPrincipal ObjetoPrincipal = new FrmPrincipal();
                ObjetoPrincipal.lblUsuario.Text = ObjEnviar.nombre;
                ObjetoPrincipal.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Clave incorrecta y/o Estado inactivo");
            }
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            Ftn_EnviarParametros();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dB_CreditosDataSet.TblCredenciales' Puede moverla o quitarla según sea necesario.
            this.tblCredencialesTableAdapter.Fill(this.dB_CreditosDataSet.TblCredenciales);

        }
    }
}
