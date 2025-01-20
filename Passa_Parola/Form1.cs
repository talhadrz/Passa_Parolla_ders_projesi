using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passa_Parola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlıs = 0;
        // cevaplar --------------------------------------------------------------------------------------------------------
        string[] cevaplar = { "akdeniz", "bursa", "cuma", "diyarbakır", "eski", "ferman", "güneş", "halı", "ısparta", "içel", "jandarma", "kayısı", "lale", "mart", "ney", "ozan", "pırasa", "ramazan", "snake", "tarkan", "umut", "van", "yıldırım", "zeytin" };
        // sorular ---------------------------------------------------------------------------------------------------------
        string[] sorular = { "Ülkemizin güney kısmındaki kıyılar?", "Yeşilliğiyle ünşü marmara ilimiz?", "Müslümanların kutsal günü?", "Karpuzuyla ünlü ilimiz?", "Yeni kelimesinin zıt anlamı?", "Padişahın emirlerinin yazılı hali?", "Dünyanın ısı kaynağı?", "Öğrencilerin kötü karne getirince bakışyığı nesne?", "Gülüyle ünlü ilimiz?", "Mersinin diğer ismi?", "Askeri bir topluluk?", "Malatyanın meşhur meyvesi?", "Her yıl bahar aylarında düzenlenen meşhur çiçek festivali?", "Yılın 3. ayı?", "Üflemeli bir büzik aleti?", "Halk şairi?", "Çocukların pek sevmediği pirinç havuç gibi sebzeler ile yapılan yemek?", "11 ayın sultanı?", "İngilizcede yılan?", "Türkiyenin megasıtarı?", "Ümit kelimesinin eş anlamlısı?", "Kahvaltısı ile ünlü ilimiz?", "Şimşek kelimesinin eş anlamlısı?", "Ege bölgesinin ençok ağacı bulunan yağıda yapılan bir kahvaltı besini?" };
        // renkler ------------------------------------------------------------------------------------------------------
        Color yesil = Color.Green;
        Color kırmızı = Color.Red;
        Color sarı = Color.Yellow;
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            Button foundButton = Controls.Find($"button{soruno}", true).FirstOrDefault() as Button;
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == cevaplar[soruno - 1])
                {
                    foundButton.BackColor = yesil;
                    lblTrue.Text = (++dogru).ToString();
                }
                else
                {
                    foundButton.BackColor = kırmızı;
                    lblFalse.Text = (++yanlıs).ToString();
                }
                linkLabel1.Enabled = true;
                textBox1.Enabled = false;
            }
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (soruno < 24)
                soruno++;
            this.Text = "Soru " + soruno.ToString();
            linkLabel1.Text = "Sonraki";
            richTextBox1.Text = sorular[soruno - 1];
            Button buton = Controls.Find($"button{soruno}", true).FirstOrDefault() as Button;
            buton.BackColor = sarı;
            linkLabel1.Enabled = false;
            textBox1.Enabled = true;
            textBox1.Text = null;
        }
    }
}