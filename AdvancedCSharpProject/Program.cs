using System;

namespace AdvancedCSharpProject
{
    class Program
    {
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
