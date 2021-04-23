using Caliburn.Micro;
using SukeBanTranslator.Log;

namespace SukeBanTranslator.Models
{
    /// <summary>
    /// <paramref name="T:SukeBanTranslator.IChildViewModel"/>的抽象实现
    /// </summary>
    public abstract class ChildViewModelBase: Conductor<ISubViewModel>.Collection.AllActive,IChildViewModel
    {
        #region Properties

        /// <summary>
        /// 获取窗体管理器
        /// </summary>
        public IWindowManager WindowManager => IoC.Get<IWindowManager>();

        /// <summary>
        /// 获取事件聚合器
        /// </summary>
        public IEventAggregator EventAggregator => IoC.Get<IEventAggregator>();

        /// <summary>
        /// 获取日志输入器
        /// </summary>
        public ILogger Logger => IoC.Get<ILogger>();

        #endregion Properties
    }
}