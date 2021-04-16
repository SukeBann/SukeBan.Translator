using System.Collections.Generic;
using System.Windows.Input;

namespace SukeBanTranslator.Core
{
    /// <summary>
    /// 提供翻译结果
    /// </summary>
    /// <typeparam name="T">翻译结果的类型</typeparam>
    public interface ITranslationResult<T>
    {   
        /// <summary>
        /// 翻译是否成功
        /// </summary>
        bool Success { get; set; } 

        /// <summary>
        /// API返回的错误信息
        /// </summary>
        string ErrorMsg { get; set; }

        /// <summary>
        /// 翻译结果，通过
        /// <paramref name="SetResultDic" /> 方法设置
        /// </summary>
        T Result { get; set; }

        /// <summary>
        /// 设置翻译结果
        /// </summary>
        /// <returns></returns>
        void SetResultDic();
    }
}
