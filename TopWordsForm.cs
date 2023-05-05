using ApplicationContext = SearchBadWords.Model.ApplicationContext;

namespace SearchBadWords
{
    public partial class TopWordsForm : Form
    {
        ApplicationContext db = new();
        public TopWordsForm()
        {
            InitializeComponent();

            dataGridView_TopWords.DataSource = db.TopWords.GroupBy(a => a.Word)
                .Select(a => new
                {
                    word = a.Key,
                    sumWords = a.Sum(ab=>ab.CountWords)
                }).OrderByDescending(s=>s.sumWords).ToList();

        }
    }
}
