// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Settings.CommonSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Configuration;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Remoting;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web.Mvc;

namespace EleWise.ELMA.Runtime.Settings
{
  /// <summary>Общие настройки системы</summary>
  public class CommonSettings : GlobalSettingsBase
  {
    private int remotingPort;
    private string _systemDefaultCultureName;
    private string applicationBaseUrl;
    private string invalidFileExtensions;
    private List<string> invalidFileExtensionsList;
    internal static CommonSettings CXAtgsWhnwEGFX35JZve;

    /// <summary>Ctor</summary>
    public CommonSettings()
    {
      CommonSettings.i81QfFWhen9IC1utmULV();
      this.remotingPort = 7100;
      this.applicationBaseUrl = (string) CommonSettings.laLnMCWhPIbSKirF48ER(647913418 ^ 648004290);
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.InvalidFileExtensions = (string) CommonSettings.laLnMCWhPIbSKirF48ER(964881585 - -1459193222 ^ -1870794885);
            num = 2;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.MaxFileSize = 1000;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 1 : 1;
            continue;
          default:
            this.WindowTitle = (string) CommonSettings.YmwiWHWh1rUK0wMhtxPC(CommonSettings.laLnMCWhPIbSKirF48ER(--1418440330 ^ 1418343334));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 3 : 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Заголовок окна</summary>
    [DisplayName(typeof (CommonSettings.__Resources_CommonSettings), "WindowTitle")]
    public string WindowTitle
    {
      get => this.\u003CWindowTitle\u003Ek__BackingField;
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
              this.\u003CWindowTitle\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 0;
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

    /// <summary>Базовый URL системы</summary>
    [RegularExpression("^(?:https?)://[^\\s/$.?#].?[^\\s]*$", typeof (CommonSettings.__Resources_CommonSettings), "ApplicationBaseUrlErrorMessage")]
    [DisplayName(typeof (CommonSettings.__Resources_CommonSettings), "ApplicationBaseUrl")]
    public string ApplicationBaseUrl
    {
      get => this.applicationBaseUrl;
      set
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_6;
            case 2:
              if (!CommonSettings.m70puYWhNSVI5c96jjAQ((object) value, UriKind.Absolute))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 1;
                continue;
              }
              break;
            case 3:
              goto label_2;
          }
          this.applicationBaseUrl = value;
          num = 3;
        }
label_2:
        return;
label_6:
        throw new ArgumentException((string) CommonSettings.laLnMCWhPIbSKirF48ER(964881585 - -1459193222 ^ -1870794911));
      }
    }

    /// <summary>Максимальный размер файла при загрузке (Mб)</summary>
    [DisplayName(typeof (CommonSettings.__Resources_CommonSettings), "MaxFileSize")]
    public int MaxFileSize
    {
      get => this.\u003CMaxFileSize\u003Ek__BackingField;
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
              this.\u003CMaxFileSize\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
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

    /// <summary>Недопустимые расширения файлов</summary>
    [DisplayName(typeof (CommonSettings.__Resources_CommonSettings), "InvalidFileExtensions")]
    public string InvalidFileExtensions
    {
      get => this.invalidFileExtensions;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.invalidFileExtensions = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            default:
              this.invalidFileExtensionsList = (List<string>) null;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 2 : 1;
              continue;
          }
        }
label_2:;
      }
    }

    /// <summary>Порт подключения дизайнера</summary>
    [DisplayName(typeof (CommonSettings.__Resources_CommonSettings), "RemotingPort")]
    public int RemotingPort
    {
      get => this.remotingPort;
      set
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              CommonSettings.QT9tOMWh3LEgyq045PnI();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
              continue;
            case 2:
              this.remotingPort = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 1 : 1;
              continue;
            default:
              goto label_5;
          }
        }
label_2:
        return;
label_5:;
      }
    }

    /// <summary>Порт, на котором на самом деле был запущен</summary>
    [HiddenInput(DisplayValue = false)]
    public int StartedRemotingPort => RemotingServiceRegistrar.GetRegisterdPort<ConfigurationServiceProvider>();

    /// <summary>Системная локаль по умолчанию</summary>
    [DisplayName(typeof (CommonSettings.__Resources_CommonSettings), "SystemDefaultCultureName")]
    public string SystemDefaultCultureName
    {
      get => this._systemDefaultCultureName;
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
              this._systemDefaultCultureName = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 0;
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
    /// Использовать базовый URL системы при подключении дизайнера
    /// </summary>
    [Description(typeof (CommonSettings.__Resources_CommonSettings), "UseBaseUrlForRemoting_Description")]
    [DisplayName(typeof (CommonSettings.__Resources_CommonSettings), "UseBaseUrlForRemoting")]
    public bool UseBaseUrlForRemoting
    {
      get => this.\u003CUseBaseUrlForRemoting\u003Ek__BackingField;
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
              this.\u003CUseBaseUrlForRemoting\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
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
    /// Получить "настоящий" порт для подключения дизайнера (с учетов возможного запуска в тестовом сервере)
    /// </summary>
    /// <returns></returns>
    public int GetRealRemotingPort() => this.RemotingPort;

    /// <summary>Получить недопустимые расширения файлов</summary>
    public List<string> GetInvalidFileExtensions()
    {
      if (this.invalidFileExtensionsList == null)
        this.invalidFileExtensionsList = ((IEnumerable<string>) this.InvalidFileExtensions.Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(712480695 ^ 712498837), string.Empty).Split(new char[1]
        {
          ','
        }, StringSplitOptions.RemoveEmptyEntries)).Select<string, string>((Func<string, string>) (e =>
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                if (e.StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -812031350)))
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
                  continue;
                }
                goto label_3;
              default:
                goto label_2;
            }
          }
