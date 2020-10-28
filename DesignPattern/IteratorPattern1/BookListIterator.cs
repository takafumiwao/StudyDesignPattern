using System;
namespace DesignPattern.IteratorPattern1
{
    public class BookListIterator: ITerator
    {
        private BookList bookList;
        private int index;


        public BookListIterator(BookList bookList)
        {
            this.bookList = bookList;
            this.index = 0;
        }

        public bool HasNext()
        {
            if (bookList.GetLastNum() > index)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Book Next()
        {
            Book b = bookList.GetBook(index);
            index++;

            return b;
        }
    }
}
