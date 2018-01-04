using Iterator模式.Interface;

namespace Iterator模式
{
    public class BookShelfIterator : Iterator
    {
        private BookShelf bookShelf;
        private int index;
        public BookShelfIterator(BookShelf bookShelf)
        {
            this.bookShelf = bookShelf;
            this.index = 0;
        }
        public bool hasNext()
        {
            return bookShelf.getLength() > index;
        }
        public object Next ()
        {
            return bookShelf.getBookAt(index++);
        }
    }
}
