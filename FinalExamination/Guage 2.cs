using LiveChartsCore.SkiaSharpView.SKCharts;
using LiveChartsCore.SkiaSharpView.WinForms;
using SkiaSharp;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FinalExamination
{
    public partial class _270DegreesGauge : Form
    {
        PieChart pieChart;
        bool status = false;
        
        public _270DegreesGauge()
        {
            InitializeComponent();
            clearChartBtn.Enabled = false;
        }

        private void _270DegreesGauge_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void AddChart(string name, SKColor guageColor, SKColor valueColor, double value, double degrees)
        {
            var ser = new Guage2(name, guageColor, valueColor, value);
            pieChart = new PieChart
            {
                Series = ser.Series,
                InitialRotation = -225,
                MaxAngle = degrees,
                Total = degrees,
                Location = new System.Drawing.Point(10, 100),
                Size = new System.Drawing.Size(700, 350),
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom
            };
            Controls.Add(pieChart);
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && valueTextBox.Text != "" && degreesTextBox.Text != "" && double.Parse(valueTextBox.Text) <= double.Parse(degreesTextBox.Text))
            {
                Color selectedColorValue, selectedColorGuage;
                ColorDialog colorDialog = new ColorDialog();
                MessageBox.Show("Виберіть колір графіку");
                DialogResult result1 = colorDialog.ShowDialog();
                if (result1 == DialogResult.OK)
                {
                    selectedColorGuage = colorDialog.Color;
                    SKColor skselectedColorGuage = new SKColor(selectedColorGuage.R, selectedColorGuage.G, selectedColorGuage.B, selectedColorGuage.A);
                    MessageBox.Show("Виберіть колір значення");
                    DialogResult result2 = colorDialog.ShowDialog();
                    if (result2 == DialogResult.OK)
                    {
                        selectedColorValue = colorDialog.Color;
                        SKColor skselectedColorValue = new SKColor(selectedColorValue.R, selectedColorValue.G, selectedColorValue.B, selectedColorGuage.A);
                        AddChart(nameTextBox.Text, skselectedColorGuage, skselectedColorValue, double.Parse(valueTextBox.Text) , double.Parse(degreesTextBox.Text));
                        createBtn.Enabled = false;
                        nameTextBox.Enabled = false;
                        degreesTextBox.Enabled = false;
                        valueTextBox.Enabled = false;
                        clearChartBtn.Enabled = true;
                        status = true;
                    }
                }

            }
            else if (nameTextBox.Text == "")
                MessageBox.Show("Введіть назву", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);  
            else if (degreesTextBox.Text =="")
                MessageBox.Show("Введіть розмір графіка", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(double.Parse(valueTextBox.Text) > double.Parse(degreesTextBox.Text))
                MessageBox.Show("Розмірність графіка менше вказаного значення!!!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Введіть значення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void valueTextBox_TextChanged(object sender, EventArgs e)
        {
            bool valueValid = double.TryParse(valueTextBox.Text, out double value);
            if (valueValid)
            {
                valueTextBox.ForeColor = Color.Black;
            }
            else
            {
                valueTextBox.ForeColor = Color.Red;
            }

            createBtn.Enabled = valueValid && !string.IsNullOrEmpty(nameTextBox.Text) && double.TryParse(degreesTextBox.Text, out double degrees);
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            createBtn.Enabled = !string.IsNullOrEmpty(valueTextBox.Text) && !string.IsNullOrEmpty(nameTextBox.Text) && double.TryParse(degreesTextBox.Text, out double degrees);
        }

        private void degreesTextBox_TextChanged(object sender, EventArgs e)
        {
            bool degreesValid = double.TryParse(degreesTextBox.Text, out double degrees);

            if (degreesValid && (degrees < 0 || degrees > 360))
            {
                degreesTextBox.ForeColor = Color.Red;
                createBtn.Enabled = false;
                MessageBox.Show("Максимальне значення 360°", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                degreesTextBox.Text = "";
            }
            else if (degreesValid)
            {
                degreesTextBox.ForeColor = Color.Black;
                createBtn.Enabled = !string.IsNullOrEmpty(valueTextBox.Text) && !string.IsNullOrEmpty(nameTextBox.Text);
            }
            else
            {
                degreesTextBox.ForeColor = Color.Red;
                createBtn.Enabled = false;
            }
        }

        private void clearChartBtn_Click(object sender, EventArgs e)
        {
            pieChart.Dispose();
            createBtn.Enabled = true;
            nameTextBox.Enabled = true;
            degreesTextBox.Enabled = true;
            valueTextBox.Enabled = true;
            clearChartBtn.Enabled = false;
            status = false;

        }
        private void CreateImageFromPieControl()
        {
            var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var filePath = Path.Combine(dialog.SelectedPath, "myImage.png");
                var chartControl = pieChart;
                var skChart = new SKPieChart(chartControl) { Width = 900, Height = 600, };
                skChart.SaveImage(filePath,SKEncodedImageFormat.Png,100);
            }

            
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(status)
            CreateImageFromPieControl();
            else
                MessageBox.Show("Графік не створений", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
