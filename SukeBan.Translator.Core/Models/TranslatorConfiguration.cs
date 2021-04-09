namespace SukeBanTranslator.Core
{   
    /// <summary>
    /// 翻译器实例的配置
    /// </summary>
    public class TranslatorConfiguration
    {
        #region Ctor
        /// <summary>
        /// 翻译器实例构造方法
        /// </summary>
        /// <param name="_TLSource">翻译源</param>
        /// <param name="_From">被翻译的文本语言</param>
        /// <param name="_To">目标语言</param>
        public TranslatorConfiguration(TranslationSource _TLSource, BaseLanguageType _From, BaseLanguageType _To)
        {
            TLSource = _TLSource;
            From = _From;
            To = _To;
        }
        #endregion

        #region Properties
        /// <summary>
        /// 翻译源
        /// </summary>
        TranslationSource TLSource { get; set; }
        /// <summary>
        /// 被翻译的文本语言
        /// </summary>
        BaseLanguageType From { get; set; }
        /// <summary>
        /// 目标语言
        /// </summary>
        BaseLanguageType To { get; set; }
        #endregion
    }
}