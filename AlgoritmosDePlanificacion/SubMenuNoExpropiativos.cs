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
    public partial class SubMenuNoExpropiativos : Form
    {
        public SubMenuNoExpropiativos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresarMenu_Click(object sender, EventArgs e)
        {
            //Redirigir al SubMenú No Expropiativosnece
            Form1 nuevoForm = new Form1();
            this.Hide();
            nuevoForm.Show();
        }

        private void btnFIFO_Click(object sender, EventArgs e)
        {
            //Redirigir al FORM FIFO
            FIFO nuevoForm = new FIFO();
            this.Hide();
            nuevoForm.Show();
        }

        private void btnPrioridad_Click(object sender, EventArgs e)
        {

            PRIORIDAD formPrioridad = new PRIORIDAD();

            formPrioridad.Show();

        }
    }
}
