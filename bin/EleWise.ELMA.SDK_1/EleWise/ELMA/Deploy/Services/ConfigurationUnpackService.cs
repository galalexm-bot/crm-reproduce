// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Services.ConfigurationUnpackService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.BPMApps;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Utils;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Packaging.Helper;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Services
{
  /// <inheritdoc />
  [Service]
  internal sealed class ConfigurationUnpackService : IConfigurationUnpackService
  {
    private readonly IExportImportFileService fileService;
    private readonly IModuleMetadataExtractorService moduleMetadataExtractorService;
    private readonly ITagService tagService;
    private readonly IZipService zipService;
    private readonly IModuleDTOManager moduleManager;
    internal static ConfigurationUnpackService z72SD2E4zpj7sCFtDHVj;

    /// <summary>Ctor</summary>
    /// <param name="fileService">Сервис передачи файлов импорта/экспорта</param>
    /// <param name="moduleMetadataExtractorService">Загрузчик метаданных модулей</param>
    /// <param name="tagService">Сервис работы с ограничениями bpmapp</param>
    /// <param name="zipService">Сервис архивации</param>
    /// <param name="moduleManager">Менеджер модулей</param>
    public ConfigurationUnpackService(
      IExportImportFileService fileService,
      IModuleMetadataExtractorService moduleMetadataExtractorService,
      ITagService tagService,
      IZipService zipService,
      IModuleDTOManager moduleManager)
    {
      ConfigurationUnpackService.xlMDMhE6W7jgYd3wDsy8();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.tagService = tagService;
            num = 3;
            continue;
          case 2:
            this.moduleMetadataExtractorService = moduleMetadataExtractorService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 1 : 1;
            continue;
          case 3:
            this.zipService = zipService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 0 : 0;
            continue;
          case 4:
            this.fileService = fileService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 2 : 2;
            continue;
          case 5:
            goto label_2;
          default:
            this.moduleManager = moduleManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 5 : 5;
            continue;
        }
      }
label_2:;
    }

    /// <inheritdoc />
    public IEnumerable<IConfigImportSettings> Unpack(
      BinaryFile file,
      ILogger logger,
      bool checkManifests,
      bool tagFilter)
    {
      Contract.ArgumentNotNull((object) file, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35917269));
      return (IEnumerable<IConfigImportSettings>) new ConfigurationUnpackService.ConfigurationUnpacker(this.fileService, this.moduleMetadataExtractorService, this.tagService, this.zipService, this.moduleManager, logger ?? NullLogger.Instance, checkManifests, tagFilter).Unpack(file);
    }

    /// <inheritdoc />
    public IEnumerable<IConfigImportSettings> FilterByTags(
      IEnumerable<IConfigImportSettings> importSettings)
    {
      return importSettings.Where<IConfigImportSettings>((Func<IConfigImportSettings, bool>) (s => this.tagService.ValidateTags((ElmaStoreComponentManifest) ConfigurationUnpackService.TZw001E6oN5anUcM5AI2((object) s))));
    }

    /// <inheritdoc />
    public void ValidateComponents(IEnumerable<IConfigImportSettings> importSettings)
    {
      List<string> warnings;
      List<string> errors;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if (!ConfigurationUnpackService.ValidateComponents(importSettings.Where<IConfigImportSettings>((Func<IConfigImportSettings, bool>) (s => ConfigurationUnpackService.\u003C\u003Ec.trhdUx8PP67C8JNcF2Wy((object) s) != null)).Select<IConfigImportSettings, ElmaStoreComponentManifest>((Func<IConfigImportSettings, ElmaStoreComponentManifest>) (s => (ElmaStoreComponentManifest) ConfigurationUnpackService.\u003C\u003Ec.trhdUx8PP67C8JNcF2Wy((object) s))), this.moduleManager.GetInstalledComponentManifests(), out warnings, out errors))
        throw new ConfigurationUnpackException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(647913418 ^ 647681488)), (Exception) null, (IEnumerable<string>) warnings, (IEnumerable<string>) errors);
    }

    private static bool ValidateComponents(
      IEnumerable<ElmaStoreComponentManifest> components,
      IEnumerable<ElmaStoreComponentManifest> installedComponents,
      out List<string> warnings,
      out List<string> errors)
    {
      if (components.Any<ElmaStoreComponentManifest>((Func<ElmaStoreComponentManifest, bool>) (c => c.ActivationType == ElmaStoreComponentActivationType.Paid)))
      {
        warnings = new List<string>(0);
        errors = new List<string>()
        {
          EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-441065788 ^ -2092910478 ^ 1727130854), (object) ElmaEditionHelper.GetDisplayName(ElmaEdition.CE))
        };
        return false;
      }
      Dictionary<ElmaStoreComponentManifest, bool> dictionary = installedComponents.Where<ElmaStoreComponentManifest>((Func<ElmaStoreComponentManifest, bool>) (c =>
      {
        int num = 1;
        ElmaStoreComponentManifest c1;
        while (true)
        {
          switch (num)
          {
            case 1:
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            default:
              c1 = c;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 2;
              continue;
          }
        }
label_2:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return !components.Any<ElmaStoreComponentManifest>((Func<ElmaStoreComponentManifest, bool>) (ci => ConfigurationUnpackService.\u003C\u003Ec__DisplayClass11_1.IMiCuw8P6AoaS3VSC83p(ConfigurationUnpackService.\u003C\u003Ec__DisplayClass11_1.CKT5vZ8P4cYXHPAxq8Yx((object) ci), ConfigurationUnpackService.\u003C\u003Ec__DisplayClass11_1.CKT5vZ8P4cYXHPAxq8Yx((object) c1))));
      })).Distinct<ElmaStoreComponentManifest>().ToDictionary<ElmaStoreComponentManifest, ElmaStoreComponentManifest, bool>((Func<ElmaStoreComponentManifest, ElmaStoreComponentManifest>) (c => c), (Func<ElmaStoreComponentManifest, bool>) (c => true));
      foreach (ElmaStoreComponentManifest component in components)
        dictionary.Add(component, false);
      return ManifestValidationHelper.Check(dictionary, out errors, out warnings) && ManifestValidationHelper.CheckByDependencies(components.ToList<ElmaStoreComponentManifest>(), dictionary.Keys.ToList<ElmaStoreComponentManifest>(), out errors);
    }

    internal static void xlMDMhE6W7jgYd3wDsy8() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool n3ndjcE6Fwpey3RFM6wq() => ConfigurationUnpackService.z72SD2E4zpj7sCFtDHVj == null;

    internal static ConfigurationUnpackService b8YsSaE6BAMb0pA3o5YO() => ConfigurationUnpackService.z72SD2E4zpj7sCFtDHVj;

    internal static object TZw001E6oN5anUcM5AI2([In] object obj0) => (object) ((IConfigImportSettings) obj0).Manifest;

    /// <summary>
    /// Класс для отслеживания и очистки созданных временных папок
    /// </summary>
    private sealed class ExportImportTempFolderTracer : IDisposable
    {
      /// <summary>Список созданных в процессе работы временных папок</summary>
      private List<string> tmpFolderPaths;
      /// <summary>
      /// Полный путь к подпапке, создаваемой по умолчанию в %TEMP% для хранения временных файлов экспорта/импорта
      /// </summary>
      private readonly object exportImportTempFolder;
      internal static object O1IWJ58e5AObEr6oWJb2;

      /// <summary>Конструктор класса</summary>
      internal ExportImportTempFolderTracer()
      {
        ConfigurationUnpackService.ExportImportTempFolderTracer.jmgZaE8eLu2mC1DEcA8w();
        this.tmpFolderPaths = new List<string>();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
          num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.exportImportTempFolder = ConfigurationUnpackService.ExportImportTempFolderTracer.u3ZH588ecTlKkyEVePBK(ConfigurationUnpackService.ExportImportTempFolderTracer.UR8umP8eUwWUdPGtcTZj(), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488894401), ConfigurationUnpackService.ExportImportTempFolderTracer.LJM0B68esSEmetePr1hS(-2106517564 ^ -2106267728));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
              continue;
            case 2:
              ConfigurationUnpackService.ExportImportTempFolderTracer.JW1rtB8PFnsjr4aJnHOu(this.exportImportTempFolder);
              num = 3;
              continue;
            case 3:
              goto label_3;
            default:
              if (!ConfigurationUnpackService.ExportImportTempFolderTracer.zKXFfq8ez4f0UDIp0SLC(this.exportImportTempFolder))
              {
                num = 2;
                continue;
              }
              goto label_8;
          }
        }
