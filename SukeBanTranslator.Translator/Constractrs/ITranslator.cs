using SukeBanTranslator.Core;

namespace SukeBanTranslator.Translator
{
    /// <summary>
    /// 定义翻译器的核心接口
    /// </summary>
    public interface ITranslator
    {
        /// <summary>
        /// 调用API
        /// </summary>
        /// <returns></returns>
        string CallAPI();

        /// <summary>
        /// 开始翻译
        /// </summary>
        /// <returns>
        /// 返回一个翻译结果:
        /// <paramref name="T:SukeBanTranslator.Core.ITranslationResult" />
        /// </returns>
        ITranslationResult<T> StartTranslating<T>(string QueryStr);
    }
}