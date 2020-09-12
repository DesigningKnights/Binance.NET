using System.ComponentModel;

namespace Binance.NET.Enums
{
    /// <summary>
    /// HTTPMethods to be used by the API.
    /// </summary>
    public enum ApiMethod
    {
        POST,
        GET,
        PUT,
        DELETE
    }

    /// <summary>
    /// Deposit Status
    /// </summary>
    public enum DepositStatus
    {
        Pending = 0,
        Success = 1
    }

    /// <summary>
    /// Different sides of an order.
    /// </summary>
    public enum OrderSide
    {
        BUY,
        SELL
    }

    /// <summary>
    /// Different types of an order.
    /// </summary>
    public enum OrderType
    {
        LIMIT,
        MARKET
    }

    /// <summary>
    /// Different Time in force of an order.
    /// </summary>
    public enum TimeInForce
    {
        GTC,
        IOC
    }

    /// <summary>
    /// Time interval for the candlestick.
    /// </summary>
    public enum TimeInterval
    {
        [Description("1m")] Minutes_1,
        [Description("3m")] Minutes_3,
        [Description("5m")] Minutes_5,
        [Description("15m")] Minutes_15,
        [Description("30m")] Minutes_30,
        [Description("1h")] Hours_1,
        [Description("2h")] Hours_2,
        [Description("4h")] Hours_4,
        [Description("6h")] Hours_6,
        [Description("8h")] Hours_8,
        [Description("12h")] Hours_12,
        [Description("1d")] Days_1,
        [Description("3d")] Days_3,
        [Description("1w")] Weeks_1,
        [Description("1M")] Months_1
    }

    public enum WithdrawStatus
    {
        EmailSent = 0,
        Cancelled = 1,
        AwaitingApproval = 2,
        Rejected = 3,
        Processing = 4,
        Failure = 5,
        Completed = 6
    }
    
}
