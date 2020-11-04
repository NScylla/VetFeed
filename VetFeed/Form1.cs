using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetFeed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        public void TextControl(KeyPressEventArgs e)

        {
            if (char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Sayısal Değer Giremezsiniz, Lütfen Kontrol Ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }

        }

        private void txtBoxCatName_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextControl(e);

        }

        private void cmbBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn1Next_Click(object sender, EventArgs e)
        {
            DialogResult devam = new DialogResult();

            VetFeed.Colors clr;
            Enum.TryParse(cmbBoxColor.SelectedItem.ToString(), out clr);

            Cats Cat1 = new Cats(txtBoxCatName.Text, txtBoxCatBreed.Text, Convert.ToInt32(nmrcAge.Value), clr);

            string catText = string.Format("Kedinin bilgileri aşağıdaki gibidir. Onaylıyorsanız devam edebilirsiniz.\n Kedinin Adı: {0},\n Kedinin Cinsi: {1},\n Kedinin Yaşı: {2},\n Kedinin Rengi: {3}", Cat1.Name, Cat1.Breed, Cat1.Age, Cat1.Color);

            devam = MessageBox.Show(catText, "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (devam == DialogResult.OK)
            {
                Form2 sahip = new Form2();
                sahip.cat = Cat1;
                sahip.Show();
                this.Hide();
            }
            else
            {
                txtBoxCatName.Clear();
                txtBoxCatBreed.Clear();
            }


        }

        private void btn1Clr_Click(object sender, EventArgs e)
        {
            txtBoxCatName.Clear();
            txtBoxCatBreed.Clear();

        }

        public void SpaceControl(string text)

        {
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Boş Bırakamazsınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtBoxCatName_Leave(object sender, EventArgs e)
        {
            SpaceControl(((TextBox)sender).Text);
        }

        public void txtBoxCatName_AcceptsTabChanged(object sender, EventArgs e)
        {
            string CatName = txtBoxCatName.Text;
        }

        private string catName;
        public string CatName
        {
            get { return catName; }
            set { catName = value; }
        }
        private void txtBoxCatName_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
    }
}

public enum Color
{
    Siyah = 1,
    Beyaz = 2,
    Sarı = 3,
    Karışık = 4
}

