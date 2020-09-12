using Newtonsoft.Json;

namespace Binance.NET.Account
{
    /// <summary>
    /// The trade.
    /// </summary>
    public class Trade
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        [JsonProperty("price")]
        public decimal Price { get; set; }
        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        [JsonProperty("qty")]
        public decimal Quantity { get; set; }
        /// <summary>
        /// Gets or sets the commission.
        /// </summary>
        [JsonProperty("commission")]
        public decimal Commission { get; set; }
        /// <summary>
        /// Gets or sets the commission asset.
        /// </summary>
        [JsonProperty("commissionAsset")]
        public string CommissionAsset { get; set; }
        /// <summary>
        /// Gets or sets the time.
        /// </summary>
        [JsonProperty("time")]
        public long Time { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether is buyer.
        /// </summary>
        [JsonProperty("isBuyer")]
        public bool IsBuyer { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether is maker.
        /// </summary>
        [JsonProperty("isMaker")]
        public bool IsMaker { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether best is match.
        /// </summary>
        [JsonProperty("isBestMatch")]
        public bool IsBestMatch { get; set; }
    }
}
