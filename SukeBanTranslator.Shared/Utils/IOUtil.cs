using System;
using System.CodeDom;
using System.IO;
using System.Reflection;
using System.Resources;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using SukeBanTranslator.Core;

namespace SukeBanTranslator.Shared
{
    public static class IOUtil
    {
        /// <summary>
        /// 从Json解析实例
        /// </summary>
        /// <typeparam name="T">
        /// 返回的实例类型，需要继承接口
        /// <paramref name="T:SukeBanTranslator.Core.ITranslationSourceToken"/>
        /// </typeparam>
        /// <returns></returns>
        public static T GetFromJson<T>() where T : ITranslationSourceToken
        {

            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = $"{assembly.GetName().Name}.Resources.{typeof(T).Name}.json";

            var Json = string.Empty;

            using (var stream = assembly.GetManifestResourceStream(resourceName))
            {
                StreamReader sr = new StreamReader(stream);
                Json = sr.ReadToEnd();
                sr.Close();
            }

            if (string.IsNullOrEmpty(Json))
            {
                throw new Exception($"配置错误:没有从{typeof(T)}令牌的配置文件中读取到信息。");
            }
            switch (typeof(T).Name)
            {
                case "BaiduToken":
                    var baiduToken = JsonConvert.DeserializeObject<BaiduToken>(Json);
                    return (T)(ITranslationSourceToken)baiduToken;

                case "CaiyunToken":
                    var CaiyunToken = JsonConvert.DeserializeObject<CaiyunToken>(Json);
                    return (T)(ITranslationSourceToken)CaiyunToken;

                case "SogouToken":
                    var SogouToken = JsonConvert.DeserializeObject<SogouToken>(Json);
                    return (T)(ITranslationSourceToken)SogouToken;

                case "TencentToken":
                    var TencentToken = JsonConvert.DeserializeObject<TencentToken>(Json);
                    return (T)(ITranslationSourceToken)TencentToken;

                case "YoudaoToken":
                    var YoudaoToken = JsonConvert.DeserializeObject<YoudaoToken>(Json);
                    return (T)(ITranslationSourceToken)YoudaoToken;

                default :
                    throw new Exception($"没有找到{typeof(T)}的配置文件");
            }

            
        }

    }
}