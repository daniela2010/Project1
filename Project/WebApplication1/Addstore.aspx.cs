using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Project;

namespace WebApplication1
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["login"] = "store";
            Label5.Visible = false;
            if (Session["Username"] != null)
            {
                Panel1.Visible = true;
                Panel2.Visible = false;

            }
            if (Session["Username"] == null)
            {
                Panel1.Visible = false;
                Panel2.Visible = true;

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Button1.Text = "1";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Button1.Text = "2";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Button1.Text = "3";
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Button1.Text = "4";
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Button1.Text = "5";
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            int rate = int.Parse(Button1.Text.ToString());
            if (Button1.Text.ToString() != "Coose a number" && TextBox1 != null)
            {
                Store.addStore(TextBox1.Text, rate, "no");
                Label5.Visible = true;
                Label5.Text = "Thank you!";
            }
        }
    }
}
