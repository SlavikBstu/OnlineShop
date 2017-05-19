using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;

namespace OnlineShop
{
    /// <summary>
    /// Сводное описание для SoapService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    [System.Web.Script.Services.ScriptService]
    public class SoapService : System.Web.Services.WebService
    {

        Domain.OnlineShopEntities context = new Domain.OnlineShopEntities();

        [WebMethod]
        public string HelloWorld()
        {
            return "Привет всем!";
        }

        [WebMethod]
        public string GetProduct(string id)
        {
            var json = " ";

            var product = from result in context.products
                          where result.Product_id == Int32.Parse(id)
                          select result;

            JavaScriptSerializer jss = new JavaScriptSerializer();
            json = jss.Serialize(product);

            return json;
        }
    }
}
