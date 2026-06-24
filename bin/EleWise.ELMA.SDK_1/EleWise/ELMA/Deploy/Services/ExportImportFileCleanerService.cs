// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Services.ExportImportFileCleanerService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Actors;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Runtime.Managers;
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
  /// <summary>
  /// Класс выполняет очистку директории для экспорта/импорта конфигураций
  /// Вызывается планировщиком и из класса ExportImportFileService
  /// </summary>
  [Service(Type = ComponentType.Server)]
  internal class ExportImportFileCleanerService : IExportImportFileCleanerService
  {
    /// <summary>Период хранения файлов. По умолчанию 2 дня</summary>
    private static readonly TimeSpan defaultStoreDuration;
    private string exportImportFilesDirectory;
    /// <summary>Шаблон для генерации ключей в BLOBStore</summary>
    private static readonly string BLOBStoreKeyTemplate;
    /// <summary>Хранилище бинарных данных</summary>
    private readonly IBLOBStore blobStore;
    private static ExportImportFileCleanerService eWHTsLE6bG8Mrj0OPsmo;

    /// <summary>Ctor</summary>
    /// <param name="exportImportFileService">Сервис передачи файлов экспорта-импорта</param>
    /// <param name="BLOBStore">Хранилище бинарных данных</param>
    public ExportImportFileCleanerService(
      IExportImportFileService exportImportFileService,
      IBLOBStore BLOBStore)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.exportImportFilesDirectory = "";
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            ExportImportFileCleanerService.m1airjE6vB1kLZ0aGMHL(ExportImportFileCleanerService.vAednlE6QIVbkCpok1Iy(), ExportImportFileCleanerService.QK952kE6CDRiI41ot8rd(-1921202237 ^ -1921495781));
            num = 2;
            continue;
          case 2:
            goto label_5;
          case 3:
            if (!ExportImportFileCleanerService.LjCuM0E6fIJj7mjh3uRs((object) this.exportImportFilesDirectory))
            {
              num = 5;
              continue;
            }
            goto case 1;
          case 4:
            this.exportImportFilesDirectory = (string) ExportImportFileCleanerService.OnjgKEE6EIMZaqqxpw2A((object) exportImportFileService);
            num = 3;
            continue;
          case 5:
            goto label_3;
          default:
            this.blobStore = BLOBStore;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 2 : 4;
            continue;
        }
      }
label_3:
      return;
label_5:
      throw new ArgumentException((string) ExportImportFileCleanerService.pL6km3E68xDTpqgYQpLm(ExportImportFileCleanerService.QK952kE6CDRiI41ot8rd(-70007027 ^ -69776301)));
    }

    /// <summary>Запуск очистки файлов</summary>
    public void Execute()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Execute(ExportImportFileCleanerService.defaultStoreDuration);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Запуск очистки файлов</summary>
    /// <param name="storeDuration">Время хранения файлов на диске</param>
    public void Execute(TimeSpan storeDuration)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.CleanFiles(this.exportImportFilesDirectory, storeDuration);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Очистка данных по импорту конфигураций</summary>
    /// <param name="exportImportDirectory">Директория с файлами</param>
    /// <param name="storeDuration">Время хранения файлов на диске</param>
    private void CleanFiles(string exportImportDirectory, TimeSpan storeDuration)
    {
      int num1 = 5;
      IEnumerator<string> enumerator;
      DateTime dateToDeleted;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_7;
          case 2:
            goto label_24;
          case 3:
            enumerator = this.GetConfigurationFiles(exportImportDirectory).GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 1 : 1;
            continue;
          case 4:
            if (Directory.Exists(exportImportDirectory))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 0 : 0;
              continue;
            }
            goto label_9;
          case 5:
            if (!string.IsNullOrWhiteSpace(exportImportDirectory))
            {
              num1 = 4;
              continue;
            }
            goto label_19;
          default:
            dateToDeleted = ExportImportFileCleanerService.kHYQjhE6uWQS3jnSrJOw(ExportImportFileCleanerService.fZ4xw2E6Z78JACHaiUQp(), storeDuration);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 3 : 0;
            continue;
        }
      }
label_24:
      return;
label_19:
      return;
label_7:
      try
      {
label_15:
        if (ExportImportFileCleanerService.xPGOceE6IywMmg1XwEq0((object) enumerator))
          goto label_11;
        else
          goto label_16;
label_8:
        string current;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_2;
            case 2:
              goto label_15;
            case 3:
              this.DeleteDirectory(this.GetDirectoryName(exportImportDirectory, current));
              num2 = 4;
              continue;
            case 4:
              this.DeleteBLOBStoreConfigurationData(this.GetBLOBStoreKey(current));
              num2 = 5;
              continue;
            case 5:
              this.DeleteFiles(current);
              num2 = 2;
              continue;
            case 6:
              goto label_11;
            default:
              if (this.IsNeedDelete(current, dateToDeleted))
              {
                num2 = 3;
                continue;
              }
              goto label_15;
          }
        }
