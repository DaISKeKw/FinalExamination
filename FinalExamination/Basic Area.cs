using System;
using System.Drawing;
using System.Windows.Forms;
using LiveChartsCore.SkiaSharpView.WinForms;
using SkiaSharp;
using System.IO;
using LiveChartsCore.SkiaSharpView.SKCharts;

namespace FinalExamination
{
    public partial class Basic_Area : Form
    {
        XYChartData.Chart chartData;
        BasicArea chart;
        CartesianChart cartesianChart;
        int tmp = 0;
        public Basic_Area()
        {
            InitializeComponent();
            chartData = new XYChartData.Chart();
            saveBtn.Enabled = false;
        }

        private void Basic_Area_Load(object sender, EventArgs e)
        {

        }
        private void addLine_Click(object sender, EventArgs e)
        {
            if (lineComboBox.Items.Count > 1) { addLineBtn.Enabled = false; }
            else
            {
                if (string.IsNullOrEmpty(lineNameTextBox.Text))
                {
                    MessageBox.Show("Напишіть назву", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    lineComboBox.Items.Clear();
                    chartData.Clear();
                    chartData.AddLine(lineNameTextBox.Text);
                    foreach (var line in chartData.Lines)
                        lineComboBox.Items.Add(line.Name);
                    lineComboBox.SelectedIndex = 0;
                    MessageBox.Show("Виберіть колір лінії на графіку");
                    ColorDialog colorDialog = new ColorDialog();
                    DialogResult result = colorDialog.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        Color selectedColor = colorDialog.Color;
                        SKColor skColor = new SKColor(selectedColor.R, selectedColor.G, selectedColor.B, selectedColor.A);
                        if (tmp == 0)
                            AddChart(lineNameTextBox.Text, skColor);
                        else
                        {
                            cartesianChart.Dispose();
                            AddChart(lineNameTextBox.Text, skColor);

                        }
                        tmp++;
                        clearChartBtn_Click(sender, e);
                        saveBtn.Enabled = true;

                    }

                }
            }
        }
        private void addPoint_Click(object sender, EventArgs e)
        {
            if (lineComboBox.Items.Count != -1 && lineComboBox.SelectedIndex >= 0 && !string.IsNullOrEmpty(pointYAddTextBox.Text)&& !string.IsNullOrEmpty(pointXAddTextBox.Text))
            {
                double x = double.Parse(pointXAddTextBox.Text);
                double y = double.Parse(pointYAddTextBox.Text);
                chartData.AddPoint(lineComboBox.SelectedIndex, x, y);
                pointOnLineComboBox.Items.Clear();
                int selectedLineIndex = lineComboBox.SelectedIndex;
                if (selectedLineIndex >= 0 && selectedLineIndex < chartData.Lines.Count)
                {
                    foreach (var point in chartData.Lines[selectedLineIndex].Points)
                    {
                        pointOnLineComboBox.Items.Add($"{point.X};{point.Y}");
                    }
                }
                pointOnLineComboBox.SelectedIndex = 0;
                chart.AddItem(x, y);

            }
            else if(string.IsNullOrEmpty(pointYAddTextBox.Text))
                MessageBox.Show("Введіть значення Y", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(string.IsNullOrEmpty(pointXAddTextBox.Text))
                MessageBox.Show("Введіть значення X", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show("Оберіть лінію", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void removePointBtn_Click(object sender, EventArgs e)
        {
            if (lineComboBox.Items.Count != -1 && lineComboBox.SelectedIndex >= 0 && pointOnLineComboBox.Items.Count != -1 && pointOnLineComboBox.SelectedIndex >= 0)
            {
                int selectedLineIndex = lineComboBox.SelectedIndex;
                chartData.RemovePoint(selectedLineIndex, pointOnLineComboBox.SelectedIndex);
                chart.RemoveItem(pointOnLineComboBox.SelectedIndex);
                pointOnLineComboBox.Items.Clear();
                if (selectedLineIndex >= 0 && selectedLineIndex < chartData.Lines.Count)
                {
                    foreach (var point in chartData.Lines[selectedLineIndex].Points)
                    {
                        pointOnLineComboBox.Items.Add($"{point.X};{point.Y}");
                    }
                }
            }
            else if (pointOnLineComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Оберіть точку", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Оберіть лінію", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pointXAddTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(pointXAddTextBox.Text, out double value))
            {
                pointXAddTextBox.ForeColor = Color.Red;
                addPointBtn.Enabled = false;
            }
            else
            {
                pointXAddTextBox.ForeColor = Color.Black;
                addPointBtn.Enabled = Enabled;
            }
        }

        private void pointYAddTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(pointYAddTextBox.Text, out double value))
            {
                pointYAddTextBox.ForeColor = Color.Red;
                addPointBtn.Enabled = false;
            }
            else
            {
                pointYAddTextBox.ForeColor = Color.Black;
                addPointBtn.Enabled = Enabled;
            }

        }


        private void lineComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            pointOnLineComboBox.Items.Clear();
            int selectedLineIndex = lineComboBox.SelectedIndex;
            if (selectedLineIndex >= 0 && selectedLineIndex < chartData.Lines.Count)
            {
                foreach (var point in chartData.Lines[selectedLineIndex].Points)
                {
                    pointOnLineComboBox.Items.Add($"{point.X};{point.Y}");
                }
            }

        }

        private void clearChartBtn_Click(object sender, EventArgs e)
        {
            int temp = pointOnLineComboBox.Items.Count;
            for (int i = temp - 1; i >= 0; i--)
            {
                chart.RemoveItem(i);
                chartData.RemovePoint(0, i);
            }
            pointOnLineComboBox.Items.Clear();
        }

        private void lineNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lineNameTextBox.Text))
            {
                addLineBtn.Enabled = Enabled;
                addLineBtn.ForeColor = Color.Black;
            }
            else
            {
                addLineBtn.Enabled = false;
                addLineBtn.ForeColor = Color.Red;
            }
        }
        public void AddChart(string name, SKColor color)
        {
            chart = new BasicArea(name, color);
            cartesianChart = new CartesianChart
            {
                DrawMarginFrame = chart.DrawMarginFrame,
                Series = chart.SeriesCollection,
                Location = new System.Drawing.Point(5, 120),
                Size = new System.Drawing.Size(780, 570),
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom
            };

            Controls.Add(cartesianChart);
            cartesianChart.ZoomMode = LiveChartsCore.Measure.ZoomAndPanMode.None;

        }

        private void CreateImageFromPieControl()
        {
            var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var filePath = Path.Combine(dialog.SelectedPath, "myImage.png");
                var chartControl = cartesianChart;
                var skChart = new SKCartesianChart(chartControl) { Width = 900, Height = 600, };
                skChart.SaveImage(filePath, SKEncodedImageFormat.Png, 100);
            }


        }


        private void saveBtn_Click(object sender, EventArgs e)
        {
            CreateImageFromPieControl();
        }
    }
}
