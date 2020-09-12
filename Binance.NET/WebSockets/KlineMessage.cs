using Newtonsoft.Json;

namespace Binance.NET.WebSockets
{
    /// <summary>
    /// The kline message.
    /// </summary>
    public class KlineMessage
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
        /// Gets or sets the kline info.
        /// </summary>
        [JsonProperty("k")]
        public KlineData KlineInfo { get; set; }

        /// <summary>
        /// The kline data.
        /// </summary>
        public class KlineData
        {
            /// <summary>
            /// Gets or sets the start time.
            /// </summary>
            [JsonProperty("t")]
            public long StartTime { get; set; }
            /// <summary>
            /// Gets or sets the end time.
            /// </summary>
            [JsonProperty("T")]
            public long EndTime { get; set; }
            /// <summary>
            /// Gets or sets the symbol.
            /// </summary>
            [JsonProperty("s")]
            public string Symbol { get; set; }
            /// <summary>
            /// Gets or sets the interval.
            /// </summary>
            [JsonProperty("i")]
            public string Interval { get; set; }
            /// <summary>
            /// Gets or sets the first trade id.
            /// </summary>
            [JsonProperty("f")]
            public int FirstTradeId { get; set; }
            /// <summary>
            /// Gets or sets the last trade id.
            /// </summary>
            [JsonProperty("L")]
            public int LastTradeId { get; set; }
            /// <summary>
            /// Gets or sets the open.
            /// </summary>
            [JsonProperty("o")]
            public decimal Open { get; set; }
            /// <summary>
            /// Gets or sets the close.
            /// </summary>
            [JsonProperty("c")]
            public decimal Close { get; set; }
            /// <summary>
            /// Gets or sets the high.
            /// </summary>
            [JsonProperty("h")]
            public decimal High { get; set; }
            /// <summary>
            /// Gets or sets the low.
            /// </summary>
            [JsonProperty("l")]
            public decimal Low { get; set; }
            /// <summary>
            /// Gets or sets the volume.
            /// </summary>
            [JsonProperty("v")]
            public decimal Volume { get; set; }
            /// <summary>
            /// Gets or sets the number of trades.
            /// </summary>
            [JsonProperty("n")]
            public int NumberOfTrades { get; set; }
            /// <summary>
            /// Gets or sets a value indicating whether is final.
            /// </summary>
            [JsonProperty("x")]
            public bool IsFinal { get; set; }
            /// <summary>
            /// Gets or sets the quote volume.
            /// </summary>
            [JsonProperty("q")]
            public decimal QuoteVolume { get; set; }
            /// <summary>
            /// Gets or sets the active buy volume.
            /// </summary>
            [JsonProperty("V")]
            public decimal ActiveBuyVolume { get; set; }
            /// <summary>
            /// Gets or sets the active buy quote volume.
            /// </summary>
            [JsonProperty("Q")]
            public decimal ActiveBuyQuoteVolume { get; set; }
        }
    }
}
