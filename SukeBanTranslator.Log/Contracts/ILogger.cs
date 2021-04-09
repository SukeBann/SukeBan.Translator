using System;
using System.Runtime.InteropServices.ComTypes;

namespace SukeBanTranslator.Log
{   
    /// <summary>
    /// 提供日志的本地文件存储功能
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// 记录一条信息级别的日志消息
        /// </summary>
        /// <param name="message">消息内容。</param>
        void Info(string message);

        /// <summary>
        /// 记录一条信息级别的日志消息
        /// </summary>
        /// <param name="exception">要记录的信息，将收集此信息的消息，栈堆跟踪等信息 </param>
        void Info(Exception exception);

        /// <summary>
        /// 记录一条信息级别的日志消息
        /// </summary>
        /// <param name="exception">要记录的信息信息，将收集此信息的消息、堆栈跟踪等信息。</param>
        /// <param name="messageTemplate">消息的格式化字符串，参考Serilog的使用文档。</param>
        void Info(Exception exception, string messageTemplate);

        /// <summary>
        /// 记录一条信息级别的日志消息
        /// </summary>
        /// <param name="exception">要记录的信息信息，将收集此信息的消息、堆栈跟踪等信息。</param>
        /// <param name="messageTemplate">消息的格式化字符串，参考Serilog的使用文档。</param>
        /// <param name="args">消息格式化字符串使用的参数。</param>
        void Info(Exception exception, string messageTemplate, params object[] args);

        /// <summary>
        /// 记录一条警告级别的日志消息
        /// </summary>
        /// <param name="message">消息内容</param>
        void Warning(string message);

        /// <summary>
        /// 记录一条警告级别的日志消息。
        /// </summary>
        /// <param name="exception">要记录的警告信息，将收集此警告的消息、堆栈跟踪等信息。</param>
        void Warning(Exception exception);

        /// <summary>
        /// 记录一条警告级别的日志消息。
        /// </summary>
        /// <param name="exception">要记录的警告信息，将收集此警告的消息、堆栈跟踪等信息。</param>
        /// <param name="messageTemplate">消息的格式化字符串，参考Serilog的使用文档。</param>
        void Warning(Exception exception, string messageTemplate);

        /// <summary>
        /// 记录一条警告级别的日志消息。
        /// </summary>
        /// <param name="exception">要记录的警告信息，将收集此警告的消息、堆栈跟踪等信息。</param>
        /// <param name="messageTemplate">消息的格式化字符串，参考Serilog的使用文档。</param>
        /// <param name="args">消息格式化字符串使用的参数。</param>
        void Warning(Exception exception, string messageTemplate, params object[] args);


        /// <summary>
        /// 记录一条错误级别的日志消息。
        /// </summary>
        /// <param name="message">消息内容。</param>
        void Error(string message);

        /// <summary>
        /// 记录一条错误级别的日志消息。
        /// </summary>
        /// <param name="exception">要记录的错误信息，将收集此错误的消息、堆栈跟踪等信息。</param>
        void Error(Exception exception);

        /// <summary>
        /// 记录一条错误级别的日志消息。
        /// </summary>
        /// <param name="exception">要记录的错误信息，将收集此错误的消息、堆栈跟踪等信息。</param>
        /// <param name="messageTemplate">消息的格式化字符串，参考Serilog的使用文档。</param>
        void Error(Exception exception, string messageTemplate);

        /// <summary>
        /// 记录一条错误级别的日志消息。
        /// </summary>
        /// <param name="exception">要记录的错误信息，将收集此错误的消息、堆栈跟踪等信息。</param>
        /// <param name="messageTemplate">消息的格式化字符串，参考Serilog的使用文档。</param>
        /// <param name="args">消息格式化字符串使用的参数。</param>
        void Error(Exception exception, string messageTemplate, params object[] args);

        /// <summary>
        /// 记录一条调试级别的日志消息。
        /// </summary>
        /// <param name="message">消息内容。</param>
        void Debug(string message);

        /// <summary>
        /// 记录一条调试级别的日志消息。
        /// </summary>
        /// <param name="exception">要记录的调试信息，将收集此调试的消息、堆栈跟踪等信息。</param>
        void Debug(Exception exception);

        /// <summary>
        /// 记录一条调试级别的日志消息。
        /// </summary>
        /// <param name="exception">要记录的调试信息，将收集此调试的消息、堆栈跟踪等信息。</param>
        /// <param name="messageTemplate">消息的格式化字符串，参考Serilog的使用文档。</param>
        void Debug(Exception exception, string messageTemplate);

        /// <summary>
        /// 记录一条调试级别的日志消息。
        /// </summary>
        /// <param name="exception">要记录的调试信息，将收集此调试的消息、堆栈跟踪等信息。</param>
        /// <param name="messageTemplate">消息的格式化字符串，参考Serilog的使用文档。</param>
        /// <param name="args">消息格式化字符串使用的参数。</param>
        void Debug(Exception exception, string messageTemplate, params object[] args);
    }
}