// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.FilterContractorTypeFilter
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using System;

namespace EleWise.ELMA.CRM.Web.Components
{
  [Component]
  public class FilterContractorTypeFilter : IFilterTypeFilter
  {
    public Guid EntityTypeUid => InterfaceActivator.UID<IContractor>();

    public Func<ClassMetadata, bool> GetFilter() => (Func<ClassMetadata, bool>) (md =>
    {
      string actionName;
      string controllerName;
      UIExtensions.SearchAction<ContractorCreateAttribute>(md.Uid, out actionName, out controllerName, out string _, out ContractorCreateAttribute _);
      return !string.IsNullOrEmpty(actionName) && !string.IsNullOrEmpty(controllerName);
    });
  }
}
