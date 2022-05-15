using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Proyecto_final.Clases;

namespace Proyecto_final
{
    public partial class Vehiculo : Form
    {

        cConexion cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public Vehiculo()
        {
            InitializeComponent();
            cn = new cConexion();
            cmd = new SqlCommand("select * from Vehiculo",cn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
        }

       


        private void txtCedula_Click(object sender, EventArgs e)
        {
            txtMatricula.BackColor = Color.Red;
            txtNumeroSerial.BackColor = Color.Red;
            cmbColor.BackColor = Color.Red;
            cmbTipo.BackColor = Color.Red;
            txtcedulaCliente.BackColor = Color.Red;
        }

        private void txtMatricula_Click(object sender, EventArgs e)
        {
            
            txtMatricula.BackColor = Color.White;
            txtNumeroSerial.BackColor = Color.Red;
            txtcedulaCliente.BackColor= Color.Red;
            cmbColor.BackColor= Color.Red;
            cmbTipo.BackColor= Color.Red;
        }

        private void txtNumeroSerial_Click(object sender, EventArgs e)
        {
           
            txtMatricula.BackColor = Color.Red;
            txtNumeroSerial.BackColor= Color.White;
            txtcedulaCliente.BackColor = Color.Red;
            cmbTipo.BackColor = Color.Red;
            cmbColor.BackColor = Color.Red;
        }

        private void cmbTipo_Click(object sender, EventArgs e)
        {
            
            txtMatricula.BackColor = Color.Red;
            txtNumeroSerial.BackColor = Color.Red;
            txtcedulaCliente.BackColor = Color.Red;
            cmbTipo.BackColor = Color.White;
            cmbColor.BackColor = Color.Red;
        }

        private void cmbColor_Click(object sender, EventArgs e)
        {
            
            txtMatricula.BackColor = Color.Red;
            txtNumeroSerial.BackColor = Color.Red;
            txtcedulaCliente.BackColor= Color.Red;
            cmbTipo.BackColor= Color.Red;
            cmbColor.BackColor= Color.White;
        }

        private void txtKilometraje_Click(object sender, EventArgs e)
        {
            
            txtMatricula.BackColor= Color.Red;
            txtNumeroSerial.BackColor= Color.Red;
            txtcedulaCliente.BackColor = Color.White;
            cmbColor.BackColor = Color.Red;
            cmbTipo.BackColor = Color.Red;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
             cmd =new SqlCommand("insert into Vehiculo('" + txtMatricula + " ',' " + cmbTipo.Text + " ' , '" + txtNumeroSerial + " ','" + cmbColor.Text + "','" + txtcedulaCliente + "'",cn.AbrirConexion());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Vehiculo Inglesado Correctamente");

            
        }
    }
}
