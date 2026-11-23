using System;
namespace Assignment
{ class Book
    {
        public string Title;
        public int Pages;
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            Book book1 = new Book();
            book1.Title = "C# Basics";
            book1.Pages = 464;

            object obj = book1;
            Console.WriteLine(obj);
            #endregion

            #region Q02
            Book book = new Book();
            book.Title = "C# Basics";
            book.Pages = 464;

            Console.WriteLine(book.ToString());
            Console.WriteLine(book.Equals(book));
            Console.WriteLine(book.GetHashCode());
            Console.WriteLine(book.GetType());
            #endregion

            #region Q03
            int pages3 = 464;
            Console.WriteLine(pages3);
            #endregion

            #region Q04
            try
            {
                int x = 10;
                int y = 0;
                int result = x / y;
                Console.WriteLine(result);
            }
            catch (Exception)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }
            #endregion

            #region Q05
            int pages5 = 300;
            double pagesDouble = pages5;
            Console.WriteLine(pagesDouble);
            #endregion

            #region Q06
            double price = 49.99;
            int priceInt = (int)price;
            Console.WriteLine(priceInt);
            #endregion

            #region Q07
            string pagesText7 = "464";
            int pages7 = Convert.ToInt32(pagesText7);
            Console.WriteLine(pages7);
            #endregion

            #region Q08
            string yearText = "2023";
            int year = int.Parse(yearText);
            Console.WriteLine(year);

            string badText = "abc";
            int number;
            bool ok = int.TryParse(badText, out number);
            if (ok == false)
            {
                Console.WriteLine("Invalid number");
            }
            else
            {
                Console.WriteLine(number);
            }
            #endregion

            #region Q09
            int pages9 = 464;
            string pagesText9 = pages9.ToString();
            Console.WriteLine(pagesText9);
            Console.WriteLine(pagesText9.GetType());
            #endregion

            #region Q10
            int copies = 100;
            object boxed = copies;     // Boxing
            int unboxed = (int)boxed;  // Unboxing
            Console.WriteLine(boxed);
            Console.WriteLine(unboxed);
            #endregion
        }
    }
}