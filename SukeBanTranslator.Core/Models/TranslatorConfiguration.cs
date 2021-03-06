using System.ComponentModel.Composition;

namespace SukeBanTranslator.Core
{
    /// <summary>
    /// 提供翻译器配置的功能
    /// </summary>
    public interface ITranslatorConfiguration
    {
        /// <summary>
        /// 被翻译的文本语言
        /// </summary>
        BaseLanguageType From { get; set; }

        /// <summary>
        /// 目标语言
        /// </summary>
        BaseLanguageType To { get; set; }

        /// <summary>
        /// 翻译类型
        /// </summary>
        TranslationMode TranslationType { get; set; }
    }

    /// <summary>
    /// 翻译器实例的配置
    /// </summary>
    [Export(typeof(ITranslatorConfiguration))]
    public class TranslatorConfiguration: ITranslatorConfiguration
    {
        #region Ctor

        /// <summary>
        /// 翻译器实例构造方法
        /// </summary>
        /// <param name="_From">被翻译的文本语言</param>
        /// <param name="_To">目标语言</param>
        public TranslatorConfiguration()
        {
            From = BaseLanguageType.auto;
            To = BaseLanguageType.en;
        }

        #endregion Ctor



        #region Properties

        public BaseLanguageType From { get; set; }

        public BaseLanguageType To { get; set; }

        public TranslationMode TranslationType { get; set; }

        #endregion Properties
    }
}