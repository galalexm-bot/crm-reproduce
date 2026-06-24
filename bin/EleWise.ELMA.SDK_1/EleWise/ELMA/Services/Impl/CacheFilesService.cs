// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.Impl.CacheFilesService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace EleWise.ELMA.Services.Impl
{
  /// <summary>Сервис для работы с временными файлами</summary>
  [Service]
  internal class CacheFilesService : IStructuredFileService, ICacheFilesService, IInitHandler
  {
    private static IAuthenticationService authenticationService;
    private string cacheFilesDirectory;
    private ICacheService cacheService;
    private ILogger logger;
    private FileSystemWatcher watcher;
    private static CacheFilesService vAphfdByFiFvMlMtDAh9;

    /// <summary>Сервис архивации/разархивации</summary>
    public IZipService ZipService
    {
      get => this.\u003CZipService\u003Ek__BackingField;
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
              this.\u003CZipService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 0;
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

    /// <inheritdoc />
    Guid IStructuredFileService.Create(StructuredFileFolder structuredFileFolder)
    {
      int num1 = 1;
      Guid uid;
      string str1;
      string str2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            CacheFilesService.IDovjHBybiOL2BHBlccv((object) structuredFileFolder, CacheFilesService.AJJ6D4ByofIIYeCCNkVe(-630932142 - 1120244082 ^ -1751234348));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            uid = CacheFilesService.pIAir7ByEsx8PcN2lspU((object) this, (object) str2);
            num1 = 4;
            continue;
          case 4:
            str1 = Path.Combine(this.CacheFilesDir, uid.ToString());
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 5 : 4;
            continue;
          case 5:
            goto label_3;
          case 6:
            str2 = (string) CacheFilesService.DBPk8UByG1SZQctnQYw9((object) structuredFileFolder.Name, CacheFilesService.AJJ6D4ByofIIYeCCNkVe(-740338220 ^ -740411724));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 3 : 3;
            continue;
          default:
            CacheFilesService.CPA9R9Byhm7v9oVKbAUc((object) structuredFileFolder.Name, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939406516));
            num1 = 6;
            continue;
        }
      }
label_2:
      return uid;
label_3:
      try
      {
        this.CreateStructuredFolder(structuredFileFolder, str1);
        int num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
          num2 = 1;
        Exception exception;
        string path;
        FileStream inputStream;
        while (true)
        {
          switch (num2)
          {
            case 1:
              path = (string) CacheFilesService.cuCqK1ByflxIQ6NyjqBC((object) str1, (object) str2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 3 : 4;
              continue;
            case 2:
              if (exception != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
                continue;
              }
              inputStream = new FileStream(path, FileMode.Open);
              num2 = 5;
              continue;
            case 3:
              goto label_2;
            case 4:
              exception = (Exception) CacheFilesService.akFwesByCtfnO0Iv4ZHS((object) this.ZipService, (object) path, (object) Path.Combine(str1, (string) CacheFilesService.eNBE3IByQeLFjTv47uEe((object) structuredFileFolder)));
              num2 = 2;
              continue;
            case 5:
              goto label_12;
            default:
              goto label_10;
          }
        }
label_10:
        throw exception;
label_12:
        try
        {
          this.AppendCacheFile(uid, (Stream) inputStream);
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
            num3 = 0;
          switch (num3)
          {
            default:
              goto label_2;
          }
        }
        finally
        {
          int num4;
          if (inputStream == null)
            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
          else
            goto label_18;
label_17:
          switch (num4)
          {
            case 1:
              break;
            default:
          }
label_18:
          CacheFilesService.gkZTvFByvjPDSGPIT9Kw((object) inputStream);
          num4 = 2;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
          {
            num4 = 2;
            goto label_17;
          }
          else
            goto label_17;
        }
      }
      catch (Exception ex)
      {
        int num5 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0)
          num5 = 0;
        while (true)
        {
          switch (num5)
          {
            case 1:
              CacheFilesService.Pp27sJBy8KNKfadcO3AM((object) this.Logger, (object) EleWise.ELMA.SR.T((string) CacheFilesService.AJJ6D4ByofIIYeCCNkVe(1470440286 ^ 1470382130), CacheFilesService.eNBE3IByQeLFjTv47uEe((object) structuredFileFolder)), (object) ex);
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 0;
              continue;
            default:
              goto label_25;
          }
        }
label_25:
        throw ex;
      }
      finally
      {
        CacheFilesService.FbwtyjByZisrujCigLCi((object) str1, true);
        int num6 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
          num6 = 0;
        switch (num6)
        {
          default:
        }
      }
    }

    private void CreateStructuredFolder(StructuredFileFolder structuredFile, string parentDirectory)
    {
      int num1 = 4;
      CacheFilesService cacheFilesService;
      string currentDirectory;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (!CacheFilesService.K586s4ByuNLZFNKW6iwd((object) currentDirectory))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 0 : 0;
              continue;
            }
            goto label_16;
          case 2:
            List<StructuredFileFolder> folders = structuredFile.Folders;
            if (folders == null)
            {
              num1 = 9;
              continue;
            }
            folders.ForEach((Action<StructuredFileFolder>) (folder =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    cacheFilesService.CreateStructuredFolder(folder, currentDirectory);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = 7;
            continue;
          case 3:
            cacheFilesService = this;
            num1 = 11;
            continue;
          case 4:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 1 : 3;
            continue;
          case 5:
            goto label_8;
          case 6:
            goto label_14;
          case 7:
          case 9:
            List<StructuredFileFile> files = structuredFile.Files;
            if (files == null)
            {
              num1 = 6;
              continue;
            }
            files.ForEach((Action<StructuredFileFile>) (file =>
            {
              int num3 = 5;
              while (true)
              {
                int num4 = num3;
                string filePath;
                string destFileName;
                while (true)
                {
                  switch (num4)
                  {
                    case 0:
                      goto label_7;
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      if (!CacheFilesService.\u003C\u003Ec__DisplayClass5_0.e5jvjvQO1pEfA6Stf3wk((object) filePath))
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
                        continue;
                      }
                      goto case 2;
                    case 2:
                      // ISSUE: reference to a compiler-generated method
                      if (!CacheFilesService.\u003C\u003Ec__DisplayClass5_0.e5jvjvQO1pEfA6Stf3wk((object) destFileName))
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 6 : 3;
                        continue;
                      }
                      goto label_3;
                    case 3:
                      goto label_12;
                    case 4:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      destFileName = (string) CacheFilesService.\u003C\u003Ec__DisplayClass5_0.vVMMXiQOPaigHlppg9lr((object) currentDirectory, CacheFilesService.\u003C\u003Ec__DisplayClass5_0.G6PSLcQOefK02C2REtyB((object) cacheFilesService, CacheFilesService.\u003C\u003Ec__DisplayClass5_0.GhJ4ghQO2An5ZrOiNLCY((object) file)));
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 1 : 1;
                      continue;
                    case 5:
                      goto label_5;
                    case 6:
                      File.Copy(filePath, destFileName);
                      num4 = 3;
                      continue;
                    default:
                      goto label_13;
                  }
                }
label_5:
                filePath = cacheFilesService.GetTempFileInfo(file.Uid).FilePath;
                num3 = 4;
              }
label_7:
              return;
label_12:
              return;
label_13:
              return;
label_3:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 5 : 0;
            continue;
          case 8:
            goto label_4;
          case 10:
            goto label_18;
          case 11:
            if (structuredFile != null)
            {
              currentDirectory = (string) CacheFilesService.cuCqK1ByflxIQ6NyjqBC((object) parentDirectory, CacheFilesService.eNBE3IByQeLFjTv47uEe((object) structuredFile));
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 1 : 0;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 8 : 4;
            continue;
          default:
            CacheFilesService.wPX301ByIuql4vat9OJU((object) currentDirectory);
            num1 = 2;
            continue;
        }
      }
label_8:
      return;
label_14:
      return;
label_4:
      return;
label_18:
      return;
label_16:;
    }

    public ICacheService Cache
    {
      get
      {
        int num = 2;
        ICacheService serviceNotNull;
        ICacheService cacheService;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.cacheService = serviceNotNull = Locator.GetServiceNotNull<ICacheService>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
              continue;
            case 2:
              cacheService = this.cacheService;
              if (cacheService == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 1;
                continue;
              }
              goto label_2;
            default:
              goto label_6;
          }
        }
label_2:
        return cacheService;
label_6:
        return serviceNotNull;
      }
    }

    private ILogger Logger
    {
      get
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_4;
            case 2:
              this.logger = (ILogger) CacheFilesService.PpJoLYByVQ7P9wa9d5bx(CacheFilesService.AJJ6D4ByofIIYeCCNkVe(272623989 ^ 272534205));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
              continue;
            case 3:
              if (this.logger == null)
              {
                num = 2;
                continue;
              }
              goto label_4;
            default:
              CacheFilesService.nWYheUBySKuXqtQRRxul((object) this.logger, (object) new EventHandler(this.OnConfigurationChanged));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 1 : 1;
              continue;
          }
        }
