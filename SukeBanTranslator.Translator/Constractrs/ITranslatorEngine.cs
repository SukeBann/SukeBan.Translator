using System.Collections.Generic;
using SukeBanTranslator.Core;

namespace SukeBanTranslator.Translator
{
    /// <summary>
    /// 定义翻译器引擎的核心接口
    /// </summary>
    public interface ITranslatorEngine
    {
        /// <summary>
        /// 翻译器配置
        /// </summary>
        ITranslatorConfiguration TConfig { get; set; }

        /// <summary>
        /// 令牌合集(决定哪些翻译器可用)
        /// </summary>
        Dictionary<TranslationSource, ITranslationSourceToken> TSourceTokenList { get; set; }

        /// <summary>
        /// 创建翻译器
        /// </summary>
        /// <param name="configuration"></param>
        /// <returns></returns>
        ITranslator CreateTranslator(TranslationSource tSource, ITranslationSourceToken token,ITranslatorConfiguration tConfig);

        /// <summary>
        /// 创建可用的翻译器合
        /// </summary>
        /// <returns></returns>
        List<ITranslator> CreateTranslatorList();
    }
}