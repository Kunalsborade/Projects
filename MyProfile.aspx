<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="MyProfile.aspx.cs" Inherits="MyProfile" %>

<asp:Content ID="h" ContentPlaceHolderID="heading" runat="server">
    My Profile

</asp:Content>
<asp:Content ID="body" ContentPlaceHolderID="body" runat="server">

    <div>
       <table width="80%">
           <tr><td class="lab">
               <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label></td><td class="txt">
                   <asp:TextBox ID="name" runat="server" CssClass="form-control" ReadOnly="True" Width="60%"></asp:TextBox>
               </td></tr>
           <tr><td colspan="2"><br /></td></tr>
           <tr><td class="lab">
               <asp:Label ID="Label2" runat="server" Text="Mobile Number"></asp:Label></td><td class="txt">
                   <asp:TextBox ID="mobile" runat="server" CssClass="form-control" required="required" Width="60%" ReadOnly="True"></asp:TextBox>
               </td></tr>
           <tr><td></td><td class="txt"><asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Invalid Mobile Number" ControlToValidate="mobile" ForeColor="Red" ValidationExpression="^[7-9]\d{9}$"></asp:RegularExpressionValidator></td></tr>
           <tr><td class="lab">
               <asp:Label ID="Label3" runat="server" Text="E-Mail ID"></asp:Label></td><td class="txt">
                   <asp:TextBox ID="email" runat="server" CssClass="form-control" required="required" Width="60%" ReadOnly="True"></asp:TextBox>
               </td></tr>

           <tr><td></td><td class="txt">          <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Invalid Email ID" ControlToValidate="email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator></td></tr>
           <tr><td class="lab">
               <asp:Label ID="Label4" runat="server" Text="SSC"></asp:Label></td><td class="txt">
                   <asp:TextBox ID="ssc" runat="server" CssClass="form-control" required="required" Width="60%" ReadOnly="True"></asp:TextBox>
               </td></tr>
           <tr><td colspan="2"><br /></td></tr>
           <tr><td class="lab">
               <asp:Label ID="Label5" runat="server" Text="HSC"></asp:Label></td><td class="txt">
                   <asp:TextBox ID="hsc" runat="server" CssClass="form-control" required="required" Width="60%" ReadOnly="True"></asp:TextBox>
               </td></tr>
           <tr><td colspan="2"><br /></td></tr>
           
           <tr><td colspan="2" style="text-align:center">
               <asp:Button ID="Button2" runat="server" Text="Edit" Height="30px" OnClick="Button2_Click" Width="75px" />
&nbsp;<asp:Button ID="Button1" runat="server" Text="Update" OnClick="Button1_Click" Height="29px" Width="80px" /></td></tr>
           <tr><td colspan="2"><br /></td></tr>
       </table>
    </div>

</asp:Content>
