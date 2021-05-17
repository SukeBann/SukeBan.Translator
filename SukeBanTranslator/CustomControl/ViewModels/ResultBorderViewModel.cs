using System.ComponentModel.Composition;
using System.Runtime.Remoting;
using Caliburn.Micro;

namespace SukeBanTranslator.CustomControl.ViewModels
{
    [Export(typeof(IPageControlViewModel))]
    public class ResultBorderViewModel:Screen,IPageControlViewModel
    {
        
    }
}