using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;

namespace Xprint
{
    public class XPrint
    {
        [StructLayout(LayoutKind.Sequential)]

        public struct OVERLAPPED
        {
            int Internal;
            int InternalHigh;
            int Offset;
            int OffSetHigh;
            int hEvent;
        }

        [DllImport("kernel32.dll")]
        private static extern int CreateFile(string lpFileName, uint dwDesiredAccess, int dwShareMode, int lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, int hTemplateFile);

        [DllImport("kernel32.dll")]
        private static extern bool WriteFile(int hFile, byte[] lpBuffer, int nNumberOfBytesToWriter, out int lpNumberOfBytesWriten, out OVERLAPPED lpOverLapped);

        [DllImport("kernel32.dll")]
        private static extern bool CloseHandle(int hObject);

        private static int iHandle;

        //打开LPT 端口
        public static bool Open(string FileNo)
        {
            if (FileNo.Length == 0) { FileNo = "LPT1"; }
            iHandle = CreateFile(FileNo, 0x40000000, 0, 0, 3, 0, 0);
            if (iHandle != -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //打印函数，参数为打印机的命令或者其他文本！
        public static bool Write(string MyString)
        {
            if (iHandle != 1)
            {
                int i;
                OVERLAPPED x;
                byte[] mybyte = System.Text.Encoding.Default.GetBytes(MyString);
                return WriteFile(iHandle, mybyte, mybyte.Length, out i, out x);
            }
            else
            {
                throw new Exception("端口未打开~！");
            }
        }

        //打印函数，参数为打印机的命令或者其他文本！
        public static bool Print(string strtxt, string comport)
        {
            try
            {
                if (Open(comport.Trim()))
                {
                    if (iHandle != 1)
                    {
                        int i;
                        OVERLAPPED x;
                        byte[] mybyte = System.Text.Encoding.Default.GetBytes(strtxt);
                        var returnValue = WriteFile(iHandle, mybyte, mybyte.Length, out i, out x);

                        return returnValue;
                    }
                    else
                    {
                        throw new Exception("端口未打开~！");
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Close();
            }


        }

        //写文件，参数为打印机的命令或者其他文本！
        public static string WriteTxT(string filePath, StringBuilder strtxt)
        {
            string pathname = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "0labeltxt";
            string allfileNamepath = System.IO.Path.Combine(pathname, filePath);
            string logofile = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"Resources\logo.png";

            if (!System.IO.File.Exists(pathname))
            {

                System.IO.Directory.CreateDirectory(pathname);

            }
            if (System.IO.File.Exists(logofile) && !System.IO.File.Exists(@"D:\logo.png"))
            { 
                System.IO.File.Copy(logofile, @"D:\logo.png", true);
            }
            FileStream filetxt = new FileStream(allfileNamepath, FileMode.OpenOrCreate);
            StreamWriter fileWrite = new StreamWriter(filetxt, Encoding.UTF8);
            try
            {
                fileWrite.Write(strtxt.ToString());
                fileWrite.Flush();

                fileWrite.Close();
                filetxt.Close();
                return allfileNamepath;
            }
            catch (Exception ex)
            {
                fileWrite.Close();
                filetxt.Close();
                return "";
            }


        }

        //关闭打印端口
        public static bool Close()
        {
            return CloseHandle(iHandle);
        }
    }
}
