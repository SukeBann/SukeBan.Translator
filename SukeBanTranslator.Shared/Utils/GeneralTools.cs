using System.Collections.Generic;
using SukeBanTranslator.Core;

namespace SukeBanTranslator.Shared
{
    /// <summary>
    /// 通用工具
    /// </summary>
    public static class GeneralTools
    {
        /// <summary>
        /// 获取语种枚举对应的中文
        /// </summary>
        /// <returns></returns>
        public static List<LanguageSourceAndEnum> GetLanguageSourceAndEnums()
        {
            return new List<LanguageSourceAndEnum>()
            {
                new LanguageSourceAndEnum()
                {
                    BaseLanguageType = BaseLanguageType.auto,
                    Language = "自动"
                },
                new LanguageSourceAndEnum()
                {
                    BaseLanguageType = BaseLanguageType.zh,
                    Language = "中文"
                },
                new LanguageSourceAndEnum()
                {
                    BaseLanguageType = BaseLanguageType.en,
                    Language = "英文"
                },
                new LanguageSourceAndEnum()
                {
                    BaseLanguageType = BaseLanguageType.jp,
                    Language = "日文"
                }
            };
        }
    }
}