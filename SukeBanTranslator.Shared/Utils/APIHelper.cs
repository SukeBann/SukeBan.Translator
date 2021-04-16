using System;
using SukeBanTranslator.Core;

namespace SukeBanTranslator.Shared
{
    public static class BaiduTranslatorHelper
    {
        public static string GetTranslate(BaseLanguageType languageType)
        {
            switch(languageType)
            {
                case BaseLanguageType.auto:
                    return "auto";
                case BaseLanguageType.zh:
                    return "zh";
                case BaseLanguageType.en:
                    return "en";
                case BaseLanguageType.jp:
                    return "jp";
                case BaseLanguageType.cht:
                    return "cht";
                default:
                    return "";
            }
        }
    }
}