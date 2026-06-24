// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.RouteProvider
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using Orchard;
using Orchard.Mvc.Routes;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;

namespace EleWise.ELMA.CRM.Web
{
  public class RouteProvider : IRouteProvider, IDependency
  {
    public const string AreaName = "EleWise.ELMA.CRM.Web";
    public const string ContentFolder = "~/Modules/EleWise.ELMA.CRM.Web/Content/";
    public const string ImagesFolder = "~/Modules/EleWise.ELMA.CRM.Web/Content/Images/";

    public void GetRoutes(ICollection<RouteDescriptor> routes)
    {
      foreach (RouteDescriptor route in this.GetRoutes())
        routes.Add(route);
    }

    public IEnumerable<RouteDescriptor> GetRoutes() => (IEnumerable<RouteDescriptor>) new RouteDescriptor[4]
    {
      new RouteDescriptor()
      {
        Priority = 20,
        Route = (RouteBase) new Route("CRM/{controller}/{action}/{id}", new RouteValueDictionary()
        {
          {
            "area",
            (object) "EleWise.ELMA.CRM.Web"
          },
          {
            "controller",
            (object) "Contractor"
          },
          {
            "action",
            (object) "Index"
          },
          {
            "id",
            (object) UrlParameter.Optional
          }
        }, (RouteValueDictionary) null, new RouteValueDictionary()
        {
          {
            "area",
            (object) "EleWise.ELMA.CRM.Web"
          }
        }, (IRouteHandler) new MvcRouteHandler())
      },
      new RouteDescriptor()
      {
        Priority = 20,
        Route = (RouteBase) new Route("CRM/{controller}/{action}/{id}", new RouteValueDictionary()
        {
          {
            "area",
            (object) "EleWise.ELMA.CRM.Web"
          },
          {
            "controller",
            (object) "Sale"
          },
          {
            "action",
            (object) "Index"
          },
          {
            "id",
            (object) UrlParameter.Optional
          }
        }, (RouteValueDictionary) null, new RouteValueDictionary()
        {
          {
            "area",
            (object) "EleWise.ELMA.CRM.Web"
          }
        }, (IRouteHandler) new MvcRouteHandler())
      },
      new RouteDescriptor()
      {
        Priority = 20,
        Route = (RouteBase) new Route("CRM/{controller}/{action}/{id}", new RouteValueDictionary()
        {
          {
            "area",
            (object) "EleWise.ELMA.CRM.Web"
          },
          {
            "controller",
            (object) "SaleStage"
          },
          {
            "action",
            (object) "Index"
          },
          {
            "id",
            (object) UrlParameter.Optional
          }
        }, (RouteValueDictionary) null, new RouteValueDictionary()
        {
          {
            "area",
            (object) "EleWise.ELMA.CRM.Web"
          }
        }, (IRouteHandler) new MvcRouteHandler())
      },
      new RouteDescriptor()
      {
        Priority = 20,
        Route = (RouteBase) new Route("CRM/{controller}/{action}/{id}", new RouteValueDictionary()
        {
          {
            "area",
            (object) "EleWise.ELMA.CRM.Web"
          },
          {
            "controller",
            (object) "SalesPlan"
          },
          {
            "action",
            (object) "Index"
          },
          {
            "id",
            (object) UrlParameter.Optional
          }
        }, (RouteValueDictionary) null, new RouteValueDictionary()
        {
          {
            "area",
            (object) "EleWise.ELMA.CRM.Web"
          }
        }, (IRouteHandler) new MvcRouteHandler())
      }
    };
  }
}
