// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Globalization.TranslateDTOManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Globalization
{
  /// <summary>Скачивание переводов</summary>
  public class TranslateDTOManager : DTOManager, ITranslateDTOManager, IConfigurationService
  {
    internal static TranslateDTOManager WIgVR6GhVQEJBsJ8sdbf;

    public virtual bool IsTranslationMode()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (TranslateService.Instance != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return ((TranslateService) TranslateDTOManager.uDrTjrGhR66UXirM48pv()).IsTranslationModeEnabled();
label_3:
      return false;
    }

    public virtual bool IsTranslationChanged(LocalizationHash[] designerLocalizationHash)
    {
      int num = 1;
      LocalizationHash[] localizationHashArray;
      while (true)
      {
        switch (num)
        {
          case 1:
            localizationHashArray = (LocalizationHash[]) TranslateDTOManager.VuBj6tGhqDs8VoOxkVoW(TranslateDTOManager.uDrTjrGhR66UXirM48pv());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return !TranslateDTOManager.GJwQLcGhKwTnBQMw4m0D((object) new ArrayEqualityComparer<LocalizationHash>(), (object) localizationHashArray, (object) designerLocalizationHash);
    }

    public virtual string[] GetServerLocals()
    {
      List<CultureInfo> cultureNames = EleWise.ELMA.SR.GetCultureNames();
      // ISSUE: reference to a compiler-generated field
      Func<CultureInfo, string> func = TranslateDTOManager.\u003C\u003Ec.\u003C\u003E9__2_0;
      Func<CultureInfo, string> selector;
      if (func == null)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        TranslateDTOManager.\u003C\u003Ec.\u003C\u003E9__2_0 = selector = (Func<CultureInfo, string>) (c => (string) TranslateDTOManager.\u003C\u003Ec.tC8jG1vlxxs6u2Lx7D21((object) c));
      }
      else
        goto label_1;
label_3:
      return cultureNames.Select<CultureInfo, string>(selector).ToArray<string>();
label_1:
      selector = func;
      goto label_3;
    }

    public virtual byte[] GetTranslations(LocalizationHash[] designerLocalizationHash)
    {
      int num1 = 6;
      string str;
      while (true)
      {
        int num2 = num1;
        LocalizationHash localizationHash1;
        LocalizationHash[] localizationHash2;
        int index;
        string withoutExtension;
        string dst;
        LocalizationHash hash;
        while (true)
        {
          switch (num2)
          {
            case 1:
              num2 = 7;
              continue;
            case 2:
            case 14:
              if (index < localizationHash2.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 9 : 4;
                continue;
              }
              goto label_8;
            case 3:
              TranslateDTOManager.IjrrdCGhkqEeaiFKh83q((object) Locator.GetServiceNotNull<IZipService>(), (object) str, (object) withoutExtension);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 9 : 15;
              continue;
            case 4:
              ++index;
              num2 = 14;
              continue;
            case 5:
              localizationHash2 = ((TranslateService) TranslateDTOManager.uDrTjrGhR66UXirM48pv()).ComputeLocalizationHash();
              num2 = 10;
              continue;
            case 6:
              withoutExtension = IOExtensions.GetTempFileNameWithoutExtension();
              num2 = 5;
              continue;
            case 7:
              hash = localizationHash1;
              num2 = 12;
              continue;
            case 8:
              goto label_8;
            case 10:
              goto label_14;
            case 11:
              FileUtils.CopyDirectory(EleWise.ELMA.SR.GetCultureDir(hash.Local), dst);
              num2 = 4;
              continue;
            case 12:
              if (((IEnumerable<LocalizationHash>) designerLocalizationHash).All<LocalizationHash>((Func<LocalizationHash, bool>) (h => !h.Equals(hash))))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 1 : 13;
                continue;
              }
              goto case 4;
            case 13:
              dst = Path.Combine(withoutExtension, (string) TranslateDTOManager.r5BRgyGhXH5CVB6mvh3o((object) hash));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 5 : 11;
              continue;
            case 15:
              goto label_15;
            default:
              localizationHash1 = localizationHash2[index];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 1;
              continue;
          }
        }
label_8:
        str = (string) TranslateDTOManager.Kdd4vhGhTVhetsSo7Yq6((object) withoutExtension, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740411724));
        num1 = 3;
        continue;
label_14:
        index = 0;
        num1 = 2;
      }
label_15:
      return (byte[]) TranslateDTOManager.ereQTjGhnVtabyQwY0fc((object) str);
    }

    public virtual CultureInfoSimple GetDefaultLocal() => CultureInfoSimple.CreateFromCultureInfo((CultureInfo) TranslateDTOManager.lQ3fqAGhOQdMVpx2afsH());

    public TranslateDTOManager()
    {
      TranslateDTOManager.YsLFExGh2MumSZYpOyPP();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object uDrTjrGhR66UXirM48pv() => (object) TranslateService.Instance;

    internal static bool AdYLIHGhS0txpxKYuUZF() => TranslateDTOManager.WIgVR6GhVQEJBsJ8sdbf == null;

    internal static TranslateDTOManager ri6DUxGhiHG28Od6i2GI() => TranslateDTOManager.WIgVR6GhVQEJBsJ8sdbf;

    internal static object VuBj6tGhqDs8VoOxkVoW([In] object obj0) => (object) ((TranslateService) obj0).ComputeLocalizationHash();

    internal static bool GJwQLcGhKwTnBQMw4m0D([In] object obj0, [In] object obj1, [In] object obj2) => ((ArrayEqualityComparer<LocalizationHash>) obj0).Equals((LocalizationHash[]) obj1, (LocalizationHash[]) obj2);

    internal static object r5BRgyGhXH5CVB6mvh3o([In] object obj0) => (object) ((LocalizationHash) obj0).Local;

    internal static object Kdd4vhGhTVhetsSo7Yq6([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object IjrrdCGhkqEeaiFKh83q([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((IZipService) obj0).CreateZipFolder((string) obj1, (string) obj2);

    internal static object ereQTjGhnVtabyQwY0fc([In] object obj0) => (object) File.ReadAllBytes((string) obj0);

    internal static object lQ3fqAGhOQdMVpx2afsH() => (object) EleWise.ELMA.SR.GetDefaultCulture();

    internal static void YsLFExGh2MumSZYpOyPP() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
