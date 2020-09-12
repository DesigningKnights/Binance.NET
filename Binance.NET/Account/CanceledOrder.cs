using Newtonsoft.Json;

namespace Binance.NET.Account
{
    /// <summary>
    /// The canceled order.
    /// </summary>
    public class CanceledOrder
    {
        /// <summary>
        /// Gets or sets the symbol.
        /// </summary>
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
        /// <summary>
        /// Gets or sets the order id.
        /// </summary>
        [JsonProperty("orderId")]
        public int OrderId { get; set; }
        /// <summary>
        /// Gets or sets the client order id.
        /// </summary>
        [JsonProperty("clientOrderId")]
        public string ClientOrderId { get; set; }
        /// <summary>
        /// Gets or sets the orig client order id.
        /// </summary>
        [JsonProperty("origClientOrderId ")]
        public string OrigClientOrderId { get; set; }
    }
}
