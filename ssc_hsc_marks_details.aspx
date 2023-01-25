<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="ssc_hsc_marks_details.aspx.cs" Inherits="ssc_hsc_marks_details" %>

<asp:Content ID="h" ContentPlaceHolderID="heading" runat="server">
    Marks Details
</asp:Content>
<asp:Content ID="body" ContentPlaceHolderID="body" runat="server">
    <div style="-webkit-align:center">
        <table width="50%">
            <tr><td class="lab"><asp:Label ID="Label1" runat="server" Text="Select Course"></asp:Label></td>
                <td class="txt">
                    <asp:DropDownList ID="course" runat="server" CssClass="form-control" Width="60%">
                        <asp:ListItem>--Select--</asp:ListItem>
                        <asp:ListItem>SSC</asp:ListItem>
                        <asp:ListItem>HSC</asp:ListItem>
                    </asp:DropDownList>
                </td></tr>
       <tr><td colspan="2"><br /></td></tr>
              <tr><td class="lab"><asp:Label ID="Label2" runat="server" Text="Subject"></asp:Label></td><td  class="txt">
                  <asp:TextBox ID="subject" runat="server" CssClass="form-control" Width="60%"></asp:TextBox>
                  </td></tr>
       <tr><td colspan="2"><br /></td></tr>
              <tr><td class="lab"><asp:Label ID="Label3" runat="server" Text="marks"></asp:Label></td><td  class="txt"><asp:TextBox ID="marks" required="required"  runat="server" CssClass="form-control" Width="60%"></asp:TextBox></td></tr>
       <tr><td colspan="2"><br /></td></tr>
          
            <tr><td colspan="2" style="text-align:center"><asp:Button ID="Button1" class="btn btn-skin" runat="server" Text="Submit" OnClick="Button1_Click"></asp:Button></td></tr>
                   <tr><td><br /></td></tr> </table>
    </div>
</asp:Content>