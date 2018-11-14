
namespace Engine
{
    public class HealingPotion : Item // Inheritance, child class or derived class from Item class
    {
        public int AmountToHeal { get; set; }

        public HealingPotion(int id, string name, string namePlural,
            int amountToHeal, int price) : base(id, name, namePlural, price) // take values from the parameters in the class
        {
            AmountToHeal = amountToHeal;
        }
    }
}
