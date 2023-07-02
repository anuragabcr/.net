<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="Notebook.home" %>

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
            width: 451px;
        }
        .style3
        {
            width: 179px;
        }
        .style4
        {
            width: 230px;
        }
        .style5
        {
            width: 329px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td style="font-family: 'Javanese Text'; font-size: x-large; font-weight: bolder; font-style: oblique; color: #000080">
                    NoteBook</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:Label ID="Label1" runat="server" Font-Size="Large" ForeColor="#009999" 
                        Text="Select ID from Dropdown to Perform Specific Action And click on the BUTTON"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
                    </asp:DropDownList>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    <table class="style1">
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td class="style5">
                <asp:Button ID="Button1" runat="server" BackColor="#3366FF" ForeColor="Black" 
                    onclick="Button1_Click" style="margin-left: 61px" Text="Update" />
            </td>
            <td class="style4">
                <asp:Button ID="Button2" runat="server" BackColor="#33CC33" 
                    onclick="Button2_Click" style="margin-left: 0px" Text="Create" />
            </td>
            <td>
                <asp:Button ID="Button3" runat="server" BackColor="Red" onclick="Button3_Click" 
                    Text="Delete" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <asp:GridView ID="GridView1" runat="server" style="margin-left: 92px" 
        Width="976px">
    </asp:GridView>
    </form>
</body>
</html>
