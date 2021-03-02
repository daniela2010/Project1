<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApplication1.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="float-left">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowDataBound="GridView1_RowDataBound" BackColor="White" BorderWidth="4px">
    </asp:GridView>
         <br />
         <asp:Label ID="Label1" runat="server" Text="The stores people suggest to add: " Font-Size="20px"></asp:Label>
    <asp:GridView ID="GridView2" runat="server" AutoGenerateSelectButton="True" OnRowDataBound="GridView2_RowDataBound" OnSelectedIndexChanged="GridView2_SelectedIndexChanged"></asp:GridView>
        </div>
    <div class="float-left">
    <asp:GridView ID="GridView3" runat="server" BackColor="White" BorderWidth="4px" OnRowDataBound="GridView3_RowDataBound">
    </asp:GridView>
        </div>
    <div class="float-left">
    <h5> If you want to request a new store click the button below:</h5>
      <a class="btn btn-secondary" href="Addstore.aspx" role="button">Add Store</a>
        </div>
    
        <asp:Label ID="LabelDelete" runat="server" Text="Do you want to delete the store?"></asp:Label>
        <asp:Button ID="ButtonDelete" runat="server" class="btn btn-info" Text="Yes" OnClick="ButtonDelete_Click" />
        <asp:Button ID="Button1NoDelete" runat="server" class="btn btn-info" Text="no" OnClick="Button1NoDelete_Click" />
        <br />
        <asp:Button ID="ButtonSeeStore" runat="server" class="btn btn-secondary dropdown-toggle" Text="Click to see the store" OnClick="ButtonSeeStore_Click" Height="32px" Width="175px" />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />

             <div class="float-left">
    <asp:Button ID="ButtonAdd" runat="server" class="btn btn-secondary" Text="Add the store" OnClick="ButtonAdd_Click" />
    <asp:Button ID="ButtonNoAdd" runat="server" class="btn btn-secondary" Text="Delete the store" OnClick="ButtonNoAdd_Click"/>
             </div>
    </asp:Content>
