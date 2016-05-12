// Template: Controller Implementation (ApiControllerImplementation.t4) version 3.0

using System.Web.Http;
using CoffeeShopApi.CoffeeShopApiRaml.Models;
using CoffeeShopApi.Models;
using CoffeeShopApi.Attributes;

namespace CoffeeShopApi.CoffeeShopApiRaml
{
    public partial class OrdersController : IOrdersController
    {

		/// <summary>
		/// All orders
		/// </summary>
		/// <param name="offset">Offset the list of returned results by this amount. Default is zero.</param>
		/// <param name="limit">Number of items to retrieve. Default is 5, maximum is 10.</param>
		/// <returns>OrdersGetOKResponseContent</returns>
        [Authorize(Roles="Barista")]
        public IHttpActionResult Get([FromUri] int offset,[FromUri] int limit)
        {
            // TODO: implement Get - route: orders/
			// var result = new OrdersGetOKResponseContent();
			// return Ok(result);
			return Ok();
        }

		/// <summary>
		/// Create order
		/// </summary>
		/// <param name="orderspostrequestcontent"></param>
        [Authorize]
        public IHttpActionResult Post(Models.OrdersPostRequestContent orderspostrequestcontent)
        {
            // TODO: implement Post - route: orders/
			return Ok();
        }

		/// <summary>
		/// Order details
		/// </summary>
		/// <param name="orderId">The unique id of the requested order</param>
		/// <returns>OrdersOrderIdGetOKResponseContent</returns>
        [Authorize]
        [CacheControl(MaxAge = 60)] //Allow requests to be cached for a minute since it can take a while to fulfill an order
        public IHttpActionResult GetByOrderId([FromUri] string orderId)
        {
            var userOrder = GetUserOrder(orderId);
            
            if (userOrder != null && (User.IsInRole("Barista") || OrderIsForUser(userOrder, User.Identity.Name)))
            {
                return Ok(new OrdersOrderIdGetOKResponseContent {
                    Itemid = userOrder.Order.Itemid,
                    Count = userOrder.Order.Count,
                    Ready = userOrder.Order.Ready
                });
            }

            return NotFound();
        }

        /// <summary>
        /// Update order
        /// </summary>
        /// <param name="ordersorderidputrequestcontent"></param>
        /// <param name="orderId">The unique id of the requested order</param>
        /// <returns>OrdersOrderIdPutOKResponseContent</returns>
        [Authorize(Roles = "Barista")]
        public IHttpActionResult Put(Models.OrdersOrderIdPutRequestContent ordersorderidputrequestcontent,[FromUri] string orderId)
        {
            // TODO: implement Put - route: orders/{orderId}
			// var result = new OrdersOrderIdPutOKResponseContent();
			// return Ok(result);
			return Ok();
        }

        private UserOrder GetUserOrder(string orderId)
        {
            return new UserOrder
            {
                UserName = "Bob",
                Order = new Order()
            };
        }

        private bool OrderIsForUser(UserOrder userOrder, string userName)
        {
            return userOrder.UserName == userName;
        }

    }
}
