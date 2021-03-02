using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Project;


namespace WebApplication1
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Visible = false;
            Session["login"] = "activity";
            if (Session["Username"] != null)
            {
                Panel1.Visible = false;
                Panel2.Visible = true;
                string user = Session["Username"].ToString();
                GridView1.DataSource = StoreComment.getByUserName(user);
                GridView1.DataBind();
                GridView2.DataSource = Quser.getByUser(user);
                GridView2.DataBind();
            }
            if(Session["Username"]==null)
            {
                Panel2.Visible = false;
                Panel1.Visible = true;
                
            }
            PanelDelete.Visible = false;
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            ////e.Row.Cells[1].Visible = false; //Scode
            e.Row.Cells[2].Visible = false; //Username
            e.Row.Cells[5].Visible = false; //Stype
            e.Row.Cells[1].Text = e.Row.Cells[8].Text;
            e.Row.Cells[8].Text = e.Row.Cells[1].Text;
            e.Row.Cells[6].Visible = false; //Ccode
            e.Row.Cells[8].Visible = false; //Scode
            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[0].Text = "Select the comment";
                e.Row.Cells[1].Text = "The name of the store";
                e.Row.Cells[3].Text = "The rate";
                e.Row.Cells[4].Text = "The comment";
                e.Row.Cells[7].Text = "The date";
                e.Row.Cells[9].Text = "The Type";
            }
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["Qcode"] = GridView2.SelectedRow.Cells[5].Text;
            int qcode = int.Parse(Session["Qcode"].ToString());
            GridView3.DataSource = Qcomment.getByQcode(qcode);
            GridView3.DataBind();
            Label1.Visible = true;
            Label1.Text = "you choose the Question on " + GridView2.SelectedRow.Cells[2].Text + "-" + GridView2.SelectedRow.Cells[4].Text;
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int code = int.Parse(GridView1.SelectedRow.Cells[6].Text.ToString());
            string comment = GridView1.SelectedRow.Cells[4].Text.ToString(); /*StoreComment.getCommentByCode(code);*/
            PanelDelete.Visible = true;
            LabelDelete.Text += comment + " ";
            Session["Ccode"] = GridView1.SelectedRow.Cells[6].Text;
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            int code = int.Parse(Session["Ccode"].ToString());
            StoreComment.DeleteScomment(code);
            PanelDelete.Visible = false;
        }

        protected void ButtonNoDelete_Click(object sender, EventArgs e)
        {
            PanelDelete.Visible = false;
        }

        protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[5].Visible = false; //Qcode
            e.Row.Cells[6].Visible = false; //Storename
            e.Row.Cells[1].Visible = false; //username
            e.Row.Cells[2].Text = e.Row.Cells[6].Text;
            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[0].Text = "Select the Question";
                e.Row.Cells[2].Text = "The store";
                e.Row.Cells[3].Text = "The date";
                e.Row.Cells[4].Text = "The Question";
                
            }
        }

        protected void GridView3_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[0].Visible = false;
            e.Row.Cells[3].Visible = false;

            if (e.Row.RowType == DataControlRowType.Header)
            {

                e.Row.Cells[1].Text = "The User name";
                e.Row.Cells[2].Text = "The comment";

            }
        }
    }
}