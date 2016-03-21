// The source is licensed to the .NET Foundation under the MIT license:
// https://github.com/dotnet/corefx/blob/master/src/System.Runtime.Extensions/tests/System/Convert.TestBase.cs
// https://github.com/dotnet/corefx/blob/master/LICENSE


using System;
using Bridge.Test;

namespace Bridge.ClientTest.ConvertTests
{
    class ConvertConstants
    {
        public const string UINT64_MAX_STRING_BASE_16 = "ffffffffffffffff";
        public const string UINT64_MAX_STRING_BASE_8 = "1777777777777777777777";
        public const string UINT64_MAX_STRING_BASE_2 = "1111111111111111111111111111111111111111111111111111111111111111";
        public const string UINT64_OVERFLOW_MAX_STRING = "18446744073709551616";
        public const string UINT64_OVERFLOW_MAX_STRING_BASE_16 = "10000000000000000";
        public const string UINT64_OVERFLOW_MAX_STRING_BASE_8 = "7777777777777777777777777";
        public const string UINT64_OVERFLOW_MAX_STRING_BASE_2 = "11111111111111111111111111111111111111111111111111111111111111111";
        public const string UINT64_OVERFLOW_MIN_STRING = "-1";

        public const string INT64_MAX_STRING_BASE_16 = "7fffffffffffffff";
        public const string INT64_MAX_STRING_BASE_8 = "777777777777777777777";
        public const string INT64_MAX_STRING_BASE_2 = "111111111111111111111111111111111111111111111111111111111111111";
        public const string INT64_MIN_STRING_BASE_16 = "8000000000000000";
        public const string INT64_MIN_STRING_BASE_8 = "1000000000000000000000";
        public const string INT64_MIN_STRING_BASE_2 = "1000000000000000000000000000000000000000000000000000000000000000";
        public const string INT64_OVERFLOW_MAX_STRING = "9223372036854775808";
        public const string INT64_OVERFLOW_MIN_STRING = "-9223372036854775809";

        public const string UINT32_MAX_STRING_BASE_16 = "ffffffff";
        public const string UINT32_MAX_STRING_BASE_8 = "37777777777";
        public const string UINT32_MAX_STRING_BASE_2 = "11111111111111111111111111111111";
        public const string UINT32_OVERFLOW_MAX_STRING = "4294967296";
        public const string UINT32_OVERFLOW_MAX_STRING_BASE_16 = "100000000";
        public const string UINT32_OVERFLOW_MAX_STRING_BASE_8 = "77777777777";
        public const string UINT32_OVERFLOW_MAX_STRING_BASE_2 = "111111111111111111111111111111111";
        public const string UINT32_OVERFLOW_MIN_STRING = "-1";

        public const string INT32_MAX_STRING_BASE_16 = "7fffffff";
        public const string INT32_MAX_STRING_BASE_8 = "17777777777";
        public const string INT32_MAX_STRING_BASE_2 = "1111111111111111111111111111111";
        public const string INT32_MIN_STRING_BASE_16 = "80000000";
        public const string INT32_MIN_STRING_BASE_8 = "20000000000";
        public const string INT32_MIN_STRING_BASE_2 = "10000000000000000000000000000000";
        public const string INT32_OVERFLOW_MAX_STRING = "2147483648";
        public const string INT32_OVERFLOW_MAX_STRING_BASE_16 = "1ffffffff";
        public const string INT32_OVERFLOW_MAX_STRING_BASE_8 = "777777777777";
        public const string INT32_OVERFLOW_MAX_STRING_BASE_2 = "111111111111111111111111111111111";
        public const string INT32_OVERFLOW_MIN_STRING = "-2147483649";

        public const string UINT16_MAX_STRING_BASE_16 = "ffff";
        public const string UINT16_MAX_STRING_BASE_8 = "177777";
        public const string UINT16_MAX_STRING_BASE_2 = "1111111111111111";
        public const string UINT16_OVERFLOW_MAX_STRING = "65536";
        public const string UINT16_OVERFLOW_MAX_STRING_BASE_16 = "10000";
        public const string UINT16_OVERFLOW_MAX_STRING_BASE_8 = "777777";
        public const string UINT16_OVERFLOW_MAX_STRING_BASE_2 = "11111111111111111";
        public const string UINT16_OVERFLOW_MIN_STRING = "-1";

        public const string INT16_MAX_STRING_BASE_16 = "7fff";
        public const string INT16_MAX_STRING_BASE_8 = "77777";
        public const string INT16_MAX_STRING_BASE_2 = "111111111111111";
        public const string INT16_MIN_STRING_BASE_16 = "8000";
        public const string INT16_MIN_STRING_BASE_8 = "100000";
        public const string INT16_MIN_STRING_BASE_2 = "1000000000000000";
        public const string INT16_OVERFLOW_MAX_STRING = "32768";
        public const string INT16_OVERFLOW_MAX_STRING_BASE_16 = "1ffff";
        public const string INT16_OVERFLOW_MAX_STRING_BASE_8 = "777777";
        public const string INT16_OVERFLOW_MAX_STRING_BASE_2 = "11111111111111111";
        public const string INT16_OVERFLOW_MIN_STRING = "-32769";

