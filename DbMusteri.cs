MySQL’de “db” adında bir veritabanı ve bu veritabanında ise “musteriler” adında bir tablo bulunmaktadır. Tablonun yapısı aşağıda verilmiştir.
Adı 	Türü	Ekstra
id 	int(11)	 AUTO_INCREMENT
isim	varchar(255)	 
konu	int(1)	 
mesaj	text	

a)	id [TextBox], 
İsim [TextBox], 
Konu [SelectBox (Arıza, Talep, Yardım)]
Mesaj [RichTextBox]
Kaydet [Button]
Sil [Button]
Güncelle [Button]
Ara [Button] 
Yukardaki elementleri forma ekleyiniz.
 

private void Form1_Load(object sender, EventArgs e)
{
    comboBox1.Items.Add("Arıza");
    comboBox1.Items.Add("Talep");
    comboBox1.Items.Add("Yardım");
}



b)	Ara butonuna tıklandığında, formdaki "id" TextBox'ındaki değere karşılık gelen kayıt, "musteriler" tablosundan alınarak formdaki elementlerde görüntülensin.
Çözüm:
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
        isim.Text = sonuc["İsim"].ToString();
        mesaj.Text = sonuc["Mesaj"].ToString();
    }
    else
    {
        MessageBox.Show("Kişi bulunamadı.");
    }
c)	Kaydet butona tıklandığında formdaki verilere göre “musteriler” tablosuna yeni kayıt eklensin.
Çözüm:
private void kaydet_Click(object sender, EventArgs e)
{
    MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=db;Uid=root;Pwd=;Charset=utf8");
    baglanti.Open();
    MySqlCommand sql = new MySqlCommand("INSERT INTO musteriler(isim,konu,mesaj) VALUES(@isim,@konu,@mesaj) ");
    sql.Parameters.AddWithValue("ID", id.Text);
    sql.Parameters.AddWithValue("İsim", isim.Text);
    sql.Parameters.AddWithValue("Konu", comboBox1.SelectedIndex);
    sql.Parameters.AddWithValue("Mesaj", mesaj.Text);
    baglanti.Close();
    MessageBox.Show("Kayıt Eklendi.");
    id.Text = "";
    isim.Text = "";
    comboBox1.Items.Clear();
    mesaj.Text = "";
}









d)	Sil butonuna tıklandığında, formdaki "id" TextBox'ında bulunan değere karşılık gelen kayıt, "musteriler" tablosundan silinsin.
Çözüm: 
private void sil_Click(object sender, EventArgs e)
 {
     MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=db;Uid=root;Pwd=;Charset=utf8");
     baglanti.Open();
     MySqlCommand sql = new MySqlCommand("DELETE FROM musteriler WHERE ID=@id", baglanti);
     sql.Parameters.AddWithValue("@id", id.Text);
     sql.ExecuteNonQuery();
     baglanti.Close();
     MessageBox.Show("Kayıt Silindi.");
     id.Text = "";
     isim.Text = "";
     comboBox1.Items.Clear();
     mesaj.Text = "";
 }


e)	Güncelle butonuna tıklandığında, formdaki "id" TextBox'ında bulunan değere karşılık gelen kayıt, formdaki mevcut bilgilere göre "musteriler" tablosunda güncellensin.
Çözüm:
private void guncelle_Click(object sender, EventArgs e)
{
    MySqlConnection baglanti = new MySqlConnection("Server=localhost, Database=db, Uid=root,Pwd=;Charset=utf8");
    baglanti.Open();
    MySqlCommand sql=new MySqlCommand("UPDATE musteriler SET İsim=@isim, Konu=@konu, Mesaj=@mesaj WHERE ID=@id", baglanti);
    sql.Parameters.AddWithValue("@isim", isim.Text);    
    sql.Parameters.AddWithValue("@konu", comboBox1.SelectedIndex);
    sql.Parameters.AddWithValue("@mesaj", mesaj.Text);
    baglanti.Close();
    MessageBox.Show("Kayıt Güncellendi.");
    id.Text = "";
    isim.Text = "";
    comboBox1.Items.Clear();
    mesaj.Text = "";
}








