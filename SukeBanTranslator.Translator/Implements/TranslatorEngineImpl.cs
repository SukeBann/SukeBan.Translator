using System.Collections.Generic;
using SukeBanTranslator.Core;
using System.ComponentModel.Composition;
using SukeBanTranslator.Shared;

namespace SukeBanTranslator.Translator
{
    /// <summary>
    /// 翻译器引擎的核心实现
    /// </summary>
    [Export(typeof(ITranslatorEngine))]
    public class TranslatorEngineImpl : ITranslatorEngine
    {
        [ImportingConstructor] 
        public TranslatorEngineImpl(ITranslatorConfiguration configuration)
        {
            TConfig = configuration;
            TSourceTokenList = APITokens.CanUseTranslationSourceTokens;
        }

        public ITranslatorConfiguration TConfig { get; set; }
        public Dictionary<TranslationSource, ITranslationSourceToken> TSourceTokenList { get; set; }


        public ITranslator CreateTranslator(TranslationSource Tsource)
        {
            throw new System.NotImplementedException();
        }

        public List<ITranslator> CreateTranslatorList()
        {
            throw new System.NotImplementedException();
        }
    }
}