// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Extensions.RelationshipWorkLogEntityLinkDescription
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.BPM.Web.Common.Extensions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Entities;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace EleWise.ELMA.CRM.Web.Extensions
{
  [Component(EnableInterceptiors = false, InjectProerties = false, Order = 10)]
  public class RelationshipWorkLogEntityLinkDescription : IWorkLogEntityInfoLinkDescription
  {
    public bool CheckType(IEntity entity) => entity is IRelationship;

    public MvcHtmlString Description(HtmlHelper htmlHelper, IEntity entity) => htmlHelper.Partial("WorkLogItem/RelationshipInfo", (object) entity);
  }
}
