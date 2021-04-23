using System.ComponentModel.Composition;
using System.Linq;
using Caliburn.Micro;
using SukeBanTranslator.CustomControl.ViewModels;
using SukeBanTranslator.Models;

namespace SukeBanTranslator.ViewModels
{
    [Export(typeof(ISubViewModel))]
    public class TranslationResultPanelViewModel: SubViewModelBase
    {
        public TranslationResultPanelViewModel()
        {
            //Items.Add(IoC.Get<IPageControlViewModel>());
            //DropDownRichTextBox = Items.FirstOrDefault(x => x is DropDownRichTextBoxViewModel);
        }

        private IPageControlViewModel _DropDownRichTextBox;
        /// <summary>
        /// 下沉式富文本框
        /// </summary>
        public IPageControlViewModel DropDownRichTextBox
        {
            get { return _DropDownRichTextBox; ; }
            set
            {
                _DropDownRichTextBox = value;
                NotifyOfPropertyChange(() => DropDownRichTextBox);
            }
        }

    }
}