label_2:
          return e;
label_3:
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          return (string) CommonSettings.\u003C\u003Ec.Jsge7fQNB5R3BRpEkYN9(CommonSettings.\u003C\u003Ec.foD4b0QNFkRin0pGfC4I(1051276242 - 990076387 ^ 61198123), (object) e);
        })).ToList<string>();
      return this.invalidFileExtensionsList;
    }

    internal static void i81QfFWhen9IC1utmULV() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object laLnMCWhPIbSKirF48ER(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object YmwiWHWh1rUK0wMhtxPC([In] object obj0) => (object) EleWise.ELMA.SR.M((string) obj0);

    internal static bool DbpRW1WhOMh9DRW7QGDK() => CommonSettings.CXAtgsWhnwEGFX35JZve == null;

    internal static CommonSettings UtjJ1rWh2ad6vDkpiSiW() => CommonSettings.CXAtgsWhnwEGFX35JZve;

    internal static bool m70puYWhNSVI5c96jjAQ([In] object obj0, [In] UriKind obj1) => Uri.IsWellFormedUriString((string) obj0, obj1);

    internal static void QT9tOMWh3LEgyq045PnI() => ConfigurationServiceProvider.Register();

    internal class __Resources_CommonSettings
    {
      private static CommonSettings.__Resources_CommonSettings oBuyDLQ1rJkrVT1iOFKS;

      public static string WindowTitle => (string) CommonSettings.__Resources_CommonSettings.R7TmkxQ1YLa2Wgw0xY8G(CommonSettings.__Resources_CommonSettings.Uv8C2yQ1jNEccCrpwRps(-1921202237 ^ -1921404869));

      public static string ApplicationBaseUrl => (string) CommonSettings.__Resources_CommonSettings.R7TmkxQ1YLa2Wgw0xY8G(CommonSettings.__Resources_CommonSettings.Uv8C2yQ1jNEccCrpwRps(-1120607109 - 305487170 ^ -1426391263));

      public static string ApplicationBaseUrlErrorMessage => EleWise.ELMA.SR.T((string) CommonSettings.__Resources_CommonSettings.Uv8C2yQ1jNEccCrpwRps(1819636893 << 3 ^ 1672404138));

      public static string MaxFileSize => (string) CommonSettings.__Resources_CommonSettings.R7TmkxQ1YLa2Wgw0xY8G(CommonSettings.__Resources_CommonSettings.Uv8C2yQ1jNEccCrpwRps(-398663332 ^ -398878296));

      public static string InvalidFileExtensions => (string) CommonSettings.__Resources_CommonSettings.R7TmkxQ1YLa2Wgw0xY8G((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1052221104 - 768835541 ^ 283207573));

      public static string RemotingPort => (string) CommonSettings.__Resources_CommonSettings.R7TmkxQ1YLa2Wgw0xY8G(CommonSettings.__Resources_CommonSettings.Uv8C2yQ1jNEccCrpwRps(1505778440 - 1981636111 ^ -475560619));

      public static string SystemDefaultCultureName => (string) CommonSettings.__Resources_CommonSettings.R7TmkxQ1YLa2Wgw0xY8G(CommonSettings.__Resources_CommonSettings.Uv8C2yQ1jNEccCrpwRps(1012087039 ^ 1012285723));

      public static string UseBaseUrlForRemoting => (string) CommonSettings.__Resources_CommonSettings.R7TmkxQ1YLa2Wgw0xY8G(CommonSettings.__Resources_CommonSettings.Uv8C2yQ1jNEccCrpwRps(272623989 ^ 272274263));

      public static string UseBaseUrlForRemoting_Description => (string) CommonSettings.__Resources_CommonSettings.R7TmkxQ1YLa2Wgw0xY8G(CommonSettings.__Resources_CommonSettings.Uv8C2yQ1jNEccCrpwRps(1461825605 - 1531863589 ^ -69847878));

      public __Resources_CommonSettings()
      {
        CommonSettings.__Resources_CommonSettings.e2mLxOQ1LGymIgol2nj1();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static object Uv8C2yQ1jNEccCrpwRps(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object R7TmkxQ1YLa2Wgw0xY8G([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

      internal static bool TacgCRQ1gxpGJqXNgmST() => CommonSettings.__Resources_CommonSettings.oBuyDLQ1rJkrVT1iOFKS == null;

      internal static CommonSettings.__Resources_CommonSettings JMHVIoQ15NNTx3L3uKdQ() => CommonSettings.__Resources_CommonSettings.oBuyDLQ1rJkrVT1iOFKS;

      internal static void e2mLxOQ1LGymIgol2nj1() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}
