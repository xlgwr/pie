<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ScanSet.aspx.cs" Inherits="ScanSet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>欢迎使用PI Mstr Info设定程式</title>
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7" />
    <meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
    <meta content="C#" name="CODE_LANGUAGE">
    <meta content="JavaScript" name="vs_defaultClientScript">
    <meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
    <link href="Style.css" rel="stylesheet" type="text/css" />
    <script src="js/jquery-1.11.1.js"></script>
    <script language="javascript" for="document" event="onkeydown">
        var e = event.srcElement;
        if ((e == document.getElementById("txtPIID")) && (event.keyCode == 13)) {


            document.getElementById("BtnSure").click();
            //$(function () {
            //    $("#BtnSure").click();
            //});
        }
        if ((e == document.getElementById("txtPalletNum")) && (event.keyCode == 13)) {

            document.getElementById("BtnSure").click();
            //$(function () {
            //    $("#BtnSure").click();
            //});
        }
        if ((e == document.getElementById("txtNW")) && (event.keyCode == 13)) {

            document.getElementById("btnnw").click();
            //$(function () {
            //    $("#BtnSure").click();
            //});
        }
        if ((e == document.getElementById("ddlType")) && (event.keyCode == 13)) {

            document.getElementById("BtnSure").click();
            //$(function () {
            //    $("#BtnSure").click();
            //});
        }
        // 判断各种浏览器，找到正确的方法
        function launchFullscreen(element) {
            if (element.requestFullscreen) {
                element.requestFullscreen();
            } else if (element.mozRequestFullScreen) {
                element.mozRequestFullScreen();
            } else if (element.webkitRequestFullscreen) {
                element.webkitRequestFullscreen();
            } else if (element.msRequestFullscreen) {
                element.msRequestFullscreen();
            }
        }
        // 启动全屏!
        //launchFullScreen(document.documentElement); // 整个网页
        //launchFullScreen(document.getElementById("videoElement")); // 某个页面元素
    </script>
    <style type="text/css">
        .style1 {
            color: #FFFFFF;
        }

        .txtu {
        }
    </style>
</head>
<body topmargin="0" onkeydown="javascript:if(event.keyCode==13) return false;">
    <form id="form1" runat="server">

        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <table id="Table2" style="width: 200px; border-right: #339999 thin solid; border-top: #339999 thin solid; border-left: #339999 thin solid; border-bottom: #339999 thin solid;"
            cellspacing="0"
            cellpadding="0" align="center" border="0">
            <tr height="20">
                <td style="width: 200px; height: 20px; background-color: #339999;" align="center"
                    bgcolor="#b0e0e6" class="style1">Pi Mstr Info设定
                </td>
            </tr>
            <tr>
                <td style="width: 200px; height: 40px" align="center" bgcolor="#dbeefd" valign="middle">
                    <table>
                        <tr>
                            <td align="right" style="width: 40px; height: 20px;" class="table_body">PINum:
                            </td>
                            <td style="width: 100px; height: 20px;" class="table_none" colspan="2">
                                <asp:TextBox ID="txtPIID" runat="server" CssClass="txtu" Width="120px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" style="width: 40px; height: 20px;" class="table_body">Pallet#:
                            </td>
                            <td align="left" style="width: 100px; height: 20px;" class="table_none" colspan="2">
                                <asp:DropDownList ID="txtPalletNum" runat="server" Width="120px" Height="16px" AutoPostBack="True" OnSelectedIndexChanged="txtPalletNum_SelectedIndexChanged">
                                </asp:DropDownList>
                                <asp:Button ID="txtPalletAdd" runat="server" OnClick="txtPalletAdd_Click" Text="+" Width="25px" Height="24px" />
                            </td>
                        </tr>
                        <tr>
                            <td align="right" style="width: 40px; height: 20px;" class="table_body">PNW:
                            </td>
                            <td style="width: 100px; height: 20px;" class="table_none" colspan="2">
                                <asp:TextBox ID="txtNW" runat="server" CssClass="txtu" Width="120px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" style="width: 40px; height: 20px;" class="table_body">Plant:<font style="font-size: 10pt"> </font>
                            </td>
                            <td style="width: 100px; height: 20px;" class="table_none">
                                <asp:DropDownList ID="ddlPlant" runat="server" Height="25px" Width="126px">
                                    <asp:ListItem>NW</asp:ListItem>
                                    <asp:ListItem>WWTS</asp:ListItem>
                                    <asp:ListItem>WEC</asp:ListItem>
                                    <asp:ListItem>WTSZ</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>

                        <tr>
                            <td align="right" style="width: 40px; height: 20px;" class="table_body">Type:<font style="font-size: 10pt"> </font>
                            </td>
                            <td style="width: 100px; height: 20px;" class="table_none">
                                <asp:DropDownList ID="ddlType" runat="server" Height="25px" Width="126px">
                                    <asp:ListItem>Normal</asp:ListItem>
                                    <asp:ListItem>Rma</asp:ListItem>
                                    <asp:ListItem>Mech</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                    </table>
                    <asp:Label ID="lblMessage" runat="server" Font-Bold="True" ForeColor="Red" Font-Size="10pt"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="center" bgcolor="#b0e0e6" style="width: 200px; height: 20px; background-color: #339999;">
                    <asp:Button ID="BtnSure" runat="server" Text="确认" Height="20px" OnClick="BtnSure_Click" Width="36px" />
                    <asp:Button ID="btnnw" runat="server" Text="保存NW" Height="20px" OnClick="btnnw_Click" Width="51px" />
                    <asp:Button ID="BtnClear" runat="server" Text="清除" Height="20px" OnClick="BtnClear_Click" Width="32px" />
                    <asp:Button ID="BtnExist" runat="server" Text="退出" Height="20px" OnClick="BtnExist_Click" Width="30px" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
