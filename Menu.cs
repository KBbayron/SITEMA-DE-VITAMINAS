using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana_2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            INGRESO a = new INGRESO();
            a.Show();
            this.Hide();
        }

        private void gestionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FVitamina a = new FVitamina();
            a.Show();
            this.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            FVitamina a = new FVitamina();
            a.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Falimento v = new Falimento();
            v.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FFuente f = new FFuente();
            f.Show();
            this.Hide();
        }

        private void terminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gestionarAlimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Falimento v = new Falimento();
            v.Show();
            this.Hide();
        }

        private void gestionarFuentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FFuente f = new FFuente();
            f.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Reporte f = new Reporte();
            f.Show();
            this.Hide();
        }
    }
}
