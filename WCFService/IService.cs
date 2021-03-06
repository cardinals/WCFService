﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCFService.Common;

namespace WCFService
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IService1”。
    [ServiceContract]
    public interface IService
    {

        [OperationContract]
        [WebGet(UriTemplate = "/GetCustomer?customerID={customerID}", ResponseFormat = WebMessageFormat.Json)]
        List<Customer> GetCustomer(string customerID);

        [OperationContract]
        [WebGet(UriTemplate = "/GetCustomerByJSon?customerID={customerID}", ResponseFormat = WebMessageFormat.Json)]
        string GetCustomerByJSon(string customerID);

        [OperationContract]
        [WebGet(UriTemplate = "/SetCustomer?customerName={customerName}&customerAddress={customerAddress}", ResponseFormat = WebMessageFormat.Json)]
        void SetCustomer(string customerName, string customerAddress);
    }
}
