﻿namespace SearchBadWords
{
    partial class StatisticsForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticsForm));
            statisticsBindingSource = new BindingSource(components);
            dataGridView_Statistics = new DataGridView();
            button_Top = new Button();
            ((System.ComponentModel.ISupportInitialize)statisticsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Statistics).BeginInit();
            SuspendLayout();
            // 
            // statisticsBindingSource
            // 
            statisticsBindingSource.DataSource = typeof(Statistics);
            // 
            // dataGridView_Statistics
            // 
            dataGridView_Statistics.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridView_Statistics.BorderStyle = BorderStyle.None;
            dataGridView_Statistics.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Statistics.Dock = DockStyle.Fill;
            dataGridView_Statistics.Location = new Point(0, 0);
            dataGridView_Statistics.Name = "dataGridView_Statistics";
            dataGridView_Statistics.RowTemplate.Height = 25;
            dataGridView_Statistics.Size = new Size(484, 361);
            dataGridView_Statistics.TabIndex = 0;
            // 
            // button_Top
            // 
            button_Top.BackColor = Color.FromArgb(255, 255, 192);
            button_Top.Dock = DockStyle.Bottom;
            button_Top.FlatAppearance.BorderColor = Color.Silver;
            button_Top.FlatStyle = FlatStyle.Flat;
            button_Top.Location = new Point(0, 331);
            button_Top.Name = "button_Top";
            button_Top.Size = new Size(484, 30);
            button_Top.TabIndex = 1;
            button_Top.Text = "Top Words";
            button_Top.UseVisualStyleBackColor = false;
            button_Top.Click += button_Top_Click;
            // 
            // StatisticsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(button_Top);
            Controls.Add(dataGridView_Statistics);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StatisticsForm";
            Text = "Word Statistics";
            ((System.ComponentModel.ISupportInitialize)statisticsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Statistics).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource statisticsBindingSource;
        private DataGridView dataGridView_Statistics;
        private Button button_Top;
    }
}