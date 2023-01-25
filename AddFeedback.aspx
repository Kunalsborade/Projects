<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="AddFeedback.aspx.cs" Inherits="AddFeedback" %>
<asp:Content ID="h" ContentPlaceHolderID="heading" runat="server">
    Feedback
</asp:Content>
<asp:Content ID="body" ContentPlaceHolderID="body" runat="server">
    <center>
        <table width="50%">
            
            <tr><td class="lab" style="vertical-align:top"><asp:Label ID="Label2" runat="server" Text="Feedback"></asp:Label></td><td class="txt"><asp:TextBox ID="feed" runat="server" required="required" CssClass="form-control" Height="300px"  TextMode="MultiLine" Width="283px"></asp:TextBox></td></tr>
            <tr><td colspan="2"><br /></td></tr>
            <tr><td colspan="2" style="text-align:center"><asp:Button ID="Button1" runat="server" Text="Submit" class="btn btn-skin" OnClick="Button1_Click"></asp:Button></td></tr>
            </table>
    </center>
    </asp:Content>
