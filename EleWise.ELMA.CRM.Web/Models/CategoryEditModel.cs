// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.CategoryEditModel
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.Web.Models
{
  public class CategoryEditModel
  {
    public ICategory Category { get; set; }

    public bool CheckUpdatePermission { get; set; }

    public bool LockEditPermission { get; set; }

    public EntityPermissionRoleTypeSelectorModel ContractorPermissionsModel { get; set; }

    public EntityPermissionRoleTypeSelectorModel LeadPermissionsModel { get; set; }

    public bool NoCategory => this.Category != null && this.Category.Uid == CategoryManager.NoCategoryUid;
  }
}
