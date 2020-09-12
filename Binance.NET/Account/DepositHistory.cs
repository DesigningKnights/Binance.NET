using Newtonsoft.Json;
using System.Collections.Generic;

namespace Binance.NET.Account
{
    /// <summary>
    /// The deposit.
    /// </summary>
    public class Deposit
    {
        /// <summary>
        /// Gets or sets the insert time.
        /// </summary>
        [JsonProperty("insertTime")]
        public long InsertTime { get; set; }
        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        [JsonProperty("amount")]
        public decimal Amount { get; set; }
        /// <summary>
        /// Gets or sets the asset.
        /// </summary>
        [JsonProperty("asset")]
        public string Asset { get; set; }
        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }
    }

    /// <summary>
    /// The deposit history.
    /// </summary>
    public class DepositHistory
    {
        /// <summary>
        /// Gets or sets the deposit list.
        /// </summary>
        [JsonProperty("depositList")]
        public IEnumerable<Deposit> DepositList { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether success.
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }
    }

}
