// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Providers.BLOBStoreProviderManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Runtime.Managers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Runtime.Providers
{
  /// <summary>
  /// Менеджер провайдеров <see cref="T:EleWise.ELMA.Runtime.Providers.BLOBStoreProvider" />.
  /// Регистрирует провайдер как <see cref="T:EleWise.ELMA.Runtime.Managers.IBLOBDataManager" />
  /// </summary>
  public class BLOBStoreProviderManager : GenericProviderManager<BLOBStoreProvider, IBLOBDataManager>
  {
    /// <summary>Строковое представление идентификатора</summary>
    public const string UID_S = "{569DED27-BA06-4055-A704-EB198EB897AE}";
    /// <summary>Идентификатор провайдера</summary>
    public static readonly Guid UID;
    private static BLOBStoreProviderManager qbmQgIWEVGqSmqIlbDDL;

    /// <summary>Uid провайдера</summary>
    public override Guid Uid => BLOBStoreProviderManager.UID;

    /// <summary>Имя СУБД</summary>
    public override string Name => (string) BLOBStoreProviderManager.JXnwd5WERFekxixIYTmr(322893104 - -1992822529 ^ -1979278581);

    public BLOBStoreProviderManager()
    {
      BLOBStoreProviderManager.prCED4WEqiafWOuJdKCS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static BLOBStoreProviderManager()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            BLOBStoreProviderManager.UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(277947046 - -1479185048 ^ 1757031022));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
            continue;
          case 2:
            BLOBStoreProviderManager.prCED4WEqiafWOuJdKCS();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object JXnwd5WERFekxixIYTmr(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool t5PaTiWES4H6smI7gVjp() => BLOBStoreProviderManager.qbmQgIWEVGqSmqIlbDDL == null;

    internal static BLOBStoreProviderManager WNdExrWEi0fa2JsRwqEM() => BLOBStoreProviderManager.qbmQgIWEVGqSmqIlbDDL;

    internal static void prCED4WEqiafWOuJdKCS() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
