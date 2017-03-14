using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 0; i < 10000000; i++)
            {
                if (i%2 == 1)
                {
                    if (i%3 == 0)
                    {
                        if (i % 4 == 1)
                        {
                            if (i % 5 == 4)
                            {
                                if (i % 6 == 3)
                                {
                                    if (i % 7 == 0)
                                    {
                                        if (i % 8 == 1)
                                        {
                                            if (i % 9 == 0)
                                            {
                                                Console.Write(i+"-");
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.Read();
        }
    }
}
