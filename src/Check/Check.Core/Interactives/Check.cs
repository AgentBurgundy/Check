using CheckNET.Core.Assertions;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace CheckNET.Core.Interactives
{
    public static class Check
    {
        public static void That<T>(Check<T> val)
        {
            var framework = GetFrameworkInUse(val);

            if (framework == TestFramework.NUnit)
            {
                NUnit.Framework.Assert.That(val.Result);
            }
            else if (framework == TestFramework.Xunit)
            {
                Xunit.Assert.True(val.Result);
            }
        }

        public static T Argument<T>(Check<T> arg)
        {
            return arg.Value;
        }

        private static TestFramework GetFrameworkInUse<T>(Check<T> val)
        {
            var nunitAttribute = new StackFrame(2).GetMethod().CustomAttributes.Where(a => a.AttributeType.FullName.Contains("NUnit")).FirstOrDefault();
            var xunitAttribute = new StackFrame(2).GetMethod().CustomAttributes.Where(a => a.AttributeType.FullName.Contains("Xunit")).FirstOrDefault();

            if (nunitAttribute != default(CustomAttributeData))
            {
                return TestFramework.NUnit;
            }
            else if (xunitAttribute != default(CustomAttributeData))
            {
                return TestFramework.Xunit;
            }
            else return TestFramework.NoFramework;
        }
    }
}
