using System;
using System.Web.Script.Serialization;

namespace WxOpenId
{
    public partial class OpenIdProcess : System.Web.UI.Page
    {
  
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string reurl = Request.QueryString["reurl"];
                string code = Request.QueryString["code"];
                string openId = GetOpenId(code);
                CommonHelper.SetCookie("openid", openId);
                string redirectUrl = string.Format("{0}?openId={1}", reurl, openId);
                Response.Redirect(redirectUrl);

            }
        }

        private string GetOpenId(string code)
        {
            string url = "https://api.weixin.qq.com/sns/oauth2/access_token?appid=" + CommonHelper.AppId+ "&secret=" + CommonHelper.AppSecret +
                   "&code=" + code + "&grant_type=authorization_code";
            string responseText = CommonHelper.ParseUrl(url);
            JavaScriptSerializer jParse = new JavaScriptSerializer();
            UserDto userInfo = jParse.Deserialize<UserDto>(responseText);
            string openId = userInfo.OpenId;
            return openId;
        }



   
    }


}