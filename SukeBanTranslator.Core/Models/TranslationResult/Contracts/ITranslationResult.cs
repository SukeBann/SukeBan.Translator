using System.Collections.Generic;
using System.Windows.Input;

namespace SukeBanTranslator.Core
{
    /// <summary>
    /// 提供翻译结果
    /// </summary>
    public interface ITranslationResult
    {
        /// <summary>
        /// 翻译源
        /// </summary>
        TranslationSource Source { get; set; }

        /// <summary>
        /// 翻译是否成功
        /// </summary>
        bool Success { get; set; }

        /// <summary>
        /// API返回的错误信息
        /// </summary>
        string ErrorMsg { get; set; }

    }
}
