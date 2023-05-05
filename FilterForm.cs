namespace SearchBadWords
{
    public partial class FilterForm : Form
    {
        List<string> words = null;
        public FilterForm(List<string> w)
        {
            InitializeComponent();
            words = w;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox_Word.Text))
            {
                listBox_AddedWords.Items.Add(richTextBox_Word.Text);
                words.Add(richTextBox_Word.Text);
                richTextBox_Word.Text = "";
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (listBox_AddedWords.SelectedIndex != -1)
            {
                words.RemoveAt(listBox_AddedWords.SelectedIndex);
                listBox_AddedWords.Items.RemoveAt(listBox_AddedWords.SelectedIndex);
            }
        }

        private async void button_LoadFromFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog of = new OpenFileDialog())
            {
                of.Filter = "(*.txt)|*.txt";
                if (of.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader reader = new StreamReader(of.FileName))
                    {
                        while (reader.Read() > 0)
                        {
                            string word = await reader.ReadLineAsync();
                            if (word != "")
                            {
                                listBox_AddedWords.Items.Add(word);
                                words.Add(word);
                            }
                        }
                    }
                }
            }
        }
    }
}
