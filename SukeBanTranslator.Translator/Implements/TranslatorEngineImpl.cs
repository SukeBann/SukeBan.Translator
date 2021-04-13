using System.ComponentModel.Composition;
using SukeBanTranslator.Core;
using SukeBanTranslator.Models.Internals;

namespace SukeBanTranslator
{       
    /// <summary>
    /// 翻译器引擎的核心实现
    /// </summary>
    [Export(typeof(ITranslatorEngine))]
    class TranslatorEngineImpl:ITranslatorEngine
    {
        public ITranslator CreateTranslator(TranslatorConfiguration configuration)
        {   
            return new TranslatorEntity();
        }
    }
}