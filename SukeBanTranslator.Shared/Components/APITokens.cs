using System.Collections.Generic;
using System.Data;
using System.Linq;
using SukeBanTranslator.Core;

namespace SukeBanTranslator.Shared
{
    /// <summary>
    /// API令牌的帮助类
    /// </summary>
    public static class APITokens
    {
        /// <summary>
        /// 从IO获取API令牌
        /// </summary>
        static APITokens()
        {
            TranslationSourceTokens = new Dictionary<TranslationSource, ITranslationSourceToken>();
            TranslationSourceTokens.Add(TranslationSource.Baidu,IOUtil.GetFromJson<BaiduToken>());
            TranslationSourceTokens.Add(TranslationSource.Youdao,new YoudaoToken());
            TranslationSourceTokens.Add(TranslationSource.Tencent,new TencentToken());
            TranslationSourceTokens.Add(TranslationSource.Sogou,new SogouToken());
            TranslationSourceTokens.Add(TranslationSource.Caiyun,new CaiyunToken());
        }
        
        /// <summary>
        /// 获取所有令牌集合（无论是否可用）
        /// </summary>
        public static Dictionary<TranslationSource, ITranslationSourceToken> TranslationSourceTokens { get; }

        /// <summary>
        /// 获取可用的令牌合集
        /// </summary>
        public static Dictionary<TranslationSource, ITranslationSourceToken> CanUseTranslationSourceTokens =>
            TranslationSourceTokens.Where(x => x.Value.IsThetokenAvailable())
                .ToDictionary(Tkey => Tkey.Key, TValue => TValue.Value);
    }
}