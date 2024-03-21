using ADODB;

namespace Semana_2
{
    public partial class FFuente : Form
    {
        Connection conexion = new Connection();
        Recordset rs = new Recordset();
        public FFuente()
        {
            InitializeComponent();
            conexion.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\BDVitamias.accdb;Persist Security Info=False";
            conexion.Open();
        }
        private void FFuente_Load(object sender, EventArgs e)
        {
            object SQL;
            int k = 0;
            SQL = "select * from ALIMENTO";
            rs = new ADODB.Recordset();
            rs.CursorType = ADODB.CursorTypeEnum.adOpenKeyset;
            rs.LockType = ADODB.LockTypeEnum.adLockOptimistic;
            rs.Open(SQL, conexion);
            listView2.GridLines = true;
            listView2.FullRowSelect = true;
            listView2.View = View.Details;
            listView2.Width = 600;
            listView2.Font = new Font(new FontFamily("Arial"), 8, FontStyle.Bold);
            listView2.Columns.Add("Cod", 40, HorizontalAlignment.Center);
            listView2.Columns.Add("Nombre", 120, HorizontalAlignment.Center);
            if (!(rs.EOF))
            {
                while (!(rs.EOF))
                {
                    listView2.Items.Add(rs.Fields[0].Value.ToString());
                    listView2.Items[k].SubItems.Add(rs.Fields["nombreA"].Value.ToString());
                    listView2.ForeColor = Color.Beige;
                    listView2.Items[k].BackColor = Color.Gray;
                    rs.MoveNext();
                    k = k + 1;
                }
            }
            listView2.Scrollable = true;
            listView2.Items[0].Selected = true;

            int M = 0;
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
            listView1.Columns.Add("Descripcion", 120, HorizontalAlignment.Center);
            listView1.Columns.Add("Id", 40, HorizontalAlignment.Center);

            if (!(rs.EOF))
            {
                while (!(rs.EOF))
                {
                    listView1.Items.Add(rs.Fields[0].Value.ToString());
                    listView1.Items[M].SubItems.Add(rs.Fields["nombreV"].Value.ToString());
                    listView1.ForeColor = Color.Beige;
                    listView1.Items[M].BackColor = Color.Gray;
                    rs.MoveNext();
                    M = M + 1;
                }
            }
            listView1.Scrollable = true;
            listView1.Items[0].Selected = true;

            int A = 0;
            SQL = "select * from FUENTE";
            rs = new ADODB.Recordset();
            rs.CursorType = ADODB.CursorTypeEnum.adOpenKeyset;
            rs.LockType = ADODB.LockTypeEnum.adLockOptimistic;
            rs.Open(SQL, conexion);

            if (!(rs.EOF))
            {
                while (!(rs.EOF))
                {
                    comboBox1.Items.Add(rs.Fields[0].Value.ToString());
                    rs.MoveNext();
                    A = A + 1;
                }
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            int Indice;
            Indice = listView1.SelectedIndices[0];
            textBox1.Text = listView1.Items[Indice].Text;
        }

        private void listView2_Click(object sender, EventArgs e)
        {
            int Indice;
            Indice = listView2.SelectedIndices[0];
            textBox2.Text = listView2.Items[Indice].Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            object SQL;
            int k = 0;
            SQL = "insert into FUENTE (necesidadN, codigo, idA) values ('" + comboBox1.Text + "', '" + textBox1.Text + "', '" + textBox2.Text + "')";
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
            SQL = "delete FROM Fuente where necesidadN = " + comboBox1.Text;
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
            SQL = "update FUENTE set necesidadN = " + comboBox1.Text + ", codigo = '" + textBox1.Text + ", idA = '" + textBox2.Text + "' where idA = " + comboBox1.Text;
            rs = new ADODB.Recordset();
            rs.CursorType = ADODB.CursorTypeEnum.adOpenKeyset;
            rs.LockType = ADODB.LockTypeEnum.adLockOptimistic;
            rs.Open(SQL, conexion);
            MessageBox.Show("Registro modificado Correctamente");
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
    }
}
