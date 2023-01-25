<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="AddMainStream.aspx.cs" Inherits="AddStream" %>
<asp:Content ID="h" ContentPlaceHolderID="heading" runat="server">
    Main Stream Details
</asp:Content>
<asp:Content ID="body" ContentPlaceHolderID="body" runat="server">
    <div style="-webkit-align:center">
        <table width="50%">
            <tr><td class="lab"><asp:Label ID="Label1" runat="server" Text="Stream Name"></asp:Label></td>
                <td class="txt">
                    <asp:TextBox ID="stream" runat="server" required="required" CssClass="form-control" Width="60%"></asp:TextBox>
                </td></tr>
       <tr><td colspan="2"><br /></td></tr>
              <tr><td class="lab"><asp:Label ID="Label2" runat="server" Text="Main Stream"></asp:Label></td><td  class="txt">
                  <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" Width="60%">
                      <asp:ListItem>--Select--</asp:ListItem>
                      <asp:ListItem>Science</asp:ListItem>
                      <asp:ListItem>Commerce</asp:ListItem>
                      <asp:ListItem>Arts</asp:ListItem>
                  </asp:DropDownList>
                  </td></tr>
       <tr><td colspan="2"><br /></td></tr>
              <tr><td class="lab"><asp:Label ID="Label3" runat="server" Text="Features"></asp:Label></td><td  class="txt"><asp:TextBox ID="features" required="required"  runat="server" CssClass="auto-style1" Width="60%" Height="85px" TextMode="MultiLine"></asp:TextBox></td></tr>
       <tr><td colspan="2"><br /></td></tr>
          
            <tr><td colspan="2" style="text-align:center"><asp:Button ID="Button1" class="btn btn-skin" runat="server" Text="Submit" OnClick="Button1_Click"></asp:Button></td></tr>
                   <tr><td><br /></td></tr> </table>
    </div>


</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style1 {
            display: block;
            padding: 6px 12px;
            font-size: 14px;
            line-height: 1.428571429;
            color: #555;
            background-color: #fff;
            background-image: none;
            border: 1px solid #ccc;
            border-radius: 4px;
            -webkit-box-shadow: inset 0 1px 1px rgba(0,0,0,.075);
            box-shadow: inset 0 1px 1px rgba(0,0,0,.075);
            -webkit-transition: border-color ease-in-out .15s,box-shadow ease-in-out .15s;
            transition: border-color ease-in-out .15s,box-shadow ease-in-out .15s;
        }
    </style>
</asp:Content>
