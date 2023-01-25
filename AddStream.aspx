<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="AddStream.aspx.cs" Inherits="AddCollege" %>

<asp:Content ID="h" ContentPlaceHolderID="heading" runat="server">

    College Cuttoff  Details
</asp:Content>
<asp:Content ID="body" ContentPlaceHolderID="body" runat="server">
    <asp:Panel ID="Panel1" runat="server">
        <center>
        <table width="80%">
            <tr><td colspan="2"><h2><asp:Label ID="Label6" runat="server" Text="College Details"></asp:Label></h2></td></tr>
       <tr><td colspan="2"><hr /></td></tr>  
            </table>
            </center>
     <center>
        <table width="50%">
             

            <tr><td class="lab"><asp:Label ID="Label2" runat="server" Text="College Name"></asp:Label></td><td class="txt"><asp:TextBox ID="name" required="required" runat="server" CssClass="form-control" Width="60%"></asp:TextBox></td></tr>
       <tr><td colspan="2"><br /></td></tr>
              <tr><td class="lab"><asp:Label ID="Label3" runat="server" Text="Address"></asp:Label></td><td class="txt"><asp:TextBox ID="address" required="required"  runat="server" CssClass="auto-style1" Height="136px" TextMode="MultiLine" Width="60%"></asp:TextBox></td></tr>
       <tr><td  colspan="2"><br /></td></tr>
            </table>
         
         <table width="80%">
                          
            <tr><td colspan="2" style="text-align:center"><asp:Button ID="Button1" runat="server" Text="Submit" class="btn btn-skin" OnClick="Button1_Click"></asp:Button></td></tr>
                   <tr><td>
                       <asp:HiddenField ID="h1" runat="server" />
                       <br /></td></tr>

        </table>

    </center>
        </asp:Panel>

    <asp:Panel ID="Panel2" runat="server">
         <center>
        <table width="80%">
              <tr><td colspan="2"><h2><asp:Label ID="Label1" runat="server" Text="Stream Details"></asp:Label></h2></td></tr>
       <tr><td colspan="2"><hr /></td></tr>
            </table>
            </center>
        <center>
        <table width="50%">
              
            <tr><td class="lab"><asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="60%">
                <asp:ListItem>--Select Main Stream--</asp:ListItem>
                </asp:DropDownList></td><td class="txt"><asp:DropDownList ID="DropDownList2" runat="server" Width="60%">
                    <asp:ListItem>--Select Stream--</asp:ListItem>
                    </asp:DropDownList></td></tr> 
            <tr><td colspan="2"><br /></td></tr>
            <tr><td class="lab"><asp:Label ID="Label5" runat="server" Text="Cutoff"></asp:Label></td><td class="txt"><asp:TextBox ID="TextBox1" runat="server" Width="60%"></asp:TextBox></td></tr>  
        <tr><td colspan="2"><br /></td></tr>
            <tr><td colspan="2"><asp:Button ID="Button2" class="btn btn-skin" runat="server" Text="Submit" OnClick="Button2_Click"></asp:Button></td></tr>
            <tr><td colspan="2"><br /></td></tr>    
        </table>
            </center>

    </asp:Panel>
       
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
