using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using IDR.Frm.Logon;

namespace IDR.Frm
{
    static class Program
    {
        #region def para ider

        public static string _frm0Version;
        public static string _frm1VersionLast;
        public static string _frm6Versionprefix;

        public static int _frm3VersionDotNet;
        public static int _frm4VersionMain;
        public static int _frm5VersionSecond;

        public static bool _frm7VersionUpdateFlag = false;
        public static string _frm8VersionMsg;
        public static string _frm9VersionURL;
        public static string _frm10VersionFixMsg;

        public static string _uploaderpmsg = "";
        public static string _uploaderrows = "";
        public static string _strURL = "";

        static LogonDomain LogonOn = null;

        #endregion
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            initValue();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //add thread exception
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            //
            Application.Run(new LogonDomain());


        }

        private static void initValue()
        {
            //frmVersion = "@2V20141010H10-dev";
            _frm3VersionDotNet = 2;
            _frm4VersionMain = 20141208;

            _frm5VersionSecond = 08;
            _frm6Versionprefix = "RTM";//RTM
            //fix msg
            _frm10VersionFixMsg = "1.fix bug";
            //dev  main
            _frm0Version = "@" + _frm3VersionDotNet + "V" + _frm4VersionMain + "H" + _frm5VersionSecond + "-" + _frm6Versionprefix;

            _strURL = "http://142.2.47.149/pisoft/net" + _frm3VersionDotNet + ".0/0" + _frm6Versionprefix;
        }
        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            //throw new NotImplementedException("error thread:"+e.Exception.Message);
            MessageBox.Show(e.Exception.Message);
        }
        /// <summary>
        /// ShowNew Version
        /// </summary>
        /// <param name="lk">linklabel</param>
        /// <returns>true: new,false: nothing</returns>
        public static bool showNewVersion(LinkLabel lk)
        {
            //checkNewVersion();
            if (Program._frm7VersionUpdateFlag)
            {
                lk.Visible = true;
                lk.Text = "New Version!" + Program._frm1VersionLast + ", Click to DownLoad.";
                lk.LinkClicked += link0NewVersion_LinkClicked;
                return true;
            }
            lk.Visible = false;
            return false;
        }
        static void link0NewVersion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(_frm10VersionFixMsg))
                {
                    MessageBox.Show("New Version: \n" + _frm1VersionLast + "\n\n" + _frm10VersionFixMsg, "Update Notice");
                }
                LinkLabel lk = (LinkLabel)sender;
                lk.Links[0].LinkData = Program._frm9VersionURL;
                if (lk.Visible == true)
                {
                    System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
                    lk.Visible = false;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (LogonOn != null)
                {

                    LogonOn.Close();
                }
                else
                {
                    Application.Exit();
                }
                GC.Collect();
            }
        }
        ///////////////////////////////////new
    }
}
