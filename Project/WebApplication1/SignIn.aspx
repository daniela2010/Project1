<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="WebApplication1.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <%--  <form id="form1" runat="server">--%>
    <style>
        
        
    </style>

  <div class="form-group">
    <label for="Username1">Username</label>
      <asp:TextBox ID="Userr"  class="form-control" runat="server"></asp:TextBox>
    

  &nbsp;</div>
  <div class="form-group">
    <label for="exampleInputPassword1">Password</label>
      <asp:TextBox ID="password"  class="form-control" runat="server"></asp:TextBox>
  </div>
        <asp:Button ID="Button1" class="btn btn-info" runat="server" Text="Submit" OnClick="Button1_Click" BackColor =" #0066cc" ForeColor ="white" />

    <a class="btn btn-info" href="SignUp.aspx" >Sign Up</a>
    
    
</asp:Content>
