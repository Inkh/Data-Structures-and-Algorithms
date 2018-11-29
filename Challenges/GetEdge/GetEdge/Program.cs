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
            Vertex newYork = new Vertex("New York");
            Vertex taipei = new Vertex("Taipei");
            Vertex shanghai = new Vertex("Shanghai");
            Vertex westLafayette = new Vertex("West Lafayette");
            Vertex sanJose = new Vertex("San Jose");
            Vertex seattle = new Vertex("Seattle");

            Graph cityGraph = new Graph();
            Vertex[] cities = { newYork, taipei, shanghai, westLafayette, sanJose, seattle };

            cityGraph.AddVertex(newYork);
            cityGraph.AddVertex(taipei);
            cityGraph.AddVertex(shanghai);
            cityGraph.AddVertex(westLafayette);
            cityGraph.AddVertex(sanJose);
            cityGraph.AddVertex(seattle);

            cityGraph.AddUndirectedEdge(newYork, taipei, 1680);
            cityGraph.AddUndirectedEdge(taipei, shanghai, 250);
            cityGraph.AddUndirectedEdge(shanghai, westLafayette, 2200);
            cityGraph.AddUndirectedEdge(westLafayette, sanJose, 560);
            cityGraph.AddUndirectedEdge(sanJose, seattle, 180);
            cityGraph.AddUndirectedEdge(taipei, westLafayette, 1900);

            List<object> ans = GetEdge(cityGraph, new Vertex[] { taipei, shanghai, sanJose });

            foreach (var item in ans)
            {
                Console.WriteLine(item);
            }
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
