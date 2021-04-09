using System.ComponentModel.Composition;
using SukeBanTranslator.Core;
using SukeBanTranslator.Translator.Models.Internals;

namespace SukeBanTranslator.Translator
{   
    [Export(typeof(ITranslatorEngine))]
    class TranslatorEngineImpl:ITranslatorEngine
    {
        public ITranslator CreateTranslator(TranslatorConfiguration configuration)
        {   
            return new TranslatorEntity();
        }
    }
}