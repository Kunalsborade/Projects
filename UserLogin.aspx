<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="UserLogin.aspx.cs" Inherits="UserLogin" %>


<asp:Content ID="h" ContentPlaceHolderID="heading" runat="server">
    User Login

</asp:Content>
<asp:Content ID="body" ContentPlaceHolderID="body" runat="server">
    <center>
    <table width="60%">
        <tr><td style="padding:10px;text-align: -webkit-center;">
            <asp:TextBox ID="id" class="form-control" Width="60%" required="required" Placeholder="User ID" runat="server"></asp:TextBox></td></tr>
        <tr><td><br /></td></tr>
        <tr><td  style="padding:10px;text-align: -webkit-center;">
            <asp:TextBox ID="pass" class="form-control" Width="60%" required="required" Placeholder="Password" runat="server" TextMode="Password"></asp:TextBox></td></tr>
        <tr><td><br /></td></tr>
        <tr><td  style="padding:10px;text-align: -webkit-center;">
            <asp:Button ID="Button1" class="btn btn-skin" runat="server" Text="Login" OnClick="Button1_Click" /></td></tr>
         <tr><td><br /></td></tr>
        <tr><td style="padding:10px;text-align: -webkit-center;">Not a Member ? <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Register.aspx">Sign In</asp:LinkButton></td></tr>
        <tr><td><br /></td></tr>
       
    </table>
         </center>
</asp:Content>
