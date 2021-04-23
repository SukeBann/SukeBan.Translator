using System.ComponentModel.Composition;
using Caliburn.Micro;
using SukeBanTranslator.Models;

namespace SukeBanTranslator.ViewModels
{
    [Export(typeof(IChildViewModel))]
    public class AggregateTranslationDicViewModel: ChildViewModelBase
    {
        public AggregateTranslationDicViewModel()
        {
            DisplayName = "词典聚合";
        }
    }
}