<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="displayemployee.aspx.cs" Inherits="HostelManagementSystem.displayemployee" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="background-color: #C0C0C0">
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" 
            CellPadding="3" DataKeyNames="empid" DataSourceID="SqlDataSource1" 
            GridLines="Vertical">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <Columns>
                <asp:BoundField DataField="empid" HeaderText="EMPLOYEE ID" ReadOnly="True" 
                    SortExpression="empid" />
                <asp:BoundField DataField="empname" HeaderText="EMPLOYEE NAME" 
                    SortExpression="empname" />
                <asp:BoundField DataField="designation" HeaderText="DESIGNATION" 
                    SortExpression="designation" />
                <asp:BoundField DataField="department" HeaderText="DEPARTMENT" 
                    SortExpression="department" />
                <asp:BoundField DataField="salary" HeaderText="SALARY" 
                    SortExpression="salary" />
                <asp:BoundField DataField="doj" HeaderText="DATE OF JOIN" 
                    SortExpression="doj" />
                <asp:BoundField DataField="empphno" HeaderText="PHONE NUMBER" 
                    SortExpression="empphno" />
                <asp:BoundField DataField="email" HeaderText="EMAIL" SortExpression="email" />
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:rohitdbConnectionString %>" 
            DeleteCommand="DELETE FROM [employee] WHERE [empid] = @empid" 
            InsertCommand="INSERT INTO [employee] ([empid], [empname], [designation], [department], [salary], [doj], [empphno], [email]) VALUES (@empid, @empname, @designation, @department, @salary, @doj, @empphno, @email)" 
            SelectCommand="SELECT * FROM [employee]" 
            UpdateCommand="UPDATE [employee] SET [empname] = @empname, [designation] = @designation, [department] = @department, [salary] = @salary, [doj] = @doj, [empphno] = @empphno, [email] = @email WHERE [empid] = @empid">
            <DeleteParameters>
                <asp:Parameter Name="empid" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="empid" Type="String" />
                <asp:Parameter Name="empname" Type="String" />
                <asp:Parameter Name="designation" Type="String" />
                <asp:Parameter Name="department" Type="String" />
                <asp:Parameter Name="salary" Type="Int64" />
                <asp:Parameter Name="doj" Type="DateTime" />
                <asp:Parameter Name="empphno" Type="Int64" />
                <asp:Parameter Name="email" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="empname" Type="String" />
                <asp:Parameter Name="designation" Type="String" />
                <asp:Parameter Name="department" Type="String" />
                <asp:Parameter Name="salary" Type="Int64" />
                <asp:Parameter Name="doj" Type="DateTime" />
                <asp:Parameter Name="empphno" Type="Int64" />
                <asp:Parameter Name="email" Type="String" />
                <asp:Parameter Name="empid" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
