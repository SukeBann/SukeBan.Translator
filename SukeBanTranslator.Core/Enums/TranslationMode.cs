namespace SukeBanTranslator.Core
{
    /// <summary>
    /// 翻译类型，根据翻译类型不同，返回的翻译结果也不同
    /// </summary>
    public enum TranslationMode
    {
        /// <summary>
        /// 聚合文本翻译，返回规则的对照文本（原文 and 译文 ）字典（Key：原文，value:译文）
        /// </summary>
        AggregateTranslation,
        /// <summary>
        /// 聚合词典模式 返回一个词典结果类
        /// </summary>
        AggregateTranslationDic,
        /// <summary>
        /// 图片翻译 返回一个图片翻译结果类
        /// </summary>
        AggregatePictureTranslationView
    }
}