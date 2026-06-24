// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.Previews.FilePreviewService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Services;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace EleWise.ELMA.Files.Previews
{
  /// <summary>Сервис для работы с предпросмотром файлов</summary>
  [Service]
  public class FilePreviewService : IFilePreviewService
  {
    private readonly ILazy<IEventHandlerSubscribeService> eventHandlerSubscribeService;
    internal static FilePreviewService OmsEAWGPAmnaGfupbY8D;

    /// <summary>Ctor</summary>
    /// <param name="eventHandlerSubscribeService">Сервис ручной подписки на события</param>
    public FilePreviewService(
      ILazy<IEventHandlerSubscribeService> eventHandlerSubscribeService)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.eventHandlerSubscribeService = eventHandlerSubscribeService;
    }

    /// <summary>Работа с папкой предпросмотра файлов</summary>
    public IFolderPreviewService FolderPreviewService
    {
      get => this.\u003CFolderPreviewService\u003Ek__BackingField;
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
              this.\u003CFolderPreviewService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
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

    /// <summary>Путь до папки с предпросмотром</summary>
    public string PreviewDir => (string) FilePreviewService.QCkbsrGP0w0BgFiiPS5A((object) this.FolderPreviewService);

    /// <summary>Провайдер сервиса генерации предпросмотра</summary>
    public IFilePreviewServiceProvider FilePreviewServiceProvider
    {
      get => this.\u003CFilePreviewServiceProvider\u003Ek__BackingField;
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
              this.\u003CFilePreviewServiceProvider\u003Ek__BackingField = value;
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
    /// Получение текстового представления предпросмотра для индексации
    /// </summary>
    /// <param name="file"></param>
    /// <returns></returns>
    public string GetPreviewText(BinaryFile file)
    {
      int num = 2;
      IFilePreviewCreator previewCreator;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (previewCreator != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 3 : 1;
              continue;
            }
            goto label_2;
          case 2:
            previewCreator = this.GetPreviewCreator(file);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 1 : 1;
            continue;
          case 3:
            if (!FilePreviewService.WmRikEGPm5PP9XdU4PjX((object) previewCreator, (object) file))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return "";
label_3:
      return (string) FilePreviewService.jtWg5wGPyCPx0SKZKQQ4((object) previewCreator, (object) file);
    }

    /// <summary>Добавить файл в очередь на создание предпросмотра</summary>
    /// <param name="file"></param>
    [Transaction]
    public virtual void AddPreviewWork(BinaryFile file, long priority)
    {
      int num = 3;
      while (true)
      {
        string str;
        Guid guid;
        string id;
        switch (num)
        {
          case 1:
            id = guid.ToString();
            break;
          case 2:
            id = file.Id;
            break;
          case 3:
            if (FilePreviewService.Qbm57fGPJwKHI5E1FkDp(FilePreviewService.fMC50iGPM2Q9HrF2XCwB((object) file), Guid.Empty))
            {
              guid = FilePreviewService.fMC50iGPM2Q9HrF2XCwB((object) file);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 1 : 1;
              continue;
            }
            num = 2;
            continue;
          case 4:
            goto label_2;
          default:
            FilePreviewService.mibgxiGP9YmGkNoNfFDS((object) this.FilePreviewServiceProvider, (object) str, priority);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 4 : 0;
            continue;
        }
        str = id;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
      }
label_2:;
    }

    /// <summary>Статус формирования предпросмотра</summary>
    /// <param name="file"></param>
    /// <returns></returns>
    public PreviewWorkStatus GetPreviewWorkStatus(BinaryFile file)
    {
      int num1 = 3;
      PreviewWorkStatus previewWorkStatus;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          string str;
          Guid guid;
          object obj;
          switch (num2)
          {
            case 1:
              goto label_10;
            case 2:
              obj = FilePreviewService.GnYjZgGPdHk6a8FQ4BJ2((object) file);
              break;
            case 3:
              if (FilePreviewService.Qbm57fGPJwKHI5E1FkDp(FilePreviewService.fMC50iGPM2Q9HrF2XCwB((object) file), Guid.Empty))
              {
                guid = FilePreviewService.fMC50iGPM2Q9HrF2XCwB((object) file);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 4:
              previewWorkStatus = FilePreviewService.my57aMGPlNTfP6Xcjdh0((object) this.FilePreviewServiceProvider, (object) str);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 6 : 3;
              continue;
            case 5:
              if (!this.HasPreview(file))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 1 : 1;
                continue;
              }
              goto label_11;
            case 6:
              if (previewWorkStatus == PreviewWorkStatus.None)
              {
                num2 = 5;
                continue;
              }
              goto label_12;
            default:
              obj = (object) guid.ToString();
              break;
          }
          str = (string) obj;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 4 : 4;
        }
label_4:
        num1 = 2;
      }
label_10:
      return PreviewWorkStatus.None;
label_11:
      return PreviewWorkStatus.Completed;
label_12:
      return previewWorkStatus;
    }

    /// <summary>Удалить предпросмотр для файла</summary>
    /// <param name="file"></param>
    public void ClearPreview(BinaryFile file)
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          string str;
          Guid guid;
          string id;
          switch (num2)
          {
            case 0:
              goto label_15;
            case 1:
              id = guid.ToString();
              break;
            case 2:
              if (FilePreviewService.fMC50iGPM2Q9HrF2XCwB((object) file) != Guid.Empty)
              {
                guid = FilePreviewService.fMC50iGPM2Q9HrF2XCwB((object) file);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 1 : 1;
                continue;
              }
              goto label_14;
            case 3:
              if (!FilePreviewService.djcAnVGPrHZDkPviXBUy((object) this.PreviewDir))
              {
                num2 = 2;
                continue;
              }
              goto label_18;
            case 4:
              string filePreviewDir = (string) FilePreviewService.bBEBZuGPjFvb5VJKFToy((object) this.FolderPreviewService, FilePreviewService.iJungfGP5ZHubUWWyCZ8((object) str));
              FilePreviewService.Lugm43GPYJOmE7mqQBuV((object) (System.Action) (() =>
              {
                int num3 = 2;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_6;
                    case 2:
                      if (!Directory.Exists(filePreviewDir))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 1 : 1;
                        continue;
                      }
                      break;
                    case 3:
                      goto label_2;
                  }
                  // ISSUE: reference to a compiler-generated method
                  FilePreviewService.\u003C\u003Ec__DisplayClass16_0.TORyTHvzMYpXfbcJ2Mav((object) filePreviewDir, true);
                  num3 = 3;
                }
label_6:
                return;
label_2:;
              }));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 3 : 8;
              continue;
            case 5:
              goto label_6;
            case 6:
              id = file.Id;
              break;
            case 7:
              if (FilePreviewService.DB0jVtGPg6wZpXBYYSPb((object) str))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
                continue;
              }
              goto case 4;
            case 8:
              goto label_4;
            default:
              goto label_3;
          }
          str = id;
          num2 = 7;
        }
