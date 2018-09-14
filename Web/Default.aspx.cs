using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services.Protocols;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System.Net;

namespace Web
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var a = new CRM_API_UAT.Service1();
            CertificateTrust.SetCertificatePolicy();//证书出现问题时调用此代码
            var r = a.CreateMemberBinding("WECHAT", "123456", "123456789", "mobile", "13912345678");
            var j = JsonConvert.SerializeObject(r);

            //var coupon = new Coupon_API_UAT.Demo();
            //var r = coupon.GetCouponLists("719", "BEN", "01", "1234567890", "obDX5jhZAYSa9gnULOoxsBwCtkAk", "Infoware");
            //var j = JsonConvert.SerializeObject(r);

            Response.Write(j);
        }

        public static class CertificateTrust
        {
            public static void SetCertificatePolicy()
            {
                ServicePointManager.ServerCertificateValidationCallback
                           += RemoteCertificateValidate;
            }
            private static bool RemoteCertificateValidate(
               object sender, X509Certificate cert,
                X509Chain chain, SslPolicyErrors error)
            {
                System.Console.WriteLine("Warning, trust any certificate");
                return true;
            }
        }
    }
}