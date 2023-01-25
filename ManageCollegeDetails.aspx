<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ManageCollegeDetails.aspx.cs" Inherits="ManageCollegeDetails" %>
<asp:Content ID="h" ContentPlaceHolderID="heading" runat="server">
    Manage College Details

</asp:Content>
<asp:Content ID="head" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
    function alertMessage() {


        var flag = "0";

        if (confirm('Are You Sure You Want To delete this record!')) {
            flag = "1";
            document.getElementById('<%= HiddenField1.ClientID %>').value = flag;
        }
        else
            document.getElementById('<%=HiddenField1.ClientID %>').value = flag;



    }
     
       
     
    </script>
</asp:Content>
<asp:Content ID="body" ContentPlaceHolderID="body" runat="server">
     <center>
    <table width="80%">
        
          <tr><td colspan="2" style="text-align:center"><hr /></td></tr>
        
        <tr><td colspan="2" style="text-align:center">
            <asp:GridView ID="GridView1" runat="server" HorizontalAlign="Center" Width="80%" AutoGenerateColumns="False"  OnRowCommand="GridView1_RowCommand" CellPadding="4" ForeColor="Black" GridLines="Vertical" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" >
                <AlternatingRowStyle BackColor="White" />
            <Columns>
             
                <asp:BoundField HeaderText="College Name" DataField="cname"/>
                <asp:BoundField HeaderText="Stream" DataField="stream" />
                <asp:BoundField HeaderText="Cut Off" DataField="cutoff" />
               
                
                
<asp:TemplateField HeaderText="Update"><ItemTemplate>

        <asp:LinkButton ID="edit" runat ="server" CommandArgument='<%#Eval("st")%>' Text ="Edit" CommandName ="ed" ></asp:LinkButton>
      
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField HeaderText="Delete"><ItemTemplate>

        <asp:LinkButton ID="delete" runat ="server" CommandArgument='<%#Eval("st")%>' OnClientClick="alertMessage()"  Text ="Delete" CommandName ="del" ></asp:LinkButton>
      
</ItemTemplate>
</asp:TemplateField>
              
                
                
                </Columns>
                        

                <FooterStyle BackColor="#CCCC99" />
                <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" />
                <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#F7F7DE" HorizontalAlign="Left" />
                <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FBFBF2" />
                <SortedAscendingHeaderStyle BackColor="#848384" />
                <SortedDescendingCellStyle BackColor="#EAEAD3" />
                <SortedDescendingHeaderStyle BackColor="#575357" />

                </asp:GridView>

        </td></tr>
        <tr><td colspan="2">
            <asp:HiddenField ID="HiddenField1" runat="server" />
            <br /></td></tr>

    </table>
    <br />
    <hr />
         <asp:HiddenField ID="HiddenField2" runat="server" />
    <br />
    <asp:Panel ID="Panel1" runat="server">
        
        <table width="50%">
            <tr><td class="lab">
                <asp:Label ID="Label1" runat="server" Text="Stream"></asp:Label></td><td class="txt">
                    <asp:TextBox ID="stream" runat="server"></asp:TextBox></td></tr>
            <tr><td colspan="2"><br /></td></tr>
            <tr><td class="lab">
                <asp:Label ID="Label2" runat="server" Text="Cutoff"></asp:Label></td><td class="txt">
                    <asp:TextBox ID="cutoff" runat="server"></asp:TextBox></td></tr>
         <tr><td colspan="2"><br /></td></tr>
            <tr><td colspan="2" style="text-align:center">
                <asp:Button ID="Button1" runat="server" Text="Update" CssClass="btn btn-skin" OnClick="Button1_Click" /></td></tr>
        </table>

    </asp:Panel>
</asp:Content>
