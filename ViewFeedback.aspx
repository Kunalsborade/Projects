<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="ViewFeedback.aspx.cs" Inherits="ViewFeedback" %>
<asp:Content ID="h" ContentPlaceHolderID="heading" runat="server">
    View Feedback
</asp:Content>
<asp:Content ID="body" ContentPlaceHolderID="body" runat="server">
    <center>
        <table width="80%">
            
          
            <tr><td><asp:GridView ID="GridView1" runat="server" HorizontalAlign="Center" Width="80%" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" AutoGenerateColumns="False">
                <AlternatingRowStyle BackColor="White" />
                <FooterStyle BackColor="#CCCC99" />
                <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#F7F7DE" />
                <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FBFBF2" />
                <SortedAscendingHeaderStyle BackColor="#848384" />
                <SortedDescendingCellStyle BackColor="#EAEAD3" />
                <SortedDescendingHeaderStyle BackColor="#575357" />
                <Columns>
                <asp:BoundField HeaderText="Student ID" DataField="uid"/>
                <asp:BoundField HeaderText="Feedback" DataField="feedback"/>
                <asp:BoundField HeaderText="Date" DataField="date" />
                <asp:BoundField HeaderText="Time" DataField="time" />
               
                </Columns>

                </asp:GridView></td></tr>
           
            </table>
    </center>
    </asp:Content>
