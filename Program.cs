using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static string CreatePhoneNumber(int[] numbers)
        {
            string fristPart = "("+ numbers[0]+ numbers[1]+ numbers[2] + ") ",
                secondPart = ""+ numbers[3]+ numbers[4]+ numbers[5] + "-" + numbers[6] + numbers[7]+ numbers[8] + numbers[9];

            return fristPart + secondPart;

            //OR

            //return long.Parse(string.Concat(numbers)).ToString("(000) 000-0000");
        }
        public static int find_it(int[] seq)
        {
            int result = 0;

            for (int i = 0; i < seq.Length; i++)
            {
                int contador = 0;

                for (int j = 0; j < seq.Length; j++)
                {
                    
                    if (seq[i] == seq[j])
                    {
                        contador++;
                    }
                }

                if (contador % 2 != 0) // Es impar
                {
                    result = seq[i];
                }
            }

            return result;

            // OR

            // return seq.GroupBy(x => x).Single(g => g.Count() % 2 == 1).Key;

            // return seq.First(x => seq.Count(s => s == x) % 2 == 1)
        }

        //Given two integers a and b, which can be positive or negative,
        //find the sum of all the integers between and including them and
        //return it.If the two numbers are equal return a or b.

        public int GetSum(int a, int b)
        {
            if (a == b) return a;
            int sum = 0;

            if (a > b)
            {
                int aux = a;
                a = b;
                b = aux;
            }

            for (int i = a; i <= b; i++)
            {
                sum += i;
            }

            return sum;
        }

        //return "abcdefghijklmnopqrstuvwxyz".All(x => str.ToLower().Contains(char.ToLower(x)));

        public static bool IsPangram(string str)
        {
            string alphabet = "";

            for (int i = 97; i <= 122; i++)
            {
                alphabet += (char)i;
            }

            str = str.ToLower();

            return alphabet.All(x => str.Contains(x));
        }

        // Implement the function unique_in_order which takes as argument a sequence and returns a list of items without any 
        // elements with the same value next to each other and preserving the original order of elements.

        // For example:
        //uniqueInOrder("AAAABBBCCDAABBB") == {'A', 'B', 'C', 'D'}

        public static IEnumerable<T> UniqueInOrder<T>( IEnumerable<T> iterable ) 
        {
            var listaAuxiliar = new List<T>();  
            foreach (var item in iterable)
            {
                if ( !listaAuxiliar.Contains( item ) ){
                  listaAuxiliar.Add( item );
                }
                
            } 
            return listaAuxiliar;
        }

        // This time no story, no theory. The examples below show you how to write function accum:

        // Examples:
        // accum("abcd") -> "A-Bb-Ccc-Dddd"
        // accum("RqaEzty") -> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
        // accum("cwAt") -> "C-Ww-Aaa-Tttt"

        public static String Accum(string s) 
        {
            return string.Join("-",s.Select((x,i)=>char.ToUpper(x)+new string(char.ToLower(x),i)));

            // .Join ( Une cada parte con el primer parametro, en este caso con "-" ) 
            // .Select (  )
        }


        static void Main(string[] args)
        {
            string nombre = "Hola me llamo lucas";
            bool condition1, condition2;

            // string , int , char , bool ....  entre otras

            Console.WriteLine("Hola" + nombre);

            condition1 = false;
            condition2 = true;

            if (!condition1 && condition2)
            {
                Console.WriteLine("entro");
            }

            //for (int i = 0; i < 41 ; i++)
            //{
            //    if ( i % 15 == 0 )
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            int[] miArrayDeNumeros = { 7, 89, 5 * 5, 4 , 5 , 9, 7 , 8 , 9 , 41};


            foreach (int i in miArrayDeNumeros)
            {
                Console.Write(i + "\n");
            }

            // Create a StringBuilder that expects to hold 50 characters.
            // Initialize the StringBuilder with "ABC".
            StringBuilder sb = new StringBuilder("ABC", 4);

            sb.Append("Concatenar");

            Console.Write( sb.ToString() + "\n" + CreatePhoneNumber(miArrayDeNumeros) + "\n");

            string str = "7864646475767";
            long res = long.Parse(str);
            Console.WriteLine(res);

            Console.WriteLine( find_it( new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }));

            Console.WriteLine(miArrayDeNumeros.First(x => x % 5 == 0 ));

            //(char)97 => a
            //(char)97 + 27 => z ? No, + 25 => (char)122 => z

            Console.WriteLine(IsPangram("The quick brown fox jumps over the lazy dog."));

            Console.WriteLine( 
                Accum("hola") + " ");    

            Console.ReadKey();
        }

    }
}