label_4:
        return this.logger;
      }
    }

    private static IAuthenticationService AuthenticationService
    {
      get
      {
        int num = 1;
        IAuthenticationService authenticationService;
        while (true)
        {
          switch (num)
          {
            case 1:
              authenticationService = CacheFilesService.authenticationService;
              if (authenticationService == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return authenticationService;
label_5:
        return CacheFilesService.authenticationService = Locator.GetService<IAuthenticationService>();
      }
    }

    private string CurrentUser
    {
      get
      {
        int num = 1;
        IUser user;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (CacheFilesService.Lkj7OhByiyt5C7FvD6pF((object) this.Logger))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 2:
              goto label_10;
            case 3:
              goto label_7;
            case 4:
              goto label_12;
            case 5:
              goto label_4;
            case 6:
              if (user != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 2 : 4;
                continue;
              }
              goto label_7;
            default:
              if (CacheFilesService.gZ32bBByRiSbvBFD1BIk() == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 2 : 1;
                continue;
              }
              user = (IUser) CacheFilesService.ygjytAByqXr8X3jWNUu7(CacheFilesService.gZ32bBByRiSbvBFD1BIk());
              num = 6;
              continue;
          }
        }
label_4:
        return (string) null;
label_7:
        object obj1 = (object) null;
        goto label_13;
label_10:
        return (string) CacheFilesService.AJJ6D4ByofIIYeCCNkVe(1470998129 - 231418599 ^ 1239552990);
label_12:
        obj1 = CacheFilesService.pJWsntByKqnNQTBVXDni((object) user);
label_13:
        object obj2 = CacheFilesService.AJJ6D4ByofIIYeCCNkVe(1994213607 >> 4 ^ 124632282);
        return (string) obj1 + (string) obj2;
      }
    }

    /// <summary>Папка для хранения временных файлов</summary>
    private string CacheFilesDir => this.cacheFilesDirectory;

    private string GetFilePathPrivate(Guid uid, string originalFileName)
    {
      int num = 2;
      string str1;
      while (true)
      {
        string str2;
        switch (num)
        {
          case 1:
            if (CacheFilesService.HqQH7EByX9ADbPJ5AJv9((object) originalFileName))
            {
              num = 5;
              continue;
            }
            str2 = Path.GetExtension(originalFileName.ReplaceInvalidFileNameChars());
            break;
          case 2:
            this.EnsureCacheDirectory();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 1 : 0;
            continue;
          case 3:
            str1 = (string) CacheFilesService.AJJ6D4ByofIIYeCCNkVe(1642859704 ^ 1642950510);
            num = 4;
            continue;
          case 4:
          case 6:
            goto label_4;
          case 5:
            str2 = (string) null;
            break;
          default:
            if (!CacheFilesService.HqQH7EByX9ADbPJ5AJv9((object) str1))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 1 : 6;
              continue;
            }
            goto case 3;
        }
        str1 = str2;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
      }
label_4:
      return (string) CacheFilesService.cuCqK1ByflxIQ6NyjqBC((object) this.CacheFilesDir, CacheFilesService.MEqmD0ByT5SM9vHJKUs5((object) uid, (object) str1));
    }

    private static string GetKey(Guid key) => (string) CacheFilesService.OdC8miByk1Z1WEn8qH9s(CacheFilesService.AJJ6D4ByofIIYeCCNkVe(-2112703338 ^ -2112628876), CacheFilesService.AJJ6D4ByofIIYeCCNkVe(1304605005 ^ 1304679097), (object) key);

    private void RemoveCacheDirectory()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            CacheFilesService.Wu9jvdBynIkjUjbYTX7M((object) this.CacheFilesDir);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    private void EnsureCacheDirectory()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            CacheFilesService.wPX301ByIuql4vat9OJU((object) this.CacheFilesDir);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
            continue;
          case 3:
            if (!CacheFilesService.K586s4ByuNLZFNKW6iwd((object) this.CacheFilesDir))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 2;
              continue;
            }
            break;
          case 4:
            this.OnConfigurationChanged((object) this, EventArgs.Empty);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 1 : 1;
            continue;
        }
        CacheFilesService.vBeLg9ByOrLD4JKYdlek((object) this.CacheFilesDir);
        num = 4;
      }
