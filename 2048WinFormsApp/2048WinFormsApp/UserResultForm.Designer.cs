
namespace _2048WinFormsApp
{
    partial class UserResultForm
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
            this.userResultDataGridView = new System.Windows.Forms.DataGridView();
            this.NameUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userResultDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userResultDataGridView
            // 
            this.userResultDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.userResultDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.userResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userResultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameUser,
            this.Score});
            this.userResultDataGridView.Location = new System.Drawing.Point(12, 12);
            this.userResultDataGridView.Name = "userResultDataGridView";
            this.userResultDataGridView.RowHeadersWidth = 51;
            this.userResultDataGridView.RowTemplate.Height = 29;
            this.userResultDataGridView.Size = new System.Drawing.Size(307, 372);
            this.userResultDataGridView.TabIndex = 0;
            // 
            // NameUser
            // 
            this.NameUser.HeaderText = "Имя";
            this.NameUser.MinimumWidth = 6;
            this.NameUser.Name = "NameUser";
            this.NameUser.Width = 125;
            // 
            // Score
            // 
            this.Score.HeaderText = "Счет";
            this.Score.MinimumWidth = 6;
            this.Score.Name = "Score";
            this.Score.Width = 125;
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(114, 397);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(98, 41);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "НАЗАД";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // UserResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(330, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.userResultDataGridView);
            this.Name = "UserResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UserResultForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userResultDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView userResultDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.Button backButton;
    }
}