label_14:
        num1 = 6;
      }
label_15:
      return;
label_6:
      return;
label_4:
      return;
label_3:
      return;
label_18:;
    }

    /// <summary>Получить генератор предпросмотра</summary>
    /// <param name="file"></param>
    /// <returns></returns>
    public IFilePreviewCreator GetPreviewCreator(BinaryFile file) => this.FilePreviewServiceProvider.GetFilePreviewCreator(file);

    /// <summary>Сгенерировать предпросмотр</summary>
    /// <param name="file"></param>
    public void GeneratePreview(BinaryFile file)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.GeneratePreview(file, (string) null, (string) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    private string UnionPasswords(string fileEncryptPassword, string password) => (string) FilePreviewService.cmCQjvGPLfD5ZfYwXqe9((object) fileEncryptPassword, (object) password);

    /// <inheritdoc />
    public void GeneratePreview(BinaryFile file, string fileEncryptPassword, string password)
    {
      int num1 = 25;
      MemoryStream baseOutputStream;
      string fileId;
      string path;
      FilePreviewService.FilePreviewEventHandler previewEventHandler;
      IDisposable disposable;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          IFilePreviewCreator previewCreator;
          string str;
          string encryptFileName;
          Guid guid;
          object obj;
          switch (num2)
          {
            case 1:
              goto label_22;
            case 2:
              FilePreviewService.zo99LPGPsdXhlZrZWPXn((object) path);
              num2 = 23;
              continue;
            case 3:
              if (!FilePreviewService.djcAnVGPrHZDkPviXBUy((object) str))
              {
                num2 = 20;
                continue;
              }
              goto default;
            case 4:
              previewCreator = this.GetPreviewCreator(file);
              num2 = 27;
              continue;
            case 5:
              if (!this.FilePreviewServiceProvider.GeneratePreview(fileId, fileEncryptPassword, password))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 13 : 5;
                continue;
              }
              goto case 12;
            case 6:
              if (!FilePreviewService.djcAnVGPrHZDkPviXBUy((object) encryptFileName))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 9 : 14;
                continue;
              }
              goto label_90;
            case 7:
            case 13:
              goto label_115;
            case 8:
              goto label_36;
            case 9:
              goto label_103;
            case 10:
              goto label_112;
            case 11:
              goto label_98;
            case 12:
              baseOutputStream = new MemoryStream();
              num2 = 8;
              continue;
            case 14:
              if (!FilePreviewService.ShiZKlGPz5VXeomuk8e4((object) encryptFileName))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
                continue;
              }
              goto label_86;
            case 15:
              goto label_3;
            case 16:
              if (!FilePreviewService.vROGZ8GPUKf24TbpsiEg((object) path))
              {
                num2 = 2;
                continue;
              }
              goto case 17;
            case 17:
              if (!file.Encrypt)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 28 : 15;
                continue;
              }
              goto case 30;
            case 18:
              goto label_10;
            case 19:
              obj = FilePreviewService.GnYjZgGPdHk6a8FQ4BJ2((object) file);
              break;
            case 20:
              if (FilePreviewService.ShiZKlGPz5VXeomuk8e4((object) str))
              {
                num2 = 10;
                continue;
              }
              goto default;
            case 21:
              goto label_6;
            case 22:
              path = (string) FilePreviewService.bBEBZuGPjFvb5VJKFToy((object) this.FolderPreviewService, FilePreviewService.iJungfGP5ZHubUWWyCZ8((object) fileId));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 4;
              continue;
            case 24:
              if (!FilePreviewService.Qbm57fGPJwKHI5E1FkDp(file.Uid, Guid.Empty))
              {
                num2 = 19;
                continue;
              }
              guid = FilePreviewService.fMC50iGPM2Q9HrF2XCwB((object) file);
              num2 = 26;
              continue;
            case 25:
              if (!FilePreviewService.djcAnVGPrHZDkPviXBUy((object) this.PreviewDir))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 24 : 21;
                continue;
              }
              goto label_92;
            case 26:
              obj = (object) guid.ToString();
              break;
            case 27:
              if (previewCreator != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 6 : 16;
                continue;
              }
              goto label_71;
            case 28:
              if (FilePreviewService.vgsgdqGPcbrdRSDpuISF((object) this.FilePreviewServiceProvider, (object) fileId, (object) null))
              {
                str = (string) FilePreviewService.E4ai5wG1F5uOoPssIWpI((object) previewCreator, (object) file);
                num2 = 3;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 21 : 30;
              continue;
            case 29:
              disposable = (IDisposable) FilePreviewService.OXOXKnG1Zt80usxi0Q1p((object) this.eventHandlerSubscribeService.Value, (object) previewEventHandler);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 1;
              continue;
            case 30:
              encryptFileName = this.GetEncryptFileName(previewCreator, file);
              num2 = 6;
              continue;
            default:
              if (!FilePreviewService.f6homMG1B9EdwKJ8qthw((object) file))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 9 : 6;
                continue;
              }
              goto case 5;
          }
          fileId = (string) obj;
          num2 = 22;
        }
