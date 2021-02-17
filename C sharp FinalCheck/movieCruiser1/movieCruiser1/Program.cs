using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Cognizant.MovieCruiser.Model;
using Com.Cognizant.MovieCruiser.Dao;

namespace Moviecruiser
{
    class MovieCollection
    {
        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            List<Movie> movielist = new List<Movie>();
            List<Movie> favorites = new List<Movie>();
            favorites.Add(new Movie(1, "Avatar", "$2,787,965,087", "Yes", "15/03/2017", "Science Fiction", "Yes"));

            Admin admin = new Admin();
            Customer customer = new Customer();
            Dictionary<int, Customer> customerlist = new Dictionary<int, Customer>()
            {
                {1,new Customer(1,"Sahitya") },
                {2,new Customer(2,"Doris") },
                {3,new Customer(3,"Sai") },
                 {4,new Customer(4,"Bhavya") },
                  {5,new Customer(5,"Mahitha") },
            };
            Console.WriteLine("Welcome to Movie crusier");
            Console.WriteLine("If you are an admin,enter 1.If you are an Custome enter 2");
            int Usertype = Convert.ToInt32(Console.ReadLine());
            if (Usertype == 1)
            {
                Console.WriteLine("Enter Your  Name");
                admin.adminName = Console.ReadLine();
                Console.WriteLine("Enter Your  Id");
                admin.adminId = Console.ReadLine();

                if (admin.adminName == "Sahitya" && admin.adminId == "Madala")
                {
                    int flag = 1;
                    Console.WriteLine("Logged in succesfully as admin");
                    while (flag == 1)
                    {
                        Console.WriteLine("\n Enter 1 to view movielist \n Enter 2 to edit movie \n enter 0 to exit");
                        int Adminchioce = Convert.ToInt16(Console.ReadLine());
                        if (Adminchioce == 1)
                        {
                            admin.DisplayMovieListByAdmin();
                        }
                        else if (Adminchioce == 2)
                        {
                            admin.DisplayMovieListByAdmin();
                            Console.WriteLine("Enter the Id of the movie you want to edit");
                            string Titlekey = Console.ReadLine();
                            admin.EditMovie(Titlekey);
                        }
                        else if (Adminchioce == 0)
                            flag = 0;
                    }
                }
                else

                    Console.WriteLine("Wrong Credentials");

            }
            else if (Usertype == 2)
            {
                Console.WriteLine("Enter username for customer");
                customer.customerId = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("Enter name of customer");
                customer.customerName = Console.ReadLine();
                if (customer.customerId == customerlist[customer.customerId].customerId && customer.customerName == customerlist[customer.customerId].customerName)
                    {
                    int flag = 1;
                    Console.WriteLine("Logged in succesfully as customer");
                    while (flag == 1)
                    {
                        Console.WriteLine("\n Enter 1 to view movielist \n Enter 2 to add movie to favorites \n Enter 3 to  view favorites \n Enter 4 to remove from favorites");
                        int CustomerChoice = Convert.ToInt16(Console.ReadLine());
                        if (CustomerChoice == 1)
                        {
                            customer.DisplayMovieListByCustomer();
                        }
                        else if (CustomerChoice == 2)
                        {
                            customer.DisplayMovieListByCustomer();
                            Console.WriteLine("Enter the Id of the movie you want to  add to favorites");
                            int Id = Convert.ToInt16(Console.ReadLine());
                              if (Id > 3)
                              {
                               Console.WriteLine("Selected Movie Not in the list");
                               }
                              else
                            customer.AddToFavorites(Id, favorites);
                        }
                        else if (CustomerChoice == 3)
                        {
                            customer.ViewFavorites(favorites);
                        }
                        else if (CustomerChoice == 4)
                        {
                            Console.WriteLine("Enter the Id of the movie you want to  remove from favorites");
                            int n = Convert.ToInt16(Console.ReadLine());
                            customer.RemoveFavorites(n, favorites);
                        }
                    }
                }
            }
        }
    }
}


