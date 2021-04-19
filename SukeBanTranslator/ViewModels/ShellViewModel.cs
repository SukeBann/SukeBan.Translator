using System.Collections.Generic;
using SukeBanTranslator.Models;
using System.ComponentModel.Composition;
using System.Globalization;
using System.Linq;
using System.Windows;
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
            UniversalConverter s = new UniversalConverter(){ConverterType = UniversalConverter.UniversalConverterType.IsNull};
            object a = s.Convert(s, typeof(object), new object(), CultureInfo.CurrentCulture);
            MessageBox.Show(a.ToString());
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