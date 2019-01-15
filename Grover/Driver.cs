using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Quantum.Grover
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var qsim = new QuantumSimulator())
            {
                int n = 8;
                int TestTime = 100;
                int tot = 0;
                for(int i=0;i<TestTime;i++)
                {
                    var (r, p, s) = GroverTest.Run(qsim,n).Result;
                    if(r==p)
                    {
                        tot++;
                    }
                    Console.Write($"第{i}次：随机数 {r,-7}");
                    Console.Write($" 测量结果 {p,-7}");
                    //for (int j = 0; j < n; j++)
                    //{
                    //    Console.Write($"Q[{j}]状态 {s[j],-5}");
                    //}
                    Console.WriteLine();
                }
                Console.WriteLine($"正确率为{tot}/{TestTime}"); 
            }
            Console.ReadKey();
        }
    }
}