<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dashbord.aspx.cs" Inherits="HostelManagementSystem.dashbord" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 264px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="background-color: #99CCFF; border: thick outset #008080; color: #800000;">
    
        <asp:Image ID="Image1" runat="server" Height="70px" ImageUrl="~/cmr.jpg" 
            Width="163px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" BorderColor="#CC0000" 
            BorderStyle="Groove" BorderWidth="10px" ForeColor="#CC0000" Height="22px" 
            Text="DASHBORD"></asp:Label>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Welcome&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" ForeColor="#CC0000" 
            Text="WELCOME" Visible="False" Width="83px"></asp:Label>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" BackColor="#33CC33" BorderColor="#FF9900" 
            BorderStyle="Groove" BorderWidth="5px" ForeColor="#993300" 
            Text="HOSTEL MANAGEMENT SYSTEM"></asp:Label>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <table class="style1">
            <tr>
                <td class="style2">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnemp" runat="server" BackColor="#CC6699" 
            BorderColor="#FFCC00" BorderStyle="Double" BorderWidth="5px" 
            ForeColor="#990033" onclick="btnemp_Click" Text="EMPLOYEE" />
&nbsp;&nbsp;&nbsp;&nbsp;<br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:Button ID="btnemp0" runat="server" BackColor="#CC6699" 
            BorderColor="#FFCC00" BorderStyle="Double" BorderWidth="5px" 
            ForeColor="#990033" Text="GUEST" onclick="btnemp0_Click" />
                    <br />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnemp1" runat="server" BackColor="#CC6699" 
            BorderColor="#FFCC00" BorderStyle="Double" BorderWidth="5px" 
            ForeColor="#990033" Text="USER" />
                    <br />
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnemp2" runat="server" BackColor="#CC6699" 
            BorderColor="#FFCC00" BorderStyle="Double" BorderWidth="5px" 
            ForeColor="#990033" onclick="btnemp2_Click" Text="LOGOUT" />
        <br />
        <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td>
                    In Which date the the highest selary taken by the which customer<br />
                    <asp:Calendar ID="Calendar1" runat="server" BackColor="White" 
                        BorderColor="Black" DayNameFormat="Shortest" Font-Names="Times New Roman" 
                        Font-Size="10pt" ForeColor="Black" Height="220px" NextPrevFormat="FullMonth" 
                        onselectionchanged="Calendar1_SelectionChanged" TitleFormat="Month" 
                        Width="269px">
                        <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" 
                            ForeColor="#333333" Height="10pt" />
                        <DayStyle Width="14%" />
                        <NextPrevStyle Font-Size="8pt" ForeColor="White" />
                        <OtherMonthDayStyle ForeColor="#999999" />
                        <SelectedDayStyle BackColor="#CC3333" ForeColor="White" />
                        <SelectorStyle BackColor="#CCCCCC" Font-Bold="True" Font-Names="Verdana" 
                            Font-Size="8pt" ForeColor="#333333" Width="1%" />
                        <TitleStyle BackColor="Black" Font-Bold="True" Font-Size="13pt" 
                            ForeColor="White" Height="14pt" />
                        <TodayDayStyle BackColor="#CCCC99" />
                    </asp:Calendar>
                    <br />
                    This graph will show in the particular date&#39;s how much&nbsp; salary took&nbsp; 
                    from the company<br />
                    <br />
                    <asp:Chart ID="Chart1" runat="server" DataSourceID="SqlDataSource1" 
                        Width="1042px">
                        <Series>
                            <asp:Series Name="Series1" XValueMember="doj" YValueMembers="salary">
                            </asp:Series>
                        </Series>
                        <ChartAreas>
                            <asp:ChartArea Name="ChartArea1">
                            </asp:ChartArea>
                        </ChartAreas>
                    </asp:Chart>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:ListView ID="ListView1" runat="server" DataKeyNames="empid" 
                        DataSourceID="SqlDataSource2">
                        <AlternatingItemTemplate>
                            <tr style="background-color: #FFFFFF;color: #284775;">
                                <td>
                                    <asp:Label ID="empidLabel" runat="server" Text='<%# Eval("empid") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="dojLabel" runat="server" Text='<%# Eval("doj") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="empnameLabel" runat="server" Text='<%# Eval("empname") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="salaryLabel" runat="server" Text='<%# Eval("salary") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="empphnoLabel" runat="server" Text='<%# Eval("empphno") %>' />
                                </td>
                            </tr>
                        </AlternatingItemTemplate>
                        <EditItemTemplate>
                            <tr style="background-color: #999999;">
                                <td>
                                    <asp:Button ID="UpdateButton" runat="server" CommandName="Update" 
                                        Text="Update" />
                                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" 
                                        Text="Cancel" />
                                </td>
                                <td>
                                    <asp:Label ID="empidLabel1" runat="server" Text='<%# Eval("empid") %>' />
                                </td>
                                <td>
                                    <asp:TextBox ID="dojTextBox" runat="server" Text='<%# Bind("doj") %>' />
                                </td>
                                <td>
                                    <asp:TextBox ID="empnameTextBox" runat="server" Text='<%# Bind("empname") %>' />
                                </td>
                                <td>
                                    <asp:TextBox ID="salaryTextBox" runat="server" Text='<%# Bind("salary") %>' />
                                </td>
                                <td>
                                    <asp:TextBox ID="empphnoTextBox" runat="server" Text='<%# Bind("empphno") %>' />
                                </td>
                            </tr>
                        </EditItemTemplate>
                        <EmptyDataTemplate>
                            <table runat="server" 
                                style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                                <tr>
                                    <td>
                                        No data was returned.</td>
                                </tr>
                            </table>
                        </EmptyDataTemplate>
                        <InsertItemTemplate>
                            <tr style="">
                                <td>
                                    <asp:Button ID="InsertButton" runat="server" CommandName="Insert" 
                                        Text="Insert" />
                                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" 
                                        Text="Clear" />
                                </td>
                                <td>
                                    <asp:TextBox ID="empidTextBox" runat="server" Text='<%# Bind("empid") %>' />
                                </td>
                                <td>
                                    <asp:TextBox ID="dojTextBox" runat="server" Text='<%# Bind("doj") %>' />
                                </td>
                                <td>
                                    <asp:TextBox ID="empnameTextBox" runat="server" Text='<%# Bind("empname") %>' />
                                </td>
                                <td>
                                    <asp:TextBox ID="salaryTextBox" runat="server" Text='<%# Bind("salary") %>' />
                                </td>
                                <td>
                                    <asp:TextBox ID="empphnoTextBox" runat="server" Text='<%# Bind("empphno") %>' />
                                </td>
                            </tr>
                        </InsertItemTemplate>
                        <ItemTemplate>
                            <tr style="background-color: #E0FFFF;color: #333333;">
                                <td>
                                    <asp:Label ID="empidLabel" runat="server" Text='<%# Eval("empid") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="dojLabel" runat="server" Text='<%# Eval("doj") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="empnameLabel" runat="server" Text='<%# Eval("empname") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="salaryLabel" runat="server" Text='<%# Eval("salary") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="empphnoLabel" runat="server" Text='<%# Eval("empphno") %>' />
                                </td>
                            </tr>
                        </ItemTemplate>
                        <LayoutTemplate>
                            <table runat="server">
                                <tr runat="server">
                                    <td runat="server">
                                        <table ID="itemPlaceholderContainer" runat="server" border="1" 
                                            style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                                            <tr runat="server" style="background-color: #E0FFFF;color: #333333;">
                                                <th runat="server">
                                                    empid</th>
                                                <th runat="server">
                                                    doj</th>
                                                <th runat="server">
                                                    empname</th>
                                                <th runat="server">
                                                    salary</th>
                                                <th runat="server">
                                                    empphno</th>
                                            </tr>
                                            <tr ID="itemPlaceholder" runat="server">
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr runat="server">
                                    <td runat="server" 
                                        style="text-align: center;background-color: #5D7B9D;font-family: Verdana, Arial, Helvetica, sans-serif;color: #FFFFFF">
                                    </td>
                                </tr>
                            </table>
                        </LayoutTemplate>
                        <SelectedItemTemplate>
                            <tr style="background-color: #E2DED6;font-weight: bold;color: #333333;">
                                <td>
                                    <asp:Label ID="empidLabel" runat="server" Text='<%# Eval("empid") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="dojLabel" runat="server" Text='<%# Eval("doj") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="empnameLabel" runat="server" Text='<%# Eval("empname") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="salaryLabel" runat="server" Text='<%# Eval("salary") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="empphnoLabel" runat="server" Text='<%# Eval("empphno") %>' />
                                </td>
                            </tr>
                        </SelectedItemTemplate>
                    </asp:ListView>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:rohitdbConnectionString %>" 
                        SelectCommand="SELECT [empid], [doj], [empname], [salary], [empphno] FROM [employee]">
                    </asp:SqlDataSource>
&nbsp;
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:rohitdbConnectionString %>" 
                        SelectCommand="SELECT [doj], [salary], [department], [empid] FROM [employee]">
                    </asp:SqlDataSource>
&nbsp;
                </td>
            </tr>
        </table>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
