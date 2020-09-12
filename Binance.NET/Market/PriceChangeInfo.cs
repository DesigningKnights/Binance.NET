using Newtonsoft.Json;

namespace Binance.NET.Market
{
    /// <summary>
    /// The price change info.
    /// </summary>
    public class PriceChangeInfo
    {
        /// <summary>
        /// Gets or sets the symbol.
        /// </summary>
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
        /// <summary>
        /// Gets or sets the price change.
        /// </summary>
        [JsonProperty("priceChange")]
        public decimal PriceChange { get; set; }
        /// <summary>
        /// Gets or sets the price change percent.
        /// </summary>
        [JsonProperty("priceChangePercent")]
        public decimal PriceChangePercent { get; set; }
        /// <summary>
        /// Gets or sets the weighted avg price.
        /// </summary>
        [JsonProperty("weightedAvgPrice")]
        public decimal WeightedAvgPrice { get; set; }
        /// <summary>
        /// Gets or sets the prev close price.
        /// </summary>
        [JsonProperty("prevClosePrice")]
        public decimal PrevClosePrice { get; set; }
        /// <summary>
        /// Gets or sets the last price.
        /// </summary>
        [JsonProperty("lastPrice")]
        public decimal LastPrice { get; set; }
        /// <summary>
        /// Gets or sets the bid price.
        /// </summary>
        [JsonProperty("bidPrice")]
        public decimal BidPrice { get; set; }
        /// <summary>
        /// Gets or sets the ask price.
        /// </summary>
        [JsonProperty("askPrice")]
        public decimal AskPrice { get; set; }
        /// <summary>
        /// Gets or sets the open price.
        /// </summary>
        [JsonProperty("openPrice")]
        public decimal OpenPrice { get; set; }
        /// <summary>
        /// Gets or sets the high price.
        /// </summary>
        [JsonProperty("highPrice")]
        public decimal HighPrice { get; set; }
        /// <summary>
        /// Gets or sets the low price.
        /// </summary>
        [JsonProperty("lowPrice")]
        public decimal LowPrice { get; set; }
        /// <summary>
        /// Gets or sets the volume.
        /// </summary>
        [JsonProperty("volume")]
        public decimal Volume { get; set; }
        /// <summary>
        /// Gets or sets the open time.
        /// </summary>
        [JsonProperty("openTime")]
        public long OpenTime { get; set; }
        /// <summary>
        /// Gets or sets the close time.
        /// </summary>
        [JsonProperty("closeTime")]
        public long CloseTime { get; set; }
        /// <summary>
        /// Gets or sets the first id.
        /// </summary>
        [JsonProperty("firstId")]
        public int FirstId { get; set; }
        /// <summary>
        /// Gets or sets the last id.
        /// </summary>
        [JsonProperty("lastId")]
        public int LastId { get; set; }
        /// <summary>
        /// Gets or sets the count.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }
    }
}
