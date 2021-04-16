using System.ComponentModel.Composition;

namespace SukeBanTranslator.Core
{
    public class SogouToken : ITranslationSourceToken
    {
        public TranslationSource _TSource { get; set; } = TranslationSource.Sogou;

        public bool IsThetokenAvailable()
        {
            return false;
        }
    }
}