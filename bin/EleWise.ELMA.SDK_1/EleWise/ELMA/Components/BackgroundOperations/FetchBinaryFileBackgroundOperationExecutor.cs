// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Components.BackgroundOperations.FetchBinaryFileBackgroundOperationExecutor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.BackgroundOperations;
using EleWise.ELMA.Model.BackgroundOperations.FetchBinaryFile;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Components.BackgroundOperations
{
  /// <summary>Исполнитель фоновой операции "Получить BinaryFile".</summary>
  internal class FetchBinaryFileBackgroundOperationExecutor : BackgroundOperationExecutorBase
  {
    private readonly IFileManager fileManager;
    private readonly IBinaryFileAsyncLoader binaryFileAsyncLoader;
    internal static FetchBinaryFileBackgroundOperationExecutor AFEWOWfGcoRISoI7yq2G;

    /// <summary>Ctor</summary>
    /// <param name="fileManager">Провайдер работы с файлами.</param>
    /// <param name="binaryFileAsyncLoader">Провайдер асинхронной загрузки файлов.</param>
    public FetchBinaryFileBackgroundOperationExecutor(
      IFileManager fileManager,
      IBinaryFileAsyncLoader binaryFileAsyncLoader)
    {
      FetchBinaryFileBackgroundOperationExecutor.jgVNR7fEBWQw2OstvEUD();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            this.fileManager = fileManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
            continue;
          default:
            this.binaryFileAsyncLoader = binaryFileAsyncLoader;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 1 : 1;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Может ли компонент выполнить фоновую операцию?</summary>
    /// <param name="executionInfo">Данные для выполнения операции.</param>
    /// <returns>true - может, false - не сможет.</returns>
    public override bool CanExecute(IBackgroundOperation executionInfo) => executionInfo is FetchBinaryFileBackgroundOperation;

    /// <summary>
    /// Получить описание фоновой операции (какая операция выполняется).
    /// </summary>
    /// <param name="executionInfo">Данные об операции.</param>
    /// <returns>Описание фоновой операции (какая операция выполняется).</returns>
    public override string GetDescription(IBackgroundOperation executionInfo)
    {
      int num = 2;
      FetchBinaryFileBackgroundOperation backgroundOperation;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (backgroundOperation != null)
            {
              num = 3;
              continue;
            }
            goto label_5;
          case 2:
            backgroundOperation = executionInfo as FetchBinaryFileBackgroundOperation;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_6;
          default:
            goto label_5;
        }
      }
label_5:
      return string.Empty;
label_6:
      return EleWise.ELMA.SR.T((string) FetchBinaryFileBackgroundOperationExecutor.ukkx5nfEW2w36000vj9x(-1858887263 ^ -1858697851), FetchBinaryFileBackgroundOperationExecutor.trCsPufEoH1u6mdjGZqt((object) backgroundOperation));
    }

    /// <summary>
    /// Максимальный размер файла, который разрешается кешировать в память при извлечении файла этой фоновой операцией.
    /// </summary>
    protected long MaxFileSizeToPrecache => EleWise.ELMA.SR.GetSetting<long>((string) FetchBinaryFileBackgroundOperationExecutor.ukkx5nfEW2w36000vj9x(-2107978722 ^ -2107643766), 10485760L);

    /// <summary>
    /// Реализация запуска фоновой операции для классов-наследников.
    /// </summary>
    /// <param name="executionInfo">Данные об операции.</param>
    /// <param name="token">Токен отмены.</param>
    /// <returns>Системная задача.</returns>
    protected override Task<object> RunTaskImpl(
      IBackgroundOperation executionInfo,
      CancellationToken token)
    {
      FetchBinaryFileBackgroundOperation backgroundOperation = this.CastTo<FetchBinaryFileBackgroundOperation>(executionInfo);
      long num = this.fileManager.FileSize(backgroundOperation.Key);
      Task<FetchBinaryFileBackgroundOperationExecutor.BackgroundBinaryFile> task = this.binaryFileAsyncLoader.LoadFileAsync(backgroundOperation.Key, token).Then<BinaryFile, FetchBinaryFileBackgroundOperationExecutor.BackgroundBinaryFile>((Func<BinaryFile, FetchBinaryFileBackgroundOperationExecutor.BackgroundBinaryFile>) (f => new FetchBinaryFileBackgroundOperationExecutor.BackgroundBinaryFile(f)), token);
      long fileSizeToPrecache = this.MaxFileSizeToPrecache;
      return (num > fileSizeToPrecache ? task : task.Then<FetchBinaryFileBackgroundOperationExecutor.BackgroundBinaryFile, FetchBinaryFileBackgroundOperationExecutor.BackgroundBinaryFile>((Func<FetchBinaryFileBackgroundOperationExecutor.BackgroundBinaryFile, Task<FetchBinaryFileBackgroundOperationExecutor.BackgroundBinaryFile>>) (f => f.PrecacheAsync(token)), token)).Then<FetchBinaryFileBackgroundOperationExecutor.BackgroundBinaryFile, object>((Func<FetchBinaryFileBackgroundOperationExecutor.BackgroundBinaryFile, object>) (r => (object) r), token);
    }

    internal static void jgVNR7fEBWQw2OstvEUD() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool UA1LBBfGz9Smvo9mUBO0() => FetchBinaryFileBackgroundOperationExecutor.AFEWOWfGcoRISoI7yq2G == null;

    internal static FetchBinaryFileBackgroundOperationExecutor W7jRFEfEFFKMkl9JDwwa() => FetchBinaryFileBackgroundOperationExecutor.AFEWOWfGcoRISoI7yq2G;

    internal static object ukkx5nfEW2w36000vj9x(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object trCsPufEoH1u6mdjGZqt([In] object obj0) => (object) ((FetchBinaryFileBackgroundOperation) obj0).Key;

    /// <summary>
    /// Специальный прокси к BinaryFile, который является результатом данной фоновой операции.
    /// </summary>
    /// <remarks>
    /// <para>Прокси работает в двух режимах:</para>
    /// <para>
    /// Режим совместимости - в этом режиме поддерживается работа с ContentFilePath для внешнего потребителя по старому протоколу.
    /// Даже если файл был в облаке, он выкачивается и размещается локально, если клиентский код обращается к свойству ContentFilePath.
    /// Переход в этот режим происходит при первом обращении к ContentFilePath.
    /// </para>
    /// <para>
    /// Обычный режим - в этом режиме файл контента может находиться в любом хранилище и доступ к нему возможен через потоки без создания
    /// локальных копий во временных папках. Прокси начинает работу в этом режиме.
    /// </para>
    /// </remarks>
    [Serializable]
    internal class BackgroundBinaryFile : BinaryFile
    {
      private byte[] content;
      private bool isLegacyMode;
      private BinaryFile originalBinaryFile;
      private static FetchBinaryFileBackgroundOperationExecutor.BackgroundBinaryFile wRwiPb8dJ9R0I0tobfcy;

      /// <summary>Ctor</summary>
      /// <param name="binaryFile">Оригинальный (оборачиваемый файл).</param>
      public BackgroundBinaryFile(BinaryFile binaryFile)
      {
        FetchBinaryFileBackgroundOperationExecutor.BackgroundBinaryFile.KMSWTU8dl9Rc8R5s9DXn();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              FetchBinaryFileBackgroundOperationExecutor.BackgroundBinaryFile.zJtf6l8lWemVmBwUfpcT((object) this, FetchBinaryFileBackgroundOperationExecutor.BackgroundBinaryFile.qv0EqN8lB7yStCjxX81k((object) binaryFile));
              num = 5;
              continue;
            case 2:
              FetchBinaryFileBackgroundOperationExecutor.BackgroundBinaryFile.a0CPMx8dYWF87AXJpb0w((object) this, binaryFile.Encrypt);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 7 : 3;
              continue;
            case 3:
              this.Id = (string) FetchBinaryFileBackgroundOperationExecutor.BackgroundBinaryFile.jnRCcN8dcBVQTeaOJ5yc((object) binaryFile);
              num = 6;
              continue;
            case 4:
              goto label_3;
            case 5:
              FetchBinaryFileBackgroundOperationExecutor.BackgroundBinaryFile.FOp01m8lbMNDSwKDt8cj((object) this, FetchBinaryFileBackgroundOperationExecutor.BackgroundBinaryFile.f4uWN28loOEhwFtRYyrF((object) binaryFile));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 4;
              continue;
            case 6:
              FetchBinaryFileBackgroundOperationExecutor.BackgroundBinaryFile.opU6AE8lFTW2WwPBu23j((object) this, FetchBinaryFileBackgroundOperationExecutor.BackgroundBinaryFile.MA8eMW8dz6ycl9JYIjae((object) binaryFile));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 1;
              continue;
            case 7:
              FetchBinaryFileBackgroundOperationExecutor.BackgroundBinaryFile.Nfb5lI8dUbBItbIHiK9k((object) this, FetchBinaryFileBackgroundOperationExecutor.BackgroundBinaryFile.uvJk0D8dLam0JK1L07AL((object) binaryFile));
              num = 8;
              continue;
            case 8:
              this.Name = (string) FetchBinaryFileBackgroundOperationExecutor.BackgroundBinaryFile.DsIUOU8ds00TIHcJB7aT((object) binaryFile);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 3;
              continue;
            case 9:
              FetchBinaryFileBackgroundOperationExecutor.BackgroundBinaryFile.YIdnh08dgOqTFiX8rvkk((object) this, FetchBinaryFileBackgroundOperationExecutor.BackgroundBinaryFile.MHgBit8dr8TbNy6dhkJq((object) binaryFile));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 3 : 10;
              continue;
            case 10:
              FetchBinaryFileBackgroundOperationExecutor.BackgroundBinaryFile.NKYT1S8djUq1AuS9ty28((object) this, FetchBinaryFileBackgroundOperationExecutor.BackgroundBinaryFile.oD0XwM8d5WLO1NolqhB4((object) binaryFile));
              num = 2;
              continue;
            default:
              this.originalBinaryFile = binaryFile;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 1 : 9;
              continue;
          }
        }
label_3:;
      }

      /// <summary>Локальный путь до файла</summary>
      [Obsolete("Свойство устарело. Для доступа к контенту используйте GetContent() и PutContent().")]
      public override string ContentFilePath
      {
        get
        {
          int num = 2;
          while (true)
          {
            switch (num)
            {
              case 2:
                if (this.isLegacyMode)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 1 : 0;
                  continue;
                }
                goto case 3;
              case 3:
                this.TransitToLegacyMode((string) FetchBinaryFileBackgroundOperationExecutor.BackgroundBinaryFile.OQmCxg8lhdMFlrdC8m3K(FetchBinaryFileBackgroundOperationExecutor.BackgroundBinaryFile.DsIUOU8ds00TIHcJB7aT((object) this)));
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
                continue;
              default:
                goto label_2;
            }
          }
label_2:
          return (string) FetchBinaryFileBackgroundOperationExecutor.BackgroundBinaryFile.ABP4lo8lGFI8oMmMQgC2((object) this.ContentLocation);
        }
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
                this.ContentLocation = new Uri(value);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
                continue;
              case 2:
                this.TransitToLegacyMode(value);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 1 : 1;
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

      /// <summary>Получить содержимое BinaryFile в виде потока.</summary>
      /// <param name="options">Характеристики потока чтения.</param>
      /// <returns>Поток.</returns>
      public override Stream GetContent(GetContentOptions options = null)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!FetchBinaryFileBackgroundOperationExecutor.BackgroundBinaryFile.JqEUtn8lEEFiiKRbmmYd((object) this))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            default:
              goto label_2;
          }
        }
