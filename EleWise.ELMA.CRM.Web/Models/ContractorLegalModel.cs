// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.ContractorLegalModel
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Extensions;
using EleWise.ELMA.Model.Views;
using System;

namespace EleWise.ELMA.CRM.Web.Models
{
  [Component]
  public class ContractorLegalModel : ContractorBaseModel<IContractorLegal>
  {
    public ContractorLegalModel()
    {
    }

    public ContractorLegalModel(IContractorLegal contractor)
      : base(contractor)
    {
    }

    public ContractorLegalModel(IContractorLegal contractor, ViewType viewType)
      : base(contractor, viewType)
    {
    }

    protected override IContractorBaseModel CreateConcreteModel(
      IContractorLegal entity,
      ViewType viewType,
      Guid? customFormUid)
    {
      ContractorLegalModel concreteModel = new ContractorLegalModel(entity, viewType);
      concreteModel.FormUid = customFormUid;
      return (IContractorBaseModel) concreteModel;
    }

    public override string EditorViewName => "ContractorLegal/Editors/ContractorLegalEdit";

    public override string EditorFieldsViewName => "ContractorLegal/ContractorLegalEditForm";

    public bool LockEditPermission { get; set; }
  }
}
