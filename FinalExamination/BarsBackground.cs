using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Drawing;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveChartsCore;
using LiveChartsCore.Defaults;
using System.Collections.ObjectModel;

namespace FinalExamination
{
    internal class BarsBackground
    {
        public ISeries[] Series { get; set; }
        public double[] Data { get; set; }
        public double[] DataMAX { get; set; }
        public double ValueMAX { get; set; }
        public Axis[] YAxes { get; set; }

        public BarsBackground(string name, SKColor color)
        {
            Series = new ISeries[]
            {
                new ColumnSeries<double>
                {
                   Values = DataMAX,
                   Stroke = null,
                   Fill = new SolidColorPaint(new SKColor(30, 30, 30, 30)),
                   IgnoresBarPosition = true
                },
                new ColumnSeries<double>
                {
                   Name = name,
                   Values = Data,
                   Stroke = null,
                   Fill = new SolidColorPaint(color),
                   IgnoresBarPosition = true
                }
            };
            YAxes = new Axis[]
            {
                new Axis { MinLimit = 0, MaxLimit = 10 }
            };
        }

        public void AddBar(double value, string name, SKColor color)
        {
            if (Data == null)
            {
                List<double> list = new List<double>();
                List<double> listM = new List<double>();
                list.Add(value);
                listM.Add(value);
                ValueMAX = value;
                Data = list.ToArray();
                DataMAX = listM.ToArray();
                Update(name, color);
            }
            else
            {

                if (ValueMAX >= value)
                {
                    List<double> list = Data.ToList();
                    List<double> listM = DataMAX.ToList();
                    list.Add(value);
                    listM.Add(ValueMAX);
                    Data = list.ToArray();
                    DataMAX = listM.ToArray();
                }
                else
                {
                    List<double> list = Data.ToList();
                    list.Add(value);
                    int length = list.Count;
                    DataMAX = new double[] { };
                    List<double> listM = DataMAX.ToList();
                    for (int i = 0; i < length; i++)
                        listM.Add(value);
                    ValueMAX = value;
                    Data = list.ToArray();
                    DataMAX = listM.ToArray();

                }
                Update(name, color);
            }
        }
        private void Update(string name, SKColor color)
        {
            Series = new ISeries[]
            {
                new ColumnSeries<double>
                {
                   Name = "Максимум",
                   Values = DataMAX,
                   Stroke = null,
                   Fill = new SolidColorPaint(new SKColor(30, 30, 30, 30)),
                   IgnoresBarPosition = true
                },
                new ColumnSeries<double>
                {
                   Name = name,
                   Values = Data,
                   Stroke = null,
                   Fill = new SolidColorPaint(color),
                   IgnoresBarPosition = true
                }
            };
            UpdateYAxes();
        }
        private void UpdateYAxes()
        {
            if (Data.Length != 0)
            {

            double min = 0;
            if(Data.ToList().Min()<=0)
                min = Data.ToList().Min();
            YAxes = new Axis[]
            {
                new Axis { MinLimit = min, MaxLimit = ValueMAX }
            };
            }
            else
            {
                YAxes = new Axis[]
{
                new Axis { MinLimit = 0, MaxLimit = 10 }
};
            }
        }
        public void RemoveBar(int index, string name, SKColor color)
        {
            List<double> list = Data.ToList();
            List<double> listM = DataMAX.ToList();
            double max = 0;
            list.RemoveAt(index);
            if(list.Count >= 1)
            {

            foreach (var tmp in list)
            {
                if (tmp >= max)
                    max = tmp;
            }
            if (max != ValueMAX)
            {
                ValueMAX = max;
                int length = list.Count;
                listM.Clear();
                for (int i = 0; i < length; i++)
                    listM.Add(ValueMAX);
            }
            else
            {
                int length = list.Count;
                listM.Clear();
                for (int i = 0; i < length; i++)
                    listM.Add(ValueMAX);
            }
                Data = list.ToArray();
                DataMAX = listM.ToArray();
            }
            else
            {
                Data = new double[] { };
                DataMAX = new double[] { };
            }

            Update(name, color);

        }


    }
}
