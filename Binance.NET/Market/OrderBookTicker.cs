using Newtonsoft.Json;

namespace Binance.NET.Market
{
    /// <summary>
    /// The order book ticker.
    /// </summary>
    public class OrderBookTicker
    {
        /// <summary>
        /// Gets or sets the symbol.
        /// </summary>
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
        /// <summary>
        /// Gets or sets the bid price.
        /// </summary>
        [JsonProperty("bidPrice")]
        public decimal BidPrice { get; set; }
        /// <summary>
        /// Gets or sets the bid quantity.
        /// </summary>
        [JsonProperty("bidQty")]
        public decimal BidQuantity { get; set; }
        /// <summary>
        /// Gets or sets the ask price.
        /// </summary>
        [JsonProperty("askPrice")]
        public decimal AskPrice { get; set; }
        /// <summary>
        /// Gets or sets the ask quantity.
        /// </summary>
        [JsonProperty("askQty")]
        public decimal AskQuantity { get; set; }
    }
}
