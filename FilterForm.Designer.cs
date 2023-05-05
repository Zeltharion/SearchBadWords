namespace SearchBadWords
{
    partial class FilterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterForm));
            richTextBox_Word = new RichTextBox();
            label_Enter = new Label();
            listBox_AddedWords = new ListBox();
            button_Add = new Button();
            button_Delete = new Button();
            button_LoadFromFile = new Button();
            SuspendLayout();
            // 
            // richTextBox_Word
            // 
            richTextBox_Word.Location = new Point(12, 27);
            richTextBox_Word.Name = "richTextBox_Word";
            richTextBox_Word.Size = new Size(260, 65);
            richTextBox_Word.TabIndex = 0;
            richTextBox_Word.Text = "";
            // 
            // label_Enter
            // 
            label_Enter.AutoSize = true;
            label_Enter.Location = new Point(12, 9);
            label_Enter.Name = "label_Enter";
            label_Enter.Size = new Size(72, 15);
            label_Enter.TabIndex = 1;
            label_Enter.Text = "Enter words:";
            // 
            // listBox_AddedWords
            // 
            listBox_AddedWords.FormattingEnabled = true;
            listBox_AddedWords.ItemHeight = 15;
            listBox_AddedWords.Location = new Point(12, 127);
            listBox_AddedWords.Name = "listBox_AddedWords";
            listBox_AddedWords.Size = new Size(260, 289);
            listBox_AddedWords.TabIndex = 2;
            // 
            // button_Add
            // 
            button_Add.BackColor = Color.FromArgb(192, 255, 192);
            button_Add.FlatAppearance.BorderColor = Color.Silver;
            button_Add.FlatStyle = FlatStyle.Flat;
            button_Add.Location = new Point(12, 98);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(128, 23);
            button_Add.TabIndex = 3;
            button_Add.Text = "Add";
            button_Add.UseVisualStyleBackColor = false;
            button_Add.Click += button_Add_Click;
            // 
            // button_Delete
            // 
            button_Delete.BackColor = Color.FromArgb(255, 192, 192);
            button_Delete.FlatAppearance.BorderColor = Color.Silver;
            button_Delete.FlatStyle = FlatStyle.Flat;
            button_Delete.Location = new Point(144, 98);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(128, 23);
            button_Delete.TabIndex = 4;
            button_Delete.Text = "Delete";
            button_Delete.UseVisualStyleBackColor = false;
            button_Delete.Click += button_Delete_Click;
            // 
            // button_LoadFromFile
            // 
            button_LoadFromFile.BackColor = Color.FromArgb(255, 255, 192);
            button_LoadFromFile.FlatAppearance.BorderColor = Color.Silver;
            button_LoadFromFile.FlatStyle = FlatStyle.Flat;
            button_LoadFromFile.Location = new Point(12, 426);
            button_LoadFromFile.Name = "button_LoadFromFile";
            button_LoadFromFile.Size = new Size(260, 23);
            button_LoadFromFile.TabIndex = 5;
            button_LoadFromFile.Text = "Load From File...";
            button_LoadFromFile.UseVisualStyleBackColor = false;
            button_LoadFromFile.Click += button_LoadFromFile_Click;
            // 
            // FilterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 461);
            Controls.Add(button_LoadFromFile);
            Controls.Add(button_Delete);
            Controls.Add(button_Add);
            Controls.Add(listBox_AddedWords);
            Controls.Add(label_Enter);
            Controls.Add(richTextBox_Word);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FilterForm";
            Text = "Bad word filter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox_Word;
        private Label label_Enter;
        private ListBox listBox_AddedWords;
        private Button button_Add;
        private Button button_Delete;
        private Button button_LoadFromFile;
    }
}