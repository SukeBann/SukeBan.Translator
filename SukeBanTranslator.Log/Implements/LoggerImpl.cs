using Serilog;
using Serilog.Core;
using SukeBanTranslator.Shared;
using System;
using System.ComponentModel.Composition;

namespace SukeBanTranslator.Log
{
    [Export(typeof(ILogger))]
    internal class LoggerImpl : ILogger
    {
        #region Fields

        private static Logger _logger;

        #endregion Fields

        #region Ctor

        public LoggerImpl()
        {
            var logFilePath = Environments.LogFilePath;

            _logger = new LoggerConfiguration()
                .WriteTo.File(logFilePath, rollingInterval: RollingInterval.Day)
                .CreateLogger();
        }

        #endregion Ctor

        #region Methods

        public void Info(string message)
        {
            Log("info", message);
        }

        public void Info(Exception exception)
        {
            Log("info", exception, null);
        }

        public void Info(Exception exception, string messageTemplate)
        {
            Log("info", exception, messageTemplate);
        }

        public void Info(Exception exception, string messageTemplate, params object[] args)
        {
            Log("info", exception, messageTemplate, args);
        }

        public void Warning(string message)
        {
            Log("warning", message);
        }

        public void Warning(Exception exception)
        {
            Log("warning", exception, null);
        }

        public void Warning(Exception exception, string messageTemplate)
        {
            Log("warning", exception, messageTemplate);
        }

        public void Warning(Exception exception, string messageTemplate, params object[] args)
        {
            Log("warning", exception, messageTemplate, args);
        }

        public void Debug(string message)
        {
            Log("trace", message);
        }

        public void Debug(Exception exception)
        {
            Log("trace", exception, null);
        }

        public void Debug(Exception exception, string messageTemplate)
        {
            Log("trace", exception, messageTemplate);
        }

        public void Debug(Exception exception, string messageTemplate, params object[] args)
        {
            Log("trace", exception, messageTemplate, args);
        }

        public void Error(string message)
        {
            Log("error", message);
        }

        public void Error(Exception exception)
        {
            Log("error", exception, null);
        }

        public void Error(Exception exception, string messageTemplate)
        {
            Log("error", exception, messageTemplate);
        }

        public void Error(Exception exception, string messageTemplate, params object[] args)
        {
            Log("error", exception, messageTemplate, args);
        }

        #endregion Methods

        #region Functions

        private void Log(string level, string message)
        {
            switch (level)
            {
                case "info":
                    _logger.Information(message);
                    break;

                case "warning":
                    _logger.Information(message);
                    break;

                case "error":
                    _logger.Information(message);
                    break;

                case "trace":
                    _logger.Debug(message);
                    break;
            }
        }

        private void Log(string level, Exception exception, string messageTemplate, params object[] args)
        {
            switch (level)
            {
                case "info":
                    _logger.Information(exception, messageTemplate, args);
                    break;

                case "warning":
                    _logger.Information(exception, messageTemplate, args);
                    break;

                case "error":
                    _logger.Information(exception, messageTemplate, args);
                    break;

                case "trace":
                    _logger.Debug(exception, messageTemplate, args);
                    break;
            }
        }

        #endregion Functions
    }
}