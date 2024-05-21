using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isogram_Validator
{
    internal class Isogram_Validator
    {
        string RemoveDuplicates(string text)
        {
            HashSet<char> uniqueChars = new HashSet<char>();
            StringBuilder stringBuilder = new StringBuilder();

            foreach (char c in text.ToLower())
            {
                if (!uniqueChars.Contains(c))
                {
                    stringBuilder.Append(c);
                    uniqueChars.Add(c);
                }
            }

            return stringBuilder.ToString();
        }

    }
}
