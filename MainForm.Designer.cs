namespace SearchBadWords
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            treeView_Directories = new TreeView();
            progressBar_Files = new ProgressBar();
            label_CurrentFile = new Label();
            listBox_Files = new ListBox();
            button_SaveIn = new Button();
            button_Filter = new Button();
            button_Statistics = new Button();
            button_Search = new Button();
            toolTip1 = new ToolTip(components);
            label_PathSave = new Label();
            SuspendLayout();
            // 
            // treeView_Directories
            // 
            treeView_Directories.BorderStyle = BorderStyle.None;
            treeView_Directories.Dock = DockStyle.Left;
            treeView_Directories.Location = new Point(0, 0);
            treeView_Directories.Name = "treeView_Directories";
            treeView_Directories.Size = new Size(209, 461);
            treeView_Directories.TabIndex = 0;
            // 
            // progressBar_Files
            // 
            progressBar_Files.Location = new Point(228, 426);
            progressBar_Files.Name = "progressBar_Files";
            progressBar_Files.Size = new Size(654, 23);
            progressBar_Files.TabIndex = 1;
            progressBar_Files.Visible = false;
            // 
            // label_CurrentFile
            // 
            label_CurrentFile.AutoSize = true;
            label_CurrentFile.Location = new Point(228, 408);
            label_CurrentFile.Name = "label_CurrentFile";
            label_CurrentFile.Size = new Size(69, 15);
            label_CurrentFile.TabIndex = 2;
            label_CurrentFile.Text = "Current file:";
            // 
            // listBox_Files
            // 
            listBox_Files.FormattingEnabled = true;
            listBox_Files.ItemHeight = 15;
            listBox_Files.Location = new Point(228, 12);
            listBox_Files.Name = "listBox_Files";
            listBox_Files.Size = new Size(654, 214);
            listBox_Files.TabIndex = 3;
            // 
            // button_SaveIn
            // 
            button_SaveIn.BackColor = Color.FromArgb(255, 255, 192);
            button_SaveIn.FlatAppearance.BorderColor = Color.Silver;
            button_SaveIn.FlatStyle = FlatStyle.Flat;
            button_SaveIn.Location = new Point(228, 240);
            button_SaveIn.Name = "button_SaveIn";
            button_SaveIn.Size = new Size(215, 30);
            button_SaveIn.TabIndex = 4;
            button_SaveIn.Text = "Save in...";
            button_SaveIn.UseVisualStyleBackColor = false;
            button_SaveIn.Click += button_SaveIn_Click;
            button_SaveIn.MouseEnter += button_SaveIn_MouseEnter;
            button_SaveIn.MouseLeave += button_SaveIn_MouseLeave;
            // 
            // button_Filter
            // 
            button_Filter.BackColor = Color.FromArgb(255, 255, 192);
            button_Filter.FlatAppearance.BorderColor = Color.Silver;
            button_Filter.FlatStyle = FlatStyle.Flat;
            button_Filter.Location = new Point(449, 240);
            button_Filter.Name = "button_Filter";
            button_Filter.Size = new Size(215, 30);
            button_Filter.TabIndex = 5;
            button_Filter.Text = "Filter words...";
            button_Filter.UseVisualStyleBackColor = false;
            button_Filter.Click += button_Filter_Click;
            // 
            // button_Statistics
            // 
            button_Statistics.BackColor = Color.Lime;
            button_Statistics.FlatAppearance.BorderColor = Color.Silver;
            button_Statistics.FlatStyle = FlatStyle.Flat;
            button_Statistics.Location = new Point(670, 390);
            button_Statistics.Name = "button_Statistics";
            button_Statistics.Size = new Size(215, 30);
            button_Statistics.TabIndex = 6;
            button_Statistics.Text = "Statistics";
            button_Statistics.UseVisualStyleBackColor = false;
            button_Statistics.Click += button_Statistics_Click;
            // 
            // button_Search
            // 
            button_Search.BackColor = Color.FromArgb(255, 255, 192);
            button_Search.FlatAppearance.BorderColor = Color.Silver;
            button_Search.FlatStyle = FlatStyle.Flat;
            button_Search.Location = new Point(670, 240);
            button_Search.Name = "button_Search";
            button_Search.Size = new Size(215, 30);
            button_Search.TabIndex = 7;
            button_Search.Text = "Search";
            button_Search.UseVisualStyleBackColor = false;
            button_Search.Click += button_Search_Click;
            // 
            // label_PathSave
            // 
            label_PathSave.AutoSize = true;
            label_PathSave.Location = new Point(324, 264);
            label_PathSave.Name = "label_PathSave";
            label_PathSave.Size = new Size(0, 15);
            label_PathSave.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 461);
            Controls.Add(label_PathSave);
            Controls.Add(button_Search);
            Controls.Add(button_Statistics);
            Controls.Add(button_Filter);
            Controls.Add(button_SaveIn);
            Controls.Add(listBox_Files);
            Controls.Add(label_CurrentFile);
            Controls.Add(progressBar_Files);
            Controls.Add(treeView_Directories);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView_Directories;
        private ProgressBar progressBar_Files;
        private Label label_CurrentFile;
        private ListBox listBox_Files;
        private Button button_SaveIn;
        private Button button_Filter;
        private Button button_Statistics;
        private Button button_Search;
        private ToolTip toolTip1;
        private Label label_PathSave;
    }
}