label_3:
        return;
label_8:;
      }

      /// <summary>Очистка временных папок и файлов</summary>
      public void Dispose() => this.CleanTempFolders();

      /// <summary>Функция получения уникальной временной папки</summary>
      /// <param name="prefix">Префикс для имени папки</param>
      /// <returns>Имя папки</returns>
      /// <remarks>Все созданные папки сохраняются в список и будут удалены при вызове метода очистки</remarks>
      internal string GetTempUniqueFolder(string prefix)
      {
        int num = 1;
        string tempUniqueFolder;
        while (true)
        {
          switch (num)
          {
            case 1:
              tempUniqueFolder = ExportImportTempFolderHelper.GetTempUniqueFolder((string) this.exportImportTempFolder, prefix);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_4;
            default:
              this.tmpFolderPaths.Add(tempUniqueFolder);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 2 : 2;
              continue;
          }
        }
label_4:
        return tempUniqueFolder;
      }

      /// <summary>Очистка временных папок</summary>
      private void CleanTempFolders()
      {
        int num1 = 2;
        while (true)
        {
          switch (num1)
          {
            case 0:
              goto label_5;
            case 1:
              ConfigurationUnpackService.ExportImportTempFolderTracer.EOWBjw8PBrpY6K2dLffb((object) this.tmpFolderPaths);
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 0 : 0;
              continue;
            case 2:
              List<string> tmpFolderPaths = this.tmpFolderPaths;
              // ISSUE: reference to a compiler-generated field
              Action<string> action1 = ConfigurationUnpackService.ExportImportTempFolderTracer.\u003C\u003Ec.\u003C\u003E9__6_0;
              Action<string> action2;
              if (action1 == null)
              {
                // ISSUE: reference to a compiler-generated field
                ConfigurationUnpackService.ExportImportTempFolderTracer.\u003C\u003Ec.\u003C\u003E9__6_0 = action2 = (Action<string>) (item =>
                {
                  int num2 = 1;
                  while (true)
                  {
                    switch (num2)
                    {
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        if (ConfigurationUnpackService.ExportImportTempFolderTracer.\u003C\u003Ec.OIPe8dZ20FkCFSZnGY8N((object) item))
                        {
                          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 0 : 0;
                          continue;
                        }
                        goto label_14;
                      case 2:
                        goto label_16;
                      default:
                        goto label_5;
                    }
                  }
label_16:
                  return;
label_14:
                  return;
label_5:
                  try
                  {
                    // ISSUE: reference to a compiler-generated method
                    ConfigurationUnpackService.ExportImportTempFolderTracer.\u003C\u003Ec.w9VAsYZ2mXFKr3isC0FD((object) item, true);
                    int num3 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
                      num3 = 0;
                    switch (num3)
                    {
                    }
                  }
                  catch (Exception ex)
                  {
                    int num4 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
                      num4 = 0;
                    while (true)
                    {
                      switch (num4)
                      {
                        case 1:
                          goto label_2;
                        default:
                          // ISSUE: reference to a compiler-generated method
                          // ISSUE: reference to a compiler-generated method
                          // ISSUE: reference to a compiler-generated method
                          ConfigurationUnpackService.ExportImportTempFolderTracer.\u003C\u003Ec.mXyPFcZ2J8BAGxR9SHMB((object) Logger.Log, (object) EleWise.ELMA.SR.T((string) ConfigurationUnpackService.ExportImportTempFolderTracer.\u003C\u003Ec.pKG3w0Z2y6n3gGwg5tik(-1350312861 << 3 ^ 2082000964), ConfigurationUnpackService.ExportImportTempFolderTracer.\u003C\u003Ec.sIf3vdZ2MjXDS6apWcEK((object) ex)));
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 1 : 1;
                          continue;
                      }
                    }
label_2:;
                  }
                });
              }
              else
                goto label_8;
label_7:
              tmpFolderPaths.ForEach(action2);
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 1 : 0;
              continue;
label_8:
              action2 = action1;
              goto label_7;
            default:
              goto label_2;
          }
        }
label_5:
        return;
label_2:;
      }

      internal static void jmgZaE8eLu2mC1DEcA8w() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static object UR8umP8eUwWUdPGtcTZj() => (object) Path.GetTempPath();

      internal static object LJM0B68esSEmetePr1hS(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object u3ZH588ecTlKkyEVePBK([In] object obj0, [In] object obj1, [In] object obj2) => (object) Path.Combine((string) obj0, (string) obj1, (string) obj2);

      internal static bool zKXFfq8ez4f0UDIp0SLC([In] object obj0) => Directory.Exists((string) obj0);

      internal static object JW1rtB8PFnsjr4aJnHOu([In] object obj0) => (object) Directory.CreateDirectory((string) obj0);

      internal static bool tjqhS28ejaKedA5iwL7y() => ConfigurationUnpackService.ExportImportTempFolderTracer.O1IWJ58e5AObEr6oWJb2 == null;

      internal static ConfigurationUnpackService.ExportImportTempFolderTracer XZZMY48eY3pYbixRG8yP() => (ConfigurationUnpackService.ExportImportTempFolderTracer) ConfigurationUnpackService.ExportImportTempFolderTracer.O1IWJ58e5AObEr6oWJb2;

      internal static void EOWBjw8PBrpY6K2dLffb([In] object obj0) => ((List<string>) obj0).Clear();
    }

    /// <summary>Объект для получения настроек импорта из файла</summary>
    /// <remarks>Логика адаптирована из WinForms дизайнера</remarks>
    private sealed class ConfigurationUnpacker
    {
      private readonly object fileService;
      private readonly object moduleMetadataExtractorService;
      private readonly object tagService;
      private readonly object zipService;
      private readonly object moduleManager;
      private readonly object logger;
      private readonly bool checkManifests;
      private readonly bool tagFilter;
      /// <summary>Список ошибок распаковки</summary>
      private readonly List<string> allErrors;
      /// <summary>Список предупреждений распаковки</summary>
      private readonly List<string> allWarnings;
      /// <summary>Настройки импорта для корневого пакета</summary>
      private readonly object rootSettings;
      /// <summary>Путь к файлу корневого пакета</summary>
      private object rootLocalFile;
      private List<string> extractedFiles;
      private List<ElmaStoreComponentManifest> loadedManifests;
      private List<ConfigImportSettings> allSettings;
      private Dictionary<ElmaStoreComponentManifest, string> localFiles;
      /// <summary>
      /// Класс для отслеживания созданных временных файлов и папок
      /// </summary>
      private object tempFolderTracer;
      internal static object zx8ius8PWoM3KRUAdSLy;

      /// <summary>Ctor</summary>
      /// <param name="fileService">Сервис передачи файлов импорта/экспорта</param>
      /// <param name="moduleMetadataExtractorService">Загрузчик метаданных модулей</param>
      /// <param name="tagService">Сервис работы с ограничениями bpmapp</param>
      /// <param name="zipService">Сервис архивации</param>
      /// <param name="moduleManager">Менеджер модулей</param>
      /// <param name="logger">Логер</param>
      /// <param name="checkManifests">Проверить манифесты компонетов на совместимость с текущей конфигурацией</param>
      /// <param name="tagFilter">Отфильтровать несовместимые компоненты по тегам манифеста</param>
      public ConfigurationUnpacker(
        IExportImportFileService fileService,
        IModuleMetadataExtractorService moduleMetadataExtractorService,
        ITagService tagService,
        IZipService zipService,
        IModuleDTOManager moduleManager,
        ILogger logger,
        bool checkManifests,
        bool tagFilter)
      {
        ConfigurationUnpackService.ConfigurationUnpacker.uNU9RE8PhEyuGgw27T4t();
        this.allErrors = new List<string>();
        this.allWarnings = new List<string>();
        this.rootSettings = (object) new ConfigImportSettings();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 9;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.checkManifests = checkManifests;
              num = 7;
              continue;
            case 2:
              this.tagService = (object) tagService;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 4 : 0;
              continue;
            case 3:
              this.logger = (object) logger;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 1;
              continue;
            case 4:
              this.zipService = (object) zipService;
              num = 5;
              continue;
            case 5:
              this.moduleManager = (object) moduleManager;
              num = 3;
              continue;
            case 6:
              this.tempFolderTracer = (object) new ConfigurationUnpackService.ExportImportTempFolderTracer();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
              continue;
            case 7:
              this.tagFilter = tagFilter;
              num = 6;
              continue;
            case 8:
              this.moduleMetadataExtractorService = (object) moduleMetadataExtractorService;
              num = 2;
              continue;
            case 9:
              this.fileService = (object) fileService;
              num = 8;
              continue;
            default:
              goto label_12;
          }
        }
