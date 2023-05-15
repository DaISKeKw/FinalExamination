namespace FinalExamination
{
    partial class Bars_Background
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bars_Background));
            this.saveBtn = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.barsComboBox = new System.Windows.Forms.ComboBox();
            this.clearChartBtn = new System.Windows.Forms.Button();
            this.barAddTextBox = new System.Windows.Forms.TextBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.addBarBtn = new System.Windows.Forms.Button();
            this.removeBarBtn = new System.Windows.Forms.Button();
            this.LineNameLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Univers Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(755, 11);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(117, 71);
            this.saveBtn.TabIndex = 41;
            this.saveBtn.Text = "Зберегти як фото";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Univers Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.nameTextBox.Location = new System.Drawing.Point(95, 52);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(159, 28);
            this.nameTextBox.TabIndex = 40;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // barsComboBox
            // 
            this.barsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.barsComboBox.Font = new System.Drawing.Font("Univers Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barsComboBox.FormattingEnabled = true;
            this.barsComboBox.Location = new System.Drawing.Point(425, 53);
            this.barsComboBox.Name = "barsComboBox";
            this.barsComboBox.Size = new System.Drawing.Size(159, 28);
            this.barsComboBox.TabIndex = 39;
            // 
            // clearChartBtn
            // 
            this.clearChartBtn.Font = new System.Drawing.Font("Univers Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearChartBtn.Location = new System.Drawing.Point(590, 12);
            this.clearChartBtn.Name = "clearChartBtn";
            this.clearChartBtn.Size = new System.Drawing.Size(159, 70);
            this.clearChartBtn.TabIndex = 38;
            this.clearChartBtn.Text = "Очистити графік";
            this.clearChartBtn.UseVisualStyleBackColor = true;
            this.clearChartBtn.Click += new System.EventHandler(this.clearChartBtn_Click);
            // 
            // barAddTextBox
            // 
            this.barAddTextBox.Font = new System.Drawing.Font("Univers Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barAddTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.barAddTextBox.Location = new System.Drawing.Point(260, 52);
            this.barAddTextBox.Name = "barAddTextBox";
            this.barAddTextBox.Size = new System.Drawing.Size(159, 28);
            this.barAddTextBox.TabIndex = 37;
            this.barAddTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.barAddTextBox.TextChanged += new System.EventHandler(this.barAddTextBox_TextChanged);
            // 
            // createBtn
            // 
            this.createBtn.Font = new System.Drawing.Font("Univers Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBtn.Location = new System.Drawing.Point(95, 12);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(159, 35);
            this.createBtn.TabIndex = 35;
            this.createBtn.Text = "Введіть назву";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // addBarBtn
            // 
            this.addBarBtn.Font = new System.Drawing.Font("Univers Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBarBtn.Location = new System.Drawing.Point(260, 12);
            this.addBarBtn.Name = "addBarBtn";
            this.addBarBtn.Size = new System.Drawing.Size(159, 35);
            this.addBarBtn.TabIndex = 34;
            this.addBarBtn.Text = "Додати бар";
            this.addBarBtn.UseVisualStyleBackColor = true;
            this.addBarBtn.Click += new System.EventHandler(this.addBarBtn_Click);
            // 
            // removeBarBtn
            // 
            this.removeBarBtn.Font = new System.Drawing.Font("Univers Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBarBtn.Location = new System.Drawing.Point(425, 12);
            this.removeBarBtn.Name = "removeBarBtn";
            this.removeBarBtn.Size = new System.Drawing.Size(159, 35);
            this.removeBarBtn.TabIndex = 43;
            this.removeBarBtn.Text = "Видалити bar";
            this.removeBarBtn.UseVisualStyleBackColor = true;
            this.removeBarBtn.Click += new System.EventHandler(this.removeBarBtn_Click);
            // 
            // LineNameLbl
            // 
            this.LineNameLbl.AutoSize = true;
            this.LineNameLbl.Font = new System.Drawing.Font("Univers Condensed", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LineNameLbl.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.LineNameLbl.Location = new System.Drawing.Point(297, 83);
            this.LineNameLbl.Name = "LineNameLbl";
            this.LineNameLbl.Size = new System.Drawing.Size(93, 15);
            this.LineNameLbl.TabIndex = 44;
            this.LineNameLbl.Text = "Введіть значення";
            // 
            // Bars_Background
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 572);
            this.Controls.Add(this.LineNameLbl);
            this.Controls.Add(this.removeBarBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.barsComboBox);
            this.Controls.Add(this.clearChartBtn);
            this.Controls.Add(this.barAddTextBox);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.addBarBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(980, 610);
            this.Name = "Bars_Background";
            this.Text = "Bars Background";
            this.Load += new System.EventHandler(this.Bars_Background_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ComboBox barsComboBox;
        private System.Windows.Forms.Button clearChartBtn;
        private System.Windows.Forms.TextBox barAddTextBox;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button addBarBtn;
        private System.Windows.Forms.Button removeBarBtn;
        private System.Windows.Forms.Label LineNameLbl;
    }
}