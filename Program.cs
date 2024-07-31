internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Put dog name");
        string name = Console.ReadLine();
        Animal Dog = new Dog();
        Dog.SetName(name);
        Dog.Eat();
    }

    public abstract class Animal
    {
        private string _name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public abstract void Eat();

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name.ToString();
        }
    }

    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine($"Dog have a name {0} eat food");
        }
    }
}