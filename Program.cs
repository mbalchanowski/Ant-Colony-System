using System;
using System.Collections.Generic;

namespace AntColonySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Point> points = TspFileReader.ReadTspFile(@"TSP\kroA100.tsp");    // Parse TSPlib file and load as List<Point>

            Graph graph = new Graph(points, true);  // Create Graph
            GreedyAlgorithm greedyAlgorithm = new GreedyAlgorithm(graph);
            double greedyShortestTourDistance = greedyAlgorithm.Run();  // get shortest tour using greedy algorithm

            Parameters parameters = new Parameters()  // Most parameters will be default. We only have to set T0 (initial pheromone level)
            {
                T0 = (1.0 / (graph.Dimensions * greedyShortestTourDistance))
            };
            parameters.Show();

            Solver solver = new Solver(parameters, graph);
            List<double> results = solver.RunACS(); // Run ACS

            Console.WriteLine("Time: " + solver.GetExecutionTime());
            Console.ReadLine();
        }
    }
}
