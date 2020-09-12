using Newtonsoft.Json;

namespace Binance.NET.WebSockets
{
    /// <summary>
    /// The order or trade updated message.
    /// </summary>
    public class OrderOrTradeUpdatedMessage
    {
        /// <summary>
        /// Gets or sets the order or trade report.
        /// </summary>
        [JsonProperty("e")]
        public string OrderOrTradeReport { get; set; }
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
        /// Gets or sets the new client order id.
        /// </summary>
        [JsonProperty("c")]
        public string NewClientOrderId { get; set; }
        /// <summary>
        /// Gets or sets the side.
        /// </summary>
        [JsonProperty("S")]
        public string Side { get; set; }
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [JsonProperty("o")]
        public string Type { get; set; }
        /// <summary>
        /// Gets or sets the time in force.
        /// </summary>
        [JsonProperty("f")]
        public string TimeInForce { get; set; }
        /// <summary>
        /// Gets or sets the original quantity.
        /// </summary>
        [JsonProperty("q")]
        public decimal OriginalQuantity { get; set; }
        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        [JsonProperty("p")]
        public decimal Price { get; set; }
        /// <summary>
        /// Gets or sets the execution type.
        /// </summary>
        [JsonProperty("x")]
        public string ExecutionType { get; set; }
        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        [JsonProperty("X")]
        public string Status { get; set; }
        /// <summary>
        /// Gets or sets the reject reason.
        /// </summary>
        [JsonProperty("r")]
        public string RejectReason { get; set; }
        /// <summary>
        /// Gets or sets the orderid.
        /// </summary>
        [JsonProperty("i")]
        public int Orderid { get; set; }
        /// <summary>
        /// Gets or sets the last filled trade quantity.
        /// </summary>
        [JsonProperty("l")]
        public decimal LastFilledTradeQuantity { get; set; }
        /// <summary>
        /// Gets or sets the filled trades accumulated quantity.
        /// </summary>
        [JsonProperty("z")]
        public decimal FilledTradesAccumulatedQuantity { get; set; }
        /// <summary>
        /// Gets or sets the last filled trade price.
        /// </summary>
        [JsonProperty("L")]
        public decimal LastFilledTradePrice { get; set; }
        /// <summary>
        /// Gets or sets the commission.
        /// </summary>
        [JsonProperty("n")]
        public decimal Commission { get; set; }
        /// <summary>
        /// Gets or sets the commission asset.
        /// </summary>
        [JsonProperty("N")]
        public string CommissionAsset { get; set; }
        /// <summary>
        /// Gets or sets the trade time.
        /// </summary>
        [JsonProperty("T")]
        public long TradeTime { get; set; }
        /// <summary>
        /// Gets or sets the trade id.
        /// </summary>
        [JsonProperty("t")]
        public int TradeId { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether buyer is maker.
        /// </summary>
        [JsonProperty("m")]
        public bool BuyerIsMaker { get; set; }
    }
}
