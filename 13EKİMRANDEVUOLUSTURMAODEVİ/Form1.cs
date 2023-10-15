namespace _13EKİMRANDEVUOLUSTURMAODEVİ
{
    public partial class tabControl1 : Form
    {
        List<Kisi> kisiler = new List<Kisi>();
        public tabControl1()
        {
            InitializeComponent();
        }

       

        private void btnRandevuOlustur_Click(object sender, EventArgs e)
        {


            Kisi kisi = new Kisi();

            try
            {
                kisi.AdSoyad = txtAdSoyad.Text;
                kisi.Polikinlik = cbBölümler.SelectedText;
                kisi.Tc = txtTc.Text;
                kisi.Tarih = dateTimetTarih.Value;
                kisi.Cinsiyet = rbdErkek.Checked ? "Erkek" : "Kadın";
                if (rb12.Checked) { kisi.Saat = "12.00"; } else if (rb13.Checked) { kisi.Saat = "13.00"; } else if (rb14.Checked) { kisi.Saat = "14.00"; } else { kisi.Saat = "15.00"; }
                DialogResult dialogResult = MessageBox.Show("Gerçekten kaydetmek istiyor musunuz?", "Mesaj", MessageBoxButtons.OKCancel);

                if(dialogResult == DialogResult.OK)
                {
                    lstrandevubilgeri.Items.Add($"{kisi.AdSoyad}-{kisi.Polikinlik}-{kisi.Tarih}-{kisi.Saat}");
                    MessageBox.Show("Kaydedildi", "", MessageBoxButtons.OK);
                }
           
                kisiler.Add(kisi);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Temizle();
        }
        private void Temizle()
        {
            txtAdSoyad.Clear();
            txtTc.Clear();
            masTelefon.Clear();
            cbBölümler.Text = "";
            rbdErkek.Checked = false;
            rb12.Checked = false;   
            rb13.Checked = false;    
            rb14.Checked = false;
            rb15.Checked = false;
            rbdKadın.Checked = false;

        }
       
       

        private void lstrandevubilgeri_DoubleClick(object sender, EventArgs e)
        {

            if (lstrandevubilgeri.SelectedIndex != -1)

            {
                int index = lstrandevubilgeri.SelectedIndex;
                Kisi kisi = kisiler[index];
                MessageBox.Show($"Ad Soyad:{kisi.AdSoyad}\n Tc :{kisi.Tc}\n Cinsiyet:{kisi.Cinsiyet}", "Hasta Bilgileri", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lstrandevubilgeri.SelectedIndex = -1;

            }

        }
        private void lstrandevubilgeri_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }


    }
}