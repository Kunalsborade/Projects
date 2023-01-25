<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TrainingData.aspx.cs" Inherits="TrainingData" %>


<asp:Content ID="h" ContentPlaceHolderID="heading" runat="server">

    Training Data

</asp:Content>
<asp:Content ID="body" ContentPlaceHolderID="body" runat="server">

    <div>
       <table width="80%">
            <tr><td class="lab">
               <asp:Label ID="Label7" runat="server" Text="Main Stream"></asp:Label></td><td class="txt">
                   <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" Width="60%">
                       <asp:ListItem>--Select--</asp:ListItem>
                   </asp:DropDownList></td></tr>
           <tr><td colspan="2"><br /></td></tr>
           <tr><td class="lab">
               <asp:Label ID="Label1" runat="server" Text="Stream"></asp:Label></td><td class="txt">
                   <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" Width="60%">
                       <asp:ListItem>--Select--</asp:ListItem>
                   </asp:DropDownList></td></tr>
           <tr><td colspan="2"><br /></td></tr>
           <tr><td class="lab">
               <asp:Label ID="Label2" runat="server" Text="Aptitude"></asp:Label></td><td class="txt">
                   <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" required="required" Width="60%"></asp:TextBox>
               </td></tr>
           <tr><td colspan="2"><br /></td></tr>
           <tr><td class="lab">
               <asp:Label ID="Label3" runat="server" Text="Maths"></asp:Label></td><td class="txt">
                   <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" required="required" Width="60%"></asp:TextBox>
               </td></tr>
           <tr><td colspan="2"><br /></td></tr>
           <tr><td class="lab">
               <asp:Label ID="Label4" runat="server" Text="English"></asp:Label></td><td class="txt">
                   <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" required="required" Width="60%"></asp:TextBox>
               </td></tr>
           <tr><td colspan="2"><br /></td></tr>
           <tr><td class="lab">
               <asp:Label ID="Label5" runat="server" Text="SSC"></asp:Label></td><td class="txt">
                   <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control" required="required" Width="60%"></asp:TextBox>
               </td></tr>
           <tr><td colspan="2"><br /></td></tr>
           <tr><td class="lab">
               <asp:Label ID="Label6" runat="server" Text="HSC"></asp:Label></td><td class="txt">
                   <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control" required="required" Width="60%"></asp:TextBox>
               </td></tr>
           <tr><td colspan="2"><br /></td></tr>
         
           <tr><td colspan="2" style="text-align:center">
               <asp:Button ID="Button1" class="btn btn-skin" runat="server" Text="Submit" OnClick="Button1_Click" /></td></tr>
           <tr><td colspan="2"><br /></td></tr>
       </table>
    </div>

</asp:Content>
