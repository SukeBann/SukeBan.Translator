using System;
using System.ComponentModel.Composition;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Caliburn.Micro;
using Panuon.UI.Silver;
using SukeBanTranslator.CustomControl.ViewModels;
using SukeBanTranslator.Models;

namespace SukeBanTranslator.ViewModels
{
    [Export(typeof(ISubViewModel))]
    public class TranslationResultPanelViewModel: SubViewModelBase
    {
        public TranslationResultPanelViewModel()
        {
            PageControl = IoC.GetAll<IPageControlViewModel>().FirstOrDefault(x => x is ResultBorderViewModel);
        }
        private IPageControlViewModel _PageControl;

        public IPageControlViewModel PageControl
        {
            get { return _PageControl; }
            set { _PageControl = value; NotifyOfPropertyChange(() => PageControl); }
        }



    }
}