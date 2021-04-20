using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using SukeBanTranslator.Core;
using SukeBanTranslator.Shared;

namespace SukeBanTranslator.Translator.Models
{
    public class BaiduTranslator: ITranslator
    {
        public TranslationSource tSource { get; set; }

        public ITranslatorConfiguration translatorConfig { get; set; }

        public ITranslationSourceToken token { get; set; }

        public string CallAPI(string QueryStr)
        {
            var BaiduToken = (BaiduToken) token;
            string retString;
            try
            {
                // 源语言
                var from = BaiduTranslatorHelper.GetTranslate(translatorConfig.From);
                // 目标语言
                var to = BaiduTranslatorHelper.GetTranslate(translatorConfig.To);


                // APP ID
                var appId = BaiduToken.appid;
                // 密钥
                var secretKey = BaiduToken.token;
                // 请求Url
                var url = BaiduToken.url;

                //随机数
                var rd = new Random();
                var salt = rd.Next(100000).ToString();


                var sign = Shared.NormalConverter.EncryptString(appId + QueryStr + salt + secretKey);
                url += "q=" + HttpUtility.UrlEncode(QueryStr);
                url += "&from=" + from;
                url += "&to=" + to;
                url += "&appid=" + appId;
                url += "&salt=" + salt;
                url += "&sign=" + sign;

                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                request.ContentType = "text/html;charset=UTF-8";
                request.UserAgent = null;
                request.Timeout = 6000;
                var response = (HttpWebResponse)request.GetResponse();
                using (var myResponseStream = response.GetResponseStream())
                {
                    var myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
                    retString = myStreamReader.ReadToEnd();
                    myStreamReader.Close();
                }
            }
            catch (Exception e)
            {
                throw new Exception($"在调用百度翻译API时发生错误:{e.Message}");
            }
            return retString;
        }

        public ITranslationResult StartTranslating(string QueryStr)
        {
           var result = new GeneralTranslationResult();
           var resultJson = CallAPI(QueryStr);

           if (string.IsNullOrEmpty(resultJson))
           {
               throw new Exception("在调用百度翻译API时发生错误：返回的数据为空");
           }
           else
           {
               var tempClass = JsonHelper.GetObjectFromJson<TempBaidu>(resultJson);
               if (!string.IsNullOrEmpty(tempClass.error_code))
               {
                   result.ErrorMsg = $"调用百度翻译API时发生错误，错误代码{tempClass.error_code}";
                   result.Success = false;
                   return result;
               }
               else
               {
                   foreach (var transResult in tempClass.trans_result)
                   {
                       result.ResultDic.Add(transResult.src,transResult.dst);
                   }
               }
           }
           return result;
        }
    }

}