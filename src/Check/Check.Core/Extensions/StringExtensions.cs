using CheckNET.Core.Interactives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckNET.Core.Extensions
{
    public static class StringExtensions
    {
        #region Null or Empty

        public static Check<string> IsNotEmpty(this string val)
        {
            var value = val ?? throw new ArgumentNullException("Cannot evalutate IsNotEmpty() against a null string.");

            return value.Equals("") ? throw new ArgumentException("String is Empty.") : new Check<string>(value, true);
        }

        public static Check<string> IsEmpty(this string val)
        {
            var value = val ?? throw new ArgumentNullException("Cannot evalutate IsEmpty() against a null string.");

            return !value.Equals("") ? throw new ArgumentException("String is Not Empty.") : new Check<string>(val, true);
        }

        public static Check<string> IsNullOrEmpty(this string val) => val.IsNotNull().And.IsNotEmpty();

        public static Check<string> IsNotNullOrEmpty(this string val) => val.IsNotNull().And.IsNotEmpty();

        #endregion

        public static Check<string> ContainsThese(this string val, IEnumerable<string> conditionals)
        {
            if (conditionals.Count() == 0)
                throw new ArgumentException("Cannot pass in empty IEnumerable<string> for conditionals.");

            var value = val ?? throw new ArgumentNullException("Cannot evaluate ContainsThese() against a null string.");

            foreach (var conditional in conditionals)
            {
                if (!val.Contains(conditional))
                    throw new ArgumentException($"String does not contain :: {conditional}");
            }

            return new Check<string>(value, true);
        }

        public static Check<string> MeetsCondition(this string val, Func<string, bool> conditional)
        {
            var method = conditional ?? throw new ArgumentNullException("Cannot evaluate MeetsCondition() with a null conditional.");
            var value = val ?? throw new ArgumentNullException("Cannot evaluate MeetsCondition() against a null string.");

            if (!method(value))
                throw new ArgumentException("String does not meet conditional.");

            return new Check<string>(value, true);
        }

    }
}
