<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="Register.aspx.cs" Inherits="Register" %>
<asp:Content ID="h" ContentPlaceHolderID="heading" runat="server">
    Student Registration


</asp:Content>
<asp:Content ID="body" ContentPlaceHolderID="body" runat="server">    
    <div>
       <center>
      <table width="80%">
          <tr><td style="text-align: -webkit-center;">
              <asp:TextBox ID="name" Placeholder="Name"  runat="server" required CssClass="form-control" Width="40%"></asp:TextBox></td></tr>
          <tr><td><br /></td></tr>
          <tr><td style="text-align: -webkit-center;">
              <asp:TextBox ID="mobile" Placeholder="Mobile Number" required runat="server" CssClass="form-control" Width="40%"></asp:TextBox></td></tr>
          <tr><td style="text-align: -webkit-center;"><asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Invalid Mobile Number" ControlToValidate="mobile" ForeColor="Red" ValidationExpression="^[7-9]\d{9}$"></asp:RegularExpressionValidator></td></tr>
          <tr><td style="text-align: -webkit-center;">
              <asp:TextBox ID="email" Placeholder="E-Mail ID" required runat="server" CssClass="form-control" Width="40%"></asp:TextBox></td></tr>
          <tr><td style="text-align: -webkit-center;"><asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Invalid Email ID" ControlToValidate="email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator></td></tr>
          <tr><td style="text-align: -webkit-center;">
              <asp:TextBox ID="ssc" Placeholder="SSC Marks" required runat="server" CssClass="form-control" Width="40%"></asp:TextBox></td></tr>
          <tr><td style="text-align:center"><br /></td></tr>
           <tr><td style="text-align: -webkit-center;">
              <asp:TextBox ID="hsc" Placeholder="HSC Marks" required runat="server" CssClass="form-control" Width="40%"></asp:TextBox></td></tr>
          <tr><td style="text-align: -webkit-center;"><br /></td></tr>
          <tr><td style="text-align: -webkit-center;">
              <asp:TextBox ID="uname" Placeholder="User Name" required runat="server"  Width="40%" CssClass="form-control"></asp:TextBox></td></tr>
         <tr><td style="text-align: -webkit-center;"><asp:Label ID="Label1" runat="server" Text="Username Already Exist !!!" ForeColor="Red" Visible="False"></asp:Label><br /></td></tr>

          <tr><td style="text-align: -webkit-center;">
              <asp:TextBox ID="pass" Palceholder="Password" required runat="server"  Width="40%" CssClass="form-control" Placeholder="Password" TextMode="Password"></asp:TextBox></td></tr>
          <tr><td><br /></td></tr>
          <tr><td style="padding:10px;text-align: -webkit-center;">
              <asp:Button ID="Button1" runat="server" Text="Submit" class="btn btn-skin" OnClick="Button1_Click" /></td></tr>
       <tr><td><br /></td></tr>    
      </table>
            </center>
    </div>
</asp:Content>
