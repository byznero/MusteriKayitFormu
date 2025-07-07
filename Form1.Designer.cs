namespace soru1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            isim = new TextBox();
            id = new TextBox();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            mesaj = new RichTextBox();
            kaydet = new Button();
            guncelle = new Button();
            sil = new Button();
            ara = new Button();
            SuspendLayout();
            // 
            // isim
            // 
            isim.Location = new Point(92, 63);
            isim.Name = "isim";
            isim.Size = new Size(150, 31);
            isim.TabIndex = 0;
            // 
            // id
            // 
            id.Location = new Point(92, 26);
            id.Name = "id";
            id.Size = new Size(150, 31);
            id.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveBorder;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(27, 30);
            label1.Name = "label1";
            label1.Size = new Size(32, 27);
            label1.TabIndex = 2;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveBorder;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(27, 66);
            label2.Name = "label2";
            label2.Size = new Size(47, 27);
            label2.TabIndex = 3;
            label2.Text = "İsim";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(310, 66);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveBorder;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(310, 26);
            label3.Name = "label3";
            label3.Size = new Size(55, 27);
            label3.TabIndex = 5;
            label3.Text = "Konu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveBorder;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(26, 112);
            label4.Name = "label4";
            label4.Size = new Size(60, 27);
            label4.TabIndex = 6;
            label4.Text = "Mesaj";
            // 
            // mesaj
            // 
            mesaj.Location = new Point(26, 142);
            mesaj.Name = "mesaj";
            mesaj.Size = new Size(466, 240);
            mesaj.TabIndex = 7;
            mesaj.Text = "";
            // 
            // kaydet
            // 
            kaydet.BackColor = Color.LightGreen;
            kaydet.Location = new Point(26, 388);
            kaydet.Name = "kaydet";
            kaydet.Size = new Size(112, 34);
            kaydet.TabIndex = 8;
            kaydet.Text = "Kaydet";
            kaydet.UseVisualStyleBackColor = false;
            // 
            // guncelle
            // 
            guncelle.BackColor = Color.PapayaWhip;
            guncelle.Location = new Point(144, 388);
            guncelle.Name = "guncelle";
            guncelle.Size = new Size(112, 34);
            guncelle.TabIndex = 9;
            guncelle.Text = "Güncelle";
            guncelle.UseVisualStyleBackColor = false;
            // 
            // sil
            // 
            sil.BackColor = Color.LightCoral;
            sil.Location = new Point(262, 388);
            sil.Name = "sil";
            sil.Size = new Size(112, 34);
            sil.TabIndex = 10;
            sil.Text = "Sil";
            sil.UseVisualStyleBackColor = false;
            // 
            // ara
            // 
            ara.BackColor = Color.AliceBlue;
            ara.Location = new Point(380, 388);
            ara.Name = "ara";
            ara.Size = new Size(112, 34);
            ara.TabIndex = 11;
            ara.Text = "Ara";
            ara.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ara);
            Controls.Add(sil);
            Controls.Add(guncelle);
            Controls.Add(kaydet);
            Controls.Add(mesaj);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(id);
            Controls.Add(isim);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox isim;
        private TextBox id;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private Label label4;
        private RichTextBox mesaj;
        private Button kaydet;
        private Button guncelle;
        private Button sil;
        private Button ara;
    }
}
