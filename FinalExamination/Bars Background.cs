using System;
using LiveChartsCore.SkiaSharpView.SKCharts;
using LiveChartsCore.SkiaSharpView.WinForms;
using SkiaSharp;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FinalExamination
{
    public partial class Bars_Background : Form
    {
        XYChartData.Chart Data;
        CartesianChart cartesianChart;
        BarsBackground barBackground;
        SKColor skselectedColor;
        bool status = false;
        public Bars_Background()
        {
            InitializeComponent();
        }

        private void Bars_Background_Load(object sender, EventArgs e)
        {
            Data = new XYChartData.Chart();
            addBarBtn.Enabled = false;
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
        private void AddChart(string name, SKColor color)
        {
            barBackground = new BarsBackground(name, color);
            cartesianChart = new CartesianChart
            {
                Name = name,
                Series = barBackground.Series,
                YAxes = barBackground.YAxes,
                Location = new System.Drawing.Point(10, 100),
                Size = new System.Drawing.Size(700, 350),
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom
            };
            Controls.Add(cartesianChart);

        }
        private void AddBar(string name, SKColor color)
        {
            cartesianChart = new CartesianChart
            {
                Name = name,
                Series = barBackground.Series,
                YAxes = barBackground.YAxes,
                Location = new System.Drawing.Point(10, 100),
                Size = new System.Drawing.Size(700, 350),
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom
            };
            Controls.Add(cartesianChart);

        }
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(nameTextBox.Text))
            {
                Color color;
                ColorDialog colorDialog = new ColorDialog();
                MessageBox.Show("Виберіть колір барів");
                DialogResult result1 = colorDialog.ShowDialog();
                if (result1 == DialogResult.OK)
                {
                    color = colorDialog.Color;
                    skselectedColor = new SKColor(color.R, color.G, color.B, color.A);
                    Data.AddLine("0");
                    AddChart(nameTextBox.Text, skselectedColor);
                 }
                barAddTextBox.Enabled = true;
                createBtn.Enabled = false;
                status = true;
            }
            else if(string.IsNullOrEmpty(nameTextBox.Text))
                MessageBox.Show("Введіть назву", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Введіть значення бару", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void addBarBtn_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(addBarBtn.Text)&&!string.IsNullOrEmpty(nameTextBox.Text))
            {
                Data.AddPoint(0, double.Parse(barAddTextBox.Text), 0);
                barsComboBox.Items.Clear();
                foreach (var bar in Data.Lines[0].Points)
                {
                    barsComboBox.Items.Add($"{bar.X}");
                }
                barsComboBox.SelectedIndex = 0;
                barBackground.AddBar(double.Parse(barAddTextBox.Text), nameTextBox.Text, skselectedColor);
                Controls.Remove(cartesianChart);
                AddBar(nameTextBox.Text, skselectedColor);
            }
            else if (string.IsNullOrEmpty(nameTextBox.Text))
                MessageBox.Show("Введіть назву", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Введіть значення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void removeBarBtn_Click(object sender, EventArgs e)
        {
            if (barsComboBox.Items.Count != -1 && barsComboBox.SelectedIndex >= 0 && !string.IsNullOrEmpty(nameTextBox.Text))
            {
                int selectedLineIndex = barsComboBox.SelectedIndex;
                Data.RemovePoint(0, selectedLineIndex);
                barsComboBox.Items.Clear();
                foreach (var bar in Data.Lines[0].Points)
                {
                    barsComboBox.Items.Add($"{bar.X}");
                }
                barBackground.RemoveBar(selectedLineIndex, nameTextBox.Text, skselectedColor);
                Controls.Remove(cartesianChart);
                AddBar(nameTextBox.Text, skselectedColor);
                if(barsComboBox.Items.Count>=1)
                barsComboBox.SelectedIndex = 0;
            }
            else if(string.IsNullOrEmpty(nameTextBox.Text))
                MessageBox.Show("Введіть назву та створіть графік", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Оберіть бар", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void clearChartBtn_Click(object sender, EventArgs e)
        {
            addBarBtn.Enabled = true;
            Controls.Remove(cartesianChart);
            int temp = barsComboBox.Items.Count;
            for (int i = temp - 1; i >= 0; i--)
            {
                Data.RemovePoint(i, 0);
            }
            Data.Clear();
            barsComboBox.Items.Clear();
            nameTextBox.Text = "";

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (status)
                CreateImageFromPieControl();
            else
                MessageBox.Show("Графік не створений", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void barAddTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(barAddTextBox.Text, out double value))
            {
                barAddTextBox.ForeColor = Color.Red;
                addBarBtn.Enabled = false;
            }
            else
            {
                barAddTextBox.ForeColor = Color.Black;
                addBarBtn.Enabled = Enabled;
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nameTextBox.Text))
                createBtn.Enabled = true;
            else
                createBtn.Enabled = false;
        }
    }
}
