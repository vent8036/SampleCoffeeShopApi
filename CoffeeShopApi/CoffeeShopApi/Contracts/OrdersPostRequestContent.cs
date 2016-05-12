// Template: Models (ApiModel.t4) version 3.0

// This code was generated by RAML Web Api 2 Scaffolder

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace CoffeeShopApi.CoffeeShopApiRaml.Models
{
    public partial class OrdersPostRequestContent
    {
        


		[JsonProperty("itemid")]
        public string Itemid { get; set; }


		[JsonProperty("count")]
        public decimal? Count { get; set; }


		[JsonProperty("ready")]
        public bool? Ready { get; set; }
    } // end class

} // end Models namespace

