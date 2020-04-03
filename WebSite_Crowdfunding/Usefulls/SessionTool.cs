using System.Web;
using WebSite_Crowdfunding.Models;

namespace WebSite_Crowdfunding.Usefulls
{
    public class SessionTool
    {
        

        public static Utilisateur utilisateur
        {
            get { return (Utilisateur)HttpContext.Current.Session["utilisateur"]; }
            set { HttpContext.Current.Session["utilisateur"] = value; }
        }
    }
}