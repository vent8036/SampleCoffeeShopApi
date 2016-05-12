// Template: Controller Interface (ApiControllerInterface.t4) version 3.0

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using CoffeeShopApi.CoffeeShopApiRaml.Models;


namespace CoffeeShopApi.CoffeeShopApiRaml
{
    public interface IMenuitemsController
    {

        IHttpActionResult Get();
        IHttpActionResult Post(Models.MenuitemsPostRequestContent menuitemspostrequestcontent);
        IHttpActionResult GetByItemId([FromUri] string itemId);
        IHttpActionResult Put(Models.MenuitemsItemIdPutRequestContent menuitemsitemidputrequestcontent,[FromUri] string itemId);
        IHttpActionResult Delete([FromUri] string itemId);
    }
}
