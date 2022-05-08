using System;
using System.Windows.Forms;
using Proyecto_final.Clases;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace Proyecto_final
{
    public partial class Login : Form 

    {
        //declaramos las variables

        cConexion cn;
        int contador, boton;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public Login()
        { 
           
        // inicializamos variables
            InitializeComponent();
            cn = new cConexion();
            contador = 0; boton = 0;     
            cmd = new SqlCommand("select * from tbl_usuario",cn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
        }
        
        //funcion loguer

        void logear()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from tbl_usuario where  usuario = '" + txtUsuario.Text + " ' and password = '" + txtPassword.Text + "'", cn.AbrirConexion());

                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);

                if(dt.Rows.Count == 1)
                {
                    Cliente cliente = new Cliente();
                    cliente.Show();
                }
                else 
                {
                    contador++;
                    MessageBox.Show("Usuario o contraseña erradas, llevas " + contador + "equivocaciones");
                }

                if (contador == 3)
                    MessageBox.Show("Superastes los Intentos Permitidos");
                    this.Close();
            } 
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            } 

            finally
            {
                cn.CerrarConexion();
            }


        }


        //Evento click del boton cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Evento click del boton maximizar
        private void btnMax_Click(object sender, EventArgs e)
        {
            //si esta normal lo maximiza, si esta maximizado vuelve normal.
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;

        }
        //Evento click boton minimizar
        private void btnMin_Click(object sender, EventArgs e)
        {
            // Si esta normal minimiza,si esta maximizado minimiza.
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Minimized;
        }
         // habilta blanco en txtUsuario y panel 3, habilta el rojo en txtPassword y panel 5 
        private void txtUsuario_Click(object sender, EventArgs e)
        {
           txtUsuario.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel5.BackColor = Color.Aquamarine;
            txtPassword.BackColor = Color.Aquamarine;
        }

        // habilita blanco en txtPassword y panel 5 y habilita el rojo en txtUsuario y panel3
        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.White;
            panel5.BackColor= Color.White;
            panel3.BackColor = Color.Aquamarine;
            txtUsuario.BackColor= Color.Aquamarine;
        }

        // boton de logueo 
        private void btnLogin_Click(object sender, EventArgs e)
        {
            logear();
        }

        // deshabilita el cifrado el txtPassword
        private void iconPictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;   
        }

        private void iconPictureBox5_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar=true;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}