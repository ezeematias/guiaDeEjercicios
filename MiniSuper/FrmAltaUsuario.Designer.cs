
namespace MiniSuper
{
    partial class FrmAltaUsuario
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.numDni = new System.Windows.Forms.NumericUpDown();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtFormaPago = new System.Windows.Forms.Label();
            this.chkEfectivo = new System.Windows.Forms.CheckBox();
            this.chkTarjeta = new System.Windows.Forms.CheckBox();
            this.chkAplicacion = new System.Windows.Forms.CheckBox();
            this.pnl = new System.Windows.Forms.Panel();
            this.groupBoxMedioDePAgo = new System.Windows.Forms.GroupBox();
            this.optAplicacion = new System.Windows.Forms.RadioButton();
            this.otpTarjeta = new System.Windows.Forms.RadioButton();
            this.optEfectivo = new System.Windows.Forms.RadioButton();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numDni)).BeginInit();
            this.pnl.SuspendLayout();
            this.groupBoxMedioDePAgo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(29, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Ingrese Nombre";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(29, 68);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(82, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Ingrese Apellido";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(32, 117);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 2;
            this.lblDni.Text = "DNI";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(118, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(118, 68);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 4;
            // 
            // numDni
            // 
            this.numDni.Location = new System.Drawing.Point(118, 109);
            this.numDni.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numDni.Minimum = new decimal(new int[] {
            8000000,
            0,
            0,
            0});
            this.numDni.Name = "numDni";
            this.numDni.Size = new System.Drawing.Size(100, 20);
            this.numDni.TabIndex = 5;
            this.numDni.Value = new decimal(new int[] {
            8000000,
            0,
            0,
            0});
            // 
            // btnOk
            // 
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(35, 491);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(183, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "&Aceptar";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtFormaPago
            // 
            this.txtFormaPago.AutoSize = true;
            this.txtFormaPago.Location = new System.Drawing.Point(32, 151);
            this.txtFormaPago.Name = "txtFormaPago";
            this.txtFormaPago.Size = new System.Drawing.Size(79, 13);
            this.txtFormaPago.TabIndex = 7;
            this.txtFormaPago.Text = "Forma de Pago";
            // 
            // chkEfectivo
            // 
            this.chkEfectivo.AutoSize = true;
            this.chkEfectivo.Checked = true;
            this.chkEfectivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEfectivo.Location = new System.Drawing.Point(37, 6);
            this.chkEfectivo.Name = "chkEfectivo";
            this.chkEfectivo.Size = new System.Drawing.Size(65, 17);
            this.chkEfectivo.TabIndex = 8;
            this.chkEfectivo.Text = "Efectivo";
            this.chkEfectivo.UseVisualStyleBackColor = true;
            this.chkEfectivo.CheckedChanged += new System.EventHandler(this.chkEfectivo_CheckedChanged);
            // 
            // chkTarjeta
            // 
            this.chkTarjeta.AutoSize = true;
            this.chkTarjeta.Checked = true;
            this.chkTarjeta.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTarjeta.Location = new System.Drawing.Point(37, 30);
            this.chkTarjeta.Name = "chkTarjeta";
            this.chkTarjeta.Size = new System.Drawing.Size(59, 17);
            this.chkTarjeta.TabIndex = 9;
            this.chkTarjeta.Text = "Tarjeta";
            this.chkTarjeta.UseVisualStyleBackColor = true;
            // 
            // chkAplicacion
            // 
            this.chkAplicacion.AutoSize = true;
            this.chkAplicacion.Checked = true;
            this.chkAplicacion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAplicacion.Location = new System.Drawing.Point(37, 54);
            this.chkAplicacion.Name = "chkAplicacion";
            this.chkAplicacion.Size = new System.Drawing.Size(75, 17);
            this.chkAplicacion.TabIndex = 10;
            this.chkAplicacion.Text = "Aplicación";
            this.chkAplicacion.UseVisualStyleBackColor = true;
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.chkAplicacion);
            this.pnl.Controls.Add(this.chkEfectivo);
            this.pnl.Controls.Add(this.chkTarjeta);
            this.pnl.Location = new System.Drawing.Point(35, 179);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(200, 79);
            this.pnl.TabIndex = 11;
            // 
            // groupBoxMedioDePAgo
            // 
            this.groupBoxMedioDePAgo.Controls.Add(this.optAplicacion);
            this.groupBoxMedioDePAgo.Controls.Add(this.otpTarjeta);
            this.groupBoxMedioDePAgo.Controls.Add(this.optEfectivo);
            this.groupBoxMedioDePAgo.Location = new System.Drawing.Point(32, 274);
            this.groupBoxMedioDePAgo.Name = "groupBoxMedioDePAgo";
            this.groupBoxMedioDePAgo.Size = new System.Drawing.Size(202, 61);
            this.groupBoxMedioDePAgo.TabIndex = 12;
            this.groupBoxMedioDePAgo.TabStop = false;
            this.groupBoxMedioDePAgo.Text = "Medio de Pago";
            // 
            // optAplicacion
            // 
            this.optAplicacion.AutoSize = true;
            this.optAplicacion.Location = new System.Drawing.Point(124, 20);
            this.optAplicacion.Name = "optAplicacion";
            this.optAplicacion.Size = new System.Drawing.Size(74, 17);
            this.optAplicacion.TabIndex = 2;
            this.optAplicacion.TabStop = true;
            this.optAplicacion.Text = "Aplicación";
            this.optAplicacion.UseVisualStyleBackColor = true;
            // 
            // otpTarjeta
            // 
            this.otpTarjeta.AutoSize = true;
            this.otpTarjeta.Location = new System.Drawing.Point(67, 20);
            this.otpTarjeta.Name = "otpTarjeta";
            this.otpTarjeta.Size = new System.Drawing.Size(58, 17);
            this.otpTarjeta.TabIndex = 1;
            this.otpTarjeta.TabStop = true;
            this.otpTarjeta.Text = "Tarjeta";
            this.otpTarjeta.UseVisualStyleBackColor = true;
            // 
            // optEfectivo
            // 
            this.optEfectivo.AutoSize = true;
            this.optEfectivo.Location = new System.Drawing.Point(7, 20);
            this.optEfectivo.Name = "optEfectivo";
            this.optEfectivo.Size = new System.Drawing.Size(64, 17);
            this.optEfectivo.TabIndex = 0;
            this.optEfectivo.TabStop = true;
            this.optEfectivo.Text = "Efectivo";
            this.optEfectivo.UseVisualStyleBackColor = true;
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(35, 353);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(51, 13);
            this.lblProvincia.TabIndex = 13;
            this.lblProvincia.Text = "Provincia";
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Items.AddRange(new object[] {
            "Buenos Aires",
            "Córdoba",
            "Mendoza",
            "Santa Cruz",
            "San Luis",
            "San Juan",
            "La Pampa",
            "Entre Rios"});
            this.cmbProvincia.Location = new System.Drawing.Point(97, 353);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(121, 21);
            this.cmbProvincia.TabIndex = 14;
            this.cmbProvincia.SelectedIndexChanged += new System.EventHandler(this.cmbProvincia_SelectedIndexChanged);
            // 
            // FrmAltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 554);
            this.Controls.Add(this.cmbProvincia);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.groupBoxMedioDePAgo);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.txtFormaPago);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.numDni);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblName);
            this.Name = "FrmAltaUsuario";
            this.Text = "Alta de Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.numDni)).EndInit();
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.groupBoxMedioDePAgo.ResumeLayout(false);
            this.groupBoxMedioDePAgo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.NumericUpDown numDni;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label txtFormaPago;
        private System.Windows.Forms.CheckBox chkEfectivo;
        private System.Windows.Forms.CheckBox chkTarjeta;
        private System.Windows.Forms.CheckBox chkAplicacion;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.GroupBox groupBoxMedioDePAgo;
        private System.Windows.Forms.RadioButton optAplicacion;
        private System.Windows.Forms.RadioButton otpTarjeta;
        private System.Windows.Forms.RadioButton optEfectivo;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.ComboBox cmbProvincia;
    }
}