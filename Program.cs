
using TMS_8_Interfaces;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Put dog name");
        string DogName = Console.ReadLine();
        Console.WriteLine("Put cat name");
        string CatName = Console.ReadLine();

        string DogVoice = "Woof";
        string CatVoice = "Meow";

        Dog instance = new Dog();
        instance.GetVoice(DogName, DogVoice);
        Cat instance1 = new Cat();
        instance1.GetVoice(CatName, CatVoice);
    }


}