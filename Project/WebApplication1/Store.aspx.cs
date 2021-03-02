using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Project;

namespace WebApplication1
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Another"] = "1";
            if(Session["Scode"] != null)
            {
                int code = int.Parse(Session["Scode"].ToString());
                
                    Label3.Text = "The types in the store are: ";
            
                GridView1.DataSource = StoreComment.getByShopCode(code);
                GridView1.DataBind();
                GridView2.DataSource = Quser.getByScode(code);
                GridView2.DataBind();
                Button4.Visible = false;
                Button5.Visible = false;
                Button6.Visible = false;
                Button8.Visible = false;
                int numofTypes = Typee.GetTypeAmount();
                int howmany = 0;
                for (int i = 1; i < numofTypes+3; i++)
                {
                    if(TypeStore.IsExist(i, code))
                    {
                        howmany++;
                        string typee = Typee.getNameByCode(i);
                        Label3.Text += typee + " ";
                        if(howmany == 1)
                        {
                            Button4.Text = typee;
                            Button4.Visible = true;

                        }
                        if (howmany == 2)
                        {
                            Button5.Text = typee;
                            Button5.Visible = true;

                        }
                        if (howmany ==3)
                        {
                            Button6.Text = typee;
                            Button6.Visible = true;
                        }
                        if (howmany == 4)
                        {
                            Button8.Text = typee;
                            Button8.Visible = true;
                        }
                    }
                    i++;
                }
            }
 
            Label2.Visible = false;
            TextBox1.Visible = false;
            Button2.Visible = false;
          
            if (Session["Sname"] != null)
            {
                LabelName.Text = "The store- " + Session["Sname"].ToString();
            }
            if (Session["Username"] == null)
            {
                Button1.Visible = false;
                Label1.Visible = false;

            }
            if (Session["Username"] != null)
            {
                int code = int.Parse(Session["Scode"].ToString());
                string name = Session["Username"].ToString();
                if (WishList.IsExist(code, name) == false)
                {
                    Button1.Visible = true;
                    Label1.Visible = false;

                }
                if (WishList.IsExist(code, name))
                {
                    Button1.Visible = false;
                    Label1.Visible = true;

                }
            }

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int code = int.Parse(Session["Scode"].ToString());
            string UserName = Session["Username"].ToString();
            WishList.AddWishList(code, UserName);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int q = int.Parse(Session["Qcode"].ToString());
            string user = Session["Username"].ToString();
            Qcomment.addQComment(q, user, TextBox1.Text);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }

        protected void Button4_Click1(object sender, EventArgs e)
        {
            int code = int.Parse(Session["Scode"].ToString()) ;
            int Tcode = int.Parse(Typee.getCodeByname(Button4.Text));
            GridView1.DataSource = StoreComment.getByShopType(code, Tcode);
            GridView1.DataBind();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            int code = int.Parse(Session["Scode"].ToString());
            int Tcode = int.Parse(Typee.getCodeByname(Button5.Text));
            GridView1.DataSource = StoreComment.getByShopType(code, Tcode);
            GridView1.DataBind();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            int code = int.Parse(Session["Scode"].ToString());
            int Tcode = int.Parse(Typee.getCodeByname(Button6.Text));
            GridView1.DataSource = StoreComment.getByShopType(code, Tcode);
            GridView1.DataBind();
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            int code = int.Parse(Session["Scode"].ToString());
            GridView1.DataSource = StoreComment.getByShopCode(code);
            GridView1.DataBind();
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[0].Visible = false; //the store
            e.Row.Cells[5].Visible = false; //Ccode
            e.Row.Cells[4].Text = e.Row.Cells[7].Text;
            e.Row.Cells[7].Visible = false; //Description


            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[1].Text = "User that wrote the comment";
                e.Row.Cells[2].Text = "The rate he gave";
                e.Row.Cells[3].Text = "The comment";
                e.Row.Cells[4].Text = "The type";
                e.Row.Cells[6].Text = "The date";

            }
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["Qcode"] = GridView2.SelectedRow.Cells[5].Text;
            int qcode = int.Parse(GridView2.SelectedRow.Cells[5].Text.ToString());
            GridView3.DataSource = Qcomment.getByQcode(qcode);
            GridView3.DataBind();
            Label2.Visible = true;
            TextBox1.Visible = true;
            Button2.Visible = true;
            Label2.Text = "you choose the Question of " + GridView2.SelectedRow.Cells[1].Text + "-" + GridView2.SelectedRow.Cells[3].Text;
        }

        protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[5].Visible = false;
            e.Row.Cells[4].Visible = false;

            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[0].Text = "Select to comment";
                e.Row.Cells[1].Text = "The User name";
                e.Row.Cells[2].Text = "Date";
                e.Row.Cells[3].Text = "The Question";
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

        protected void Button8_Click(object sender, EventArgs e)
        {
            int code = int.Parse(Session["Scode"].ToString());
            int Tcode = int.Parse(Typee.getCodeByname(Button8.Text));
            GridView1.DataSource = StoreComment.getByShopType(code, Tcode);
            GridView1.DataBind();
        }

        //protected void Button1_Click(object sender, EventArgs e)
        //{

        //}

        //protected void TextBox1_TextChanged(object sender, EventArgs e)
        //{
        //    TextBox1.Text = "";
        //}
    }
}
