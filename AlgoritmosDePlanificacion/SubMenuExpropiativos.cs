using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmosDePlanificacion
{
    public partial class SubMenuExpropiativos : Form
    {
        public SubMenuExpropiativos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresarMenu1_Click(object sender, EventArgs e)
        {
            //Redirigir al SubMenú No Expropiativosnece
            Form1 nuevoForm = new Form1();
            this.Hide();
            nuevoForm.Show();
        }

        private void btnSRTJ_Click(object sender, EventArgs e)
        {
            //Redirigir al SubMenú No Expropiativosnece
            SRTF nuevoForm = new SRTF();
            this.Hide();
            nuevoForm.Show();
        }
    }
}
