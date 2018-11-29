using System;
using System.Collections.Generic;
using Graphs.Classes;

namespace GetEdge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// Returns if a single trip itenerary is possible.
        /// </summary>
        /// <param name="graph">Graph of cities</param>
        /// <param name="cities">Array of cities</param>
        /// <returns>If possible, return a List of true and total price. If not possible, return false and 0.</returns>
        public static List<object> GetEdge(Graph graph, Vertex[] cities)
        {
            int totalPrice = 0;
            List<Vertex> hi = graph.GetNeighbors(new Vertex(cities[0]));
            for (int i = 0; i < cities.Length - 1; i++)
            {
                if (!graph.GetNeighbors(cities[i]).Contains(cities[i + 1]))
                {
                    return new List<object> { false, 0 };
                }
                int tempPrice = (int)graph.WeightList[(cities[i], cities[i + 1])];
                totalPrice += tempPrice;
            }

            return new List<object> { true, totalPrice };
        }
    }
}
