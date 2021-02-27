using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Com.Cognizant.Moviecruiser.Dao;
using Com.Cognizant.MovieCruiser.Model;

namespace Moviecruiser
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MovieDaoCollection movieDaoCollection = new MovieDaoCollection();
            MovieDaoCollection.ListOfMovies();
            GridCust.DataSource = MovieDaoCollection.movielist;
            GridCust.DataBind();
             if (Request.QueryString["id"]!=null)
            {
                FavoritesDaoCollection favoritesDao = new FavoritesDaoCollection();
                FavoritesDaoCollection.FavoritesListInitialization();
                int id = Convert.ToInt32(Request.QueryString["id"].ToString());
                Movie obj = (from x in MovieDaoCollection.movielist
                             where x.Id == id
                             select x).FirstOrDefault();
                if (obj != null)
                {
                    if (!FavoritesDaoCollection.favoritesmovielist.Contains(obj))
                    {
                        FavoritesDaoCollection.favoritesmovielist.Add(obj);
                    }
                    Boolean ShowPanel = Convert.ToBoolean(Request.QueryString["showpanel"].ToString());
                    if (ShowPanel)
                    {
                        notification.Visible = true;
                    }
                }
            }
        }

      
    }
}