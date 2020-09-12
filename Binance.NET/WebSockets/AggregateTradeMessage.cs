using Newtonsoft.Json;

namespace Binance.NET.WebSockets
{
    /// <summary>
    /// The aggregate trade message.
    /// </summary>
    public class AggregateTradeMessage
    {
        /// <summary>
        /// Gets or sets the event type.
        /// </summary>
        [JsonProperty("e")]
        public string EventType { get; set; }
        /// <summary>
        /// Gets or sets the event time.
        /// </summary>
        [JsonProperty("E")]
        public long EventTime { get; set; }
        /// <summary>
        /// Gets or sets the symbol.
        /// </summary>
        [JsonProperty("s")]
        public string Symbol { get; set; }
        /// <summary>
        /// Gets or sets the aggregated trade id.
        /// </summary>
        [JsonProperty("a")]
        public int AggregatedTradeId { get; set; }
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
        /// Gets or sets the first breakdown trade id.
        /// </summary>
        [JsonProperty("f")]
        public int FirstBreakdownTradeId { get; set; }
        /// <summary>
        /// Gets or sets the last breakdown trade id.
        /// </summary>
        [JsonProperty("l")]
        public int LastBreakdownTradeId { get; set; }
        /// <summary>
        /// Gets or sets the trade time.
        /// </summary>
        [JsonProperty("T")]
        public long TradeTime { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether buyer is maker.
        /// </summary>
        [JsonProperty("m")]
        public bool BuyerIsMaker { get; set; }
    }
}
