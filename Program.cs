
using TMS_8_Interfaces;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Put dog name");
        string name = Console.ReadLine();
        Animal Dog = new Dog();
        Dog.SetAnimalName(name);
        Dog.Eat();
    }


}