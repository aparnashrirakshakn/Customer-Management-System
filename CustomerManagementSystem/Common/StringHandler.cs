using System;

namespace Common
{
    public static class StringHandler
    {
        /// <summary>
        /// Inserts spaces before each capital letter in a string
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string InsertSpaces(this string source)
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