label_2:;
    }

    private void OnConfigurationChanged(object sender, EventArgs eventArgs)
    {
      int num1 = 8;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              CacheFilesService.RKKvlAByeP3QOXVt0QBn((object) this.watcher, (object) new FileSystemEventHandler(this.CacheFilesWatcher));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 4 : 11;
              continue;
            case 2:
              goto label_17;
            case 3:
              if (this.Logger.IsEnabled(EleWise.ELMA.Logging.LogLevel.Information))
              {
                num2 = 6;
                continue;
              }
              goto default;
            case 4:
              goto label_8;
            case 5:
              FileSystemWatcher fileSystemWatcher = new FileSystemWatcher(this.CacheFilesDir);
              fileSystemWatcher.IncludeSubdirectories = false;
              CacheFilesService.j3iWu9By2lwEMqIgrN7S((object) fileSystemWatcher, true);
              fileSystemWatcher.NotifyFilter = NotifyFilters.FileName;
              this.watcher = fileSystemWatcher;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 1 : 1;
              continue;
            case 6:
              if (!CacheFilesService.K586s4ByuNLZFNKW6iwd((object) this.CacheFilesDir))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
                continue;
              }
              goto case 5;
            case 8:
              if (this.watcher != null)
              {
                num2 = 7;
                continue;
              }
              goto case 3;
            case 9:
              CacheFilesService.j3iWu9By2lwEMqIgrN7S((object) this.watcher, CacheFilesService.Jj1VoGBy1tfo6yMm6QA0((object) this.Logger, EleWise.ELMA.Logging.LogLevel.Information));
              num2 = 10;
              continue;
            case 10:
              goto label_14;
            case 11:
              CacheFilesService.sIMxdwByPndBFTT8RYLH((object) this.watcher, (object) new FileSystemEventHandler(this.CacheFilesWatcher));
              num2 = 2;
              continue;
            default:
              if (this.watcher != null)
                goto case 9;
              else
                goto label_10;
          }
        }
label_10:
        num1 = 4;
      }
label_17:
      return;
label_8:
      return;
label_14:;
    }

    private void CacheFilesWatcher(object sender, FileSystemEventArgs e)
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        WatcherChangeTypes watcherChangeTypes;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_10;
            case 1:
              if (watcherChangeTypes == WatcherChangeTypes.Created)
              {
                this.Logger.LogFormat(EleWise.ELMA.Logging.LogLevel.Information, (string) CacheFilesService.AJJ6D4ByofIIYeCCNkVe(-882126494 ^ -882199292), CacheFilesService.W1FlbEBy3OaVCJFY8Nlq((object) e));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 5 : 5;
                continue;
              }
              goto label_5;
            case 2:
              watcherChangeTypes = CacheFilesService.A5VNgTByNyXcKqNLKgjk((object) e);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 1 : 0;
              continue;
            case 3:
              goto label_3;
            case 4:
              if (watcherChangeTypes != WatcherChangeTypes.Deleted)
              {
                num2 = 3;
                continue;
              }
              this.Logger.LogFormat(EleWise.ELMA.Logging.LogLevel.Information, (string) CacheFilesService.AJJ6D4ByofIIYeCCNkVe(1917998801 >> 2 ^ 479588670), CacheFilesService.W1FlbEBy3OaVCJFY8Nlq((object) e));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
              continue;
            case 5:
              goto label_8;
            default:
              goto label_13;
          }
        }
label_5:
        num1 = 4;
      }
label_10:
      return;
label_3:
      return;
label_8:
      return;
label_13:;
    }

    public virtual bool DeleteByUid(Guid uid)
    {
      int num1 = 15;
      bool flag;
      while (true)
      {
        int num2 = num1;
        string str;
        int index;
        string[] strArray;
        string key;
        while (true)
        {
          switch (num2)
          {
            case 1:
              flag = true;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 2 : 4;
              continue;
            case 2:
              index = 0;
              num2 = 16;
              continue;
            case 3:
              if (!CacheFilesService.tlxuMqBythdwFhR1dTPI((object) this.Cache, (object) key, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1251470110 >> 2 ^ 312777011)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 12;
                continue;
              }
              goto case 6;
            case 4:
            case 12:
              if (flag)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 9 : 9;
                continue;
              }
              goto label_6;
            case 5:
              flag = true;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
              continue;
            case 6:
              this.Cache.Remove(key, (string) CacheFilesService.AJJ6D4ByofIIYeCCNkVe(-1710575414 ^ -1710501058));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 1 : 0;
              continue;
            case 7:
              this.Logger.InfoFormat((string) CacheFilesService.AJJ6D4ByofIIYeCCNkVe(-1872275253 >> 6 ^ -29296171), (object) str);
              num2 = 17;
              continue;
            case 8:
            case 16:
              if (index >= strArray.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 3 : 0;
                continue;
              }
              goto case 13;
            case 9:
              this.Logger.DebugFormat((string) CacheFilesService.AJJ6D4ByofIIYeCCNkVe(87862435 ^ 87935103), (object) this.CurrentUser, (object) uid);
              num2 = 11;
              continue;
            case 10:
              goto label_11;
            case 11:
              goto label_6;
            case 13:
              str = strArray[index];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 7 : 7;
              continue;
            case 14:
              flag = false;
              num2 = 10;
              continue;
            case 15:
              key = (string) CacheFilesService.ipK3aeBypticGKf8sGIC(uid);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 14 : 13;
              continue;
            case 17:
              CacheFilesService.tPM6Y4ByD5ObDCmdoDoH((object) str);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 5 : 4;
              continue;
            default:
              goto label_20;
          }
        }
label_11:
        strArray = (string[]) CacheFilesService.bWF3HXByaUfWR8dxoqDw((object) this.CacheFilesDir, (object) (uid.ToString() + CacheFilesService.AJJ6D4ByofIIYeCCNkVe(-1876063057 ^ -1876105215)));
        num1 = 2;
        continue;
label_20:
        ++index;
        num1 = 8;
      }
label_6:
      return flag;
    }

    public virtual Guid CreateCacheFile(string fileName)
    {
      int num = 2;
      Guid uid;
      CacheFilesService.TempFileInfo tempFileInfo;
      while (true)
      {
        switch (num)
        {
          case 1:
            tempFileInfo = new CacheFilesService.TempFileInfo()
            {
              FileName = fileName,
              FilePath = this.GetFilePathPrivate(uid, fileName)
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
            continue;
          case 2:
            uid = CacheFilesService.dO6wkdBywZeR9u8rJbgC();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_2;
          default:
            if (!this.AddValue(uid, tempFileInfo))
            {
              num = 3;
              continue;
            }
            goto label_3;
        }
      }
label_2:
      return Guid.Empty;
label_3:
      return uid;
    }

    private bool AddValue(Guid uid, CacheFilesService.TempFileInfo value, bool needSaveName = true)
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        FileInfo fileInfo;
        while (true)
        {
          switch (num2)
          {
            case 1:
              CacheFilesService.hT8XtLByHYurNgshAqZM((object) fileInfo, CacheFilesService.qghom1ByAk0KBvJ1IQcC());
              num2 = 8;
              continue;
            case 2:
              if (needSaveName)
              {
                num2 = 11;
                continue;
              }
              goto case 10;
            case 3:
              this.Cache.Insert<CacheFilesService.TempFileInfo>((string) CacheFilesService.ipK3aeBypticGKf8sGIC(uid), value, (string) CacheFilesService.AJJ6D4ByofIIYeCCNkVe(~1767720452 ^ -1767646705), FileCleaner.cacheDuration);
              num2 = 2;
              continue;
            case 4:
            case 9:
              fileInfo = new FileInfo(value.FilePath + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35937031));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 1 : 13;
              continue;
            case 5:
            case 6:
            case 8:
              this.Logger.DebugFormat((string) CacheFilesService.AJJ6D4ByofIIYeCCNkVe(-1120607109 - 305487170 ^ -1426136575), (object) this.CurrentUser, (object) value.FileName, (object) uid, (object) value.FilePath);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 2 : 7;
              continue;
            case 7:
              goto label_11;
            case 10:
              fileInfo = new FileInfo(value.FilePath);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
              continue;
            case 11:
              CacheFilesService.BvJrdQBy4NfBFYw2jTk4((object) (value.FilePath + (string) CacheFilesService.AJJ6D4ByofIIYeCCNkVe(-342626196 - 1290888215 ^ -1633425079)), (object) value.FileName.ToBase64String());
              num2 = 6;
              continue;
            case 12:
              goto label_13;
            case 13:
              if (!CacheFilesService.nj2IfbBy6JYF52tYjEZ8((object) fileInfo))
              {
                num2 = 5;
                continue;
              }
              goto case 1;
            default:
              if (!CacheFilesService.nj2IfbBy6JYF52tYjEZ8((object) fileInfo))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 9 : 4;
                continue;
              }
              goto label_13;
          }
        }
