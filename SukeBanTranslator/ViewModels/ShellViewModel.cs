using System.Collections.Generic;
using SukeBanTranslator.Models;
using System.ComponentModel.Composition;
using System.Linq;
using Caliburn.Micro;
using SukeBanTranslator.Core;
using SukeBanTranslator.Shared;
using SukeBanTranslator.Translator;

namespace SukeBanTranslator.ViewModels
{
    [Export(typeof(IViewModel))]
    public class ShellViewModel : ViewModelBase
    {
        public ShellViewModel()
        { 
            Items.AddRange(IoC.GetAll<ISubViewModel>());
            DisplayName = string.Empty;

        }

        private int _BContent = 1;
        public int BContent
        {
            get
            {
                return _BContent;
            }
            set
            {
                _BContent = value;
                NotifyOfPropertyChange(() => BContent);
            }
        } 

        public void Button()
        {
            BContent ++;
        }

        protected override void OnActivate()
        {
            ActiveItem = Items.FirstOrDefault(x => x.GetType() == typeof(AggregateTranslationViewModel));
            base.OnActivate();
        }
    }
}