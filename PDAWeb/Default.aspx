<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

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
        .auto-style1 {
            width: 91px;
        }

        .hiddenBtn {
        }

        .auto-style2 {
            width: 79px;
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
                    <span>扫描作业</span>
                </td>
            </tr>
            <tr height="60">
                <td style="width: 200px;" align="center" bgcolor="#dbeefd" valign="middle">
                    <table>
                        <tr>
                            <td align="left" class="auto-style1">PI ID:
                            </td>
                            <td colspan="3" class="auto-style2">
                                <asp:TextBox ID="txtpiid" runat="server" Width="97px" ReadOnly="True"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" align="left" class="auto-style1"><asp:Label ID="txtPlant" runat="server" Width="97px"></asp:Label>
                            </td>
                            <td colspan="2" class="auto-style2"><asp:Label ID="txtType" runat="server" Width="97px" ></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="left" class="auto-style1">Pallet#:
                            </td>
                            <td colspan="3" class="auto-style2">
                                <asp:TextBox ID="txtPalletNum" runat="server" Width="97px" ReadOnly="True"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="left" class="auto-style1">WecCtnSN:<font style="font-size: 10pt"> </font>
                            </td>
                            <td colspan="3" class="auto-style2">
                                <asp:TextBox ID="txtboxid" runat="server" Width="97px" AutoPostBack="True" OnTextChanged="txtboxid_TextChanged"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="left" class="auto-style1">CO:<font style="font-size: 10pt"> </font>
                            </td>
                            <td colspan="3" class="auto-style2">
                                <asp:TextBox ID="txtCo" runat="server" Width="97px" OnTextChanged="txtCo_TextChanged" AutoPostBack="True"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4" align="left">
                                <asp:Label ID="lbl3co" runat="server" Style="text-align: left"></asp:Label>
                            </td>
                        </tr>
                    </table>
                    <asp:Label ID="lblMessage" runat="server" Font-Bold="True" ForeColor="Red" Font-Size="10pt" CssClass="Brak"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="center" bgcolor="#b0e0e6" style="width: 200px; background-color: #339999;">
                    <asp:Button ID="BtnClear" runat="server" Text="清除" OnClick="BtnClear_Click" Width="30px" />
                    <asp:Button ID="BtnOK" runat="server" Text="保存" OnClick="BtnOK_Click" CssClass="hiddenBtn" Width="43px" />
                    <asp:Button ID="BtnReturn" runat="server" OnClick="BtnReturn_Click" Text="返回设置" Width="57px" />
                    <asp:Button ID="BtnExit" runat="server" Text="退出" OnClick="BtnExit_Click" Width="30px" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
