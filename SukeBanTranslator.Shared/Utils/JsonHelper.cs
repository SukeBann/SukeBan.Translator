using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace SukeBanTranslator.Shared
{
    /// <summary>
    /// Json数据相关的工具类
    /// </summary>
    public static class JsonHelper
    {
        /// <summary>
        /// 从Json解析实例
        /// </summary>
        /// <typeparam name="T">实例的泛型</typeparam>
        /// <param name="Json">要解析的Json</param>
        /// <returns></returns>
        public static T GetObjectFromJson<T>(string Json)where T:class
        {
            if (string.IsNullOrEmpty(Json))
            {
                throw new Exception($"在解析Json时发生错误：目标Json不包含任何数据");
            }
            else
            {
                return JsonConvert.DeserializeObject<T>(Json);
            }
            
        }
    }
}