label_103:
        if (password != null)
        {
          num1 = 5;
        }
        else
        {
          previewEventHandler = new FilePreviewService.FilePreviewEventHandler(fileId);
          num1 = 29;
        }
      }
label_112:
      return;
label_98:
      return;
label_3:
      return;
label_10:
      return;
label_6:
      return;
label_92:
      return;
label_90:
      return;
label_22:
      try
      {
        FilePreviewService.TL1irMG1ueSnQ873k5Le((object) this, (object) file, 0L);
        int num3 = 2;
        TaskAwaiter taskAwaiter;
        while (true)
        {
          switch (num3)
          {
            case 0:
              goto label_84;
            case 1:
              taskAwaiter.GetResult();
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
              continue;
            case 2:
              taskAwaiter = FilePreviewService.Phy6OaG1V0BASVOZM5OL(FilePreviewService.MI6UmwG1IfZRPe7T9Vdp((object) previewEventHandler));
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 1 : 1;
              continue;
            default:
              goto label_76;
          }
        }
label_84:
        return;
label_76:
        return;
      }
      finally
      {
        int num4;
        if (disposable == null)
          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 1 : 1;
        else
          goto label_29;
label_28:
        switch (num4)
        {
          case 1:
          case 2:
        }
label_29:
        FilePreviewService.rO1VWFG1Gjl52MSQSK3B((object) disposable);
        num4 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
        {
          num4 = 2;
          goto label_28;
        }
        else
          goto label_28;
      }
