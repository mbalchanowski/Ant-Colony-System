using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace AntColonySystem
{
    public static class TspFileReader
    {
        public static List<Point> ReadTspFile(string tspFilePath)
        {
            var file = File.ReadLines(tspFilePath);
            List<Point> points = new List<Point>();

            CultureInfo ci = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            ci.NumberFormat.CurrencyDecimalSeparator = ".";
            bool readData = false;
            foreach (var item in file)
            {
                if (item.Contains("NODE_COORD_SECTION"))
                {
                    readData = true;
                    continue;
                }
                if (item.Contains("EOF"))
                {
                    readData = false;
                }
                if (readData)
                {
                    var spitted = item.Split(' ');
                    points.Add(new Point(int.Parse(spitted[0]), float.Parse(spitted[1], NumberStyles.Any, ci), float.Parse(spitted[2], NumberStyles.Any, ci)));
                }
            }

            return points;
        }
    }
}
