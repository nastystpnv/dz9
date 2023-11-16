using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz9
{
    public interface ICipher
    {
        string encode(string input);
        string decode(string input);
    }
}
