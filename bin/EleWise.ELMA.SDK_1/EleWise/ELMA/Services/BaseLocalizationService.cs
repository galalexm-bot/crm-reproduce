// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.BaseLocalizationService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Packaging;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.Services
{
  public abstract class BaseLocalizationService : ILocalizationService
  {
    private static BaseLocalizationService Wx3emWB77QSFaLnFLSco;

    /// <summary>Проверка аутентификации</summary>
    public IAuthenticationService AuthenticationService
    {
      get => this.\u003CAuthenticationService\u003Ek__BackingField;
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
              this.\u003CAuthenticationService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
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

    /// <summary>Сохранить культуру для текущего пользователя</summary>
    /// <param name="info"></param>
    public abstract void Save(CultureInfo info);

    /// <summary>Сохранить культуру для указанного пользователя</summary>
    /// <param name="info"></param>
    /// <param name="user">Пользователь</param>
    public abstract void Save(CultureInfo info, IUser user);

    /// <summary>Загрузить культуру текущего пользователя</summary>
    /// <returns></returns>
    public virtual CultureInfo Load()
    {
      int num = 1;
      IUser user;
      while (true)
      {
        switch (num)
        {
          case 1:
            user = (IUser) BaseLocalizationService.qyViOAB7m7aiWtLssqMy((object) this.AuthenticationService);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (CultureInfo) BaseLocalizationService.g8nT4SB7ycTJQXTE6MWr((object) this, (object) user);
    }

    /// <summary>
    /// Загрузить культуру указанного. Если user == null, то загрузит текущего
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public abstract CultureInfo Load(IUser user);

    /// <summary>Инициализация текущей культуры</summary>
    public virtual void InitCulture()
    {
      int num = 2;
      CultureInfo culture;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.SetThreadCulture(culture);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
            continue;
          case 2:
            culture = (CultureInfo) BaseLocalizationService.rJBgHZB7McT10Ms7Y8Tm((object) this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>Инициализация текущей культуры из файла</summary>
    public virtual void InitCulture(string filePath)
    {
      int num = 2;
      LanguageHolder languageHolder;
      CultureInfo culture;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (languageHolder == null)
            {
              num = 5;
              continue;
            }
            goto case 3;
          case 2:
            languageHolder = (LanguageHolder) BaseLocalizationService.h0mvV1B7JJrun6LZaJXd((object) filePath);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 1 : 1;
            continue;
          case 3:
            culture = (CultureInfo) BaseLocalizationService.vcIPxbB79e8s40MGNOeY((object) languageHolder);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
            continue;
          case 4:
            goto label_8;
          case 5:
            goto label_2;
          default:
            this.SetThreadCulture(culture);
            num = 4;
            continue;
        }
      }
label_8:
      return;
label_2:;
    }

    private void SetThreadCulture(CultureInfo culture)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_5;
          case 1:
            if (culture == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 2:
            goto label_2;
          case 3:
            ((Thread) BaseLocalizationService.okSv0pB7d0IMhQlSXyDn()).CurrentUICulture = culture;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 3 : 4;
            continue;
          case 4:
            BaseLocalizationService.QVPtPRB7gxoQNRBk3435(BaseLocalizationService.okSv0pB7d0IMhQlSXyDn(), BaseLocalizationService.Tgf7cZB7reTntkttX7r2(BaseLocalizationService.Rj2SMkB7l4dhuCyPpdkM((object) culture)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 2 : 2;
            continue;
          default:
            goto label_8;
        }
      }
label_5:
      return;
label_2:
      return;
label_8:;
    }

    /// <summary>Системная локаль по умолчанию</summary>
    public abstract CultureInfo DefaultCulture { get; }

    /// <summary>Установить системную локаль по умолчанию</summary>
    /// <param name="name"></param>
    public abstract void SetDefaultCulture(string name);

    protected BaseLocalizationService()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool OGC5j3B7x1s95jAkHDWc() => BaseLocalizationService.Wx3emWB77QSFaLnFLSco == null;

    internal static BaseLocalizationService kqdnb4B70LjfdjoEUnfn() => BaseLocalizationService.Wx3emWB77QSFaLnFLSco;

    internal static object qyViOAB7m7aiWtLssqMy([In] object obj0) => (object) ((IAuthenticationService) obj0).GetCurrentUser();

    internal static object g8nT4SB7ycTJQXTE6MWr([In] object obj0, [In] object obj1) => (object) ((BaseLocalizationService) obj0).Load((IUser) obj1);

    internal static object rJBgHZB7McT10Ms7Y8Tm([In] object obj0) => (object) ((BaseLocalizationService) obj0).Load();

    internal static object h0mvV1B7JJrun6LZaJXd([In] object obj0) => (object) EleWise.ELMA.SR.ReadFromFile((string) obj0);

    internal static object vcIPxbB79e8s40MGNOeY([In] object obj0) => (object) ((LanguageHolder) obj0).GetCulture();

    internal static object okSv0pB7d0IMhQlSXyDn() => (object) Thread.CurrentThread;

    internal static object Rj2SMkB7l4dhuCyPpdkM([In] object obj0) => (object) ((CultureInfo) obj0).Name;

    internal static object Tgf7cZB7reTntkttX7r2([In] object obj0) => (object) CultureInfo.CreateSpecificCulture((string) obj0);

    internal static void QVPtPRB7gxoQNRBk3435([In] object obj0, [In] object obj1) => ((Thread) obj0).CurrentCulture = (CultureInfo) obj1;
  }
}
