using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace study1025
{
    internal class Proram
    {
        static void Main(string[] args)
        {
            Test test = new Test();

            Console.Write("수행할 잡억을 입력하세요");
            string read = Console.ReadLine();

            Console.Write("a 입력 : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b 입력 : ");
            int b = int.Parse(Console.ReadLine());
            if (read == "+")
            {
                Console.WriteLine("a + b : " + test.add(a, b));
            }
            if (read == "-")
            {
                Console.WriteLine("a - b : " + test.minus(a, b));
            }                                   
            if (read == "*")
            {
                Console.WriteLine("a * b : " + test.multi(a, b));
            }
            if (read == "/")
            {
                Console.WriteLine("a / b : " + test.div(a, b));
            }

            Console.Read();
        }

    }
}