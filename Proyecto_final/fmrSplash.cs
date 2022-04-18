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
            timer1.Interval = 3000;
            progressBar1.Increment(1);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hide();
           
            Login login = new Login();
            login.Show();
            timer1.Stop();
        }

        
    }
}
