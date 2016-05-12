// Template: Controller Interface (ApiControllerInterface.t4) version 3.0

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using CoffeeShopApi.CoffeeShopApiRaml.Models;


namespace CoffeeShopApi.CoffeeShopApiRaml
{
    public interface IOrdersController
    {

        IHttpActionResult Get([FromUri] int offset,[FromUri] int limit);
        IHttpActionResult Post(Models.OrdersPostRequestContent orderspostrequestcontent);
        IHttpActionResult GetByOrderId([FromUri] string orderId);
        IHttpActionResult Put(Models.OrdersOrderIdPutRequestContent ordersorderidputrequestcontent,[FromUri] string orderId);
    }
}
