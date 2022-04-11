namespace Proyecto_final
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
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
    }
}