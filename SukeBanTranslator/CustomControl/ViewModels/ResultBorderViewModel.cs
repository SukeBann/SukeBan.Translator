using System.ComponentModel.Composition;
using System.Windows;
using Caliburn.Micro;

namespace SukeBanTranslator.CustomControl.ViewModels
{
    [Export(typeof(IPageControlViewModel))]
    public class ResultBorderViewModel:Screen,IPageControlViewModel
    {
        #region Fields

        public TextWrapping OriginalTextWrap
        {
            get => originalTextWrap;
            set
            {
                if (value == originalTextWrap) return;
                originalTextWrap = value;
                NotifyOfPropertyChange(() => OriginalTextWrap);
            }
        }

        public TextWrapping TranslatedTextWrap
        {
            get => translatedTextWrap;
            set
            {
                if (value == translatedTextWrap) return;
                translatedTextWrap = value;
                NotifyOfPropertyChange(() => TranslatedTextWrap);
            }
        }

        public GridLength OriginalTextHeight
        {
            get => originalTextHeight;
            set
            {
                if (value.Equals(originalTextHeight)) return;
                originalTextHeight = value;
                NotifyOfPropertyChange(() => OriginalTextHeight);
            }
        }

        public GridLength TranslatedTextHeight
        {
            get => translatedTextHeight;
            set
            {
                if (value.Equals(translatedTextHeight)) return;
                translatedTextHeight = value;
                NotifyOfPropertyChange(() => TranslatedTextHeight);
            }
        }

        private TextWrapping originalTextWrap = TextWrapping.Wrap;

        private TextWrapping translatedTextWrap = TextWrapping.Wrap;

        private GridLength originalTextHeight = new GridLength(400,GridUnitType.Pixel);

        private GridLength translatedTextHeight = new GridLength(400,GridUnitType.Pixel);

        #endregion

        #region Method



        #endregion

        #region MyRegion



        #endregion


    }
}