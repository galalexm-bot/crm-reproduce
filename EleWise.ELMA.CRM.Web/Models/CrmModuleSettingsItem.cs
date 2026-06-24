// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.CrmModuleSettingsItem
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using System.Collections.Generic;

namespace EleWise.ELMA.CRM.Web.Models
{
  public class CrmModuleSettingsItem
  {
    public string Category { get; set; }

    public string Url { get; set; }

    public string Image { get; set; }

    public string Text { get; set; }

    public string Description { get; set; }

    public int Order { get; set; }

    public IEnumerable<CrmModuleSettingsItem> Inheritors { get; set; }
  }
}
