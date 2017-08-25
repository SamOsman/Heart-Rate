<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HeartRate.aspx.cs" Inherits="A1SalmaOsman.HeartRate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 84%;
            height: 531px;
            margin-right: 57px;
        }
        .auto-style5 {
            height: 80px;
        }
        .auto-style6 {
            width: 73px;
            height: 70px;
        }
        .auto-style7 {
            width: 383px;
            height: 70px;
        }
        .auto-style8 {
            height: 158px;
        }
        .auto-style9 {
            height: 176px;
        }
        .auto-style10 {
            width: 73px;
            height: 58px;
        }
        .auto-style11 {
            width: 383px;
            height: 58px;
        }
        .auto-style12 {
            height: 79px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style9" colspan="2">
                    <asp:Image ID="imgLogo" runat="server" Height="172px" ImageUrl="~/images/Pensive Parakeet.jpg" Width="190px" />
                </td>
            </tr>
            <tr>
                <td colspan="2" class="auto-style12">
                    <asp:Label ID="lblHeader" runat="server" Font-Size="Larger" Text="Calculate Heart Rate"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">First Name</td>
                <td class="auto-style11">
                    <asp:TextBox ID="txtFirst" runat="server"  Width="176px" OnTextChanged="TextOnly"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">Last Name</td>
                <td class="auto-style11">
                    <asp:TextBox ID="txtLast" runat="server" Width="172px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Gender</td>
                <td class="auto-style7">
                    <asp:RadioButton ID="radFemale" runat="server" Text="Female" />
                    <br />
                    <asp:RadioButton ID="radMale" runat="server" Text="Male" />
                </td>
            </tr>
            <tr>
                <td class="auto-style10">Year Born</td>
                <td class="auto-style11">
                    <asp:TextBox ID="txtYear" runat="server" Width="169px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" class="auto-style5">
                    <asp:Button ID="btnCalc" runat="server" Text="Calculate" OnClick="btn_CalculareRate" Width="146px" />
                    <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btn_Reset" Width="101px" />
                </td>
                <td class="auto-style5">
                    </td>
            </tr>
            <tr>
                <td colspan="3" class="auto-style8">
                    <asp:Label ID="lblOutCome" runat="server"></asp:Label>
                    <br />
                    <asp:Label ID="lblAge" runat="server"></asp:Label>
                    <br />
                    <asp:Label ID="lblMaxRate" runat="server"></asp:Label>
                    <br />
                    <asp:Label ID="lblTargetRate" runat="server"></asp:Label>
                    <br />
                    <asp:Label ID="lblError" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    
    </form>
</body>
</html>
