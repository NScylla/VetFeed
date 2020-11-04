using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetFeed
{
    public class Food
    {
        public Food(FoodType type, DietType dietType)
        {
            this.Type = type;
            this.DietType = dietType;
        }

        private FoodType type;
        public FoodType Type
        {
            get { return type; }
            set { type = value; }
        }

        private DietType dietType;
        public DietType DietType
        {
            get { return dietType; }
            set { dietType = value; }
        }


    }

    public enum FoodType
    {
        Dry,
        Age
    }

    public enum DietType
    {
        Zayıflama,
        Kısırlaştırılmış,
        Tahılsız,
        YavruKedi
    }
}