label_2:
        return;
label_12:;
      }

      public IEnumerable<ConfigImportSettings> Unpack(BinaryFile file)
      {
        try
        {
          IEnumerable<ConfigImportSettings> configImportSettingses = this.DoUnpack(file);
          if (this.allErrors.Any<string>())
            throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461408521)));
          return configImportSettingses;
        }
        catch (Exception ex)
        {
          throw new ConfigurationUnpackException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333445314), (object) ex.Message), ex, (IEnumerable<string>) this.allWarnings, (IEnumerable<string>) this.allErrors);
        }
        finally
        {
          ((ConfigurationUnpackService.ExportImportTempFolderTracer) this.tempFolderTracer).Dispose();
        }
      }

      /// <summary>Выполнить распаковку</summary>
      private IEnumerable<ConfigImportSettings> DoUnpack(BinaryFile file)
      {
        this.rootLocalFile = (object) this.UploadFile((ConfigImportSettings) this.rootSettings, file);
        this.allSettings = new List<ConfigImportSettings>();
        ((ConfigImportSettings) this.rootSettings).Manifest = ElmaStoreComponentsBuilder.Read((string) this.rootLocalFile);
        ((ConfigImportSettings) this.rootSettings).FakeManifest.DisplayName = Path.GetFileNameWithoutExtension(file.Name);
        bool flag = false;
        if (((ConfigImportSettings) this.rootSettings).Manifest != null && ((ConfigImportSettings) this.rootSettings).Manifest.BpmApps != null && ((ConfigImportSettings) this.rootSettings).Manifest.BpmApps.Any<BpmAppManifest>())
        {
          List<string> files = new List<string>();
          this.ValidateTags(ElmaStoreComponentsBuilder.ExtractAndValidateOnComponent(new List<string>()
          {
            (string) this.rootLocalFile
          }, new Func<string, string>(((ConfigurationUnpackService.ExportImportTempFolderTracer) this.tempFolderTracer).GetTempUniqueFolder), (IEnumerable<string>) ComponentManager.Current.LicenseManager.GetActivationKeys().Select<KeyValuePair<Guid, string>, string>((Func<KeyValuePair<Guid, string>, string>) (a => a.Value)).ToList<string>(), new Func<DateTime?>(ComponentManager.Current.ModuleManager.GetMainLicensedUnitExpiration)), files, 0);
          this.extractedFiles = files;
          this.loadedManifests = this.DownloadManifestsLocal();
          flag = true;
          ((ConfigImportSettings) this.rootSettings).Manifest = (ElmaStoreComponentManifest) null;
        }
        if (((ConfigImportSettings) this.rootSettings).Manifest != null && !string.IsNullOrEmpty(((ConfigImportSettings) this.rootSettings).Manifest.BPMAppManifest))
          this.AddMessages((IEnumerable<TestImportMessages>) BPMAppManifestSerializationHelper.ValidateChaptersXsiTypes(((ConfigImportSettings) this.rootSettings).Manifest.BPMAppManifest));
        else if (this.loadedManifests != null)
        {
          foreach (ElmaStoreComponentManifest loadedManifest in this.loadedManifests)
            this.AddMessages((IEnumerable<TestImportMessages>) BPMAppManifestSerializationHelper.ValidateChaptersXsiTypes(loadedManifest.BPMAppManifest));
        }
        if (flag)
        {
          this.ExecuteLoadComponents();
        }
        else
        {
          if (((ConfigImportSettings) this.rootSettings).Manifest != null)
            this.ValidateComponents(new List<ElmaStoreComponentManifest>()
            {
              ((ConfigImportSettings) this.rootSettings).Manifest
            });
          this.allSettings.Add((ConfigImportSettings) this.rootSettings);
        }
        this.allSettings.ForEach((Action<ConfigImportSettings>) (s =>
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                ConfigurationUnpackService.ConfigurationUnpacker.\u003C\u003Ec.gpnZXTZ25VJIq6mkTenx(ConfigurationUnpackService.ConfigurationUnpacker.\u003C\u003Ec.mgcTw7Z2gHyyUiFuL7OB((object) s), (object) s.FileName);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }));
        return (IEnumerable<ConfigImportSettings>) this.allSettings;
      }

      /// <summary>
      /// Добавить ошибки и предупреждения из сообщений проверки
      /// </summary>
      /// <param name="messages">Список сообщений проверки</param>
      private void AddMessages(IEnumerable<TestImportMessages> messages)
      {
        if (messages == null)
          return;
        foreach (TestImportMessages message in messages)
        {
          if (message.Type == TestImportMessagesType.Error)
            this.AddErrors((IEnumerable<string>) new string[1]
            {
              message.Text
            });
          if (message.Type == TestImportMessagesType.Warning)
            this.AddWarnings((IEnumerable<string>) new string[1]
            {
              message.Text
            });
        }
      }

      /// <summary>
      /// Загрузить файл в сервис управления файлами импорта/экспорта
      /// </summary>
      /// <param name="importSettings">Настройки импорта</param>
      /// <param name="file">Файл</param>
      /// <returns>Локальное имя файла</returns>
      private string UploadFile(ConfigImportSettings importSettings, BinaryFile file)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              ((IExportImportFileService) this.fileService).DeleteFiles((string) ConfigurationUnpackService.ConfigurationUnpacker.f0tR9F8PGyvJymH49uQO((object) importSettings));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_4;
            default:
              ((IExportImportFileService) this.fileService).AddToFile((string) ConfigurationUnpackService.ConfigurationUnpacker.f0tR9F8PGyvJymH49uQO((object) importSettings), file);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 2 : 2;
              continue;
          }
        }
