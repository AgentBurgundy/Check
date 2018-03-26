using CheckNET.Core.Assertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CheckNET.Core.Interactives
{
    public static class Check
    {
        public static void That<T>(Check<T> val)
        {
            var framework = GetFrameworkInUse(val);

            if (framework == TestFramework.NUnit)
            {
                Assert.That(val.Result);
            }
        }

        private static TestFramework GetFrameworkInUse<T>(Check<T> val)
        {
            var nunitAttribute = new StackFrame(2).GetMethod().CustomAttributes.Where(a => a.AttributeType.FullName.Contains("NUnit")).FirstOrDefault();

            if (nunitAttribute != default(CustomAttributeData))
            {
                return TestFramework.NUnit;
            }
            else return TestFramework.NoFramework;
        }
    }
}
