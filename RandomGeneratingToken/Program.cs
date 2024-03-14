using System.ComponentModel;

namespace RandomGeneratingToken
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] charatersForToken = {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z",
            "a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z",
            "0","1","2","3","4","5","6","7","8","9","%","$"};
            string token = "";
            for (int i = 0; i < 9; i++)
            {
                Random randomCharacter = new Random();
                string randomCharaterGenerated = charatersForToken[randomCharacter.Next(charatersForToken.Length)];
                token = token + randomCharaterGenerated;
            }
            Console.WriteLine(token);

        }
    }
}