using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaAnalistaDevJúnior
{
    class Program
    {
        public static int SymbolicToOctal(string permString)
        {
            permString = permString.ToLower();
            char[] array = permString.ToCharArray();
            string result = string.Empty;
            int sum = 0;
            for (int i = 0; i < array.Length;)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (array[i] == 'r') sum = sum + 4;
                    if (array[i] == 'w') sum = sum + 2;
                    if (array[i] == 'x') sum = sum + 1;
                    if (array[i] == '-') sum = sum + 0;
                    i++;
                }
                result = String.Concat(result, sum);
                sum = 0;
            }
            sum = int.Parse(result);
            sum = Convert.ToInt32(result);
            return sum;
        }

            static void Main(string[] args)
        {
            string str = "rwxr-x-w-";
            Console.WriteLine(Program.SymbolicToOctal(str));
        }
    }
}
