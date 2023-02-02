using System;

namespace bookStore
{
    class book
    {
        private int _Id;
        private string _Title;
        private string _Author;
        private static int _Transactions = 0;
        public int GetTrans()
        {
            return _Transactions;
        }
        public string GetFullBook()
        {
            return _Title + " by " + _Author;
        }
        public int GetId()
        {
            return _Id;
        }

        public void SetId(int identification)
        {
            _Id = identification;
        }
        public void SetTrans(int num)
        {
            _Transactions = _Transactions + num;
        }

        public void SetTitle(string name)
        {
            _Title = name;
        }

        public void SetAuthor(string writer)
        {
            _Author = writer;
        }
        public book()
        {
            _Id = 0;
            _Title = "";
            _Author = "";
        }
        public book(int id, string title, string author)
        {
            _Id = id;
            _Title = title;
            _Author = author;
        }
    }
    class myStore
    {
        static void Main(string[] args)
        {
            book id30 = new book();
            id30.SetTrans(1);
            id30.SetId(30);
            id30.SetTitle("1984");
            id30.SetAuthor("George Orwell");

            book id20 = new book();
            id20.SetTrans(1);
            Console.WriteLine("Please enter the book ID: ");
            id20.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the title name: ");
            id20.SetTitle(Console.ReadLine());
            Console.WriteLine("Please enter the author name: ");
            id20.SetAuthor(Console.ReadLine());

            book id10 = new book(10, "Animal Farm", "George Orwell");
            id10.SetTrans(1);

            Console.WriteLine("Please enter the book ID: ");
            int tempID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the title name: ");
            string tempTitleName = Console.ReadLine();
            Console.WriteLine("Please enter the author name: ");
            string tempAuthorName = Console.ReadLine();
            book id40 = new book(tempID, tempTitleName, tempAuthorName);
            id40.SetTrans(1);

            Console.WriteLine($"Transactions #: {id20.GetTrans()}");
            displayBooks(id20);
            displayBooks(id30);
            displayBooks(id10);
            displayBooks(id40);
            Console.ReadLine();
        }
        static void displayBooks(book id)
        {
            Console.WriteLine("Here's your book information");
            Console.WriteLine($"Book ID: {id.GetId()}");
            Console.WriteLine($"Book Name: {id.GetFullBook()}");
        }

    }
}