        public const string UINT8_MAX_STRING_BASE_16 = "ff";
        public const string UINT8_MAX_STRING_BASE_8 = "377";
        public const string UINT8_MAX_STRING_BASE_2 = "11111111";
        public const string UINT8_OVERFLOW_MAX_STRING = "256";
        public const string UINT8_OVERFLOW_MIN_STRING = "-1";

        public const string INT8_MAX_STRING_BASE_16 = "7f";
        public const string INT8_MAX_STRING_BASE_8 = "177";
        public const string INT8_MAX_STRING_BASE_2 = "1111111";
        public const string INT8_MIN_STRING_BASE_16 = "80";
        public const string INT8_MIN_STRING_BASE_8 = "200";
        public const string INT8_MIN_STRING_BASE_2 = "10000000";
        public const string INT8_OVERFLOW_MAX_STRING = "128";
        public const string INT8_OVERFLOW_MAX_STRING_BASE_16 = "1ff";
        public const string INT8_OVERFLOW_MAX_STRING_BASE_8 = "777";
        public const string INT8_OVERFLOW_MAX_STRING_BASE_2 = "111111111";
        public const string INT8_OVERFLOW_MIN_STRING = "-129";

        public const string DECIMAL_MAX_STRING = "79228162514264337593543950335";
        public const string DECIMAL_MIN_STRING = "-79228162514264337593543950335";

        public const string DOUBLE_MAX_STRING = "1.7976931348623157e+308";
        public const string DOUBLE_MIN_STRING = "-1.7976931348623157e+308";
        public const string DOUBLE_EPSILON_STRING = "5e-324";

        public const string SINGLE_MAX_STRING = "3.40282347e+38";
        public const string SINGLE_MIN_STRING = "-3.40282347e+38";
        public const string SINGLE_EPSILON_STRING = "1.401298e-45";
    }

    public abstract class ConvertTestBase<TOutput>
    {
        /// <summary>
        /// Verify that the provided convert delegate produces expectedValues given testValues.
        /// </summary>
        protected void Verify<TInput>(Func<TInput, TOutput> convert, TInput[] testValues, TOutput[] expectedValues, bool useTrue = false)
        {
            if (expectedValues == null || testValues == null || expectedValues.Length != testValues.Length)
            {
                Assert.Fail("Test data should have the same lenght");
                return;
            }

            for (int i = 0; i < testValues.Length; i++)
            {
                TOutput result = convert(testValues[i]);
                if (useTrue)
                {
                    Assert.True(expectedValues[i].Equals(result));
                }
                else
                {
                    Assert.AreEqual(expectedValues[i], result);
                }
            }
        }

        /// <summary>
        /// Verify that the provided convert delegate produces expectedValues given testValues.
        /// The overloading should be used to test methods accepting objects.
        /// </summary>
        protected void VerifyViaObj<TInput>(Func<object, TOutput> convert, TInput[] testValues, TOutput[] expectedValues)
        {
            if (expectedValues == null || testValues == null || expectedValues.Length != testValues.Length)
            {
                Assert.Fail("Test data should have the same lenght");
                return;
            }

            for (int i = 0; i < testValues.Length; i++)
            {
                TOutput result = convert(testValues[i]);
                Assert.AreEqual(expectedValues[i], result);
            }
        }

        /// <summary>
        /// Verify that the provided convert delegates produce expectedValues given testValues
        /// </summary>
        protected void VerifyFromString(Func<string, TOutput> convert, Func<string, IFormatProvider, TOutput> convertWithFormatProvider, string[] testValues, TOutput[] expectedValues, bool useTrue = false)
        {
            Verify(convert, testValues, expectedValues, useTrue);
            Verify(input => convertWithFormatProvider(input, TestFormatProvider.s_instance), testValues, expectedValues, useTrue);
        }

        /// <summary>
        /// Verify that the provided convert delegates produce expectedValues given testValues
        /// </summary>
        protected void VerifyFromObject(Func<object, TOutput> convert, Func<object, IFormatProvider, TOutput> convertWithFormatProvider, object[] testValues, TOutput[] expectedValues)
        {
            Verify(convert, testValues, expectedValues);
            Verify(input => convertWithFormatProvider(input, TestFormatProvider.s_instance), testValues, expectedValues);
        }

