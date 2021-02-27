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
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FavoritesDaoCollection favoritesDaoCollection = new FavoritesDaoCollection();
            FavoritesDaoCollection.FavoritesListInitialization();
            if(FavoritesDaoCollection.favoritesmovielist.Count()==0)
            {
                Response.Redirect("FavoritesEmpty.aspx");
            }
            GridFavorites.DataSource = FavoritesDaoCollection.favoritesmovielist;
            GridFavorites.DataBind();
            NofFavorites.Text = FavoritesDaoCollection.favoritesmovielist.Count().ToString();
            if (Request.QueryString["id"] != null)
            {
                FavoritesDaoCollection.FavoritesListInitialization();
                int id = Convert.ToInt32(Request.QueryString["id"].ToString());
                Movie obj = (from x in FavoritesDaoCollection.favoritesmovielist
                             where x.Id == id
                             select x).FirstOrDefault();
                if (obj != null)
                {
                    if (FavoritesDaoCollection.favoritesmovielist.Contains(obj))
                    {
                        FavoritesDaoCollection.favoritesmovielist.Remove(obj);
                        GridFavorites.DataSource = FavoritesDaoCollection.favoritesmovielist;
                        if (FavoritesDaoCollection.favoritesmovielist.Count() == 0)
                        {
                            Response.Redirect("FavoritesEmpty.aspx");
                        }
                        GridFavorites.DataBind();
                        NofFavorites.Text= FavoritesDaoCollection.favoritesmovielist.Count().ToString();
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
