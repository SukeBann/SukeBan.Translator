﻿using System.ComponentModel.Composition;
using Caliburn.Micro;
using SukeBanTranslator.Models;

namespace SukeBanTranslator.ViewModels
{
    [Export(typeof(ISubViewModel))]
    public class AggregateTranslationDicViewModel: SubViewModelBase
    {
        public AggregateTranslationDicViewModel()
        {
            DisplayName = "词典聚合";
        }
    }
}