using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using System;
using System.Collections.ObjectModel;

namespace FinalExamination
{
    internal class BasicScatter
    {
        public BasicScatter(string name, SKColor color)
        {
            var data = new ObservableCollection<ObservablePoint>();
            Data = data;
            SeriesCollection = new ISeries[]
            {
            new LineSeries<ObservablePoint>
            {
                Name = name,
                Values = data,
                DataPadding = new LiveChartsCore.Drawing.LvcPoint(5, 5),
                Stroke = null,
                GeometryStroke = new SolidColorPaint(color, 3f),
                Fill = null,
            }
            };
        }
        public ObservableCollection<ObservablePoint> Data { get; set; }

        public ISeries[] SeriesCollection { get; set; }
        public void AddItem(double x, double y)
        {
            Data.Add(new ObservablePoint(x, y));
        }
        public void RemoveItem(int count)
        {
            if (Data.Count == 0) return;
            Data.RemoveAt(count);
        }
        public void AddSeries(string name, SKColor color)
        {

            var data = new ObservableCollection<ObservablePoint> { };
            Data = data;
            SeriesCollection = new ISeries[]
            {
               new LineSeries<ObservablePoint>
               {
                   Name = name,
                   Values = data,
                   DataPadding = new LiveChartsCore.Drawing.LvcPoint(5, 5),
                   Stroke = null

               }
            };


        }
    }
}
