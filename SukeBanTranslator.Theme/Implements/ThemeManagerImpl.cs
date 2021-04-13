using System;
using System.ComponentModel.Composition;
using System.Net.Mime;
using System.Windows;
using SukeBanTranslator.Theme;
using SukeBanTranslator.Core;

namespace SukeBanTranslator.Theme.Implements
{   
    [Export(typeof(IThemeManager))]
    class ThemeManagerImpl:IThemeManager
    {
        #region Fields
        #endregion

        #region Method

        public void ChangeTheme(PresetTheme theme)
        {
            var mergeDictionaries = Application.Current.Resources.MergedDictionaries;

            for (int i = mergeDictionaries.Count; i >= 0; i--)
            {
                var dic = mergeDictionaries[i];
                if (dic.Source != null && dic.Source.ToString().Contains("SukeBanTranslator.Themes;component/Themes"))
                {
                    mergeDictionaries.RemoveAt(i);
                    continue;
                }
            }

            mergeDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri($"pack://application:,,,//SukeBanTranslator.Theme;component/Themes/{theme}.xaml")
            });
        }
        #endregion
    }
}