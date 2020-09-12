using Newtonsoft.Json;

namespace Binance.NET.Account
{
    /// <summary>
    /// The new order.
    /// </summary>
    public class NewOrder
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
        /// Gets or sets the transact time.
        /// </summary>
        [JsonProperty("transactTime")]
        public long TransactTime { get; set; }
    }
}
