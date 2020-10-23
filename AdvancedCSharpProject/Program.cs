using System;
using System.Collections.Generic;

namespace AdvancedCSharpProject
{
    class Program
    {
        //Rethrowing Exception
        private void RethrowingExceptions()
        {
            try
            {
                throw new BootcampException("Throw this exception");
                //var ex = new BootcampException ("Throw this exception")
                //throw ex
            }
            catch (BootcampException ex)
            {
                //if we cannot handle the exception
                //just stating throw; cancels catch block
                throw ex;
            }
        }
        //Collection initializer
        //List <int>
        List<int> ints = new List<int> { 1, 2, 3, 4, 5 };

        //dictionary<int, bootcamp>
        Dictionary<string, Bootcamp> bootcamps = new Dictionary<string, Bootcamp>
        {
            ["CSharp"] = new Bootcamp(),
            ["Java"] = new Bootcamp(),
        };
        void AccessDictionary()
        {
            var csharpBc = bootcamps["CSharp"];
        }

        static int i = 10;
        static string a = "ABC";

        //static means you don't have make an instance of the variable or even class. Just call it in STATIC MAIN METHOD
        static void Main(string[] args)
        {


            //out patameter
            var nbrStr = "123";//with a character like "f" it would come back false because f cannot be an integer
            int nbr; //if you put 'var' in front of 'nbr' you have to give it a value
            var ok = int.TryParse(nbrStr, out nbr);

            //Ref Parameter
            Console.WriteLine($"Before increment i is {a}");
            Concat(ref a);
            Console.WriteLine($"Before increment i is {a}");

            static void Concat (ref string s)
            {
                s += "XXX";
            }

            Console.WriteLine($"Before increment i is {i}");
            Add1(ref i);
            Console.WriteLine($"After increment i is {i}");
            //ref gives you the actual value instead of a copy.
            //happens for all types
            static void Add1(ref int i)
            {
                i++;
                //passed by Value = copy of data not the actual data so it didn't change.
            }
        }
    }
}
