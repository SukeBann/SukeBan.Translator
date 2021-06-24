using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using Caliburn.Micro;
using SukeBanTranslator.Core;
using SukeBanTranslator.CustomControl.ViewModels;
using SukeBanTranslator.CustomControl.Views;
using SukeBanTranslator.Models;
using SukeBanTranslator.Shared;

namespace SukeBanTranslator.ViewModels
{
    [Export(typeof(ISubViewModel))]
    public class ATMainInputViewModel: SubViewModelBase
    {
        public ATMainInputViewModel()
        {
            Items.AddRange(IoC.GetAll<IPageControlViewModel>());
            LanguageSource = GeneralTools.GetLanguageSourceAndEnums();
        }

        private IPageControlViewModel _DropDownRichTextBox;

        public IPageControlViewModel DropDownRichTextBox
        {
            get => _DropDownRichTextBox;
            set { _DropDownRichTextBox = value; NotifyOfPropertyChange(()=> DropDownRichTextBox); }
        }

        protected override void OnActivate()
        {
            DropDownRichTextBox = Items.FirstOrDefault(x => x is DropDownTextBoxViewModel);
            base.OnActivate();
        }

        /// <summary>
        /// 语言源
        /// </summary>
        public List<LanguageSourceAndEnum> LanguageSource { get; set; }
    }

}