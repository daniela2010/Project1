

<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Addcomment.aspx.cs" Inherits="WebApplication1.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server">
        <div class="jumbotron">
  <h1 class="display-4">Hello</h1>
   
  <p class="lead">To Add a comment you have to login first.</p>
  <hr class="my-4">
  <p>you didnt login yet... to login click the Button below.</p>
  <a class="btn btn-primary btn-lg" href="SignIn.aspx" role="button">LogIn</a>
</div>

    </asp:Panel>


    <asp:Panel ID="Panel2" runat="server">
        
      
        <asp:Label ID="Label3" runat="server" Text="Add comment on the store:" Font-Size =" 16"></asp:Label>
       <br />
       <asp:Label ID="Label1" runat="server" Text="Here you should write your comment:"></asp:Label> <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" Height="50px" Width="289px"></asp:TextBox>
        
       <br />
         <asp:Label ID="Label2" runat="server" Text="Choose how you rate the store between 1-5"></asp:Label>
       <div class="dropdown">
  <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Coose rate" class="btn btn-secondary dropdown-toggle" type="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false" />
  <div class="dropdown-menu" aria-labelledby="dropdownMenuButton">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="1" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="2" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="3" />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="4" />
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="5" />
       </div>
           </div>
        <div class="dropdown">
        <asp:Button ID="Button9" runat="server" Text="Coose the Type" OnClick="Button9_Click" class="btn btn-secondary dropdown-toggle" type="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false" />
        <div class="dropdown-menu" aria-labelledby="dropdownMenuButton">
            <asp:Button ID="Button10" runat="server" Text="Button" OnClick="Button10_Click" />
        <asp:Button ID="Button11" runat="server" Text="Button" OnClick="Button11_Click" />
        <asp:Button ID="Button12" runat="server" Text="Button" OnClick="Button12_Click" />
        <br />
            </div>
            </div>
        <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Add the comment" Height="38px" Width="178px" class="btn btn-info" />
        <br />
        <asp:Label ID="Label4" runat="server" Text="to add a question on the store: " Font-Size =" 16"></asp:Label>
        <h3> Write your question here: </h3>
        <asp:TextBox ID="TextBox2" runat="server" Height="29px" Width="247px"></asp:TextBox>
        <br />
        <asp:Button ID="Button8" runat="server" class="btn btn-info" Text="Add the question" Height="37px" Width="171px" OnClick="Button8_Click" />
        </asp:Panel>
        
        <a class="navbar-brand" href="Store.aspx">To Go Back to the store click me</a>
</asp:Content>


