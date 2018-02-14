using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangles
{
    class Program
    {
        static void Main(string[] args)
        {
            //answer variable
            int answer = 0;
            //answer counter
            int answerCount = 0;
            //counter variable
            int counter = 0;
            //4th position answer
            string fourth = "";

            try
            {

                //enumeration counters
                for (int iCount = 0; iCount < 4; iCount++)
                {
                    for (int t1 = 0; t1 < 10; t1++)
                    {
                        for (int t2 = 0; t2 < 10; t2++)
                        {
                            for (int t3 = 0; t3 < 10; t3++)
                            {
                                if ((((t1 == 3) & (t2 == 4)) & (t3 == 7)) | (((t1 == 4) & (t2 == 3)) & (t3 == 7)))
                                {
                                    answerCount++;
                                    fourth = "fourth position ==>";
                                    Console.WriteLine("****************************************");
                                    Console.WriteLine(fourth);
                                    Console.WriteLine("****************************************");
                                }
                                counter++;
                                answer = (t1 * t2) - t3;
                                Console.WriteLine("Count: {3} - t1:{0}, t2:{1}, t3:{2} ==> {0}*{1}-{2} = {4}", t1, t2, t3, counter, answer);
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }

            Console.WriteLine("{0} permutations. {1} answers.", counter, answerCount);
            Console.ReadLine();
        }
    }
}
