namespace CoffeeShopApi.Models
{
    public class UserOrder
    {
        public string UserName { get; set; }

        public CoffeeShopApiRaml.Models.Order Order { get; set; }
    }
}