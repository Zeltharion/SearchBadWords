namespace SearchBadWords
{
    public partial class StatisticsForm : Form
    {
        List<Statistics> listStatistics;

        public StatisticsForm(List<Statistics> statistics)
        {
            InitializeComponent();
            this.listStatistics = listStatistics;
            dataGridView_Statistics.DataSource = listStatistics;
            /*dataGridView_Statistics.Columns["Id"].Visible = false;*/
        }

        private void button_Top_Click(object sender, EventArgs e)
        {
            TopWordsForm topWordsForm = new TopWordsForm();
            topWordsForm.Show();
        }
    }
}