label_2:
        return;
label_11:
        current = enumerator.Current;
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
        {
          num2 = 0;
          goto label_8;
        }
        else
          goto label_8;
label_16:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 1 : 1;
        goto label_8;
      }
      finally
      {
        if (enumerator != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_26;
              default:
                ExportImportFileCleanerService.NqNIk0E6VUdh2OianPr3((object) enumerator);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 1 : 0;
                continue;
            }
          }
        }
label_26:;
      }
label_9:;
    }

    private bool IsNeedDelete(string fullName, DateTime dateToDeleted)
    {
      int num = 1;
      FileInfo fileInfo;
      while (true)
      {
        switch (num)
        {
          case 1:
            fileInfo = new FileInfo(fullName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_5;
          default:
            if (fileInfo.Exists)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 2 : 0;
              continue;
            }
            goto label_6;
        }
      }
label_5:
      return ExportImportFileCleanerService.jSQyjoE6i2wlHOasJwZY(ExportImportFileCleanerService.IUqdxuE6SnBGnTA43R4M((object) fileInfo), dateToDeleted);
label_6:
      return false;
    }

    /// <summary>
    /// Формируем ключ в BLOBStore, по которому будем искать данные
    /// </summary>
    /// <param name="fullFileName">Имя файла конфигурации</param>
    private string GetBLOBStoreKey(string fullFileName) => (string) ExportImportFileCleanerService.LER4JiE6qWVSn8sruNbm((object) ExportImportFileCleanerService.BLOBStoreKeyTemplate, ExportImportFileCleanerService.r9LI6fE6RDduKF0jXLV0((object) fullFileName));

    /// <summary>Удаление информации из BLOBStore</summary>
    /// <param name="storeKey">Ключ</param>
    private void DeleteBLOBStoreConfigurationData(string storeKey)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ExportImportFileCleanerService.jRuM9LE6KVqeSrOIXEtU((object) this.blobStore, (object) storeKey);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    private IEnumerable<string> GetConfigurationFiles(string exportImportDirectory)
    {
      IEnumerable<string> files = (IEnumerable<string>) Directory.GetFiles(exportImportDirectory, z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-122002947 ^ 121705952), SearchOption.TopDirectoryOnly);
      foreach (string searchPattern in ElmaStoreComponentFile.SupportedComponentMask)
        files.Concat<string>((IEnumerable<string>) Directory.GetFiles(exportImportDirectory, searchPattern, SearchOption.TopDirectoryOnly));
      return files;
    }

    /// <summary>Удаляем файл</summary>
    /// <param name="fullFileName">Полный путь к удаляемому файлу</param>
    private void DeleteFiles(string fullFileName)
    {
      int num1 = 1;
      FileInfo fileInfo;
      while (true)
      {
        switch (num1)
        {
          case 1:
            fileInfo = new FileInfo(fullFileName);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_15;
          default:
            goto label_3;
        }
      }
label_15:
      return;
label_3:
      try
      {
        ((ILogger) ExportImportFileCleanerService.vAednlE6QIVbkCpok1Iy()).InfoFormat((string) ExportImportFileCleanerService.QK952kE6CDRiI41ot8rd(-649342099 - -1150814748 ^ 501397823), (object) fullFileName);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_12;
            default:
              ExportImportFileCleanerService.B8pmJWE6XVFVJkU9htFK((object) fileInfo);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 1;
              continue;
          }
        }
label_12:;
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_8;
            case 2:
              ((ILogger) ExportImportFileCleanerService.vAednlE6QIVbkCpok1Iy()).Warn(ex, EleWise.ELMA.SR.T((string) ExportImportFileCleanerService.QK952kE6CDRiI41ot8rd(-16752921 ^ -16461105), (object) fullFileName));
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 1 : 1;
              continue;
            default:
              ExportImportFileCleanerService.m1airjE6vB1kLZ0aGMHL(ExportImportFileCleanerService.vAednlE6QIVbkCpok1Iy(), ExportImportFileCleanerService.pL6km3E68xDTpqgYQpLm(ExportImportFileCleanerService.QK952kE6CDRiI41ot8rd(647913418 ^ 647681086)));
              num3 = 2;
              continue;
          }
        }
