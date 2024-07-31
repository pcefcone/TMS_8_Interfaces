
using TMS_8_Interfaces;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Put dog name");
        string DogName = Console.ReadLine();
        Console.WriteLine("Put cat name");
        string CatName = Console.ReadLine();
        Animal Dog = new Dog();
        Dog.SetAnimalName(DogName);
        Dog.G
        Animal Cat = new Cat();
        Cat.SetAnimalName(CatName);
        Dog.Eat();
        Cat.Eat();
    }


}