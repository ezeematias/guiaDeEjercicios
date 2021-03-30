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
    public partial class MiniSupermercado : Form
    {
        public MiniSupermercado()
        {
            InitializeComponent();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmAltaUsuario frmAltaUsuario = new FrmAltaUsuario();
            frmAltaUsuario.Location = this.Location;
            if(frmAltaUsuario.ShowDialog() == DialogResult.OK)
            {
                MiniSuper.AgregarUsuarios(frmAltaUsuario.GetUsuario());

            }

            cmbUsuarios.DataSource = null;
            cmbUsuarios.DataSource = MiniSuper.GetUsuarios();

        }

        private void MiniSupermercado_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea Cerrar?", "Cerrando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
