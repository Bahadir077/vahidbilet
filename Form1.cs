using System;
using System.Windows.Forms;

namespace vahid_bilet
{
    public partial class Form1 : Form
    {
        private int count = 0;

        public Form1()
        {
            InitializeComponent();
            Text = "Vahid Bilet";

            // telefon MaskedTextBox olmalıdır
            telefon.Mask = "+000 (00) 000-00-00";
            telefon.PromptChar = '_';
        }

        // Marşrutları dəyişdir
        private void button1_Click(object sender, EventArgs e)
        {
            string temp = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = temp;
        }

        // Bilet əlavə et
        private void button2_Click(object sender, EventArgs e)
        {
            string menbe = comboBox1.Text.Trim();
            string teyinati = comboBox2.Text.Trim();
            string ad = adsoyad.Text.Trim();
            string finKod = fin.Text.Trim();
            string emailUnvani = email.Text.Trim();
            string yerNomresi = yer.Text.Trim();

            // Maskanın içindəki rəqэмүүдийг ғана alırıq
            telefon.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string telefonNomresi = telefon.Text.Trim();
            telefon.TextMaskFormat = MaskFormat.IncludeLiterals;

            if (string.IsNullOrWhiteSpace(menbe) ||
                string.IsNullOrWhiteSpace(teyinati) ||
                string.IsNullOrWhiteSpace(ad) ||
                string.IsNullOrWhiteSpace(finKod) ||
                string.IsNullOrWhiteSpace(emailUnvani) ||
                string.IsNullOrWhiteSpace(yerNomresi) ||
                string.IsNullOrWhiteSpace(telefonNomresi) ||
                !telefon.MaskCompleted)
            {
                MessageBox.Show(
                    "Bütün məlumatları doldurun. Telefon nömrəsini tam yazın.",
                    "Məlumat çatışmır",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (string.Equals(menbe, teyinati, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(
                    "Başlanğıc və təyinat şəhərləri eyni ola bilməz.",
                    "Yanlış marşrut",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            count++;

            string bilet =
                $"{count}) {menbe} - {teyinati} | " +
                $"{tarix.Value:dd.MM.yyyy} | {saat.Text} | Yer: {yerNomresi} | " +
                $"{ad} | FIN: {finKod} | {emailUnvani} | Tel: {telefon.Text}";

            listBox1.Items.Add(bilet);
            FormuTemizle();
        }

        // Seçilmiş bileti sil
        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Silmək üçün əvvəlcə bilet seçin.",
                    "Seçim edilməyib",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            while (listBox1.SelectedItems.Count > 0)
            {
                listBox1.Items.Remove(listBox1.SelectedItems[0]);
            }
        }

        // Proqramdan çıx
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult netice = MessageBox.Show(
                "Çıxmaq istədiyinizə əminsiniz?",
                "Bildiriş",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (netice == DialogResult.Yes)
                Close();
        }

        private void FormuTemizle()
        {
            comboBox1.SelectedIndex = -1;
            comboBox1.Text = string.Empty;

            comboBox2.SelectedIndex = -1;
            comboBox2.Text = string.Empty;

            saat.Text = string.Empty; // Fixed: ComboBox does not have Clear(), use Text property
            yer.Clear();
            adsoyad.Clear();
            fin.Clear();
            email.Clear();
            telefon.Clear();
        }

        private void tarix_ValueChanged(object sender, EventArgs e)
        {
        }

        private void telefon_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}