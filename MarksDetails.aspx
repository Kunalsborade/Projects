<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="MarksDetails.aspx.cs" Inherits="MarksDetails" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<asp:Content ID="h" ContentPlaceHolderID="heading" runat="server">
    Marks Details
</asp:Content>
<asp:Content ID="body" ContentPlaceHolderID="body" runat="server">
    <table width="80%">
        <tr><td>
            <asp:Chart ID="Chart1" runat="server">
                <Series>
                    <asp:Series Name="Series1" ChartType="Pie"></asp:Series>
                </Series>
                <ChartAreas>
                    <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                </ChartAreas>
            </asp:Chart>
        </td><td>
               <h3> <asp:Label ID="Label1"  runat="server" ForeColor="#3366FF"></asp:Label>
            </h3></td></tr>

    </table>
    <table width="80%">
        <tr><td style="text-align:center"><h1>College List</h1></td></tr>
        <tr><td><hr /></td></tr>
        <tr><td>
            <asp:GridView ID="GridView1" runat="server" Width="80%" AutoGenerateColumns="False" HorizontalAlign="Center" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                <asp:BoundField HeaderText="College Name" DataField="cname"/>
                <asp:BoundField HeaderText="Address" DataField="address"/>
                <asp:BoundField HeaderText="Stream" DataField="stream" />
                <asp:BoundField HeaderText="Cut Off" DataField="cutoff" />
</Columns>
                <FooterStyle BackColor="#CCCC99" />
                <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#F7F7DE" />
                <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FBFBF2" />
                <SortedAscendingHeaderStyle BackColor="#848384" />
                <SortedDescendingCellStyle BackColor="#EAEAD3" />
                <SortedDescendingHeaderStyle BackColor="#575357" />
            </asp:GridView>
        </td></tr>
    </table>
</asp:Content>

