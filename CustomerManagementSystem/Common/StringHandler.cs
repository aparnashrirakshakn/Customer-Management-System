using System;

namespace Common
{
    public static class StringHandler
    {
        public static string InsertSpaces(string source)
        {
            string result = "";

            if (!string.IsNullOrWhiteSpace(source))
            {
                foreach(char character in source)
                {
                    if (char.IsUpper(character))
                    {
                        //trim off any extra space before adding another one
                        result = result.Trim();
                        result += " ";
                    }
                    result += character;
                }
            }
            //trim off any spaces at the beginning of the result
            result = result.Trim();
            return result;
        }
    }
}
