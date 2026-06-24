// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.SecurityPermissionModel
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.BPM.Web.Security.Models;
using System.Collections.Generic;

namespace EleWise.ELMA.CRM.Web.Models
{
  public class SecurityPermissionModel
  {
    public SecurityPermissionModel(
      IEnumerable<CrmCustomPermissionsModel> leadPermissionsModels,
      IEnumerable<CrmCustomPermissionsModel> contractorPermissionsModels,
      GlobalPermissionsModel globalPermissionsModel)
    {
      this.LeadPermissionsModels = leadPermissionsModels;
      this.ContractorPermissionsModels = contractorPermissionsModels;
      this.GlobalPermissionsModel = globalPermissionsModel;
    }

    public IEnumerable<CrmCustomPermissionsModel> LeadPermissionsModels { get; set; }

    public IEnumerable<CrmCustomPermissionsModel> ContractorPermissionsModels { get; set; }

    public GlobalPermissionsModel GlobalPermissionsModel { get; set; }
  }
}
