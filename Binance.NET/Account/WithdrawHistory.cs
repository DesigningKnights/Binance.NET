using Newtonsoft.Json;
using System.Collections.Generic;

namespace Binance.NET.Account
{
    /// <summary>
    /// The withdraw history.
    /// </summary>
    public class WithdrawHistory
    {
        /// <summary>
        /// Gets or sets the withdraw list.
        /// </summary>
        [JsonProperty("withdrawList")]
        public IEnumerable<Deposit> WithdrawList { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether success.
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    /// <summary>
    /// The withdraw.
    /// </summary>
    public class Withdraw
    {
        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        [JsonProperty("amount")]
        public decimal Amount { get; set; }
        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }
        /// <summary>
        /// Gets or sets the tx id.
        /// </summary>
        [JsonProperty("txId")]
        public string TxId { get; set; }
        /// <summary>
        /// Gets or sets the asset.
        /// </summary>
        [JsonProperty("asset")]
        public string Asset { get; set; }
        /// <summary>
        /// Gets or sets the apply time.
        /// </summary>
        [JsonProperty("applyTime")]
        public long ApplyTime { get; set; }
        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }
    }
}
