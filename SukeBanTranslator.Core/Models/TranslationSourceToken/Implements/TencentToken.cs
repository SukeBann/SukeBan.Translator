using System.ComponentModel.Composition;

namespace SukeBanTranslator.Core
{
    public class TencentToken : ITranslationSourceToken
    {
        public TranslationSource _TSource { get; set; } = TranslationSource.Tencent;

        public bool IsThetokenAvailable()
        {
            return false;
        }
    }
}