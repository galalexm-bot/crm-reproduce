// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Security.ModulePermissionsPageProvider
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Services;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Security
{
  [Component(Order = 50)]
  public class ModulePermissionsPageProvider : 
    IModulePermissionsPageProvider,
    IModuleSettingsPageProvider
  {
    public string ModuleUid => "EleWise.ELMA.CRM.Web";

    public string Url(UrlHelper urlHelper) => urlHelper.Action("Permissions", "Security", (object) new
    {
      area = "EleWise.ELMA.CRM.Web"
    });

    public string Image => "#client.svg";

    public string Text => SR.T("Работа с клиентами");

    public string Description => SR.T("Раздел содержит перечень прав доступа к объектам модуля <b>CRM</b>. С помощью данного раздела настраиваются параметры видимости объектов и набор доступных операций с этими объектами. ");
  }
}
