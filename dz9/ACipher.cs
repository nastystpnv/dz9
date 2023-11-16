using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz9
{
    public class ACipher : ICipher
    {
        public string encode(string input)
        {       
            char[] charAr = new char[input.Length];
            for (int i = 0; i < charAr.Length; i++)
            {
                if (char.IsLower(charAr[i]))
                {
                    charAr[i] = char.ToUpper(charAr[i]);
                }
                else if (char.IsUpper(charAr[i]))
                {
                    charAr[i] = char.ToLower(charAr[i]);
                }
            }
            for (int i = 0; i < charAr.Length; i++)
            {
                Console.Write(charAr[i]);
            }
            return new string(charAr);
        }
        public string decode(string input)
        {
            return encode(input);
        }

    }
}


        
    