label_36:
      try
      {
        ZipOutputStream zipOutputStream1 = new ZipOutputStream((Stream) baseOutputStream);
        zipOutputStream1.IsStreamOwner = false;
        ZipOutputStream zipOutputStream2 = zipOutputStream1;
        int num5 = 6;
        IEnumerator<string> enumerator;
        FileStream fileStream;
        while (true)
        {
          switch (num5)
          {
            case 1:
label_39:
              fileStream = (FileStream) FilePreviewService.f9fRsMG1C5nkgMkx7f72((object) this.GetEncryptFileName(this.GetPreviewCreator(file), file));
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
              continue;
            case 2:
              try
              {
label_54:
                if (enumerator.MoveNext())
                  goto label_56;
                else
                  goto label_55;
label_53:
                int num6;
                switch (num6)
                {
                  case 1:
                    goto label_38;
                  case 2:
                    goto label_54;
                  default:
                    goto label_56;
                }
label_55:
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 1 : 1;
                goto label_53;
label_56:
                FilePreviewService.eSenYCG1ELhJZ0ATJ0xs((object) enumerator.Current);
                num6 = 2;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0)
                {
                  num6 = 0;
                  goto label_53;
                }
                else
                  goto label_53;
              }
              finally
              {
                int num7;
                if (enumerator == null)
                  num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 1 : 1;
                else
                  goto label_61;
label_60:
                switch (num7)
                {
                  case 1:
                  case 2:
                }
label_61:
                FilePreviewService.rO1VWFG1Gjl52MSQSK3B((object) enumerator);
                num7 = 2;
                goto label_60;
              }
            case 3:
label_51:
              enumerator = Directory.EnumerateFiles(path, (string) FilePreviewService.BKhpi1G1oUidIk0DJDr6(1304605005 ^ 1304617757), SearchOption.AllDirectories).GetEnumerator();
              num5 = 2;
              continue;
            case 4:
              try
              {
label_42:
                if (FilePreviewService.EVWRIeG1Qt5rsMjtGuqF((object) enumerator))
                  goto label_44;
                else
                  goto label_43;
label_41:
                int num8;
                switch (num8)
                {
                  case 1:
                    goto label_39;
                  case 2:
                    goto label_42;
                  default:
                    goto label_44;
                }
label_43:
                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 1 : 0;
                goto label_41;
label_44:
                FilePreviewService.BOA0GNG1fIMhhxMwdSjj((object) enumerator.Current, true);
                num8 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
                {
                  num8 = 2;
                  goto label_41;
                }
                else
                  goto label_41;
              }
              finally
              {
                int num9;
                if (enumerator == null)
                  num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
                else
                  goto label_49;
label_48:
                switch (num9)
                {
                  case 1:
                    break;
                  default:
                }
label_49:
                FilePreviewService.rO1VWFG1Gjl52MSQSK3B((object) enumerator);
                num9 = 2;
                goto label_48;
              }
            case 5:
label_38:
              enumerator = Directory.EnumerateDirectories(path, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088317048), SearchOption.AllDirectories).GetEnumerator();
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 4 : 3;
              continue;
            case 6:
              try
              {
                ZipOutputStream zipOutputStream3 = zipOutputStream2;
                string str1;
                if (!FilePreviewService.f6homMG1B9EdwKJ8qthw((object) file) || password == null)
                {
                  string str2 = password;
                  str1 = str2 == null ? fileEncryptPassword : str2;
                }
                else
                  str1 = this.UnionPasswords(fileEncryptPassword, password);
                FilePreviewService.gexp38G1WsksbV4vpGRl((object) zipOutputStream3, (object) str1);
                int num10 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0)
                  num10 = 0;
                int folderOffset;
                while (true)
                {
                  switch (num10)
                  {
                    case 1:
                      folderOffset = path.Length + (FilePreviewService.oZoRjOG1bJVlFGTO5q0X((object) path, FilePreviewService.BKhpi1G1oUidIk0DJDr6(-1290212282 ^ -644262414 ^ 1786881730)) ? 0 : 1);
                      num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_51;
                    default:
                      FilePreviewService.Ar0eXoG1hBMyXRENNSwm((object) path, (object) zipOutputStream2, folderOffset);
                      num10 = 2;
                      continue;
                  }
                }
              }
              finally
              {
                int num11;
                if (zipOutputStream2 == null)
                  num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 1 : 1;
                else
                  goto label_77;
label_74:
                switch (num11)
                {
                  case 1:
                  case 2:
                }
label_77:
                FilePreviewService.rO1VWFG1Gjl52MSQSK3B((object) zipOutputStream2);
                num11 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
                {
                  num11 = 2;
                  goto label_74;
                }
                else
                  goto label_74;
              }
            default:
              goto label_80;
          }
        }
label_80:
        try
        {
          FilePreviewService.zKMMAKG1vjabkxjPAFLV((object) baseOutputStream, 0L, SeekOrigin.Begin);
          int num12 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
            num12 = 0;
          while (true)
          {
            switch (num12)
            {
              case 1:
                goto label_75;
              default:
                FilePreviewService.SgWoHeG180vC2bXyNnHu((object) baseOutputStream, (object) fileStream);
                num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 1 : 1;
                continue;
            }
          }
label_75:
          return;
        }
        finally
        {
          int num13;
          if (fileStream == null)
            num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 1;
          else
            goto label_91;
label_89:
          switch (num13)
          {
            case 1:
            case 2:
          }
label_91:
          FilePreviewService.rO1VWFG1Gjl52MSQSK3B((object) fileStream);
          num13 = 2;
          goto label_89;
        }
      }
      finally
      {
        if (baseOutputStream != null)
        {
          int num14 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
            num14 = 0;
          while (true)
          {
            switch (num14)
            {
              case 1:
                goto label_100;
              default:
                FilePreviewService.rO1VWFG1Gjl52MSQSK3B((object) baseOutputStream);
                num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 1 : 1;
                continue;
            }
          }
        }
label_100:;
      }
label_71:
      return;
label_86:
      return;
