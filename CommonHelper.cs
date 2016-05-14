using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace WxOpenId
{
    public class CommonHelper
    {
        //xiaomiao's test wechat appid
        public static string AppId
        {
            get { return ConfigurationManager.AppSettings["appId"]; }
        }
        public static string AppSecret
        {
            get { return ConfigurationManager.AppSettings["appSecret"]; }
        }
        public static string BaseUri
        {
            get { return ConfigurationManager.AppSettings["baseUri"]; }
        }

        public static void SetCookie(string name, string value)
        {
            if (name != "" || name != null)
            {
                HttpContext.Current.Response.Cookies[name].Value = value;
                HttpContext.Current.Response.Cookies[name].Expires = DateTime.Now.Add(new TimeSpan(30, 0, 0, 0));
            }
        }
        public static string GetCookie(string name)
        {
            if (name != "" || name != null)
            {
                return HttpContext.Current.Request.Cookies[name].Value.ToString();
            }
            return null;
        }
        public static string ParseUrl(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream responseStream = response.GetResponseStream();

            StreamReader s = new StreamReader(responseStream, System.Text.Encoding.GetEncoding("utf-8"));
            string responseText = s.ReadToEnd();
            s.Close();
            s.Dispose();
            responseStream.Close();
            return responseText;
        }
    }
}