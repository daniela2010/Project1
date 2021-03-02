<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Store.aspx.cs" Inherits="WebApplication1.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="LabelName" runat="server" Text="The store- " Font-Size="30px"></asp:Label>
    <br />
     <asp:Button ID="Button1" runat="server" OnClick="Button4_Click" Text="Wishlist" class="btn btn-primary btn-lg" />
    <asp:Label ID="Label1" runat="server" Text="This store is in your wish List" BorderColor="White"></asp:Label>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
<h5> Here are all the comments on the store:</h5>
            <div class="dropdown">
  <asp:Button ID="Button3" runat="server" Text="Coose a Type" class="btn btn-secondary dropdown-toggle" type="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false" OnClick="Button3_Click" Height="36px" Width="147px" />
  <div class="dropdown-menu" aria-labelledby="dropdownMenuButton">
                <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="All comments" class="dropdown-item"/>
                <asp:Button ID="Button4" runat="server" Text="Button" OnClick="Button4_Click1" class="dropdown-item"/>
                <asp:Button ID="Button5" runat="server" Text="Button" OnClick="Button5_Click" class="dropdown-item"/>
                <asp:Button ID="Button6" runat="server" Text="Button" OnClick="Button6_Click" class="dropdown-item"/>
               <asp:Button ID="Button8" runat="server" Text="Button" OnClick="Button8_Click" class="dropdown-item" />
</div>
                </div>
                
     <asp:GridView ID="GridView1" runat="server"  OnRowDataBound="GridView1_RowDataBound" BackColor="White" BorderWidth="3px" >
        </asp:GridView>
        <ul> <li> <h4>  <a href ="Addcomment.aspx" id="lconnemt">To write a comment on the store or a Questionclick me :)</a> </h4> </li></ul>
       <div class="float-left">
        <asp:GridView ID="GridView2" runat="server" OnRowDataBound="GridView2_RowDataBound" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" AutoGenerateSelectButton="True" BackColor="White" BorderWidth="4px">
    </asp:GridView>
    </div>
    <div class="float-Left">
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    <asp:GridView ID="GridView3" runat="server" class="float-left" OnRowDataBound="GridView3_RowDataBound" BackColor="White">
    </asp:GridView>
        </div>
    <br />
    <div class ="float-right">
        <asp:TextBox ID="TextBox1" runat="server" Height="31px" Width="322px">Write your answer about the comment here...</asp:TextBox>
    <br />
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" class="btn btn-primary btn-lg" Text="Send the comment" Height="32px" Width="147px" />
</div>
</asp:Content>

    