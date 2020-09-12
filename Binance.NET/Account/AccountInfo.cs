using Newtonsoft.Json;
using System.Collections.Generic;

namespace Binance.NET.Account
{
    /// <summary>
    /// The account info.
    /// </summary>
    public class AccountInfo
    {
        /// <summary>
        /// Gets or sets the maker commission.
        /// </summary>
        [JsonProperty("makerCommission")]
        public int MakerCommission { get; set; }
        /// <summary>
        /// Gets or sets the taker commission.
        /// </summary>
        [JsonProperty("takerCommission")]
        public int TakerCommission { get; set; }
        /// <summary>
        /// Gets or sets the buyer commission.
        /// </summary>
        [JsonProperty("buyerCommission")]
        public int BuyerCommission { get; set; }
        /// <summary>
        /// Gets or sets the seller commission.
        /// </summary>
        [JsonProperty("sellerCommission")]
        public int SellerCommission { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether can trade.
        /// </summary>
        [JsonProperty("canTrade")]
        public bool CanTrade { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether can withdraw.
        /// </summary>
        [JsonProperty("canWithdraw")]
        public bool CanWithdraw { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether can deposit.
        /// </summary>
        [JsonProperty("canDeposit")]
        public bool CanDeposit { get; set; }
        /// <summary>
        /// Gets or sets the balances.
        /// </summary>
        [JsonProperty("balances")]
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
        [JsonProperty("asset")]
        public string Asset { get; set; }
        /// <summary>
        /// Gets or sets the free.
        /// </summary>
        [JsonProperty("free")]
        public decimal Free { get; set; }
        /// <summary>
        /// Gets or sets the locked.
        /// </summary>
        [JsonProperty("locked")]
        public decimal Locked { get; set; }
    }
}
