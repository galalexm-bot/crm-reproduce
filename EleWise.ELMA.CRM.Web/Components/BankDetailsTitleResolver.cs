// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.BankDetailsTitleResolver
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models.BillingInformation;
using EleWise.ELMA.Model.Entities;
using System;
using System.Web;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Components
{
  [Component(Order = 100)]
  internal class BankDetailsTitleResolver : IEntityTitleResolver
  {
    public bool CheckType(IEntity entity) => entity is IBankDetails;

    public MvcHtmlString GetTitle(IEntity entity, UrlHelper helper)
    {
      IBankDetails bankDetails = (IBankDetails) entity;
      string str = HttpUtility.HtmlEncode(bankDetails.Name);
      DateTime? endDate = bankDetails.EndDate;
      DateTime today = DateTime.Today;
      return (endDate.HasValue ? (endDate.GetValueOrDefault() < today ? 1 : 0) : 0) != 0 ? MvcHtmlString.Create(string.Format("<strike>{0}</strike>", (object) str)) : MvcHtmlString.Create(string.Format("{0}", (object) str));
    }
  }
}
