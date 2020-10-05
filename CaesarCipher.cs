using System;
using System.Collections.Generic;
using System.Linq;

namespace Encryption_Computer_Science
{
    public class CaesarCipher
    {
        private readonly int _key;
        private readonly string _plainText;
        private readonly string[] _alphabet = new[] {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
            "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"}; 

        public CaesarCipher(string plaintext, int shiftKey)
        {
            _plainText = plaintext;
            _key = shiftKey;
        }

        public string Encrypt()
        {
            var encryptedList = new List<string>();
            foreach (var letter in _plainText)
            {
                var stringLetter = letter.ToString();
                if (Array.IndexOf(_alphabet, stringLetter) + _key >= 26)
                {
                    var modifiedLetter = _alphabet[Array.IndexOf(_alphabet, stringLetter) + _key - 26];
                    encryptedList.Add(modifiedLetter);
                }
                else
                {
                    var modifiedLetter = _alphabet[Array.IndexOf(_alphabet, stringLetter) + _key];
                    encryptedList.Add(modifiedLetter);
                }
            }

            return string.Join("", encryptedList);
        }

        public string Decrypt(string message, int shift)
        {
            var decryptedList = new List<string>();
            foreach (var letter in message)
            {
                var stringLetter = letter.ToString();
                if (Array.IndexOf(_alphabet, stringLetter) - _key <= 0)
                {
                    var modifiedLetter = _alphabet[Array.IndexOf(_alphabet, stringLetter) - _key + 26];
                    decryptedList.Add(modifiedLetter);
                }
                else
                {
                    var modifiedLetter = _alphabet[Array.IndexOf(_alphabet, stringLetter) - _key];
                    decryptedList.Add(modifiedLetter);
                }
            }

            return string.Join("", decryptedList);
        }

    }
}