label_115:
      throw new Exception(EleWise.ELMA.SR.T((string) FilePreviewService.BKhpi1G1oUidIk0DJDr6(1514961705 ^ 1515164127), (object) fileId));
    }

    /// <inheritdoc />
    public bool TryExtractFile(
      BinaryFile file,
      string path,
      Stream outputStream,
      string fileEncryptPassword,
      string password)
    {
      int num1 = 11;
      IFilePreviewCreator previewCreator;
      string str;
      ZipFile zipFile;
      while (true)
      {
        switch (num1)
        {
          case 1:
            zipFile = new ZipFile((FileStream) FilePreviewService.faqxuaG1SCvXaIrGAHaA((object) str, FileMode.Open, FileAccess.Read, FileShare.Read), false);
            num1 = 8;
            continue;
          case 2:
            goto label_31;
          case 3:
            if (FilePreviewService.f6homMG1B9EdwKJ8qthw((object) file))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 9 : 8;
              continue;
            }
            goto case 5;
          case 4:
          case 9:
            if (!FilePreviewService.djcAnVGPrHZDkPviXBUy((object) str))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 5:
            if (password != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 1 : 4;
              continue;
            }
            goto label_5;
          case 6:
            goto label_11;
          case 7:
            goto label_5;
          case 8:
            goto label_15;
          case 10:
            if (previewCreator == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 2;
              continue;
            }
            str = Path.ChangeExtension((string) FilePreviewService.E4ai5wG1F5uOoPssIWpI((object) previewCreator, (object) file), z2jc63fLkugS1X8Q9N.tE1kD1vbB(993438473 ^ 993511529));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 3 : 1;
            continue;
          case 11:
            previewCreator = this.GetPreviewCreator(file);
            num1 = 10;
            continue;
          default:
            if (FilePreviewService.ShiZKlGPz5VXeomuk8e4((object) str))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 1 : 1;
              continue;
            }
            goto label_5;
        }
      }
label_5:
      return false;
label_11:
      return false;
label_15:
      bool file1;
      try
      {
        FilePreviewService.jMA5m7G1iVkycrKLduAg((object) zipFile, !file.Encrypt || password == null ? (object) (password ?? fileEncryptPassword) : (object) this.UnionPasswords(fileEncryptPassword, password));
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
          num2 = 0;
        ZipEntry entry;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_12;
            case 2:
              goto label_11;
            case 3:
              file1 = true;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 1 : 1;
              continue;
            case 4:
              if (entry != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 5;
                continue;
              }
              goto label_11;
            case 5:
              FilePreviewService.SgWoHeG180vC2bXyNnHu(FilePreviewService.x8VLV6G1RhLmSKn5nTXP((object) zipFile, (object) entry), (object) outputStream);
              num2 = 3;
              continue;
            default:
              entry = zipFile.GetEntry(path);
              num2 = 4;
              continue;
          }
        }
      }
      finally
      {
        if (zipFile != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_28;
              default:
                FilePreviewService.rO1VWFG1Gjl52MSQSK3B((object) zipFile);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 1 : 1;
                continue;
            }
          }
        }
label_28:;
      }
label_12:
      return file1;
label_31:
      return false;
    }

    /// <summary>
    /// Получить полный путь до предпросмотра на сервере
    /// Если null, то нет превью
    /// </summary>
    /// <param name="file"></param>
    /// <returns></returns>
    public string GetPreviewPath(BinaryFile file)
    {
      int num1 = 2;
      string previewPath;
      while (true)
      {
        int num2 = num1;
        IFilePreviewCreator previewCreator;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (previewCreator != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 5 : 0;
                continue;
              }
              goto label_8;
            case 2:
              previewCreator = this.GetPreviewCreator(file);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 1;
              continue;
            case 3:
              goto label_6;
            case 4:
              goto label_8;
            case 5:
              previewPath = (string) FilePreviewService.fuI82TG1qYNhSqw3DcJw((object) previewCreator, (object) file);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        if (!FilePreviewService.ShiZKlGPz5VXeomuk8e4((object) previewPath))
          num1 = 3;
        else
          goto label_7;
      }
label_6:
      return (string) null;
label_7:
      return previewPath;
label_8:
      return (string) null;
    }

    /// <summary>Получить полный путь до текста предпросмотра</summary>
    /// <param name="file">Файл</param>
    /// <returns></returns>
    public string GetTextPreviewPath(BinaryFile file)
    {
      int num1 = 2;
      string textFileName;
      while (true)
      {
        int num2 = num1;
        IFilePreviewCreator previewCreator;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (previewCreator != null)
              {
                textFileName = previewCreator.GetTextFileName(file);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
                continue;
              }
              goto label_8;
            case 2:
              previewCreator = this.GetPreviewCreator(file);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 1 : 0;
              continue;
            case 3:
              goto label_9;
            case 4:
              goto label_3;
            default:
              if (!FilePreviewService.ShiZKlGPz5VXeomuk8e4((object) textFileName))
              {
                num2 = 4;
                continue;
              }
              goto label_4;
          }
        }
label_8:
        num1 = 3;
      }
label_3:
      return (string) null;
label_4:
      return textFileName;
label_9:
      return (string) null;
    }

    /// <summary>Получить размер текстового файла предпросмотра</summary>
    /// <param name="file">Файл</param>
    /// <returns></returns>
    public long GetTextPreviewSize(BinaryFile file)
    {
      int num = 4;
      IMultiFilePreviewCreator previewCreator;
      string textPreviewPath;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            if (File.Exists(textPreviewPath))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 0 : 0;
              continue;
            }
            goto label_10;
          case 3:
            if (previewCreator == null)
            {
              textPreviewPath = this.GetTextPreviewPath(file);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 2;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 1 : 1;
            continue;
          case 4:
            previewCreator = this.GetPreviewCreator(file) as IMultiFilePreviewCreator;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 3;
            continue;
          default:
            goto label_9;
        }
      }
