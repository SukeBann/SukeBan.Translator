namespace SukeBanTranslator.Core
{   
    /// <summary>
    /// 语种类型
    /// </summary>
    public enum BaseLanguageType
    {   
        /// <summary>
        /// 自动识别
        /// </summary>
        auto,
        /// <summary>
        /// 中文
        /// </summary>
        zh,
        /// <summary>
        /// 英文
        /// </summary>
        en,
        /// <summary>
        /// 日语
        /// </summary>
        jp,
        /// <summary>
        /// 繁体中文
        /// </summary>
        cht
    }

    /// <summary>
    /// 翻译源类型
    /// </summary>
    public enum TranslationSource
    {   
        /// <summary>
        /// 百度翻译
        /// </summary>
        Baidu,
        /// <summary>
        /// 有道翻译
        /// </summary>
        Youdao,
        /// <summary>
        /// 彩云小译
        /// </summary>
        Caiyun,
        /// <summary>
        /// 腾讯翻译君
        /// </summary>
        Tencent,
        /// <summary>
        /// 搜狗翻译
        /// </summary>
        Sogou
    }
}