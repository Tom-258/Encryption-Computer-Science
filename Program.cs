using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Encryption_Computer_Science
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Message:");
            var message = Console.ReadLine();
            Console.WriteLine("Shift:");
            var shift = Convert.ToInt32(Console.ReadLine());
            var caesarCipher = new CaesarCipher(message, shift);
            var cypherText = caesarCipher.Encrypt();
            Console.WriteLine(cypherText);
            Console.WriteLine(caesarCipher.Decrypt(cypherText, shift));
        }
    }
}
