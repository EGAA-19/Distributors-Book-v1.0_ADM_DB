using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Layout
{
    public partial class frmLoad : Form
    {
        //Initialize Form
        public frmLoad()
        {
            InitializeComponent();
        }
        private void frmLoad_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
            timer1.Start();
        }

        //==>Timers
        //Start Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.1;
            circularProgressBar1.Value += 1;
            circularProgressBar1.Text = circularProgressBar1.Value.ToString();
            if (circularProgressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }
        //Timer Finish
        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if ((circularProgressBar1.Value >= circularProgressBar1.Maximum) && (this.Opacity <= 0))
            {
                timer2.Stop();
                this.Hide();

                frmHome formMain = new frmHome();
                formMain.Closed += (s, args) => this.Close(); //Close the current form when the second form has been closed
                formMain.ShowDialog(this);
            }
        }
        //==>Timers
    }
}
