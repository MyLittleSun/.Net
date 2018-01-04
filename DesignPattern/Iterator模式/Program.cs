using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator模式.Interface;

namespace Iterator模式
{
    class Program
    {
        static void Main(string[] args)
        {
            BookShelf bookShelf = new BookShelf();
            bookShelf.appendBook(new Book("Around the World in 80 Days"));
            bookShelf.appendBook(new Book("Bible"));
            bookShelf.appendBook(new Book("Cinderellda"));
            bookShelf.appendBook(new Book("Daddy-Long-Leds"));
            bookShelf.appendBook(new Book("DesignPattern"));
            Iterator it = bookShelf.iterator();
            while (it.hasNext())
            {
                Book book = (Book)it.Next();
                Console.WriteLine(book.GetName());
            }
            Console.ReadKey();
        }
    }
}
