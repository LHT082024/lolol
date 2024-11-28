using System.Security.Cryptography.X509Certificates;

namespace lol;

class Program
{
    static void Main(string[] args)
    {
        Binary binary = new Binary();

        Console.WriteLine("write text here");
        string userInput = Console.ReadLine();

        string binaryResult = Binary.makeBinary(userInput);

        Console.WriteLine(binaryResult);
    }


}
