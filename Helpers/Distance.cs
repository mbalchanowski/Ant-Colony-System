using System;

namespace AntColonySystem
{
    public static class Distance
    {
        public static double Euclidean(double X1, double Y1, double X2, double Y2)
        {
            return Math.Sqrt((Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2)));
        }
    }
}
