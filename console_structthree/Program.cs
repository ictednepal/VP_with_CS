using System;

namespace console_structthree
{
    struct Book{
        public string title;
        public float price;
        public int pages;

        public void setData(string tt, float pr, int pg){
            title = tt;
            price = pr;
            pages = pg;
        }
        public void display(){
            Console.WriteLine("Title = {0}",title);
            Console.WriteLine("Price = {0}",price);
            Console.WriteLine("Pages = {0}",pages);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();
            Book b2 = new Book();
            b1.setData("The Old Man and The Sea",23.45F,89);
            b2.setData("The Alchemist",92.34F,102);
            b1.display();
            b2.display();
        }
    }
}
