using System.ComponentModel;

namespace TimServe.Core;

/// <summary>
/// 账号来源枚举
/// </summary>
[Description("账号来源枚举")]
public enum AccountSourceEnum
{
    /// <summary>
    /// PC
    /// </summary>
    [Description("Pc")] Pc = 999,

    /// <summary>
    /// APP
    /// </summary>
    [Description("App")] App = 888,

    /// <summary>
    /// H5
    /// </summary>
    [Description("H5")] H5 = 777,

    /// <summary>
    /// 微信小程序
    /// </summary>
    [Description("微信小程序")] WeMiniApp = 666,

    /// <summary>
    /// 抖音小程序
    /// </summary>
    [Description("抖音小程序")] DMiniApp = 555,

    /// <summary>
    /// 其他小程序
    /// </summary>
    [Description("其他小程序")] OtherMiniApp = 444,
}