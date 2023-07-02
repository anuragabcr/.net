<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="note.aspx.cs" Inherits="Notebook.note" %>

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
            width: 242px;
        }
        .style3
        {
            width: 542px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table class="style1">
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style3">
                <asp:Label ID="Label1" runat="server" Text="Note"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="Label2" runat="server" Text="Title"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="TextBox1" runat="server" Width="260px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="TextBox1" ErrorMessage="Can't be Empty"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="Label3" runat="server" Text="Note"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="TextBox2" runat="server" Height="224px" TextMode="MultiLine" 
                    Width="361px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="TextBox2" ErrorMessage="Can't be Empty"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style3">
                <asp:Button ID="Button1" runat="server" BackColor="#00CC00" 
                    onclick="Button1_Click" Text="Create" />
            </td>
            <td>
                <asp:Button ID="Button2" runat="server" BackColor="#FF3300" 
                    onclick="Button2_Click" Text="Cancel" />
            </td>
        </tr>
    </table>
    <div>
    
    </div>
    </form>
</body>
</html>