label_13:
        CacheFilesService.hT8XtLByHYurNgshAqZM((object) fileInfo, DateTime.Now);
        num1 = 4;
      }
label_11:
      return true;
    }

    public virtual bool CreateCacheFileByUid(Guid uid, string fileName)
    {
      int num1 = 2;
      CacheFilesService.TempFileInfo tempFileInfo;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (CacheFilesService.tlxuMqBythdwFhR1dTPI((object) this.Cache, CacheFilesService.ipK3aeBypticGKf8sGIC(uid), CacheFilesService.AJJ6D4ByofIIYeCCNkVe(979449278 ^ 979392074)))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
              continue;
            }
            goto case 9;
          case 2:
            tempFileInfo = new CacheFilesService.TempFileInfo()
            {
              FileName = fileName,
              FilePath = this.GetFilePathPrivate(uid, fileName)
            };
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 1 : 1;
            continue;
          case 5:
            goto label_9;
          case 6:
            goto label_12;
          case 7:
            goto label_11;
          case 8:
            if (this.AddValue(uid, tempFileInfo))
            {
              num1 = 3;
              continue;
            }
            goto label_9;
          case 9:
            if (Directory.EnumerateFiles(this.CacheFilesDir, (string) CacheFilesService.MEqmD0ByT5SM9vHJKUs5((object) uid, CacheFilesService.AJJ6D4ByofIIYeCCNkVe(-1317790512 ^ -1317701506))).Any<string>())
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 2 : 4;
              continue;
            }
            goto case 8;
          default:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 3 : 6;
            continue;
        }
      }
label_9:
      return false;
label_11:
      bool cacheFileByUid;
      return cacheFileByUid;
label_12:
      try
      {
        int num2;
        if (File.Exists(tempFileInfo.FilePath))
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 3 : 1;
        else
          goto label_16;
label_14:
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_16;
            case 2:
              CacheFilesService.tPM6Y4ByD5ObDCmdoDoH((object) tempFileInfo.FilePath);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 1;
              continue;
            case 3:
              this.Logger.InfoFormat((string) CacheFilesService.AJJ6D4ByofIIYeCCNkVe(-488881205 ^ -488823231), (object) this.CurrentUser, (object) tempFileInfo.FilePath);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 1 : 2;
              continue;
            default:
              goto label_11;
          }
        }
label_16:
        cacheFileByUid = true;
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
        {
          num2 = 0;
          goto label_14;
        }
        else
          goto label_14;
      }
      catch
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_11;
            default:
              cacheFileByUid = false;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 1 : 1;
              continue;
          }
        }
      }
    }

    protected virtual CacheFilesService.TempFileInfo GetTempFileInfo(Guid uid)
    {
      int num1 = 12;
      CacheFilesService.TempFileInfo tempFileInfo;
      while (true)
      {
        int num2 = num1;
        string str;
        string originalFileName;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!CacheFilesService.Lkj7OhByiyt5C7FvD6pF((object) this.Logger))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 7 : 8;
                continue;
              }
              goto case 10;
            case 2:
              originalFileName = (string) CacheFilesService.G5ZRIFBym9IDD5TNqHrP(CacheFilesService.Yu4qNvBy7aQ43fNUZGAC(), CacheFilesService.EcQiVLBy02bKHUrVLBk6(CacheFilesService.wTjwdHByxJDJXw0jnY7L((object) str)));
              num2 = 9;
              continue;
            case 4:
            case 15:
              if (tempFileInfo == null)
                goto case 1;
              else
                goto label_5;
            case 5:
              this.AddValue(uid, tempFileInfo, false);
              num2 = 16;
              continue;
            case 6:
              this.Logger.DebugFormat((string) CacheFilesService.AJJ6D4ByofIIYeCCNkVe(-1939377524 ^ -1939466438), (object) this.CurrentUser, (object) uid);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 18 : 9;
              continue;
            case 7:
            case 8:
              this.Logger.WarnFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1012087039 ^ 1012031095), (object) this.CurrentUser, (object) uid);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
              continue;
            case 9:
              tempFileInfo = new CacheFilesService.TempFileInfo()
              {
                FileName = originalFileName,
                FilePath = this.GetFilePathPrivate(uid, originalFileName)
              };
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 15 : 9;
              continue;
            case 10:
              this.Logger.WarnFormat((string) CacheFilesService.AJJ6D4ByofIIYeCCNkVe(647913418 ^ 647969158), (object) this.CurrentUser, (object) uid, CacheFilesService.CiG4YMByyHC8WtvQ5aTd());
              num2 = 17;
              continue;
            case 11:
              if (tempFileInfo != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 3 : 2;
                continue;
              }
              goto case 6;
            case 12:
              tempFileInfo = this.Cache.Get<CacheFilesService.TempFileInfo>(CacheFilesService.GetKey(uid), (string) CacheFilesService.AJJ6D4ByofIIYeCCNkVe(1051802738 - -1831968059 ^ -1411138983));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 11 : 11;
              continue;
            case 13:
              this.Logger.DebugFormat((string) CacheFilesService.AJJ6D4ByofIIYeCCNkVe(-1217523399 ^ -1217431755), (object) this.CurrentUser, (object) tempFileInfo.FileName, (object) uid, (object) tempFileInfo.FilePath);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 5;
              continue;
            case 14:
              if (string.IsNullOrWhiteSpace(str))
              {
                num2 = 4;
                continue;
              }
              goto case 2;
            case 18:
              str = Directory.EnumerateFiles(this.CacheFilesDir, (string) CacheFilesService.MEqmD0ByT5SM9vHJKUs5((object) uid, CacheFilesService.AJJ6D4ByofIIYeCCNkVe(1142330761 ^ 1541959139 ^ 536845712))).FirstOrDefault<string>();
              num2 = 14;
              continue;
            default:
              goto label_10;
          }
        }
