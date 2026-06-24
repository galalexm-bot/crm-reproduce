// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.Modules.Validator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Logging;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Import.Modules
{
  /// <summary>
  /// Класс для валидации настроек импорта модуля или приложения
  /// </summary>
  internal sealed class Validator
  {
    private static readonly ISet<string> emptyModuleIds;
    private readonly ILogger logger;
    internal static Validator ttojsAEJOrbvpqtRBq8v;

    /// <summary>Ctor</summary>
    /// <param name="logger">Журнал для записи информации о процессе валидации</param>
    public Validator(ILogger logger)
    {
      Validator.ErwQ1vEJPF0ZWd3dRshV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.logger = logger;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>
    /// Валидировать коллекцию настроек импорта модуля/приложения
    /// </summary>
    /// <param name="configImportSettings">Настройки импорта</param>
    /// <exception cref="T:EleWise.ELMA.Deploy.Import.Modules.ModuleValidationException">В случае если настройки неверны</exception>
    public void Validate(
      IReadOnlyCollection<IConfigImportSettings> configImportSettings)
    {
      if (configImportSettings == null || configImportSettings.Count == 0)
        throw this.Error(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461346837)));
      if (configImportSettings.Count == 1)
        this.ValidateModule(configImportSettings.First<IConfigImportSettings>(), Validator.emptyModuleIds);
      else
        this.ValidateApplication(configImportSettings);
    }

    /// <summary>Валидировать настройки импорта приложения</summary>
    /// <param name="configImportSettings">Настройки импорта</param>
    /// <exception cref="T:EleWise.ELMA.Deploy.Import.Modules.ModuleValidationException">В случае если настройки неверны</exception>
    public void ValidateApplication(
      IReadOnlyCollection<IConfigImportSettings> configImportSettings)
    {
      this.ValidateApplicationHeader(configImportSettings.First<IConfigImportSettings>());
      // ISSUE: reference to a compiler-generated method
      HashSet<string> hashSet = configImportSettings.First<IConfigImportSettings>().Manifest.BpmApps.Select<BpmAppManifest, string>((Func<BpmAppManifest, string>) (b => (string) Validator.\u003C\u003Ec.mvo1t586R1lRE0guLbJr((object) b))).ToHashSet<string>();
      foreach (IConfigImportSettings import in configImportSettings.Skip<IConfigImportSettings>(1))
        this.ValidateModule(import, (ISet<string>) hashSet);
      ElmaStoreComponentManifest manifest = configImportSettings.First<IConfigImportSettings>().Manifest;
      this.Info(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1033719030 - 2012070891 ^ -978630439), (object) manifest.Title, (object) manifest.Id));
    }

    /// <summary>
    /// Валидировать настройки импорта корневого BPMApp приложения
    /// </summary>
    /// <param name="import">Настройки импорта</param>
    /// <exception cref="T:EleWise.ELMA.Deploy.Import.Modules.ModuleValidationException">В случае если настройки неверны</exception>
    public void ValidateApplicationHeader(IConfigImportSettings import)
    {
      int num = 2;
      while (true)
      {
        object obj;
        switch (num)
        {
          case 1:
            obj = Validator.jOE9CHEJ1gL8EKt5Ovwe((object) import);
            break;
          case 2:
            if (import != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 1 : 0;
              continue;
            }
            goto case 3;
          case 3:
            obj = (object) null;
            break;
          case 4:
            if (Validator.hJIqNoEJDuKe4JAZD5e3(Validator.Wr26ZWEJa1W9ksQN3c7Z(Validator.jOE9CHEJ1gL8EKt5Ovwe((object) import)), Guid.Empty))
            {
              num = 5;
              continue;
            }
            goto label_3;
          case 5:
            goto label_9;
          default:
            goto label_6;
        }
        if (obj != null)
        {
          if (Validator.QA77skEJpJflDUV7GIwa((object) import.Manifest) == ManifestComponentType.Application)
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 1 : 4;
          else
            goto label_9;
        }
        else
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
      }
label_6:
      throw this.Error((string) Validator.A02ZeyEJ3fOWxUSYOoJd(Validator.wUdxMWEJN2OIwFvN7Vp9(813604817 ^ 813325701)));
label_9:
      throw this.Error(EleWise.ELMA.SR.T((string) Validator.wUdxMWEJN2OIwFvN7Vp9(-244066886 - -48452443 ^ -195826733), (object) import.Manifest.Title, Validator.kqBTYtEJtEXATeUhTgbK(Validator.jOE9CHEJ1gL8EKt5Ovwe((object) import))));
label_3:;
    }

    /// <summary>Валидировать настройки импорта модуля</summary>
    /// <param name="import">Настройки импорта</param>
    /// <param name="moduleIds">Идентификаторы модулей импорт которых разрешен. Если пуст - проверка не производится</param>
    /// <exception cref="T:EleWise.ELMA.Deploy.Import.Modules.ModuleValidationException">В случае если настройки неверны</exception>
    public void ValidateModule(IConfigImportSettings import, ISet<string> moduleIds)
    {
      if (import?.Manifest == null)
        throw this.Error(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-122002947 ^ 121724200)));
      if (import.Manifest.ProductType != ManifestComponentType.Module || import.Manifest.ModuleUid == Guid.Empty || import.Manifest.BpmApps.Count > 0)
        throw this.Error(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1335271525), (object) import.Manifest.Title, (object) import.Manifest.Id));
      if (moduleIds.Count > 0 && !moduleIds.Contains(import.Manifest.Id))
        throw this.Error(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112456858), (object) import.Manifest.Title, (object) import.Manifest.Id));
      this.Info(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470440286 ^ 1470228258), (object) import.Manifest.Title, (object) import.Manifest.Id));
    }

    private Exception Error(string message)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.logger.Log(EleWise.ELMA.Logging.LogLevel.Error, (Exception) null, message);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return (Exception) new ModuleValidationException(message);
    }

    private void Info(string message)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.logger.Log(EleWise.ELMA.Logging.LogLevel.Information, (Exception) null, message);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    static Validator()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            Validator.emptyModuleIds = (ISet<string>) new HashSet<string>(0);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
            continue;
          case 2:
            Validator.ErwQ1vEJPF0ZWd3dRshV();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static void ErwQ1vEJPF0ZWd3dRshV() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool gWaBd1EJ2RrPAQPH9q22() => Validator.ttojsAEJOrbvpqtRBq8v == null;

    internal static Validator JTQtJYEJeKRD0DmtN9ED() => Validator.ttojsAEJOrbvpqtRBq8v;

    internal static object jOE9CHEJ1gL8EKt5Ovwe([In] object obj0) => (object) ((IConfigImportSettings) obj0).Manifest;

    internal static object wUdxMWEJN2OIwFvN7Vp9(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object A02ZeyEJ3fOWxUSYOoJd([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static ManifestComponentType QA77skEJpJflDUV7GIwa([In] object obj0) => ((ElmaStoreComponentManifest) obj0).ProductType;

    internal static Guid Wr26ZWEJa1W9ksQN3c7Z([In] object obj0) => ((ElmaStoreComponentManifest) obj0).ModuleUid;

    internal static bool hJIqNoEJDuKe4JAZD5e3([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static object kqBTYtEJtEXATeUhTgbK([In] object obj0) => (object) ((ElmaStoreComponentManifest) obj0).Id;
  }
}
