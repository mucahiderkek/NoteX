using System;
using System.IO;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Drawing;
using iTextSharp.text;
using iTextSharp.text.pdf;
using NHunspell; // Hunspell kütüphanesini ekledik.

namespace NotDefteri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ApplyButtonStyles();
            this.Resize += new EventHandler(Form1_Resize);
            this.MouseWheel += new MouseEventHandler(Form1_MouseWheel); // Formun MouseWheel olayını bağla
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            panel1.Left = 0;
            panel1.Top = 0;
            // Label'ı formun sol alt köşesine sabitle
            lblKarakterSayisi.Left = 10; // Sol kenardan 10 piksel
            lblKarakterSayisi.Top = this.ClientSize.Height - lblKarakterSayisi.Height - 10; // Alt kenardan 10 piksel
        }

        private void ApplyButtonStyles()
        {
            foreach (Control control in panel1.Controls)
            {
                if (control is Button btn)
                {
                    btn.BackColor = Color.FromArgb(224, 242, 255);
                    btn.ForeColor = Color.FromArgb(64, 64, 64);
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;

                    btn.MouseEnter += (sender, e) => btn.BackColor = Color.FromArgb(192, 229, 255);
                    btn.MouseLeave += (sender, e) => btn.BackColor = Color.FromArgb(224, 242, 255);
                }
            }
            panel1.BackColor = Color.FromArgb(240, 248, 255);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Font = new System.Drawing.Font("Segoe UI", 10);
            textBox1.Font = new System.Drawing.Font("Arial", 12);
            ApplyButtonStyles();
            textBox1.MouseWheel += new MouseEventHandler(textBox1_MouseWheel);
            // Label'ı formun sol alt köşesine sabitle
            lblKarakterSayisi.Left = 10; // Sol kenardan 10 piksel
            lblKarakterSayisi.Top = this.ClientSize.Height - lblKarakterSayisi.Height - 10; // Alt kenardan 10 piksel
        }

        private void Form1_MouseWheel(object sender, MouseEventArgs e)
        {
            // Ctrl tuşu basılıysa yazı tipi boyutunu büyüt/küçült
            if (Control.ModifierKeys == Keys.Control)
            {
                float currentSize = textBox1.Font.Size;
                float newSize = currentSize + (e.Delta > 0 ? 1 : -1); // Yukarı ise büyüt, aşağı ise küçült

                if (newSize >= 8 && newSize <= 72) // Boyut sınırları
                {
                    textBox1.Font = new System.Drawing.Font(textBox1.Font.FontFamily, newSize, textBox1.Font.Style);
                }
            }
        }

        private void textBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            // Bu metodu boş bırakabilirsiniz, çünkü Form1_MouseWheel metodu kullanılacak.
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Metin Dosyaları|*.txt";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(openFile.FileName);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Metin Dosyaları|*.txt";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFile.FileName, textBox1.Text);
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog.Font;
            }
        }

        private void btnRenk_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog.Color;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lblKarakterSayisi.Text = "Karakter Sayısı: " + textBox1.Text.Length.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string filePath = "otomatik_Kayir.txt";
            File.WriteAllText(filePath, textBox1.Text);
        }

        private void btnPdfKaydet_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "PDF Dosyaları|*.pdf";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                Document doc = new Document();
                PdfWriter.GetInstance(doc, new FileStream(saveFile.FileName, FileMode.Create));
                doc.Open();
                doc.Add(new Paragraph(textBox1.Text));
                doc.Close();
            }
        }

        // ✅ Hunspell ile Yazım Denetimi Butonu
        private void btnSpellCheck_Click(object sender, EventArgs e)
        {
            string dicPath = Path.Combine(Application.StartupPath, "tr_TR.dic");
            string affPath = Path.Combine(Application.StartupPath, "tr_TR.aff");

            if (!File.Exists(dicPath) || !File.Exists(affPath))
            {
                MessageBox.Show("Dil dosyaları bulunamadı! Lütfen 'tr_TR.dic' ve 'tr_TR.aff' dosyalarını proje klasörüne ekleyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (Hunspell hunspell = new Hunspell(affPath, dicPath))
            {
                string[] words = textBox1.Text.Split(' ');
                string incorrectWords = "";

                foreach (string word in words)
                {
                    if (!hunspell.Spell(word))
                    {
                        incorrectWords += word + "\n";
                    }
                }

                if (incorrectWords != "")
                {
                    MessageBox.Show("Yanlış Kelimeler:\n" + incorrectWords, "Yazım Denetimi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Tüm kelimeler doğru!", "Yazım Denetimi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
