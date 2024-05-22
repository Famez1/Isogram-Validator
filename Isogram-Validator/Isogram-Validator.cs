using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isogram_Validator
{
    class IsogramValidator
    {
       public string RemoveDuplicates(string text)
        {
            List<char> uniqueChars = new List<char>();
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