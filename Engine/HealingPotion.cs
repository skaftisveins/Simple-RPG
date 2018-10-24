using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class HealingPotion : Item // Inheritance, child class or derived class from Item class
    {
        public int AmountToHeal { get; set; }

        public HealingPotion(int id, string name, string namePlural,
            int amountToHeal) : base(id, name, namePlural) // take values from the parameters in the class
        {
            AmountToHeal = amountToHeal;
        }
    }
}
