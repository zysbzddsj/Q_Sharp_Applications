using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Quantum.Grover_4items
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var qsim = new QuantumSimulator())
            {
                for(int i=0;i<100;i++)
                {
                    var (r, s1, s2) = GroverTest.Run(qsim).Result;
                    Console.WriteLine($"第{i}次：随机数 {r,-5} Q1状态 {s1,-5} Q2状态 {s2,-5}");
                }
            }
            Console.WriteLine("按任意键继续...");
            Console.ReadKey();
        }
    }
}