label_2:
      return FilePreviewService.EBypVdG1KiKdtFBwXqSc((object) previewCreator, (object) file);
label_9:
      return FilePreviewService.uFSDujG1XOKBZ0BAOMKR((object) new FileInfo(textPreviewPath));
label_10:
      return 0;
    }

    /// <summary>Есть ли предпросмотр у файла</summary>
    /// <param name="file"></param>
    /// <returns></returns>
    public bool HasPreview(BinaryFile file) => this.HasPreview(file, 5L);

    /// <summary>Есть ли предпросмотр у файла</summary>
    /// <param name="file"></param>
    /// <param name="priority"></param>
    /// <returns></returns>
    public bool HasPreview(BinaryFile file, long priority)
    {
      int num1 = 2;
      IFilePreviewCreator previewCreator;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (previewCreator != null)
              {
                if (!FilePreviewService.WmRikEGPm5PP9XdU4PjX((object) previewCreator, (object) file))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
                  continue;
                }
                goto label_9;
              }
              else
                goto label_7;
            case 2:
              previewCreator = this.GetPreviewCreator(file);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_3;
            default:
              goto label_8;
          }
        }
label_7:
        num1 = 3;
      }
label_3:
      return false;
label_8:
      return false;
label_9:
      return previewCreator.HasPreview(file, priority);
    }

    /// <summary>Относительный путь до превью</summary>
    /// <param name="file"></param>
    /// <returns></returns>
    public string GetPreviewRelativePath(BinaryFile file)
    {
      int num = 10;
      string previewPath;
      string previewDirectory;
      while (true)
      {
        Guid uid;
        string input;
        object obj;
        switch (num)
        {
          case 1:
            previewPath = this.GetPreviewPath(file);
            num = 3;
            continue;
          case 2:
            obj = (object) uid.ToString();
            break;
          case 3:
            if (!FilePreviewService.djcAnVGPrHZDkPviXBUy((object) previewPath))
            {
              num = 5;
              continue;
            }
            goto label_13;
          case 4:
            goto label_4;
          case 5:
            goto label_14;
          case 6:
            obj = FilePreviewService.GnYjZgGPdHk6a8FQ4BJ2((object) file);
            break;
          case 7:
            previewDirectory = this.FolderPreviewService.GetPreviewDirectory(Guid.Parse(input));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 1 : 1;
            continue;
          case 8:
            goto label_13;
          case 9:
            if (FilePreviewService.Qbm57fGPJwKHI5E1FkDp(FilePreviewService.fMC50iGPM2Q9HrF2XCwB((object) file), Guid.Empty))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
              continue;
            }
            goto case 6;
          case 10:
            if (!FilePreviewService.djcAnVGPrHZDkPviXBUy((object) this.PreviewDir))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 1 : 9;
              continue;
            }
            goto label_4;
          default:
            uid = file.Uid;
            num = 2;
            continue;
        }
        input = (string) obj;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 7 : 4;
      }
label_4:
      return (string) null;
label_13:
      return (string) null;
label_14:
      return ((string) FilePreviewService.k5gYTTG1TgNwWep4F2Rp((object) previewPath, (object) previewDirectory, (object) "")).Substring(1);
    }

    /// <summary>Поддерживается ли предпросмотр для файла</summary>
    /// <param name="file"></param>
    /// <returns></returns>
    public bool IsSupportPreview(BinaryFile file) => this.GetPreviewCreator(file) != null;

    /// <inheritdoc />
    public bool CheckPassword(BinaryFile file, string password)
    {
      int num = 3;
      string str;
      while (true)
      {
        Guid guid;
        object obj;
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            obj = FilePreviewService.GnYjZgGPdHk6a8FQ4BJ2((object) file);
            break;
          case 3:
            if (!(FilePreviewService.fMC50iGPM2Q9HrF2XCwB((object) file) != Guid.Empty))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 2;
              continue;
            }
            guid = FilePreviewService.fMC50iGPM2Q9HrF2XCwB((object) file);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
            continue;
          default:
            obj = (object) guid.ToString();
            break;
        }
        str = (string) obj;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 1;
      }
