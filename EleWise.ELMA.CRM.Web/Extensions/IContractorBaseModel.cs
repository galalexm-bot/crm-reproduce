// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Extensions.IContractorBaseModel
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Views;
using System;

namespace EleWise.ELMA.CRM.Web.Extensions
{
  [ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
  public interface IContractorBaseModel
  {
    IContractor Contractor { get; }

    Guid ContratorTypeUid { get; }

    IContractorBaseModel CreateFromContrator(IContractor contractor);

    IContractorBaseModel CreateFromContrator(IContractor contractor, ViewType viewType);

    string EditorViewName { get; }

    string EditorFieldsViewName { get; }

    void PrepareSave();

    FormViewItem View { get; set; }
  }
}
