namespace Semana_2
{
    public partial class INGRESO : Form
    {
        public INGRESO()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Progra")
            {
                if (textBox2.Text == "Cuatro")
                {
                    Menu m = new Menu();
                    m.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Contraseña incorrecta");
            }
            else
                MessageBox.Show("Codigo incorrecto");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }


    }
}