label_5:
        num1 = 13;
      }
label_10:
      return tempFileInfo;
    }

    public virtual bool IncrementCacheFile(
      Guid uid,
      [NotNull] Stream inputStream,
      long startPos = 0,
      long endPos = 9223372036854775807)
    {
      int num1 = 9;
      CacheFilesService.TempFileInfo tempFileInfo;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_31;
            case 2:
              goto label_8;
            case 3:
              tempFileInfo = (CacheFilesService.TempFileInfo) CacheFilesService.rq8Vi3ByMm7jUVX133Wv((object) this, uid);
              num2 = 7;
              continue;
            case 4:
              if (endPos > startPos)
              {
                num2 = 3;
                continue;
              }
              goto label_6;
            case 5:
              goto label_39;
            case 6:
              goto label_5;
            case 7:
              if (tempFileInfo != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 2 : 2;
                continue;
              }
              goto label_4;
            case 8:
              goto label_34;
            case 9:
              if (inputStream != null)
              {
                if (inputStream.CanRead)
                {
                  num2 = 4;
                  continue;
                }
                goto label_31;
              }
              else
              {
                num2 = 8;
                continue;
              }
            default:
              goto label_6;
          }
        }
label_4:
        num1 = 5;
      }
label_5:
      bool flag;
      return flag;
label_6:
      return false;
label_8:
      try
      {
        this.EnsureCacheDirectory();
        int num3 = 3;
        while (true)
        {
          FileStream fileStream;
          switch (num3)
          {
            case 1:
              goto label_5;
            case 2:
              CacheFilesService.d6eHgSBydAILEDgwNpaK(CacheFilesService.LF9KLEBy9Ryl5t4bjcA1((object) tempFileInfo.FilePath));
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 0 : 0;
              continue;
            case 3:
              if (!CacheFilesService.Lgx56rByJYoYrkMGKWnR((object) tempFileInfo.FilePath))
              {
                num3 = 2;
                continue;
              }
              break;
            case 4:
              try
              {
                CacheFilesService.eSv3I9Byl3qpsL7ot6i8((object) fileStream, startPos, SeekOrigin.Begin);
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
                  num4 = 0;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      fileStream.Flush();
                      num4 = 2;
                      continue;
                    case 2:
                      goto label_12;
                    default:
                      CacheFilesService.q4Z9hKByrvToUFCRjnyI((object) inputStream, (object) fileStream);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 1 : 1;
                      continue;
                  }
                }
              }
              finally
              {
                if (fileStream != null)
                {
                  int num5 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0)
                    num5 = 1;
                  while (true)
                  {
                    switch (num5)
                    {
                      case 1:
                        CacheFilesService.gkZTvFByvjPDSGPIT9Kw((object) fileStream);
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_25;
                    }
                  }
                }
label_25:;
              }
            case 5:
              fileStream = new FileStream(tempFileInfo.FilePath, FileMode.Open, FileAccess.Write, FileShare.ReadWrite);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 4;
              continue;
            case 6:
label_12:
              flag = true;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 1 : 1;
              continue;
          }
          this.Logger.DebugFormat((string) CacheFilesService.AJJ6D4ByofIIYeCCNkVe(1669371371 ^ 1669460727), (object) this.CurrentUser, (object) tempFileInfo.FileName, (object) uid, (object) tempFileInfo.FilePath, (object) startPos);
          num3 = 5;
        }
      }
      catch (Exception ex)
      {
        int num6 = 2;
        while (true)
        {
          switch (num6)
          {
            case 1:
              goto label_5;
            case 2:
              this.Logger.Error((object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317700680), (object) uid), ex);
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
              continue;
            default:
              flag = false;
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 1 : 1;
              continue;
          }
        }
      }
label_31:
      throw new ArgumentException(EleWise.ELMA.SR.T((string) CacheFilesService.AJJ6D4ByofIIYeCCNkVe(1994213607 >> 4 ^ 124564058)), (string) CacheFilesService.AJJ6D4ByofIIYeCCNkVe(1232639661 >> 3 ^ 154039407));
label_34:
      throw new ArgumentNullException((string) CacheFilesService.AJJ6D4ByofIIYeCCNkVe(-1638402543 ^ -1638494037));
label_39:
      return false;
    }

    public bool IncrementCacheFile(Guid uid, byte[] buf, long startPos = 0, long endPos = 9223372036854775807)
    {
      int num1 = 5;
      CacheFilesService.TempFileInfo tempFileInfo;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_5;
          case 2:
            if (tempFileInfo != null)
            {
              num1 = 7;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_9;
          case 4:
            if (endPos <= startPos)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
              continue;
            }
            tempFileInfo = (CacheFilesService.TempFileInfo) CacheFilesService.rq8Vi3ByMm7jUVX133Wv((object) this, uid);
            num1 = 2;
            continue;
          case 5:
            if (buf != null)
            {
              num1 = 4;
              continue;
            }
            goto label_2;
          case 6:
            goto label_2;
          case 7:
            goto label_14;
          default:
            goto label_10;
        }
      }
label_2:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(277947046 - -1479185048 ^ 1757074062));
label_5:
      return false;
label_9:
      bool flag;
      return flag;
label_10:
      return false;