label_4:
        return (string) ConfigurationUnpackService.ConfigurationUnpacker.uGiOtG8PEJFFhepviIZm(this.fileService, ConfigurationUnpackService.ConfigurationUnpacker.f0tR9F8PGyvJymH49uQO((object) importSettings));
      }

      /// <summary>
      /// Проверить совместимость ограничений манифеста всех пакетов с текущей версией сервера
      /// </summary>
      /// <param name="items">Список данных компонентов</param>
      /// <param name="files">Список файлов компонентов</param>
      /// <param name="level">Уровень вложенности компонентов</param>
      private void ValidateTags(List<ValidateTreeItem> items, List<string> files, int level)
      {
        level++;
        if (level > 100)
          throw new NestingLevelException();
        items.ForEach((Action<ValidateTreeItem>) (item =>
        {
          int num1 = 12;
          while (true)
          {
            int num2 = num1;
            List<TestImportMessages> messages1;
            List<TestImportMessages>.Enumerator enumerator;
            while (true)
            {
              switch (num2)
              {
                case 1:
                  this.ValidateTags(item.Items, files, level);
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 2 : 2;
                  continue;
                case 2:
                  goto label_4;
                case 3:
label_40:
                  List<TestImportMessages> source = messages1;
                  // ISSUE: reference to a compiler-generated field
                  Func<TestImportMessages, bool> func1 = ConfigurationUnpackService.ConfigurationUnpacker.\u003C\u003Ec.\u003C\u003E9__22_2;
                  Func<TestImportMessages, bool> predicate;
                  if (func1 == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    ConfigurationUnpackService.ConfigurationUnpacker.\u003C\u003Ec.\u003C\u003E9__22_2 = predicate = (Func<TestImportMessages, bool>) (m => ConfigurationUnpackService.ConfigurationUnpacker.\u003C\u003Ec.ju7dsiZ2sTUDy4geJlIh((object) m) == TestImportMessagesType.Error);
                  }
                  else
                    goto label_23;
label_43:
                  if (!source.Any<TestImportMessages>(predicate))
                  {
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
                    continue;
                  }
                  goto label_35;
label_23:
                  predicate = func1;
                  goto label_43;
                case 4:
                  this.ValidateTags(item.Items, files, level);
                  num2 = 7;
                  continue;
                case 5:
                  enumerator = messages1.GetEnumerator();
                  num2 = 10;
                  continue;
                case 6:
                  // ISSUE: reference to a compiler-generated method
                  files.Add((string) ConfigurationUnpackService.ConfigurationUnpacker.\u003C\u003Ec__DisplayClass22_0.fENeG8ZeBLe6uwohQUCo((object) item));
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 1;
                  continue;
                case 7:
                  goto label_30;
                case 8:
                  goto label_36;
                case 9:
                  goto label_8;
                case 10:
                  try
                  {
label_13:
                    if (enumerator.MoveNext())
                      goto label_20;
                    else
                      goto label_14;
label_12:
                    TestImportMessages current;
                    TestImportMessagesType type;
                    int num3;
                    while (true)
                    {
                      switch (num3)
                      {
                        case 1:
                          // ISSUE: reference to a compiler-generated method
                          ((ILogger) this.logger).Error(ConfigurationUnpackService.ConfigurationUnpacker.\u003C\u003Ec__DisplayClass22_0.ILobHIZeWpY4gpUOnesj((object) current));
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 10 : 6;
                          continue;
                        case 2:
                        case 11:
                          // ISSUE: reference to a compiler-generated method
                          // ISSUE: reference to a compiler-generated method
                          ConfigurationUnpackService.ConfigurationUnpacker.\u003C\u003Ec__DisplayClass22_0.sf4QncZeoaDnidlLfGJj(this.logger, ConfigurationUnpackService.ConfigurationUnpacker.\u003C\u003Ec__DisplayClass22_0.ILobHIZeWpY4gpUOnesj((object) current));
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 4 : 1;
                          continue;
                        case 3:
                          if (type != TestImportMessagesType.Warning)
                          {
                            num3 = 9;
                            continue;
                          }
                          goto case 6;
                        case 4:
                        case 5:
                        case 10:
                          goto label_13;
                        case 6:
                          ((ILogger) this.logger).Warn((object) current.Text);
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 2 : 5;
                          continue;
                        case 7:
                          goto label_20;
                        case 8:
                          goto label_40;
                        case 9:
                          if (type != TestImportMessagesType.Error)
                          {
                            num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 9 : 11;
                            continue;
                          }
                          goto case 1;
                        default:
                          type = current.Type;
                          num3 = 3;
                          continue;
                      }
                    }
label_14:
                    num3 = 8;
                    goto label_12;
label_20:
                    current = enumerator.Current;
                    num3 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
                    {
                      num3 = 0;
                      goto label_12;
                    }
                    else
                      goto label_12;
                  }
                  finally
                  {
                    enumerator.Dispose();
                    int num4 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
                      num4 = 0;
                    switch (num4)
                    {
                      default:
                    }
                  }
                case 11:
                  if (!this.tagFilter)
                  {
                    num2 = 6;
                    continue;
                  }
                  ((ITagService) this.tagService).ValidateTags(item.Manifest, out messages1);
                  num2 = 8;
                  continue;
                case 12:
                  // ISSUE: reference to a compiler-generated method
                  if (!files.Contains((string) ConfigurationUnpackService.ConfigurationUnpacker.\u003C\u003Ec__DisplayClass22_0.fENeG8ZeBLe6uwohQUCo((object) item)))
                  {
                    num2 = 11;
                    continue;
                  }
                  goto label_37;
                case 13:
                  goto label_41;
                default:
                  // ISSUE: reference to a compiler-generated method
                  files.Add((string) ConfigurationUnpackService.ConfigurationUnpacker.\u003C\u003Ec__DisplayClass22_0.fENeG8ZeBLe6uwohQUCo((object) item));
                  num2 = 4;
                  continue;
              }
            }
label_36:
            List<TestImportMessages> testImportMessagesList = messages1;
            List<ValidateMessage> messages2 = item.Messages;
            // ISSUE: reference to a compiler-generated field
            Func<ValidateMessage, TestImportMessages> func2 = ConfigurationUnpackService.ConfigurationUnpacker.\u003C\u003Ec.\u003C\u003E9__22_1;
            Func<ValidateMessage, TestImportMessages> selector;
            if (func2 == null)
            {
              // ISSUE: reference to a compiler-generated field
              ConfigurationUnpackService.ConfigurationUnpacker.\u003C\u003Ec.\u003C\u003E9__22_1 = selector = (Func<ValidateMessage, TestImportMessages>) (m =>
              {
                int num5 = 3;
                ValidateMessageCode validateMessageCode;
                TestImportMessages testImportMessages;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      goto label_12;
                    case 2:
                      // ISSUE: reference to a compiler-generated method
                      validateMessageCode = ConfigurationUnpackService.ConfigurationUnpacker.\u003C\u003Ec.BTYPdCZ2jtuOZWBvqxQZ((object) m);
                      num5 = 9;
                      continue;
                    case 3:
                      testImportMessages = new TestImportMessages();
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 1 : 2;
                      continue;
                    case 4:
                    case 5:
                    case 6:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      ConfigurationUnpackService.ConfigurationUnpacker.\u003C\u003Ec.nvhoOIZ2UKfTSiUeFTCk((object) testImportMessages, ConfigurationUnpackService.ConfigurationUnpacker.\u003C\u003Ec.HJaca6Z2LLMgvPW17YLx((object) m));
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 1 : 1;
                      continue;
                    case 7:
                      // ISSUE: reference to a compiler-generated method
                      ConfigurationUnpackService.ConfigurationUnpacker.\u003C\u003Ec.vyTreCZ2YgkIl3bs7SYw((object) testImportMessages, TestImportMessagesType.InfoCommon);
                      num5 = 4;
                      continue;
                    case 8:
                      testImportMessages.Type = TestImportMessagesType.Warning;
                      num5 = 5;
                      continue;
                    case 9:
                      if (validateMessageCode != ValidateMessageCode.Warning)
                      {
                        num5 = 10;
                        continue;
                      }
                      goto case 8;
                    case 10:
                      if (validateMessageCode == ValidateMessageCode.Error)
                      {
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
                        continue;
                      }
                      goto case 7;
                    default:
                      // ISSUE: reference to a compiler-generated method
                      ConfigurationUnpackService.ConfigurationUnpacker.\u003C\u003Ec.vyTreCZ2YgkIl3bs7SYw((object) testImportMessages, TestImportMessagesType.Error);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 6 : 6;
                      continue;
                  }
                }
label_12:
                return testImportMessages;
              });
            }
            else
              goto label_45;
label_39:
            IEnumerable<TestImportMessages> collection = messages2.Select<ValidateMessage, TestImportMessages>(selector);
            testImportMessagesList.AddRange(collection);
            num1 = 5;
            continue;
label_45:
            selector = func2;
            goto label_39;
          }
label_4:
          return;
label_30:
          return;
label_8:
          return;
label_41:
          return;
label_37:
          return;
label_35:;
        }));
      }

      /// <summary>Получить описание компонентов</summary>
      private List<ElmaStoreComponentManifest> DownloadManifestsLocal()
      {
        List<ElmaStoreComponentManifest> manifests = new List<ElmaStoreComponentManifest>();
        List<string> files = new List<string>();
        foreach (string extractedFile in this.extractedFiles)
        {
          string tmpDirPath = ((ConfigurationUnpackService.ExportImportTempFolderTracer) this.tempFolderTracer).GetTempUniqueFolder(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606945222));
          ((IZipService) this.zipService).ExtractZipFolder(extractedFile, tmpDirPath);
          string[] array = ((IEnumerable<string>) Directory.GetFiles(tmpDirPath, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87120589))).Union<string>(((IEnumerable<string>) ElmaStoreComponentFile.SupportedManifestMask).SelectMany<string, string>((Func<string, IEnumerable<string>>) (mask => (IEnumerable<string>) Directory.GetFiles(tmpDirPath, mask)))).ToArray<string>();
          if (array.Length != 0)
            files.Add(((IEnumerable<string>) array).First<string>());
        }
        this.ParseComponentFiles(files, manifests);
        return manifests;
      }

      /// <summary>Читаем информацию о компоненте</summary>
      /// <param name="files">Список файлов</param>
      /// <param name="manifests">Список манифестов</param>
      private void ParseComponentFiles(
        List<string> files,
        List<ElmaStoreComponentManifest> manifests)
      {
        foreach (string file in files)
        {
          try
          {
            ElmaStoreComponentManifest componentManifest = ManifestBuilder.DeserializeByXmlFromFile<ElmaStoreComponentManifest>(file);
            manifests.Add(componentManifest);
          }
          catch (Exception ex)
          {
            Logger.Log.Error((object) ex.Message, ex);
          }
        }
      }

      /// <summary>Провалидировать компоненты</summary>
      /// <param name="components">Список компонентов</param>
      private void ValidateComponents(List<ElmaStoreComponentManifest> components)
      {
        List<string> warnings;
        List<string> errors;
        if (this.checkManifests && !ConfigurationUnpackService.ValidateComponents((IEnumerable<ElmaStoreComponentManifest>) components, ((IModuleDTOManager) this.moduleManager).GetInstalledComponentManifests(), out warnings, out errors))
        {
          this.AddErrors((IEnumerable<string>) errors);
          this.AddWarnings((IEnumerable<string>) warnings);
          throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1853130722)));
        }
      }

      /// <summary>Добавить ошибки в общий список</summary>
      /// <param name="errors">Список ошибок</param>
      private void AddErrors(IEnumerable<string> errors)
      {
        foreach (object error in errors)
          ((ILogger) this.logger).Error(error);
        this.allErrors.AddRange(errors);
      }

      /// <summary>Добавить предупреждения в общий список</summary>
      /// <param name="warnings">Список предупреждений</param>
      private void AddWarnings(IEnumerable<string> warnings)
      {
        foreach (object warning in warnings)
          ((ILogger) this.logger).Warn(warning);
        this.allWarnings.AddRange(warnings);
      }

      /// <summary>
      /// Добавить компоненты в результирующий список компонентов
      /// </summary>
      private void ExecuteLoadComponents()
      {
        int num1 = 6;
        IEnumerator<string> enumerator1;
        while (true)
        {
          int num2 = num1;
          int index;
          List<ElmaStoreComponentManifest>.Enumerator enumerator2;
          List<string> errors;
          while (true)
          {
            switch (num2)
            {
              case 1:
                List<ElmaStoreComponentManifest> list = this.loadedManifests.ToList<ElmaStoreComponentManifest>();
                index = 0;
                enumerator2 = list.GetEnumerator();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 7 : 7;
                continue;
              case 2:
                goto label_48;
              case 3:
                enumerator1 = this.localFiles.Values.Distinct<string>().GetEnumerator();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
                continue;
              case 4:
                goto label_53;
              case 5:
                if (this.DownloadComponentsLocal(out this.localFiles, out errors))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 1 : 1;
                  continue;
                }
                goto label_51;
              case 6:
                this.localFiles = new Dictionary<ElmaStoreComponentManifest, string>();
                num2 = 5;
                continue;
              case 7:
                try
                {
label_8:
                  if (enumerator2.MoveNext())
                    goto label_11;
                  else
                    goto label_9;
label_4:
                  int num3;
                  while (true)
                  {
                    ElmaStoreComponentManifest manifest;
                    ElmaStoreComponentManifest componentManifest;
                    switch (num3)
                    {
                      case 1:
                        goto label_50;
                      case 2:
                        goto label_5;
                      case 3:
                        componentManifest = enumerator2.Current;
                        num3 = 5;
                        continue;
                      case 4:
                        goto label_11;
                      case 5:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        if (this.localFiles.Keys.All<ElmaStoreComponentManifest>((Func<ElmaStoreComponentManifest, bool>) (f => ConfigurationUnpackService.ConfigurationUnpacker.\u003C\u003Ec__DisplayClass28_0.fSWgLUZeZpgW6p4q6FaE(ConfigurationUnpackService.ConfigurationUnpacker.\u003C\u003Ec__DisplayClass28_0.FUB7wsZe8wZqursVpEOr((object) f), ConfigurationUnpackService.ConfigurationUnpacker.\u003C\u003Ec__DisplayClass28_0.FUB7wsZe8wZqursVpEOr((object) componentManifest)))))
                        {
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 6 : 2;
                          continue;
                        }
                        break;
                      case 6:
                        manifest = ((IModuleDTOManager) this.moduleManager).GetManifest((string) ConfigurationUnpackService.ConfigurationUnpacker.smadog8PQJYgLDdEXeEV((object) componentManifest), out bool _);
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 9 : 9;
                        continue;
                      case 7:
                        this.loadedManifests[index] = manifest;
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 0 : 0;
                        continue;
                      case 8:
                      case 11:
                        this.AddErrors((IEnumerable<string>) new string[1]
                        {
                          EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138578364), ConfigurationUnpackService.ConfigurationUnpacker.rPMuNu8PCOstx1xsYHcQ((object) componentManifest), ConfigurationUnpackService.ConfigurationUnpacker.smadog8PQJYgLDdEXeEV((object) componentManifest))
                        });
                        num3 = 2;
                        continue;
                      case 9:
                        if (manifest == null)
                        {
                          num3 = 11;
                          continue;
                        }
                        goto case 7;
                      case 10:
                        goto label_8;
                    }
                    ++index;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 10 : 9;
                  }
label_5:
                  throw new InvalidOperationException((string) ConfigurationUnpackService.ConfigurationUnpacker.dNqKTg8PffEGoZHer2O0((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124346004)));
label_9:
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 1 : 1;
                  goto label_4;
label_11:
                  num3 = 3;
                  goto label_4;
                }
                finally
                {
                  enumerator2.Dispose();
                  int num4 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
                    num4 = 0;
                  switch (num4)
                  {
                    default:
                  }
                }
              case 8:
                goto label_51;
              case 9:
label_50:
                this.ValidateComponents(this.loadedManifests);
                num2 = 3;
                continue;
              default:
                goto label_24;
            }
          }
