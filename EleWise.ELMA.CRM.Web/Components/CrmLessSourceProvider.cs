// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.CrmLessSourceProvider
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.CRM.Web.Components
{
  [Component(Order = 800)]
  internal class CrmLessSourceProvider : ILayoutLessSourceProvider, IAbstractLessSourceProvider
  {
    public string Area => "EleWise.ELMA.CRM.Web";

    public string ContentPath => "~/Modules/EleWise.ELMA.CRM.Web/Content/";

    public string FileName => "index.less";
  }
}
