using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using Caliburn.Micro;
using SukeBanTranslator.Models;

namespace SukeBanTranslator.ViewModels
{
    [Export(typeof(IChildViewModel))]
    public class AggregatePictureTranslationViewModel: ChildViewModelBase
    {
        public AggregatePictureTranslationViewModel()
        {
            DisplayName = "识图翻译";
        }
    }
}