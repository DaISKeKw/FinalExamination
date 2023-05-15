namespace FinalExamination
{
    partial class SingleXYChart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingleXYChart));
            this.addPointBtn = new System.Windows.Forms.Button();
            this.removePointBtn = new System.Windows.Forms.Button();
            this.addLineBtn = new System.Windows.Forms.Button();
            this.lineLabel = new System.Windows.Forms.Label();
            this.pointXAddTextBox = new System.Windows.Forms.TextBox();
            this.pointYAddTextBox = new System.Windows.Forms.TextBox();
            this.clearChartBtn = new System.Windows.Forms.Button();
            this.LineNameLbl = new System.Windows.Forms.Label();
            this.x = new System.Windows.Forms.Label();
            this.y = new System.Windows.Forms.Label();
            this.lineComboBox = new System.Windows.Forms.ComboBox();
            this.pointOnLineComboBox = new System.Windows.Forms.ComboBox();
            this.lineNameTextBox = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addPointBtn
            // 
            this.addPointBtn.Font = new System.Drawing.Font("Univers Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPointBtn.Location = new System.Drawing.Point(394, 16);
            this.addPointBtn.Name = "addPointBtn";
            this.addPointBtn.Size = new System.Drawing.Size(159, 35);
            this.addPointBtn.TabIndex = 4;
            this.addPointBtn.Text = "Додати точку";
            this.addPointBtn.UseVisualStyleBackColor = true;
            this.addPointBtn.Click += new System.EventHandler(this.addPoint_Click);
            // 
            // removePointBtn
            // 
            this.removePointBtn.Font = new System.Drawing.Font("Univers Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removePointBtn.Location = new System.Drawing.Point(559, 16);
            this.removePointBtn.Name = "removePointBtn";
            this.removePointBtn.Size = new System.Drawing.Size(159, 35);
            this.removePointBtn.TabIndex = 5;
            this.removePointBtn.Text = "Видалити точку";
            this.removePointBtn.UseVisualStyleBackColor = true;
            this.removePointBtn.Click += new System.EventHandler(this.removePointBtn_Click);
            // 
            // addLineBtn
            // 
            this.addLineBtn.Font = new System.Drawing.Font("Univers Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLineBtn.Location = new System.Drawing.Point(229, 17);
            this.addLineBtn.Name = "addLineBtn";
            this.addLineBtn.Size = new System.Drawing.Size(159, 35);
            this.addLineBtn.TabIndex = 6;
            this.addLineBtn.Text = "Створити нову лінію";
            this.addLineBtn.UseVisualStyleBackColor = true;
            this.addLineBtn.Click += new System.EventHandler(this.addLine_Click);
            // 
            // lineLabel
            // 
            this.lineLabel.AutoEllipsis = true;
            this.lineLabel.AutoSize = true;
            this.lineLabel.Font = new System.Drawing.Font("Univers Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineLabel.Location = new System.Drawing.Point(134, 20);
            this.lineLabel.Name = "lineLabel";
            this.lineLabel.Size = new System.Drawing.Size(45, 24);
            this.lineLabel.TabIndex = 8;
            this.lineLabel.Text = "Лінії";
            // 
            // pointXAddTextBox
            // 
            this.pointXAddTextBox.Font = new System.Drawing.Font("Univers Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointXAddTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.pointXAddTextBox.Location = new System.Drawing.Point(394, 56);
            this.pointXAddTextBox.Name = "pointXAddTextBox";
            this.pointXAddTextBox.Size = new System.Drawing.Size(72, 28);
            this.pointXAddTextBox.TabIndex = 10;
            this.pointXAddTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pointXAddTextBox.TextChanged += new System.EventHandler(this.pointXAddTextBox_TextChanged);
            // 
            // pointYAddTextBox
            // 
            this.pointYAddTextBox.Font = new System.Drawing.Font("Univers Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointYAddTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.pointYAddTextBox.Location = new System.Drawing.Point(481, 57);
            this.pointYAddTextBox.Name = "pointYAddTextBox";
            this.pointYAddTextBox.Size = new System.Drawing.Size(72, 28);
            this.pointYAddTextBox.TabIndex = 13;
            this.pointYAddTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pointYAddTextBox.TextChanged += new System.EventHandler(this.pointYAddTextBox_TextChanged);
            // 
            // clearChartBtn
            // 
            this.clearChartBtn.Font = new System.Drawing.Font("Univers Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearChartBtn.Location = new System.Drawing.Point(724, 17);
            this.clearChartBtn.Name = "clearChartBtn";
            this.clearChartBtn.Size = new System.Drawing.Size(159, 70);
            this.clearChartBtn.TabIndex = 16;
            this.clearChartBtn.Text = "Очистити графік";
            this.clearChartBtn.UseVisualStyleBackColor = true;
            this.clearChartBtn.Click += new System.EventHandler(this.clearChartBtn_Click);
            // 
            // LineNameLbl
            // 
            this.LineNameLbl.AutoSize = true;
            this.LineNameLbl.Font = new System.Drawing.Font("Univers Condensed", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LineNameLbl.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.LineNameLbl.Location = new System.Drawing.Point(256, 89);
            this.LineNameLbl.Name = "LineNameLbl";
            this.LineNameLbl.Size = new System.Drawing.Size(99, 15);
            this.LineNameLbl.TabIndex = 17;
            this.LineNameLbl.Text = "Введіть назву лінії";
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.Font = new System.Drawing.Font("Univers Condensed", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.x.Location = new System.Drawing.Point(423, 88);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(14, 15);
            this.x.TabIndex = 18;
            this.x.Text = "X";
            // 
            // y
            // 
            this.y.AutoSize = true;
            this.y.Font = new System.Drawing.Font("Univers Condensed", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.y.Location = new System.Drawing.Point(510, 88);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(14, 15);
            this.y.TabIndex = 19;
            this.y.Text = "Y";
            // 
            // lineComboBox
            // 
            this.lineComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lineComboBox.Font = new System.Drawing.Font("Univers Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineComboBox.FormattingEnabled = true;
            this.lineComboBox.Location = new System.Drawing.Point(102, 57);
            this.lineComboBox.Name = "lineComboBox";
            this.lineComboBox.Size = new System.Drawing.Size(121, 28);
            this.lineComboBox.TabIndex = 22;
            this.lineComboBox.SelectedIndexChanged += new System.EventHandler(this.lineComboBox_SelectedIndexChanged);
            // 
            // pointOnLineComboBox
            // 
            this.pointOnLineComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pointOnLineComboBox.Font = new System.Drawing.Font("Univers Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointOnLineComboBox.FormattingEnabled = true;
            this.pointOnLineComboBox.Location = new System.Drawing.Point(559, 58);
            this.pointOnLineComboBox.Name = "pointOnLineComboBox";
            this.pointOnLineComboBox.Size = new System.Drawing.Size(159, 28);
            this.pointOnLineComboBox.TabIndex = 23;
            // 
            // lineNameTextBox
            // 
            this.lineNameTextBox.Font = new System.Drawing.Font("Univers Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineNameTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lineNameTextBox.Location = new System.Drawing.Point(229, 57);
            this.lineNameTextBox.Name = "lineNameTextBox";
            this.lineNameTextBox.Size = new System.Drawing.Size(159, 28);
            this.lineNameTextBox.TabIndex = 24;
            this.lineNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lineNameTextBox.TextChanged += new System.EventHandler(this.lineNameTextBox_TextChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Univers Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(889, 16);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(117, 71);
            this.saveBtn.TabIndex = 33;
            this.saveBtn.Text = "Зберегти як фото";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // SingleXYChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 874);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.lineNameTextBox);
            this.Controls.Add(this.pointOnLineComboBox);
            this.Controls.Add(this.lineComboBox);
            this.Controls.Add(this.y);
            this.Controls.Add(this.x);
            this.Controls.Add(this.LineNameLbl);
            this.Controls.Add(this.clearChartBtn);
            this.Controls.Add(this.pointYAddTextBox);
            this.Controls.Add(this.pointXAddTextBox);
            this.Controls.Add(this.lineLabel);
            this.Controls.Add(this.addLineBtn);
            this.Controls.Add(this.removePointBtn);
            this.Controls.Add(this.addPointBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1077, 900);
            this.Name = "SingleXYChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Simple X Y Chart";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addPointBtn;
        private System.Windows.Forms.Button removePointBtn;
        private System.Windows.Forms.Button addLineBtn;
        private System.Windows.Forms.Label lineLabel;
        private System.Windows.Forms.TextBox pointXAddTextBox;
        private System.Windows.Forms.TextBox pointYAddTextBox;
        private System.Windows.Forms.Button clearChartBtn;
        private System.Windows.Forms.Label LineNameLbl;
        private System.Windows.Forms.Label x;
        private System.Windows.Forms.Label y;
        private System.Windows.Forms.ComboBox lineComboBox;
        private System.Windows.Forms.ComboBox pointOnLineComboBox;
        private System.Windows.Forms.TextBox lineNameTextBox;
        private System.Windows.Forms.Button saveBtn;
    }
}