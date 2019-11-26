using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace TexcWebService
{
    /// <summary>
    /// Summary description for WebTextWebService
    /// </summary>
    [WebService(Namespace = "http://northwindtraders.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebTextWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string ToUpper(string inputString)
        {
            return inputString.ToUpper();
        }

        [WebMethod]
        public string ToLower(string inputString)
        {
            return inputString.ToLower();
        }
    }
}
