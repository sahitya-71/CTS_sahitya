using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.MovieCruiser.Model
{
    public class Movie
    {
        int Id;
        public int id
        {
            get
            {
                return Id;
            }
            set
            {
                Id = value;
            }
        }

        string Title;
        public string title
        {
            get
            {
                return Title;
            }
            set
            {
                Title = value;
            }
        }

        string BoxOffice;
        public string boxoffice
        {
            get
            {
                return BoxOffice;
            }
            set
            {
                boxoffice = value;
            }
        }

        string Active;
        public string active
        {
            get
            {
                return Active;
            }
            set
            {
                Active = value;
            }
        }

        string DateOfLaunch;
        public string dateOfLaunch
        {
            get
            {
                return DateOfLaunch;
            }
            set
            {
                DateOfLaunch = value;
            }
        }

        string Genre;
        public string genre
        {
            get
            {
                return Genre;
            }
            set
            {
                Genre = value;
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
            this.BoxOffice = BoxOffice;
            this.Active = Active;
            this.DateOfLaunch = DateOfLaunch;
            this.Genre = Genre;
            this.HasTeaser = HasTeaser;
        }
       
    }
}
