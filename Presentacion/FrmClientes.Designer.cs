namespace Presentacion
{
    partial class FrmClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIngresos = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtContacEmpresa = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxSexo = new System.Windows.Forms.ComboBox();
            this.tblSexoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_CreditosDataSet2 = new Presentacion.DB_CreditosDataSet2();
            this.cbxCivil = new System.Windows.Forms.ComboBox();
            this.tblEstadoCivilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_CreditosDataSet1 = new Presentacion.DB_CreditosDataSet1();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSupri = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tblEstadoCivilTableAdapter = new Presentacion.DB_CreditosDataSet1TableAdapters.TblEstadoCivilTableAdapter();
            this.tblSexoTableAdapter = new Presentacion.DB_CreditosDataSet2TableAdapters.TblSexoTableAdapter();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSexoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CreditosDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEstadoCivilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CreditosDataSet1)).BeginInit();
            this.panel11.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 22);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 55);
            this.panel1.TabIndex = 0;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUsuario.Location = new System.Drawing.Point(500, 38);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(58, 16);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(436, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 16);
            this.label13.TabIndex = 3;
            this.label13.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modulo - Registro de Clientes";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(9, 180);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.MaxLength = 10;
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(350, 35);
            this.txtId.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(9, 142);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 32);
            this.panel2.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(272, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "<ENTER>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(2, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Identificación";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGreen;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(9, 265);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(603, 32);
            this.panel3.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(2, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombres";
            // 
            // txtNombres
            // 
            this.txtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(9, 302);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombres.MaxLength = 500;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(604, 35);
            this.txtNombres.TabIndex = 18;
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombres_KeyPress);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGreen;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(9, 354);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(349, 32);
            this.panel4.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(2, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Correo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(9, 392);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreo.MaxLength = 100;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(350, 35);
            this.txtCorreo.TabIndex = 20;
            this.txtCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorreo_KeyPress);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGreen;
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(9, 444);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(349, 32);
            this.panel5.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(2, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Contacto";
            // 
            // txtContacto
            // 
            this.txtContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContacto.Location = new System.Drawing.Point(9, 481);
            this.txtContacto.Margin = new System.Windows.Forms.Padding(2);
            this.txtContacto.MaxLength = 10;
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(350, 35);
            this.txtContacto.TabIndex = 20;
            this.txtContacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContacto_KeyPress);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkGreen;
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(371, 354);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(241, 32);
            this.panel6.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(2, 7);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Edad";
            // 
            // txtEdad
            // 
            this.txtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(371, 392);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(2);
            this.txtEdad.MaxLength = 3;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(242, 35);
            this.txtEdad.TabIndex = 30;
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkGreen;
            this.panel7.Controls.Add(this.label8);
            this.panel7.Location = new System.Drawing.Point(371, 444);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(241, 32);
            this.panel7.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(2, 7);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ingresos";
            // 
            // txtIngresos
            // 
            this.txtIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngresos.Location = new System.Drawing.Point(371, 481);
            this.txtIngresos.Margin = new System.Windows.Forms.Padding(2);
            this.txtIngresos.MaxLength = 10;
            this.txtIngresos.Name = "txtIngresos";
            this.txtIngresos.Size = new System.Drawing.Size(242, 35);
            this.txtIngresos.TabIndex = 32;
            this.txtIngresos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIngresos_KeyPress);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkGreen;
            this.panel8.Controls.Add(this.label9);
            this.panel8.Location = new System.Drawing.Point(9, 531);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(349, 32);
            this.panel8.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(2, 7);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Empresa";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpresa.Location = new System.Drawing.Point(9, 569);
            this.txtEmpresa.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmpresa.MaxLength = 400;
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(350, 35);
            this.txtEmpresa.TabIndex = 34;
            this.txtEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpresa_KeyPress);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DarkGreen;
            this.panel9.Controls.Add(this.label10);
            this.panel9.Location = new System.Drawing.Point(371, 531);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(241, 32);
            this.panel9.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(2, 7);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Contacto Empresa";
            // 
            // txtContacEmpresa
            // 
            this.txtContacEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContacEmpresa.Location = new System.Drawing.Point(371, 569);
            this.txtContacEmpresa.Margin = new System.Windows.Forms.Padding(2);
            this.txtContacEmpresa.MaxLength = 10;
            this.txtContacEmpresa.Name = "txtContacEmpresa";
            this.txtContacEmpresa.Size = new System.Drawing.Size(242, 35);
            this.txtContacEmpresa.TabIndex = 36;
            this.txtContacEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContacEmpresa_KeyPress);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DarkGreen;
            this.panel10.Controls.Add(this.label11);
            this.panel10.Location = new System.Drawing.Point(371, 619);
            this.panel10.Margin = new System.Windows.Forms.Padding(2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(241, 32);
            this.panel10.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(2, 7);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Sexo";
            // 
            // cbxSexo
            // 
            this.cbxSexo.DataSource = this.tblSexoBindingSource;
            this.cbxSexo.DisplayMember = "Descripcion";
            this.cbxSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSexo.FormattingEnabled = true;
            this.cbxSexo.Location = new System.Drawing.Point(371, 657);
            this.cbxSexo.Margin = new System.Windows.Forms.Padding(2);
            this.cbxSexo.Name = "cbxSexo";
            this.cbxSexo.Size = new System.Drawing.Size(242, 34);
            this.cbxSexo.TabIndex = 40;
            this.cbxSexo.ValueMember = "PKId";
            // 
            // tblSexoBindingSource
            // 
            this.tblSexoBindingSource.DataMember = "TblSexo";
            this.tblSexoBindingSource.DataSource = this.dB_CreditosDataSet2;
            // 
            // dB_CreditosDataSet2
            // 
            this.dB_CreditosDataSet2.DataSetName = "DB_CreditosDataSet2";
            this.dB_CreditosDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxCivil
            // 
            this.cbxCivil.DataSource = this.tblEstadoCivilBindingSource;
            this.cbxCivil.DisplayMember = "Descripcion";
            this.cbxCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCivil.FormattingEnabled = true;
            this.cbxCivil.Location = new System.Drawing.Point(9, 657);
            this.cbxCivil.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCivil.Name = "cbxCivil";
            this.cbxCivil.Size = new System.Drawing.Size(350, 34);
            this.cbxCivil.TabIndex = 42;
            this.cbxCivil.ValueMember = "PKId";
            // 
            // tblEstadoCivilBindingSource
            // 
            this.tblEstadoCivilBindingSource.DataMember = "TblEstadoCivil";
            this.tblEstadoCivilBindingSource.DataSource = this.dB_CreditosDataSet1;
            // 
            // dB_CreditosDataSet1
            // 
            this.dB_CreditosDataSet1.DataSetName = "DB_CreditosDataSet1";
            this.dB_CreditosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.DarkGreen;
            this.panel11.Controls.Add(this.label12);
            this.panel11.Location = new System.Drawing.Point(9, 619);
            this.panel11.Margin = new System.Windows.Forms.Padding(2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(349, 32);
            this.panel11.TabIndex = 41;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Window;
            this.label12.Location = new System.Drawing.Point(2, 7);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Estado Civil";
            // 
            // btnSupri
            // 
            this.btnSupri.BackColor = System.Drawing.Color.Firebrick;
            this.btnSupri.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSupri.Location = new System.Drawing.Point(410, 217);
            this.btnSupri.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupri.Name = "btnSupri";
            this.btnSupri.Size = new System.Drawing.Size(58, 32);
            this.btnSupri.TabIndex = 54;
            this.btnSupri.Text = "Supr";
            this.btnSupri.UseVisualStyleBackColor = false;
            this.btnSupri.Click += new System.EventHandler(this.btnSupri_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.ForestGreen;
            this.btnEnter.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEnter.Location = new System.Drawing.Point(532, 217);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(58, 32);
            this.btnEnter.TabIndex = 53;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(470, 217);
            this.btn0.Margin = new System.Windows.Forms.Padding(2);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(58, 32);
            this.btn0.TabIndex = 52;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(410, 180);
            this.btn7.Margin = new System.Windows.Forms.Padding(2);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(58, 32);
            this.btn7.TabIndex = 51;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(532, 180);
            this.btn9.Margin = new System.Windows.Forms.Padding(2);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(58, 32);
            this.btn9.TabIndex = 50;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(470, 180);
            this.btn8.Margin = new System.Windows.Forms.Padding(2);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(58, 32);
            this.btn8.TabIndex = 49;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(410, 142);
            this.btn4.Margin = new System.Windows.Forms.Padding(2);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(58, 32);
            this.btn4.TabIndex = 48;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(470, 142);
            this.btn5.Margin = new System.Windows.Forms.Padding(2);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(58, 32);
            this.btn5.TabIndex = 47;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(532, 142);
            this.btn6.Margin = new System.Windows.Forms.Padding(2);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(58, 32);
            this.btn6.TabIndex = 46;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(532, 105);
            this.btn3.Margin = new System.Windows.Forms.Padding(2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(58, 32);
            this.btn3.TabIndex = 45;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(470, 105);
            this.btn2.Margin = new System.Windows.Forms.Padding(2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(58, 32);
            this.btn2.TabIndex = 44;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(410, 105);
            this.btn1.Margin = new System.Windows.Forms.Padding(2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(58, 32);
            this.btn1.TabIndex = 43;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGreen;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(723, 24);
            this.menuStrip1.TabIndex = 55;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.actualizarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoToolStripMenuItem.Text = "&Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guardarToolStripMenuItem.Text = "&Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.actualizarToolStripMenuItem.Text = "&Actualizar";
            this.actualizarToolStripMenuItem.Click += new System.EventHandler(this.actualizarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // tblEstadoCivilTableAdapter
            // 
            this.tblEstadoCivilTableAdapter.ClearBeforeFill = true;
            // 
            // tblSexoTableAdapter
            // 
            this.tblSexoTableAdapter.ClearBeforeFill = true;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(132, 707);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(126, 25);
            this.lblMensaje.TabIndex = 56;
            this.lblMensaje.Text = "lblMensaje";
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(723, 752);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnSupri);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.cbxCivil);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.cbxSexo);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.txtContacEmpresa);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.txtIngresos);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtContacto);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmClientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSexoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CreditosDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEstadoCivilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CreditosDataSet1)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIngresos;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtContacEmpresa;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxSexo;
        private System.Windows.Forms.ComboBox cbxCivil;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSupri;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        public System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label13;
        private DB_CreditosDataSet1 dB_CreditosDataSet1;
        private System.Windows.Forms.BindingSource tblEstadoCivilBindingSource;
        private DB_CreditosDataSet1TableAdapters.TblEstadoCivilTableAdapter tblEstadoCivilTableAdapter;
        private DB_CreditosDataSet2 dB_CreditosDataSet2;
        private System.Windows.Forms.BindingSource tblSexoBindingSource;
        private DB_CreditosDataSet2TableAdapters.TblSexoTableAdapter tblSexoTableAdapter;
        private System.Windows.Forms.Label lblMensaje;
    }
}