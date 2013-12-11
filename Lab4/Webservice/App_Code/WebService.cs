using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService {

    [WebMethod]
    public string Add(string a,string b) {

        int x = int.Parse(a);

        int y = int.Parse(b);

        int z = x + y;

        return z.ToString();
        
    }

    [WebMethod]
    public string Sub(string a, string b)
    {

        int x = int.Parse(a);

        int y = int.Parse(b);

        int z = x - y;

        return z.ToString();

    }

    [WebMethod]
    public string Multiply(string a, string b)
    {

        int x = int.Parse(a);

        int y = int.Parse(b);

        int z = x * y;

        return z.ToString();


    }

    [WebMethod]
    public string Divide(string a, string b)
    {

        int x = int.Parse(a);

        int y = int.Parse(b);

        int z = x / y;

        return z.ToString();

    }
    
}
