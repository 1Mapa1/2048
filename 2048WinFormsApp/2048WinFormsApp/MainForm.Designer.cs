
namespace _2048WinFormsApp
{
    partial class MainForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.bestUserLabel = new System.Windows.Forms.Label();
            this.resultGamesButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.mapSizeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(324, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "2048";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(60, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите имя:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(235, 214);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(394, 27);
            this.nameTextBox.TabIndex = 2;
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startButton.Location = new System.Drawing.Point(307, 308);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(165, 56);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "ИГРАТЬ";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // bestUserLabel
            // 
            this.bestUserLabel.AutoSize = true;
            this.bestUserLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bestUserLabel.Location = new System.Drawing.Point(60, 140);
            this.bestUserLabel.Name = "bestUserLabel";
            this.bestUserLabel.Size = new System.Drawing.Size(163, 31);
            this.bestUserLabel.TabIndex = 4;
            this.bestUserLabel.Text = "Лучший игрок";
            // 
            // resultGamesButton
            // 
            this.resultGamesButton.AutoSize = true;
            this.resultGamesButton.Location = new System.Drawing.Point(318, 381);
            this.resultGamesButton.Name = "resultGamesButton";
            this.resultGamesButton.Size = new System.Drawing.Size(139, 30);
            this.resultGamesButton.TabIndex = 5;
            this.resultGamesButton.Text = "РЕЗУЛЬТАТЫ ИГР";
            this.resultGamesButton.UseVisualStyleBackColor = true;
            this.resultGamesButton.Click += new System.EventHandler(this.resultGamesButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(60, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Размер поля:";
            // 
            // mapSizeComboBox
            // 
            this.mapSizeComboBox.FormattingEnabled = true;
            this.mapSizeComboBox.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.mapSizeComboBox.Location = new System.Drawing.Point(235, 269);
            this.mapSizeComboBox.Name = "mapSizeComboBox";
            this.mapSizeComboBox.Size = new System.Drawing.Size(151, 28);
            this.mapSizeComboBox.TabIndex = 8;
            this.mapSizeComboBox.Text = "4";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mapSizeComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultGamesButton);
            this.Controls.Add(this.bestUserLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label bestUserLabel;
        private System.Windows.Forms.Button resultGamesButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox mapSizeComboBox;
    }
}