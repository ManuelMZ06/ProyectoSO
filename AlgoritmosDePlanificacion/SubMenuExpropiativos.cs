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
            ROUNDROBIN newFORM = new ROUNDROBIN();
            this.Hide();
            newFORM.Show();
        }

        private void btnRegresarMenu1_Click(object sender, EventArgs e)
        {
            //Redirigir al Menú
            Form1 nuevoForm = new Form1();
            this.Hide();
            nuevoForm.Show();
        }

        private void btnSRTJ_Click(object sender, EventArgs e)
        {
            //Redirigir al SRTF
            SRTF nuevoForm = new SRTF();
            this.Hide();
            nuevoForm.Show();
        }

        private void SubMenuExpropiativos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Environment.Exit(0);
            }
        }
    }
}
