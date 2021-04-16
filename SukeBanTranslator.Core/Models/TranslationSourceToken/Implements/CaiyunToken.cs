using System.ComponentModel.Composition;

namespace SukeBanTranslator.Core
{
    public class CaiyunToken : ITranslationSourceToken
    {
        public TranslationSource _TSource { get; set; } = TranslationSource.Caiyun;

        public bool IsThetokenAvailable()
        {
            return false;
        }
    }
}