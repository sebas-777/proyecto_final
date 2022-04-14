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
    public partial class fmrSplash : Form
    {
       // Timer timer = new Timer();
        public fmrSplash()
        {
            InitializeComponent();
            timer1.Interval = 3000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Incrementamos la barra
            progressBar1.Increment(1);

            //Si llega al maximo paramos el timer
            if(progressBar1.Value == 100)
               timer1.Stop();
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
