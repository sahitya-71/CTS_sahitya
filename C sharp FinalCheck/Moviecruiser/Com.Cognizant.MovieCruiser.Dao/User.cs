using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Cognizant.MovieCruiser.Model;

namespace Com.Cognizant.MovieCruiser.Dao
{
    abstract public  class User
    {
        public List<Movie> movielist = new List<Movie>()
                {
                   new Movie(1,"Avatar","$2,787,965,087","Yes","15/03/2017","Science Fiction","Yes"),
                    new Movie(2,"The Avengers","$1,518,812,988","Yes","23/12/2017","Superhero","No"),
                    new Movie(3,"Titanic","$2,187,463,944","Yes","21/08/2017","Romance","No"),
                    new Movie(4,"Jurassic World","$1,617,713,208","No","02/07/2017","Science Fiction","Yes"),
                    new Movie(5,"Avengers","$2,750,760,348","Yes","02/11/2022","Superhero","Yes"),
            };
        abstract public List<Movie> GetMovieList();
    }
      public class Admin:User
    {
        string AdminId;
        public string adminId
        {
            get
            {
                return AdminId;
            }
            set
            {
                AdminId = value;
            }
        }
        string AdminName;
        public string adminName
        {
            get
            {
                return AdminName;
            }
            set
            {
                AdminName = value;
            }
        }
        public override List<Movie> GetMovieList()
        {
            return movielist;
        }

        public void DisplayMovieListByAdmin()
        {
            movielist = GetMovieList();
            int i = 1;
            Console.WriteLine(" Id     Title             BoxOffice        Active       DateOfLaunch        Genre          HasTeaser");

            foreach (Movie temp in movielist)
            {
                Console.WriteLine("{0,3}   {1,-18} {2,-6}    {3,-14} {4}    {5,-15}     {6}", i, temp.title, temp.boxoffice, temp.active, temp.dateOfLaunch, temp.genre, temp.hasTeaser);
                i++;
            }
           
        }
        public void EditMovie(string tiTle)
        {
            movielist = GetMovieList();
            foreach (Movie temp in movielist)
            {
                if (temp.title == tiTle)
                {
                    Console.WriteLine("Enter title");
                    temp.title = Console.ReadLine();
                    //Console.WriteLine("Enter Boxoffice");
                    //temp.boxoffice = Console.ReadLine();
                    Console.WriteLine("Enter Active");
                    temp.active = Console.ReadLine();
                    Console.WriteLine("Enter Dateoflaunch");
                    temp.dateOfLaunch = Console.ReadLine();
                    Console.WriteLine("Enter genre");
                    temp.genre = Console.ReadLine();
                    Console.WriteLine("Enter Hasteaser");
                    temp.hasTeaser = Console.ReadLine();
                    Console.WriteLine("Selected Record Updated Succesfully");
                }
            }
        }
    }
    public class Customer:User
    {
        int CustomerId;
        public int customerId
        {
            get
            {
                return CustomerId;
            }
            set
            {
                CustomerId = value;
            }
        }
        string CustomerName;
        public string customerName
        {
            get
            {
                return CustomerName;
            }
            set
            {
                CustomerName = value;
            }
        }
        public Customer() { }
        public Customer(int CustomerId,string CustomerName)
        {
            this.CustomerId = CustomerId;
            this.CustomerName = CustomerName;
        }
        //public List<Movie> movielist;
        public override List<Movie> GetMovieList()
        {
            return movielist;
        }
        public void DisplayMovieListByCustomer()
        {
            movielist = GetMovieList();
            int i = 1;
            Console.WriteLine(" Id     Title             BoxOffice            Genre           HasTeaser");
            for (int a = 0; a < movielist.Count - (2); a++)
            {
                Console.WriteLine("{0,3}   {1,-18} {2,-6}    {3,-16}     {4,-2}", i, movielist[a].title, movielist[a].boxoffice, movielist[a].genre, movielist[a].hasTeaser);
                i++;
            }
        }
        //Add to favorrites
        public void AddToFavorites(int id,List<Movie> favorites)
           
        {
            movielist = GetMovieList();
            int favId, s = 0, count = 0;
            string FavTitle;
            string FavBoxOffice;
            string FavActive;
            string FavDateOfLaunch;
            string FavGenre;
            string FavHasteaser;

            foreach (Movie temp in movielist)
            {
                count++;
                if (temp.id == id)
                {
                    foreach (Movie emp in favorites)
                    {
                        if (temp.id == emp.id)
                        {
                            s = 1;
                        }
                    }
                    if (s == 0)
                    {
                        favId = temp.id;
                        FavTitle = temp.title;
                        FavBoxOffice = temp.boxoffice;
                        FavActive = temp.active;
                        FavDateOfLaunch = temp.dateOfLaunch;
                        FavGenre = temp.genre;
                        FavHasteaser = temp.hasTeaser;
                        favorites.Add(new Movie(favId, FavTitle, FavBoxOffice, FavActive, FavDateOfLaunch, FavGenre, FavHasteaser));
                        Console.WriteLine("Movie Added to Favorites Succesfully");
                        Console.WriteLine("The movies list in favorites is");
                        ViewFavorites(favorites);
                    }
                    else
                    {
                        Console.WriteLine("The selected movie is in favorites already");
                    }
                }
            }
            if (count < id)
            {
                Console.WriteLine("Movie index out  bounds");
            }
        }
        public void ViewFavorites(List<Movie> favorites)
        {
            int i = 1;
            Console.WriteLine(" Id     Title             BoxOffice            Genre");
            foreach (Movie temp in favorites)
            {
                Console.WriteLine("{0,3}   {1,-18} {2,-6}    {3,-16}", i, temp.title, temp.boxoffice, temp.genre);
                i++;
            }
        }
        //Remove Favorites
        public void RemoveFavorites(int id, List<Movie> favorites)
        {
            if (favorites.ElementAtOrDefault(id -1) != null)
            {
                favorites.RemoveAt(id-1);
                Console.WriteLine("Movie Removed Successfully from favorites");
                ViewFavorites(favorites);
            }
            else
                Console.WriteLine("No movie found with selected id");
        }
    }
}
