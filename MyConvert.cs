using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BookStore
{
    public class MyConvert
    {
        public static string ToAscii(string value)
        {
            //var chars =
            //    from c in value.Normalize(NormalizationForm.FormD).ToCharArray()
            //    let uc = CharUnicodeInfo.GetUnicodeCategory(c)
            //    where uc != UnicodeCategory.NonSpacingMark
            //    select c;
            //value = new string(chars.ToArray()).Normalize(NormalizationForm.FormC);

            //return value;

            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = value.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
    }
}
