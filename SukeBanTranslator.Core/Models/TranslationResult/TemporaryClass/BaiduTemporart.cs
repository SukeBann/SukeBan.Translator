namespace SukeBanTranslator.Core
{
    #region Baidu临时类 用于API返回Json的转换

    /// <summary>
    /// Baidu临时类 用于API返回Json的转换
    /// </summary>
    public class TempBaidu
    {
        public string from { get; set; }
        public string to { get; set; }
        /// <summary>
        /// 错误码
        /// </summary>
        public string error_code { get; set; }
        public Trans_Result[] trans_result { get; set; }
    }

    /// <summary>
    /// Baidu临时类 用于API返回Json的转换
    /// </summary>
    public class Trans_Result
    {
        /// <summary>
        /// 原文
        /// </summary>
        public string src { get; set; }
        /// <summary>
        /// /译文
        /// </summary>
        public string dst { get; set; }
    }

    #endregion

}