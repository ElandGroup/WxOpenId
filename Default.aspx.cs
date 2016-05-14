using System;

namespace WxOpenId
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
<<<<<<< ours
            string openIdProcessUrl = "http://"+CommonHelper.BaseUri+"/OpenIdProcess.aspx";
            string targetUrl = "http://"+ CommonHelper.BaseUri + "/UserInfo.aspx";
            string url = string.Format("https://open.weixin.qq.com/connect/oauth2/authorize?appid=wxfc82543f2ac6&redirect_uri={0}?reurl={1}"+
                                        "&response_type=code&scope=snsapi_base&state=1#wechat_redirect",openIdProcessUrl,targetUrl);
=======
            string openIdProcessUrl = "http://wxdemo.accurate9.com/OpenIdProcess.aspx";
            string targetUrl = "http://wxdemo.accurate9.com/UserInfo.aspx";
           
            string url = "https://open.weixin.qq.com/connect/oauth2/authorize?appid=" 
                + CommonHelper.AppId + "&redirect_uri=http://wxdemo.accurate9.com/OpenIdProcess.aspx?reurl=" 
                + targetUrl + "&response_type=code&scope=snsapi_userinfo&state=1#wechat_redirect";
>>>>>>> theirs
            Response.Redirect(url);
        }
    }
}