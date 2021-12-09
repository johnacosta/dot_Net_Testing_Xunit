using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Tests
{
    public class InternalHealthDamageTestData
    {
        //private static readonly List<object[]> Data = new List<object[]>
        //{
        //    new object[] { 0, 100 },
        //    new object[] { 1, 99 },
        //    new object[] { 50, 50 },
        //    new object[] { 101, 1 }
        //};

        // use yield return to get rid of intermediary List of type object array
        //public static IEnumerable<object[]> TestData => Data;

        public static IEnumerable<object[]> TestData
        {
            get
            {
                yield return new object[] { 0, 100 };
                yield return new object[] { 1, 99 };
                yield return new object[] { 50, 50 };
                yield return new object[] { 101, 1 };
            }
        }
    }
}
