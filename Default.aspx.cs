using System;

namespace WxOpenId
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string openIdProcessUrl = "http://"+CommonHelper.BaseUri+"/OpenIdProcess.aspx";
            string targetUrl = "http://"+ CommonHelper.BaseUri + "/UserInfo.aspx";
            string url = string.Format("https://open.weixin.qq.com/connect/oauth2/authorize?appid=wxfc82543f2ac6&redirect_uri={0}?reurl={1}"+
                                        "&response_type=code&scope=snsapi_base&state=1#wechat_redirect",openIdProcessUrl,targetUrl);
            Response.Redirect(url);
        }
    }
}