label_51:
          this.AddErrors((IEnumerable<string>) errors);
          num1 = 4;
        }
label_48:
        return;
label_24:
        try
        {
label_40:
          if (enumerator1.MoveNext())
            goto label_32;
          else
            goto label_41;
label_26:
          ConfigImportSettings importSettings;
          string current;
          int num5;
          while (true)
          {
            switch (num5)
            {
              case 1:
              case 5:
                ConfigurationUnpackService.ConfigurationUnpacker.MWMvBe8Pu6YYtXOYZoHb((object) importSettings, ConfigurationUnpackService.ConfigurationUnpacker.E6JkVj8PZUQrFnFj9nP1((object) current));
                num5 = 4;
                continue;
              case 2:
                ConfigurationUnpackService.ConfigurationUnpacker.RHytFc8PvjIQqSlXufo9((object) importSettings, ConfigurationUnpackService.ConfigurationUnpacker.f0tR9F8PGyvJymH49uQO(this.rootSettings));
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 1 : 0;
                continue;
              case 3:
                ConfigurationUnpackService.ConfigurationUnpacker.E78L4D8P8EHnARTlY69d((object) importSettings);
                num5 = 5;
                continue;
              case 4:
                ConfigurationUnpackService.ConfigurationUnpacker.IIu5if8PV2lYjbnvOhxX(ConfigurationUnpackService.ConfigurationUnpacker.xb2sfQ8PIGjK9jdPlQsm((object) importSettings), ConfigurationUnpackService.ConfigurationUnpacker.rPMuNu8PCOstx1xsYHcQ((object) importSettings.Manifest));
                num5 = 11;
                continue;
              case 6:
                this.allSettings.Add(importSettings);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 10 : 5;
                continue;
              case 7:
                importSettings = ClassSerializationHelper.CloneObject<ConfigImportSettings>((ConfigImportSettings) this.rootSettings);
                num5 = 9;
                continue;
              case 8:
                goto label_45;
              case 9:
                if (current == (string) this.rootLocalFile)
                {
                  num5 = 2;
                  continue;
                }
                goto case 3;
              case 10:
                goto label_40;
              case 11:
                if (ConfigurationUnpackService.ConfigurationUnpacker.reVpsQ8PSQD9RdsDAtIi((object) current, this.rootLocalFile))
                {
                  num5 = 12;
                  continue;
                }
                goto case 6;
              case 12:
                this.UploadFile(importSettings, new BinaryFile(current));
                num5 = 6;
                continue;
              default:
                goto label_32;
            }
          }
label_45:
          return;
label_32:
          current = enumerator1.Current;
          num5 = 7;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
          {
            num5 = 7;
            goto label_26;
          }
          else
            goto label_26;
label_41:
          num5 = 8;
          goto label_26;
        }
        finally
        {
          int num6;
          if (enumerator1 == null)
            num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
          else
            goto label_46;
label_44:
          switch (num6)
          {
            case 2:
              break;
            default:
          }
label_46:
          enumerator1.Dispose();
          num6 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
          {
            num6 = 1;
            goto label_44;
          }
          else
            goto label_44;
        }
