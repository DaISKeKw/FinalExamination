using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using System;
using System.Collections.ObjectModel;


namespace FinalExamination
{
    internal class BasicArea
    {
        public BasicArea(string name, SKColor color)
        {
            var data = new ObservableCollection<ObservablePoint>();
            Data = data;
            SeriesCollection = new ISeries[]
            {
            new LineSeries<ObservablePoint>
            {
                Name = name,
                Values = data,
                Fill = new SolidColorPaint(color),
                Stroke = null,
                GeometryFill = null,
                GeometryStroke = null
            }
            };

        }
        public DrawMarginFrame DrawMarginFrame => new DrawMarginFrame()
        {
            Fill = new SolidColorPaint(new SKColor(220, 220, 220)),
            Stroke = new SolidColorPaint(new SKColor(180, 180, 180), 1)
        };
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
                Fill = new SolidColorPaint(color),
                Stroke = null,
                GeometryFill = null,
                GeometryStroke = null
               }
            };


        }
    }
}
