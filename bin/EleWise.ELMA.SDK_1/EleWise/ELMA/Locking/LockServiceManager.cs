// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Locking.LockServiceManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Configuration;
using EleWise.ELMA.Runtime.Providers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Locking
{
  /// <summary>Менеджер сервиса блокировок</summary>
  public class LockServiceManager : GenericProviderManager<LockService, ILockService>
  {
    /// <summary>Строковое представление идентификатора</summary>
    public const string UID_S = "{43C6D863-0255-440A-91DE-27FB90EB1BD4}";
    /// <summary>Идентификатор провайдера</summary>
    public static readonly Guid UID;
    /// <summary>Имя провайдера</summary>
    public static readonly string NAME;
    internal static LockServiceManager pkl0wlhrsdyvZDLynpFW;

    /// <inheritdoc />
    public override Guid Uid => LockServiceManager.UID;

    /// <inheritdoc />
    public override string Name => LockServiceManager.NAME;

    /// <inheritdoc />
    public override void Configure(
      ProviderSettingsSection settings,
      RuntimeConfiguration configuration)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            LockServiceManager.n0VnEuhgBBkFhcBXaemY((object) this.DefaultProvider, (object) settings, (object) configuration);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
            continue;
          case 2:
            LockServiceManager.JNd1x8hgFGwifpBdkxka((object) this, (object) settings, (object) configuration);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    public LockServiceManager()
    {
      LockServiceManager.BTddbDhgW30PddS6d786();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static LockServiceManager()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            LockServiceManager.NAME = (string) LockServiceManager.xuhJtjhgohYGSlN8GXdm(95909607 + 343705423 ^ 439378612);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 1 : 2;
            continue;
          default:
            LockServiceManager.UID = new Guid((string) LockServiceManager.xuhJtjhgohYGSlN8GXdm(1051802738 - -1831968059 ^ -1411299937));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 3 : 3;
            continue;
        }
      }
label_2:;
    }

    internal static void JNd1x8hgFGwifpBdkxka([In] object obj0, [In] object obj1, [In] object obj2) => __nonvirtual (((GenericProviderManager<LockService, ILockService>) obj0).Configure((ProviderSettingsSection) obj1, (RuntimeConfiguration) obj2));

    internal static void n0VnEuhgBBkFhcBXaemY([In] object obj0, [In] object obj1, [In] object obj2) => ((LockService) obj0).Configure((ProviderSettingsSection) obj1, (RuntimeConfiguration) obj2);

    internal static bool QWOVYrhrcCJgSd51lb6F() => LockServiceManager.pkl0wlhrsdyvZDLynpFW == null;

    internal static LockServiceManager sGJTsthrzYZfXMCBV4Bw() => LockServiceManager.pkl0wlhrsdyvZDLynpFW;

    internal static void BTddbDhgW30PddS6d786() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object xuhJtjhgohYGSlN8GXdm(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