label_53:
        throw new InvalidOperationException((string) ConfigurationUnpackService.ConfigurationUnpacker.dNqKTg8PffEGoZHer2O0((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1255365154 ^ 596875508 ^ -1766142900)));
      }

      /// <summary>Получить компоненты</summary>
      /// <param name="localFileNames">Список локальных файлов</param>
      /// <param name="errors">Список ошибок</param>
      private bool DownloadComponentsLocal(
        out Dictionary<ElmaStoreComponentManifest, string> localFileNames,
        out List<string> errors)
      {
        int num1 = 3;
        Dictionary<ElmaStoreComponentManifest, string> source;
        bool flag;
        List<ElmaStoreComponentManifest>.Enumerator enumerator1;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                source = new Dictionary<ElmaStoreComponentManifest, string>();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 4 : 0;
                continue;
              case 2:
                localFileNames = new Dictionary<ElmaStoreComponentManifest, string>();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 1 : 0;
                continue;
              case 3:
                goto label_44;
              case 4:
                try
                {
                  List<string>.Enumerator enumerator2 = this.extractedFiles.GetEnumerator();
                  int num3 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
                    num3 = 1;
                  switch (num3)
                  {
                    case 1:
                      try
                      {
label_15:
                        if (enumerator2.MoveNext())
                          goto label_13;
                        else
                          goto label_16;
label_7:
                        string current1;
                        ElmaStoreComponentManifest key1;
                        IEnumerator<ModuleVersion> enumerator3;
                        int num4;
                        while (true)
                        {
                          switch (num4)
                          {
                            case 1:
                            case 7:
                              goto label_15;
                            case 2:
                              source.Add(key1, current1);
                              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
                              continue;
                            case 3:
                              if (key1 == null)
                              {
                                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 1 : 1;
                                continue;
                              }
                              goto case 2;
                            case 4:
                              goto label_55;
                            case 5:
                              goto label_17;
                            case 6:
                              goto label_13;
                            case 8:
                              key1 = (ElmaStoreComponentManifest) ConfigurationUnpackService.ConfigurationUnpacker.E6JkVj8PZUQrFnFj9nP1((object) current1);
                              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 3;
                              continue;
                            default:
                              enumerator3 = ((IModuleMetadataExtractorService) this.moduleMetadataExtractorService).ExtractModules(current1).GetEnumerator();
                              num4 = 5;
                              continue;
                          }
                        }
label_17:
                        try
                        {
label_19:
                          if (ConfigurationUnpackService.ConfigurationUnpacker.zlQd9m8PKVhZxdWKYd12((object) enumerator3))
                            goto label_22;
                          else
                            goto label_20;
label_18:
                          ElmaStoreComponentManifest key2;
                          ModuleVersion current2;
                          int num5;
                          while (true)
                          {
                            switch (num5)
                            {
                              case 1:
                                goto label_19;
                              case 2:
                                goto label_22;
                              case 3:
                                goto label_15;
                              case 4:
                                source[key2] = current1;
                                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
                                continue;
                              case 5:
                                key2 = new ElmaStoreComponentManifest()
                                {
                                  Version = ConfigurationUnpackService.ConfigurationUnpacker.IPA1pt8PR2uMjeJZhEcB(ConfigurationUnpackService.ConfigurationUnpacker.oaUcEC8PiFxMkITkvSjV((object) current2)).ToString(),
                                  Id = ((NamedMetadata) ConfigurationUnpackService.ConfigurationUnpacker.US2UMR8PqpREKTRw8k8A((object) current2)).Name
                                };
                                num5 = 4;
                                continue;
                              default:
                                this.loadedManifests.Add(key2);
                                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 1;
                                continue;
                            }
                          }
label_20:
                          num5 = 3;
                          goto label_18;
label_22:
                          current2 = enumerator3.Current;
                          num5 = 5;
                          goto label_18;
                        }
                        finally
                        {
                          int num6;
                          if (enumerator3 == null)
                            num6 = 2;
                          else
                            goto label_28;
label_27:
                          switch (num6)
                          {
                            case 1:
                            case 2:
                          }
label_28:
                          ConfigurationUnpackService.ConfigurationUnpacker.JdnoAx8PXNq9Q5MGMRK3((object) enumerator3);
                          num6 = 1;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
                          {
                            num6 = 1;
                            goto label_27;
                          }
                          else
                            goto label_27;
                        }
label_13:
                        current1 = enumerator2.Current;
                        num4 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
                        {
                          num4 = 8;
                          goto label_7;
                        }
                        else
                          goto label_7;
label_16:
                        num4 = 4;
                        goto label_7;
                      }
                      finally
                      {
                        enumerator2.Dispose();
                        int num7 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0)
                          num7 = 0;
                        switch (num7)
                        {
                          default:
                        }
                      }
                    default:
                      goto label_55;
                  }
                }
                catch (Exception ex)
                {
                  int num8 = 3;
                  while (true)
                  {
                    switch (num8)
                    {
                      case 1:
                        goto label_41;
                      case 2:
                        flag = false;
                        num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 1;
                        continue;
                      case 3:
                        ((ILogger) ConfigurationUnpackService.ConfigurationUnpacker.pFtGmZ8PTa4CKTjRXeZr()).Error(ConfigurationUnpackService.ConfigurationUnpacker.mmTK708PkCgwhPRWX1SU((object) ex), ex);
                        num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
                        continue;
                      default:
                        errors.Add((string) ConfigurationUnpackService.ConfigurationUnpacker.mmTK708PkCgwhPRWX1SU((object) ex));
                        num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 2 : 2;
                        continue;
                    }
                  }
                }
              case 5:
