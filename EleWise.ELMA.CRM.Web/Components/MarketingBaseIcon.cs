// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.MarketingBaseIcon
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using System;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Components
{
  [Component(Order = 10)]
  public class MarketingBaseIcon : IObjectIcon
  {
    public bool CheckType(Type type) => typeof (IMarketingBase).IsAssignableFrom(type);

    public string Icon(UrlHelper url, ObjectIconFormat format, object obj)
    {
      switch (obj)
      {
        case IMarketingGroup _:
          return "/Content/IconPack/targets.svg";
        case IMarketingActivity _:
          return "/Content/IconPack/target.svg";
        case IMarketingEffect _:
          return "/Content/IconPack/arrow.svg";
        default:
          return (string) null;
      }
    }
  }
}
