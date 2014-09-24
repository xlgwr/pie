using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IDR.WCF
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Service1 s = new Service1();
            var plr = s.GetPlrMstrList("R1409220012", 2);
            Response.Write(plr);
        }
    }
}