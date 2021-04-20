using SukeBanTranslator.Core;

namespace SukeBanTranslator.Translator
{
    /// <summary>
    /// 定义翻译器的核心接口
    /// </summary>
    public interface ITranslator
    {
        /// <summary>
        /// 翻译源
        /// </summary>
        TranslationSource tSource { get; set; }

        /// <summary>
        /// 翻译器的配置
        /// </summary>
        ITranslatorConfiguration translatorConfig { get; set; }

        /// <summary>
        /// API令牌
        /// </summary>
        ITranslationSourceToken token { get; set; }

        /// <summary>
        /// 调用API
        /// </summary>
        /// <returns></returns>
        string CallAPI(string QueryStr);

        /// <summary>
        /// 开始翻译
        /// </summary>
        /// <returns>
        /// 返回一个翻译结果:
        /// <paramref name="ITranslationResult" />
        /// </returns>
        ITranslationResult StartTranslating(string QueryStr);
    }
}