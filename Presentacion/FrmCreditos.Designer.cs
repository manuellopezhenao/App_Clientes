
namespace Presentacion
{
    partial class FrmCreditos
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
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxPlazo = new System.Windows.Forms.ComboBox();
            this.tblPlazoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_CreditosDataSet3 = new Presentacion.DB_CreditosDataSet3();
            this.tblPlazoTableAdapter = new Presentacion.DB_CreditosDataSet3TableAdapters.TblPlazoTableAdapter();
            this.cbxInteres = new System.Windows.Forms.ComboBox();
            this.tblInteresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_CreditosDataSet4 = new Presentacion.DB_CreditosDataSet4();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.tblInteresTableAdapter = new Presentacion.DB_CreditosDataSet4TableAdapters.TblInteresTableAdapter();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCuota = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPlazoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CreditosDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblInteresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CreditosDataSet4)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 69);
            this.panel1.TabIndex = 0;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.Window;
            this.lblUsuario.Location = new System.Drawing.Point(419, 49);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(64, 20);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(28, 23);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Modulo - Credito";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(11, 88);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 32);
            this.panel2.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(145, 7);
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
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(11, 126);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.MaxLength = 10;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(233, 35);
            this.txtId.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGreen;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(11, 180);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(233, 32);
            this.panel3.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(2, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fecha De Pago";
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPago.Location = new System.Drawing.Point(11, 217);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(233, 35);
            this.dtpFechaPago.TabIndex = 22;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGreen;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(263, 88);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(493, 32);
            this.panel4.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(2, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(263, 126);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.MaxLength = 10;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(493, 35);
            this.txtNombre.TabIndex = 23;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGreen;
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(264, 180);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(235, 32);
            this.panel5.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(152, 7);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "<ENTER>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(2, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monto Solicitado";
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(264, 218);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(2);
            this.txtMonto.MaxLength = 10;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(235, 35);
            this.txtMonto.TabIndex = 25;
            this.txtMonto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMonto_KeyUp);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkGreen;
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(521, 180);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(235, 32);
            this.panel6.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(2, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Plazo";
            // 
            // cbxPlazo
            // 
            this.cbxPlazo.DataSource = this.tblPlazoBindingSource;
            this.cbxPlazo.DisplayMember = "Descripcion";
            this.cbxPlazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPlazo.FormattingEnabled = true;
            this.cbxPlazo.Location = new System.Drawing.Point(521, 220);
            this.cbxPlazo.Name = "cbxPlazo";
            this.cbxPlazo.Size = new System.Drawing.Size(235, 37);
            this.cbxPlazo.TabIndex = 28;
            this.cbxPlazo.ValueMember = "PKId";
            // 
            // tblPlazoBindingSource
            // 
            this.tblPlazoBindingSource.DataMember = "TblPlazo";
            this.tblPlazoBindingSource.DataSource = this.dB_CreditosDataSet3;
            // 
            // dB_CreditosDataSet3
            // 
            this.dB_CreditosDataSet3.DataSetName = "DB_CreditosDataSet3";
            this.dB_CreditosDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPlazoTableAdapter
            // 
            this.tblPlazoTableAdapter.ClearBeforeFill = true;
            // 
            // cbxInteres
            // 
            this.cbxInteres.DataSource = this.tblInteresBindingSource;
            this.cbxInteres.DisplayMember = "Descripcion";
            this.cbxInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxInteres.FormattingEnabled = true;
            this.cbxInteres.Location = new System.Drawing.Point(11, 312);
            this.cbxInteres.Name = "cbxInteres";
            this.cbxInteres.Size = new System.Drawing.Size(235, 37);
            this.cbxInteres.TabIndex = 30;
            this.cbxInteres.ValueMember = "PKId";
            // 
            // tblInteresBindingSource
            // 
            this.tblInteresBindingSource.DataMember = "TblInteres";
            this.tblInteresBindingSource.DataSource = this.dB_CreditosDataSet4;
            // 
            // dB_CreditosDataSet4
            // 
            this.dB_CreditosDataSet4.DataSetName = "DB_CreditosDataSet4";
            this.dB_CreditosDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkGreen;
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(11, 275);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(235, 32);
            this.panel7.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(2, 7);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Interes";
            // 
            // tblInteresTableAdapter
            // 
            this.tblInteresTableAdapter.ClearBeforeFill = true;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkGreen;
            this.panel8.Controls.Add(this.label8);
            this.panel8.Location = new System.Drawing.Point(264, 277);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(235, 32);
            this.panel8.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(2, 7);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Cuota";
            // 
            // txtCuota
            // 
            this.txtCuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuota.Location = new System.Drawing.Point(263, 313);
            this.txtCuota.Margin = new System.Windows.Forms.Padding(2);
            this.txtCuota.MaxLength = 10;
            this.txtCuota.Name = "txtCuota";
            this.txtCuota.ReadOnly = true;
            this.txtCuota.Size = new System.Drawing.Size(235, 35);
            this.txtCuota.TabIndex = 27;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DarkGreen;
            this.panel9.Controls.Add(this.label9);
            this.panel9.Location = new System.Drawing.Point(521, 275);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(235, 32);
            this.panel9.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(2, 7);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "ValorTotal";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.Location = new System.Drawing.Point(521, 313);
            this.txtValorTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorTotal.MaxLength = 10;
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(235, 35);
            this.txtValorTotal.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(521, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 28);
            this.button1.TabIndex = 31;
            this.button1.Text = "&Guardar Credito";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(263, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 28);
            this.button2.TabIndex = 32;
            this.button2.Text = "&Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 353);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(236, 28);
            this.button3.TabIndex = 33;
            this.button3.Text = "&Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmCreditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.txtCuota);
            this.Controls.Add(this.cbxInteres);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.cbxPlazo);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dtpFechaPago);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCreditos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCreditos";
            this.Load += new System.EventHandler(this.FrmCreditos_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.tblPlazoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CreditosDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblInteresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CreditosDataSet4)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxPlazo;
        private DB_CreditosDataSet3 dB_CreditosDataSet3;
        private System.Windows.Forms.BindingSource tblPlazoBindingSource;
        private DB_CreditosDataSet3TableAdapters.TblPlazoTableAdapter tblPlazoTableAdapter;
        private System.Windows.Forms.ComboBox cbxInteres;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private DB_CreditosDataSet4 dB_CreditosDataSet4;
        private System.Windows.Forms.BindingSource tblInteresBindingSource;
        private DB_CreditosDataSet4TableAdapters.TblInteresTableAdapter tblInteresTableAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCuota;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label11;
    }
}