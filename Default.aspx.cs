using System;

namespace WxOpenId
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string openIdProcessUrl = "http://wxdemo.accurate9.com/OpenIdProcess.aspx";
            string targetUrl = "http://wxdemo.accurate9.com/UserInfo.aspx";
           
            string url = "https://open.weixin.qq.com/connect/oauth2/authorize?appid=" 
                + CommonHelper.AppId + "&redirect_uri=http://wxdemo.accurate9.com/OpenIdProcess.aspx?reurl=" 
                + targetUrl + "&response_type=code&scope=snsapi_userinfo&state=1#wechat_redirect";
            Response.Redirect(url);
        }
    }
}