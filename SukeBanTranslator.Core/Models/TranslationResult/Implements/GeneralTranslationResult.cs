using System.Collections.Generic;

namespace SukeBanTranslator.Core
{
    /// <summary>
    /// 一个通用的翻译结果：
    /// 包含一个<paramref name="Key"/>为原文
    /// <paramref name="Value"/>为译文的字典集，
    /// 每一个键值对为一个段落。
    /// </summary>
    public class GeneralTranslationResult:ITranslationResult
    {
        public TranslationSource Source { get; set; }

        public bool Success { get; set; }

        public string ErrorMsg { get; set; }

        /// <summary>
        /// <paramref name="Key"/>为原文
        /// <paramref name="Value"/>为译文的字典集，
        /// 每一个键值对为一个段落。
        /// </summary>
        public Dictionary<string,string> ResultDic { get; set; } = new Dictionary<string, string>();
    }

}