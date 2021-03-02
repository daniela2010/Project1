using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Project;
using WebApplication1.ServiceReference2;

namespace WebApplication1
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        int Tcode;
        ServiceReference2.Service1Client s1 = new ServiceReference2.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            Button10.Visible = false;
            Button11.Visible = false;
            Button12.Visible = false;

            Session["login"] = "comment";
            if (Session["Username"] == null)
            {
                Panel1.Visible = true;
                Panel2.Visible = false;

            }
            if(Session["Sname"]!=null)
            {
                string n = Session["Sname"].ToString();
                Label3.Text = "Add comment on the store:" + Session["Sname"].ToString();
                Label4.Text = "to add a question on the store: " + Session["Sname"].ToString();

            }
            if(Session["Scode"] !=null)
            {
                int code = int.Parse(Session["Scode"].ToString());
                int numofTypes = Typee.GetTypeAmount();
                int howmany = 0;
                for (int i = 1; i < numofTypes + 1; i++)
                {
                    if (TypeStore.IsExist(i, code))
                    {
                        howmany++;
                        string typee = Typee.getNameByCode(i);
                        if (howmany == 1)
                        {
                            Button10.Text = typee;
                            Button10.Visible = true;
                            Tcode = int.Parse(Typee.getCodeByname(Button10.Text.ToString()));

                        }
                        if (howmany == 2)
                        {
                            Button11.Text = typee;
                            Button11.Visible = true;
                            Tcode = int.Parse(Typee.getCodeByname(Button11.Text.ToString()));


                        }
                        if (howmany == 3)
                        {
                            Button12.Text = typee;
                            Button12.Visible = true;
                            Tcode = int.Parse(Typee.getCodeByname(Button12.Text.ToString()));

                        }
                    }
                    i++;
                }
            }
            if (Session["Username"] != null)
            {
                Panel1.Visible = false;
                Panel2.Visible = true;
                

            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button6.Text = "1";

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Button6.Text = "2";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Button6.Text = "3";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Button6.Text = "4";
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Button6.Text = "5";
        }

        protected void Button6_Click(object sender, EventArgs e)
        {

        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            int rate = int.Parse(Button6.Text.ToString());
            int code = int.Parse(Session["Scode"].ToString());
            string user = Session["Username"].ToString();
            DateTime d = DateTime.Today;
            string sd = d.ToString(("yyyy,MM,dd"));
            StoreComment.addComment(code, user, rate, TextBox1.Text,Tcode, sd);
            int Srate = StoreComment.getAVGRate(code) ;
            Srate += Convert.ToInt32((s1.GetRate(code) / (StoreComment.Getnumofcommments(code) + 1)));
            Store.Updateate(code, Srate);

        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            int code = int.Parse(Session["Scode"].ToString());
            string user = Session["Username"].ToString();
            DateTime d = DateTime.Today;
            string sd = d.ToString(("yyyy,MM,dd"));
            Quser.addQuestion(user, sd, TextBox2.Text, code);
            
        }

        protected void Button9_Click(object sender, EventArgs e)
        {

        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Tcode = int.Parse(Typee.getCodeByname(Button10.Text.ToString()));
            Button9.Text = Button10.Text;
            
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            Tcode = int.Parse(Typee.getCodeByname(Button11.Text.ToString()));
            Button9.Text = Button11.Text;

        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            Tcode = int.Parse(Typee.getCodeByname(Button12.Text.ToString()));
            Button9.Text = Button12.Text;

        }
    }
}