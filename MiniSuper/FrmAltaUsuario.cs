using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniSuper
{
    public partial class FrmAltaUsuario : Form
    {
        private Usuario usuario;
        public FrmAltaUsuario()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // Checkbox
            string[] formasDePAgo = new string[0];
            foreach (Control miControl in this.pnl.Controls)
            {
                if (miControl is CheckBox && ((CheckBox)miControl).Checked)
                {
                    Array.Resize<string>(ref formasDePAgo, formasDePAgo.Length + 1);
                    formasDePAgo[formasDePAgo.Length - 1] = ((CheckBox)miControl).Text;
                }
            }

            //Radio Button
            string medioDePago = String.Empty;
            foreach (Control item in groupBoxMedioDePAgo.Controls)
            {
                if (item is RadioButton && ((RadioButton)item).Checked)
                {
                    medioDePago = item.Text;
                }
            }

            //ComboBoc

            // this.cmbProvincia.DataSource = (Se le puede pasar la colección en está opción)
            string provincia = String.Empty;
            if (this.cmbProvincia.SelectedIndex == -1)
            {
                if (this.cmbProvincia.Text != String.Empty)
                {
                    provincia = this.cmbProvincia.Text;
                }
            }
            else
            {
                provincia = this.cmbProvincia.SelectedItem.ToString();
            }

            //Texto, Nombre, Apellido y DNI
            this.usuario = new Usuario(this.txtName.Text, this.txtLastName.Text, (long)this.numDni.Value, formasDePAgo, medioDePago, provincia);
            this.DialogResult = DialogResult.OK;


        }

        private void chkEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                this.groupBoxMedioDePAgo.Visible = true;
            }
            else
            {
                this.groupBoxMedioDePAgo.Visible = false;
            }
        }

        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnOk.Enabled = true;
        }
        public Usuario GetUsuario()
        {
            return this.usuario;
        }

    }
}
