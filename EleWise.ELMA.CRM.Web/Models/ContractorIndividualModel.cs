// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.ContractorIndividualModel
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
  public class ContractorIndividualModel : ContractorBaseModel<IContractorIndividual>
  {
    public ContractorIndividualModel()
    {
    }

    public ContractorIndividualModel(IContractorIndividual contractor)
      : base(contractor)
    {
    }

    public ContractorIndividualModel(IContractorIndividual contractor, ViewType viewType)
      : base(contractor, viewType)
    {
    }

    public override void PrepareSave()
    {
      this.Entity.Name = string.Format("{2} {0} {1}", (object) this.Entity.FirstName, (object) this.Entity.MiddleName, (object) this.Entity.SecondName);
      base.PrepareSave();
    }

    protected override IContractorBaseModel CreateConcreteModel(
      IContractorIndividual entity,
      ViewType viewType,
      Guid? customFormUid)
    {
      ContractorIndividualModel concreteModel = new ContractorIndividualModel(entity, viewType);
      concreteModel.FormUid = customFormUid;
      return (IContractorBaseModel) concreteModel;
    }

    public override string EditorViewName => "ContractorIndividual/Editors/ContractorIndividualEdit";

    public override string EditorFieldsViewName => "ContractorIndividual/ContractorIndividualEditForm";

    public bool LockEditPermission { get; set; }
  }
}
