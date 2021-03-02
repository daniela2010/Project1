<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UserActivity.aspx.cs" Inherits="WebApplication1.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:Panel ID="Panel1" runat="server">
 <div class="jumbotron">
  <h1 class="display-4">Hello</h1>
   
  <p class="lead">To see "My activity" you have to login first.</p>
  <hr class="my-4">
  <p>you didnt login yet... to login click the Button below.</p>
  <a class="btn btn-primary btn-lg" href="SignIn.aspx" role="button">LogIn</a>
</div>
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server">
        <h3> Here you will see your comments, your questions and the answers you got from other users</h3>
        <h4> The comments you wrote:</h4>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateSelectButton="True" OnRowDataBound="GridView1_RowDataBound" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" BackColor="White" BorderWidth="4px">
    </asp:GridView>
        <asp:Panel ID="PanelDelete" runat="server">
        <asp:Label ID="LabelDelete" runat="server"  Text="Are you sure you want to delete the comment:" Font-Size="15px"></asp:Label>
        <asp:Button ID="ButtonDelete" runat="server" class="btn btn-info" Text="yes" OnClick="ButtonDelete_Click" />
        <asp:Button ID="ButtonNoDelete" runat="server" class="btn btn-info" Text="No" OnClick="ButtonNoDelete_Click" />
            </asp:Panel>

    <h4> All the questions you asked:</h4>
        <div class="float-left">
    <asp:GridView ID="GridView2" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" OnRowDataBound="GridView2_RowDataBound" BackColor="White" BorderWidth="4px">
    </asp:GridView>
            </div>
        <div class="float-left">
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:GridView ID="GridView3" runat="server" OnRowDataBound="GridView3_RowDataBound" BackColor="White"></asp:GridView>
            </div>
    </asp:Panel>

</asp:Content>
