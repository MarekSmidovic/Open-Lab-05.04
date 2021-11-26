using System;

namespace Open_Lab_05._04
{
    public class StringTools
    {
        public string RemoveSpecialCharacters(string original)
        {
            return System.Text.RegularExpressions.Regex.Replace(original, "[^a-zA-Z0-9_.]+", "", System.Text.RegularExpressions.RegexOptions.Compiled);
        }
    }
}
