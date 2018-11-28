﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    class Graph
    {
        public Dictionary<Vertex, List<Vertex>> AdjacencyList { get; set; }
        public Dictionary<Tuple<Vertex, Vertex>, int> WeightList { get; set; }

        //Constructor
        public Graph()
        {
            AdjacencyList = new Dictionary<Vertex, List<Vertex>>();
            WeightList = new Dictionary<Tuple<Vertex, Vertex>, int>();
        }

        /// <summary>
        /// Adds a vertex to the graph with no connections
        /// </summary>
        /// <param name="vertex">Vertex/Node</param>
        public void AddVertex(Vertex vertex)
        {
            AdjacencyList.Add(vertex, new List<Vertex>());
        }

        /// <summary>
        /// Adds edge to two vertices
        /// </summary>
        /// <param name="vertexOne">First vertex</param>
        /// <param name="vertexTwo">Second vertex</param>
        /// <param name="weight">Weight of the edge</param>
        public void AddEdge(Vertex vertexOne, Vertex vertexTwo, int weight)
        {
            WeightList.Add(new Tuple<Vertex, Vertex>(vertexOne, vertexTwo), weight);
            AdjacencyList[vertexOne].Add(vertexTwo);
        }

        /// <summary>
        /// Grabs all the 'keys' or Vertices and returns them in a list
        /// </summary>
        /// <returns>List of Vertices</returns>
        public List<Vertex> GetVertices()
        {
            return new List<Vertex>(AdjacencyList.Keys);
        }

        /// <summary>
        /// Gets all the vertices connected to given vertex
        /// </summary>
        /// <param name="vertex">Vertex to be checked</param>
        /// <returns>List of connected/neighboring vertices</returns>
        public List<Vertex> GetNeighbors(Vertex vertex)
        {
            return AdjacencyList.GetValueOrDefault(vertex);
        }

        /// <summary>
        /// Gets the amount of vertices in the graph
        /// </summary>
        /// <returns>Number of vertices</returns>
        public int Size()
        {
            return AdjacencyList.Count;
        }
    }
}