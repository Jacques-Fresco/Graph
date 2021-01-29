using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            Model.Graph graph = new Model.Graph();

            Model.Vertex v1 = new Model.Vertex(1);
            Model.Vertex v2 = new Model.Vertex(2);
            Model.Vertex v3 = new Model.Vertex(3);
            Model.Vertex v4 = new Model.Vertex(4);
            Model.Vertex v5 = new Model.Vertex(5);
            Model.Vertex v6 = new Model.Vertex(6);
            Model.Vertex v7 = new Model.Vertex(7);


            graph.AddVertex(v1);
            graph.AddVertex(v2);
            graph.AddVertex(v3);
            graph.AddVertex(v4);
            graph.AddVertex(v5);
            graph.AddVertex(v6);
            graph.AddVertex(v7);

            graph.AddEdge(v1, v2);
            graph.AddEdge(v1, v3);
            graph.AddEdge(v3, v4);
            graph.AddEdge(v2, v5);
            graph.AddEdge(v2, v6);
            graph.AddEdge(v6, v5);
            graph.AddEdge(v5, v6);

            GetMatrix(graph);

            Console.WriteLine();
            Console.WriteLine();

            GetVertex(graph, v1);
            GetVertex(graph, v2);
            GetVertex(graph, v3);
            GetVertex(graph, v4);
            GetVertex(graph, v5);
            GetVertex(graph, v6);
            GetVertex(graph, v7);

            Console.WriteLine(graph.Wave(v1, v5));
            Console.WriteLine(graph.Wave(v2, v4));


            Console.ReadLine();
        }

        private static void GetVertex(Model.Graph graph, Model.Vertex vertex)
        {
            Console.Write(vertex.Number + ": ");
            foreach (Model.Vertex v in graph.GetVertexLists(vertex))
            {
                Console.Write(v.Number + ", ");
            }
            Console.WriteLine();
        }

        private static void GetMatrix(Model.Graph graph)
        {
            int[,] matrix = graph.GetMatrix();
            for (int i = 0; i < graph.VertexCount; i++)
            {
                Console.Write(i + 1);
                for (int j = 0; j < graph.VertexCount; j++)
                {
                    Console.Write(" | " + matrix[i, j] + " | ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("________________________________________________");
            Console.WriteLine(" ");
            for (int i = 0; i < graph.VertexCount; i++)
            {
                Console.Write($" | {i + 1} | ");
            }
        }
    }
}
