using System;
using System.Linq;
using System.Numerics;

namespace XNLeisureTest
{
    public class Helper
    {
        public static int? GetTypes(Object value, int? add, string itemToFind)
        {
            if (value == null) { return null; }

            var typeCheck = value.GetType();

            if (typeCheck == typeof(string))
            {
                if (string.IsNullOrWhiteSpace((string)value)) { return null; }

                var res = CountOccurance(value.ToString(), itemToFind);

                return res;
            }

            if (typeCheck == typeof(BigInteger))
            {
                value = (value == null || (BigInteger?)value == 0) ? null : value;

                value = value.ToString();

                value += add.ToString();

                var res = CountOccurance(value.ToString(), itemToFind);

                return res;
            }

            return null;
        }

        private static int CountOccurance(string str, string itemToFind)
        {
            int count = str.ToString().Count(f => f.ToString().ToLower() == itemToFind);

            return count;
        }
    }
}
