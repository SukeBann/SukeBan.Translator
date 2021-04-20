using System;
using System.Collections.Generic;
using SukeBanTranslator.Models;
using System.ComponentModel.Composition;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Caliburn.Micro;
using SukeBanTranslator.Core;
using SukeBanTranslator.Shared;
using SukeBanTranslator.Translator;

namespace SukeBanTranslator.ViewModels
{
    [Export(typeof(IViewModel))]
    public class ShellViewModel : ViewModelBase
    {
        #region Ctor

        public ShellViewModel()
        {
            DisplayName = string.Empty;

            Items.AddRange(IoC.GetAll<ISubViewModel>().Reverse());

            //IoC.Get<ITranslatorConfiguration>().To = BaseLanguageType.en;
            //IoC.Get<ITranslatorConfiguration>().From = BaseLanguageType.zh;
            StartAnimation();
            //            var Tlist = IoC.Get<ITranslatorEngine>().CreateTranslatorList();
            //            var result = Tlist.FirstOrDefault().StartTranslating(@"这是一段翻译测试的译文，现在开始测试段落
            //                这是第二段，
            //                这是第三段，
            //这是第四段。
            //            ");
            //            foreach (var item in ((GeneralTranslationResult)result).ResultDic)
            //            {
            //                MessageBox.Show($"原文：{item.Key}，译文：{item.Value}");
            //            }


        }


        protected override void OnActivate()
        {
            ActiveItem = Items.FirstOrDefault(x => x.GetType() == typeof(AggregateTranslationViewModel));
            base.OnActivate();
        }

        #endregion
        
        #region Fields

        private string _GridLoadingTag = "EndLoad";
        /// <summary>
        /// 标识<paramref name="ActiveItem"/>
        /// 是否启用加载动画
        /// </summary>
        public string GridLoadingTag
        {
            get { return _GridLoadingTag; }
            set { _GridLoadingTag = value; NotifyOfPropertyChange(() => GridLoadingTag); }
        }

        #endregion

        #region Method

        
        /// <summary>
        /// 页面变更时进行的操作
        /// </summary>
        public void SelectionChanged()
        {
            StartAnimation();
        }

        /// <summary>
        /// 启用子页面的加载动画
        /// </summary>
        private void StartAnimation()
        {
            GridLoadingTag = "Loading";
            GridLoadingTag = "EndLoad";
        }

        #endregion
    }
}