﻿using System.ComponentModel.Composition;
using Caliburn.Micro;
using SukeBanTranslator.Models;

namespace SukeBanTranslator.ViewModels
{
    [Export(typeof(ISubViewModel))]
    public class AggregateTranslationViewModel: SubViewModelBase
    {
        public AggregateTranslationViewModel()
        {
            DisplayName = "聚合文本翻译";
        }
    }
}