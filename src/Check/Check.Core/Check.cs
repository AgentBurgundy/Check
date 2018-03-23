using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckNET.Core
{
    public class Check<T>
    {
        public bool Result { get; internal set; }
        public T Value { get; internal set; }

        internal Check(T value)
        {
            Value = value;
        }

        public static implicit operator bool(Check<T> check)
        {
            return check.Result;
        }
    }

    public static class Check
    {
        #region IsNull

        public static Check<T?> IsNull<T>(T? value) where T : struct => new Check<T?>(value).IsNull();

        public static Check<T> IsNull<T>(T value) where T : class => new Check<T>(value).IsNull();

        public static Check<T?> IsNull<T>(this Check<T?> check) where T : struct
        {
            check.Result = check.Value.Equals(null);
            return check;
        }

        public static Check<T> IsNull<T>(this Check<T> check) where T : class
        {
            try
            {
                check.Result = check.Value.Equals(null);
            }
            catch (NullReferenceException ex)
            {
                check.Result = true;
            }
            
            return check;
        }


        #endregion

        #region IsNotNull

        public static Check<T?> IsNotNull<T>(T? value) where T : struct => new Check<T?>(value).IsNotNull();

        public static Check<T> IsNotNull<T>(T value) where T : class => new Check<T>(value).IsNotNull();

        public static Check<T?> IsNotNull<T>(this Check<T?> check) where T : struct
        {
            check.Result = !check.Value.Equals(null);
            return check;
        }

        public static Check<T> IsNotNull<T>(this Check<T> check) where T : class
        {
            try
            {
                check.Result = !check.Value.Equals(null);
            }
            catch (NullReferenceException ex)
            {
                check.Result = false;
            }

            return check;
        }

        #endregion

        #region IsEqual

        public static Check<T?> IsEqual<T>(T? value, T? equality) where T : struct => new Check<T?>(value).IsEqual(equality);

        public static Check<T> IsEqual<T>(T value, T equality) where T : class => new Check<T>(value).IsEqual(equality);

        public static Check<T?> IsEqual<T>(this Check<T?> check, T? equality) where T : struct
        {
            check.Result = check.Value.Equals(equality);
            return check;
        }

        public static Check<T> IsEqual<T>(this Check<T> check, T equality) where T : class
        {
            try
            {
                check.Result = check.Value.Equals(equality);
            }
            catch (NullReferenceException ex)
            {
                if (equality == null)
                    check.Result = true;
                else
                    check.Result = false;
            }

            return check;
        }

        #endregion

        #region IsNotEqual

        public static Check<T?> IsNotEqual<T>(T? value, T? equality) where T : struct => new Check<T?>(value).IsNotEqual(equality);

        public static Check<T> IsNotEqual<T>(T value, T equality) where T : class => new Check<T>(value).IsNotEqual(equality);

        public static Check<T?> IsNotEqual<T>(this Check<T?> check, T? equality) where T : struct
        {
            check.Result = !check.Value.Equals(equality);
            return check;
        }

        public static Check<T> IsNotEqual<T>(this Check<T> check, T equality) where T : class
        {
            try
            {
                check.Result = !check.Value.Equals(equality);
            }
            catch (NullReferenceException ex)
            {
                if (equality == null)
                    check.Result = false;
                else
                    check.Result = true;
            }

            return check;
        }

        #endregion

        #region Condition

        public static Check<T?> MeetsCondition<T>(T? value, Func<T?, bool> condition) where T : struct => new Check<T?>(value).MeetsCondition(condition);

        public static Check<T> MeetsCondition<T>(T value, Func<T, bool> condition) where T : class => new Check<T>(value).MeetsCondition(condition);

        public static Check<T?> MeetsCondition<T>(this Check<T?> check, Func<T?, bool> condition) where T : struct
        {
            check.Result = check.Result = condition(check.Value);
            return check;
        }

        public static Check<T> MeetsCondition<T>(this Check<T> check, Func<T, bool> condition) where T : class
        {
            try
            {
                check.Result = check.Result = condition(check.Value);
            }
            catch (NullReferenceException ex)
            {
                if (condition(null))
                    check.Result = true;
                else
                    check.Result = false;
            }

            return check;
        }

        #endregion
    }
}
