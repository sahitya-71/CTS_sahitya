using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Com.Cognizant.Moviecruiser.Dao;

namespace Moviecruiser
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                MovieDaoCollection movieDaoCollection = new MovieDaoCollection();
            MovieDaoCollection.ListOfMovies();
                GridAdmin.DataSource = MovieDaoCollection.movielist;
                GridAdmin.DataBind();


            }

        }
    }
