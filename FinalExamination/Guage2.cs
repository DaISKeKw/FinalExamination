using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.Drawing;
using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Drawing;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamination
{
    internal class Guage2
    {
        public string Name { get; set; }
        public SKColor GuageColor { get; set; }
        public double Value { get; set; }
        public SKColor ValueColor { get; set; }

        public IEnumerable<ISeries> Series { get; set; }
        public Guage2(string name, SKColor guageColor, SKColor valueColor, double value)
        {
            Name = name;
            GuageColor = guageColor;
            ValueColor = valueColor;
            Value = value;

            Series = new GaugeBuilder()
                .WithLabelsSize(50)
                .WithInnerRadius(75)
                .WithBackgroundInnerRadius(75)
                .WithBackground(new SolidColorPaint(new SKColor(100, 181, 246, 90)))
                .WithLabelsPosition(PolarLabelsPosition.ChartCenter)
                .AddValue(Value, Name, GuageColor, ValueColor)
                .BuildSeries();
        }
    }
}
