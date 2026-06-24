// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.EntityWithoutMarketingFilterProvider
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using System;

namespace EleWise.ELMA.CRM.Web.Components
{
  [Component]
  public class EntityWithoutMarketingFilterProvider : IEntityFilterProvider
  {
    public const string UID_S = "{69E761BC-F58D-49FE-AFFF-ED0E5C4AC0F8}";
    public static readonly Guid UID = new Guid("{69E761BC-F58D-49FE-AFFF-ED0E5C4AC0F8}");

    public Guid ProviderUid => EntityWithoutMarketingFilterProvider.UID;

    public void ApplyFilter(IEntityFilter filter, string data)
    {
      if (data == InterfaceActivator.UID<IMarketingGroup>().ToString())
        filter.Query = "MarketingGroup is null";
      else if (data == InterfaceActivator.UID<IMarketingActivity>().ToString())
      {
        filter.Query = "MarketingActivity is null";
      }
      else
      {
        if (!(data == InterfaceActivator.UID<IMarketingEffect>().ToString()))
          return;
        filter.Query = "MarketingEffect is null";
      }
    }

    public string GetFilterProviderData(
      Type entityType,
      PropertyMetadata propertyMetadata,
      ViewAttributes viewAttributes)
    {
      return (string) null;
    }

    public IEntityFilter GetFilter(Guid uid, IEntityFilter filter) => filter;
  }
}
