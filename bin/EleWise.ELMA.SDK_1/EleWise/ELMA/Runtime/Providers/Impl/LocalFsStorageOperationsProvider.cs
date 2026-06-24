// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Providers.Impl.LocalFsStorageOperationsProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Runtime.Providers.Impl
{
  /// <summary>
  /// Реализация провайдера операций для хранилища файлов на локальной файловой системе.
  /// </summary>
  internal class LocalFsStorageOperationsProvider : IStorageOperationsProvider
  {
    private readonly ILogger logger;
    private readonly ILocationSchema locationSchema;
    private static LocalFsStorageOperationsProvider Jl3V1sWfU9h0YHy9BU56;

    /// <summary>Ctor</summary>
    /// <param name="logger">Логгер.</param>
    /// <param name="locationSchema">Схема ссылок на местоположения.</param>
    public LocalFsStorageOperationsProvider(ILogger logger, ILocationSchema locationSchema)
    {
      LocalFsStorageOperationsProvider.htk39nWfzQXlVC86FrPl();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.locationSchema = locationSchema;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 1 : 1;
            continue;
          default:
            this.logger = logger;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>
    /// Получить ссылку на местоположение первоисточника контента.
    /// </summary>
    /// <param name="systemFile"></param>
    /// <returns></returns>
    public Uri GetSourceContentLocation(SystemFile systemFile) => (Uri) LocalFsStorageOperationsProvider.JkXKXaWQFNmPyDUglE9o((object) this.locationSchema, (object) systemFile);

    /// <summary>
    /// Разместить указанный файл на ближайшей точке хранения (скопирует с источника контента).
    /// </summary>
    /// <param name="systemFile">Метаданные постоянно хранимого файла.</param>
    public void FetchContent(SystemFile systemFile)
    {
    }

    /// <summary>
    /// Разместить указанный файл на ближайшей точке хранения асинхронно (скопирует с источника контента).
    /// </summary>
    /// <param name="systemFile">Метаданные постоянно хранимого файла.</param>
    /// <param name="token">Токен отмены.</param>
    /// <returns>Задачу, которая представляет собой работу по размещению файла (копирование из источника на ближайшую точку).</returns>
    public Task FetchContentAsync(SystemFile systemFile, CancellationToken token) => CompletedTask.Default;

    /// <summary>Расшифровать контент.</summary>
    /// <param name="systemFile">Метаданные постоянно хранимого контента.</param>
    /// <param name="password">Пароль.</param>
    /// <returns>Сведения о расшифрованном контенте.</returns>
    public BinaryFileContentInfo DecryptContent(SystemFile systemFile, string password)
    {
      int num = 2;
      Uri location;
      string fileName;
      Uri uri;
      Guid guid;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.ValidateContent(location, (string) LocalFsStorageOperationsProvider.q5QX0gWQBfFFgMaDcoj9((object) systemFile));
            num = 5;
            continue;
          case 2:
            location = (Uri) LocalFsStorageOperationsProvider.JkXKXaWQFNmPyDUglE9o((object) this.locationSchema, (object) systemFile);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 1 : 1;
            continue;
          case 3:
            fileName = (string) LocalFsStorageOperationsProvider.zaqd8TWQfummUFplwpA6((object) uri);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 4 : 0;
            continue;
          case 4:
            LocalFsStorageOperationsProvider.hsmTOqWQCIicD2jmHIfp((object) location.LocalPath, (object) fileName, LocalFsStorageOperationsProvider.w4IkjxWQQ261bRjWYBFu((object) systemFile), (object) password);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 0 : 0;
            continue;
          case 5:
            guid = LocalFsStorageOperationsProvider.pYim0sWQW8kn01CnTqA5();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 2 : 6;
            continue;
          case 6:
            uri = (Uri) LocalFsStorageOperationsProvider.eHmSanWQEtc86D51rqVc((object) this.locationSchema, (object) guid.ToString((string) LocalFsStorageOperationsProvider.BPulnsWQoNb2kpkZOTao(-218496594 ^ -218467936)), LocalFsStorageOperationsProvider.tOGJ1xWQGOXsLbHOdctB(LocalFsStorageOperationsProvider.JTxGXMWQhguhC6AX4aAP(LocalFsStorageOperationsProvider.HGOC8kWQbTBmwkb1pJy2((object) systemFile))));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 2 : 3;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      BinaryFileContentInfo binaryFileContentInfo = new BinaryFileContentInfo();
      LocalFsStorageOperationsProvider.oasiL0WQvXh8sRxX27GN((object) binaryFileContentInfo, (object) uri);
      LocalFsStorageOperationsProvider.xDEEJYWQZDTBO9jesloQ((object) binaryFileContentInfo, LocalFsStorageOperationsProvider.cNthweWQ8RZ3xiKTfQb5((object) new FileInfo(fileName)));
      LocalFsStorageOperationsProvider.DvVkiOWQIFx4JAsU8PtM((object) binaryFileContentInfo, LocalFsStorageOperationsProvider.UUgk17WQuQyTN3Gvegh3((object) fileName));
      return binaryFileContentInfo;
    }

    /// <summary>Зашифровать контент.</summary>
    /// <param name="systemFile">Метаданные постоянно хранимого контента.</param>
    /// <param name="password">Пароль.</param>
    /// <returns>Сведения о зашифрованном контенте.</returns>
    public BinaryFileContentInfo EncryptContent(SystemFile systemFile, string password)
    {
      int num = 4;
      Uri location;
      string fileName;
      Uri uri;
      Guid guid;
      while (true)
      {
        switch (num)
        {
          case 1:
            guid = Guid.NewGuid();
            num = 2;
            continue;
          case 2:
            uri = (Uri) LocalFsStorageOperationsProvider.eHmSanWQEtc86D51rqVc((object) this.locationSchema, (object) guid.ToString((string) LocalFsStorageOperationsProvider.BPulnsWQoNb2kpkZOTao(874012245 ^ 873999963)), LocalFsStorageOperationsProvider.tOGJ1xWQGOXsLbHOdctB(LocalFsStorageOperationsProvider.JTxGXMWQhguhC6AX4aAP(LocalFsStorageOperationsProvider.HGOC8kWQbTBmwkb1pJy2((object) systemFile))));
            num = 6;
            continue;
          case 3:
            this.ValidateContent(location, (string) LocalFsStorageOperationsProvider.q5QX0gWQBfFFgMaDcoj9((object) systemFile));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 1 : 1;
            continue;
          case 4:
            location = (Uri) LocalFsStorageOperationsProvider.JkXKXaWQFNmPyDUglE9o((object) this.locationSchema, (object) systemFile);
            num = 3;
            continue;
          case 5:
            goto label_4;
          case 6:
            fileName = (string) LocalFsStorageOperationsProvider.zaqd8TWQfummUFplwpA6((object) uri);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
            continue;
          default:
            LocalFsStorageOperationsProvider.oplrejWQVmtyd9CflQlu(LocalFsStorageOperationsProvider.zaqd8TWQfummUFplwpA6((object) location), (object) fileName, LocalFsStorageOperationsProvider.w4IkjxWQQ261bRjWYBFu((object) systemFile), (object) password);
            num = 5;
            continue;
        }
      }
label_4:
      BinaryFileContentInfo binaryFileContentInfo = new BinaryFileContentInfo();
      LocalFsStorageOperationsProvider.oasiL0WQvXh8sRxX27GN((object) binaryFileContentInfo, (object) uri);
      LocalFsStorageOperationsProvider.xDEEJYWQZDTBO9jesloQ((object) binaryFileContentInfo, LocalFsStorageOperationsProvider.cNthweWQ8RZ3xiKTfQb5((object) new FileInfo(fileName)));
      LocalFsStorageOperationsProvider.DvVkiOWQIFx4JAsU8PtM((object) binaryFileContentInfo, LocalFsStorageOperationsProvider.UUgk17WQuQyTN3Gvegh3((object) fileName));
      return binaryFileContentInfo;
    }

    /// <summary>Получить размер контента.</summary>
    /// <param name="systemFile">Метаданные постоянно храняимого контента.</param>
    /// <returns>Размер контента, либо null, если контент не существует.</returns>
    public long? GetContentSize(SystemFile systemFile)
    {
      FileInfo fileInfo = new FileInfo(this.locationSchema.MapPersistentLocation(systemFile).LocalPath);
      return !fileInfo.Exists ? new long?() : new long?(fileInfo.Length);
    }

    /// <summary>Открыть поток записи с требуемыми характеристиками.</summary>
    /// <param name="contentInfoHandler">Действие, обрабатывающее сведения о записываемом контенте.</param>
    /// <param name="options">Требуемые характеристики потока.</param>
    /// <returns>Поток.</returns>
    /// <remarks>
    /// При открытии потока на запись внутренний код или удалённая сторона решает, каким будет имя временного файла.
    /// Это имя может быть известно не сразу при открытии потока.
    /// Отсюда и использование делегата contentInfoHandler, роль которого - передать сведения о временном файле вызывающему коду.
    /// </remarks>
    public Stream OpenTempContentWriteStream(
      Action<Uri> contentInfoHandler,
      PutContentOptions options)
    {
      Contract.ArgumentNotNull((object) options, z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-306453669 ^ 306559622));
      Uri newTempLocation = this.locationSchema.CreateNewTempLocation(options.Extension);
      contentInfoHandler(newTempLocation);
      string localPath = newTempLocation.LocalPath;
      if (File.Exists(localPath))
        File.Delete(localPath);
      return this.OpenWriteFileStream(localPath, options.ForAsync);
    }

    /// <summary>
    /// Открыть поток чтения для постоянно хранимого файла с требуемыми характеристиками.
    /// </summary>
    /// <param name="systemFile">Метаданные постоянно хранимого файла.</param>
    /// <param name="options">Требуемые характеристики потока.</param>
    /// <returns>Поток.</returns>
    public Stream OpenPersistentContentReadStream(SystemFile systemFile, GetContentOptions options)
    {
      int num = 1;
      Uri location;
      while (true)
      {
        switch (num)
        {
          case 1:
            location = (Uri) LocalFsStorageOperationsProvider.JkXKXaWQFNmPyDUglE9o((object) this.locationSchema, (object) systemFile);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          default:
            this.ValidateContent(location, (string) LocalFsStorageOperationsProvider.q5QX0gWQBfFFgMaDcoj9((object) systemFile));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 2 : 0;
            continue;
        }
      }
label_4:
      return this.OpenReadFileStream((string) LocalFsStorageOperationsProvider.zaqd8TWQfummUFplwpA6((object) location), options.ForAsync);
    }

    /// <summary>
    /// Открыть поток чтения для временного файла с требуемыми характеристиками.
    /// </summary>
    /// <param name="contentLocation">Местоположение временного файла.</param>
    /// <param name="options">Требуемые характеристики потока.</param>
    /// <returns>Поток.</returns>
    public Stream OpenTempContentReadStream(Uri contentLocation, GetContentOptions options) => this.OpenReadFileStream(contentLocation.LocalPath, LocalFsStorageOperationsProvider.IDmOV4WQSMlgbXcfrOuL((object) options));

    /// <summary>
    /// Сохранить контент (переместить в папку постоянного хранения).
    /// </summary>
    /// <param name="srcLocation">Исходное местоположение контента.</param>
    /// <param name="systemFile">Метаданные сохраняемого контента.</param>
    /// <param name="deleteSourceAfterSave">Удалять ли исходный контент после его сохранения в папке постоянного хранения?</param>
    /// <returns>Местоположение сохранённого контента.</returns>
    public Uri SaveContent(Uri srcLocation, SystemFile systemFile, bool deleteSourceAfterSave = false)
    {
      int num1 = 6;
      string localPath;
      string str;
      Uri uri;
      while (true)
      {
        switch (num1)
        {
          case 1:
            str = (string) LocalFsStorageOperationsProvider.zaqd8TWQfummUFplwpA6((object) uri);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 4 : 4;
            continue;
          case 3:
            if (!LocalFsStorageOperationsProvider.oQFAtMWQRAJaJWNdhsIR((object) localPath))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
              continue;
            }
            goto case 8;
          case 4:
            if (!LocalFsStorageOperationsProvider.r91FSWWQiSZC7PwGdmmW((object) srcLocation, (object) uri))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 6 : 7;
              continue;
            }
            goto case 3;
          case 5:
            localPath = srcLocation.LocalPath;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 1 : 1;
            continue;
          case 6:
            uri = (Uri) LocalFsStorageOperationsProvider.JkXKXaWQFNmPyDUglE9o((object) this.locationSchema, (object) systemFile);
            num1 = 5;
            continue;
          case 8:
            this.logger.InfoFormat((string) LocalFsStorageOperationsProvider.BPulnsWQoNb2kpkZOTao(1218962250 ^ 1218856318), (object) srcLocation, (object) uri);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 10 : 7;
            continue;
          case 9:
            goto label_14;
          case 10:
            LocalFsStorageOperationsProvider.SxPG5sWQqZT8m3pKfI5y((object) localPath, (object) str, true);
            num1 = 11;
            continue;
          case 11:
            if (deleteSourceAfterSave)
            {
              num1 = 9;
              continue;
            }
            goto label_11;
          default:
            goto label_11;
        }
      }
label_11:
      return uri;
label_14:
      try
      {
        this.logger.InfoFormat((string) LocalFsStorageOperationsProvider.BPulnsWQoNb2kpkZOTao(1994213607 >> 4 ^ 124547810), (object) srcLocation);
        int num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
          num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              LocalFsStorageOperationsProvider.MiTkhNWQKawBmIcmChEX((object) localPath);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
              continue;
            default:
              goto label_11;
          }
        }
      }
      catch (Exception ex)
      {
        int num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              this.logger.Error(LocalFsStorageOperationsProvider.bI9ugJWQXIsakqC6vsmo((object) ex), ex);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 0 : 0;
              continue;
            default:
              goto label_11;
          }
        }
      }
    }

    /// <summary>
    /// Вычислить хеш по указанному алгоритму у постоянно хранимого файла.
    /// </summary>
    /// <param name="systemFile">Метаданные постоянно хранимого файла.</param>
    /// <param name="hashAlgorithm">Алгоритм хеширования.</param>
    /// <returns>Хеш.</returns>
    public string GetContentHash(SystemFile systemFile, HashAlogrithmEnum hashAlgorithm)
    {
      int num1 = 1;
      Stream stream;
      while (true)
      {
        switch (num1)
        {
          case 1:
            stream = this.OpenPersistentContentReadStream(systemFile, GetContentOptions.NonSeekable);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      string contentHash;
      return contentHash;
label_3:
      try
      {
        contentHash = (string) LocalFsStorageOperationsProvider.YwPj8CWQTKl6JGBNaxa8((object) stream);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0)
          num2 = 0;
        switch (num2)
        {
          default:
            goto label_2;
        }
      }
      finally
      {
        int num3;
        if (stream == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 1 : 1;
        else
          goto label_10;
label_9:
        switch (num3)
        {
          case 1:
          case 2:
        }
label_10:
        LocalFsStorageOperationsProvider.RDZLgMWQkaRp7XKiatOw((object) stream);
        num3 = 2;
        goto label_9;
      }
    }

    /// <summary>
    /// Вычислить хеш по указанному алгоритму у постоянно хранимого файла.
    /// </summary>
    /// <param name="systemFile">Метаданные постоянно хранимого файла.</param>
    /// <param name="hashAlgorithm">Алгоритм хеширования.</param>
    /// <param name="token">Токен отмены.</param>
    /// <returns>Задачу, представляющую собой работу по вычислению хеша.</returns>
    public Task<string> GetContentHashAsync(
      SystemFile systemFile,
      HashAlogrithmEnum hashAlgorithm,
      CancellationToken token)
    {
      return Task.Factory.StartNew<string>((Func<string>) (() => this.GetContentHash(systemFile, hashAlgorithm)), token, TaskCreationOptions.LongRunning, TaskScheduler.Current);
    }

    private void ValidateContent(Uri location, string crcStr)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            uint result;
            if (!uint.TryParse(crcStr, out result))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 0;
              continue;
            }
            if ((int) LocalFsStorageOperationsProvider.UUgk17WQuQyTN3Gvegh3(LocalFsStorageOperationsProvider.zaqd8TWQfummUFplwpA6((object) location)) != (int) result)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 2 : 1;
              continue;
            }
            goto label_2;
          case 2:
            goto label_3;
          default:
            goto label_6;
        }
      }
