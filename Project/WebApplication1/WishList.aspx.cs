using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Project;

namespace WebApplication1
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["login"] = "wish";
            Panel3.Visible = false;
            if (Session["Username"] == null)
            {
                Panel1.Visible = true;
                Panel2.Visible = false;

            }
            if (Session["Username"] != null)
            {
                Panel1.Visible = false;
                Panel2.Visible = true;
                string user = Session["Username"].ToString();
                GridView1.DataSource = WishList.getallStores(user);
                GridView1.DataBind();


            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["Scode"] = int.Parse(GridView1.SelectedRow.Cells[1].Text);
            Session["Sname"] = GridView1.SelectedRow.Cells[3].Text.ToString();
            Panel3.Visible = true;
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[1].Visible = false; //Scode
            e.Row.Cells[2].Visible = false; //Username
            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[0].Text = "Coose the store";
                e.Row.Cells[3].Text = "The store";
                e.Row.Cells[4].Text = "The rate of the store";
                e.Row.Cells[5].Text = "The website of the store";
            }
            if (e.Row.RowType != DataControlRowType.Header)
            {
                string HyperLinkValue = e.Row.Cells[5].Text;
                HyperLink theLink = new HyperLink();
                theLink.NavigateUrl = HyperLinkValue;
                theLink.Text = "Link to the website of the store";
                e.Row.Cells[5].Controls.Add(theLink);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int scode =  int.Parse(Session["Scode"].ToString());
            string name = Session["Username"].ToString();
            WishList.DeleteFromWishList(scode, name);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Store.aspx");
        }
    }
}