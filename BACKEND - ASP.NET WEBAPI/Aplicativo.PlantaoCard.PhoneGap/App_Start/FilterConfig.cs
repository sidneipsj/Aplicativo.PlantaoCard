using System.Web;
using System.Web.Mvc;

namespace Aplicativo.PlantaoCard.PhoneGap
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}