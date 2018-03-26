using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;
using NUnit.Framework;

/// <summary>
/// We can do a couple of cool things with this.
/// 
/// I think we should make the extensions not extend Check<T> but rather the object type itself. 
/// This allows the extensions to be used for assertions or just general value checking.
/// 
/// Namespace so that we have two NuGet packages essentially. One for assertions and one for checking.
/// 
/// Assertions should be handled within the Check.This() method. Make Check.This take in a Check<T>
/// instead of T so we can assert on that value and keep it all clean.
/// </summary>

namespace CheckNET.Core.Interactives
{
    public class Check<T>
    {
        internal T Value { get; set; }
        internal Type TypeOfT { get; set; }
        internal bool Result { get; set; }
        public T And => Value;

        internal Check(T val)
        {
            Value = val;
            TypeOfT = val.GetType();
        }

        internal Check(T val, bool res)
        {
            Value = val;
            Result = res;
        }
    }
}
