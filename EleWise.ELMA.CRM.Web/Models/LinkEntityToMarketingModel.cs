// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.LinkEntityToMarketingModel
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using System;
using System.Linq.Expressions;

namespace EleWise.ELMA.CRM.Web.Models
{
  public class LinkEntityToMarketingModel
  {
    [DisplayName(typeof (LinkEntityToMarketingModel_SR), "Contractor")]
    public IContractor Contractor { get; set; }

    [DisplayName(typeof (LinkEntityToMarketingModel_SR), "Lead")]
    public ILead Lead { get; set; }

    [DisplayName(typeof (LinkEntityToMarketingModel_SR), "Sale")]
    public ISale Sale { get; set; }

    public IMarketingBase MarketingBase { get; set; }

    public Expression<Func<LinkEntityToMarketingModel, IEntity>> EntityExpression { get; set; }

    public string Action { get; set; }

    public string Callback { get; set; }
  }
}