label_14:
      try
      {
        this.EnsureCacheDirectory();
        int num2 = 2;
        FileStream fileStream;
        int num3;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_9;
            case 2:
              if (!CacheFilesService.Lgx56rByJYoYrkMGKWnR((object) tempFileInfo.FilePath))
              {
                num2 = 3;
                continue;
              }
              goto case 6;
            case 3:
              CacheFilesService.d6eHgSBydAILEDgwNpaK(CacheFilesService.LF9KLEBy9Ryl5t4bjcA1((object) tempFileInfo.FilePath));
              num2 = 6;
              continue;
            case 4:
              fileStream = new FileStream(tempFileInfo.FilePath, FileMode.Open, FileAccess.Write, FileShare.ReadWrite);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 3 : 7;
              continue;
            case 5:
label_17:
              flag = true;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 1 : 1;
              continue;
            case 6:
              num3 = CacheFilesService.Xs9j5IBy5fYcXsavNAIa(CacheFilesService.xHd3YpBygqDxKXVPa2nH((long) buf.Length, endPos - startPos));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
              continue;
            case 7:
              try
              {
                fileStream.Seek(startPos, SeekOrigin.Begin);
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
                  num4 = 0;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      CacheFilesService.EYaxZhByYEFZvhRRqTWc((object) fileStream);
                      num4 = 2;
                      continue;
                    case 2:
                      goto label_17;
                    default:
                      CacheFilesService.RK3lbMByj3GQR5YMA7dX((object) fileStream, (object) buf, 0, num3);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 1;
                      continue;
                  }
                }
              }
              finally
              {
                if (fileStream != null)
                {
                  int num5 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
                    num5 = 1;
                  while (true)
                  {
                    switch (num5)
                    {
                      case 1:
                        fileStream.Dispose();
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_31;
                    }
                  }
                }
label_31:;
              }
            default:
              this.Logger.DebugFormat((string) CacheFilesService.AJJ6D4ByofIIYeCCNkVe(~541731958 ^ -541805517), (object) this.CurrentUser, (object) tempFileInfo.FileName, (object) uid, (object) tempFileInfo.FilePath, (object) startPos, (object) num3);
              num2 = 4;
              continue;
          }
        }
      }
      catch (Exception ex)
      {
        int num6 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
          num6 = 0;
        while (true)
        {
          switch (num6)
          {
            case 1:
              flag = false;
              num6 = 2;
              continue;
            case 2:
              goto label_9;
            default:
              CacheFilesService.Pp27sJBy8KNKfadcO3AM((object) this.Logger, (object) EleWise.ELMA.SR.T((string) CacheFilesService.AJJ6D4ByofIIYeCCNkVe(--1360331293 ^ 1360291189), (object) uid), (object) ex);
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 1;
              continue;
          }
        }
      }
    }

    public virtual bool AppendCacheFile(Guid uid, [NotNull] byte[] buf, int cnt)
    {
      int num1 = 2;
      CacheFilesService.TempFileInfo tempFileInfo;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_27;
            case 2:
              if (buf != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 1;
                continue;
              }
              goto label_26;
            case 3:
              goto label_34;
            case 4:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 5 : 6;
              continue;
            case 5:
              goto label_26;
            case 6:
              goto label_3;
            case 7:
              if (tempFileInfo != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 4 : 2;
                continue;
              }
              goto label_28;
            default:
              goto label_28;
          }
        }
label_27:
        tempFileInfo = this.GetTempFileInfo(uid);
        num1 = 7;
      }
label_3:
      bool flag;
      try
      {
        this.EnsureCacheDirectory();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
          num3 = 5;
        while (true)
        {
          FileStream fileStream;
          switch (num3)
          {
            case 1:
            case 6:
              this.Logger.DebugFormat((string) CacheFilesService.AJJ6D4ByofIIYeCCNkVe(993438473 ^ 993510151), (object) this.CurrentUser, (object) tempFileInfo.FileName, (object) uid, (object) tempFileInfo.FilePath);
              num3 = 2;
              continue;
            case 2:
              fileStream = new FileStream(tempFileInfo.FilePath, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
              num3 = 7;
              continue;
            case 3:
              CacheFilesService.d6eHgSBydAILEDgwNpaK((object) File.Create(tempFileInfo.FilePath));
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 1;
              continue;
            case 4:
              goto label_34;
            case 5:
              if (CacheFilesService.Lgx56rByJYoYrkMGKWnR((object) tempFileInfo.FilePath))
              {
                num3 = 6;
                continue;
              }
              goto case 3;
            case 7:
              try
              {
                CacheFilesService.RK3lbMByj3GQR5YMA7dX((object) fileStream, (object) buf, 0, cnt);
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
                  num4 = 0;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_21;
                    default:
                      CacheFilesService.EYaxZhByYEFZvhRRqTWc((object) fileStream);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 1 : 0;
                      continue;
                  }
                }
              }
              finally
              {
                int num5;
                if (fileStream == null)
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 2 : 0;
                else
                  goto label_15;
label_14:
                switch (num5)
                {
                  case 1:
                    break;
                  default:
                }
label_15:
                fileStream.Dispose();
                num5 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
                {
                  num5 = 0;
                  goto label_14;
                }
                else
                  goto label_14;
              }
          }
label_21:
          flag = true;
          num3 = 4;
        }
      }
      catch (Exception ex)
      {
        int num6 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
          num6 = 1;
        while (true)
        {
          switch (num6)
          {
            case 1:
              flag = false;
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
              continue;
            default:
              goto label_34;
          }
        }
      }
label_26:
      throw new ArgumentNullException((string) CacheFilesService.AJJ6D4ByofIIYeCCNkVe(222162814 ^ 222070990));
label_28:
      return false;
label_34:
      return flag;
    }

    public bool AppendCacheFile(Guid uid, [NotNull] Stream inputStream)
    {
      int num1 = 7;
      CacheFilesService.TempFileInfo tempFileInfo;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_11;
            case 2:
              num2 = 5;
              continue;
            case 3:
              goto label_7;
            case 4:
              goto label_3;
            case 5:
              goto label_12;
            case 6:
              goto label_34;
            case 7:
              if (inputStream == null)
              {
                num2 = 6;
                continue;
              }
              if (inputStream.CanRead)
              {
                tempFileInfo = this.GetTempFileInfo(uid);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
                continue;
              }
              num2 = 3;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        if (tempFileInfo != null)
          num1 = 2;
        else
          break;
      }
label_3:
      return false;
label_7:
      throw new ArgumentException((string) CacheFilesService.q7gwsrByLV26r1oss90n((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398620792)), (string) CacheFilesService.AJJ6D4ByofIIYeCCNkVe(-1921202237 ^ -1921146503));
label_11:
      bool flag;
      return flag;
label_12:
      try
      {
        this.EnsureCacheDirectory();
        int num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0)
          num3 = 1;
        FileStream fileStream;
        while (true)
        {
          switch (num3)
          {
            case 1:
              if (!CacheFilesService.Lgx56rByJYoYrkMGKWnR((object) tempFileInfo.FilePath))
              {
                num3 = 6;
                continue;
              }
              goto case 2;
            case 2:
              this.Logger.DebugFormat((string) CacheFilesService.AJJ6D4ByofIIYeCCNkVe(-1638402543 ^ -1638490593), (object) this.CurrentUser, (object) tempFileInfo.FileName, (object) uid, (object) tempFileInfo.FilePath);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
              continue;
            case 3:
label_16:
              flag = true;
              num3 = 4;
              continue;
            case 4:
              goto label_11;
            case 5:
              try
              {
                CacheFilesService.q4Z9hKByrvToUFCRjnyI((object) inputStream, (object) fileStream);
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
                  num4 = 1;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      CacheFilesService.EYaxZhByYEFZvhRRqTWc((object) fileStream);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_16;
                  }
                }
              }
              finally
              {
                int num5;
                if (fileStream == null)
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 1;
                else
                  goto label_25;
label_24:
                switch (num5)
                {
                  case 1:
                  case 2:
                }
label_25:
                CacheFilesService.gkZTvFByvjPDSGPIT9Kw((object) fileStream);
                num5 = 2;
                goto label_24;
              }
            case 6:
              CacheFilesService.d6eHgSBydAILEDgwNpaK(CacheFilesService.LF9KLEBy9Ryl5t4bjcA1((object) tempFileInfo.FilePath));
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 2 : 0;
              continue;
            default:
              fileStream = new FileStream(tempFileInfo.FilePath, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
              num3 = 5;
              continue;
          }
        }
      }
      catch (Exception ex)
      {
        int num6 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
          num6 = 1;
        while (true)
        {
          switch (num6)
          {
            case 1:
              flag = false;
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
              continue;
            default:
              goto label_11;
          }
        }
      }
