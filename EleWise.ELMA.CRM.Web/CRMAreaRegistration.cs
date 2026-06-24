// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.CRMAreaRegistration
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web
{
  public class CRMAreaRegistration : AreaRegistration
  {
    public const string AREA_NAME = "EleWise.ELMA.CRM.Web";

    public override string AreaName => "EleWise.ELMA.CRM.Web";

    public override void RegisterArea(AreaRegistrationContext context) => context.MapRoute("CRM_default", "CRM/{controller}/{action}/{id}", (object) new
    {
      controller = "Contractor",
      action = "Index",
      id = UrlParameter.Optional
    });
  }
}
