using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            txtNombre.BackColor = Color.White;
            txtApellidos.BackColor = Color.Red;
            txtCedula.BackColor = Color.Red;
            txtDireccion.BackColor = Color.Red;
            txtEmail.BackColor = Color.Red;
            txtTelefono.BackColor= Color.Red;
        }

        private void txtApellidos_Click(object sender, EventArgs e)
        {
            txtNombre.BackColor= Color.Red;
            txtApellidos.BackColor= Color.White;
            txtCedula.BackColor= Color.Red;
            txtDireccion.BackColor =Color.Red;
            txtEmail.BackColor = Color.Red;
            txtTelefono.BackColor = Color.Red;
        }

        private void txtCedula_Click(object sender, EventArgs e)
        {
            txtNombre.BackColor= Color.Red;
            txtApellidos.BackColor = Color.Red;
            txtCedula.BackColor = Color.White;
            txtDireccion.BackColor= Color.Red;
            txtEmail.BackColor= Color.Red;
            txtTelefono.BackColor = Color.Red;
        }

        private void txtDireccion_Click(object sender, EventArgs e)
        {
            txtNombre.BackColor = Color.Red;
            txtApellidos.BackColor = Color.Red;
            txtCedula.BackColor = Color.Red;
            txtDireccion.BackColor = Color.White;
            txtEmail.BackColor = Color.Red;
            txtTelefono.BackColor = Color.Red;
        }

        private void txtTelefono_Click(object sender, EventArgs e)
        {
            txtNombre.BackColor = Color.Red;
            txtApellidos.BackColor = Color.Red;
            txtCedula.BackColor = Color.Red;
            txtDireccion.BackColor = Color.Red;
            txtEmail.BackColor = Color.Red;
            txtTelefono.BackColor = Color.White;
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtNombre.BackColor = Color.Red;
            txtApellidos.BackColor = Color.Red;
            txtCedula.BackColor = Color.Red;
            txtDireccion.BackColor = Color.Red;
            txtTelefono.BackColor = Color.Red;
            txtEmail.BackColor = Color.White;
        }

        
    }
}
