using MySql.Data.MySqlClient;
namespace soru1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Ar�za");
            comboBox1.Items.Add("Talep");
            comboBox1.Items.Add("Yard�m");
        }

        private void ara_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=db;Uid=root;Pwd=; Charset=utf-8");
            baglanti.Open();
            MySqlCommand sql = new MySqlCommand("SELECT * FROM musteriler where ID=@id", baglanti);
            sql.Parameters.AddWithValue("@id", id.Text);
            var sonuc = sql.ExecuteReader();
            if (sonuc.Read())
            {
                id.Text = sonuc["ID"].ToString();
                isim.Text = sonuc["�sim"].ToString();
                mesaj.Text = sonuc["Mesaj"].ToString();
            }
            else
            {
                MessageBox.Show("Ki�i bulunamad�.");
            }
            baglanti.Close();
        }

            private void kaydet_Click(object sender, EventArgs e)
            {
            MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=db;Uid=root;Pwd=;Charset=utf8");
            baglanti.Open();
            MySqlCommand sql = new MySqlCommand("INSERT INTO musteriler(isim,konu,mesaj) VALUES(@isim,@konu,@mesaj) ", baglanti);
            sql.Parameters.AddWithValue("ID", id.Text);
            sql.Parameters.AddWithValue("�sim", isim.Text);
            sql.Parameters.AddWithValue("Konu", comboBox1.SelectedIndex);
            sql.Parameters.AddWithValue("Mesaj", mesaj.Text);
            baglanti.Close();
            MessageBox.Show("Kay�t Eklendi.");
            id.Text = "";
            isim.Text = "";
            mesaj.Text = "";
            }
        private void sil_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=db;Uid=root;Pwd=;Charset=utf8");
            baglanti.Open();
            MySqlCommand sql = new MySqlCommand("DELETE FROM musteriler WHERE ID=@id", baglanti);
            sql.Parameters.AddWithValue("@id", id.Text);
            sql.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kay�t Silindi.");
            id.Text = "";
            isim.Text = "";
            mesaj.Text = "";
        }
        private void guncelle_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=localhost, Database=db, Uid=root,Pwd=;Charset=utf8");
            baglanti.Open();
            MySqlCommand sql = new MySqlCommand("UPDATE musteriler SET �sim=@isim, Konu=@konu, Mesaj=@mesaj WHERE ID=@id", baglanti);
            sql.Parameters.AddWithValue("@isim", isim.Text);
            sql.Parameters.AddWithValue("@konu", comboBox1.SelectedIndex);
            sql.Parameters.AddWithValue("@mesaj", mesaj.Text);
            baglanti.Close();
            MessageBox.Show("Kay�t G�ncellendi.");
            id.Text = "";
            isim.Text = "";
            mesaj.Text = "";
        }

    }
}

