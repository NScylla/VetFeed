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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Cats cat;

        Form1 Kedi = new Form1();


        public void TextControl(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Sayısal Değer Giremezsiniz, Lütfen Kontrol Ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txtBoxOwnersName_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextControl(e);
        }

        private void cmbBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn2Next_Click(object sender, EventArgs e)
        {
            DialogResult devam = new DialogResult();

            VetFeed.Cities cts;
            Enum.TryParse(cmbBoxCity.SelectedItem.ToString(), out cts);

            Owners Owner1 = new Owners(txtBoxOwnersName.Text, txtBoxOwnersSurname.Text, dTpBirthDate.Value, cts);
            
            Owner1.Cat = cat;

            string ownerText = string.Format("Bilgileriniz aşağıdaki gibidir. Onaylıyorsanız devam edebilirsiniz.\n Adınız: {0},\n Soyadınız: {1},\n Yaşınız: {2},\n Yaşadığınız Şehir: {3}", Owner1.OwnersName, Owner1.OwnersSurname, Owner1.Age, Owner1.Living);

            devam = MessageBox.Show(ownerText, "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (devam == DialogResult.OK)
            {
                Form3 Food = new Form3();
                Food.owner = Owner1;
                Food.Show();
                this.Hide();
            }
            else
            {
                txtBoxOwnersName.Clear();
                txtBoxOwnersSurname.Clear();
            }

        }

        private void btn2Back_Click(object sender, EventArgs e)
        {
            DialogResult geri = new DialogResult();

            geri = MessageBox.Show("Kediniz ile ilgili bilgilere dönmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (geri == DialogResult.Yes)
                Kedi.Show();
            this.Hide();

        }

        private void btn2Clr_Click(object sender, EventArgs e)
        {
            txtBoxOwnersName.Clear();
            txtBoxOwnersSurname.Clear();

        }

        private void txtBoxOwnersName_Leave(object sender, EventArgs e)
        {
            SpaceControl(((TextBox)sender).Text);
        }

        public void SpaceControl(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Boş Bırakamazsınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dTpBirthDate_TabStopChanged(object sender, EventArgs e)
        {
            int Age;
            DateTime DTarihi = dTpBirthDate.Value;

            Age = DateTime.Today.Year - DTarihi.Year;

            if (Age < 18 && Age > 75)
                MessageBox.Show("Doğum Tarihinizi Kontrol Ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Hand);

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }

}


