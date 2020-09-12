using Newtonsoft.Json;

namespace Binance.NET.Account
{
    /// <summary>
    /// The order.
    /// </summary>
    public class Order
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
        /// Gets or sets the price.
        /// </summary>
        [JsonProperty("price")]
        public decimal Price { get; set; }
        /// <summary>
        /// Gets or sets the orig qty.
        /// </summary>
        [JsonProperty("origQty")]
        public decimal OrigQty { get; set; }
        /// <summary>
        /// Gets or sets the executed qty.
        /// </summary>
        [JsonProperty("executedQty")]
        public decimal ExecutedQty { get; set; }
        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
        /// <summary>
        /// Gets or sets the time in force.
        /// </summary>
        [JsonProperty("timeInForce")]
        public string TimeInForce { get; set; }
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
        /// <summary>
        /// Gets or sets the side.
        /// </summary>
        [JsonProperty("side")]
        public string Side { get; set; }
        /// <summary>
        /// Gets or sets the stop price.
        /// </summary>
        [JsonProperty("stopPrice")]
        public decimal StopPrice { get; set; }
        /// <summary>
        /// Gets or sets the iceberg qty.
        /// </summary>
        [JsonProperty("icebergQty")]
        public decimal IcebergQty { get; set; }
        /// <summary>
        /// Gets or sets the time.
        /// </summary>
        [JsonProperty("time")]
        public long Time { get; set; }
    }
}
