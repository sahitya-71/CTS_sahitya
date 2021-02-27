using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.MovieCruiser.Model
{
    public class Movie
    {
        int id;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        string title;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        string boxOffice;
        public string Boxoffice
        {
            get
            {
                return boxOffice;
            }
            set
            {
                boxOffice = value;
            }
        }

        string active;
        public string Active
        {
            get
            {
                return active;
            }
            set
            {
                active = value;
            }
        }

        string dateOfLaunch;
        public string DateOfLaunch
        {
            get
            {
                return dateOfLaunch;
            }
            set
            {
                dateOfLaunch = value;
            }
        }

        string genre;
        public string Genre
        {
            get
            {
                return genre;
            }
            set
            {
                genre = value;
            }
        }

        string HasTeaser;
        public string hasTeaser
        {
            get
            {
                return HasTeaser;
            }
            set
            {
                HasTeaser = value;
            }
        }

        //Default constructor
        public Movie() { }
        //full parameterised constructor
        public Movie(int Id, string Title, string BoxOffice, string Active, string DateOfLaunch, string Genre, string HasTeaser)
        {
            this.Id = Id;
            this.Title = Title;
            this.Boxoffice = Boxoffice;
            this.Active = Active;
            this.DateOfLaunch = DateOfLaunch;
            this.Genre = Genre;
            this.HasTeaser = HasTeaser;
        }
       
    }
}
