// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.BPM.Mvc.Controllers.BPMController
// Assembly: EleWise.ELMA.BPM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EE1B80B5-F464-4FFF-85CF-6A69B66F676D
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.BPM.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.BPM.xml

using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Web.Mvc.Controllers;
using j3AmrhgkCleVTGdEwA;
using Orchard.Themes;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.BPM.Mvc.Controllers
{
  /// <summary>
  /// Базовый контроллер для модулей Платформы. Содержит несколько вспомогательных сервисов.
  /// </summary>
  [Themed]
  public class BPMController : BaseController
  {
    internal static BPMController TE6SuAg1WkXW0IDgK1;

    /// <summary>
    /// Получить текущего пользователя как модель Платформы <see cref="T:EleWise.ELMA.Security.Models.IUser" />
    /// </summary>
    /// <returns>Текущий пользователь контекста или <c>null</c></returns>
    protected IUser GetCurrentUser() => ((IAuthenticationService) BPMController.JG9blciijPcX1XwC9gT((object) this)).GetCurrentUser<IUser>();

    public BPMController()
    {
      TKW1L3mlUyvXmg29jA.RWk58XigPN();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (<Module>\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_97b683f617e640659cafc539b8e993b2 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object JG9blciijPcX1XwC9gT([In] object obj0) => (object) __nonvirtual (((BaseController) obj0).AuthenticationService);

    internal static bool LrUQ22zqx4CAOAZj7U() => BPMController.TE6SuAg1WkXW0IDgK1 == null;

    internal static BPMController BDPxWCidRdkBMoGiRmP() => BPMController.TE6SuAg1WkXW0IDgK1;
  }
}
