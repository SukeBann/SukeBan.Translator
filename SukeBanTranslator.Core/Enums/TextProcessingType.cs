namespace SukeBanTranslator.Core
{
    public enum TextProcessingType
    {
        /// <summary>
        /// 删除注释
        /// </summary>
        RemoveComments,

        /// <summary>
        /// 删除换行
        /// </summary>
        DeleteLine,

        /// <summary>
        /// 删除多余空格
        /// </summary>
        RemoveExtraSpaces,
    }
}