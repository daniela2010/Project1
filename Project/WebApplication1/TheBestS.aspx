<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="TheBestS.aspx.cs" Inherits="WebApplication1.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3> Here are the top 3 stores:</h3>

    <asp:Label ID="Top1" runat="server" Text="Number 1:" Font-Size ="20px"></asp:Label>

    <asp:Label ID="Top2" runat="server" Text="Number 2:" Font-Size ="20px"></asp:Label>
    <asp:Label ID="Top3" runat="server" Text="Number 3:" Font-Size ="20px"></asp:Label>

</asp:Content>
