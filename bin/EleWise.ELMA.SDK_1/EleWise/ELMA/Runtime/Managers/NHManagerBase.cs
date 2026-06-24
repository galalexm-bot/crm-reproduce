// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Managers.NHManagerBase
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.NH;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.Managers
{
  /// <summary>Базовый абстрактный класс менеджера NHibernate</summary>
  public abstract class NHManagerBase
  {
    internal static NHManagerBase lmIK41WJv8XDtP5fxAMo;

    /// <summary>Получить имя БД по умолчанию</summary>
    /// <returns>Имя БД</returns>
    protected string GetDbName() => string.Empty;

    /// <summary>Сессия NHibernate</summary>
    [NotNull]
    protected ISession Session => (ISession) NHManagerBase.n1IAdYWJuuAwGnjgQoQY((object) this.SessionProvider, (object) this.GetDbName());

    /// <summary>Провайдер сессий</summary>
    [NotNull]
    public ISessionProvider SessionProvider
    {
      protected get => this.\u003CSessionProvider\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CSessionProvider\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    protected NHManagerBase()
    {
      NHManagerBase.HyyndPWJIeiPLVreAWJD();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object n1IAdYWJuuAwGnjgQoQY([In] object obj0, [In] object obj1) => (object) ((ISessionProvider) obj0).GetSession((string) obj1);

    internal static bool oMXn3lWJ86dKpsKFGNpy() => NHManagerBase.lmIK41WJv8XDtP5fxAMo == null;

    internal static NHManagerBase PLrAGiWJZLBwCyFJ9E6N() => NHManagerBase.lmIK41WJv8XDtP5fxAMo;

    internal static void HyyndPWJIeiPLVreAWJD() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
