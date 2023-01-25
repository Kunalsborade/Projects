<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="AddQuestions.aspx.cs" Inherits="AddQuestions" %>

<asp:Content ID="h" ContentPlaceHolderID="heading" runat="server">

    Apptitude Questions

</asp:Content>
<asp:Content ID="body" ContentPlaceHolderID="body" runat="server">

    <div>
        <center>
       <table width="70%">
           <tr><td class="lab">
               <asp:Label ID="Label1" runat="server" Text="Type"></asp:Label></td><td class="txt">
                   <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" Width="60%">
                       <asp:ListItem>--Select--</asp:ListItem>
                       <asp:ListItem>Apptitude</asp:ListItem>
                       <asp:ListItem>Maths</asp:ListItem>
                       <asp:ListItem>English</asp:ListItem>
                   </asp:DropDownList></td></tr>
           <tr><td colspan="2"><br /></td></tr>
           <tr><td class="lab">
               <asp:Label ID="Label2" runat="server" Text="Question"></asp:Label></td><td class="txt">
                   <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" required="required" TextMode="MultiLine" Width="60%"></asp:TextBox>
               </td></tr>
           <tr><td colspan="2"><br /></td></tr>
           <tr><td class="lab">
               <asp:Label ID="Label3" runat="server" Text="Option 1"></asp:Label></td><td class="txt">
                   <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" required="required" TextMode="MultiLine" Width="60%"></asp:TextBox>
               </td></tr>
           <tr><td colspan="2"><br /></td></tr>
           <tr><td class="lab">
               <asp:Label ID="Label4" runat="server" Text="Option 2"></asp:Label></td><td class="txt">
                   <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" required="required" TextMode="MultiLine" Width="60%"></asp:TextBox>
               </td></tr>
           <tr><td colspan="2"><br /></td></tr>
           <tr><td class="lab">
               <asp:Label ID="Label5" runat="server" Text="Option 3"></asp:Label></td><td class="txt">
                   <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control" required="required" TextMode="MultiLine" Width="60%"></asp:TextBox>
               </td></tr>
           <tr><td colspan="2"><br /></td></tr>
           <tr><td class="lab">
               <asp:Label ID="Label6" runat="server" Text="Option 4"></asp:Label></td><td class="txt">
                   <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control" required="required" TextMode="MultiLine" Width="60%"></asp:TextBox>
               </td></tr>
           <tr><td colspan="2"><br /></td></tr>
           <tr><td class="lab">
               <asp:Label ID="Label7" runat="server" Text="Ans"></asp:Label></td><td class="txt">
                   <asp:TextBox ID="TextBox6" runat="server" CssClass="form-control" required="required" TextMode="MultiLine" Width="60%"></asp:TextBox>
               </td></tr>
           <tr><td colspan="2"><br /></td></tr>
           <tr><td colspan="2" style="text-align:center">
               <asp:Button ID="Button1" class="btn btn-skin" runat="server" Text="Submit" OnClick="Button1_Click" /></td></tr>
           <tr><td colspan="2"><br /></td></tr>
       </table>
            </center>
    </div>

</asp:Content>