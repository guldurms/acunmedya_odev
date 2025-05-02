using ogrencibilgiformu.classes;
using System.Reflection;
using System.Text;

namespace ogrencibilgiformu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Değiştirilmiş btnDogrula_Click metodu

        private void btnDogrula_Click(object sender, EventArgs e)
        {
            try
            {
                ResetTextBoxColors();
                var ogrenci = new Ogrenci { Ad = txtAd.Text, Soyad = txtSoyad.Text, Bolum = txtBolum.Text };

                bool isValid = true;
                StringBuilder errors = new StringBuilder();

                foreach (PropertyInfo property in typeof(Ogrenci).GetProperties())
                {
                    var attr = (RequiredAttribute)property.GetCustomAttribute(typeof(RequiredAttribute));
                    if (attr != null && !attr.IsValid(property.GetValue(ogrenci)))
                    {
                        isValid = false;
                        errors.AppendLine(attr.ErrorMessage);
                        MarkInvalidTextBox(property.Name);
                    }
                }

                if (!isValid)
                {
                    lblSonuc.Text = "";
                    lblSonuc.Visible = false;
                    MessageBox.Show(errors.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    lblSonuc.Text = $"Kayıt Başarılı!\n\nAd: {ogrenci.Ad}\nSoyad: {ogrenci.Soyad}\nBölüm: {ogrenci.Bolum}";
                    lblSonuc.Font = new Font(lblSonuc.Font.FontFamily, 10, FontStyle.Bold);
                    lblSonuc.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        
        

        private void MarkInvalidTextBox(string propertyName)
        {
            switch (propertyName)
            {
                case "Ad":
                    txtAd.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "Soyad":
                    txtSoyad.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "Bolum":
                    txtBolum.BackColor = System.Drawing.Color.LightPink;
                    break;
            }
        }

        private void ResetTextBoxColors()
        {
            txtAd.BackColor = System.Drawing.Color.White;
            txtSoyad.BackColor = System.Drawing.Color.White;
            txtBolum.BackColor = System.Drawing.Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSonuc.Text = "";
            lblSonuc.AutoSize = false;
            lblSonuc.Size = new System.Drawing.Size(300, 80);
            lblSonuc.BorderStyle = BorderStyle.FixedSingle;
        }
        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            txtAd.BackColor = System.Drawing.Color.White;
        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {
            txtSoyad.BackColor = System.Drawing.Color.White;
        }

        private void txtBolum_TextChanged(object sender, EventArgs e)
        {
            txtBolum.BackColor = System.Drawing.Color.White;
        }
    }
}


