using CheckNET.Core.Interactives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckNET.Core.Extensions
{
    public static class ObjectExtensions
    {
        public static Check<T> IsNotNull<T>(this T val)
        {
            var value = (object)val ?? throw new ArgumentNullException();

            return new Check<T>((T)value, true);
        }

        public static Check<T> IsNull<T>(this T val)
        {
            return val != null ? throw new ArgumentException() : new Check<T>(val, true);
        }
    }
}
