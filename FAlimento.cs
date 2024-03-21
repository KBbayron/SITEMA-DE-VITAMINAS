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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Semana_2
{
    public partial class Falimento : Form

    {
        Connection conexion = new Connection();
        Recordset rs = new Recordset();

        public Falimento()
        {
            InitializeComponent();
            conexion.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\BDVitamias.accdb;Persist Security Info=False";
            conexion.Open();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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

        private void Falimento_Load(object sender, EventArgs e)
        {
            object SQL;
            int k = 0;
            SQL = "select * from ALIMENTO";
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
            if (!(rs.EOF))
            {
                while (!(rs.EOF))
                {
                    listView1.Items.Add(rs.Fields[0].Value.ToString());
                    listView1.Items[k].SubItems.Add(rs.Fields["nombreA"].Value.ToString());
                    listView1.ForeColor = Color.Beige;
                    listView1.Items[k].BackColor = Color.Gray;
                    rs.MoveNext();
                    k = k + 1;
                }
            }
            listView1.Scrollable = true;
            listView1.Items[0].Selected = true;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            object SQL;
            int k = 0;
            SQL = "insert into ALIMENTO (idA, nombreA) values ('" + textBox1.Text + "','" + textBox2.Text + "')";
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
            SQL = "delete FROM ALIMENTO where idA =  " + textBox1.Text ;
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
            SQL = "update ALIMENTO set idA=" + textBox1.Text + ", nombreA = '" + textBox2.Text + "' where idA = " + textBox1.Text;
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
            textBox1.Text = listView1.Items[Indice].SubItems[0].Text;
            textBox2.Text = listView1.Items[Indice].SubItems[1].Text;
        }
    }
}
