using Nancy;

namespace Successful.Planr.Web.Modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => "Hello World from Nancy in ASP.Net vNext";
        }
    }
}
