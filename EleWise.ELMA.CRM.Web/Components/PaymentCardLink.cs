// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.PaymentCardLink
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models.BillingInformation;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace EleWise.ELMA.CRM.Web.Components
{
  [Component]
  internal class PaymentCardLink : IObjectLink
  {
    public bool CheckType(Type type) => typeof (IPaymentCard).IsAssignableFrom(type);

    public string Url(RequestContext context, object obj) => new UrlHelper(context).Action("Details", "PaymentCard", (object) new
    {
      area = "EleWise.ELMA.CRM.Web",
      id = ((IIdentified) obj).GetId(),
      inPopup = false
    });
  }
}
