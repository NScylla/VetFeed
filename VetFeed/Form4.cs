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
    public partial class Form4 : Form
    {
        public Form4(Owners owner)
        {
            owner1 = owner;
            InitializeComponent();
        }

        private Owners owner1;

        Form1 Kedi = new Form1();
        Form2 Sahip = new Form2();
        Form3 Food = new Form3();

        public IFormatProvider txtBoxCatName_AcceptsTabChanged { get; private set; }

        private void Form4_Enter(object sender, EventArgs e)
        {
            lblCatName.Text = owner1.Cat.Name;
            labelSahip.Text = owner1.OwnersName;
            lblID.Text = owner1.ID.ToString();

        }

        private void lnkFood_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (owner1.Cat.FoodType.Type == FoodType.Dry && owner1.Cat.FoodType.DietType == DietType.Kısırlaştırılmış)
                System.Diagnostics.Process.Start("https://www.hillspet.com.tr/health-conditions/cat/cat-urinary");

            if (owner1.Cat.FoodType.Type == FoodType.Dry && owner1.Cat.FoodType.DietType == DietType.Tahılsız)
                System.Diagnostics.Process.Start("https://www.hillspet.com.tr/health-conditions/cat/digestive");

            if (owner1.Cat.FoodType.Type == FoodType.Dry && owner1.Cat.FoodType.DietType == DietType.YavruKedi)
                System.Diagnostics.Process.Start("https://www.hillspet.com.tr/search?_SPECIES=cat&_LIFESTAGE=youth&tab=learn#stq=&stp=1");

            if (owner1.Cat.FoodType.Type == FoodType.Dry && owner1.Cat.FoodType.DietType == DietType.Zayıflama)
                System.Diagnostics.Process.Start("https://www.hillspet.com.tr/health-conditions/cat/weight-management");

            if (owner1.Cat.FoodType.Type == FoodType.Age && owner1.Cat.FoodType.DietType == DietType.Kısırlaştırılmış)
                System.Diagnostics.Process.Start("https://www.hillspet.com.tr/health-conditions/cat/cat-urinary");

            if (owner1.Cat.FoodType.Type == FoodType.Age && owner1.Cat.FoodType.DietType == DietType.Tahılsız)
                System.Diagnostics.Process.Start("https://www.hillspet.com.tr/health-conditions/cat/digestive");

            if (owner1.Cat.FoodType.Type == FoodType.Age && owner1.Cat.FoodType.DietType == DietType.YavruKedi)
                System.Diagnostics.Process.Start("https://www.hillspet.com.tr/search?_SPECIES=cat&_LIFESTAGE=youth&tab=learn#stq=&stp=1");

            if (owner1.Cat.FoodType.Type == FoodType.Age && owner1.Cat.FoodType.DietType == DietType.Zayıflama)
                System.Diagnostics.Process.Start("https://www.hillspet.com.tr/health-conditions/cat/weight-management");
        }
    }
}
