using System.ComponentModel.DataAnnotations.Schema;

namespace SearchBadWords
{
    public class TopWords
    {
        public int Id { set; get; }
        public string Word { set; get; }
        public int CountWords { set; get; }

        public TopWords(string Word, int CountWords)
        {
            this.Word = Word;
            this.CountWords = CountWords;
        }
    }
}
