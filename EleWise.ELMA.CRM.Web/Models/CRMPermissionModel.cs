// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.CRMPermissionModel
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.BPM.Web.Security.Models;

namespace EleWise.ELMA.CRM.Web.Models
{
  public class CRMPermissionModel
  {
    public long Id { get; set; }

    public bool ChangeInherite { get; set; }

    public EntityPermissionRoleTypeSelectorModel AdditionalPermissionsModel { get; set; }

    public EntityPermissionRoleTypeSelectorModel InheritPermissionsModel { get; set; }

    public bool InheritAvailable { get; set; }

    public bool InheritPermissions { get; set; }

    public bool LockEditPermission { get; set; }
  }
}
