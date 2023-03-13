using InitonlySetter;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Using Init-Setter - Regular way!");

        Member memberObj = new Member
        {
            Id = 1,
        };



        // memberObj.Name = "Abdul Salam"; // Not allowed
        // memberObj.Address = "Kerala, India"; //Not allowed 

        Console.WriteLine("****************START - Member Details***********");

        Console.WriteLine($"ID : -  {memberObj.Id}");
        Console.WriteLine($"Name :-  {memberObj.Name}");
        Console.WriteLine($"Address:-   {memberObj.Address}");
        Console.ReadLine();

        Console.WriteLine("****************END - Member Details***********");
    }
}