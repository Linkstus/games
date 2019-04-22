using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    class Cards
    {
        private string type;
        private int damage;
        private string name;

        public Cards(string type, int damage, string name)
        {
            this.type = type;
            this.damage = damage;
            this.name = name;
        }

        public override string ToString()
        {
            string card = string.Format("Name: {0} \nDamage: {1} \nType: {2}\n", name, damage, type);
            return card;
        }

        public static void Main(String[] args)
        {
            Cards c;


        }
    }
}
