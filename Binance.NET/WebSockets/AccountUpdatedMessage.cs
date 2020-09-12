using Newtonsoft.Json;
using System.Collections.Generic;

namespace Binance.NET.WebSockets
{
    /// <summary>
    /// The account updated message.
    /// </summary>
    public class AccountUpdatedMessage
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
        /// Gets or sets the maker commission.
        /// </summary>
        [JsonProperty("m")]
        public int MakerCommission { get; set; }
        /// <summary>
        /// Gets or sets the taker commission.
        /// </summary>
        [JsonProperty("t")]
        public int TakerCommission { get; set; }
        /// <summary>
        /// Gets or sets the buyer commission.
        /// </summary>
        [JsonProperty("b")]
        public int BuyerCommission { get; set; }
        /// <summary>
        /// Gets or sets the seller commission.
        /// </summary>
        [JsonProperty("s")]
        public int SellerCommission { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether can trade.
        /// </summary>
        [JsonProperty("t")]
        public bool CanTrade { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether can withdraw.
        /// </summary>
        [JsonProperty("w")]
        public bool CanWithdraw { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether can deposit.
        /// </summary>
        [JsonProperty("d")]
        public bool CanDeposit { get; set; }
        /// <summary>
        /// Gets or sets the balances.
        /// </summary>
        [JsonProperty("B")]
        public IEnumerable<Balance> Balances { get; set; }
    }
    /// <summary>
    /// The balance.
    /// </summary>
    public class Balance
    {
        /// <summary>
        /// Gets or sets the asset.
        /// </summary>
        [JsonProperty("a")]
        public string Asset { get; set; }
        /// <summary>
        /// Gets or sets the free.
        /// </summary>
        [JsonProperty("f")]
        public decimal Free { get; set; }
        /// <summary>
        /// Gets or sets the locked.
        /// </summary>
        [JsonProperty("l")]
        public decimal Locked { get; set; }
    }
}
