// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.Previews.FolderPreviewService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace EleWise.ELMA.Files.Previews
{
  /// <summary>Сервис для работы с папкой предпросмотра файлов</summary>
  [Service]
  internal class FolderPreviewService : IFolderPreviewService
  {
    /// <summary>Интерфейс для менеджера файлов</summary>
    private IFileManager fileManager;
    internal static FolderPreviewService wfuOgPGOJTaEyhf5fyfH;

    /// <summary>Интерфейс для менеджера файлов</summary>
    public IFileManager FileManager
    {
      get
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.fileManager = Locator.GetServiceNotNull<IFileManager>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 0 : 0;
              continue;
            case 2:
              if (this.fileManager == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 1 : 0;
                continue;
              }
              goto label_5;
            default:
              goto label_5;
          }
        }
label_5:
        return this.fileManager;
      }
    }

    /// <summary>Запущенное приложение</summary>
    public IRuntimeApplication RuntimeApplication
    {
      get => this.\u003CRuntimeApplication\u003Ek__BackingField;
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
              this.\u003CRuntimeApplication\u003Ek__BackingField = value;
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
    }

    /// <summary>Путь к корневой папке с предпросмотрами</summary>
    public string PreviewsPath
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.RuntimeApplication != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            case 2:
              this.DirectoryCreated = true;
              num = 5;
              continue;
            case 3:
              FolderPreviewService.pnxtNDGOrUPxBXwS0x0Q((object) this.FileManager.PreviewsPath);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 2 : 2;
              continue;
            case 4:
              goto label_3;
            case 5:
              goto label_2;
            default:
              if (FolderPreviewService.CWT1hEGOln2cS5OpAiqB((object) this.RuntimeApplication) != null)
              {
                if (!this.DirectoryCreated)
                {
                  num = 3;
                  continue;
                }
                goto label_2;
              }
              else
              {
                num = 4;
                continue;
              }
          }
        }
label_2:
        return (string) FolderPreviewService.K8xPFEGOgROKBeAnCpdU((object) this.FileManager);
label_3:
        return string.Empty;
      }
    }

    /// <summary>Создана директория с превью</summary>
    private bool DirectoryCreated
    {
      get => this.\u003CDirectoryCreated\u003Ek__BackingField;
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
              this.\u003CDirectoryCreated\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
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

    /// <summary>Собрать путь к папке с предпросмотром для документа</summary>
    /// <param name="id">Uid документа</param>
    public string GetPreviewDirectory(Guid id)
    {
      int num = 4;
      string pathPreviewByHash;
      while (true)
      {
        switch (num)
        {
          case 1:
            FolderPreviewService.pnxtNDGOrUPxBXwS0x0Q((object) pathPreviewByHash);
            num = 5;
            continue;
          case 2:
            if (FolderPreviewService.GKX7lgGOjWFhlKe67gBA((object) pathPreviewByHash))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
              continue;
            }
            goto case 1;
          case 3:
            pathPreviewByHash = this.GetPathPreviewByHash(this.PreviewsPath, id);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 2;
            continue;
          case 4:
            Contract.CheckWithMessage<InvalidOperationException>(FolderPreviewService.xkg13UGO504U0C2imarU(id, Guid.Empty), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138201920));
            num = 3;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return pathPreviewByHash;
    }

    private string GetPathPreviewByHash(string pathRoot, Guid guid)
    {
      int num1 = 2;
      SHA1 shA1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            shA1 = SHA1.Create();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 1 : 0;
            continue;
          default:
            goto label_11;
        }
      }
label_2:
      byte[] byteArray;
      try
      {
        byteArray = (byte[]) FolderPreviewService.CnqjLYGOYyFj7P9TcX0m((object) shA1, (object) guid.ToByteArray());
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        if (shA1 != null)
        {
          int num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                FolderPreviewService.MuXGgQGOLwyYOvpqo2iB((object) shA1);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
                continue;
              default:
                goto label_10;
            }
          }
        }
label_10:;
      }
label_11:
      return Path.Combine(this.GetPathPreview(pathRoot, byteArray), guid.ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979453360)));
    }

    private string GetPathPreview(string pathRoot, byte[] byteArray) => (string) FolderPreviewService.hp2yZXGOUeKp7ELfrKK2(FolderPreviewService.hp2yZXGOUeKp7ELfrKK2(FolderPreviewService.hp2yZXGOUeKp7ELfrKK2(FolderPreviewService.hp2yZXGOUeKp7ELfrKK2((object) pathRoot, (object) this.GetLevel(byteArray, 0, 1)), (object) this.GetLevel(byteArray, 1, 1)), (object) this.GetLevel(byteArray, 2, 1)), (object) this.GetLevel(byteArray, 3, 1));

    private string GetLevel(byte[] hash, int v1, int v2) => (string) FolderPreviewService.tWWQecGOcVkWG30FFZrR(FolderPreviewService.jUgSWSGOslBYxJ6sVBZq((object) hash, v1, v2), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852834712), (object) "");

    public FolderPreviewService()
    {
      FolderPreviewService.q9d100GOz8kMNymsROAc();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool sSvUg0GO9SMRCpqkeVgQ() => FolderPreviewService.wfuOgPGOJTaEyhf5fyfH == null;

    internal static FolderPreviewService rG1ktWGOdTgC4G3nqMO3() => FolderPreviewService.wfuOgPGOJTaEyhf5fyfH;

    internal static object CWT1hEGOln2cS5OpAiqB([In] object obj0) => (object) ((IRuntimeApplication) obj0).Configuration;

    internal static object pnxtNDGOrUPxBXwS0x0Q([In] object obj0) => (object) Directory.CreateDirectory((string) obj0);

    internal static object K8xPFEGOgROKBeAnCpdU([In] object obj0) => (object) ((IFileManager) obj0).PreviewsPath;

    internal static bool xkg13UGO504U0C2imarU([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static bool GKX7lgGOjWFhlKe67gBA([In] object obj0) => Directory.Exists((string) obj0);

    internal static object CnqjLYGOYyFj7P9TcX0m([In] object obj0, [In] object obj1) => (object) ((HashAlgorithm) obj0).ComputeHash((byte[]) obj1);

    internal static void MuXGgQGOLwyYOvpqo2iB([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object hp2yZXGOUeKp7ELfrKK2([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static object jUgSWSGOslBYxJ6sVBZq([In] object obj0, [In] int obj1, [In] int obj2) => (object) BitConverter.ToString((byte[]) obj0, obj1, obj2);

    internal static object tWWQecGOcVkWG30FFZrR([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static void q9d100GOz8kMNymsROAc() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
