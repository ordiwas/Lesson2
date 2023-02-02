using System;

namespace movieStore
{
    class movie
    {
        private int _Id;
        private string _Title;
        private string _Director;
        public string GetFullMovie()
        {
            return _Title + " by " + _Director;
        }
        public int GetId()
        {
            return _Id;
        }

        public void SetId(int identification)
        {
            _Id = identification;
        }

        public void SetTitle(string name)
        {
            _Title = name;
        }

        public void SetDirector(string director)
        {
            _Director = director;
        }
        public movie()
        {
            _Id = 0;
            _Title = "";
            _Director = "";
        }
        public movie(int id, string title, string producer)
        {
            _Id = id;
            _Title = title;
            _Director = producer;
        }
    }
    class myStore
    {
        static void Main(string[] args)
        {
            movie id30 = new movie();
            id30.SetId(30);
            id30.SetTitle("IronMan");
            id30.SetDirector("Jon Favreau");

            movie id20 = new movie();
            Console.WriteLine("Please enter the movie ID: ");
            id20.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the title name: ");
            id20.SetTitle(Console.ReadLine());
            Console.WriteLine("Please enter the director name: ");
            id20.SetDirector(Console.ReadLine());

            movie id10 = new movie(10, "The Batman", "Matt Reeves");

            Console.WriteLine("Please enter the movie ID: ");
            int tempID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the title name: ");
            string tempTitleName = Console.ReadLine();
            Console.WriteLine("Please enter the director name: ");
            string tempDirectorName = Console.ReadLine();
            movie id40 = new movie(tempID, tempTitleName, tempDirectorName);

            displayMovies(id20);
            displayMovies(id30);
            displayMovies(id10);
            displayMovies(id40);
            Console.ReadLine();
        }
        static void displayMovies(movie id)
        {
            Console.WriteLine("Here's your movie information");
            Console.WriteLine($"Movie ID: {id.GetId()}");
            Console.WriteLine($"Movie Name: {id.GetFullMovie()}");
        }

    }
}