label_8:;
      }
    }

    /// <summary>Формируем имя директории по имени файла конфигурации</summary>
    /// <param name="exportImportDirectory">Директория для хранения файлов</param>
    /// <param name="fullFileName">Имя файла</param>
    /// <returns>Имя директории, соответствующей файлу</returns>
    private string GetDirectoryName(string exportImportDirectory, string fullFileName) => Path.Combine(exportImportDirectory, Path.GetFileNameWithoutExtension(fullFileName));

    /// <summary>Удаление директории</summary>
    /// <param name="directoryName">Имя директории</param>
    private void DeleteDirectory(string directoryName)
    {
      int num1 = 1;
      DirectoryInfo directoryInfo;
      while (true)
      {
        switch (num1)
        {
          case 1:
            directoryInfo = new DirectoryInfo(directoryName);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_18;
          default:
            goto label_3;
        }
      }
label_18:
      return;
label_3:
      try
      {
        Logger.Log.InfoFormat((string) ExportImportFileCleanerService.QK952kE6CDRiI41ot8rd(323422137 << 2 ^ 1293456000), (object) directoryName);
        int num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (ExportImportFileCleanerService.Q3QPWxE6TMmmrVFmKIaq((object) directoryInfo))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
                continue;
              }
              goto label_11;
            case 2:
              goto label_15;
            default:
              ExportImportFileCleanerService.HH5E54E6kV907QgAiD3e((object) directoryInfo, true);
              num2 = 2;
              continue;
          }
        }
label_15:
        return;
label_11:;
      }
      catch (Exception ex)
      {
        int num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
          num3 = 1;
        while (true)
        {
          switch (num3)
          {
            case 1:
              ExportImportFileCleanerService.m1airjE6vB1kLZ0aGMHL(ExportImportFileCleanerService.vAednlE6QIVbkCpok1Iy(), (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951220878)));
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_7;
            default:
              Logger.Log.Warn(ex, EleWise.ELMA.SR.T((string) ExportImportFileCleanerService.QK952kE6CDRiI41ot8rd(222162814 ^ 221864874), (object) directoryName));
              num3 = 2;
              continue;
          }
        }
label_7:;
      }
    }

    static ExportImportFileCleanerService()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ExportImportFileCleanerService.wc6Z1kE6npWo5YYsPfsF();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
            continue;
          case 2:
            ExportImportFileCleanerService.BLOBStoreKeyTemplate = (string) ExportImportFileCleanerService.DRD6SvE6OKb9C4iuxoqX((object) ConfigurationTestActor.TestDataKey, ExportImportFileCleanerService.QK952kE6CDRiI41ot8rd(-680446928 - -370807692 ^ -309656522));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 3 : 3;
            continue;
          case 3:
            goto label_2;
          default:
            ExportImportFileCleanerService.defaultStoreDuration = TimeSpan.FromDays(2.0);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object OnjgKEE6EIMZaqqxpw2A([In] object obj0) => (object) ((IExportImportFileService) obj0).GetFilesFolderPath();

    internal static bool LjCuM0E6fIJj7mjh3uRs([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object vAednlE6QIVbkCpok1Iy() => (object) Logger.Log;

    internal static object QK952kE6CDRiI41ot8rd(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void m1airjE6vB1kLZ0aGMHL([In] object obj0, [In] object obj1) => ((ILogger) obj0).Error(obj1);

    internal static object pL6km3E68xDTpqgYQpLm([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool apbsm2E6hJN9kHpclAV3() => ExportImportFileCleanerService.eWHTsLE6bG8Mrj0OPsmo == null;

    internal static ExportImportFileCleanerService hmUNONE6GQxvRjx8sqmK() => ExportImportFileCleanerService.eWHTsLE6bG8Mrj0OPsmo;

    internal static DateTime fZ4xw2E6Z78JACHaiUQp() => DateTime.Now;

    internal static DateTime kHYQjhE6uWQS3jnSrJOw([In] DateTime obj0, [In] TimeSpan obj1) => obj0 - obj1;

    internal static bool xPGOceE6IywMmg1XwEq0([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void NqNIk0E6VUdh2OianPr3([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static DateTime IUqdxuE6SnBGnTA43R4M([In] object obj0) => ((FileSystemInfo) obj0).LastWriteTime;

    internal static bool jSQyjoE6i2wlHOasJwZY([In] DateTime obj0, [In] DateTime obj1) => obj0 < obj1;

    internal static object r9LI6fE6RDduKF0jXLV0([In] object obj0) => (object) Path.GetFileNameWithoutExtension((string) obj0);

    internal static object LER4JiE6qWVSn8sruNbm([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static void jRuM9LE6KVqeSrOIXEtU([In] object obj0, [In] object obj1) => ((IBLOBStore) obj0).Remove((string) obj1);

    internal static void B8pmJWE6XVFVJkU9htFK([In] object obj0) => ((FileSystemInfo) obj0).Delete();

    internal static bool Q3QPWxE6TMmmrVFmKIaq([In] object obj0) => ((FileSystemInfo) obj0).Exists;

    internal static void HH5E54E6kV907QgAiD3e([In] object obj0, [In] bool obj1) => ((DirectoryInfo) obj0).Delete(obj1);

    internal static void wc6Z1kE6npWo5YYsPfsF() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object DRD6SvE6OKb9C4iuxoqX([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);
  }
}
