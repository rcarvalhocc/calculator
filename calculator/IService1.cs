using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace calculator
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    //cenas
    [ServiceContract]
    public interface IService1
    {
        // TODO: Add your service operations here
        [OperationContract]
        int Sum(int value1, int value2);
        [OperationContract]
        int Subtract(int value1, int value2);
        [OperationContract]
        int Multiply(int value1, int value2);
        [OperationContract]
        double Divide(float value1, float value2);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
//    [DataContract]
//    public class CompositeType
//    {
//        bool boolValue = true;
//        string stringValue = "Hello ";
//
//        [DataMember]
//        public bool BoolValue
//        {
//            get { return boolValue; }
//            set { boolValue = value; }
//        }
//
//        [DataMember]
//        public string StringValue
//        {
//            get { return stringValue; }
//            set { stringValue = value; }
//        }
//    }
}
