using System.Text.Json;
using JSON_odev.urunler.json;

namespace JSON_odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnurungoster_Click(object sender, EventArgs e)
        {
            try
            {
                string jsonPath = "urunler.json";
                string jsonString = File.ReadAllText(jsonPath);

                List<Urun> urunler = JsonSerializer.Deserialize<List<Urun>>(jsonString);

                listBox1.Items.Clear();

                foreach (var urun in urunler)
                {
                    listBox1.Items.Add($"{urun.UrunAdi} - {urun.Fiyat} TL");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}

