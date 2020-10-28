namespace DesignPattern.IteratorPattern1
{
    public class Book
    {
        private readonly string bookName;
        private readonly int page;

        public Book(string bookName, int page)
        {
            // コンストラクタ
            this.bookName = bookName;
            this.page = page;
        }

        public string GetBookName()
        {
            return bookName;
        }

        public int GetPage()
        {
            return page;
        }
    }
}
