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
    public partial class FVitamina : Form
    {
        Connection conexion = new Connection();
        Recordset rs = new Recordset();
        public FVitamina()
        {
            InitializeComponent();
            conexion.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\BDVitamias.accdb;Persist Security Info=False";
            conexion.Open();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FVitamina_Load(object sender, EventArgs e)
        {
            object SQL;
            int k = 0;
            SQL = "select * from VITAMINA";
            rs = new ADODB.Recordset();
            rs.CursorType = ADODB.CursorTypeEnum.adOpenKeyset;
            rs.LockType = ADODB.LockTypeEnum.adLockOptimistic;
            rs.Open(SQL, conexion);
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.View = View.Details;
            listView1.Width = 600;
            listView1.Font = new Font(new FontFamily("Arial"), 8, FontStyle.Bold);
            listView1.Columns.Add("Cod", 40, HorizontalAlignment.Center);
            listView1.Columns.Add("Nombre", 120, HorizontalAlignment.Center);
            listView1.Columns.Add("Descripcion", 250, HorizontalAlignment.Center);
            if (!(rs.EOF))
            {
                while (!(rs.EOF))
                {
                    listView1.Items.Add(rs.Fields[0].Value.ToString());
                    listView1.Items[k].SubItems.Add(rs.Fields["nombreV"].Value.ToString());
                    listView1.Items[k].SubItems.Add(rs.Fields["descripcionV"].Value.ToString());
                    listView1.Items[k].SubItems.Add(rs.Fields["idCat"].Value.ToString());
                    listView1.ForeColor = Color.Beige;
                    listView1.Items[k].BackColor = Color.Gray;
                    rs.MoveNext();
                    k = k + 1;
                }
            }
            listView1.Scrollable = true;
            listView1.Items[0].Selected = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu f = new Menu();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            object SQL;
            int k = 0;
            SQL = "insert into VITAMINA (codigo, nombreV, descripcionV, idCat) values (" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "'," + (listBox1.SelectedIndex + 1) + ")";
            rs = new ADODB.Recordset();
            rs.CursorType = ADODB.CursorTypeEnum.adOpenKeyset;
            rs.LockType = ADODB.LockTypeEnum.adLockOptimistic;
            rs.Open(SQL, conexion);
            MessageBox.Show("Registro agreado Correctamente");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            object SQL;
            int k = 0;
            SQL = "delete FROM VITAMINA  where codigo = " + textBox1.Text;
            rs = new ADODB.Recordset();
            rs.CursorType = ADODB.CursorTypeEnum.adOpenKeyset;
            rs.LockType = ADODB.LockTypeEnum.adLockOptimistic;
            rs.Open(SQL, conexion);
            MessageBox.Show("Registro eliminado Correctamente");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            object SQL;
            int k = 0;
            SQL = "update VITAMINA set nombreV='" + textBox2.Text + "', descripcionV = '" + textBox3.Text + "', idCat = " + (listBox1.SelectedIndex + 1).ToString() + " where codigo = " + textBox1.Text;
            rs = new ADODB.Recordset();
            rs.CursorType = ADODB.CursorTypeEnum.adOpenKeyset;
            rs.LockType = ADODB.LockTypeEnum.adLockOptimistic;
            rs.Open(SQL, conexion);
            MessageBox.Show("Registro modificado Correctamente");
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            int Indice;
            Indice = listView1.SelectedIndices[0];
            textBox1.Text = listView1.Items[Indice].Text;
            textBox2.Text = listView1.Items[Indice].SubItems[1].Text;
            textBox3.Text = listView1.Items[Indice].SubItems[2].Text;
            listBox1.SelectedIndex = Convert.ToInt32(listView1.Items[Indice].SubItems[3].Text) - 1;
        }
    }
}
