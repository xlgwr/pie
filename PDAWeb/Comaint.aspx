<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Comaint.aspx.cs" Inherits="Comaint" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>欢迎使用PDA扫描程式</title>
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7" />
    <meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
    <meta content="C#" name="CODE_LANGUAGE">
    <meta content="JavaScript" name="vs_defaultClientScript">
    <meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
    <link href="Style.css" rel="stylesheet" type="text/css" />
    <script src="js/jquery-1.11.1.js"></script>
    <script lang="javascript" for="document" event="onkeydown">

        var e = event.srcElement;

        if ((e == document.getElementById("txtboxid")) && (event.keyCode == 13)) {
            document.getElementById("txtboxid").focus();
            document.getElementById("BtnOK").click();
            //$(function () {
            //    $("#BtnOK").click();
            //});
        }
        if ((e == document.getElementById("txtPalletNum")) && (event.keyCode == 13)) {
            document.getElementById("txtboxid").focus();
            //$(function () {
            //    $("#BtnOK").click();
            //});
        }
        if ((e == document.getElementById("txtCo")) && (event.keyCode == 13)) {
            document.getElementById("BtnOK").click();
            //$(function () {
            //    $("#BtnOK").click();
            //});
        }


    </script>
    <script lang="javascript">
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
        // 判断浏览器种类
        function exitFullscreen() {
            if (document.exitFullscreen) {
                document.exitFullscreen();
            } else if (document.mozCancelFullScreen) {
                document.mozCancelFullScreen();
            } else if (document.webkitExitFullscreen) {
                document.webkitExitFullscreen();
            }
        }

        // 退出全屏模式!
        //exitFullscreen();
        // 启动全屏!
        //launchFullScreen(document.documentElement); // 整个网页
        //launchFullScreen(document.getElementById("videoElement")); // 某个页面元素
    </script>
    <style type="text/css">
        
        .hiddenBtn {
        }

        .auto-style2 {
            width: 90px;
        }

        :-webkit-full-screen {
            /* properties */
        }

        :-moz-full-screen {
            /* properties */
        }

        :-ms-fullscreen {
            /* properties */
        }

        :full-screen { /*pre-spec */
            /* properties */
        }

        :fullscreen { /* spec */
            /* properties */
        }

        /* deeper elements */
        :-webkit-full-screen video {
            width: 100%;
            height: 100%;
        }

        /* styling the backdrop*/
        ::backdrop {
            /* properties */
        }

        ::-ms-backdrop {
            /* properties */
        }

        .auto-style3 {
            width: 52px;
        }
    </style>
</head>
<body topmargin="0" onkeydown="javascript:if(event.keyCode==13) return false;">
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <table id="Table2" style="width: 200px; border-right: #339999 thin solid; border-top: #339999 thin solid; border-left: #339999 thin solid; border-bottom: #339999 thin solid;"
            cellspacing="0"
            cellpadding="0" align="center" border="0">
            <tr height="25">
                <td style="width: 200px; background-color: #339999;" align="center" bgcolor="#b0e0e6">
                    <span>CoMaint</span>
                </td>
            </tr>
            <tr height="60">
                <td style="width: 200px;" align="center" bgcolor="#dbeefd" valign="middle">
                    <table>
                        <tr>
                            <td align="left" class="auto-style3">PINum:
                            </td>
                            <td colspan="3" class="auto-style2">
                                <asp:TextBox ID="txtpiid" runat="server" Width="111px" ReadOnly="True"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="left" class="auto-style3">
                                Pallet#:
                            </td>
                            <td colspan="3" class="auto-style2">
                                <asp:Label ID="txtPalletNum" runat="server"></asp:Label>
                            </td>
                            <%--<td colspan="4" align="left" class="auto-style1">
                                <asp:Label ID="txtPalletNum" runat="server"></asp:Label>
                            </td>--%>
                        </tr>
                        <tr>
                            <td align="left" class="auto-style3">
                                CtnSN:
                            </td>
                            <td colspan="3" class="auto-style2">
                                <asp:Label ID="txtboxid" runat="server"></asp:Label>
                            </td>
                            <%--<td colspan="4" class="auto-style2">
                                <asp:Label ID="txtboxid" runat="server"></asp:Label>
                            </td>--%>
                        </tr>
                        <tr>
                            <td align="left" class="auto-style3">Part#:<font style="font-size: 10pt"> </font>
                            </td>
                            <td colspan="3" class="auto-style2">
                                <asp:TextBox ID="txtPart" runat="server" Width="111px" AutoPostBack="True"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="left" class="auto-style3">CO:<font style="font-size: 10pt"> </font>
                            </td>
                            <td colspan="3" class="auto-style2">
                                <asp:TextBox ID="txtCo" runat="server" Width="111px" AutoPostBack="True"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3" align="left" class="auto-style2">
                                <asp:Label ID="lbl3co" runat="server" Style=" width:100px; text-align: left"></asp:Label>
                            </td>
                        </tr>
                    </table>
                    <asp:Label ID="lblMessage" runat="server" Font-Bold="True" ForeColor="Red" Font-Size="10pt" CssClass="Brak"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="center" bgcolor="#b0e0e6" style="width: 200px; background-color: #339999;">
                    <asp:Button ID="BtnOK" runat="server" Text="保存" CssClass="hiddenBtn" Width="43px" OnClick="BtnOK_Click" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>

