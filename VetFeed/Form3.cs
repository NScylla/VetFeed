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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public Owners owner;

        Form2 sahip = new Form2();

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void cmbBoxFood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbBoxDiet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn3Next_Click(object sender, EventArgs e)
        {
            DialogResult devam = new DialogResult();

            VetFeed.FoodType fdtype;
            Enum.TryParse(cmbBoxFood.SelectedItem.ToString(), out fdtype);

            VetFeed.DietType dttype;
            Enum.TryParse(cmbBoxDiet.SelectedItem.ToString(), out dttype);


            Food Food1 = new Food(fdtype, dttype);

            devam = MessageBox.Show("Kediniz için uygun mamaları görmek üzeresiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            if (devam == DialogResult.OK)
            {
                owner.Cat.FoodType = Food1;
                Form4 mamalar = new Form4(owner);
               
                mamalar.Show();
                this.Hide();
            }
                
        }

        private void btn3Back_Click(object sender, EventArgs e)
        {
            DialogResult geri = new DialogResult();

            geri = MessageBox.Show("Kendiniz ile ilgili bilgilere dönmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (geri == DialogResult.Yes)
                sahip.Show();
            this.Hide();
        }
    }

  
}
