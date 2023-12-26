namespace SuperApi.Core.DataBase.Model;

/// <summary>
/// 租户表
/// </summary>
[SugarTable(null, "租户表")]
[SugarIndex("unique_Tenant_Account", nameof(Tenant.Account), OrderByType.Desc, true)]
[SugarIndex("unique_Tenant_Phone", nameof(Tenant.Phone), OrderByType.Desc, true)]
public class Tenant : BaseModel
{
    /// <summary>
    /// 账号，即库名，要求不能有中文：英文，英文加数字
    /// Id 即数据库的ConnId
    /// </summary>
    [SugarColumn(ColumnDescription = "账号", Length = 32)]
    [Required, MaxLength(32)]
    public string Account { get; set; } = "";

    /// <summary>
    /// 密码
    /// </summary>
    [SugarColumn(ColumnDescription = "密码", Length = 512)]
    [MaxLength(512)]
    [System.Text.Json.Serialization.JsonIgnore]
    [JsonIgnore]
    public string Password { get; set; } = "";

    /// <summary>
    /// 数据库地址
    /// </summary>
    [SugarColumn(ColumnDescription = "数据库IP", Length = 128)]
    [MaxLength(128)]
    public string? Host { get; set; } = "";

    /// <summary>
    /// 数据库类型
    /// </summary>
    [SugarColumn(ColumnDescription = "数据库类型")]
    public DbType? DbType { get; set; } = SqlSugar.DbType.MySql;

    /// <summary>
    /// 数据库账号
    /// </summary>
    [SugarColumn(ColumnDescription = "数据库账号", Length = 256)]
    [MaxLength(256)]
    public string? ConnAccount { get; set; } = "";

    /// <summary>
    /// 数据库密码
    /// </summary>
    [SugarColumn(ColumnDescription = "数据库密码", Length = 512)]
    [MaxLength(512)]
    public string? ConnPassword { get; set; } = "";

    /// <summary>
    /// 排序
    /// </summary>
    [SugarColumn(ColumnDescription = "排序")]
    public int? OrderNo { get; set; } = 100;

    /// <summary>
    /// 备注
    /// </summary>
    [SugarColumn(ColumnDescription = "备注", Length = 128)]
    public string? Remark { get; set; }

    /// <summary>
    /// 状态
    /// </summary>
    [SugarColumn(ColumnDescription = "状态")]
    public StatusEnum? Status { get; set; } = StatusEnum.Enable;

    /// <summary>
    /// 真实姓名
    /// </summary>
    [SugarColumn(ColumnDescription = "真实姓名", Length = 32)]
    public string? RealName { get; set; }

    /// <summary>
    /// 昵称
    /// </summary>
    [SugarColumn(ColumnDescription = "昵称", Length = 32)]
    public string? NickName { get; set; }

    /// <summary>
    /// 头像
    /// </summary>
    [SugarColumn(ColumnDescription = "头像", Length = 512)]
    public string? Avatar { get; set; }

    /// <summary>
    /// 性别-男_1、女_2
    /// </summary>
    [SugarColumn(ColumnDescription = "性别")]
    public GenderEnum? Sex { get; set; } = GenderEnum.Male;

    /// <summary>
    /// 年龄
    /// </summary>
    [SugarColumn(ColumnDescription = "年龄")]
    public int? Age { get; set; } = 0;

    /// <summary>
    /// 出生日期
    /// </summary>
    [SugarColumn(ColumnDescription = "出生日期")]
    public DateTime? Birthday { get; set; }

    /// <summary>
    /// 民族
    /// </summary>
    [SugarColumn(ColumnDescription = "民族", Length = 32)]
    public string? Nation { get; set; }

    /// <summary>
    /// 手机号码
    /// </summary>
    [SugarColumn(ColumnDescription = "手机号码", Length = 16)]
    [MaxLength(16)]
    public string Phone { get; set; } = "";

    /// <summary>
    /// 邮箱
    /// </summary>
    [SugarColumn(ColumnDescription = "邮箱", Length = 64)]
    [MaxLength(64)]
    public string? Email { get; set; }

    /// <summary>
    /// 最新登录Ip
    /// </summary>
    [SugarColumn(ColumnDescription = "最新登录Ip", Length = 256)]
    [MaxLength(256)]
    public string? LastLoginIp { get; set; }

    /// <summary>
    /// 最新登录地点
    /// </summary>
    [SugarColumn(ColumnDescription = "最新登录地点", Length = 128)]
    [MaxLength(128)]
    public string? LastLoginAddress { get; set; }

    /// <summary>
    /// 最新登录时间
    /// </summary>
    [SugarColumn(ColumnDescription = "最新登录时间")]
    public DateTime? LastLoginTime { get; set; }

    /// <summary>
    /// 最新登录设备
    /// </summary>
    [SugarColumn(ColumnDescription = "最新登录设备", Length = 128)]
    [MaxLength(128)]
    public string? LastLoginDevice { get; set; }

    /// <summary>
    /// 付费是否到期
    /// </summary>
    [SugarColumn(ColumnDescription = "付费是否到期")]
    public StatusEnum? IsExpire { get; set; } = StatusEnum.Enable;
}