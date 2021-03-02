using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Project;
using WebApplication1.ServiceReference1;
using WebApplication1.ServiceReference2;
 

namespace WebApplication1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        //public int scode;
        ServiceReference1.Service1Client s = new ServiceReference1.Service1Client();
        ServiceReference2.Service1Client s1 = new ServiceReference2.Service1Client();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["login"] = null;
            GridView1.DataSource = Store.getAproveShops();
            GridView1.DataBind();
            Button1NoDelete.Visible = false;
            ButtonDelete.Visible = false;
            ButtonSeeStore.Visible = false;
            LabelDelete.Visible = false;
            ButtonAdd.Visible = false;
            ButtonNoAdd.Visible = false;
            Label1.Visible = false;
            GridView3.DataSource = s1.GetSRate();
            GridView3.DataBind();
            if (Session["Rank"] != null)
            {
                if (Session["Rank"].ToString() == "2")
                {
                    Label1.Visible = true;
                    GridView2.DataSource = Store.getNotAproveShops();
                    GridView2.DataBind();
                }
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["Scode"] = int.Parse(GridView1.SelectedRow.Cells[4].Text);
            Session["Sname"] = GridView1.SelectedRow.Cells[1].Text.ToString();
            if (Session["Rank"] != null)
            {
                if (Session["Rank"].ToString() == "2")
                {
                    Button1NoDelete.Visible = true;
                    ButtonDelete.Visible = true;
                    ButtonSeeStore.Visible = true;
                    LabelDelete.Visible = true;

                }
                else
                {
                    Response.Redirect("Store.aspx");
                }
            }
            else
            {
                Response.Redirect("Store.aspx");
            }
            
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[4].Visible = false;
            e.Row.Cells[5].Visible = false;
            if (e.Row.RowType==DataControlRowType.Header)
            {
                e.Row.Cells[0].Text = "Coose the store";
                e.Row.Cells[1].Text = "The store";
                e.Row.Cells[2].Text = "The rate of the store";
                e.Row.Cells[3].Text = "The website of the store";
            }
            if (e.Row.RowType != DataControlRowType.Header)
            {
                string HyperLinkValue = e.Row.Cells[3].Text;
                HyperLink theLink = new HyperLink();
                theLink.NavigateUrl = HyperLinkValue;
                theLink.Text = "Link to the website of the store";
                e.Row.Cells[3].Controls.Add(theLink);
            }
            
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            int code = int.Parse(Session["Scode"].ToString());
            Store.DeleteShop(code);
        }

        protected void Button1NoDelete_Click(object sender, EventArgs e)
        {
            Button1NoDelete.Visible = false;
            ButtonDelete.Visible = false;

        }

        protected void ButtonSeeStore_Click(object sender, EventArgs e)
        {
            Response.Redirect("Store.aspx");
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["Scode"] = int.Parse(GridView2.SelectedRow.Cells[5].Text);
            Session["Sname"] = GridView2.SelectedRow.Cells[1].Text.ToString();
            ButtonAdd.Visible = true;
            ButtonNoAdd.Visible = true;
        }

        protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[5].Visible = false;
            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[0].Text = "Coose the store";
                e.Row.Cells[1].Text = "The store";
                e.Row.Cells[2].Text = "The rate of the store";
                e.Row.Cells[3].Text = "The website of the store";
                e.Row.Cells[4].Text = "Is in the website?";
            }
            if (e.Row.RowType != DataControlRowType.Header)
            {
                string HyperLinkValue = e.Row.Cells[3].Text;
                HyperLink theLink = new HyperLink();
                theLink.NavigateUrl = HyperLinkValue;
                theLink.Text = "Link to the website of the store";
                e.Row.Cells[3].Controls.Add(theLink);
            }
        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            int codee = int.Parse(Session["Scode"].ToString());
            Store.UpdateISAprove(codee);
            ButtonAdd.Visible = false;
            ButtonNoAdd.Visible = false;

        }

        protected void ButtonNoAdd_Click(object sender, EventArgs e)
        {
            int codee = int.Parse(Session["Scode"].ToString());
            Store.DeleteShop(codee);
            ButtonAdd.Visible = false;
            ButtonNoAdd.Visible = false;
        }

        protected void GridView3_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[0].Visible = false;
            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[1].Text = "Relatable rate";
            }
        }
    }
}