// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.SecurityDefaultHomePagePortletProvider
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Web.Portlets;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using System.Collections.Generic;

namespace EleWise.ELMA.CRM.Web.Components
{
  [Component]
  internal class SecurityDefaultHomePagePortletProvider : ISecurityDefaultHomePagePortletsProvider
  {
    public CRMHomePortlet CRMHomePortlet { get; set; }

    public IEnumerable<SecurityDefaultHomePagePortlet> Portlets()
    {
      yield return new SecurityDefaultHomePagePortlet((IPortlet) this.CRMHomePortlet, "Left", 40);
    }
  }
}
