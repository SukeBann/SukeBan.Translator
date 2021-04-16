using SukeBanTranslator.Core;

namespace SukeBanTranslator.Theme
{
    /// <summary>
    /// 提供主题的切换功能
    /// </summary>
    public interface IThemeManager
    {
        /// <summary>
        /// 切换主题
        /// </summary>
        /// <param name="theme">要切换的主题 </param>
        void ChangeTheme(PresetTheme theme);
    }
}