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
        public fmrSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Incrementamos la barra
            progressBar1.Increment(1);

            //Si llega al maximo paramos el timer
            if(progressBar1.Value == 100)
                timer1.Stop();
        }
    }
}
