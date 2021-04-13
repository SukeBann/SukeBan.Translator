using SukeBanTranslator.Core;

namespace SukeBanTranslator
{
    /// <summary>
    /// 定义翻译器的核心接口
    /// </summary>
    public interface ITranslator
    {
        /// <summary>
        /// 开始翻译
        /// </summary>
        /// <returns>
        /// 返回一个翻译结果:
        /// <paramref name="T:SukeBanTranslator.Core.TranslationResult" /> 
        /// </returns>
        TranslationResult StartSranslating();
    }
}