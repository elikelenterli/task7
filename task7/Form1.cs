namespace task7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            double ceki, boy;

            if (!double.TryParse(textBox1.Text, out ceki) ||
                !double.TryParse(textBox2.Text, out boy) ||
                ceki <= 0 || boy <= 0)
            {
                MessageBox.Show("Çəki və boyu düzgün daxil edin!");
                return;
            }

            double boyM = boy / 100.0;
            double bki = ceki / (boyM * boyM);

            label4.Text = Math.Round(bki, 1).ToString();

            string yol = @"C:\Users\Asus\Desktop\sekiller\";

            try
            {
                if (bki < 18.5)
                {
                    label3.Text = "Çəki azlığı (Arıq)";
                    pictureBox1.Image = Image.FromFile(yol + "arig.jpeg");
                }
                else if (bki < 25)
                {
                    label3.Text = "Normal çəki";
                    pictureBox1.Image = Image.FromFile(yol + "normal.jpeg");
                }
                else if (bki < 33)
                {
                    label3.Text = "Artıq çəki";
                    pictureBox1.Image = Image.FromFile(yol + "artiq.jpeg");
                }
                else if (bki < 40)
                {
                    label3.Text = "I dərəcəli piylənmə";
                    pictureBox1.Image = Image.FromFile(yol + "piylenme.jpeg");
                }
                else
                {
                    label3.Text = "III dərəcəli (Morbid) piylənmə";
                    pictureBox1.Image = Image.FromFile(yol + "morbid.jpeg");
                }
            }
            catch
            {
                MessageBox.Show("Şəkil tapılmadı: " + yol);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
