using System;
using System.ComponentModel.Composition;
using System.Windows.Controls;
using Caliburn.Micro;

namespace SukeBanTranslator.CustomControl.ViewModels
{
    [Export(typeof(IPageControlViewModel))]
    public class DropDownTextBoxViewModel:Screen,IPageControlViewModel
    {

    }
}