label_2:
        return this.originalBinaryFile.GetContent(options);
label_3:
        return (Stream) MemoryHelper.GetMemoryStream(this.content, false);
      }

      /// <summary>Получить crc-32 файла.</summary>
      /// <returns>crc-32 файла.</returns>
      public override uint GetCrc() => FetchBinaryFileBackgroundOperationExecutor.BackgroundBinaryFile.VIx3f78lf8s6LlbUpdSw((object) this.originalBinaryFile);

      /// <summary>Получить размер.</summary>
      /// <returns>Размер файла.</returns>
      public override long GetSize()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!FetchBinaryFileBackgroundOperationExecutor.BackgroundBinaryFile.JqEUtn8lEEFiiKRbmmYd((object) this))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            default:
              goto label_4;
          }
        }
label_4:
        return FetchBinaryFileBackgroundOperationExecutor.BackgroundBinaryFile.LDmhuw8lQxRsTdgPjS9A((object) this.originalBinaryFile);
label_5:
        return (long) this.content.Length;
      }

      /// <summary>Содержимое файла закешировано в памяти?</summary>
      protected virtual bool IsPrecached => this.content != null;

      /// <summary>Сбросить кеш.</summary>
      protected virtual void DropCache()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.content = (byte[]) null;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      /// <summary>
      /// Асинхронная задача по кешированию содержимого файла в память.
      /// </summary>
      /// <param name="token">Токен отмены.</param>
      /// <returns>Системная задача, представляющая работу по кешированию содержимого файла.</returns>
      internal Task<FetchBinaryFileBackgroundOperationExecutor.BackgroundBinaryFile> PrecacheAsync(
        CancellationToken token)
      {
        return Task.Factory.StartNew<Stream>((Func<Stream>) (() =>
        {
          int num1 = 2;
          CallContextSessionOwner contextSessionOwner;
          while (true)
          {
            switch (num1)
            {
              case 1:
                goto label_4;
              case 2:
                contextSessionOwner = CallContextSessionOwner.Create();
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 1;
                continue;
              default:
                goto label_2;
            }
          }
label_2:
          Stream content;
          return content;
label_4:
          try
          {
            content = this.GetContent(GetContentOptions.NonSeekableForAsync);
            int num2 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
              num2 = 0;
            switch (num2)
            {
              default:
                goto label_2;
            }
          }
          finally
          {
            if (contextSessionOwner != null)
            {
              int num3 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
                num3 = 1;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    FetchBinaryFileBackgroundOperationExecutor.BackgroundBinaryFile.xRJ7Es8lZOGPcRCej9Ov((object) contextSessionOwner);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_12;
                }
              }
            }
label_12:;
          }
        }), token).Then<Stream, byte[]>((Func<Stream, Task<byte[]>>) (stream => stream.ReadAllBytesAsync()), token).Then<byte[], FetchBinaryFileBackgroundOperationExecutor.BackgroundBinaryFile>((Func<byte[], FetchBinaryFileBackgroundOperationExecutor.BackgroundBinaryFile>) (buf =>
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                this.content = buf;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 0;
                continue;
              default:
                goto label_2;
            }
          }
