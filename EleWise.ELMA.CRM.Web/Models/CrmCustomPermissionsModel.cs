// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.CrmCustomPermissionsModel
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.BPM.Web.Security.Code;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Security.Models;
using System.Collections.Generic;

namespace EleWise.ELMA.CRM.Web.Models
{
  public class CrmCustomPermissionsModel
  {
    public static readonly string ModelTypeLead = "Lead";
    public static readonly string ModelTypeContractor = "Contractor";

    public ICategory Category { get; set; }

    public IEnumerable<AssignedRoleTypeModel> AssignedRoleTypeModels { get; set; }

    public IEnumerable<CrmPermissionData> SelectedPermissionsData { get; set; }

    public string ModelType { get; set; }

    public CrmCustomPermissionsModel(
      ICategory category,
      string modelType,
      IEnumerable<AssignedRoleTypeModel> assignedRoleTypeModels,
      IEnumerable<CrmPermissionData> leadPermissionData)
    {
      this.Category = category;
      this.ModelType = modelType;
      this.AssignedRoleTypeModels = assignedRoleTypeModels;
      this.SelectedPermissionsData = leadPermissionData;
    }
  }
}
