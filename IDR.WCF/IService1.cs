using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace IDR.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    //UrlParameterName is the jsonp callback name in the request url.
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        [WebGet(ResponseFormat=WebMessageFormat.Json)]
        string GetDataJsonpGet();

        [OperationContract]
        [WebGet(ResponseFormat=WebMessageFormat.Json)]
        string GetDataJsonp(string Tid, int lineid);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

     

        // TODO: Add your service operations here

        [OperationContract]
        [WebInvoke(RequestFormat=WebMessageFormat.Json,BodyStyle=WebMessageBodyStyle.WrappedRequest)]
        string GetPlrMstrList(string Tid,int lineid);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
