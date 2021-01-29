using System;
using System.Collections.Generic;
using System.Linq;

namespace Graph.Model
{
    class Graph // Граф
    {
        List<Vertex> Vertexes = new List<Vertex>(); // Вершины
        List<Edge> Edges = new List<Edge>(); //Рёбра

        public int VertexCount => Vertexes.Count;
        public int EdgeCount => Edges.Count;

        public void AddVertex(Vertex vertex)
        {
            Vertexes.Add(vertex);
        }
        public void AddEdge(Vertex from, Vertex to)
        {
            Edge edge = new Edge(from, to);
            Edges.Add(edge);
        }

        public int[,] GetMatrix() // матрица смежности
        {
            int[,] matrix = new int[Vertexes.Count, Vertexes.Count];

            foreach(Edge edge in Edges)
            {
                int row = edge.From.Number - 1;
                int column = edge.To.Number - 1;

                matrix[row, column] = edge.Weight;
            }

            return matrix;
        }

        public List<Vertex> GetVertexLists(Vertex vertex) // список смежных вершин
        {
            List<Vertex> result = new List<Vertex>();

            foreach(Edge edge in Edges)
            {
                if(edge.From == vertex)
                {
                    result.Add(edge.To);
                }
            }

            return result;
        }

        public bool Wave(Vertex start, Vertex finish) // список рёбер 
        {
            List<Vertex> result = new List<Vertex>();

            List<Vertex> list = new List<Vertex>();

            list.Add(start);

            for(int i = 0; i < list.Count; i++)
            {
                Vertex vertex = list[i];
                foreach (Vertex v in GetVertexLists(vertex))
                {
                    if(!list.Contains(v)) list.Add(v); 
                }
            }

            return list.Contains(finish);
        }
    }
}