label_6:
      return FilePreviewService.vgsgdqGPcbrdRSDpuISF((object) this.FilePreviewServiceProvider, (object) str, (object) password);
    }

    /// <inheritdoc />
    public bool CheckPassword(BinaryFile file, string fileEncryptPassword, string password)
    {
      int num = 3;
      string str;
      while (true)
      {
        Guid guid;
        object obj;
        switch (num)
        {
          case 1:
            obj = (object) guid.ToString();
            break;
          case 2:
            obj = FilePreviewService.GnYjZgGPdHk6a8FQ4BJ2((object) file);
            break;
          case 3:
            if (FilePreviewService.fMC50iGPM2Q9HrF2XCwB((object) file) != Guid.Empty)
            {
              guid = FilePreviewService.fMC50iGPM2Q9HrF2XCwB((object) file);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 1;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 2 : 1;
            continue;
          default:
            goto label_2;
        }
        str = (string) obj;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 0 : 0;
      }
label_2:
      return FilePreviewService.MAQS47G1kWIr0urpc10F((object) this.FilePreviewServiceProvider, (object) str, (object) fileEncryptPassword, (object) password);
    }

    private string GetEncryptFileName(IFilePreviewCreator creator, BinaryFile file) => (string) FilePreviewService.vxu9ElG1n0JmBuRtpS5H(FilePreviewService.fuI82TG1qYNhSqw3DcJw((object) creator, (object) file), FilePreviewService.BKhpi1G1oUidIk0DJDr6(-867826612 ^ -867735764));

    internal static bool qVMR7TGP7jUdwNnPZ9m1() => FilePreviewService.OmsEAWGPAmnaGfupbY8D == null;

    internal static FilePreviewService FYePciGPxXRC24HtGDLF() => FilePreviewService.OmsEAWGPAmnaGfupbY8D;

    internal static object QCkbsrGP0w0BgFiiPS5A([In] object obj0) => (object) ((IFolderPreviewService) obj0).PreviewsPath;

    internal static bool WmRikEGPm5PP9XdU4PjX([In] object obj0, [In] object obj1) => ((IFilePreviewCreator) obj0).IsAvaliable((BinaryFile) obj1);

    internal static object jtWg5wGPyCPx0SKZKQQ4([In] object obj0, [In] object obj1) => (object) ((IFilePreviewCreator) obj0).GetPreviewText((BinaryFile) obj1);

    internal static Guid fMC50iGPM2Q9HrF2XCwB([In] object obj0) => ((BinaryFile) obj0).Uid;

    internal static bool Qbm57fGPJwKHI5E1FkDp([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static void mibgxiGP9YmGkNoNfFDS([In] object obj0, [In] object obj1, long priority) => ((IFilePreviewServiceProvider) obj0).AddFileToQueue((string) obj1, priority);

    internal static object GnYjZgGPdHk6a8FQ4BJ2([In] object obj0) => (object) ((BinaryFile) obj0).Id;

    internal static PreviewWorkStatus my57aMGPlNTfP6Xcjdh0([In] object obj0, [In] object obj1) => ((IFilePreviewServiceProvider) obj0).GetFilePreviewWorkStatus((string) obj1);

    internal static bool djcAnVGPrHZDkPviXBUy([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static bool DB0jVtGPg6wZpXBYYSPb([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static Guid iJungfGP5ZHubUWWyCZ8([In] object obj0) => Guid.Parse((string) obj0);

    internal static object bBEBZuGPjFvb5VJKFToy([In] object obj0, Guid id) => (object) ((IFolderPreviewService) obj0).GetPreviewDirectory(id);

    internal static void Lugm43GPYJOmE7mqQBuV([In] object obj0) => ExecuteHelper.InvokeSafe((System.Action) obj0);

    internal static object cmCQjvGPLfD5ZfYwXqe9([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static bool vROGZ8GPUKf24TbpsiEg([In] object obj0) => Directory.Exists((string) obj0);

    internal static object zo99LPGPsdXhlZrZWPXn([In] object obj0) => (object) Directory.CreateDirectory((string) obj0);

    internal static bool vgsgdqGPcbrdRSDpuISF([In] object obj0, [In] object obj1, [In] object obj2) => ((IFilePreviewServiceProvider) obj0).CheckPassword((string) obj1, (string) obj2);

    internal static bool ShiZKlGPz5VXeomuk8e4([In] object obj0) => File.Exists((string) obj0);

    internal static object E4ai5wG1F5uOoPssIWpI([In] object obj0, [In] object obj1) => (object) ((IFilePreviewCreator) obj0).GetTextFileName((BinaryFile) obj1);

    internal static bool f6homMG1B9EdwKJ8qthw([In] object obj0) => ((BinaryFile) obj0).Encrypt;

    internal static void gexp38G1WsksbV4vpGRl([In] object obj0, [In] object obj1) => ((DeflaterOutputStream) obj0).Password = (string) obj1;

    internal static object BKhpi1G1oUidIk0DJDr6(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool oZoRjOG1bJVlFGTO5q0X([In] object obj0, [In] object obj1) => ((string) obj0).EndsWith((string) obj1);

    internal static void Ar0eXoG1hBMyXRENNSwm([In] object obj0, [In] object obj1, int folderOffset) => FileUtils.CompressFolder((string) obj0, (ZipOutputStream) obj1, folderOffset);

    internal static void rO1VWFG1Gjl52MSQSK3B([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void eSenYCG1ELhJZ0ATJ0xs([In] object obj0) => File.Delete((string) obj0);

    internal static void BOA0GNG1fIMhhxMwdSjj([In] object obj0, [In] bool obj1) => Directory.Delete((string) obj0, obj1);

    internal static bool EVWRIeG1Qt5rsMjtGuqF([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static object f9fRsMG1C5nkgMkx7f72([In] object obj0) => (object) File.Create((string) obj0);

    internal static long zKMMAKG1vjabkxjPAFLV([In] object obj0, [In] long obj1, [In] SeekOrigin obj2) => ((Stream) obj0).Seek(obj1, obj2);

    internal static void SgWoHeG180vC2bXyNnHu([In] object obj0, [In] object obj1) => ((Stream) obj0).CopyTo((Stream) obj1);

    internal static object OXOXKnG1Zt80usxi0Q1p([In] object obj0, [In] object obj1) => (object) ((IEventHandlerSubscribeService) obj0).Subscribe((IEventHandler) obj1);

    internal static void TL1irMG1ueSnQ873k5Le([In] object obj0, [In] object obj1, long priority) => ((FilePreviewService) obj0).AddPreviewWork((BinaryFile) obj1, priority);

    internal static object MI6UmwG1IfZRPe7T9Vdp([In] object obj0) => (object) ((FilePreviewService.FilePreviewEventHandler) obj0).Wait;

    internal static TaskAwaiter Phy6OaG1V0BASVOZM5OL([In] object obj0) => ((Task) obj0).GetAwaiter();

    internal static object faqxuaG1SCvXaIrGAHaA(
      [In] object obj0,
      [In] FileMode obj1,
      [In] FileAccess obj2,
      [In] FileShare obj3)
    {
      return (object) File.Open((string) obj0, obj1, obj2, obj3);
    }

    internal static void jMA5m7G1iVkycrKLduAg([In] object obj0, [In] object obj1) => ((ZipFile) obj0).Password = (string) obj1;

    internal static object x8VLV6G1RhLmSKn5nTXP([In] object obj0, [In] object obj1) => (object) ((ZipFile) obj0).GetInputStream((ZipEntry) obj1);

    internal static object fuI82TG1qYNhSqw3DcJw([In] object obj0, [In] object obj1) => (object) ((IFilePreviewCreator) obj0).GetMainFileName((BinaryFile) obj1);

    internal static long EBypVdG1KiKdtFBwXqSc([In] object obj0, [In] object obj1) => ((IMultiFilePreviewCreator) obj0).GetTextPreviewFilesSize((BinaryFile) obj1);

    internal static long uFSDujG1XOKBZ0BAOMKR([In] object obj0) => ((FileInfo) obj0).Length;

    internal static object k5gYTTG1TgNwWep4F2Rp([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static bool MAQS47G1kWIr0urpc10F([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((IFilePreviewServiceProvider) obj0).CheckPassword((string) obj1, (string) obj2, (string) obj3);

    internal static object vxu9ElG1n0JmBuRtpS5H([In] object obj0, [In] object obj1) => (object) Path.ChangeExtension((string) obj0, (string) obj1);

    /// <summary>Обработчик события генерации предпросмотра</summary>
    private sealed class FilePreviewEventHandler : IFilePreviewEventHandler, IEventHandler
    {
      private readonly object fileId;
      private readonly TaskCompletionSource<bool> taskCompletionSource;
      internal static object rcYSkqvzHsPLUjFUJtND;

      /// <summary>Ctor</summary>
      /// <param name="fileId">Идентификатор файла</param>
      public FilePreviewEventHandler(string fileId)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        this.taskCompletionSource = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
          num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              this.fileId = (object) fileId;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_3:
        return;
label_5:;
      }

      /// <summary>Задача ожидания</summary>
      public Task Wait => (Task) this.taskCompletionSource.Task;

      /// <inheritdoc />
      public Task Complete(string fileId, Exception exception = null)
      {
        int num1 = 6;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
              case 3:
                goto label_9;
              case 2:
                this.taskCompletionSource.SetResult(true);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
                continue;
              case 4:
                if (exception != null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 1 : 1;
                  continue;
                }
                goto case 2;
              case 6:
                if (!FilePreviewService.FilePreviewEventHandler.km8fkpvzx32sRLC8D3HL(this.fileId, (object) fileId, StringComparison.InvariantCultureIgnoreCase))
                {
                  num2 = 5;
                  continue;
                }
                goto case 4;
              default:
                goto label_3;
            }
          }
label_9:
          this.taskCompletionSource.SetException(exception);
          num1 = 7;
        }
label_3:
        return Task.CompletedTask;
      }

      internal static bool BWMcnZvzAu1EVf408syF() => FilePreviewService.FilePreviewEventHandler.rcYSkqvzHsPLUjFUJtND == null;

      internal static FilePreviewService.FilePreviewEventHandler j0f9unvz7EpyF7DVJlAn() => (FilePreviewService.FilePreviewEventHandler) FilePreviewService.FilePreviewEventHandler.rcYSkqvzHsPLUjFUJtND;

      internal static bool km8fkpvzx32sRLC8D3HL([In] object obj0, [In] object obj1, [In] StringComparison obj2) => ((string) obj0).Equals((string) obj1, obj2);
    }
  }
}
