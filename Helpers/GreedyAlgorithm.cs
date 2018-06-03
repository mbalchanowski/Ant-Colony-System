using System;
using System.Collections.Generic;
using System.Linq;

namespace AntColonySystem
{
    /// <summary>
    /// This class represents simple greedy algorithm for finding shorters tour in TSP. It always choose shortest distance beetwen two points.
    /// </summary>
    public class GreedyAlgorithm
    {
        #region Properties
        private Graph Graph { get; set; }
        private double TourDistance { get; set; }
        private List<Point> VisitedNodes { get; set; }
        private List<Point> UnvisitedNodes { get; set; }
        private List<Edge> Path { get; set; }
        #endregion

        public GreedyAlgorithm(Graph graph)
        {
            Graph = graph;
            TourDistance = 0;
            UnvisitedNodes = graph.Points.ToList();
            VisitedNodes = new List<Point>();
            Path = new List<Edge>();
        }

        public double Run()
        {
            Point toPoint, fromPoint;
            SetStartingPoint();

            for (int i = 0; i < Graph.Dimensions; i++)
            {
                fromPoint = GetCurrentNode();

                if (UnvisitedNodes.Count > 0)   // if we have nodes to visit;
                {
                    toPoint = ChooseNextPoint(fromPoint);
                    VisitedNodes.Add(toPoint);
                    UnvisitedNodes.Remove(toPoint);
                }
                else
                {
                    toPoint = VisitedNodes[0]; // if visited every node, just go back to start
                }

                Edge edge = Graph.GetEdge(fromPoint.Id, toPoint.Id);
                Path.Add(edge);
                TourDistance += edge.Length;
            }

            return Math.Round(TourDistance);
        }

        private Point ChooseNextPoint(Point startPoint)
        {
            List<Edge> edges = new List<Edge>();

            foreach (Point endPoint in UnvisitedNodes)
            {
                Edge edge = Graph.GetEdge(startPoint.Id, endPoint.Id);
                edges.Add(edge);
            }

            Edge shortestEdge = edges.OrderBy(x => x.Length).FirstOrDefault(); // choosing shortest edge
            return shortestEdge.End;
        }

        private Point GetCurrentNode()
        {
            return VisitedNodes[VisitedNodes.Count - 1];
        }
        
        private void SetStartingPoint()
        {
            Point startPoint = Graph.Points.First(); // We can set any point as starting point. I choosed first one.
            VisitedNodes.Add(startPoint);
            UnvisitedNodes.Remove(startPoint);
        }
    }
}
