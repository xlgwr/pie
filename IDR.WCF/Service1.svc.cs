using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

using PIE.EF.Model.Dal;
using Newtonsoft.Json;
using System.IO;

namespace IDR.WCF
{

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    //UrlParameterName is the jsonp callback name in the request url.
    [JavascriptCallbackBehavior(UrlParameterName = "jsoncallback")]
    public class Service1 : IService1
    {
        private PIEEntities db = new PIEEntities();

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
        public string GetDataJsonp(string Tid, int lineid)
        {
            try
            {
                plr_mstr plr_model = db.plr_mstr.Find("R1409220012", 2);
                return JsonConvert.SerializeObject(plr_model);
            }
            catch (Exception ex)
            {
                return ex.Message + ",Tid:" + Tid + ",LineID:" + lineid;
            }

        }
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }


        public string GetPlrMstrList(string Tid, int lineid)
        {
            try
            {

                plr_mstr plr_model = db.plr_mstr.Find(Tid, lineid);

                return JsonConvert.SerializeObject(plr_model);

            }
            catch (Exception ex)
            {
                return ex.Message + ",Tid:" + Tid + ",LineID:" + lineid;
            }

        }


        public string GetDataJsonpGet()
        {
            return "msg:'good time'";
        }
    }
}