label_34:
      throw new ArgumentNullException((string) CacheFilesService.AJJ6D4ByofIIYeCCNkVe(1199946765 ^ 1199889079));
    }

    public virtual string GetFileName(Guid uid)
    {
      int num = 2;
      CacheFilesService.TempFileInfo tempFileInfo;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (tempFileInfo != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 2:
            tempFileInfo = this.GetTempFileInfo(uid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 1;
            continue;
          case 3:
            goto label_5;
          default:
            goto label_6;
        }
      }
label_5:
      return "";
label_6:
      return tempFileInfo.FileName;
    }

    public virtual string GetFilePath(Guid uid)
    {
      int num = 1;
      CacheFilesService.TempFileInfo tempFileInfo;
      while (true)
      {
        switch (num)
        {
          case 1:
            tempFileInfo = (CacheFilesService.TempFileInfo) CacheFilesService.rq8Vi3ByMm7jUVX133Wv((object) this, uid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            if (tempFileInfo == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 2 : 0;
              continue;
            }
            goto label_3;
        }
      }
label_2:
      return "";
label_3:
      return tempFileInfo.FilePath;
    }

    /// <inheritdoc />
    public virtual long GetFileLength(Guid uid)
    {
      int num = 5;
      CacheFilesService.TempFileInfo tempFileInfo;
      FileInfo fileInfo;
      while (true)
      {
        switch (num)
        {
          case 1:
            fileInfo = new FileInfo(tempFileInfo.FilePath);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 2 : 2;
            continue;
          case 2:
            if (!fileInfo.Exists)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 3:
            goto label_6;
          case 4:
            if (tempFileInfo != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 1 : 1;
              continue;
            }
            goto label_6;
          case 5:
            tempFileInfo = (CacheFilesService.TempFileInfo) CacheFilesService.rq8Vi3ByMm7jUVX133Wv((object) this, uid);
            num = 4;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return 0;
label_5:
      return CacheFilesService.AT9ayUByUhnrcIFuImrG((object) fileInfo);
label_6:
      return 0;
    }

    public void Init()
    {
    }

    public void InitComplete()
    {
      switch (1)
      {
        case 1:
          try
          {
            IFileManager service = Locator.GetService<IFileManager>();
            int num1 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
              num1 = 0;
            while (true)
            {
              int num2;
              string str;
              object obj;
              switch (num1)
              {
                case 1:
                  if (string.IsNullOrEmpty(str))
                  {
                    num1 = 6;
                    continue;
                  }
                  goto case 5;
                case 2:
                  this.RemoveCacheDirectory();
                  num2 = 7;
                  break;
                case 3:
                  goto label_5;
                case 4:
                  obj = (object) null;
                  goto label_16;
                case 5:
                  this.cacheFilesDirectory = str;
                  num2 = 2;
                  break;
                case 6:
                  str = (string) CacheFilesService.hhohlJBycAWmFpJxsKUu(CacheFilesService.AJJ6D4ByofIIYeCCNkVe(--1867379187 ^ 1867291043));
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 5 : 5;
                  continue;
                case 7:
                  this.EnsureCacheDirectory();
                  num1 = 3;
                  continue;
                default:
                  if (service == null)
                  {
                    num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 4 : 3;
                    continue;
                  }
                  obj = CacheFilesService.hFZQh9BysJEnFcH3X3cN((object) service);
                  goto label_16;
              }
              num1 = num2;
              continue;
label_16:
              str = (string) obj;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 1 : 1;
            }
label_5:
            break;
          }
          catch (Exception ex)
          {
            int num = 2;
            InvalidOperationException operationException;
            while (true)
            {
              switch (num)
              {
                case 1:
                  CacheFilesService.Pp27sJBy8KNKfadcO3AM((object) this.Logger, CacheFilesService.AJJ6D4ByofIIYeCCNkVe(1470998129 - 231418599 ^ 1239618384), (object) operationException);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
                  continue;
                case 2:
                  operationException = new InvalidOperationException((string) CacheFilesService.q7gwsrByLV26r1oss90n(CacheFilesService.AJJ6D4ByofIIYeCCNkVe(-35995181 ^ -35935837)), ex);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 1 : 0;
                  continue;
                default:
                  goto label_23;
              }
            }
label_23:
            throw operationException;
          }
      }
    }

    public CacheFilesService()
    {
      CacheFilesService.qiI97KByzwsCPc1EOhGY();
      this.cacheFilesDirectory = "";
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool Apo2DxByBGbdTPsVGUxy() => CacheFilesService.vAphfdByFiFvMlMtDAh9 == null;

    internal static CacheFilesService E31pulByWHwx8K7cc9vS() => CacheFilesService.vAphfdByFiFvMlMtDAh9;

    internal static object AJJ6D4ByofIIYeCCNkVe(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void IDovjHBybiOL2BHBlccv([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void CPA9R9Byhm7v9oVKbAUc([In] object obj0, [In] object obj1) => Contract.ArgumentNotNullOrEmpty((string) obj0, (string) obj1);

    internal static object DBPk8UByG1SZQctnQYw9([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static Guid pIAir7ByEsx8PcN2lspU([In] object obj0, [In] object obj1) => ((CacheFilesService) obj0).CreateCacheFile((string) obj1);

    internal static object cuCqK1ByflxIQ6NyjqBC([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static object eNBE3IByQeLFjTv47uEe([In] object obj0) => (object) ((StructuredFileFolder) obj0).Name;

    internal static object akFwesByCtfnO0Iv4ZHS([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((IZipService) obj0).CreateZipFolder((string) obj1, (string) obj2);

    internal static void gkZTvFByvjPDSGPIT9Kw([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void Pp27sJBy8KNKfadcO3AM([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static void FbwtyjByZisrujCigLCi([In] object obj0, [In] bool obj1) => Directory.Delete((string) obj0, obj1);

    internal static bool K586s4ByuNLZFNKW6iwd([In] object obj0) => Directory.Exists((string) obj0);

    internal static object wPX301ByIuql4vat9OJU([In] object obj0) => (object) Directory.CreateDirectory((string) obj0);

    internal static object PpJoLYByVQ7P9wa9d5bx([In] object obj0) => (object) EleWise.ELMA.Logging.Logger.GetLogger((string) obj0);

    internal static void nWYheUBySKuXqtQRRxul([In] object obj0, [In] object obj1) => ((ILogger) obj0).ConfigurationChanged += (EventHandler) obj1;

    internal static bool Lkj7OhByiyt5C7FvD6pF([In] object obj0) => ((ILogger) obj0).IsDebugEnabled();

    internal static object gZ32bBByRiSbvBFD1BIk() => (object) CacheFilesService.AuthenticationService;

    internal static object ygjytAByqXr8X3jWNUu7([In] object obj0) => (object) ((IAuthenticationService) obj0).GetCurrentUser();

    internal static object pJWsntByKqnNQTBVXDni([In] object obj0) => (object) ((IUser) obj0).UserName;

    internal static bool HqQH7EByX9ADbPJ5AJv9([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object MEqmD0ByT5SM9vHJKUs5([In] object obj0, [In] object obj1) => (object) (obj0.ToString() + obj1);

    internal static object OdC8miByk1Z1WEn8qH9s([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static void Wu9jvdBynIkjUjbYTX7M([In] object obj0) => FileCleaner.CleanFiles((string) obj0);

    internal static void vBeLg9ByOrLD4JKYdlek([In] object obj0) => FileCleaner.SetCacheFilesDirectory((string) obj0);

    internal static void j3iWu9By2lwEMqIgrN7S([In] object obj0, [In] bool obj1) => ((FileSystemWatcher) obj0).EnableRaisingEvents = obj1;

    internal static void RKKvlAByeP3QOXVt0QBn([In] object obj0, [In] object obj1) => ((FileSystemWatcher) obj0).Created += (FileSystemEventHandler) obj1;

    internal static void sIMxdwByPndBFTT8RYLH([In] object obj0, [In] object obj1) => ((FileSystemWatcher) obj0).Deleted += (FileSystemEventHandler) obj1;

    internal static bool Jj1VoGBy1tfo6yMm6QA0([In] object obj0, EleWise.ELMA.Logging.LogLevel level) => ((ILogger) obj0).IsEnabled(level);

    internal static WatcherChangeTypes A5VNgTByNyXcKqNLKgjk([In] object obj0) => ((FileSystemEventArgs) obj0).ChangeType;

    internal static object W1FlbEBy3OaVCJFY8Nlq([In] object obj0) => (object) ((FileSystemEventArgs) obj0).FullPath;

    internal static object ipK3aeBypticGKf8sGIC(Guid key) => (object) CacheFilesService.GetKey(key);

    internal static object bWF3HXByaUfWR8dxoqDw([In] object obj0, [In] object obj1) => (object) Directory.GetFiles((string) obj0, (string) obj1);

    internal static void tPM6Y4ByD5ObDCmdoDoH([In] object obj0) => File.Delete((string) obj0);

    internal static bool tlxuMqBythdwFhR1dTPI([In] object obj0, [In] object obj1, [In] object obj2) => ((ICacheService) obj0).Contains((string) obj1, (string) obj2);

    internal static Guid dO6wkdBywZeR9u8rJbgC() => Guid.NewGuid();

    internal static void BvJrdQBy4NfBFYw2jTk4([In] object obj0, [In] object obj1) => File.WriteAllText((string) obj0, (string) obj1);

    internal static bool nj2IfbBy6JYF52tYjEZ8([In] object obj0) => ((FileSystemInfo) obj0).Exists;

    internal static void hT8XtLByHYurNgshAqZM([In] object obj0, [In] DateTime obj1) => ((FileSystemInfo) obj0).LastWriteTime = obj1;

    internal static DateTime qghom1ByAk0KBvJ1IQcC() => DateTime.Now;

    internal static object Yu4qNvBy7aQ43fNUZGAC() => (object) Encoding.UTF8;

    internal static object wTjwdHByxJDJXw0jnY7L([In] object obj0) => (object) File.ReadAllText((string) obj0);

    internal static object EcQiVLBy02bKHUrVLBk6([In] object obj0) => (object) Convert.FromBase64String((string) obj0);

    internal static object G5ZRIFBym9IDD5TNqHrP([In] object obj0, [In] object obj1) => (object) ((Encoding) obj0).GetString((byte[]) obj1);

    internal static object CiG4YMByyHC8WtvQ5aTd() => (object) Environment.StackTrace;

    internal static object rq8Vi3ByMm7jUVX133Wv([In] object obj0, Guid uid) => (object) ((CacheFilesService) obj0).GetTempFileInfo(uid);

    internal static bool Lgx56rByJYoYrkMGKWnR([In] object obj0) => File.Exists((string) obj0);

    internal static object LF9KLEBy9Ryl5t4bjcA1([In] object obj0) => (object) File.Create((string) obj0);

    internal static void d6eHgSBydAILEDgwNpaK([In] object obj0) => ((Stream) obj0).Close();

    internal static long eSv3I9Byl3qpsL7ot6i8([In] object obj0, [In] long obj1, [In] SeekOrigin obj2) => ((Stream) obj0).Seek(obj1, obj2);

    internal static void q4Z9hKByrvToUFCRjnyI([In] object obj0, [In] object obj1) => ((Stream) obj0).CopyTo((Stream) obj1);

    internal static long xHd3YpBygqDxKXVPa2nH([In] long obj0, [In] long obj1) => Math.Min(obj0, obj1);

    internal static int Xs9j5IBy5fYcXsavNAIa([In] long obj0) => Convert.ToInt32(obj0);

    internal static void RK3lbMByj3GQR5YMA7dX([In] object obj0, [In] object obj1, [In] int obj2, [In] int obj3) => ((Stream) obj0).Write((byte[]) obj1, obj2, obj3);

    internal static void EYaxZhByYEFZvhRRqTWc([In] object obj0) => ((Stream) obj0).Flush();

    internal static object q7gwsrByLV26r1oss90n([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static long AT9ayUByUhnrcIFuImrG([In] object obj0) => ((FileInfo) obj0).Length;

    internal static object hFZQh9BysJEnFcH3X3cN([In] object obj0) => (object) ((IFileManager) obj0).TempFilesPath;

    internal static object hhohlJBycAWmFpJxsKUu([In] object obj0) => (object) IOExtensions.GetTempPath((string) obj0);

    internal static void qiI97KByzwsCPc1EOhGY() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    [Serializable]
    internal class TempFileInfo
    {
      public string FilePath;
      public string FileName;
      internal static CacheFilesService.TempFileInfo Wl0UDXQOR3LWwlEJcnPI;

      public TempFileInfo()
      {
        CacheFilesService.TempFileInfo.EAygtFQOXFpocJet1fY9();
        this.FilePath = "";
        this.FileName = "";
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static void EAygtFQOXFpocJet1fY9() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool asPfJKQOqhCRPx49Dval() => CacheFilesService.TempFileInfo.Wl0UDXQOR3LWwlEJcnPI == null;

      internal static CacheFilesService.TempFileInfo p0SpQjQOK46MF1Zcr4Tl() => CacheFilesService.TempFileInfo.Wl0UDXQOR3LWwlEJcnPI;
    }
  }
}
