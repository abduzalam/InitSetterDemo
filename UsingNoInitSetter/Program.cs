using UsingNoInitSetter;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Using Non-Init-Setter - Regular way!");

        Member memberObj = new Member();
        memberObj.Id = 1;
        memberObj.Name = "Abdul Salam";
        memberObj.Address = "Kerala, India";

        Console.WriteLine("****************START - Member Details***********");

        Console.WriteLine($"ID : -  { memberObj.Id}");
        Console.WriteLine($"Name :-  {memberObj.Name}");
        Console.WriteLine($"Address:-   {memberObj.Address}");
        Console.ReadLine();

        Console.WriteLine("****************END - Member Details***********");
    }
}