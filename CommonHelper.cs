using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace WxOpenId
{
    public class CommonHelper
    {
        //xiaomiao's test wechat appid
        public static string AppId = "wxfc82543f2ac38756";
        public static string AppSecret = "d4624c36b6795d1d99dcf0547af5443d";

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