using System;
namespace macapp
{
    public static class ExtensionMethods
    {
        public static int WordCount(this string str)
        {
            var wordcount = str.Split(new char[] { ' ', '.', '?'}, StringSplitOptions.RemoveEmptyEntries).Length;
            return wordcount;
        }
    }
}
