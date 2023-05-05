using System.ComponentModel.DataAnnotations.Schema;

namespace SearchBadWords
{
    public class Statistics
    {
        public int Id { get; set; }
        public string Word { set; get; }
        public string PathOfFile { set; get; }
        public int Size { set; get; }
        public int NumOfWordFound { set; get; }
        public int NumOfReplacedWord { set; get; }

        public Statistics(string Word, string PathOfFile, int Size, int NumOfWordFound, int NumOfReplacedWord)
        {
            this.Word = Word;
            this.PathOfFile = PathOfFile;
            this.Size = Size;
            this.NumOfWordFound = NumOfWordFound;
            this.NumOfReplacedWord = NumOfReplacedWord;
        }
    }
}
