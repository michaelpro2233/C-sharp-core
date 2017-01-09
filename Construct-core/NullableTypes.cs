using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    public static class NullableTypes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun With Nullable Data *****\n");
            var dr = new DatabaseReader();

            int myData = dr.GetIntFromDatabase() ?? 100;
            Console.WriteLine("Value of myData: {0}", myData);

            // Get int from "database"
            int? i = dr.GetIntFromDatabase();
            if (i.HasValue)
                Console.WriteLine("Value of 'i' is: {0}", i.Value);
            else
                Console.WriteLine("Value of 'i' is undefined.");

            // Get bool from "database"
            bool? b = dr.GetBoolFromDatabase();
            if (b != null)
                Console.WriteLine("Value of 'b' is: {0}", b.Value);
            else
                Console.WriteLine("Value of 'b' is undefined.");

            LocalNullableVariables();
            Console.WriteLine();

            LocalNullableVariablesUsingNullable();

            Console.ReadLine();
        }

        private static void LocalNullableVariables()
        {
            // Define some local nullable types
            int? nullableInt = 10;
            double? nullableDouble = 3.14;
            bool? nullableBool = nullableDouble > 3 ? (bool?)null : true;
            char? nullableChar = 'a';
            int?[] arrayofNullableInts = new int?[10];

            // Error! Strings are reference types!
            // string? s = "oops";

            Console.WriteLine("{0}{1}{2}{3}", nullableInt.Value, nullableDouble.Value, nullableBool, nullableChar.Value);
        }

        private static void LocalNullableVariablesUsingNullable()
        {
            // Define some local nullable types using Nullable<T>
            Nullable<int> nullableInt = 10;
            Nullable<double> nullableDouble = 3.14;
            Nullable<bool> nullableBool = nullableDouble > 3 ? (bool?)null : true;
            Nullable<Char> nullableChar = 'a';
            Nullable<int>[] arrayOfNullableInts = new int?[10];

            Console.WriteLine("{0}{1}{2}{3}", nullableInt.Value, nullableDouble.Value, nullableBool, nullableChar.Value);
        }
    }
}
