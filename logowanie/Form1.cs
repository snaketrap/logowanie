using System.DirectoryServices;
using System.Windows.Forms;

namespace logowanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" & textBox2.Text == "Qwerty1@34")
            {
                MessageBox.Show("zalogowano");
                Form2 f2 = new Form2();
                f2.Show();
            }
            else
            {
                MessageBox.Show("niepoprwny login");
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {
            string[] paths = Directory.GetFiles(@"C:\Users\student\Downloads", "*.png");
            List<string> images = paths.ToList();
            Random random = new Random();
            pictureBox1.ImageLocation = paths[random.Next(0, images.Count - 1)];
            
            
        }
    }
}