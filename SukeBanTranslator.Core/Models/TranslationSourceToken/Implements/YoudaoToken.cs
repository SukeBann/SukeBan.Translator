using System.ComponentModel.Composition;

namespace SukeBanTranslator.Core
{
    public class YoudaoToken : ITranslationSourceToken
    {
        public TranslationSource _TSource { get; set; } = TranslationSource.Youdao;

        public bool IsThetokenAvailable()
        {
            return false;
        }
    }
}