// Template: Models (ApiModel.t4) version 3.0

// This code was generated by RAML Web Api 2 Scaffolder

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace CoffeeShopApi.CoffeeShopApiRaml.Models
{
    public partial class MenuitemsPostRequestContent
    {
        

        /// <summary>
        /// The unique id of the menu item
        /// </summary>

		[JsonProperty("itemId")]
        public string ItemId { get; set; }

        /// <summary>
        /// The type of item (ex. coffee or tea)
        /// </summary>

		[JsonProperty("category")]
        public string Category { get; set; }

        /// <summary>
        /// The friendly name of the menu item
        /// </summary>

		[JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The size of the menu item (ex. small, medium, or larger)
        /// </summary>

		[JsonProperty("size")]
        public string Size { get; set; }

        /// <summary>
        /// The cost of the item in US dollars (ex. $1.25 or $.50)
        /// </summary>

		[JsonProperty("cost")]
        public string Cost { get; set; }
    } // end class

} // end Models namespace

