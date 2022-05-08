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
    public partial class Cliente : Form
    {
        //declaramos las variables
        int i, boton, contador;
        cConexion cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        
        public Cliente()
        {
         
         //inicializamos las variables
         boton = 0;
         i = 0;
         cn = new cConexion();
         cmd = new SqlCommand("select * from tbl_cliente",cn.AbrirConexion());
         da = new SqlDataAdapter(cmd);
         dt = new DataTable();
         da.Fill(dt);
         InitializeComponent();
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            txtNombre.BackColor = Color.White;
            txtApellidos.BackColor = Color.CadetBlue;
            txtCedula.BackColor = Color.CadetBlue;
            txtDireccion.BackColor = Color.CadetBlue;
            txtEmail.BackColor = Color.CadetBlue;
            txtTelefono.BackColor= Color.CadetBlue;
        }

        private void txtApellidos_Click(object sender, EventArgs e)
        {
            txtNombre.BackColor= Color.CadetBlue;
            txtApellidos.BackColor= Color.White;
            txtCedula.BackColor= Color.CadetBlue;
            txtDireccion.BackColor =Color.CadetBlue;
            txtEmail.BackColor = Color.CadetBlue;
            txtTelefono.BackColor = Color.CadetBlue;
        }

        private void txtCedula_Click(object sender, EventArgs e)
        {
            txtNombre.BackColor= Color.CadetBlue;
            txtApellidos.BackColor = Color.CadetBlue;
            txtCedula.BackColor = Color.White;
            txtDireccion.BackColor= Color.CadetBlue;
            txtEmail.BackColor= Color.CadetBlue;
            txtTelefono.BackColor = Color.CadetBlue;
        }

        private void txtDireccion_Click(object sender, EventArgs e)
        {
            txtNombre.BackColor = Color.CadetBlue;
            txtApellidos.BackColor = Color.CadetBlue;
            txtCedula.BackColor = Color.CadetBlue;
            txtDireccion.BackColor = Color.White;
            txtEmail.BackColor = Color.CadetBlue;
            txtTelefono.BackColor = Color.CadetBlue;
        }

        private void txtTelefono_Click(object sender, EventArgs e)
        {
            txtNombre.BackColor = Color.CadetBlue;
            txtApellidos.BackColor = Color.CadetBlue;
            txtCedula.BackColor = Color.CadetBlue;
            txtDireccion.BackColor = Color.CadetBlue;
            txtEmail.BackColor = Color.CadetBlue;
            txtTelefono.BackColor = Color.White;
        }

     

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtNombre.BackColor = Color.CadetBlue;
            txtApellidos.BackColor = Color.CadetBlue;
            txtCedula.BackColor = Color.CadetBlue;
            txtDireccion.BackColor = Color.CadetBlue;
            txtTelefono.BackColor = Color.CadetBlue;
            txtEmail.BackColor = Color.White;
        }

       

        private void Cliente_Load(object sender, EventArgs e)
        {
            llenar(dt, i);
        }

        // metodo para limpiar los textBox
        void limpiar()
        {
            txtNombre.Clear();
            txtApellidos.Clear();
            txtCedula.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
        }

        // boton primero
        private void btnPrimero_Click(object sender, EventArgs e)
        {
            i = 0;
            llenar(dt, i);
        }

        // boton anterior
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            i = i - 1;
            if(i==-1)
            {
                MessageBox.Show("Es el primer cliente");
            }
            llenar(dt, i);
        }

        // boton siguiente
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            MessageBox.Show(i.ToString());
            i++;
            if (i == contador)
            {
                MessageBox.Show("Es el ultimo cliente");
                i = contador - 1;
            }
            llenar(dt, i);
        }

        // boton ultimo
        private void btnUltimo_Click(object sender, EventArgs e)
        {
            i = contador - 1;
            llenar(dt,i);

        }

        // boton nuevo
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            boton = 1;
            limpiar();
            habilita();
            txtCedula.Focus();
        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from tbl_cliente where cedula = '" + txtCedula.Text + "'",cn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            if(dt.Rows.Count > 0)
            {
                switch(boton)
                {

                    case 1:
                        MessageBox.Show("Ya existe");
                        llenar(dtb, 0);
                        break;
                    case 2:
                        llenar(dtb, 0);
                        deshabilita();
                        break;
                    case 3:
                        llenar(dtb, 0);
                        break ;
                    case 4:
                        llenar(dtb, 0);
                        if(MessageBox.Show("Desea borralo","peligro!!",MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            SqlCommand cmdb = new SqlCommand("delete from tbl_cliente where cedula = '" + txtCedula.Text + "'", cn.AbrirConexion());
                            cmdb.ExecuteNonQuery();
                            MessageBox.Show("Cliente Eliminado!!");
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("El cliente no existe");
                if (boton!= 1) txtCedula.Clear();
            }
        }



        // metodo para habilitar los textbox
        void habilita()
        {
            txtNombre.Enabled = true;
            txtApellidos.Enabled = true;
            txtCedula.Enabled = true;
            txtDireccion.Enabled = true;
            txtTelefono.Enabled = true;
            txtEmail.Enabled = true;
        }

        // boton consultar
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            boton = 2;
            limpiar();
            txtCedula.Enabled = true;
            txtCedula.Focus();
        }
        //boton modificar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            boton = 3;
            limpiar();
            habilita();
            txtCedula.Focus();
        }

        // boton retiro
        private void btnRetiro_Click(object sender, EventArgs e)
        {
            boton = 4;
            limpiar();
            txtCedula.Enabled =true;
            txtCedula.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(boton==1)
            {
                cmd = new SqlCommand("insert into tbl_cliente values('" + txtCedula.Text + "','" + txtNombre.Text + "','" + txtApellidos.Text + "','" + txtDireccion.Text + "','" + txtTelefono.Text + "','" + txtEmail.Text + "')", cn.AbrirConexion());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente Creado");
            }
            if(boton==3)
            {
                cmd = new SqlCommand("update tbl_cliente set nombre ='" + txtNombre.Text + "',apellido ='" + txtApellidos.Text + "',direccion='" + txtDireccion.Text + "',telefono='" + txtTelefono.Text + "',email='" + txtEmail.Text + "' where cedula ='" + "'", cn.AbrirConexion());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente Modificado");
            }
        }


        // metodo para deshabilitar los textbox



        void deshabilita()
        {
            txtNombre.Enabled = false;
            txtApellidos.Enabled = false;
            txtCedula.Enabled = false;
            txtDireccion.Enabled = false;
            txtTelefono.Enabled = false;
            txtEmail.Enabled = false;
        }

        // metodo llenar

        void llenar(DataTable dt , int i)
        {
            txtNombre.Text = dt.Rows[i][0].ToString();
            txtApellidos.Text = dt.Rows[i][1].ToString();
            txtCedula.Text = dt.Rows[i][2].ToString();
            txtDireccion.Text = dt.Rows[i][3].ToString();
            txtTelefono.Text = dt.Rows[i][4].ToString();
            txtEmail.Text = dt.Rows[i][5].ToString();
        }
    }

    


}
