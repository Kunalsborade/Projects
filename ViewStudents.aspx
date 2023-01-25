<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="ViewStudents.aspx.cs" Inherits="ViewStudents" %>

<asp:Content ID="h" ContentPlaceHolderID="heading" runat="server">
    View Students
</asp:Content>
<asp:Content ID="body" ContentPlaceHolderID="body" runat="server">

    <center>
        <table width="80%">

            <tr><td colspan="2"><br /></td></tr>
            <tr><td colspan="2"><asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" HorizontalAlign="Center" Width="80%">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                <asp:BoundField HeaderText="Name" DataField="name"/>
                <asp:BoundField HeaderText="Mobile Number" DataField="mobile"/>
                <asp:BoundField HeaderText="E-Mail ID" DataField="email" />
                <asp:BoundField HeaderText="SSC" DataField="ssc" />
                <asp:BoundField HeaderText="HSC" DataField="hsc" />
                <asp:BoundField HeaderText="User Name" DataField="uname" />
                </Columns>

                                <FooterStyle BackColor="#CCCC99" />
                <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" HorizontalAlign="Left" />
                <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#F7F7DE" />
                <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" />
                <SortedAscendingCellStyle BackColor="#FBFBF2" />
                <SortedAscendingHeaderStyle BackColor="#848384" />
                <SortedDescendingCellStyle BackColor="#EAEAD3" />
                <SortedDescendingHeaderStyle BackColor="#575357" />

                                </asp:GridView></td></tr>
            <tr><td colspan="2"><br /></td></tr>
        </table>
    </center>

</asp:Content>