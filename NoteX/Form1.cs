using System;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NotDefteri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ✅ Yeni Dosya Butonu
        private void btnYeni_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        // ✅ Dosya Açma Butonu
        private void btnAc_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Metin Dosyaları|*.txt";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(openFile.FileName);
            }
        }

        // ✅ Dosya Kaydetme Butonu
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Metin Dosyaları|*.txt";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFile.FileName, textBox1.Text);
            }
        }

        // ✅ Çıkış Butonu
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
