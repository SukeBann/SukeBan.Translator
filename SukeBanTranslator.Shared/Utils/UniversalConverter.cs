using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;

namespace SukeBanTranslator.Shared
{
    /// <summary>
    /// 通用转换器
    /// </summary>
    public class UniversalConverter: MarkupExtension, IValueConverter
    {
        public UniversalConverter()
        {
            SetConverterFunc();
        }



        /// <summary>
        /// 转换方式枚举
        /// </summary>
        public enum UniversalConverterType
        {
            /*  命名规则
             *
             *  申明的
             * 《枚举名》
             * ！必须与！
             * 《转换方法的名称》
             * ！相对应！
             */

            /// <summary>
            /// 判断是否为null值
            /// </summary>
            IsNull,
        }

        #region Fields

        /// <summary>
        /// 转换方式
        /// </summary>
        public UniversalConverterType ConverterType { get; set; }

        /// <summary>
        /// 封装了转换方法的Func
        /// </summary>
        private Func<object, Type, object, CultureInfo, bool, object> ConverterFunc { get; set; }

        #endregion

        #region ConverterFunc

        /*  命名规则
         *
         *  申明的
         * 《转换方法的名称》
         * ！必须与！
         * 《枚举名》
         * ！相对应！
         *
         * 《转换方法的名称》
         * ！必须以大写M开头！
         * ！以枚举名结尾！
         */

        /// <summary>
        /// 判断Value是否为Null
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <param name="isBack">是否为返回参数</param>
        /// <returns>如果Value为Null返回True</returns>
        public object MIsNull(object value, Type targetType, object parameter, CultureInfo culture, bool isBack)
        {
            if (isBack)
            {
                return DependencyProperty.UnsetValue;
            }
            return value != null;
        }

        #endregion

        #region MainMethod

        /// <summary>
        /// 根据<paramref name="ConverterType"/>
        /// 正则匹配对应的转换方法 并赋值
        /// <paramref name="ConverterFunc"/>
        /// 因此 转换方法与转换方式类型 必须严格遵守命名规则
        /// </summary>
        private void SetConverterFunc()
        {
            var ThisType = this.GetType();
            var MethodInfoArray = ThisType.GetMethods();
            foreach (var methodInfo in MethodInfoArray)
            {
                if (!Regex.IsMatch(methodInfo.Name, ConverterType.ToString())) continue;
                ConverterFunc = new Func<object, Type, object, CultureInfo, bool, object>
                (
                    (value, type, parameter, culture, isBack) => 
                        methodInfo.Invoke(this,new[]{ value, type, parameter, culture, isBack })
                    );
                return;
            }
        }

        //当值从绑定源传播给绑定目标时，调用方法Convert
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ConverterFunc(value, targetType, parameter = null, culture, false);
        }

        //当值从绑定目标传播给绑定源时，调用此方法ConvertBack

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ConverterFunc(value, targetType, parameter = null, culture, true);
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return new UniversalConverter() { ConverterType = this.ConverterType };
        }

        #endregion


    }
}