label_2:
          return this;
        }), token);
      }

      /// <summary>
      /// Перейти в режим совместимости, поддерживающий ContentFilePath.
      /// </summary>
      /// <param name="filename"></param>
      internal void TransitToLegacyMode(string filename)
      {
        int num1 = 7;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            object source;
            switch (num2)
            {
              case 1:
                goto label_10;
              case 2:
                source = (object) this.originalBinaryFile.GetContent(GetContentOptions.NonSeekable);
                break;
              case 3:
                FetchBinaryFileBackgroundOperationExecutor.BackgroundBinaryFile.c2jbdN8l8f9MI4mochQf((object) this);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 4 : 4;
                continue;
              case 4:
                goto label_7;
              case 5:
                goto label_4;
              case 6:
                if (FetchBinaryFileBackgroundOperationExecutor.BackgroundBinaryFile.JqEUtn8lEEFiiKRbmmYd((object) this))
                {
                  source = FetchBinaryFileBackgroundOperationExecutor.BackgroundBinaryFile.kj3ZJ28lC0YCxTt4VYdE((object) this.content, false);
                  break;
                }
                goto label_6;
              case 7:
                if (!this.isLegacyMode)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 6 : 0;
                  continue;
                }
                goto label_3;
              default:
                this.isLegacyMode = true;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 3 : 3;
                continue;
            }
            FileStream destination = (FileStream) FetchBinaryFileBackgroundOperationExecutor.BackgroundBinaryFile.Q2Z97y8lvqm94no6Jml1((object) filename);
            ((Stream) source).CopyAllBytesToStream((Stream) destination);
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
          }
