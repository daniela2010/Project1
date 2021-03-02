using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Project;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string pass = password.Text;
            string name = Userr.Text;
            if (SigninMethods.IsExist(name))
            {
                if (SigninMethods.getPassword(name) == pass)
                {
                    Session["Username"] = name;
                    Session["Password"] = pass;
                    Session["Rank"] = int.Parse(SigninMethods.getRankByName(name));
                    if (Session["login"] == null)
                    {
                        Response.Redirect("Home.aspx");
                    }
                    if (Session["login"].ToString() == "wish")
                    {
                        Response.Redirect("WishList.aspx");

                    }
                    if (Session["login"].ToString() == "store")
                    {
                        Response.Redirect("Addstore.aspx");

                    }
                    if (Session["login"].ToString() == "comment")
                    {
                        Response.Redirect("Addcomment.aspx");

                    }
                    if (Session["login"].ToString() == "activity")
                    {
                        Response.Redirect("UserActivity.aspx");

                    }
                }
                else
                {
                    Response.Redirect("SignIn.aspx");                   
                }
            }
            else
            {
                
                Response.Redirect("SignIn.aspx");
            }
        }
    }
}