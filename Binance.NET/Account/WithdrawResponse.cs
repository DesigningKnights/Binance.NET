using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binance.NET.Account
{
    /// <summary>
    /// The withdraw response.
    /// </summary>
    public class WithdrawResponse
    {
        /// <summary>
        /// Gets or sets the msg.
        /// </summary>
        [JsonProperty("msg")]
        public string Msg { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether success.
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}
