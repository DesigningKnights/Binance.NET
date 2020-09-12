using Newtonsoft.Json;

namespace Binance.NET.Market
{
    /// <summary>
    /// The aggregate trade.
    /// </summary>
    public class AggregateTrade
    {
        /// <summary>
        /// Gets or sets the aggregate trade id.
        /// </summary>
        [JsonProperty("a")]
        public int AggregateTradeId { get; set; }
        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        [JsonProperty("p")]
        public decimal Price { get; set; }
        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        [JsonProperty("q")]
        public decimal Quantity { get; set; }
        /// <summary>
        /// Gets or sets the first trade id.
        /// </summary>
        [JsonProperty("f")]
        public int FirstTradeId { get; set; }
        /// <summary>
        /// Gets or sets the last trade id.
        /// </summary>
        [JsonProperty("l")]
        public int LastTradeId { get; set; }
        /// <summary>
        /// Gets or sets the time stamp.
        /// </summary>
        [JsonProperty("T")]
        public long TimeStamp { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether buyer is maker.
        /// </summary>
        [JsonProperty("m")]
        public bool BuyerIsMaker { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether best price match.
        /// </summary>
        [JsonProperty("M")]
        public bool BestPriceMatch { get; set; }
    }
}
