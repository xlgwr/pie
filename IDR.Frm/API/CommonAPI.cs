using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace IDR.Frm.API
{
    class CommonAPI
    {
        Default _frmDefault;

        public CommonAPI() { }

        public CommonAPI(Default frmDefault)
        {
            _frmDefault = frmDefault;
        }
        /// <summary>
        ///  ControlIsNullOrEmpty
        /// </summary>
        /// <param name="msg">messageBox msg</param>
        /// <param name="cl">control name</param>
        /// <returns>true,false</returns>
        public bool ControlIsNullOrEmpty(string msg, Control cl)
        {
            if (string.IsNullOrEmpty(cl.Text))
            {
                MessageBox.Show(msg);
                cl.Focus();
                return true;
            }
            return false;
        }
        
        /// <summary>
        ///  ControlIsNullOrEmpty
        /// </summary>
        /// <param name="msg">label msg</param>
        /// <param name="cl">control name</param>
        /// <returns>true,false</returns>
        public bool ControlIsNullOrEmpty(string msg, Control cl, Control clnotice)
        {
            if (string.IsNullOrEmpty(cl.Text))
            {
                cl.Focus();
                clnotice.Text = msg;
                return true;
            }
            return false;
        }
        //////////////////////////////////add new

    }
}
