using System.Collections.Generic;

namespace FinalExamination
{
    internal class XYChartData
    {
        public class Point
        {
            public double X { get; set; }
            public double Y { get; set; }
        }

        public class Line
        {
            public string Name { get; set; }
            public List<Point> Points { get; set; }
        }
        public class Chart
        {
            public List<Line> Lines { get; set; }

            public Chart()
            {
                Lines = new List<Line>();
            }

            public void AddLine(string name)
            {
                var line = new Line
                {
                    Name = name,
                    Points = new List<Point>()
                };
                Lines.Add(line);
            }
            public void RemoveLine(int index)
            {
                if (index >= 0 && index < Lines.Count)
                {
                    Lines.RemoveAt(index);
                }
            }

            public void AddPoint(int lineIndex, double x, double y)
            {
                var point = new Point
                {
                    X = x,
                    Y = y
                };
                Lines[lineIndex].Points.Add(point);
            }
            public void RemovePoint(int lineIndex, int pointIndex)
            {
                if (lineIndex >= 0 && lineIndex < Lines.Count)
                {
                   
                    if (pointIndex >= 0 && pointIndex < Lines[lineIndex].Points.Count)
                    {
                        Lines[lineIndex].Points.RemoveAt(pointIndex);
                    }
                }
            }
            public void RenameLine(int index, string newName)
            {
                if (index >= 0 && index < Lines.Count)
                {
                    Lines[index].Name = newName;
                }
            }
            public void Clear()
            {
                Lines.Clear();
            }
        }

    }
}
