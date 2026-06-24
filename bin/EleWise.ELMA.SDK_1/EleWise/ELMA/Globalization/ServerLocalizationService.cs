// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Globalization.ServerLocalizationService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using j3AmrhgkCleVTGdEwA;
using System.Globalization;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Globalization
{
  /// <summary>
  /// Серверный сервис локализации для использования дизайнером
  /// </summary>
  public class ServerLocalizationService : 
    DTOManager,
    IServerLocalizationService,
    IConfigurationService
  {
    internal static ServerLocalizationService H4aS4AGELOuJHpwwQhY9;

    public virtual string GetDefaultCultureName() => (string) ServerLocalizationService.GibsWQGEc3hjpQ6iqIXR((object) SR.GetDefaultCulture());

    public ServerLocalizationService()
    {
      ServerLocalizationService.mS4p4KGEzEZ93YEpQIR9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object GibsWQGEc3hjpQ6iqIXR([In] object obj0) => (object) ((CultureInfo) obj0).Name;

    internal static void mS4p4KGEzEZ93YEpQIR9() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool U06ICdGEU4mPS1bsUc1r() => ServerLocalizationService.H4aS4AGELOuJHpwwQhY9 == null;

    internal static ServerLocalizationService kZeQXOGEsBMLkbdhy3Rt() => ServerLocalizationService.H4aS4AGELOuJHpwwQhY9;
  }
}
