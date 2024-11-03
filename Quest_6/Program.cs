using System.Xml.Linq;

namespace Quest_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero myHero = new Hero("Paige", "NotHealthy", 100, 100);
            myHero.ShowStats();
            myHero.Attack();
            myHero.Defend();
        }
    }

    public class Character
    {
        protected string Name { get; set; }
        protected string Health { get; set; }
        protected int Power { get; set; }

        public Character(string name, string health, int power)
        {
            Name = name;
            Health = health;
            Power = power;
        }

        public virtual void Attack()
        {
            Console.WriteLine($"{Name} attacks with power {Power}.");
        }

        public void ShowStats()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Power: {Power}");
        }
    }

    public class Hero : Character
    {

        private int DefenseLevel { get; set; }

        public Hero(string name, string health, int power, int defenseLevel) : base(name, health, power)
        {
            DefenseLevel = defenseLevel;
        }
        public void Defend()
        {
            Console.WriteLine($"Hero defends with level {DefenseLevel} defense");
        }

        public override void Attack()
        {
            Console.WriteLine($"{Name} courageously strikes with a power of {Power}!");
        }
    }
}
