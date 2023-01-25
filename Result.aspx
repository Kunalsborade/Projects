<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Result.aspx.cs" Inherits="_Default" %>

<asp:Content ID="h" ContentPlaceHolderID="heading" runat="server">

    Result

</asp:Content>
<asp:Content ID="body" ContentPlaceHolderID="body" runat="server">
    <table width="100%">
<tr>
<td width="40%" align="left">
   <h1><asp:Label ID="Label1" runat="server" Text="Aptitude" 
        Font-Bold="True" Font-Names="Calibri" Font-Size="X-Large" 
        ForeColor="#A7D12F"></asp:Label></h1> 
    </td>
    <td width="20%" align="right">
        &nbsp;</td>
    <td width="20%" align="left">
        &nbsp;</td>
    </tr>
</table>
    <asp:Panel ID="ap" runat="server">
    <table width="100%">
    <tr style="background-color:Green; color:White">
    <td width="40%" align="right">
        <asp:Label ID="Label112" runat="server" Text="Marks :" Font-Bold="True"></asp:Label></td>
    <td width="40%" align="left" style="font-weight: bold">
        &nbsp;
        <asp:Label ID="score"
            runat="server" Font-Bold="True"></asp:Label>&nbsp;/
        <asp:Label ID="total" runat="server" Font-Bold="True"></asp:Label>
        </td>
    </tr>
    <tr>
    
    <td width="40%" align="right">
        <asp:Label ID="Label115" runat="server" Text="Total Number of Questions :"></asp:Label></td>
    <td width="40%" align="left">
        <asp:Label ID="tq" runat="server"></asp:Label></td>
   
    </tr>
    <tr>
    
    <td width="40%" align="right">
        <asp:Label ID="Label120" runat="server" Text="Number of Answered Questions :"></asp:Label></td>
    <td width="40%" align="left">
        <asp:Label ID="aq" runat="server"></asp:Label></td>
   
    </tr>
     <tr>
    
    <td width="40%" align="right">
        <asp:Label ID="Label122" runat="server" Text="Number of Unanswered Questions :"></asp:Label></td>
    <td width="40%" align="left">
        <asp:Label ID="uq" runat="server"></asp:Label></td>
   
    </tr>
    </table>
    
    </asp:Panel>
    <table width="100%">
<tr>
<td width="40%" align="left">
   <h1><asp:Label ID="Maths" runat="server" Text="MATHS" 
        Font-Bold="True" Font-Names="Calibri" Font-Size="X-Large" 
        ForeColor="#A7D12F"></asp:Label></h1> 
    </td>
    <td width="20%" align="right">
        &nbsp;</td>
    <td width="20%" align="left">
        &nbsp;</td>
    </tr>
</table>
    <asp:Panel ID="ma" runat="server">
    <table width="100%">
    <tr style="background-color:Green; color:White">
    <td width="40%" align="right">
        <asp:Label ID="Label3" runat="server" Text="Marks :" Font-Bold="True"></asp:Label></td>
    <td width="40%" align="left" style="font-weight: bold">
        &nbsp;
        <asp:Label ID="score1"
            runat="server" Font-Bold="True"></asp:Label>&nbsp;/
        <asp:Label ID="total1" runat="server" Font-Bold="True"></asp:Label>
        </td>
    </tr>
    <tr>
    
    <td width="40%" align="right">
        <asp:Label ID="Label6" runat="server" Text="Total Number of Questions :"></asp:Label></td>
    <td width="40%" align="left">
        <asp:Label ID="tq1" runat="server"></asp:Label></td>
   
    </tr>
    <tr>
    
    <td width="40%" align="right">
        <asp:Label ID="Label8" runat="server" Text="Number of Answered Questions :"></asp:Label></td>
    <td width="40%" align="left">
        <asp:Label ID="aq1" runat="server"></asp:Label></td>
   
    </tr>
     <tr>
    
    <td width="40%" align="right">
        <asp:Label ID="Label10" runat="server" Text="Number of Unanswered Questions :"></asp:Label></td>
    <td width="40%" align="left">
        <asp:Label ID="uq1" runat="server"></asp:Label></td>
   
    </tr>
    </table>
    
    </asp:Panel>
    <table width="100%">
<tr>
<td width="40%" align="left">
   <h1><asp:Label ID="Label12" runat="server" Text="Aptitude" 
        Font-Bold="True" Font-Names="Calibri" Font-Size="X-Large" 
        ForeColor="#A7D12F"></asp:Label></h1> 
    </td>
    <td width="20%" align="right">
        &nbsp;</td>
    <td width="20%" align="left">
        &nbsp;</td>
    </tr>
</table>
    <asp:Panel ID="en" runat="server">
    <table width="100%">
    <tr style="background-color:Green; color:White">
    <td width="40%" align="right">
        <asp:Label ID="Label13" runat="server" Text="Marks :" Font-Bold="True"></asp:Label></td>
    <td width="40%" align="left" style="font-weight: bold">
        &nbsp;
        <asp:Label ID="score2"
            runat="server" Font-Bold="True"></asp:Label>&nbsp;/
        <asp:Label ID="total2" runat="server" Font-Bold="True"></asp:Label>
        </td>
    </tr>
    <tr>
    
    <td width="40%" align="right">
        <asp:Label ID="Label16" runat="server" Text="Total Number of Questions :"></asp:Label></td>
    <td width="40%" align="left">
        <asp:Label ID="tq2" runat="server"></asp:Label></td>
   
    </tr>
    <tr>
    
    <td width="40%" align="right">
        <asp:Label ID="Label18" runat="server" Text="Number of Answered Questions :"></asp:Label></td>
    <td width="40%" align="left">
        <asp:Label ID="aq2" runat="server"></asp:Label></td>
   
    </tr>
     <tr>
    
    <td width="40%" align="right">
        <asp:Label ID="Label20" runat="server" Text="Number of Unanswered Questions :"></asp:Label></td>
    <td width="40%" align="left">
        <asp:Label ID="uq2" runat="server"></asp:Label></td>
   
    </tr>
    </table>
    
    </asp:Panel>

</asp:Content>
