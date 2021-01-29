using System;

namespace Graph.Model
{
    class Edge // Ребро
    {
        public Vertex From { get; set; }
        public Vertex To { get; set; }
        public int Weight { get; set; }
        public Edge(Vertex from, Vertex to, int weight = 1)
        {
            // должны быть проверки
            From = from;
            To = to;
            Weight = weight;
        }
        public override string ToString()
        {
            return $"({From}; {To})";
        }
    }
}
