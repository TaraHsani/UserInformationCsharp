namespace UserInformationCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your Name?");
            string Name = Console.ReadLine();

            Console.WriteLine("How old are you?");
            string agestr = Console.ReadLine();
            int age = int.Parse(agestr);
            ;
            Console.WriteLine("What is your Email adress?");
            string Email = Console.ReadLine();

            Console.WriteLine("Please writh you adress");
            string adress = Console.ReadLine();

            string discribtion = $"My name is {Name} and I'm {age} years old and my adress is {adress} ";
            Console.WriteLine(discribtion);
        }
    }
}