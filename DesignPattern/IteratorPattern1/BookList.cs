namespace DesignPattern.IteratorPattern1
{
    
    public class BookList: IAggregate
    {
        protected Book[] books;
        private int last = 0;

        public BookList(int bookCount)
        {
            this.books = new Book[bookCount];
        }

        public void Add(Book book)
        {
            books[last] = book;
            last++;
        }

        public Book GetBook(int index)
        {
            return books[index];
        }

        public int GetLastNum()
        {
            return last;
        }

        public ITerator Iterator()
        {
            return new BookListIterator(this);
        }
    }
}