        /// <summary>
        /// Verify that the provided convert delegate produces expectedValues given testValues and testBases
        /// </summary>
        protected void VerifyFromStringWithBase(Func<string, int, TOutput> convert, string[] testValues, int[] testBases, TOutput[] expectedValues, bool useTrue = false)
        {
            if (expectedValues == null || testBases == null || testValues == null
                || expectedValues.Length != testValues.Length
                || testBases.Length != testValues.Length)
            {
                Assert.Fail("Test data should have the same lenghts");
                return;
            }

            for (int i = 0; i < testValues.Length; i++)
            {
                var testValue = testValues[i];
                var radix = testBases[i];

                TOutput result = convert(testValue, radix);

                var expected = expectedValues[i];

                if (useTrue)
                {
                    Assert.True(expected.Equals(result), "Test: " + testValue + " Radix: " + radix + " Expected: " + expected.ToString() + " Result: " + result.ToString());
                }
                else
                {
                    Assert.AreEqual(expected, result);
                }
            }
        }

        /// <summary>
        /// Verify that the provided convert delegate throws an exception of type TException given testValues and testBases
        /// </summary>
        protected void VerifyFromStringWithBaseThrows<TException>(Func<string, int, TOutput> convert, string[] testValues, int[] testBases)
            where TException : Exception
        {
            if (testBases == null || testValues == null || testBases.Length != testValues.Length)
            {
                Assert.Fail("Test data should have the same lenght");
                return;
            }

            for (int i = 0; i < testValues.Length; i++)
            {
                try
                {
                    Assert.Throws(() => convert(testValues[i], testBases[i]), err => err.GetClassName() == typeof(TException).GetClassName(), "Value " + testValues[i] + " base " + testBases[i]);
                }
                catch (Exception e)
                {
                    string message = string.Format("Expected {0} converting '{1}' (base {2}) to '{3}'", typeof(TException).GetClassName(), testValues[i], testBases[i], typeof(TOutput).GetClassName());
                    throw new AggregateException(message, e);
                }
            }
        }

        /// <summary>
        /// Verify that the provided convert delegate throws an exception of type TException given testValues
        /// </summary>
        protected void VerifyThrows<TException, TInput>(Func<TInput, TOutput> convert, TInput[] testValues) 
            where TException : Exception
        {
            for (int i = 0; i < testValues.Length; i++)
            {
                try
                {
                    Assert.Throws(() => convert(testValues[i]), err => err.GetClassName() == typeof(TException).GetClassName(), "Value " + testValues[i]);
                }
                catch (Exception e)
                {
                    string message = string.Format("Expected {0} converting '{1}' ({2}) to {3}", typeof(TException).GetClassName(), testValues[i], typeof(TInput).GetClassName(), typeof(TOutput).GetClassName());
                    throw new AggregateException(message, e);
                }
            }
        }

        /// <summary>
        /// Verify that the provided convert delegate throws an exception of type TException given testValues
        /// The overloading should be used to test methods accepting objects.
        /// </summary>
        protected void VerifyThrowsViaObj<TException, TInput>(Func<object, TOutput> convert, TInput[] testValues) 
            where TException : Exception
        {
            for (int i = 0; i < testValues.Length; i++)
            {
                try
                {
                    Assert.Throws(() => convert(testValues[i]), err => err.GetClassName() == typeof(TException).GetClassName(), "Value " + testValues[i]);
                }
                catch (Exception e)
                {
                    string message = string.Format("Expected {0} converting '{1}' ({2}) to {3}", typeof(TException).GetClassName(), testValues[i], typeof(TInput).GetClassName(), typeof(TOutput).GetClassName());
                    throw new AggregateException(message, e);
                }
            }
        }

        /// <summary>
        /// Verify that the provided convert delegates throws an exception of type TException given testValues
        /// </summary>
        protected void VerifyFromStringThrows<TException>(Func<string, TOutput> convert, Func<string, IFormatProvider, TOutput> convertWithFormatProvider, string[] testValues) 
            where TException : Exception
        {
            VerifyThrows<TException, string>(convert, testValues);
            VerifyThrows<TException, string>(input => convertWithFormatProvider(input, TestFormatProvider.s_instance), testValues);
        }

        /// <summary>
        /// Verify that the provided convert delegates throw exception of type TException given testValues
        /// </summary>
        protected void VerifyFromObjectThrows<TException>(Func<object, TOutput> convert, Func<object, IFormatProvider, TOutput> convertWithFormatProvider, object[] testValues)
            where TException : Exception
        {
            VerifyThrows<TException, object>(convert, testValues);
            VerifyThrows<TException, object>(input => convertWithFormatProvider(input, TestFormatProvider.s_instance), testValues);
        }

        /// <summary>
        /// Helper class to test that the IFormatProvider is being called.
        /// </summary>
        protected class TestFormatProvider : IFormatProvider
        {
            public static readonly TestFormatProvider s_instance = new TestFormatProvider();

            private TestFormatProvider()
            {
            }

            public object GetFormat(Type formatType)
            {
                return this;
            }

            public string Format(string format, object arg, IFormatProvider formatProvider)
            {
                return arg.ToString();
            }

            public string GetAllDateTimePatterns(string format, bool returnNull)
            {
                return "G";
            }
        }
    }
}