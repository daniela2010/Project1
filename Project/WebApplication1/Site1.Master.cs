using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Project;
using WebApplication1.ServiceReference1;

namespace WebApplication1
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        Service1Client s = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            Service1Client s = new Service1Client();
            Panel1.Visible = false;
            Label1.Visible = false;
            Panel2.Visible = true;
            
            if (Session["Username"] == null)
            {
                Panel1.Visible = false;
                Label1.Visible = false;
                Panel2.Visible = true;

            }
            if (Session["Username"] != null)
            {
                Panel1.Visible = true ;
                Label1.Visible = true ;
                Label1.Text = " You are now log in whith"+ " " + Session["Username"];
                Panel2.Visible = false ;
            }
            Image1.ImageUrl = "~/logo.jpg";

        }

        //protected void Button2_Click(object sender, EventArgs e)
        //{

        //}

        //protected void Button1_Click(object sender, EventArgs e)
        //{

        //}

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Label1.Visible = false;
            Panel2.Visible = true;
            Session["Username"] = null;
            Session["Password"] = null;
            Session["Rank"] = null;

        }


        protected void Button2_Click(object sender, EventArgs e)
        {
            if (s.IsExist(searchBox.Text))
            {
                Session["Sname"] = searchBox.Text;
                Session["Scode"] = s.getCodeByName(searchBox.Text);
                Response.Redirect("Store.aspx");
            }
            else
            {
                
               ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Shop not found')", true);

            }
        }
    }
}