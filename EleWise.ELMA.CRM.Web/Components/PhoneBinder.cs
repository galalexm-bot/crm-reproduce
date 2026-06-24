// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.PhoneBinder
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Web.Mvc;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Components
{
  public class PhoneBinder : ElmaModelBinder
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
      if (!(obj is IPhone phone))
        return obj;
      return string.IsNullOrWhiteSpace(phone.PhoneString) ? (object) null : (object) phone;
    }
  }
}
