using System;
using System.Collections.Generic;
using SukeBanTranslator.Core;
using System.ComponentModel.Composition;
using System.Linq;
using SukeBanTranslator.Shared;
using SukeBanTranslator.Translator.Models;

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


        public ITranslator CreateTranslator(TranslationSource tSource, ITranslationSourceToken token, ITranslatorConfiguration tConfig)
        {
            switch (tSource)
            {
                case TranslationSource.Baidu:
                    return new BaiduTranslator()
                    {
                        tSource = TranslationSource.Baidu,
                        token = token,
                        translatorConfig = tConfig
                    };
                case TranslationSource.Youdao:
                case TranslationSource.Caiyun:
                case TranslationSource.Tencent:
                case TranslationSource.Sogou:
                default:
                    throw new ArgumentOutOfRangeException(nameof(tSource), tSource, null);
            }
        }

        public List<ITranslator> CreateTranslatorList()
        {
            return TSourceTokenList.Select(sourceToken => CreateTranslator(sourceToken.Key, sourceToken.Value, TConfig)).ToList();
        }
    }
}