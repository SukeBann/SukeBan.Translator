using System;
using System.IO;

namespace SukeBanTranslator.Shared
{
    public static class Environments
    {
        #region Fields
        private const string _appDataPath = "%appdata%\\Panuon\\Panuon Setup";
        #endregion

        #region Properties

        #region AppDataPath
        /// <summary>
        /// 获取当前提供给程序缓存使用的AppData路径。
        /// <para>若文件夹不存在，将创建新文件夹。</para>
        /// </summary>
        public static string AppDataPath
        {
            get
            {
                var path = Environment.ExpandEnvironmentVariables(_appDataPath);
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                return path;
            }
        }
        #endregion

        #region LogFilePath
        /// <summary>
        /// 获取日志文件的储存位置。
        /// </summary>
        public static string LogFilePath
        {
            get
            {
                var logDirectory = Path.Combine(Environment.ExpandEnvironmentVariables(_appDataPath), "Log");
                if (!Directory.Exists(logDirectory))
                {
                    Directory.CreateDirectory(logDirectory);
                }
                return Path.Combine(logDirectory, "Log.txt");
            }
        }
        #endregion

        #endregion
    }
}