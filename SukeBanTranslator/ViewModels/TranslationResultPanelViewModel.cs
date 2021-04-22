using System.ComponentModel.Composition;
using Caliburn.Micro;

namespace SukeBanTranslator.ViewModels
{
    [Export(typeof(IPageControlViewModel))]
    public class TranslationResultPanelViewModel:Screen,IPageControlViewModel
    {
        public TranslationResultPanelViewModel() { }



    }
}