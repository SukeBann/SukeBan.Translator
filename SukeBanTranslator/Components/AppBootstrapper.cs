using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Primitives;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Threading;
using Caliburn.Micro;
using SukeBanTranslator.Log;
using SukeBanTranslator.Theme;

namespace SukeBanTranslator
{
    class AppBootstrapper:BootstrapperBase
    {
        #region Fields

        /// <summary>
        /// 组件容器
        /// </summary>
        private CompositionContainer _container;

        /// <summary>
        /// 窗口管理器
        /// </summary>
        private IWindowManager _windowManager;

        /// <summary>
        /// 事件聚合器
        /// </summary>
        private IEventAggregator _eventAggregator;

        /// <summary>
        /// 日志组件
        /// </summary>
        private ILogger _logger;

        /// <summary>
        /// 主题管理器
        /// </summary>
        private IThemeManager _themeManager;

        /// <summary>
        /// 翻译核心引擎
        /// </summary>
        private ITranslatorEngine _translatorEngine;

        #endregion

        #region Ctor

        public AppBootstrapper()
        {
            Initialize();
        }

        #endregion

        #region Overrides

        /// <summary>
        /// 重写以设置 Ioc 容器。
        /// </summary>
        protected override void Configure()
        {
            var catalog = new AggregateCatalog
            (
                AssemblySource.Instance
                    .Select(x => new AssemblyCatalog(x))
                    .OfType<ComposablePartCatalog>()
            );
            //添加MEF自动发现包含的程序集
            catalog.Catalogs.Add(new AssemblyCatalog(typeof(ILogger).Assembly));
            catalog.Catalogs.Add(new AssemblyCatalog(typeof(IThemeManager).Assembly));
            catalog.Catalogs.Add(new AssemblyCatalog(typeof(ITranslatorEngine).Assembly));

            var batch = new CompositionBatch();

            _container = new CompositionContainer(catalog);
            batch.AddExportedValue(_container);

            //注入控制反转
            _windowManager = new WindowManager();
            batch.AddExportedValue(_windowManager);
            _eventAggregator = new EventAggregator();
            batch.AddExportedValue(_eventAggregator);
            _logger = _container.GetExportedValue<ILogger>();
            batch.AddExportedValue(_logger);
            _themeManager = _container.GetExportedValue<IThemeManager>();
            batch.AddExportedValue(_themeManager);
            _translatorEngine = _container.GetExportedValue<ITranslatorEngine>();
            batch.AddExportedValue(_translatorEngine);

            _container.Compose(batch);
        }

        /// <summary>
        /// 重写此操作以添加未处理异常的自定义行为。(添加了日志的记录,以及弹窗)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void OnUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            base.OnUnhandledException(sender, e);
            _logger.Error(e.Exception, "发生了未经捕获的异常。");
            MessageBox.Show(e.Exception.Message);
#if !(DEBUG)
            e.Handled = true;
#endif
        }

        /// <summary>
        /// 重写以提供一个特定于IOC的实现{获取单项实例}
        /// </summary>
        /// <param name="serviceType">实例类型</param>
        /// <param name="key"></param>
        /// <returns></returns>
        protected override object GetInstance(Type serviceType, string key)
        {
            string contract = string.IsNullOrEmpty(key) ? AttributedModelServices.GetContractName(serviceType) : key;
            var exports = _container.GetExportedValues<object>(contract);

            if (exports.Any())
            {
                return exports.First();
            }
            else
            {
                throw new Exception($"找不到实例{contract}.");
            }
        }

        /// <summary>
        /// 重写以提供一个特定于IOC的实现{获取多项实例}
        /// </summary>
        /// <param name="serviceType">实例类型</param>
        /// <param name="key"></param>
        /// <returns></returns>
        protected override IEnumerable<object> GetAllInstances(Type serviceType)
        {
            return _container.GetExportedValues<object>(AttributedModelServices.GetContractName(serviceType));
        }

        /// <summary>
        /// 重写以设置加载到AssemblySource中的程序集列表
        /// </summary>
        /// <returns></returns>
        protected override IEnumerable<Assembly> SelectAssemblies()
        {
            var assemblies = new List<Assembly>(){ Assembly.GetExecutingAssembly() };
            return assemblies;
        }

        /// <summary>
        /// IOC容器注入实例的方法
        /// </summary>
        /// <param name="instance"></param>
        protected override void BuildUp(object instance)
        {
            _container.SatisfyImportsOnce(instance);
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<IViewModel>();
        }

        protected override void OnExit(object sender, EventArgs e)
        {
            base.OnExit(sender, e);
        }

        #endregion
    }
}
