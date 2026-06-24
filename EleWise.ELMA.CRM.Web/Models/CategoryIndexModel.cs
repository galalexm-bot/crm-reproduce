// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.CategoryIndexModel
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.CRM.Web.Models
{
  public class CategoryIndexModel
  {
    public EleWise.ELMA.Web.Mvc.Models.Grids.GridData<ICategory> GridData { get; set; }

    public IUser CurrentUser { get; set; }

    public bool ShowAccess { get; set; }

    public bool CheckUpdatePermission { get; set; }

    public bool LockEditPermission { get; set; }

    public string LastRecalculatePermissionsError { get; set; }
  }
}
