<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Rebel_Exercise.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 459px;
            height: 543px;
        }

        .auto-style2 {
            width: 563px;
            height: 543px;
            margin-left: 40px;
        }

        .auto-style3 {
            width: 100%;
            height: 539px;
        }

        .auto-style4 {
            width: 81px;
        }

        .auto-style5 {
            height: 543px;
        }

        .auto-style6 {
            height: 90px;
        }

        .auto-style7 {
            width: 81px;
            height: 90px;
        }
    </style>
</head>
<body style="width: 100%; height: 100%;">
    <form id="form1" runat="server">
        <table style="width: 100%; height: 100%;">
            <tr>
                <td class="auto-style1">
                    <asp:TextBox ID="AddItemTextBox" runat="server" Height="529px" ValidateRequestMode="Enabled" Width="445px" AutoCompleteType="Disabled"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <table class="auto-style3">
                        <tr>
                            <td>&nbsp;</td>
                            <td class="auto-style4">
                                <asp:Button ID="AddButton" runat="server" OnClick="AddButton_Click" Text="Add" Width="135px" />
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td class="auto-style4">
                                <asp:Button ID="RemoveButton" runat="server" OnClick="RemoveButton_Click" Text="Remove Selected" Width="135px" />
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td class="auto-style4">
                                <asp:Button ID="ClearButton" runat="server" OnClick="ClearButton_Click" Text="Clear" Width="135px" />
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td class="auto-style4">
                                <asp:Button ID="ExportButton" runat="server" OnClick="ExportButton_Click" Text="Export To Xml" Width="135px" />
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td class="auto-style4">
                                <asp:Button ID="SortNameButton" runat="server" OnClick="SortNameButton_Click" Text="Sort By Name" Width="135px" />
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style6"></td>
                            <td class="auto-style7">
                                <asp:Button ID="SortValueButton" runat="server" OnClick="SortValueButton_Click" Text="Sort By Value" Width="135px" />
                            </td>
                            <td class="auto-style6"></td>
                        </tr>
                    </table>
                </td>
                <td class="auto-style5">
                    <asp:ListBox ID="AddedItemsList" runat="server" Height="100%" Width="422px"></asp:ListBox>
                </td>
            </tr>
        </table>
        <p>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="AddItemTextBox" ErrorMessage="Pairs must be in the format Key=Value" ValidationExpression="([a-zA-Z0-9]| )*=([a-zA-Z0-9]| )*"></asp:RegularExpressionValidator>
        </p>
    </form>
</body>
</html>
