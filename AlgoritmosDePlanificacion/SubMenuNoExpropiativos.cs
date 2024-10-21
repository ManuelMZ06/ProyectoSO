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
            //Redirigir al FORM PRIORIDAD
            PRIORIDAD formPrioridad = new PRIORIDAD();
            this.Hide();
            formPrioridad.Show();

        }

        private void brnHRRN_Click(object sender, EventArgs e)
        {
            //Redirigir al FORM PRIORIDAD
            HRRN formPrioridad = new HRRN();
            this.Hide();
            formPrioridad.Show();
        }

        private void btnSPN_Click(object sender, EventArgs e)
        {
            //Redirigir al FORM SPN
            Form3 nuevoForm = new Form3();
            this.Hide();
            nuevoForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Redirigir al form SJF
            SJF sjf = new SJF();
            this.Hide();
            sjf.Show();
        }

        private void SubMenuNoExpropiativos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Environment.Exit(0);
            }
        }
    }
}
