<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="AdminLogin.aspx.cs" Inherits="AdminLogin" %>

<asp:Content ID="h" ContentPlaceHolderID="heading" runat="server">
    Admin Login

</asp:Content>
<asp:Content ID="body" ContentPlaceHolderID="body" runat="server">
    <center>
    <table width="60%">
        <tr><td style="padding:10px;text-align: -webkit-center;">
            <asp:TextBox ID="id" class="form-control" Width="60%" required="required" Placeholder="Admin ID" runat="server"></asp:TextBox></td></tr>
        <tr><td><br /></td></tr>
        <tr><td  style="padding:10px;text-align: -webkit-center;">
            <asp:TextBox ID="pass" class="form-control" Width="60%" required="required" Placeholder="Password" runat="server" TextMode="Password"></asp:TextBox></td></tr>
        <tr><td><br /></td></tr>
        <tr><td  style="padding:10px;text-align: -webkit-center;">
            <asp:Button ID="Button1" class="btn btn-skin" runat="server" Text="Login" OnClick="Button1_Click" /></td></tr>
         <tr><td><br /></td></tr>
       
    </table>
         </center>
</asp:Content>
