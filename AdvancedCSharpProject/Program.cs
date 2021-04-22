using System;
using System.Collections.Generic;

namespace AdvancedCSharpProject
{
    class Program
    {

        Mathematics<double> coll = new Mathematics<double>();

        private void TestCollection()
        {
            coll.Add(1.5);
            coll.Add(7.3);
            coll.Add(5.6);
        }



        //Lambda in Methods
        //private int Add (int a, int b)
        //{
        //    return a + b; 
        //}
        private int Add(int a, int b) => a + b; 

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
            ["Angular"] = new Bootcamp(),
        };
        void AccessDictionary()
        {
            var csharpBc = bootcamps["CSharp"];
        }

        static int i = 12;
        static string a = "ABC";

        //static means you don't have make an instance of the variable or even class. Just call it in STATIC MAIN METHOD
        static void Main(string[] args)
        {
            //switch STATEMENT
            //switch jumps straight to answer where if and else statements would take average 25 to go through to find the one
            var stateCode = "KY";
            var stateName = "";
            switch (stateCode)
            {
                case "OH": stateName = "Ohio"; break; //break says the case is done and no other value can be it
                case "KY": stateName = "Kentucky"; break;
                case "IN": stateName = "Indiana"; break;
                default: stateName = "I Don't Know"; break;
            }
            //switch EXPRESSION
            stateName = stateCode switch
            {
                "OH" => "Ohio", 
                "KY" => "Kentucky", 
                "IN" => "Indiana",
                _ => "I don't know" //the "_" is for anything else/ the default
            };

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
