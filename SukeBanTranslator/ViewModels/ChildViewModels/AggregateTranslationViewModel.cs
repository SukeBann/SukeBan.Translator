using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Windows;
using Caliburn.Micro;
using SukeBanTranslator.Core;
using SukeBanTranslator.CustomControl.ViewModels;
using SukeBanTranslator.Models;

namespace SukeBanTranslator.ViewModels
{
    [Export(typeof(IChildViewModel))]
    public class AggregateTranslationViewModel: ChildViewModelBase
    {
        public AggregateTranslationViewModel()
        {
            DisplayName = "聚合文本翻译";

            Items.AddRange(IoC.GetAll<ISubViewModel>().Reverse());
        }

        #region Fields

        private ISubViewModel _ATMainInput;
        /// <summary>
        /// 下沉式富文本框
        /// </summary>
        public ISubViewModel ATMainInput
        {
            get => _ATMainInput;
            set
            {
                _ATMainInput = value; 
                NotifyOfPropertyChange(() => ATMainInput);
            }
        }

        private ISubViewModel _TranslationResultPanel;
        /// <summary>
        /// 翻译结果子页面
        /// </summary>
        public ISubViewModel TranslationResultPanel
        {
            get => _TranslationResultPanel;
            set
            {
                _TranslationResultPanel = value; 
                NotifyOfPropertyChange(() => TranslationResultPanel);
            }
        }

        #endregion

        protected override void OnActivate()
        {
            TranslationResultPanel = Items.FirstOrDefault(x => x is TranslationResultPanelViewModel);
            ATMainInput = Items.FirstOrDefault(x => x is ATMainInputViewModel);
            base.OnActivate();
        }

    }
}