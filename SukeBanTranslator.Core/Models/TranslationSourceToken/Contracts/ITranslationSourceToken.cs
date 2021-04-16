namespace SukeBanTranslator.Core
{
    /// <summary>
    /// 提供检查令牌是否可用的功能
    /// </summary>
    public interface ITranslationSourceToken
    {
        /// <summary>
        /// 翻译源
        /// </summary>
        TranslationSource _TSource { get; set; }

        /// <summary>
        /// 检查Token是否可用
        /// </summary>
        /// <returns></returns>
        bool IsThetokenAvailable();
    }
}