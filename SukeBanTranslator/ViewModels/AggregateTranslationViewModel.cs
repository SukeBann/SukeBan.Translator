using System.ComponentModel.Composition;
using Caliburn.Micro;
using SukeBanTranslator.Models;

namespace SukeBanTranslator.ViewModels
{
    [Export(typeof(ISubViewModel))]
    public class AggregateTranslationViewModel: Screen,ISubViewModel
    {
        public AggregateTranslationViewModel()
        {
            DisplayName = "聚合文本翻译";
        }
    }

    [Export(typeof(ISubViewModel))]
    public class a : Screen, ISubViewModel
    {
        public a()
        {
            DisplayName = "词典聚合";
        }
    }

    [Export(typeof(ISubViewModel))]
    public class b : Screen, ISubViewModel
    {
        public b()
        {
            DisplayName = "图片翻译";
        }
    }
}