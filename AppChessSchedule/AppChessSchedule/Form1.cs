using AppChessSchedule.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppChessSchedule
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void paísToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaPais vp = new VentanaPais();
            vp.ShowDialog();
        }
    }
}
