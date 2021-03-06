using System;
using System.Linq;
using System.Numerics;

namespace XNLeisureTest
{
    public class Helper
    {
        public static Object GetTypes(object value, int? add, string itemToFind)
        {
            if (value is null) { return null; }

            var typeCheck = value.GetType();

            if (typeCheck == typeof(string))
            {
                if (string.IsNullOrWhiteSpace((string)value)) { return string.Empty; }

                var res = CountOccurrence(value.ToString(), itemToFind);

                return res;
            }

            if (typeCheck == typeof(BigInteger))
            {
                value = (value == null || (BigInteger?)value == 0) ? null : value;

                value = value.ToString();

                value += add.ToString();

                var res = CountOccurrence(value.ToString(), itemToFind);

                return res;
            }

            return null;
        }

        private static int CountOccurrence(string str, string itemToFind)
        {
            int count = str.Count(f => f.ToString().ToLower() == itemToFind.ToLower());

            return count;
        }
    }
}
