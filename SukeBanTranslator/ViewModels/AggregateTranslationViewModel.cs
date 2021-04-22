using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Windows;
using Caliburn.Micro;
using SukeBanTranslator.Core;
using SukeBanTranslator.Models;

namespace SukeBanTranslator.ViewModels
{
    [Export(typeof(ISubViewModel))]
    public class AggregateTranslationViewModel: SubViewModelBase
    {
        public AggregateTranslationViewModel()
        {
            DisplayName = "聚合文本翻译";

            Items.AddRange(IoC.GetAll<IPageControlViewModel>().Reverse());

            LanguageSource = new List<LanguageSourceAndEnum>()
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

        public List<LanguageSourceAndEnum> LanguageSource { get; set; }

        public void Button()
        {
            MessageBox.Show("123");
        }

        protected override void OnActivate()
        {
            ActiveItem = Items.FirstOrDefault(x => x.GetType() == typeof(TranslationResultPanelViewModel));
            base.OnActivate();
        }

    }

    public class LanguageSourceAndEnum
    {
        public BaseLanguageType BaseLanguageType { get; set; }

        public string Language { get; set; }
    }
}