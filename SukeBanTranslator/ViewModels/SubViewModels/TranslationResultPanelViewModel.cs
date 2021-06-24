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
            for (int i = 0; i < 10; i++)
            {
              Items.Add(new ResultBorderViewModel());
            }
        }

    }
}