label_55:
                enumerator1 = DeployUtils.SortComponentsByDependencies(source.Select<KeyValuePair<ElmaStoreComponentManifest, string>, ElmaStoreComponentManifest>((Func<KeyValuePair<ElmaStoreComponentManifest, string>, ElmaStoreComponentManifest>) (d => d.Key)).ToList<ElmaStoreComponentManifest>()).GetEnumerator();
                num2 = 6;
                continue;
              case 6:
                goto label_45;
              default:
                goto label_40;
            }
          }
label_44:
          errors = new List<string>();
          num1 = 2;
        }
label_40:
        return true;
label_41:
        return flag;
label_45:
        try
        {
label_49:
          if (enumerator1.MoveNext())
            goto label_48;
          else
            goto label_50;
label_46:
          ElmaStoreComponentManifest current;
          int num9;
          while (true)
          {
            switch (num9)
            {
              case 1:
                goto label_48;
              case 2:
                goto label_40;
              case 3:
                localFileNames.Add(current, source[current]);
                num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
                continue;
              default:
                goto label_49;
            }
          }
label_48:
          current = enumerator1.Current;
          num9 = 3;
          goto label_46;
label_50:
          num9 = 2;
          goto label_46;
        }
        finally
        {
          enumerator1.Dispose();
          int num10 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
            num10 = 0;
          switch (num10)
          {
            default:
          }
        }
      }

      internal static void uNU9RE8PhEyuGgw27T4t() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool TJM3dh8PotnXYKbbfXql() => ConfigurationUnpackService.ConfigurationUnpacker.zx8ius8PWoM3KRUAdSLy == null;

      internal static ConfigurationUnpackService.ConfigurationUnpacker F6iHcK8Pb2cNAgTK6hSl() => (ConfigurationUnpackService.ConfigurationUnpacker) ConfigurationUnpackService.ConfigurationUnpacker.zx8ius8PWoM3KRUAdSLy;

      internal static object f0tR9F8PGyvJymH49uQO([In] object obj0) => (object) ((ConfigImportSettings) obj0).FileName;

      internal static object uGiOtG8PEJFFhepviIZm([In] object obj0, [In] object obj1) => (object) ((IExportImportFileService) obj0).CreateZipFileName((string) obj1);

      internal static object dNqKTg8PffEGoZHer2O0([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

      internal static object smadog8PQJYgLDdEXeEV([In] object obj0) => (object) ((ElmaStoreComponentManifest) obj0).Id;

      internal static object rPMuNu8PCOstx1xsYHcQ([In] object obj0) => (object) ((ElmaStoreComponentManifest) obj0).Title;

      internal static void RHytFc8PvjIQqSlXufo9([In] object obj0, [In] object obj1) => ((ConfigImportSettings) obj0).FileName = (string) obj1;

      internal static void E78L4D8P8EHnARTlY69d([In] object obj0) => ((ConfigImportSettings) obj0).CreateFileName();

      internal static object E6JkVj8PZUQrFnFj9nP1([In] object obj0) => (object) ElmaStoreComponentsBuilder.Read((string) obj0);

      internal static void MWMvBe8Pu6YYtXOYZoHb([In] object obj0, [In] object obj1) => ((ConfigImportSettings) obj0).Manifest = (ElmaStoreComponentManifest) obj1;

      internal static object xb2sfQ8PIGjK9jdPlQsm([In] object obj0) => (object) ((ConfigImportSettings) obj0).FakeManifest;

      internal static void IIu5if8PV2lYjbnvOhxX([In] object obj0, [In] object obj1) => ((BPMAppFakeManifest) obj0).DisplayName = (string) obj1;

      internal static bool reVpsQ8PSQD9RdsDAtIi([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

      internal static object oaUcEC8PiFxMkITkvSjV([In] object obj0) => (object) ((ModuleVersion) obj0).Header;

      internal static object IPA1pt8PR2uMjeJZhEcB([In] object obj0) => (object) ((ModuleVersionHeader) obj0).Version;

      internal static object US2UMR8PqpREKTRw8k8A([In] object obj0) => (object) ((ModuleVersion) obj0).Metadata;

      internal static bool zlQd9m8PKVhZxdWKYd12([In] object obj0) => ((IEnumerator) obj0).MoveNext();

      internal static void JdnoAx8PXNq9Q5MGMRK3([In] object obj0) => ((IDisposable) obj0).Dispose();

      internal static object pFtGmZ8PTa4CKTjRXeZr() => (object) Logger.Log;

      internal static object mmTK708PkCgwhPRWX1SU([In] object obj0) => (object) ((Exception) obj0).Message;
    }
  }
}
