using System;
using System.Windows.Forms;


namespace Proyecto_final
{
    public partial class Login : Form
    {
        public Login()
        { 
            //creamos un hilo
            // Thread t = new Thread(new ThreadStart(SplashStart));

            // arrancamos el hilo 
            // t.Start();

            //ponemos a dormir la formar  principal
           // Thread.Sleep(5000);

            InitializeComponent();

            //finalizamos el hilo
           // t.Abort();
        }

       // public void SplashStart()
       // {
          //  Application.Run(new fmrSplash());
       // }

      
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
            panel5.BackColor = Color.Red;
            txtPassword.BackColor = Color.Red;
        }

        // habilita blanco en txtPassword y panel 5 y habilita el rojo en txtUsuario y panel3
        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.White;
            panel5.BackColor= Color.White;
            panel3.BackColor = Color.Red;
            txtUsuario.BackColor= Color.Red;
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
    }
}