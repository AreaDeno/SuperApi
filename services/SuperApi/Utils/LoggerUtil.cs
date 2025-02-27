using System.Text;
using System.Text.RegularExpressions;

namespace SuperApi.Utils;


/// <summary>
/// 日志模版
/// </summary>
public static class LoggerUtil
{
    /// <summary>
    /// 生成规范日志模板
    /// </summary>
    /// <param name="title">标题</param>
    /// <param name="description">描述</param>
    /// <param name="items">列表项，如果以 [xxx] 开头，自动生成 xxx: 属性</param>
    /// <returns><see cref="string"/></returns>
    public static string Wrapper(string title, string description, params string[] items)
    {
        // 处理不同编码问题
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        var regex = new Regex(@"^##(?<prop>.*)?##[:：]?\s*(?<content>.*)");
        var stringBuilder = new StringBuilder();
        stringBuilder.Append($"\r\n┏━━━━━━━━━━━  {title} ━━━━━━━━━━━").AppendLine();

        // 添加描述
        if (!string.IsNullOrWhiteSpace(description))
        {
            stringBuilder.Append($"┣ {description}").AppendLine().Append("┣ ").AppendLine();
        }
        if (items != null && items.Length > 0)
        {
            var propMaxLength = items.Where(u => regex.IsMatch(u))
                .DefaultIfEmpty(string.Empty)
                .Max(u => regex.Match(u).Groups["prop"].Value.Length);
            propMaxLength += (propMaxLength >= 5 ? 10 : 5);

            for (var i = 0; i < items.Length; i++)
            {
                var item = items[i];
                if (regex.IsMatch(item))
                {
                    var match = regex.Match(item);
                    var prop = match.Groups["prop"].Value;
                    var content = match.Groups["content"].Value;

                    var propTitle = $"{prop}：";
                    stringBuilder.Append($"┣ {PadRight(propTitle, propMaxLength)}{content}").AppendLine();
                }
                else
                {
                    stringBuilder.Append($"┣ {item}").AppendLine();
                }
            }
        }

        stringBuilder.Append($"┗━━━━━━━━━━━  {title} ━━━━━━━━━━━");
        return stringBuilder.ToString();
    }

    /// <summary>
    /// 等宽文字对齐
    /// </summary>
    /// <param name="str"></param>
    /// <param name="totalByteCount"></param>
    /// <returns></returns>
    private static string PadRight(string str, int totalByteCount)
    {
        var coding = Encoding.GetEncoding("gbk");
        var dcount = 0;

        foreach (var ch in str.ToCharArray())
        {
            if (coding.GetByteCount(ch.ToString()) == 2)
                dcount++;
        }

        var w = str.PadRight(totalByteCount - dcount);
        return w;
    }
}