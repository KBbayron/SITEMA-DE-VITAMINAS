using ADODB;
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
    public partial class Reporte : Form
    {
        Connection conexion = new Connection();
        Recordset rs = new Recordset();

        public Reporte()
        {
            InitializeComponent();
            conexion.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\BDVitamias.accdb;Persist Security Info=False";
            conexion.Open();
        }

        private void Reporte1()
        {

            listView1.Clear();
            int k = 0;
            string SQL = "select * from VITAMINA";
            rs = new ADODB.Recordset();
            rs.CursorType = ADODB.CursorTypeEnum.adOpenKeyset;
            rs.LockType = ADODB.LockTypeEnum.adLockOptimistic;
            rs.Open(SQL, conexion);
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.View = View.Details;
            listView1.Width = 500;
            listView1.Font = new Font(new FontFamily("Arial"), 8, FontStyle.Bold);
            listView1.Columns.Add("Cod", 80, HorizontalAlignment.Center);
            listView1.Columns.Add("Nombre", 180, HorizontalAlignment.Center);
            listView1.Columns.Add("Descripcion", 180, HorizontalAlignment.Center);
            listView1.Columns.Add("Cat", 30, HorizontalAlignment.Center);
            progressBar1.Minimum = 0;
            progressBar1.Maximum = Convert.ToInt32(rs.RecordCount);
            progressBar1.Value = 0;
            while (!rs.EOF)
            {
                listView1.Items.Add(rs.Fields["codigo"].Value.ToString());
                listView1.Items[k].SubItems.Add(rs.Fields["nombreV"].Value.ToString());
                listView1.Items[k].SubItems.Add(rs.Fields["descripcionV"].Value.ToString());
                listView1.Items[k].SubItems.Add(rs.Fields["idCat"].Value.ToString());
                listView1.ForeColor = Color.Beige;
                listView1.Items[k].BackColor = Color.Gray;
                progressBar1.Value = progressBar1.Value + 1;
                rs.MoveNext();
                k = k + 1;
            }
            listView1.Items[0].Selected = true;
        }

        private void Reporte2()
        {
            listView1.Clear();
            int k = 0;
            string SQL = "select * from ALIMENTO";
            rs = new ADODB.Recordset();
            rs.CursorType = ADODB.CursorTypeEnum.adOpenKeyset;
            rs.LockType = ADODB.LockTypeEnum.adLockOptimistic;
            rs.Open(SQL, conexion);

            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.View = View.Details;
            listView1.Width = 500;
            listView1.Font = new Font(new FontFamily("Arial"), 8, FontStyle.Bold);
            listView1.Columns.Add("Identificador", 80, HorizontalAlignment.Center);
            listView1.Columns.Add("Nombre", 360, HorizontalAlignment.Center);

            progressBar1.Minimum = 0;
            progressBar1.Maximum = Convert.ToInt32(rs.RecordCount);
            progressBar1.Value = 0;

            while (!rs.EOF)
            {
                listView1.Items.Add(rs.Fields["idA"].Value.ToString());
                listView1.Items[k].SubItems.Add(rs.Fields["nombreA"].Value.ToString());
                listView1.ForeColor = Color.Beige;
                listView1.Items[k].BackColor = Color.Gray;
                progressBar1.Value = progressBar1.Value + 1;
                rs.MoveNext();
                k = k + 1;
            }
            listView1.Items[0].Selected = true;
        }

        private void Reporte3()
        {
            listView1.Clear();
            int k = 0;
            string SQL = "select  nombreV, NecesidadN, NombreA from VITAMINA V, FUENTE F, ALIMENTO A WHERE V.codigo=F.codigo and A.idA = F.idA";
            rs = new ADODB.Recordset();
            rs.CursorType = ADODB.CursorTypeEnum.adOpenKeyset;
            rs.LockType = ADODB.LockTypeEnum.adLockOptimistic;
            rs.Open(SQL, conexion);

            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.View = View.Details;
            listView1.Width = 500;
            listView1.Font = new Font(new FontFamily("Arial"), 12, FontStyle.Bold);
            listView1.Columns.Add("Vitamina", 180, HorizontalAlignment.Center);
            listView1.Columns.Add("Nec. Nutr.", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Alimento", 180, HorizontalAlignment.Center);
            progressBar1.Minimum = 0;
            progressBar1.Maximum = Convert.ToInt32(rs.RecordCount);
            progressBar1.Value = 0;
            while (!rs.EOF)
            {
                listView1.ForeColor = Color.Brown;
                listView1.Items.Add(rs.Fields["nombreV"].Value.ToString());
                listView1.Items[k].SubItems.Add(rs.Fields["NecesidadN"].Value.ToString());
                listView1.Items[k].SubItems.Add(rs.Fields["NombreA"].Value.ToString());
                listView1.Items[k].BackColor = Color.Aquamarine;
                progressBar1.Value = progressBar1.Value + 1;
                rs.MoveNext();
                k = k + 1;
            }
            listView1.Items[0].Selected = true;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int opcion;
            opcion = comboBox1.SelectedIndex + 1;
            switch (opcion)
            {
                case 1:
                    Reporte1();
                    break;
                case 2:
                    Reporte2();
                    break;
                case 3:
                    Reporte3();
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu f = new Menu();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
