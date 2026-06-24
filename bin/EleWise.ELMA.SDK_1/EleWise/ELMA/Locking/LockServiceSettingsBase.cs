// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Locking.LockServiceSettingsBase
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Configuration;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Locking
{
  /// <summary>Базовый класс настроек сервиса блокировок</summary>
  public class LockServiceSettingsBase : ConfigurationSection
  {
    private static LockServiceSettingsBase bAghp9hgbc4hPKY3fIFf;

    /// <summary>
    /// Время жизни блокировки в секундах (отрицательные значения - бесконечное время жизни. Настоятельно не рекомендуется!)
    /// </summary>
    [ConfigurationProperty("validFor", DefaultValue = 30)]
    public int DefaultLockValidFor
    {
      get => (int) LockServiceSettingsBase.TB0KsRhgfvfGTBgHmZvZ((object) this, LockServiceSettingsBase.dTE4SThgEMd4PopHbVXE(-2092274397 << 4 ^ 883248812));
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
              LockServiceSettingsBase.HtYmlVhgQFmt0bVCbddE((object) this, LockServiceSettingsBase.dTE4SThgEMd4PopHbVXE(-138018305 ^ -138044061), (object) value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
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

    /// <summary>
    /// Время таймаута при получении блокировки в секундах (отрицательные значения - бесконечное время)
    /// </summary>
    [ConfigurationProperty("timeout", DefaultValue = 30)]
    public int DefaultLockTimeout
    {
      get => (int) this[(string) LockServiceSettingsBase.dTE4SThgEMd4PopHbVXE(-740338220 ^ -740505244)];
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
              LockServiceSettingsBase.HtYmlVhgQFmt0bVCbddE((object) this, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105292974), (object) value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
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

    /// <summary>
    /// Время повторной попытки захвата блокировки в милисекундах
    /// </summary>
    [ConfigurationProperty("repeat", DefaultValue = 500)]
    public int DefaultLockRepeat
    {
      get => (int) this[(string) LockServiceSettingsBase.dTE4SThgEMd4PopHbVXE(1994213607 >> 4 ^ 124667980)];
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
              this[(string) LockServiceSettingsBase.dTE4SThgEMd4PopHbVXE(1149433385 + 173655049 ^ 1323247344)] = (object) value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
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

    public LockServiceSettingsBase()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object dTE4SThgEMd4PopHbVXE(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object TB0KsRhgfvfGTBgHmZvZ([In] object obj0, [In] object obj1) => ((ConfigurationElement) obj0)[(string) obj1];

    internal static bool jOfhQ4hghvya4a5EV0EE() => LockServiceSettingsBase.bAghp9hgbc4hPKY3fIFf == null;

    internal static LockServiceSettingsBase A9pQVahgGlnWZlqLtdne() => LockServiceSettingsBase.bAghp9hgbc4hPKY3fIFf;

    internal static void HtYmlVhgQFmt0bVCbddE([In] object obj0, [In] object obj1, [In] object obj2) => ((ConfigurationElement) obj0)[(string) obj1] = obj2;
  }
}
