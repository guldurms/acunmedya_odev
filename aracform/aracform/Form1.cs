namespace aracform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string marka = textBox1.Text;
            string model = textBox2.Text;
            string renk = textBox3.Text;
            string kap�= textBox4.Text;
            string pencere= textBox5.Text;
            string yak�t=textBox6.Text;

            MessageBox.Show("Marka : " + marka + "\n" + "Model : " + model + "\n" + "Renk : " + renk + "\n" + "Kap� Say�s� : " + kap� + "\n" + "Pencere Say�s� : " + pencere + "\n" + "100 Km'de yakt��� yak�t : " + yak�t );
        }
    }
}
