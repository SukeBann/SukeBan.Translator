using SukeBanTranslator.Core;

namespace SukeBanTranslator.Core
{
    public class BaiduToken :ITranslationSourceToken
    {
        /// <summary>
        /// API地址
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// APP ID
        /// </summary>
        public string appid { get; set; }

        /// <summary>
        /// API 令牌
        /// </summary>
        public string token { get; set; }

        /// <summary>
        /// 是否显示语音合成资源	0 - 显示 1 - 不显示
        /// </summary>
        public short tts { get; set; }

        /// <summary>
        /// 是否显示词典资源	0 - 显示 1 - 不显示
        /// </summary>
        public short dict { get; set; }

        /// <summary>
        /// 判断是否需要使用自定义术语干预 API	1 - 是 0 - 否
        /// (需要开通”我的术语库“)
        /// </summary>
        public short action { get; set; }

        public TranslationSource _TSource { get; set; } = TranslationSource.Baidu;

        public bool IsThetokenAvailable()
        {
            //url，appid，token不能为空   tts，dict 只能为0或1
            return !string.IsNullOrEmpty(url) && !string.IsNullOrEmpty(appid) && !string.IsNullOrEmpty(token) && (tts == 0 || tts == 1) && (dict == 0 || dict == 1);
        }
    }

}