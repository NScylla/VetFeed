using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetFeed
{
    public class Cats
    {

        public Cats(string name, string breed, int age, Colors color)
        {
            this.Name = name;
            this.Breed = breed;
            this.Age = age;
            this.Color = color;
        }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("İsim Alanı Boş Bırakılamaz.");
                else
                    name = value;
            }
        }

        private string breed;
        public string Breed
        {
            get { return breed; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Cins Alanı Boş Bırakılamaz.");
                else
                    breed = value;
            }
        }

        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0 || value > 15)
                    throw new Exception("Girmiş olduğunuz değeri kontrol ediniz.");
                else
                    age = value;
            }
        }

        private Colors color;
        public Colors Color
        {
            get { return color; }
            set { color = value; }
        }

        private Food foodtype;
        public Food FoodType
        {
            get { return foodtype; }
            set { foodtype = value; }
        }

    }

    public enum Colors
    {
        Beyaz,
        Siyah,
        Sarı,
        Karışık
    }
}
