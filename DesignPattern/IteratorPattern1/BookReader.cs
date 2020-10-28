using System;
namespace DesignPattern.IteratorPattern1
{
    public class BookReader
    {
        private BookList bookList;

        public void CreateBookList()
        {
            bookList = new BookList(5);
            bookList.Add(new Book("harry potter", 1));
            bookList.Add(new Book("harry potter2", 2));
            bookList.Add(new Book("harry potter3", 3));
            bookList.Add(new Book("harry potter4", 4));
            bookList.Add(new Book("harry potter5", 5));
        }

        public void ReadBook()
        {
            ITerator itr = bookList.Iterator();

            while (itr.HasNext())
            {
                Console.WriteLine(((Book)itr.Next()).GetBookName());
            }
        }
    }
}
