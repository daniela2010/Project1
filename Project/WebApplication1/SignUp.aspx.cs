﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Project;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["Username"] != null)
            {

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Password = password.Text;
            string username = UserName.Text;
            string Firstname = FirstName.Text;
            string Lastname = LastName.Text;
            int rank = 1;
            if (SigninMethods.IsExist(username) == false)
            {
                Session["Username"] = username;
                Session["Password"] = Password;
                Session["Rank"] = rank;
                Session["Firstname"] = Firstname;
                Session["Lastname"] = Lastname;
                SigninMethods.addUser(username, Password, rank, Firstname, Lastname);
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
            //    Response.Redirect("WebForm3.aspx");
            //}
            //else
            //{
                
                
            //    Response.Redirect("WebForm2.aspx");
            //}
        }
    }
}