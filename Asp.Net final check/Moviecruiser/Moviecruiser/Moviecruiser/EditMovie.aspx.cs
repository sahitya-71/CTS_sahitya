using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Com.Cognizant.Moviecruiser.Dao;
using Com.Cognizant.MovieCruiser.Utility;
using Com.Cognizant.MovieCruiser.Model;

namespace Moviecruiser
{
    public partial class WebForm3 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    MovieDaoCollection movieDaoCollection = new MovieDaoCollection();
                    MovieDaoCollection.ListOfMovies();
                    int id = Convert.ToByte(Request.QueryString["id"].ToString());
                    Movie obj = (from x in MovieDaoCollection.movielist
                                 where x.Id == id
                                 select x).FirstOrDefault();
                    if (obj != null)
                    {
                        TxtTitle.Text = obj.Title;
                        TxtGross.Text = obj.BoxOffice;
                        TxtDate.Text = obj.DateOfLaunch.ToString();
                        if (obj.Active == "Yes")
                        {
                            Radioyes.Checked = true;
                        }
                        else
                            Radiono.Checked = true;
                        if (obj.HasTeaser == "Yes")
                            ChkHasTeaser.Checked = true;
                        else
                            ChkHasTeaser.Checked = false;




                        MovieDaoCollection.movielist.Where(w => w.Id == id).ToList().ForEach(i => TxtTitle.Text = obj.Title);
                    }
                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MovieDaoCollection.ListOfMovies();
            int id = Convert.ToByte(Request.QueryString["id"].ToString());
            MovieDaoCollection.movielist.Where(w=>w.Id==id).ToList().ForEach(i=>
            {
               
                i.Title = TxtTitle.Text;
                i.BoxOffice = TxtGross.Text;
                if (Radioyes.Checked)
                {
                    i.Active = "Yes";
                }
                else
                {
                    i.Active = "No";
                }
                i.DateOfLaunch = DateUtility.ConvertToDate(TxtDate.Text);
                i.Genre = DropDownGenre.SelectedValue; 
                    if (ChkHasTeaser.Checked)
                    {
                        i.HasTeaser = "Yes";
                    }
                    else
                    {
                        i.HasTeaser = "No";
                    }
                
            });
            Response.Redirect("EditMovieStatus.aspx");
        }
        
      
    }

}