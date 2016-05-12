using System;

namespace WxOpenId
{
    public partial class UserInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string openId = Request.QueryString["openId"];
            if (!string.IsNullOrWhiteSpace(openId))
            {
                Response.Write(string.Format("your openId is :{0} in appId:{1}",openId,CommonHelper.AppId));
            }
            else
            {
                Response.Write("openId is not obtained!");
            }
        }
    }
}