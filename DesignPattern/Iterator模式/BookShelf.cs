using System;
using System.Collections;
using Iterator模式.Interface;

namespace Iterator模式
{
    public class BookShelf : Aggregate
    {
        private ArrayList books = new ArrayList();
        public Book getBookAt (int index)
        {
            return (Book)books[index];
        }
        public void appendBook (Book book)
        {
            books.Add(book);
        }
        public int getLength ()
        {
            return books.Count;

        }
        public Iterator iterator()
        {
            return new BookShelfIterator(this);
        }
    }
}