label_6:
          num1 = 2;
          continue;
label_7:
          this.ContentLocation = new Uri(filename);
          num1 = 5;
        }
label_10:
        return;
label_4:
        return;
label_3:;
      }

      internal static void KMSWTU8dl9Rc8R5s9DXn() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static object MHgBit8dr8TbNy6dhkJq([In] object obj0) => (object) ((BinaryFile) obj0).ContentType;

      internal static void YIdnh08dgOqTFiX8rvkk([In] object obj0, [In] object obj1) => ((BinaryFile) obj0).ContentType = (string) obj1;

      internal static DateTime oD0XwM8d5WLO1NolqhB4([In] object obj0) => ((BinaryFile) obj0).CreateDate;

      internal static void NKYT1S8djUq1AuS9ty28([In] object obj0, DateTime value) => ((BinaryFile) obj0).CreateDate = value;

      internal static void a0CPMx8dYWF87AXJpb0w([In] object obj0, bool value) => ((BinaryFile) obj0).Encrypt = value;

      internal static object uvJk0D8dLam0JK1L07AL([In] object obj0) => (object) ((BinaryFile) obj0).Salt;

      internal static void Nfb5lI8dUbBItbIHiK9k([In] object obj0, [In] object obj1) => ((BinaryFile) obj0).Salt = (string) obj1;

      internal static object DsIUOU8ds00TIHcJB7aT([In] object obj0) => (object) ((BinaryFile) obj0).Name;

      internal static object jnRCcN8dcBVQTeaOJ5yc([In] object obj0) => (object) ((BinaryFile) obj0).Id;

      internal static object MA8eMW8dz6ycl9JYIjae([In] object obj0) => (object) ((BinaryFile) obj0).SecondId;

      internal static void opU6AE8lFTW2WwPBu23j([In] object obj0, [In] object obj1) => ((BinaryFile) obj0).SecondId = (string) obj1;

      internal static Guid qv0EqN8lB7yStCjxX81k([In] object obj0) => ((BinaryFile) obj0).Uid;

      internal static void zJtf6l8lWemVmBwUfpcT([In] object obj0, Guid value) => ((BinaryFile) obj0).Uid = value;

      internal static object f4uWN28loOEhwFtRYyrF([In] object obj0) => (object) ((BinaryFile) obj0).ContentLocation;

      internal static void FOp01m8lbMNDSwKDt8cj([In] object obj0, [In] object obj1) => ((BinaryFile) obj0).ContentLocation = (Uri) obj1;

      internal static bool Pwc9tc8d9X6IVKTwcKy1() => FetchBinaryFileBackgroundOperationExecutor.BackgroundBinaryFile.wRwiPb8dJ9R0I0tobfcy == null;

      internal static FetchBinaryFileBackgroundOperationExecutor.BackgroundBinaryFile t3og6O8ddlHxEESlNtin() => FetchBinaryFileBackgroundOperationExecutor.BackgroundBinaryFile.wRwiPb8dJ9R0I0tobfcy;

      internal static object OQmCxg8lhdMFlrdC8m3K([In] object obj0) => (object) BinaryFile.CreateContentFilePath((string) obj0);

      internal static object ABP4lo8lGFI8oMmMQgC2([In] object obj0) => (object) ((Uri) obj0).LocalPath;

      internal static bool JqEUtn8lEEFiiKRbmmYd([In] object obj0) => ((FetchBinaryFileBackgroundOperationExecutor.BackgroundBinaryFile) obj0).IsPrecached;

      internal static uint VIx3f78lf8s6LlbUpdSw([In] object obj0) => ((BinaryFile) obj0).GetCrc();

      internal static long LDmhuw8lQxRsTdgPjS9A([In] object obj0) => ((BinaryFile) obj0).GetSize();

      internal static object kj3ZJ28lC0YCxTt4VYdE([In] object obj0, bool writable) => (object) MemoryHelper.GetMemoryStream((byte[]) obj0, writable);

      internal static object Q2Z97y8lvqm94no6Jml1([In] object obj0) => (object) File.OpenWrite((string) obj0);

      internal static void c2jbdN8l8f9MI4mochQf([In] object obj0) => ((FetchBinaryFileBackgroundOperationExecutor.BackgroundBinaryFile) obj0).DropCache();

      internal static void xRJ7Es8lZOGPcRCej9Ov([In] object obj0) => ((IDisposable) obj0).Dispose();
    }
  }
}
