using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Quantum.QSharpApplication1
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var sim = new QuantumSimulator())
            {
                for (int i = 0; i < 100; i++)
                {
                    var (s1, s2) = BellTest.Run(sim).Result;
                    Console.WriteLine($"第{i}次：Q1状态 {s1,-5} Q2状态 {s2,-5}");
                }
            }

            Console.WriteLine("按任意键继续...");
            Console.ReadKey();
        }
    }
}