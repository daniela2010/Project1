<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WishList.aspx.cs" Inherits="WebApplication1.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<asp:Panel ID="Panel1" runat="server">
<div class="jumbotron">
  <h1 class="display-4">Hello</h1>
   
  <p class="lead">To see your wishlist you have to login first.</p>
  <hr class="my-4">
  <p>you didnt login yet... to login click the Button below.</p>
  <a class="btn btn-primary btn-lg" href="SignIn.aspx" role="button">LogIn</a>
</div>
             </asp:Panel>
         <asp:Panel ID="Panel2" runat="server">
        <h1> Wish List </h1>
        <h2> Here you will see all the stores you liked </h2>

    <asp:GridView ID="GridView1" runat="server"  AutoGenerateSelectButton="True" OnRowDataBound="GridView1_RowDataBound" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" BackColor="White" BorderColor="Black" BorderWidth="2px">
    </asp:GridView>
             <asp:Panel ID="Panel3" runat="server">
             <asp:Button ID="Button1" class="btn btn-primary btn-lg" runat="server" Text="Remove from WishList" OnClick="Button1_Click" />
                 <asp:Button ID="Button2" class="btn btn-primary btn-lg" runat="server" Text="Go to see the store" OnClick="Button2_Click" />
                 </asp:Panel>
             </asp:Panel>
</asp:Content>
