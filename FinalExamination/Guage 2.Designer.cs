namespace FinalExamination
{
    partial class _270DegreesGauge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_270DegreesGauge));
            this.lineLabel = new System.Windows.Forms.Label();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.clearChartBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.degreesTextBox = new System.Windows.Forms.TextBox();
            this.degreesLabel = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lineLabel
            // 
            this.lineLabel.AutoEllipsis = true;
            this.lineLabel.AutoSize = true;
            this.lineLabel.Font = new System.Drawing.Font("Univers Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineLabel.Location = new System.Drawing.Point(170, 23);
            this.lineLabel.Name = "lineLabel";
            this.lineLabel.Size = new System.Drawing.Size(141, 24);
            this.lineLabel.TabIndex = 9;
            this.lineLabel.Text = "Введіть значення";
            // 
            // valueTextBox
            // 
            this.valueTextBox.Font = new System.Drawing.Font("Univers Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.valueTextBox.Location = new System.Drawing.Point(174, 59);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(137, 28);
            this.valueTextBox.TabIndex = 25;
            this.valueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valueTextBox.TextChanged += new System.EventHandler(this.valueTextBox_TextChanged);
            // 
            // clearChartBtn
            // 
            this.clearChartBtn.Font = new System.Drawing.Font("Univers Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearChartBtn.Location = new System.Drawing.Point(629, 23);
            this.clearChartBtn.Name = "clearChartBtn";
            this.clearChartBtn.Size = new System.Drawing.Size(159, 64);
            this.clearChartBtn.TabIndex = 26;
            this.clearChartBtn.Text = "Очистити графік";
            this.clearChartBtn.UseVisualStyleBackColor = true;
            this.clearChartBtn.Click += new System.EventHandler(this.clearChartBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.Font = new System.Drawing.Font("Univers Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBtn.Location = new System.Drawing.Point(464, 23);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(159, 64);
            this.createBtn.TabIndex = 27;
            this.createBtn.Text = "Створити графік";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Univers Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.nameTextBox.Location = new System.Drawing.Point(27, 59);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(137, 28);
            this.nameTextBox.TabIndex = 29;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoEllipsis = true;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Univers Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(38, 23);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(115, 24);
            this.nameLabel.TabIndex = 28;
            this.nameLabel.Text = "Введіть назву";
            // 
            // degreesTextBox
            // 
            this.degreesTextBox.Font = new System.Drawing.Font("Univers Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degreesTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.degreesTextBox.Location = new System.Drawing.Point(321, 59);
            this.degreesTextBox.Name = "degreesTextBox";
            this.degreesTextBox.Size = new System.Drawing.Size(137, 28);
            this.degreesTextBox.TabIndex = 31;
            this.degreesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.degreesTextBox.TextChanged += new System.EventHandler(this.degreesTextBox_TextChanged);
            // 
            // degreesLabel
            // 
            this.degreesLabel.AutoEllipsis = true;
            this.degreesLabel.AutoSize = true;
            this.degreesLabel.Font = new System.Drawing.Font("Univers Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degreesLabel.Location = new System.Drawing.Point(328, 26);
            this.degreesLabel.Name = "degreesLabel";
            this.degreesLabel.Size = new System.Drawing.Size(124, 24);
            this.degreesLabel.TabIndex = 30;
            this.degreesLabel.Text = "Розмірність в°";
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Univers Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(824, 23);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(117, 64);
            this.saveBtn.TabIndex = 32;
            this.saveBtn.Text = "Зберегти як фото";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // _270DegreesGauge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 572);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.degreesTextBox);
            this.Controls.Add(this.degreesLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.clearChartBtn);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.lineLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(975, 600);
            this.Name = "_270DegreesGauge";
            this.Text = "Guage 2";
            this.Load += new System.EventHandler(this._270DegreesGauge_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lineLabel;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.Button clearChartBtn;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox degreesTextBox;
        private System.Windows.Forms.Label degreesLabel;
        private System.Windows.Forms.Button saveBtn;
    }
}