using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphSearch
{
   
        public class Program
        {
            public static void Main(string[] args)
            {
            var vertices = new[] { 1, 12, 19, 21, 7, 31, 14};
            var edges = new[]{
                            Tuple.Create(1,12), Tuple.Create(1,21), Tuple.Create(1,7),
                            Tuple.Create(12,19),
                            Tuple.Create(7,21),
                            Tuple.Create(19,1), Tuple.Create(19,21),
                            Tuple.Create(21,14), Tuple.Create(21,31),
                            Tuple.Create(14,14)};

            var graph = new Graph<int>(vertices, edges);
                var algorithms = new Algorithms();

            var startVertex = 1;
                var shortestPath = algorithms.ShortestPathFunction(graph, startVertex);
                foreach (var vertex in vertices)
                    Console.WriteLine("Shortest Path to {0,2}: {1}",
                            vertex, string.Join(", ", shortestPath(vertex)));

            Console.ReadKey();
            }
        }
    }
    
