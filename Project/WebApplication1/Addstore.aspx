<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Addstore.aspx.cs" Inherits="WebApplication1.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <style>
            lable4{
                position: absolute;
                 top: 0; 
                 right: 0;
            }
        </style>

    <asp:Panel ID="Panel1" runat="server">
        
        
        <asp:Label ID="Label1" runat="server" Text="Enter the name of the store"></asp:Label> 
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Rate the store:"></asp:Label>
        <div class="dropdown">
  <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Coose rate" class="btn btn-secondary dropdown-toggle" type="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false" />
  <div class="dropdown-menu" aria-labelledby="dropdownMenuButton">
      <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="1" class="dropdown-item" />
      <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="2" class="dropdown-item" />
      <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="3" class="dropdown-item"/>
      <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="4" class="dropdown-item" />
      <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="5" class="dropdown-item" />

   
  </div>
</div>
   
        <asp:Button ID="Button7" runat="server" Text="Add the store" OnClick="Button7_Click" class="btn btn-info"/>
   <br />
         
        </asp:Panel>
        <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
    <asp:Panel ID="Panel2" runat="server">
        <div class="jumbotron">
  <h1 class="display-4">Hello</h1>
   
  <p class="lead">To Add a store you would like to see on this site you have to login first.</p>
  <hr class="my-4">
  <p>you didnt login yet... to login click the Button below.</p>
  <a class="btn btn-primary btn-lg" href="SignIn.aspx" role="button">LogIn</a>
</div>
        
    </asp:Panel>

</asp:Content>
