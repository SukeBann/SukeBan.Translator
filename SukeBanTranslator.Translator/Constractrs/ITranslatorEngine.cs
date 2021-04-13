using SukeBanTranslator.Core;

namespace SukeBanTranslator
{   
    /// <summary>
    /// 定义翻译器引擎的核心接口
    /// </summary>
    public interface ITranslatorEngine
    {
        /// <summary>
        /// 创建翻译器
        /// </summary>
        /// <param name="configuration"></param>
        /// <returns></returns>
        ITranslator CreateTranslator(TranslatorConfiguration configuration);
    }
}