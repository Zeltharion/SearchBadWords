namespace SearchBadWords
{
    partial class TopWordsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopWordsForm));
            dataGridView_TopWords = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView_TopWords).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_TopWords
            // 
            dataGridView_TopWords.BackgroundColor = SystemColors.Control;
            dataGridView_TopWords.BorderStyle = BorderStyle.None;
            dataGridView_TopWords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_TopWords.Dock = DockStyle.Fill;
            dataGridView_TopWords.Location = new Point(0, 0);
            dataGridView_TopWords.Name = "dataGridView_TopWords";
            dataGridView_TopWords.RowTemplate.Height = 25;
            dataGridView_TopWords.Size = new Size(284, 461);
            dataGridView_TopWords.TabIndex = 0;
            // 
            // TopWordsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 461);
            Controls.Add(dataGridView_TopWords);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TopWordsForm";
            Text = "Words Top";
            ((System.ComponentModel.ISupportInitialize)dataGridView_TopWords).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_TopWords;
    }
}