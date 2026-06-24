// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.EmailBinder
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Web.Mvc;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Components
{
  public class EmailBinder : ElmaModelBinder
  {
    public override object BindModel(
      ControllerContext controllerContext,
      ModelBindingContext bindingContext)
    {
      object obj;
      try
      {
        obj = base.BindModel(controllerContext, bindingContext);
      }
      catch
      {
        return (object) null;
      }
      if (!(obj is IEmail email))
        return obj;
      return string.IsNullOrWhiteSpace(email.EmailString) ? (object) null : (object) email;
    }
  }
}
