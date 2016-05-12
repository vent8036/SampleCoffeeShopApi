// Template: Controller Implementation (ApiControllerImplementation.t4) version 3.0

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using CoffeeShopApi.CoffeeShopApiRaml.Models;

namespace CoffeeShopApi.CoffeeShopApiRaml
{
    public partial class MenuitemsController : IMenuitemsController
    {

		/// <summary>
		/// All Menu Items
		/// </summary>
		/// <returns>IList&lt;MenuitemsGetOKResponseContent&gt;</returns>
        public IHttpActionResult Get()
        {
            // TODO: implement Get - route: menuitems/
			// var result = new IList<MenuitemsGetOKResponseContent>();
			// return Ok(result);
			return Ok();
        }

        /// <summary>
        /// Create a new menu item.
        /// </summary>
        /// <param name="menuitemspostrequestcontent"></param>
        /// <returns>MenuitemsPostOKResponseContent</returns>
        [Authorize(Roles = "Barista")]
        public IHttpActionResult Post(Models.MenuitemsPostRequestContent menuitemspostrequestcontent)
        {
            // TODO: implement Post - route: menuitems/
			// var result = new MenuitemsPostOKResponseContent();
			// return Ok(result);
			return Ok();
        }

        /// <summary>
        /// A specific menu item
        /// </summary>
        /// <param name="itemId">The id of the requested item</param>
        /// <returns>MenuitemsItemIdGetOKResponseContent</returns>
        [Authorize(Roles = "Barista")]
        public IHttpActionResult GetByItemId([FromUri] string itemId)
        {
            // TODO: implement GetByItemId - route: menuitems/{itemId}
			// var result = new MenuitemsItemIdGetOKResponseContent();
			// return Ok(result);
			return Ok();
        }

        /// <summary>
        /// Update a specific menu item
        /// </summary>
        /// <param name="menuitemsitemidputrequestcontent"></param>
        /// <param name="itemId">The id of the requested item</param>
        [Authorize(Roles = "Barista")]
        public IHttpActionResult Put(Models.MenuitemsItemIdPutRequestContent menuitemsitemidputrequestcontent,[FromUri] string itemId)
        {
            // TODO: implement Put - route: menuitems/{itemId}
			return Ok();
        }

        /// <summary>
        /// Remove a specific menu item
        /// </summary>
        /// <param name="itemId">The id of the requested item</param>
        [Authorize(Roles = "Barista")]
        public IHttpActionResult Delete([FromUri] string itemId)
        {
            // TODO: implement Delete - route: menuitems/{itemId}
			return Ok();
        }

    }
}
