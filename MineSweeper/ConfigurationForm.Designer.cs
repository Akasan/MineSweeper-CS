namespace MineSweeper
{
    partial class ConfigurationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.BombCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.マスの数 = new System.Windows.Forms.Label();
            this.SizeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BombCountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "爆弾の数";
            // 
            // BombCountNumericUpDown
            // 
            this.BombCountNumericUpDown.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.BombCountNumericUpDown.Location = new System.Drawing.Point(137, 27);
            this.BombCountNumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.BombCountNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BombCountNumericUpDown.Name = "BombCountNumericUpDown";
            this.BombCountNumericUpDown.Size = new System.Drawing.Size(94, 27);
            this.BombCountNumericUpDown.TabIndex = 1;
            this.BombCountNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BombCountNumericUpDown.ValueChanged += new System.EventHandler(this.BombCountNumericUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label2.Location = new System.Drawing.Point(28, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "高さ";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.HeightTextBox.Location = new System.Drawing.Point(137, 63);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(100, 27);
            this.HeightTextBox.TabIndex = 3;
            this.HeightTextBox.Text = "800";
            this.HeightTextBox.TextChanged += new System.EventHandler(this.HeightTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label3.Location = new System.Drawing.Point(28, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "横幅";
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.WidthTextBox.Location = new System.Drawing.Point(137, 105);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(100, 27);
            this.WidthTextBox.TabIndex = 5;
            this.WidthTextBox.Text = "800";
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(32, 207);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(199, 43);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "スタート";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // マスの数
            // 
            this.マスの数.AutoSize = true;
            this.マスの数.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.マスの数.Location = new System.Drawing.Point(28, 159);
            this.マスの数.Name = "マスの数";
            this.マスの数.Size = new System.Drawing.Size(0, 20);
            this.マスの数.TabIndex = 7;
            // 
            // SizeComboBox
            // 
            this.SizeComboBox.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.SizeComboBox.FormattingEnabled = true;
            this.SizeComboBox.Location = new System.Drawing.Point(137, 151);
            this.SizeComboBox.Name = "SizeComboBox";
            this.SizeComboBox.Size = new System.Drawing.Size(100, 28);
            this.SizeComboBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label4.Location = new System.Drawing.Point(28, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "マスの数";
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 280);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SizeComboBox);
            this.Controls.Add(this.マスの数);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BombCountNumericUpDown);
            this.Controls.Add(this.label1);
            this.Name = "ConfigurationForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.BombCountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown BombCountNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label マスの数;
        private System.Windows.Forms.ComboBox SizeComboBox;
        private System.Windows.Forms.Label label4;
    }
}