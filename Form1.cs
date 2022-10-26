namespace Jornada_ao_Desconhecido
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // teste
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2FLORESTA f2floresta = new Form2FLORESTA();
            f2floresta.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}