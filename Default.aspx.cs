using System;

namespace WxOpenId
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string openIdProcessUrl = "http://"+CommonHelper.BaseUri+"/OpenIdProcess.aspx";
            string targetUrl = "http://"+ CommonHelper.BaseUri + "/UserInfo.aspx";
            string url = "https://open.weixin.qq.com/connect/oauth2/authorize?appid=" 
                + CommonHelper.AppId + "&redirect_uri="+ openIdProcessUrl + "?reurl=" 
                + targetUrl + "&response_type=code&scope=snsapi_userinfo&state=1#wechat_redirect";
            Response.Redirect(url);
        }
    }
}