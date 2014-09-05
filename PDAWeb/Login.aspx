<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>欢迎使用PDA扫描程式</title>

    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7" />
    <meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
    <meta content="C#" name="CODE_LANGUAGE">
    <meta content="JavaScript" name="vs_defaultClientScript">
    <meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">

    <script src="js/jquery-1.11.1.js"></script>
    <script language="javascript" for="document" event="onkeydown">
        var e = event.srcElement;
        if ((e == document.getElementById("txtUserName")) && (event.keyCode == 13))
            document.getElementById("txtPassword").focus();
        if ((e == document.getElementById("txtpwd2")) && (event.keyCode == 13))
            document.getElementById("BtnLogin").click();

        var e = event.srcElement;

        if ((e == document.getElementById("BtnLogin")) && (event.keyCode == 13)) {
            document.getElementById("BtnLogin").click();
            $(function () {
                $("#BtnLogin").click();
            });
        }

    </script>
    <script language='javascript'>
        //window.open('ff.aspx', '_blank', 'fullscreen=yes,toolbar=no,titlebar=no');
       // window.statusbar = false;

    </script>

    <style type="text/css">
        .auto-style1 {
            height: 25px;
            width: 40px;
            text-align: right;
            font-size: small;
        }

        .txtu {
        }
    </style>

</head>
<body topmargin="0" onkeydown="javascript:if(event.keyCode==13) return false;">
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <table id="Table2" style="width: 200px; border-right: #339999 thin solid; border-top: #339999 thin solid; border-left: #339999 thin solid; border-bottom: #339999 thin solid;" cellspacing="0" cellpadding="0"
            align="center" border="0">
            <tr height="15">
                <td style="width: 200px; height: 40px; background-image: url(images/bghead1.jpg);" bgcolor="#f2f9ff" align="center">
                    <asp:Label ID="Label1" runat="server" Font-Size="10pt" Text="扫描程序登陆"></asp:Label></td>
            </tr>
            <tr height="26">
                <td style="width: 200px; height: 20px; background-color: #339999;" align="center" bgcolor="#b0e0e6">
                    <asp:Label ID="Lblmsg" runat="server" Font-Bold="False" Font-Size="10pt" ForeColor="White"
                        Height="17px" Width="71%">请使用系统账号</asp:Label></td>
            </tr>
            <tr height="70">
                <td style="width: 200px; height: 50px" align="center" bgcolor="#dbeefd" valign="middle">
                    <table>

                        <tr>
                            <td align="right" class="auto-style1">DomainName:</td>
                            <td style="width: 100px; height: 25px;" class="table_none">
                                <asp:DropDownList ID="ddlcmp0" runat="server" Height="16px" Width="109px">
                                    <asp:ListItem>WWTS</asp:ListItem>
                                    <asp:ListItem>WEC</asp:ListItem>
                                    <asp:ListItem>WTSZ</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" class="auto-style1">UserName:</td>
                            <td style="width: 100px; height: 18px;" class="table_none">
                                <asp:TextBox ID="txtUserName" runat="server" CssClass="txtu" Width="100px" Height="18px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td align="right" class="auto-style1">
                                <font style="font-size: 10pt">Password：</font>
                            </td>
                            <td style="width: 100px; height: 25px;" class="table_none">
                                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="txtu"
                                    Width="100px" Height="18px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td align="right" class="auto-style1">PassPhrase:</td>
                            <td style="width: 100px; height: 25px;" class="table_none">
                                <asp:TextBox ID="txtpwd2" runat="server" TextMode="Password" CssClass="txtu"
                                    Width="100px" Height="18px"></asp:TextBox></td>
                        </tr>
                    </table>
                    <asp:Label ID="lblMessage" runat="server" Font-Bold="True" ForeColor="Red" Font-Size="10pt" Height="15px"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="center" bgcolor="#b0e0e6" style="width: 200px; height: 26px; background-color: #339999;">
                    <asp:Button ID="BtnLogin" runat="server" Text="登陆" OnClick="BtnLogin_Click" Height="20px" />
                    <asp:Button ID="BtnClear" runat="server" Text="清除" OnClick="BtnClear_Click" Height="20px" />
                    <a href="javascript:self.close()">关闭窗口</a>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
