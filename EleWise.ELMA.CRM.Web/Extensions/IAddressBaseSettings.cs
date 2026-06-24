// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Extensions.IAddressBaseSettings
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Extensions
{
  [ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
  public interface IAddressBaseSettings
  {
    IEnumerable<NamedValue<string>> Settings(UrlHelper url);
  }
}
