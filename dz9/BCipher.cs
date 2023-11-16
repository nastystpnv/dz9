using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz9
{
    internal class BCipher : ICipher
    {
        public string encode(string input)
        {
            char[] result = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                if (char.IsLetter(currentChar))
                {
                    char baseChar = char.IsUpper(currentChar) ? 'A' : 'a';
                    result[i] = (char)(((baseChar + 25 - (currentChar - baseChar)) % 26) + baseChar);
                }
                else
                {
                    result[i] = currentChar;
                }
            }
            return new string(result);

        }

       
        public string decode(string input)
        {
            return encode(input);
        }
    }
}