label_3:
      throw new InvalidDataException(EleWise.ELMA.SR.T((string) LocalFsStorageOperationsProvider.BPulnsWQoNb2kpkZOTao(-1426456882 ^ 2009939514 ^ -583702566), (object) location));
label_6:
      throw new InvalidDataException((string) LocalFsStorageOperationsProvider.T7uVdCWQnSdKmrZXBNLA((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099645965)));
label_2:;
    }

    private Stream OpenReadFileStream(string path, bool forAsync)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (forAsync)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 1 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return (Stream) LocalFsStorageOperationsProvider.oaZgGnWQOjhPLBuSN7Ra((object) path, FileMode.Open, FileAccess.Read, FileShare.Read);
label_5:
      return (Stream) FileAsync.OpenRead(path);
    }

    private Stream OpenWriteFileStream(string path, bool forAsync)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (forAsync)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      return (Stream) LocalFsStorageOperationsProvider.Jy2riWWQ2Ss8u5o1hFho((object) path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
label_3:
      return (Stream) LocalFsStorageOperationsProvider.SkpIm6WQeGAiRXl7gfYY((object) path);
    }

    internal static void htk39nWfzQXlVC86FrPl() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool SfuPCqWfsQa9UPIRyBoU() => LocalFsStorageOperationsProvider.Jl3V1sWfU9h0YHy9BU56 == null;

    internal static LocalFsStorageOperationsProvider Lo4snBWfctlllRtagYtE() => LocalFsStorageOperationsProvider.Jl3V1sWfU9h0YHy9BU56;

    internal static object JkXKXaWQFNmPyDUglE9o([In] object obj0, [In] object obj1) => (object) ((ILocationSchema) obj0).MapPersistentLocation((SystemFile) obj1);

    internal static object q5QX0gWQBfFFgMaDcoj9([In] object obj0) => (object) ((SystemFile) obj0).FileCrc;

    internal static Guid pYim0sWQW8kn01CnTqA5() => Guid.NewGuid();

    internal static object BPulnsWQoNb2kpkZOTao(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object HGOC8kWQbTBmwkb1pJy2([In] object obj0) => (object) ((SystemFile) obj0).Name;

    internal static object JTxGXMWQhguhC6AX4aAP([In] object obj0) => (object) ((string) obj0).ReplaceInvalidFileNameChars();

    internal static object tOGJ1xWQGOXsLbHOdctB([In] object obj0) => (object) Path.GetExtension((string) obj0);

    internal static object eHmSanWQEtc86D51rqVc([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((ILocationSchema) obj0).MapTempLocation((string) obj1, (string) obj2);

    internal static object zaqd8TWQfummUFplwpA6([In] object obj0) => (object) ((Uri) obj0).LocalPath;

    internal static object w4IkjxWQQ261bRjWYBFu([In] object obj0) => (object) ((SystemFile) obj0).Salt;

    internal static void hsmTOqWQCIicD2jmHIfp([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => EncryptionHelper.DecryptFile((string) obj0, (string) obj1, (string) obj2, (string) obj3);

    internal static void oasiL0WQvXh8sRxX27GN([In] object obj0, [In] object obj1) => ((BinaryFileContentInfo) obj0).ContentLocation = (Uri) obj1;

    internal static long cNthweWQ8RZ3xiKTfQb5([In] object obj0) => ((FileInfo) obj0).Length;

    internal static void xDEEJYWQZDTBO9jesloQ([In] object obj0, long value) => ((BinaryFileContentInfo) obj0).ContentLength = value;

    internal static uint UUgk17WQuQyTN3Gvegh3([In] object obj0) => Crc32.GetCrcValue((string) obj0);

    internal static void DvVkiOWQIFx4JAsU8PtM([In] object obj0, uint value) => ((BinaryFileContentInfo) obj0).Crc = value;

    internal static void oplrejWQVmtyd9CflQlu([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => EncryptionHelper.EncryptFile((string) obj0, (string) obj1, (string) obj2, (string) obj3);

    internal static bool IDmOV4WQSMlgbXcfrOuL([In] object obj0) => ((GetContentOptions) obj0).ForAsync;

    internal static bool r91FSWWQiSZC7PwGdmmW([In] object obj0, [In] object obj1) => (Uri) obj0 != (Uri) obj1;

    internal static bool oQFAtMWQRAJaJWNdhsIR([In] object obj0) => File.Exists((string) obj0);

    internal static void SxPG5sWQqZT8m3pKfI5y([In] object obj0, [In] object obj1, [In] bool obj2) => File.Copy((string) obj0, (string) obj1, obj2);

    internal static void MiTkhNWQKawBmIcmChEX([In] object obj0) => File.Delete((string) obj0);

    internal static object bI9ugJWQXIsakqC6vsmo([In] object obj0) => (object) ((Exception) obj0).Message;

    internal static object YwPj8CWQTKl6JGBNaxa8([In] object obj0) => (object) EncryptionHelper.GetMd5Hash((Stream) obj0);

    internal static void RDZLgMWQkaRp7XKiatOw([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object T7uVdCWQnSdKmrZXBNLA([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object oaZgGnWQOjhPLBuSN7Ra(
      [In] object obj0,
      [In] FileMode obj1,
      [In] FileAccess obj2,
      [In] FileShare obj3)
    {
      return (object) File.Open((string) obj0, obj1, obj2, obj3);
    }

    internal static object Jy2riWWQ2Ss8u5o1hFho([In] object obj0, [In] FileMode obj1, [In] FileAccess obj2) => (object) File.Open((string) obj0, obj1, obj2);

    internal static object SkpIm6WQeGAiRXl7gfYY([In] object obj0) => (object) FileAsync.OpenWrite((string) obj0);
  }
}
