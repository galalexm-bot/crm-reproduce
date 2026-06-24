// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Providers.Impl.FileSystemFileStoreProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Autofac;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Configuration;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Files.Previews;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Runtime.Providers.Impl.Models;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration.Provider;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Resources;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Runtime.Providers.Impl
{
  /// <summary>
  /// Провайдер для работы с файлами.
  /// Хранит файлы в файловой системе, путь до файлов задается атрибутом конфигурации filesPath
  /// </summary>
  [Component(EnableInterceptors = true)]
  public class FileSystemFileStoreProvider : 
    FileStoreProvider,
    INHManagerRegistrar,
    IBinaryFileStreams,
    IBinaryFileAsyncLoader,
    IBinaryFileHashService,
    IBinaryFileLegacyBehaviorProvider,
    IFileGatewayService
  {
    private IEnumerable<IPreUploadFile> componentsPreUploadFile;
    private SystemFileNHManager systemFileManager;
    private IStorageOperationsProvider storageOperationsProvider;
    internal const string ItemsKey = "EleWise.ELMA.Runtime.Providers.Impl.FileSystemFileStoreProvider.StoreOnCommit";
    internal const string StoreKey = "EleWise.ELMA.Runtime.Providers.Impl.FileSystemFileStoreProvider.ProcessStore";
    /// <summary>
    /// Ключ для хранения в кэше информации о несохраненных и зашифрованнх файлах.
    /// </summary>
    internal const string EncryptItemsKey = "EleWise.ELMA.Runtime.Providers.Impl.FileSystemFileStoreProvider.EncriptedFilesKeys";
    private string privateFilesPath;
    private string privatePreviewsPath;
    private string privateTempFilesPath;
    private bool initialized;
    protected bool ignoreNotExistsFiles;
    private ILogger logger;
    private static IAuthenticationService authenticationService;
    private static readonly IList<string> notFoundExtensions;
    private static FileSystemFileStoreProvider asrIwLWQt4N0iq3l3VrP;

    /// <summary>Ctor</summary>
    public FileSystemFileStoreProvider()
    {
      FileSystemFileStoreProvider.BxCLkOWQ6cNg7WloU7c4();
      this.privateFilesPath = (string) FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(-867826612 ^ -867735676);
      this.privatePreviewsPath = (string) FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(~538519529 ^ -538476622);
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.componentsPreUploadFile = Enumerable.Empty<IPreUploadFile>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Ctor</summary>
    /// <param name="componentsPreUploadFile">Компоненты для предобработки загружаемых файлов.</param>
    public FileSystemFileStoreProvider(
      IEnumerable<IPreUploadFile> componentsPreUploadFile)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.privateFilesPath = z2jc63fLkugS1X8Q9N.tE1kD1vbB(132912447 ^ 133002999);
      this.privatePreviewsPath = z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051276242 - 990076387 ^ 61108811);
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.componentsPreUploadFile = componentsPreUploadFile;
    }

    /// <summary>Логгер.</summary>
    protected ILogger Logger
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.logger == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 2:
              goto label_4;
            default:
              this.logger = EleWise.ELMA.Logging.Logger.GetLogger((string) FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(-97972138 ^ -98012258));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 2;
              continue;
          }
        }
label_4:
        return this.logger;
      }
    }

    protected static IAuthenticationService AuthenticationService
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
              authenticationService = FileSystemFileStoreProvider.authenticationService;
              if (authenticationService == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 0;
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
        return FileSystemFileStoreProvider.authenticationService = Locator.GetService<IAuthenticationService>();
      }
    }

    /// <summary>Менеджер работы с системными файлами.</summary>
    protected SystemFileNHManager SystemFileManager
    {
      get
      {
        int num = 1;
        SystemFileNHManager service;
        SystemFileNHManager systemFileManager;
        while (true)
        {
          switch (num)
          {
            case 1:
              systemFileManager = this.systemFileManager;
              if (systemFileManager == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_6;
            default:
              this.systemFileManager = service = Locator.GetService<SystemFileNHManager>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 2;
              continue;
          }
        }
label_2:
        return systemFileManager;
label_6:
        return service;
      }
    }

    /// <summary>Провайдер операций с хранилищем файлов.</summary>
    protected virtual IStorageOperationsProvider StorageOperationsProvider => this.storageOperationsProvider;

    /// <summary>Служба точек хранения.</summary>
    protected virtual IFileGatewayService FileGatewayService => (IFileGatewayService) this;

    /// <summary>Флаг завершённой инициализации провайдера.</summary>
    protected bool Initialized => this.initialized;

    private string CurrentUser
    {
      get
      {
        int num = 5;
        IUser user;
        while (true)
        {
          object obj;
          switch (num)
          {
            case 1:
              if (user != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              obj = (object) null;
              break;
            case 3:
              goto label_2;
            case 4:
              goto label_4;
            case 5:
              if (FileSystemFileStoreProvider.Eg5apLWQApu3sMfYKK7y((object) this.Logger))
              {
                if (FileSystemFileStoreProvider.AuthenticationService != null)
                {
                  num = 6;
                  continue;
                }
                goto case 2;
              }
              else
              {
                num = 4;
                continue;
              }
            case 6:
              obj = FileSystemFileStoreProvider.QMLaHHWQ7PNFBfRYdjiB((object) FileSystemFileStoreProvider.AuthenticationService);
              break;
            default:
              goto label_13;
          }
          user = (IUser) obj;
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 1;
        }
label_2:
        string str = string.Empty;
        goto label_14;
label_4:
        return string.Empty;
label_13:
        str = user.UserName;
label_14:
        object obj1 = FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(2045296739 + 1688595713 ^ -561068752);
        return (string) FileSystemFileStoreProvider.OKX2EnWQxYL1v96cCmMl((object) str, obj1);
      }
    }

    /// <summary>Инициализировать провайдер.</summary>
    /// <param name="name">Имя провайдера.</param>
    /// <param name="config">Секция с параметрами.</param>
    public override void Initialize(string name, NameValueCollection config)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_6;
            case 2:
              goto label_3;
            case 3:
              name = (string) FileSystemFileStoreProvider.cadO6IWQmTh6igQ0FFB5((object) this, (object) name, (object) config);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
              continue;
            case 4:
              FileSystemFileStoreProvider.AReyowWQ0Kckm3BpBhgN((object) config, FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(1253244298 - 1829393894 ^ -576126948));
              num2 = 3;
              continue;
            default:
              FileSystemFileStoreProvider.Kjcq2VWQyZ1AgRROCN04((object) this, (object) name, (object) config);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 1 : 1;
              continue;
          }
        }
label_6:
        this.initialized = true;
        num1 = 2;
      }
label_3:;
    }

    /// <summary>Выполнить провайдеро-зависимую инициализацию.</summary>
    /// <param name="name">Имя провайдера.</param>
    /// <param name="config">Секция с параметрами.</param>
    /// <returns>Имя провайдера.</returns>
    protected virtual string DoProviderSpecificInitialization(
      string name,
      NameValueCollection config)
    {
      int num1 = 16;
      while (true)
      {
        int num2 = num1;
        string str;
        while (true)
        {
          switch (num2)
          {
            case 1:
              this.privateFilesPath = (string) FileSystemFileStoreProvider.Ty5XGhWQYVexiHXqAD85((object) str, (object) this.privateFilesPath);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 2 : 7;
              continue;
            case 2:
              Directory.CreateDirectory(this.privateTempFilesPath);
              num2 = 35;
              continue;
            case 3:
            case 32:
              goto label_12;
            case 4:
              if (string.IsNullOrEmpty(this.privateFilesPath))
              {
                num2 = 31;
                continue;
              }
              goto case 30;
            case 5:
              FileSystemFileStoreProvider.eea7PgWQ9W5u1LQgRtWp((object) config, FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(-882126494 ^ -882214534));
              num2 = 27;
              continue;
            case 6:
              if (!FileSystemFileStoreProvider.uDS7aQWQMj4nE33ahKIX((object) this.privateTempFilesPath))
              {
                num2 = 33;
                continue;
              }
              goto label_3;
            case 7:
              this.privatePreviewsPath = (string) FileSystemFileStoreProvider.Ty5XGhWQYVexiHXqAD85((object) str, (object) this.privatePreviewsPath);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 32 : 22;
              continue;
            case 8:
              FileSystemFileStoreProvider.AeUo83WQsLGPb8rFOfWc((object) this.privatePreviewsPath);
              num2 = 22;
              continue;
            case 9:
            case 17:
              str = (string) FileSystemFileStoreProvider.yOOQQWWQjwviuNyt7mgY(FileSystemFileStoreProvider.CWE5fZWQ5Gxf16FypDR8(FileSystemFileStoreProvider.xjsSIEWQgCUavKVs2qUd(FileSystemFileStoreProvider.QgPdWVWQrGEl5NMTRg33((object) ((ComponentManager) FileSystemFileStoreProvider.r0xjxRWQlZbrlGoT2HGl()).GetExtensionPoints<IRuntimeApplication>().First<IRuntimeApplication>()))));
              num2 = 13;
              continue;
            case 10:
              this.privateFilesPath = (string) FileSystemFileStoreProvider.OBV0MWWQJtY5GU8b8YwP((object) config, FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(1514961705 ^ 1515049771));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 4 : 1;
              continue;
            case 11:
              goto label_35;
            case 12:
              this.ignoreNotExistsFiles = false;
              num2 = 17;
              continue;
            case 13:
              if (str == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 3 : 3;
                continue;
              }
              goto case 1;
            case 14:
              this.privatePreviewsPath = (string) FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(1012087039 ^ 1012047707);
              num2 = 5;
              continue;
            case 15:
              name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(2008901894 << 3 ^ -1108676616);
              num2 = 10;
              continue;
            case 16:
              if (FileSystemFileStoreProvider.uDS7aQWQMj4nE33ahKIX((object) name))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 15 : 0;
                continue;
              }
              goto case 10;
            case 18:
              FileSystemFileStoreProvider.eea7PgWQ9W5u1LQgRtWp((object) config, FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(-2138958856 ^ -2138850356));
              num2 = 34;
              continue;
            case 19:
              if (FileSystemFileStoreProvider.uDS7aQWQMj4nE33ahKIX((object) this.privatePreviewsPath))
              {
                num2 = 14;
                continue;
              }
              goto case 25;
            case 20:
            case 22:
              if (!Directory.Exists(this.privateTempFilesPath))
              {
                num2 = 2;
                continue;
              }
              goto case 35;
            case 21:
              if (FileSystemFileStoreProvider.B3eXXMWQU4Gcbuv26ElV((object) this.privateFilesPath))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 26 : 23;
                continue;
              }
              goto case 29;
            case 23:
              goto label_3;
            case 24:
              goto label_28;
            case 25:
              this.privateTempFilesPath = (string) FileSystemFileStoreProvider.OBV0MWWQJtY5GU8b8YwP((object) config, FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(-345420348 ^ -345446928));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 6 : 2;
              continue;
            case 26:
            case 36:
              if (Directory.Exists(this.privatePreviewsPath))
              {
                num2 = 20;
                continue;
              }
              goto case 8;
            case 27:
              goto label_30;
            case 28:
              FileSystemFileStoreProvider.PtcISBWQdV4ZSIfBirCv((object) config, FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(322893104 - -1992822529 ^ -1979274189), (object) this.privateFilesPath);
              num2 = 30;
              continue;
            case 29:
              FileSystemFileStoreProvider.AeUo83WQsLGPb8rFOfWc((object) this.privateFilesPath);
              num2 = 36;
              continue;
            case 30:
              this.privatePreviewsPath = config[(string) FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(~1767720452 ^ -1767697949)];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 19 : 9;
              continue;
            case 31:
              this.privateFilesPath = (string) FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(92412609 - 1050237057 ^ -957767288);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 4 : 11;
              continue;
            case 34:
              config.Add((string) FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(-2138958856 ^ -2138850356), this.privateFilesPath);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
              continue;
            case 35:
              this.storageOperationsProvider = (IStorageOperationsProvider) FileSystemFileStoreProvider.y5VjpYWQcdn8Pe1tkmNU((object) this);
              num2 = 24;
              continue;
            default:
              if (bool.TryParse(config[(string) FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(647913418 ^ 648017816)], out this.ignoreNotExistsFiles))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 9 : 2;
                continue;
              }
              goto case 12;
          }
        }
label_3:
        this.privateTempFilesPath = (string) FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(1051276242 - 990076387 ^ 61128127);
        num1 = 18;
        continue;
label_12:
        this.privateTempFilesPath = (string) FileSystemFileStoreProvider.gGWm3YWQL1xXAxg9YgPj((object) this.privateTempFilesPath);
        num1 = 21;
        continue;
label_30:
        config.Add((string) FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(95909607 + 343705423 ^ 439506478), this.privatePreviewsPath);
        num1 = 25;
        continue;
label_35:
        FileSystemFileStoreProvider.eea7PgWQ9W5u1LQgRtWp((object) config, FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(825385222 ^ 825477380));
        num1 = 28;
      }
label_28:
      return name;
    }

    /// <summary>Создать провайдер операция с хранилищем файлов.</summary>
    /// <returns>Реализацию провайдера операций с хранилищем файлов.</returns>
    protected virtual IStorageOperationsProvider CreateStorageOperationsProvider()
    {
      int num = 1;
      LocalFsLocationSchema fsLocationSchema;
      while (true)
      {
        switch (num)
        {
          case 1:
            fsLocationSchema = new LocalFsLocationSchema(this.privateFilesPath, this.privateTempFilesPath, this.privatePreviewsPath);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return (IStorageOperationsProvider) new LocalFsStorageOperationsProvider(this.Logger, (ILocationSchema) fsLocationSchema);
    }

    /// <summary>Папка для хранения временных файлов</summary>
    public override string TempFilesPath
    {
      get => this.privateTempFilesPath;
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
              this.privateTempFilesPath = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
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

    /// <summary>Папка для хранения файлов</summary>
    public override string FilesPath
    {
      get => this.privateFilesPath;
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
              this.privateFilesPath = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
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

    /// <summary>Путь для хранения предпросмотров</summary>
    public override string PreviewsPath
    {
      get => this.privatePreviewsPath;
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
              this.privatePreviewsPath = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
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

    /// <summary>Ключ элемента контекста</summary>
    public override string ContextItemsKey => z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195657365);

    /// <summary>Ключ процесса хранения</summary>
    public override string ProcessStoreKey => (string) FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(2045296739 + 1688595713 ^ -561052552);

    /// <summary>Сохранить файл</summary>
    /// <param name="binaryFile">Файл</param>
    /// <returns>Идентификатор в строковом представлении</returns>
    [Transaction]
    public override string SaveFile([NotNull] BinaryFile binaryFile)
    {
      int num1 = 2;
      Guid guid;
      while (true)
      {
        int num2 = num1;
        IMimeMappingService service;
        string str1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              Contract.ArgumentNotNull((object) binaryFile.ContentLocation, (string) FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(-710283084 ^ -537863435 ^ 173573009));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 2 : 7;
              continue;
            case 2:
              FileSystemFileStoreProvider.AReyowWQ0Kckm3BpBhgN((object) binaryFile, FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(-787452571 ^ -787364643));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 0;
              continue;
            case 3:
              if (!string.IsNullOrEmpty(binaryFile.ContentType))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
                continue;
              }
              goto case 6;
            case 4:
              if (this.StoreOnCommit(binaryFile))
              {
                num2 = 8;
                continue;
              }
              goto case 9;
            case 6:
              if (!FileSystemFileStoreProvider.uDS7aQWQMj4nE33ahKIX((object) binaryFile.Name))
              {
                num2 = 11;
                continue;
              }
              goto default;
            case 7:
              if (FileSystemFileStoreProvider.HJV403WQz9oIxyeKZUoO((object) binaryFile) == Guid.Empty)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 15 : 6;
                continue;
              }
              goto case 3;
            case 8:
              try
              {
                this.Logger.InfoFormat((string) FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(-1876063057 ^ -1876154713), (object) this.CurrentUser, FileSystemFileStoreProvider.pwPeWRWCoaDhEFeoegbE((object) binaryFile), (object) FileSystemFileStoreProvider.HJV403WQz9oIxyeKZUoO((object) binaryFile), (object) binaryFile.ContentLocation);
                int num3 = 21;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
                  num3 = 5;
                while (true)
                {
                  FileEncryptData fileEncryptData;
                  SystemFile systemFile1;
                  Dictionary<Guid, FileEncryptData> dictionary;
                  Uri uri;
                  SystemFile systemFile2;
                  int num4;
                  switch (num3)
                  {
                    case 1:
                    case 15:
                      goto label_19;
                    case 2:
                      FileSystemFileStoreProvider.bVgMVJWCuPvX8OY39nqD((object) systemFile1, FileSystemFileStoreProvider.TjV9mtWCZeWsUixZb8fV((object) binaryFile));
                      num3 = 22;
                      continue;
                    case 3:
                      if (FileSystemFileStoreProvider.OHIHnqWCfZNEnMyPI1Li(FileSystemFileStoreProvider.T6pqnWWCEyAkKEfZa5a6((object) systemFile1), Guid.Empty))
                      {
                        num3 = 19;
                        continue;
                      }
                      goto case 6;
                    case 4:
                      FileSystemFileStoreProvider.c1oklHWCnYm6QcxofQWx((object) binaryFile, false);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
                      continue;
                    case 5:
                      FileSystemFileStoreProvider.gaC7jVWCq0IyFu0BFvCX((object) systemFile1, FileSystemFileStoreProvider.oj12U7WCRH9SGPDFp2eN((object) this.SystemFileManager, (object) systemFile1));
                      num3 = 11;
                      continue;
                    case 6:
                      FileSystemFileStoreProvider.a2P0npWCvx261HlQJK6r((object) systemFile1, binaryFile.Uid);
                      num3 = 16;
                      continue;
                    case 7:
                      this.Encrypt(systemFile1, (string) FileSystemFileStoreProvider.CbicZdWCOAYPJglA3BX9((object) fileEncryptData), fileEncryptData.Salt);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 5 : 15;
                      continue;
                    case 8:
                      FileSystemFileStoreProvider.At6vZoWCkT1pHQiWF9jx((object) this, (object) systemFile1, (object) binaryFile);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 4 : 4;
                      continue;
                    case 9:
label_30:
                      dictionary.Remove(binaryFile.Uid);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 7 : 6;
                      continue;
                    case 10:
                      systemFile1.FileSize = new long?(FileSystemFileStoreProvider.Br8ooaWCS9BqIt9cMsTJ((object) binaryFile));
                      num3 = 14;
                      continue;
                    case 11:
                      uri = ((IStorageOperationsProvider) FileSystemFileStoreProvider.vEA5BFWCK9YpiBvQ6HPm((object) this)).SaveContent(binaryFile.ContentLocation, systemFile1, FileSystemFileStoreProvider.mmlTF3WCXLYQ8ZuPao98((object) binaryFile));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 23 : 23;
                      continue;
                    case 12:
                      fileEncryptData = (FileEncryptData) null;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 25 : 25;
                      continue;
                    case 13:
                      systemFile2 = this.SystemFileManager.LoadFile(FileSystemFileStoreProvider.HJV403WQz9oIxyeKZUoO((object) binaryFile));
                      if (systemFile2 == null)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 18 : 15;
                        continue;
                      }
                      break;
                    case 14:
                      FileSystemFileStoreProvider.xaoNSHWCi8egLXt5YXqA((object) systemFile1, false);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 5 : 3;
                      continue;
                    case 16:
                      FileSystemFileStoreProvider.L4lLFUWC8UissaqMAKXj((object) systemFile1, FileSystemFileStoreProvider.pwPeWRWCoaDhEFeoegbE((object) binaryFile));
                      num3 = 2;
                      continue;
                    case 17:
                      FileSystemFileStoreProvider.txcOcZWCGCdx9v38TiTn((object) this, (object) binaryFile);
                      num3 = 13;
                      continue;
                    case 18:
                      systemFile2 = new SystemFile();
                      break;
                    case 19:
                      FileSystemFileStoreProvider.eeZP1MWCCg1kShv0hCjy((object) systemFile1, FileSystemFileStoreProvider.k7TNmDWCQBPhhUd8TJIa((object) binaryFile));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 6 : 1;
                      continue;
                    case 20:
                      num4 = dictionary.TryGetValue(binaryFile.Uid, out fileEncryptData) ? 1 : 0;
                      goto label_54;
                    case 21:
                      if (!string.IsNullOrEmpty((string) FileSystemFileStoreProvider.oL6SFQWCbe6V3WoQImtX((object) binaryFile)))
                      {
                        num3 = 24;
                        continue;
                      }
                      goto case 17;
                    case 22:
                      FileSystemFileStoreProvider.R6dwNNWCVf2diMPf9UHA((object) systemFile1, (object) binaryFile.GetCrc().ToString((IFormatProvider) FileSystemFileStoreProvider.GrcXM7WCIMLvc7IupXrB()));
                      num3 = 10;
                      continue;
                    case 23:
                      FileSystemFileStoreProvider.l7IbIgWCTSrVC5ALBFfM((object) this, (object) binaryFile, (object) uri);
                      num3 = 8;
                      continue;
                    case 24:
                      FileSystemFileStoreProvider.s1YiV9WCh03a5CvOm5jA((object) binaryFile, (object) null);
                      num3 = 17;
                      continue;
                    case 25:
                      if (ContextVars.TryGetValue<Dictionary<Guid, FileEncryptData>>((string) FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(-1350312861 << 3 ^ 2082425170), out dictionary))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 20 : 6;
                        continue;
                      }
                      num4 = 0;
                      goto label_54;
                    default:
                      BinaryFile binaryFile1 = binaryFile;
                      guid = FileSystemFileStoreProvider.T6pqnWWCEyAkKEfZa5a6((object) systemFile1);
                      string str2 = guid.ToString();
                      binaryFile1.Id = str2;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 12 : 6;
                      continue;
                  }
                  systemFile1 = systemFile2;
                  num3 = 3;
                  continue;
label_54:
                  if (num4 == 0)
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 1 : 1;
                  else
                    goto label_30;
                }
              }
              catch (Exception ex)
              {
                int num5 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
                  num5 = 1;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      FileSystemFileStoreProvider.Hdj8quWCepXKdcnLt788((object) this.Logger, FileSystemFileStoreProvider.R57rr5WC2c2bvo7qa0Cc((object) ex), (object) ex);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_60;
                  }
                }
label_60:
                throw;
              }
            case 9:
label_19:
              if (!FileSystemFileStoreProvider.OHIHnqWCfZNEnMyPI1Li(binaryFile.Uid, Guid.Empty))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 17 : 16;
                continue;
              }
              goto label_66;
            case 10:
              if (Locator.Initialized)
              {
                num2 = 16;
                continue;
              }
              goto default;
            case 11:
              str1 = (string) FileSystemFileStoreProvider.YLkZMkWCBWOSpCbBxbGX((object) binaryFile);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 10 : 4;
              continue;
            case 13:
              binaryFile.ContentType = (string) FileSystemFileStoreProvider.covDZxWCWMnUmd2s2G3O((object) service, (object) str1);
              num2 = 5;
              continue;
            case 14:
              goto label_65;
            case 15:
              FileSystemFileStoreProvider.WRFrqaWCFPgyirfaRD6L((object) binaryFile, Guid.NewGuid());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 3 : 1;
              continue;
            case 16:
              if ((service = Locator.GetService<IMimeMappingService>()) == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 3 : 12;
                continue;
              }
              goto case 13;
            case 17:
              guid = FileSystemFileStoreProvider.HJV403WQz9oIxyeKZUoO((object) binaryFile);
              num2 = 14;
              continue;
            default:
              if (!this.initialized)
                goto case 9;
              else
                goto label_63;
          }
        }
label_63:
        num1 = 4;
      }
label_65:
      return guid.ToString();
label_66:
      return (string) null;
    }

    /// <summary>Выполнить действия после сохранения файла.</summary>
    /// <param name="file">Сохранённый системный файл.</param>
    /// <param name="binaryFile">Сохранённый файл.</param>
    protected virtual void PostSaveActions(SystemFile file, BinaryFile binaryFile)
    {
    }

    /// <summary>Выполнить действия перед сохранением файла.</summary>
    /// <param name="binaryFile">Сохраняемый файл.</param>
    protected virtual void PreSaveActions(BinaryFile binaryFile)
    {
      int num1 = 3;
      BinaryFile binaryFile1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            binaryFile1 = binaryFile;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
            continue;
          case 3:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 2 : 2;
            continue;
          default:
            this.componentsPreUploadFile.ForEach<IPreUploadFile>((Action<IPreUploadFile>) (a =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    FileSystemFileStoreProvider.\u003C\u003Ec__DisplayClass48_0.tEq1FJQ3kGVmvaRhEnZB((object) a, (object) binaryFile1);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 1 : 1;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Обновить местоположение контента.</summary>
    /// <param name="binaryFile">Файл.</param>
    /// <param name="newLocation">Новое местоположение контента.</param>
    protected virtual void UpdateBinaryFileLocation(BinaryFile binaryFile, Uri newLocation)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            FileSystemFileStoreProvider.eGOmdNWCPS2Zot9ddNPt((object) binaryFile, (object) newLocation);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Зашифровать файл.</summary>
    /// <param name="file">Шифруемый файл.</param>
    /// <param name="password">Пароль шифрования.</param>
    /// <param name="salt">Соль шифрования.</param>
    public override void Encrypt(BinaryFile file, string password, string salt)
    {
      int num = 11;
      SystemFile systemFile;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            goto label_17;
          case 2:
            if (systemFile != null)
            {
              num = 5;
              continue;
            }
            goto case 6;
          case 3:
            goto label_9;
          case 4:
            Dictionary<Guid, FileEncryptData> orAdd = ContextVars.GetOrAdd<Dictionary<Guid, FileEncryptData>>((string) FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(--1867379187 ^ 1867275193), (Func<Dictionary<Guid, FileEncryptData>>) (() => new Dictionary<Guid, FileEncryptData>()));
            Guid uid = file.Uid;
            FileEncryptData fileEncryptData = new FileEncryptData();
            fileEncryptData.Salt = salt;
            FileSystemFileStoreProvider.vGal2WWCpvMWavp4O4J2((object) fileEncryptData, (object) password);
            orAdd[uid] = fileEncryptData;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 1 : 1;
            continue;
          case 5:
            this.Encrypt(systemFile, password, salt);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 0;
            continue;
          case 6:
            if (FileSystemFileStoreProvider.OHIHnqWCfZNEnMyPI1Li(FileSystemFileStoreProvider.HJV403WQz9oIxyeKZUoO((object) file), Guid.Empty))
            {
              num = 7;
              continue;
            }
            goto case 4;
          case 7:
            FileSystemFileStoreProvider.WRFrqaWCFPgyirfaRD6L((object) file, FileSystemFileStoreProvider.QMcLjVWC32j5wmxunVT5());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 2 : 4;
            continue;
          case 8:
            if (!FileSystemFileStoreProvider.fJ2kkiWC16MbYk3rSP6V((object) file))
            {
              num = 9;
              continue;
            }
            goto label_10;
          case 9:
            systemFile = (SystemFile) FileSystemFileStoreProvider.SYSpO6WCNZN0xTTRbZbw((object) this.SystemFileManager, FileSystemFileStoreProvider.HJV403WQz9oIxyeKZUoO((object) file));
            num = 2;
            continue;
          case 10:
            goto label_2;
          case 11:
            if (!this.initialized)
            {
              num = 10;
              continue;
            }
            goto case 8;
          default:
            goto label_11;
        }
      }
label_3:
      return;
label_17:
      return;
label_9:
      return;
label_2:
      return;
label_11:
      return;
label_10:;
    }

    private void Encrypt(SystemFile systemFile, string password, string salt)
    {
      int num = 2;
      BinaryFileContentInfo binaryFileContentInfo;
      while (true)
      {
        switch (num)
        {
          case 1:
            binaryFileContentInfo = ((IStorageOperationsProvider) FileSystemFileStoreProvider.vEA5BFWCK9YpiBvQ6HPm((object) this)).EncryptContent(systemFile, password);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 5 : 0;
            continue;
          case 2:
            FileSystemFileStoreProvider.HTaVT0WCawwFGtejQ0QG((object) systemFile, (object) salt);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 1 : 1;
            continue;
          case 3:
            FileSystemFileStoreProvider.R6dwNNWCVf2diMPf9UHA((object) systemFile, (object) FileSystemFileStoreProvider.SBd9ugWCDfbbwmcXsutl((object) binaryFileContentInfo).ToString((IFormatProvider) FileSystemFileStoreProvider.GrcXM7WCIMLvc7IupXrB()));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
            continue;
          case 4:
            goto label_2;
          case 5:
            ((IStorageOperationsProvider) FileSystemFileStoreProvider.vEA5BFWCK9YpiBvQ6HPm((object) this)).SaveContent(binaryFileContentInfo.ContentLocation, systemFile, true);
            num = 3;
            continue;
          case 6:
            this.SystemFileManager.InsertFile(systemFile);
            num = 4;
            continue;
          default:
            systemFile.FileSize = new long?(FileSystemFileStoreProvider.lCTSG1WCtQSqGOCL8kYx((object) binaryFileContentInfo));
            num = 6;
            continue;
        }
      }
label_2:;
    }

    /// <summary>
    /// Расшифровать файл (будет создаваться временный файл на сервере).
    /// </summary>
    /// <param name="file">Дешифруемый файл.</param>
    /// <param name="password">Пароль шифрования.</param>
    public override BinaryFile Decrypt(BinaryFile file, string password)
    {
      int num = 3;
      SystemFile systemFile;
      BinaryFileContentInfo binaryFileContentInfo;
      while (true)
      {
        switch (num)
        {
          case 1:
            systemFile = (SystemFile) FileSystemFileStoreProvider.SYSpO6WCNZN0xTTRbZbw((object) this.SystemFileManager, file.Uid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
            continue;
          case 2:
            if (FileSystemFileStoreProvider.fJ2kkiWC16MbYk3rSP6V((object) file))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 1;
              continue;
            }
            goto label_2;
          case 3:
            if (this.initialized)
            {
              num = 2;
              continue;
            }
            goto label_2;
          case 4:
            goto label_2;
          case 5:
            goto label_5;
          default:
            binaryFileContentInfo = (BinaryFileContentInfo) FileSystemFileStoreProvider.fhrfnCWCw0UO6lPqmLM8(FileSystemFileStoreProvider.vEA5BFWCK9YpiBvQ6HPm((object) this), (object) systemFile, (object) password);
            num = 5;
            continue;
        }
      }
label_2:
      return file;
label_5:
      return (BinaryFile) FileSystemFileStoreProvider.p9YHHlWCAIrOcVOiF1ou(FileSystemFileStoreProvider.qUNSQxWCHxCZnsBAMhfP(FileSystemFileStoreProvider.pStENnWC4CRDcZUe0HQV((object) file), FileSystemFileStoreProvider.RJvH4ZWC6PW8q8HVFpR3((object) binaryFileContentInfo), binaryFileContentInfo.ContentLength, binaryFileContentInfo.Crc));
    }

    /// <summary>
    /// Отмена шифрования для файла (снятие шифрования с файла).
    /// </summary>
    /// <param name="file">Файл, с которого будет снято шифрование.</param>
    /// <param name="password">Пароль шифрования.</param>
    [Transaction]
    public override void CancelEncrypt(BinaryFile file, string password)
    {
      int num1 = 15;
      while (true)
      {
        int num2 = num1;
        IFilePreviewService service;
        SystemFile systemFile;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (FileSystemFileStoreProvider.bnFO7VWCyuZEcc52N64A((object) service, (object) file, (object) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 4 : 1;
                continue;
              }
              goto label_26;
            case 2:
              systemFile = (SystemFile) FileSystemFileStoreProvider.SYSpO6WCNZN0xTTRbZbw((object) this.SystemFileManager, FileSystemFileStoreProvider.HJV403WQz9oIxyeKZUoO((object) file));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 6 : 8;
              continue;
            case 3:
              FileSystemFileStoreProvider.quF5HyWCmL6KJGJkPSDL((object) systemFile, false);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 6 : 7;
              continue;
            case 4:
              goto label_4;
            case 5:
              FileSystemFileStoreProvider.NFjQL3WC0r2TQwd7lkCq((object) systemFile, (object) null);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 3 : 1;
              continue;
            case 6:
              if (FileSystemFileStoreProvider.fJ2kkiWC16MbYk3rSP6V((object) file))
              {
                file.Encrypt = false;
                num2 = 13;
                continue;
              }
              goto label_13;
            case 7:
              FileSystemFileStoreProvider.oj12U7WCRH9SGPDFp2eN((object) this.SystemFileManager, (object) systemFile);
              num2 = 12;
              continue;
            case 8:
              if (systemFile == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
                continue;
              }
              goto case 5;
            case 9:
              goto label_23;
            case 10:
              FileSystemFileStoreProvider.hT53vMWCx73TXAwt4HID((object) this, (object) file);
              num2 = 2;
              continue;
            case 11:
              goto label_8;
            case 13:
              FileSystemFileStoreProvider.dDDj6sWC7VyxWvUwAssO((object) file, (object) null);
              num2 = 10;
              continue;
            case 14:
              goto label_17;
            case 15:
              if (!this.initialized)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 4 : 14;
                continue;
              }
              goto case 6;
            case 16:
              if (service != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 1;
                continue;
              }
              goto label_3;
            default:
              service = Locator.GetService<IFilePreviewService>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 10 : 16;
              continue;
          }
        }
label_4:
        FileSystemFileStoreProvider.J02i9oWCMUBBThx1UpS7((object) service, (object) file, 0L);
        num1 = 11;
        continue;
label_13:
        num1 = 9;
      }
label_23:
      return;
label_8:
      return;
label_17:
      return;
label_3:
      return;
label_26:;
    }

    private bool StoreOnCommit(BinaryFile binaryFile)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            ContextVars.GetOrAdd<Dictionary<Guid, BinaryFile>>((string) FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(1461825605 - 1531863589 ^ -70064546), (Func<Dictionary<Guid, BinaryFile>>) (() => new Dictionary<Guid, BinaryFile>()))[FileSystemFileStoreProvider.HJV403WQz9oIxyeKZUoO((object) binaryFile)] = binaryFile;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 3 : 1;
            continue;
          case 2:
            if (binaryFile != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 1 : 0;
              continue;
            }
            goto label_4;
          case 3:
            goto label_6;
          default:
            goto label_4;
        }
      }
label_4:
      return false;
label_6:
      return ContextVars.GetOrAdd<bool>((string) FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(-1822890472 ^ -1822863612), (Func<bool>) (() => true));
    }

    /// <summary>Переименовать файл в хранилище</summary>
    /// <param name="id">Идентификатор файла</param>
    /// <param name="fileName">Имя файла</param>
    /// <exception cref="T:System.ArgumentException">Идентификатор должен представлять целое число или Guid</exception>
    /// <returns>Переименован ли файл</returns>
    public override string RenameFile(string id, string fileName)
    {
      string str;
      switch (1)
      {
        case 1:
          try
          {
            int result1 = 0;
            int num = 6;
            while (true)
            {
              Guid result2;
              object obj;
              switch (num)
              {
                case 1:
                  obj = (object) this.SystemFileManager.RenameFile(result2, fileName);
                  break;
                case 2:
                  if (FileSystemFileStoreProvider.yUFHIyWC9XwUZdCpqfmR(result2, Guid.Empty))
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 1;
                    continue;
                  }
                  goto case 3;
                case 3:
                  obj = FileSystemFileStoreProvider.Hbb4YVWCdQJJ8mq7Ev2T((object) this.SystemFileManager, result1, (object) fileName);
                  break;
                case 4:
                  goto label_8;
                case 5:
                  if (int.TryParse(id, out result1))
                  {
                    num = 2;
                    continue;
                  }
                  goto label_8;
                case 6:
                  if (!Guid.TryParse(id, out result2))
                  {
                    num = 5;
                    continue;
                  }
                  goto case 2;
                default:
                  goto label_18;
              }
              str = (string) FileSystemFileStoreProvider.nqo3oSWClPPwrilrg1r7(obj);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
            }
label_8:
            throw new ArgumentException((string) FileSystemFileStoreProvider.up3qLTWCJBVts8sYkhWP((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(277947046 - -1479185048 ^ 1757028300)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1581325282 << 3 ^ -234230678));
          }
          catch (Exception ex)
          {
            int num = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
              num = 1;
            while (true)
            {
              switch (num)
              {
                case 1:
                  FileSystemFileStoreProvider.Hdj8quWCepXKdcnLt788((object) this.Logger, (object) EleWise.ELMA.SR.T((string) FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(~1767720452 ^ -1767697767)), (object) ex);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
                  continue;
                default:
                  goto label_17;
              }
            }
label_17:
            throw;
          }
      }
label_18:
      return str;
    }

    /// <summary>Копировать файл</summary>
    /// <param name="sourceBinaryFile">Бинарный файл источник</param>
    /// <exception cref="T:System.ArgumentNullException">sourceBinaryFile is null</exception>
    [Transaction]
    public override BinaryFile CopyFile(BinaryFile sourceBinaryFile)
    {
      int num = 3;
      BinaryFile binaryFile;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_7;
          case 2:
            binaryFile = (BinaryFile) FileSystemFileStoreProvider.p9YHHlWCAIrOcVOiF1ou((object) ((BinaryFileBuilder) FileSystemFileStoreProvider.S5pgj4WCrY1iJHPJYJ58(FileSystemFileStoreProvider.pStENnWC4CRDcZUe0HQV((object) sourceBinaryFile), FileSystemFileStoreProvider.QMcLjVWC32j5wmxunVT5())).Created(FileSystemFileStoreProvider.vYp6YCWCgb8bCrKZSDDA()).Content(sourceBinaryFile.GetContent(GetContentOptions.NonSeekable), true));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 0 : 0;
            continue;
          case 3:
            Contract.ArgumentNotNull((object) sourceBinaryFile, (string) FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(-1350312861 << 3 ^ 2082425020));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 2;
            continue;
          case 4:
            goto label_6;
          default:
            if (FileSystemFileStoreProvider.Fa8ZhRWC5CnSDV2bivuD(FileSystemFileStoreProvider.hT53vMWCx73TXAwt4HID((object) this, (object) binaryFile)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 1;
              continue;
            }
            goto label_6;
        }
      }
label_6:
      return binaryFile;
label_7:
      return (BinaryFile) null;
    }

    /// <summary>Загрузить файл</summary>
    /// <param name="id">Идентификатор файла</param>
    /// <returns>Загруженный файл</returns>
    /// <exception cref="T:System.ArgumentException">Идентификатор должен представлять целое число</exception>
    /// <exception cref="T:System.ArgumentException">Контрольная сумма файла должна представлять беззнаковое целое число</exception>
    /// <exception cref="T:System.IO.FileNotFoundException">Если файл не найден в хранилище</exception>
    /// <exception cref="T:System.IO.FileNotFoundException">Если CRC файла не соответствует оригинальному</exception>
    public override BinaryFile LoadFile(string id)
    {
      int num = 3;
      Dictionary<Guid, BinaryFile> dictionary;
      Guid result;
      BinaryFile binaryFile;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            if (!ContextVars.TryGetValue<Dictionary<Guid, BinaryFile>>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1251470110 >> 2 ^ 312758969), out dictionary))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
              continue;
            }
            goto case 8;
          case 3:
            if (Guid.TryParse(id, out result))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 1 : 2;
              continue;
            }
            if (int.TryParse(id, out int _))
            {
              num = 4;
              continue;
            }
            goto label_4;
          case 5:
            goto label_13;
          case 6:
            goto label_4;
          case 8:
            if (!dictionary.TryGetValue(result, out binaryFile))
            {
              num = 7;
              continue;
            }
            goto label_13;
          default:
            if (!this.initialized)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 1 : 1;
              continue;
            }
            goto label_3;
        }
      }
label_2:
      return (BinaryFile) null;
label_3:
      return (BinaryFile) FileSystemFileStoreProvider.FIZAfZWCjjJYcmSXrLnh((object) this, (object) id);
label_4:
      return (BinaryFile) null;
label_13:
      return binaryFile;
    }

    /// <summary>Получить загруженный файл.</summary>
    /// <param name="id">Идентификатор файла.</param>
    /// <returns>Файл.</returns>
    protected virtual BinaryFile GetLoadedBinaryFile(string id) => (BinaryFile) new FileSystemFileStoreProvider.LazyBinaryFile(id, this.privateFilesPath, !this.ignoreNotExistsFiles);

    /// <summary>
    /// Загрузить BinaryFile полностью (развернуть LazyBinaryFile).
    /// </summary>
    /// <param name="id">Идентификатор файла.</param>
    /// <returns>Загруженный файл.</returns>
    protected BinaryFile LoadFileUnwrapped(string id)
    {
      object obj = FileSystemFileStoreProvider.jKux5NWCYr5aSEPp4wFR((object) this, (object) id);
      FileSystemFileStoreProvider.pwPeWRWCoaDhEFeoegbE(obj);
      FileSystemFileStoreProvider.tohkq6WCLVIHB31MrHkI(obj);
      return (BinaryFile) obj;
    }

    /// <summary>Загрузить файлы</summary>
    /// <param name="idList">Массив идентификаторов файлов</param>
    /// <returns>Загруженные файлы</returns>
    public override BinaryFile[] LoadFiles(string[] idList)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!this.initialized)
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
      return (BinaryFile[]) null;
label_3:
      return (BinaryFile[]) FileSystemFileStoreProvider.huER4TWCUvlbox2RUcoD((object) this, (object) idList);
    }

    /// <summary>Загрузить файлы по списку.</summary>
    /// <param name="idList">Массив идентификаторов загружаемых файлов.</param>
    /// <returns>Массив загруженных файлов.</returns>
    protected virtual BinaryFile[] LoadFilesNonLazy(string[] idList)
    {
      int num1 = 13;
      string str;
      List<BinaryFile> binaryFileList;
      while (true)
      {
        int num2 = num1;
        int result1;
        BinaryFile binaryFile1;
        string[] strArray;
        while (true)
        {
          int index;
          List<Guid> guidList;
          SystemFile systemFile;
          Uri sourceContentLocation;
          Guid result2;
          SystemFile[] systemFileArray;
          List<long> longList;
          switch (num2)
          {
            case 1:
            case 20:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 22 : 0;
              continue;
            case 2:
              goto label_20;
            case 3:
              BinaryFile binaryFile2 = new BinaryFile();
              FileSystemFileStoreProvider.YdEy3VWvFkkiUOLFO09A((object) binaryFile2, FileSystemFileStoreProvider.hnOHIjWCzdwsQddAn7m9((object) systemFile));
              FileSystemFileStoreProvider.eGOmdNWCPS2Zot9ddNPt((object) binaryFile2, (object) sourceContentLocation);
              FileSystemFileStoreProvider.bsbVPXWvBSIYW5ICSIvC((object) binaryFile2, systemFile.CreateDate);
              FileSystemFileStoreProvider.fAqpjDWvWewJN4csDtLC((object) binaryFile2, FileSystemFileStoreProvider.nqo3oSWClPPwrilrg1r7((object) systemFile));
              binaryFile2.Uid = FileSystemFileStoreProvider.T6pqnWWCEyAkKEfZa5a6((object) systemFile);
              binaryFile1 = binaryFile2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 18 : 0;
              continue;
            case 4:
            case 22:
              if (index >= strArray.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 14 : 12;
                continue;
              }
              goto case 5;
            case 5:
              str = strArray[index];
              num2 = 24;
              continue;
            case 6:
            case 7:
              if (index >= systemFileArray.Length)
              {
                num2 = 9;
                continue;
              }
              goto case 16;
            case 8:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 7 : 6;
              continue;
            case 9:
              goto label_12;
            case 10:
              if (int.TryParse(str, out result1))
                break;
              goto label_6;
            case 11:
              goto label_27;
            case 12:
              guidList = new List<Guid>();
              num2 = 11;
              continue;
            case 13:
              longList = new List<long>();
              num2 = 12;
              continue;
            case 14:
              object obj = FileSystemFileStoreProvider.qVvdB1WCcffclfB4vIy6((object) this.SystemFileManager, FileSystemFileStoreProvider.DTFihWWCs4atIbbrkCR8((object) longList), (object) guidList.ToArray());
              binaryFileList = new List<BinaryFile>();
              systemFileArray = (SystemFile[]) obj;
              num2 = 21;
              continue;
            case 15:
              if (!Guid.TryParse(str, out result2))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 10 : 8;
                continue;
              }
              break;
            case 16:
              systemFile = systemFileArray[index];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 19 : 18;
              continue;
            case 17:
label_8:
              guidList.Add(result2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 1 : 1;
              continue;
            case 18:
              binaryFile1.Id = FileSystemFileStoreProvider.T6pqnWWCEyAkKEfZa5a6((object) systemFile).ToString();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 23 : 3;
              continue;
            case 19:
              sourceContentLocation = this.StorageOperationsProvider.GetSourceContentLocation(systemFile);
              num2 = 3;
              continue;
            case 21:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 1 : 6;
              continue;
            case 23:
              FileSystemFileStoreProvider.qbJdV6WvbpEGr4SETEY3((object) binaryFile1, (object) FileSystemFileStoreProvider.IqiKf4WvoNJ4MuIlpmb1((object) systemFile).ToString((IFormatProvider) FileSystemFileStoreProvider.GrcXM7WCIMLvc7IupXrB()));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 1 : 2;
              continue;
            case 24:
              goto label_9;
            case 25:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 2 : 4;
              continue;
            case 26:
              goto label_23;
            default:
              longList.Add((long) result1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 16 : 20;
              continue;
          }
          if (FileSystemFileStoreProvider.OHIHnqWCfZNEnMyPI1Li(result2, Guid.Empty))
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
          else
            goto label_8;
        }
label_6:
        num1 = 26;
        continue;
label_9:
        result1 = 0;
        num1 = 15;
        continue;
label_20:
        binaryFileList.Add(binaryFile1);
        num1 = 8;
        continue;
label_27:
        strArray = idList;
        num1 = 25;
      }
label_12:
      return (BinaryFile[]) FileSystemFileStoreProvider.Vn8WHPWvh5XyX5PmHRco((object) binaryFileList);
label_23:
      throw new ArgumentException(EleWise.ELMA.SR.T((string) FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(-1487388570 ^ -1487279186), (object) str));
    }

    /// <summary>Проверить, существует ли файл в хранилище</summary>
    /// <param name="id">Идентификатор файла</param>
    /// <returns>True, если существует</returns>
    public override bool FileExists(string id)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!this.initialized)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return false;
label_3:
      return FileSystemFileStoreProvider.YFO3VNWvGXX1bqq2NT5s((object) this.SystemFileManager, (object) id) != null;
    }

    /// <summary>Получить размер файла из хранилища</summary>
    /// <param name="id">Идентификатор файла</param>
    /// <returns>Размер файла в байтах</returns>
    public override long FileSize(string id)
    {
      int num1 = 4;
      long? fileSize;
      SystemFile file;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              fileSize = file.FileSize;
              num2 = 5;
              continue;
            case 2:
              if (!file.IsDeleted)
              {
                num2 = 11;
                continue;
              }
              goto label_5;
            case 3:
              goto label_7;
            case 4:
              if (this.initialized)
              {
                file = (SystemFile) FileSystemFileStoreProvider.YFO3VNWvGXX1bqq2NT5s((object) this.SystemFileManager, (object) id);
                num2 = 10;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 3;
              continue;
            case 5:
              goto label_15;
            case 6:
              if (!fileSize.HasValue)
              {
                num2 = 8;
                continue;
              }
              goto case 1;
            case 7:
              FileSystemFileStoreProvider.oj12U7WCRH9SGPDFp2eN((object) this.SystemFileManager, (object) file);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 1 : 1;
              continue;
            case 8:
              goto label_10;
            case 9:
              goto label_16;
            case 10:
              if (file != null)
              {
                num2 = 2;
                continue;
              }
              goto label_16;
            case 11:
              fileSize = file.FileSize;
              num2 = 6;
              continue;
            default:
              goto label_5;
          }
        }
label_10:
        file.FileSize = new long?(FileSystemFileStoreProvider.mydxOpWvE10sEZWa3w4J((object) this, (object) file));
        num1 = 7;
      }
label_5:
      return this.GetDeletedFileLength(file);
label_7:
      return -1;
label_15:
      return fileSize.Value;
label_16:
      throw new FileNotFoundException(EleWise.ELMA.SR.T((string) FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(1461825605 - 1531863589 ^ -70065566), (object) id));
    }

    /// <summary>
    /// Получить размер файла для записи о файле без заполненного размера.
    /// </summary>
    /// <param name="file">Системный файл.</param>
    /// <returns>Длина файла.</returns>
    protected virtual long GetFileLength(SystemFile file)
    {
      int num = 2;
      long? contentSize;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (contentSize.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
              continue;
            }
            goto case 4;
          case 2:
            contentSize = ((IStorageOperationsProvider) FileSystemFileStoreProvider.vEA5BFWCK9YpiBvQ6HPm((object) this)).GetContentSize(file);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_7;
          case 4:
            if (this.ignoreNotExistsFiles)
            {
              num = 3;
              continue;
            }
            goto label_8;
          default:
            goto label_9;
        }
      }
label_7:
      return FileSystemFileStoreProvider.TsB4VpWvCyTnG0oeBxup(FileSystemFileStoreProvider.FEAe4oWvQgIRbIjGRnrp(FileSystemFileStoreProvider.CLUaO8WvfTVd5RYLLBSg(FileSystemFileStoreProvider.nqo3oSWClPPwrilrg1r7((object) file))));
label_8:
      throw new FileNotFoundException(EleWise.ELMA.SR.T((string) FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(-867826612 ^ -867718938), (object) file.Id));
label_9:
      return contentSize.Value;
    }

    private static void MarkSystemFileAsEncrypt(object file, object salt)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            FileSystemFileStoreProvider.NFjQL3WC0r2TQwd7lkCq(file, salt);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            FileSystemFileStoreProvider.quF5HyWCmL6KJGJkPSDL(file, true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 2;
            continue;
        }
      }
label_2:;
    }

    /// <summary>
    /// Получить длину контента-заглушки, если исходный контент был удалён.
    /// </summary>
    /// <param name="file"></param>
    /// <returns>Длина контента-заглушки.</returns>
    protected virtual long GetDeletedFileLength(SystemFile file) => FileSystemFileStoreProvider.TsB4VpWvCyTnG0oeBxup(FileSystemFileStoreProvider.FEAe4oWvQgIRbIjGRnrp(FileSystemFileStoreProvider.CLUaO8WvfTVd5RYLLBSg((object) file.Name)));

    private static string CreateFileDelete(object privateFilesPath, object storePath)
    {
      int num1 = 5;
      FileStream fileStream;
      string str;
      while (true)
      {
        FileInfo fileInfo;
        object obj;
        switch (num1)
        {
          case 1:
            fileStream = (FileStream) FileSystemFileStoreProvider.OlxEENWvZDgqeAKDnZM2((object) fileInfo);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
            continue;
          case 2:
            if (!FileSystemFileStoreProvider.Yd4ShhWv8fHaRx2SLOkN((object) fileInfo))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 1 : 1;
              continue;
            }
            goto label_4;
          case 3:
            obj = (object) str;
            break;
          case 4:
            if (FileSystemFileStoreProvider.notFoundExtensions.Contains((string) FileSystemFileStoreProvider.XglHwnWvvNl280IEDor8((object) str)))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 3 : 3;
              continue;
            }
            goto case 9;
          case 5:
            str = (string) FileSystemFileStoreProvider.FEAe4oWvQgIRbIjGRnrp(storePath);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 4 : 3;
            continue;
          case 6:
            storePath = (object) Path.Combine((string) privateFilesPath, (string) FileSystemFileStoreProvider.OKX2EnWQxYL1v96cCmMl(FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(-138018305 ^ -137908989), (object) str));
            num1 = 8;
            continue;
          case 7:
            goto label_4;
          case 8:
            fileInfo = new FileInfo((string) storePath);
            num1 = 2;
            continue;
          case 9:
            obj = FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(-398663332 ^ -398635604);
            break;
          default:
            goto label_11;
        }
        str = (string) obj;
        num1 = 6;
      }
label_4:
      return (string) storePath;
label_11:
      try
      {
        byte[] buffer = (byte[]) FileSystemFileStoreProvider.v19nRHWvu8fdHDxjcjCl((object) EleWise.ELMA.Properties.Resources.ResourceManager, (object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(-643786247 ^ -643746583) + str.Remove(0, 1)));
        int num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
          num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              fileStream.Write(buffer, 0, buffer.Length);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
      }
      finally
      {
        int num3;
        if (fileStream == null)
          num3 = 2;
        else
          goto label_19;
label_18:
        switch (num3)
        {
          case 1:
          case 2:
        }
label_19:
        FileSystemFileStoreProvider.IlWmTDWvIPVdgSQNhGwX((object) fileStream);
        num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
        {
          num3 = 1;
          goto label_18;
        }
        else
          goto label_18;
      }
    }

    private static string CreateFileNotFound(object privateFilesPath, object storePath)
    {
      int num1 = 6;
      FileStream fileStream;
      string str;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          FileInfo fileInfo;
          object obj;
          switch (num2)
          {
            case 1:
              fileStream = (FileStream) FileSystemFileStoreProvider.OlxEENWvZDgqeAKDnZM2((object) fileInfo);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 2 : 2;
              continue;
            case 2:
              goto label_6;
            case 4:
              fileInfo = new FileInfo((string) storePath);
              num2 = 7;
              continue;
            case 5:
              if (!FileSystemFileStoreProvider.notFoundExtensions.Contains((string) FileSystemFileStoreProvider.XglHwnWvvNl280IEDor8((object) str)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 8 : 4;
                continue;
              }
              obj = (object) str;
              break;
            case 6:
              str = (string) FileSystemFileStoreProvider.FEAe4oWvQgIRbIjGRnrp(storePath);
              num2 = 5;
              continue;
            case 7:
              if (!FileSystemFileStoreProvider.Yd4ShhWv8fHaRx2SLOkN((object) fileInfo))
                goto case 1;
              else
                goto label_20;
            case 8:
              obj = FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(-342626196 - 1290888215 ^ -1633476443);
              break;
            case 9:
              storePath = FileSystemFileStoreProvider.Ty5XGhWQYVexiHXqAD85(privateFilesPath, (object) ((string) FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(-1204263869 ^ -1341583247 ^ 137418958) + str));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 2 : 4;
              continue;
            default:
              goto label_16;
          }
          str = (string) obj;
          num2 = 9;
        }
label_20:
        num1 = 3;
      }
label_6:
      try
      {
        byte[] buffer = (byte[]) FileSystemFileStoreProvider.v19nRHWvu8fdHDxjcjCl(FileSystemFileStoreProvider.Wq1aPwWvViH6Qxh6aTtr(), (object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(1819636893 << 3 ^ 1672088056) + (string) FileSystemFileStoreProvider.EAebepWvS6uyQKtvhfHw((object) str, 0, 1)));
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_16;
            default:
              fileStream.Write(buffer, 0, buffer.Length);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 1 : 1;
              continue;
          }
        }
      }
      finally
      {
        int num4;
        if (fileStream == null)
          num4 = 2;
        else
          goto label_13;
label_12:
        switch (num4)
        {
          case 1:
          case 2:
        }
label_13:
        FileSystemFileStoreProvider.IlWmTDWvIPVdgSQNhGwX((object) fileStream);
        num4 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
        {
          num4 = 1;
          goto label_12;
        }
        else
          goto label_12;
      }
label_16:
      return (string) storePath;
    }

    /// <summary>
    /// Получить размер контента-заглушки (для случая, когда исходный контент отсутствует).
    /// </summary>
    /// <param name="extension">Расширение исходного файла.</param>
    /// <returns>Размер контента-заглушки.</returns>
    protected static long GetNotFoundStubSize(string extension) => (long) ((byte[]) FileSystemFileStoreProvider.v19nRHWvu8fdHDxjcjCl(FileSystemFileStoreProvider.Wq1aPwWvViH6Qxh6aTtr(), FileSystemFileStoreProvider.OKX2EnWQxYL1v96cCmMl(FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(-1939377524 ^ -1939415140), FileSystemFileStoreProvider.EAebepWvS6uyQKtvhfHw((object) extension, 0, 1)))).Length;

    /// <summary>Получить контент-заглушку.</summary>
    /// <param name="extension">Расширение исходного файла.</param>
    /// <returns>Контент заглушки в виде потока.</returns>
    protected static Stream GetNotFoundStubStreamFromResources(string extension) => (Stream) MemoryHelper.GetMemoryStream((byte[]) ((ResourceManager) FileSystemFileStoreProvider.Wq1aPwWvViH6Qxh6aTtr()).GetObject((string) FileSystemFileStoreProvider.OKX2EnWQxYL1v96cCmMl((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420849098), FileSystemFileStoreProvider.EAebepWvS6uyQKtvhfHw((object) extension, 0, 1))), false);

    /// <summary>Получить ближайшее местоположение контента.</summary>
    /// <param name="id">Идентификатор файла.</param>
    /// <returns>Местоположение контента.</returns>
    protected internal virtual Uri GetLazyFileLocation(string id)
    {
      int num = 1;
      SystemFile systemFile;
      while (true)
      {
        switch (num)
        {
          case 1:
            systemFile = (SystemFile) FileSystemFileStoreProvider.YFO3VNWvGXX1bqq2NT5s((object) this.SystemFileManager, (object) id);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          case 3:
            goto label_5;
          default:
            if (systemFile != null)
            {
              num = 3;
              continue;
            }
            goto label_4;
        }
      }
label_4:
      throw new FileNotFoundException(EleWise.ELMA.SR.T((string) FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(-281842504 ^ -281886470), (object) id));
label_5:
      return (Uri) FileSystemFileStoreProvider.CSUkmTWvipjPCPb3okLT((object) this.StorageOperationsProvider, (object) systemFile);
    }

    /// <summary>
    /// Асинхронно скопировать файл в ближайшее к серверу хранилище файлов.
    /// </summary>
    /// <param name="id">Идентификатор файла.</param>
    /// <param name="token">Токен отмены.</param>
    /// <returns>Асинхронная системная задача копирования файла.</returns>
    protected virtual Task CopyToNearestStorageAsync(string id, CancellationToken token) => CompletedTask.Default;

    /// <summary>Асинхронно загрузить файл из хранилища файлов.</summary>
    /// <param name="id">Идентификатор файла.</param>
    /// <param name="token">Токен отмены.</param>
    /// <returns>Асинхронная системная задача копирования файла.</returns>
    public virtual Task<BinaryFile> LoadFileAsync(string id, CancellationToken token) => this.CopyToNearestStorageAsync(id, token).Then<BinaryFile>((Func<BinaryFile>) (() =>
    {
      int num1 = 1;
      CallContextSessionOwner contextSessionOwner;
      while (true)
      {
        switch (num1)
        {
          case 1:
            // ISSUE: reference to a compiler-generated method
            contextSessionOwner = (CallContextSessionOwner) FileSystemFileStoreProvider.\u003C\u003Ec__DisplayClass74_0.dBTXxnQ3p24oIXnAWtsP();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_13;
          default:
            goto label_2;
        }
      }
label_2:
      BinaryFile binaryFile;
      try
      {
        binaryFile = this.LoadFileUnwrapped(id);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        if (contextSessionOwner != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_11;
              default:
                // ISSUE: reference to a compiler-generated method
                FileSystemFileStoreProvider.\u003C\u003Ec__DisplayClass74_0.vc36MHQ3a8CXitANBACU((object) contextSessionOwner);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 1 : 0;
                continue;
            }
          }
        }
label_11:;
      }
label_13:
      return binaryFile;
    }), token);

    private void ThrowIfWritingToPersistantFile(BinaryFile binaryFile)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!FileSystemFileStoreProvider.ylLctpWvRMyaIenxPscI(FileSystemFileStoreProvider.oL6SFQWCbe6V3WoQImtX((object) binaryFile)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:
      throw new NotSupportedException((string) FileSystemFileStoreProvider.up3qLTWCJBVts8sYkhWP(FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(~289714581 ^ -289742004)));
    }

    /// <summary>Получить поток для предоставленного файла.</summary>
    /// <param name="binaryFile">Файл.</param>
    /// <param name="options">Требуемые характеристики потока.</param>
    /// <returns>Поток.</returns>
    public virtual Stream GetContent(BinaryFile binaryFile, GetContentOptions options = null)
    {
      int num = 5;
      SystemFile systemFile;
      while (true)
      {
        GetContentOptions getContentOptions1;
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            if (systemFile != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 1 : 1;
              continue;
            }
            goto label_5;
          case 3:
            this.Logger.DebugFormat((string) FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(1052221104 - 768835541 ^ 283489139), FileSystemFileStoreProvider.tohkq6WCLVIHB31MrHkI((object) binaryFile), (object) FileSystemFileStoreProvider.UmXqvQWvq36flwwha90M((object) options), (object) FileSystemFileStoreProvider.eLF0OyWvK1nXCl2Fi38e((object) options));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
            continue;
          case 4:
            getContentOptions1 = GetContentOptions.Default;
            break;
          case 5:
            GetContentOptions getContentOptions2 = options;
            if (getContentOptions2 == null)
            {
              num = 4;
              continue;
            }
            getContentOptions1 = getContentOptions2;
            break;
          default:
            systemFile = (SystemFile) FileSystemFileStoreProvider.SYSpO6WCNZN0xTTRbZbw((object) this.SystemFileManager, FileSystemFileStoreProvider.HJV403WQz9oIxyeKZUoO((object) binaryFile));
            num = 2;
            continue;
        }
        options = getContentOptions1;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 3 : 1;
      }
label_4:
      return this.StorageOperationsProvider.OpenPersistentContentReadStream(systemFile, options);
label_5:
      return this.StorageOperationsProvider.OpenTempContentReadStream((Uri) FileSystemFileStoreProvider.tohkq6WCLVIHB31MrHkI((object) binaryFile), options);
    }

    /// <summary>
    /// Поместить контент в файл из указанного потока. После выполнения операции входящий поток будет закрыт.
    /// </summary>
    /// <param name="binaryFile">Файл.</param>
    /// <param name="content">Контент.</param>
    /// <param name="options">Параметры операции помещения контента.</param>
    /// <exception cref="T:System.InvalidOperationException">Нельзя открыть поток на запись для файла в постоянном хранилище</exception>
    public void PutContent(BinaryFile binaryFile, Stream content, PutContentOptions options = null)
    {
      int num1 = 3;
      Stream stream1;
      Stream stream2;
      BinaryFile binaryFile1;
      while (true)
      {
        PutContentOptions putContentOptions1;
        switch (num1)
        {
          case 1:
            putContentOptions1 = PutContentOptions.Default;
            break;
          case 2:
            binaryFile1 = binaryFile;
            num1 = 4;
            continue;
          case 3:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 2;
            continue;
          case 4:
            PutContentOptions putContentOptions2 = options;
            if (putContentOptions2 == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 1;
              continue;
            }
            putContentOptions1 = putContentOptions2;
            break;
          case 5:
            goto label_32;
          case 6:
            this.ThrowIfWritingToPersistantFile(binaryFile1);
            num1 = 7;
            continue;
          case 7:
            stream1 = ((IStorageOperationsProvider) FileSystemFileStoreProvider.vEA5BFWCK9YpiBvQ6HPm((object) this)).OpenTempContentWriteStream((Action<Uri>) (location =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    FileSystemFileStoreProvider.\u003C\u003Ec__DisplayClass77_0.VuyyacQ36a5HZxNdieoB((object) binaryFile1, (object) location);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }), options);
            num1 = 8;
            continue;
          case 8:
            stream2 = stream1;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
        options = putContentOptions1;
        num1 = 6;
      }
label_32:
      return;
label_2:
      try
      {
        Crc32 crc32 = new Crc32();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
          num3 = 0;
        switch (num3)
        {
          default:
            try
            {
              MemoryHelper.ActionWithMemoryBuffer<byte, (Stream, Stream, Crc32)>(1048576, (content, stream1, crc32), new MemoryHelper.ActionWithMemoryBufferAndParameterDelegate<byte, (Stream, Stream, Crc32)>(this.PutContentCRC32Action));
              int num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
                num4 = 2;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    FileSystemFileStoreProvider.nxdiSCWvOeJ3E9IXmqAd((object) binaryFile1, FileSystemFileStoreProvider.echXVSWvnnnoWUYZU9Dm((object) crc32));
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 3 : 0;
                    continue;
                  case 2:
                    FileSystemFileStoreProvider.mnBLaTWvXydwkOOdiPnV((object) crc32);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
                    continue;
                  case 3:
                    goto label_23;
                  default:
                    FileSystemFileStoreProvider.CDf1pFWvkjsIrOKCN8B6((object) binaryFile1, FileSystemFileStoreProvider.L0Ki8KWvTckRO7CtM0rx((object) stream1));
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 1;
                    continue;
                }
              }
label_23:
              break;
            }
            finally
            {
              if (crc32 != null)
              {
                int num5 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
                  num5 = 1;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      FileSystemFileStoreProvider.IlWmTDWvIPVdgSQNhGwX((object) crc32);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_18;
                  }
                }
              }
label_18:;
            }
        }
      }
      finally
      {
        if (stream2 != null)
        {
          int num6 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
            num6 = 0;
          while (true)
          {
            switch (num6)
            {
              case 1:
                goto label_25;
              default:
                FileSystemFileStoreProvider.IlWmTDWvIPVdgSQNhGwX((object) stream2);
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 1 : 0;
                continue;
            }
          }
        }
label_25:;
      }
    }

    private void PutContentCRC32Action(
      byte[] buffer,
      int offset,
      int length,
      (Stream, Stream, Crc32) param)
    {
      int num;
      do
      {
        (Stream stream1, Stream stream2, Crc32 crc32) = param;
        num = stream1.Read(buffer, offset, length);
        if (num > 0)
        {
          crc32.HashBlock(buffer, offset, num);
          stream2.Write(buffer, offset, num);
        }
      }
      while (num > 0);
    }

    /// <summary>
    /// Асинхронно поместить контент в файл из указанного потока.
    /// </summary>
    /// <param name="binaryFile">Файл.</param>
    /// <param name="content">Контент.</param>
    /// <param name="options">Параметры операции помещения контента.</param>
    /// <returns>Асинхронную задачу копирования контента.</returns>
    public Task PutContentAsync(BinaryFile binaryFile, Stream content, PutContentOptions options = null)
    {
      int num = 1;
      while (true)
      {
        PutContentOptions putContentOptions1;
        switch (num)
        {
          case 1:
            PutContentOptions putContentOptions2 = options;
            if (putContentOptions2 == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 0;
              continue;
            }
            putContentOptions1 = putContentOptions2;
            break;
          case 2:
            goto label_5;
          case 3:
            this.ThrowIfWritingToPersistantFile(binaryFile);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 2 : 2;
            continue;
          default:
            putContentOptions1 = PutContentOptions.Default;
            break;
        }
        options = putContentOptions1;
        num = 3;
      }
label_5:
      throw new NotImplementedException();
    }

    /// <summary>Вычислить хеш.</summary>
    /// <param name="binaryFile">Файл.</param>
    /// <param name="algorithm">Алгоритм хеширования.</param>
    /// <returns>Хеш.</returns>
    public string GetHash(BinaryFile binaryFile, HashAlogrithmEnum algorithm)
    {
      int num = 1;
      SystemFile systemFile;
      while (true)
      {
        switch (num)
        {
          case 1:
            systemFile = (SystemFile) FileSystemFileStoreProvider.a2aauTWv2AY8dosjMeK7((object) this.SystemFileManager, FileSystemFileStoreProvider.HJV403WQz9oIxyeKZUoO((object) binaryFile));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return ((IStorageOperationsProvider) FileSystemFileStoreProvider.vEA5BFWCK9YpiBvQ6HPm((object) this)).GetContentHash(systemFile, algorithm);
    }

    /// <summary>Асинхронно вычислить хеш.</summary>
    /// <param name="binaryFile">Файл.</param>
    /// <param name="algorithm">Алгоритм хеширования.</param>
    /// <param name="token">Токен отмены.</param>
    /// <returns>Задачу, которая представляет работу по вычислению хеша.</returns>
    public Task<string> GetHashAsync(
      BinaryFile binaryFile,
      HashAlogrithmEnum algorithm,
      CancellationToken token)
    {
      return this.StorageOperationsProvider.GetContentHashAsync(this.SystemFileManager.LoadFileRequired(binaryFile.Uid), algorithm, token);
    }

    /// <summary>
    /// Инициализировать местоположение контента.
    /// Создаёт ссылку на контент, но не создаёт сам файл.
    /// </summary>
    /// <param name="binaryFile">Файл, у которого будет инициализировано местоположение контента.</param>
    /// <returns>Ссылку на местоположение контента.</returns>
    Uri IBinaryFileLegacyBehaviorProvider.InitializeContentLocation(BinaryFile binaryFile) => new Uri(BinaryFile.CreateContentFilePath(binaryFile.Name));

    /// <summary>Получить размер контента в режиме совместимости.</summary>
    /// <param name="binaryFile">Файл, размер которого нужно определить.</param>
    /// <returns>Размер файла, либо null, если файл не существует.</returns>
    long? IBinaryFileLegacyBehaviorProvider.GetLength(BinaryFile binaryFile)
    {
      long? length = new long?();
      Uri contentLocation = binaryFile.ContentLocation;
      string localPath = !(contentLocation != (Uri) null) || !(contentLocation.Scheme == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1255365154 ^ 596875508 ^ -1765929262)) ? (string) null : contentLocation.LocalPath;
      if (!localPath.IsNullOrEmpty())
      {
        FileInfo fileInfo = new FileInfo(localPath);
        if (fileInfo.Exists)
          length = new long?(fileInfo.Length);
      }
      return length;
    }

    /// <summary>Получить crc файла в режиме совместимости.</summary>
    /// <param name="binaryFile">Файл, crc которого нужно определить.</param>
    /// <returns>Crc файла, либо null, если файл не существует.</returns>
    uint? IBinaryFileLegacyBehaviorProvider.GetCrc(BinaryFile binaryFile)
    {
      uint? crc = new uint?();
      Uri contentLocation = binaryFile.ContentLocation;
      string localPath = !(contentLocation != (Uri) null) || !(contentLocation.Scheme == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488804301)) ? (string) null : contentLocation.LocalPath;
      if (!localPath.IsNullOrEmpty() && new FileInfo(localPath).Exists)
        crc = new uint?(Crc32.GetCrcValue(localPath));
      return crc;
    }

    /// <summary>Зарегистрировать</summary>
    /// <param name="parameters">Параметры для регистрации</param>
    public void Register(NHManagerRegisterParams parameters)
    {
      int num1 = 4;
      IStartInformation startInformation;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_18;
          case 2:
            startInformation = StartInformation.Operation(99.0, (string) FileSystemFileStoreProvider.sylKQXWveH3sZ0eGyJuU(FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(1925118608 << 2 ^ -889568254)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
            continue;
          case 3:
            goto label_9;
          case 4:
            if (!this.initialized)
            {
              num1 = 3;
              continue;
            }
            goto case 2;
          default:
            goto label_3;
        }
      }
label_18:
      return;
label_9:
      return;
label_3:
      try
      {
        FileSystemFileStoreProvider.aaPhOnWvPNOoYIOuVhAO((object) this, (object) parameters);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
          num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_16;
            case 1:
              this.RegisterExtendedBinaryFileProviders((ContainerBuilder) FileSystemFileStoreProvider.axH4XNWv11uPkL4IUtwA((object) parameters));
              num2 = 2;
              continue;
            case 2:
              FileSystemFileStoreProvider.TqcEsVWvN5QeTkCskFMV((object) this, FileSystemFileStoreProvider.axH4XNWv11uPkL4IUtwA((object) parameters));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
              continue;
            default:
              goto label_13;
          }
        }
label_16:
        return;
label_13:;
      }
      finally
      {
        int num3;
        if (startInformation == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 1 : 1;
        else
          goto label_14;
label_12:
        switch (num3)
        {
          case 2:
            break;
          default:
        }
label_14:
        FileSystemFileStoreProvider.IlWmTDWvIPVdgSQNhGwX((object) startInformation);
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0)
        {
          num3 = 0;
          goto label_12;
        }
        else
          goto label_12;
      }
    }

    /// <summary>
    /// Зарегистрировать менеджеры, необходимые для работы провайдера.
    /// </summary>
    /// <param name="parameters">Параметры для регистрации менеджеров.</param>
    protected virtual void RegisterManagers(NHManagerRegisterParams parameters)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: type reference
            ((ContainerBuilder) FileSystemFileStoreProvider.axH4XNWv11uPkL4IUtwA((object) parameters)).RegisterNHManager(FileSystemFileStoreProvider.k8UC08Wv34gfPyeouddv(__typeref (SystemFileNHManager))).As<SystemFileNHManager>().SingleInstance();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            parameters.Add<SystemFileMetadataMap>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    /// <summary>
    /// Зарегистрировать дополнительные службы, необходимые для работы провайдера.
    /// </summary>
    /// <param name="containerBuilder">Контейнер Autofac.</param>
    protected virtual void RegisterAdditionalServices(ContainerBuilder containerBuilder)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            // ISSUE: type reference
            // ISSUE: type reference
            containerBuilder.RegisterInstance<FileSystemFileStoreProvider>(this).As(FileSystemFileStoreProvider.k8UC08Wv34gfPyeouddv(__typeref (IFileGatewayService)), FileSystemFileStoreProvider.k8UC08Wv34gfPyeouddv(__typeref (IBinaryFileHashService))).SingleInstance();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
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
    /// Зарегистрировать дополнительные провайдеры, работающие с объектами <see cref="T:EleWise.ELMA.Files.BinaryFile" />.
    /// </summary>
    /// <param name="containerBuilder">Контейнер Autofac.</param>
    protected virtual void RegisterExtendedBinaryFileProviders(ContainerBuilder containerBuilder)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            // ISSUE: type reference
            // ISSUE: type reference
            // ISSUE: type reference
            containerBuilder.RegisterInstance<FileSystemFileStoreProvider>(this).As(FileSystemFileStoreProvider.k8UC08Wv34gfPyeouddv(__typeref (IBinaryFileStreams)), FileSystemFileStoreProvider.k8UC08Wv34gfPyeouddv(__typeref (IBinaryFileAsyncLoader)), FileSystemFileStoreProvider.k8UC08Wv34gfPyeouddv(__typeref (IBinaryFileLegacyBehaviorProvider))).SingleInstance();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Ближайший к серверу ELMA файловый шлюз.</summary>
    string IFileGatewayService.SystemGateway => string.Empty;

    /// <summary>Все имена файловых шлюзов.</summary>
    string[] IFileGatewayService.AllGateways => new string[0];

    /// <summary>Получить ближайший к пользователю файловый шлюз.</summary>
    /// <returns>Уникальное идентификатор файлового шлюза.</returns>
    string IFileGatewayService.GetClosestGateway() => string.Empty;

    /// <summary>
    /// Получить точку хранения, к которой прикреплён данный пользователь.
    /// </summary>
    /// <param name="user">Пользователь.</param>
    /// <returns>
    /// Идентификатор закреплённой за пользователем точки хранения (индивидуальное сопоставление), либо null, если сопоставление отсутствует.
    /// </returns>
    string IFileGatewayService.GetUserGateway(IUser user) => string.Empty;

    /// <summary>Указать шлюз, к которому будет привязан пользователь.</summary>
    /// <param name="user">Пользователь.</param>
    /// <param name="gateway">Уникальное имя шлюза.</param>
    void IFileGatewayService.SetUserGateway(IUser user, string gateway)
    {
    }

    static FileSystemFileStoreProvider()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            FileSystemFileStoreProvider.notFoundExtensions = (IList<string>) new string[18]
            {
              (string) FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(-477139494 ^ -477221506),
              (string) FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(-97972138 ^ -98021146),
              (string) FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(825385222 ^ 825434552),
              (string) FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(1819636893 << 3 ^ 1672088180),
              (string) FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(-345420348 ^ -345447572),
              (string) FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(1581325282 << 3 ^ -234262108),
              (string) FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(-218496594 ^ -218387106),
              (string) FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(-53329496 >> 4 ^ -3298732),
              (string) FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(-1380439818 << 3 ^ 1841330702),
              (string) FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(1033719030 - 2012070891 ^ -978400609),
              (string) FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(1925118608 << 2 ^ -889530486),
              (string) FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(-1837662597 ^ -1837743187),
              (string) FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(-1598106783 - -968262081 ^ -629905216),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -576068604),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767638441),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487330554),
              (string) FileSystemFileStoreProvider.zjGtgwWQH4ZdBdwcPAiW(-2092274397 << 4 ^ 883391728),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099644005)
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
            continue;
          case 2:
            FileSystemFileStoreProvider.BxCLkOWQ6cNg7WloU7c4();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static void BxCLkOWQ6cNg7WloU7c4() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object zjGtgwWQH4ZdBdwcPAiW(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool agAHIXWQwPnKP7Csrxhf() => FileSystemFileStoreProvider.asrIwLWQt4N0iq3l3VrP == null;

    internal static FileSystemFileStoreProvider wkDxnQWQ4AF7FijOBYv3() => FileSystemFileStoreProvider.asrIwLWQt4N0iq3l3VrP;

    internal static bool Eg5apLWQApu3sMfYKK7y([In] object obj0) => ((ILogger) obj0).IsDebugEnabled();

    internal static object QMLaHHWQ7PNFBfRYdjiB([In] object obj0) => (object) ((IAuthenticationService) obj0).GetCurrentUser();

    internal static object OKX2EnWQxYL1v96cCmMl([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static void AReyowWQ0Kckm3BpBhgN([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object cadO6IWQmTh6igQ0FFB5([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((FileSystemFileStoreProvider) obj0).DoProviderSpecificInitialization((string) obj1, (NameValueCollection) obj2);

    internal static void Kjcq2VWQyZ1AgRROCN04([In] object obj0, [In] object obj1, [In] object obj2) => __nonvirtual (((ProviderBase) obj0).Initialize((string) obj1, (NameValueCollection) obj2));

    internal static bool uDS7aQWQMj4nE33ahKIX([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object OBV0MWWQJtY5GU8b8YwP([In] object obj0, [In] object obj1) => (object) ((NameValueCollection) obj0)[(string) obj1];

    internal static void eea7PgWQ9W5u1LQgRtWp([In] object obj0, [In] object obj1) => ((NameValueCollection) obj0).Remove((string) obj1);

    internal static void PtcISBWQdV4ZSIfBirCv([In] object obj0, [In] object obj1, [In] object obj2) => ((NameValueCollection) obj0).Add((string) obj1, (string) obj2);

    internal static object r0xjxRWQlZbrlGoT2HGl() => (object) ComponentManager.Current;

    internal static object QgPdWVWQrGEl5NMTRg33([In] object obj0) => (object) ((IRuntimeApplication) obj0).Configuration;

    internal static object xjsSIEWQgCUavKVs2qUd([In] object obj0) => (object) ((RuntimeConfiguration) obj0).Config;

    internal static object CWE5fZWQ5Gxf16FypDR8([In] object obj0) => (object) ((System.Configuration.Configuration) obj0).FilePath;

    internal static object yOOQQWWQjwviuNyt7mgY([In] object obj0) => (object) Path.GetDirectoryName((string) obj0);

    internal static object Ty5XGhWQYVexiHXqAD85([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static object gGWm3YWQL1xXAxg9YgPj([In] object obj0) => (object) IOExtensions.GetTempPath((string) obj0);

    internal static bool B3eXXMWQU4Gcbuv26ElV([In] object obj0) => Directory.Exists((string) obj0);

    internal static object AeUo83WQsLGPb8rFOfWc([In] object obj0) => (object) Directory.CreateDirectory((string) obj0);

    internal static object y5VjpYWQcdn8Pe1tkmNU([In] object obj0) => (object) ((FileSystemFileStoreProvider) obj0).CreateStorageOperationsProvider();

    internal static Guid HJV403WQz9oIxyeKZUoO([In] object obj0) => ((BinaryFile) obj0).Uid;

    internal static void WRFrqaWCFPgyirfaRD6L([In] object obj0, Guid value) => ((BinaryFile) obj0).Uid = value;

    internal static object YLkZMkWCBWOSpCbBxbGX([In] object obj0) => (object) ((BinaryFile) obj0).Extension;

    internal static object covDZxWCWMnUmd2s2G3O([In] object obj0, [In] object obj1) => (object) ((IMimeMappingService) obj0).GetTypeByExtension((string) obj1);

    internal static object pwPeWRWCoaDhEFeoegbE([In] object obj0) => (object) ((BinaryFile) obj0).Name;

    internal static object oL6SFQWCbe6V3WoQImtX([In] object obj0) => (object) ((BinaryFile) obj0).Id;

    internal static void s1YiV9WCh03a5CvOm5jA([In] object obj0, [In] object obj1) => ((BinaryFile) obj0).Id = (string) obj1;

    internal static void txcOcZWCGCdx9v38TiTn([In] object obj0, [In] object obj1) => ((FileSystemFileStoreProvider) obj0).PreSaveActions((BinaryFile) obj1);

    internal static Guid T6pqnWWCEyAkKEfZa5a6([In] object obj0) => ((SystemFile) obj0).Uid;

    internal static bool OHIHnqWCfZNEnMyPI1Li([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static DateTime k7TNmDWCQBPhhUd8TJIa([In] object obj0) => ((BinaryFile) obj0).CreateDate;

    internal static void eeZP1MWCCg1kShv0hCjy([In] object obj0, DateTime value) => ((SystemFile) obj0).CreateDate = value;

    internal static void a2P0npWCvx261HlQJK6r([In] object obj0, Guid value) => ((SystemFile) obj0).Uid = value;

    internal static void L4lLFUWC8UissaqMAKXj([In] object obj0, [In] object obj1) => ((SystemFile) obj0).Name = (string) obj1;

    internal static object TjV9mtWCZeWsUixZb8fV([In] object obj0) => (object) ((BinaryFile) obj0).ContentType;

    internal static void bVgMVJWCuPvX8OY39nqD([In] object obj0, [In] object obj1) => ((SystemFile) obj0).ContentType = (string) obj1;

    internal static object GrcXM7WCIMLvc7IupXrB() => (object) CultureInfo.InvariantCulture;

    internal static void R6dwNNWCVf2diMPf9UHA([In] object obj0, [In] object obj1) => ((SystemFile) obj0).FileCrc = (string) obj1;

    internal static long Br8ooaWCS9BqIt9cMsTJ([In] object obj0) => ((BinaryFile) obj0).GetSize();

    internal static void xaoNSHWCi8egLXt5YXqA([In] object obj0, bool value) => ((SystemFile) obj0).IsDeleted = value;

    internal static int oj12U7WCRH9SGPDFp2eN([In] object obj0, [In] object obj1) => ((SystemFileNHManager) obj0).InsertFile((SystemFile) obj1);

    internal static void gaC7jVWCq0IyFu0BFvCX([In] object obj0, int value) => ((SystemFile) obj0).Id = value;

    internal static object vEA5BFWCK9YpiBvQ6HPm([In] object obj0) => (object) ((FileSystemFileStoreProvider) obj0).StorageOperationsProvider;

    internal static bool mmlTF3WCXLYQ8ZuPao98([In] object obj0) => ((BinaryFile) obj0).DeleteTempFileAfterSave;

    internal static void l7IbIgWCTSrVC5ALBFfM([In] object obj0, [In] object obj1, [In] object obj2) => ((FileSystemFileStoreProvider) obj0).UpdateBinaryFileLocation((BinaryFile) obj1, (Uri) obj2);

    internal static void At6vZoWCkT1pHQiWF9jx([In] object obj0, [In] object obj1, [In] object obj2) => ((FileSystemFileStoreProvider) obj0).PostSaveActions((SystemFile) obj1, (BinaryFile) obj2);

    internal static void c1oklHWCnYm6QcxofQWx([In] object obj0, bool value) => ((BinaryFile) obj0).DeleteTempFileAfterSave = value;

    internal static object CbicZdWCOAYPJglA3BX9([In] object obj0) => (object) ((FileEncryptData) obj0).Password;

    internal static object R57rr5WC2c2bvo7qa0Cc([In] object obj0) => (object) ((Exception) obj0).Message;

    internal static void Hdj8quWCepXKdcnLt788([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static void eGOmdNWCPS2Zot9ddNPt([In] object obj0, [In] object obj1) => ((BinaryFile) obj0).ContentLocation = (Uri) obj1;

    internal static bool fJ2kkiWC16MbYk3rSP6V([In] object obj0) => ((BinaryFile) obj0).Encrypt;

    internal static object SYSpO6WCNZN0xTTRbZbw([In] object obj0, Guid uid) => (object) ((SystemFileNHManager) obj0).LoadFile(uid);

    internal static Guid QMcLjVWC32j5wmxunVT5() => Guid.NewGuid();

    internal static void vGal2WWCpvMWavp4O4J2([In] object obj0, [In] object obj1) => ((FileEncryptData) obj0).Password = (string) obj1;

    internal static void HTaVT0WCawwFGtejQ0QG([In] object obj0, [In] object obj1) => FileSystemFileStoreProvider.MarkSystemFileAsEncrypt(obj0, obj1);

    internal static uint SBd9ugWCDfbbwmcXsutl([In] object obj0) => ((BinaryFileContentInfo) obj0).Crc;

    internal static long lCTSG1WCtQSqGOCL8kYx([In] object obj0) => ((BinaryFileContentInfo) obj0).ContentLength;

    internal static object fhrfnCWCw0UO6lPqmLM8([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((IStorageOperationsProvider) obj0).DecryptContent((SystemFile) obj1, (string) obj2);

    internal static object pStENnWC4CRDcZUe0HQV([In] object obj0) => (object) BinaryFile.CreateFrom((BinaryFile) obj0);

    internal static object RJvH4ZWC6PW8q8HVFpR3([In] object obj0) => (object) ((BinaryFileContentInfo) obj0).ContentLocation;

    internal static object qUNSQxWCHxCZnsBAMhfP(
      [In] object obj0,
      [In] object obj1,
      long contentLength,
      uint contentCrc)
    {
      return (object) ((BinaryFileBuilder) obj0).Content((Uri) obj1, contentLength, contentCrc);
    }

    internal static object p9YHHlWCAIrOcVOiF1ou([In] object obj0) => (object) ((BinaryFileBuilder) obj0).Build();

    internal static void dDDj6sWC7VyxWvUwAssO([In] object obj0, [In] object obj1) => ((BinaryFile) obj0).Salt = (string) obj1;

    internal static object hT53vMWCx73TXAwt4HID([In] object obj0, [In] object obj1) => (object) ((FileStoreProvider) obj0).SaveFile((BinaryFile) obj1);

    internal static void NFjQL3WC0r2TQwd7lkCq([In] object obj0, [In] object obj1) => ((SystemFile) obj0).Salt = (string) obj1;

    internal static void quF5HyWCmL6KJGJkPSDL([In] object obj0, bool value) => ((SystemFile) obj0).Encrypt = value;

    internal static bool bnFO7VWCyuZEcc52N64A([In] object obj0, [In] object obj1, [In] object obj2) => ((IFilePreviewService) obj0).CheckPassword((BinaryFile) obj1, (string) obj2);

    internal static void J02i9oWCMUBBThx1UpS7([In] object obj0, [In] object obj1, long priority) => ((IFilePreviewService) obj0).AddPreviewWork((BinaryFile) obj1, priority);

    internal static object up3qLTWCJBVts8sYkhWP([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool yUFHIyWC9XwUZdCpqfmR([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static object Hbb4YVWCdQJJ8mq7Ev2T([In] object obj0, int id, [In] object obj2) => (object) ((SystemFileNHManager) obj0).RenameFile(id, (string) obj2);

    internal static object nqo3oSWClPPwrilrg1r7([In] object obj0) => (object) ((SystemFile) obj0).Name;

    internal static object S5pgj4WCrY1iJHPJYJ58([In] object obj0, Guid uid) => (object) ((BinaryFileBuilder) obj0).Uid(uid);

    internal static DateTime vYp6YCWCgb8bCrKZSDDA() => DateTime.Now;

    internal static bool Fa8ZhRWC5CnSDV2bivuD([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object FIZAfZWCjjJYcmSXrLnh([In] object obj0, [In] object obj1) => (object) ((FileSystemFileStoreProvider) obj0).GetLoadedBinaryFile((string) obj1);

    internal static object jKux5NWCYr5aSEPp4wFR([In] object obj0, [In] object obj1) => (object) ((FileStoreProvider) obj0).LoadFile((string) obj1);

    internal static object tohkq6WCLVIHB31MrHkI([In] object obj0) => (object) ((BinaryFile) obj0).ContentLocation;

    internal static object huER4TWCUvlbox2RUcoD([In] object obj0, [In] object obj1) => (object) ((FileSystemFileStoreProvider) obj0).LoadFilesNonLazy((string[]) obj1);

    internal static object DTFihWWCs4atIbbrkCR8([In] object obj0) => (object) ((List<long>) obj0).ToArray();

    internal static object qVvdB1WCcffclfB4vIy6([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((SystemFileNHManager) obj0).LoadFiles((long[]) obj1, (Guid[]) obj2);

    internal static object hnOHIjWCzdwsQddAn7m9([In] object obj0) => (object) ((SystemFile) obj0).ContentType;

    internal static void YdEy3VWvFkkiUOLFO09A([In] object obj0, [In] object obj1) => ((BinaryFile) obj0).ContentType = (string) obj1;

    internal static void bsbVPXWvBSIYW5ICSIvC([In] object obj0, DateTime value) => ((BinaryFile) obj0).CreateDate = value;

    internal static void fAqpjDWvWewJN4csDtLC([In] object obj0, [In] object obj1) => ((BinaryFile) obj0).Name = (string) obj1;

    internal static int IqiKf4WvoNJ4MuIlpmb1([In] object obj0) => ((SystemFile) obj0).Id;

    internal static void qbJdV6WvbpEGr4SETEY3([In] object obj0, [In] object obj1) => ((BinaryFile) obj0).SecondId = (string) obj1;

    internal static object Vn8WHPWvh5XyX5PmHRco([In] object obj0) => (object) ((List<BinaryFile>) obj0).ToArray();

    internal static object YFO3VNWvGXX1bqq2NT5s([In] object obj0, [In] object obj1) => (object) ((SystemFileNHManager) obj0).LoadFile((string) obj1);

    internal static long mydxOpWvE10sEZWa3w4J([In] object obj0, [In] object obj1) => ((FileSystemFileStoreProvider) obj0).GetFileLength((SystemFile) obj1);

    internal static object CLUaO8WvfTVd5RYLLBSg([In] object obj0) => (object) ((string) obj0).ReplaceInvalidFileNameChars();

    internal static object FEAe4oWvQgIRbIjGRnrp([In] object obj0) => (object) Path.GetExtension((string) obj0);

    internal static long TsB4VpWvCyTnG0oeBxup([In] object obj0) => FileSystemFileStoreProvider.GetNotFoundStubSize((string) obj0);

    internal static object XglHwnWvvNl280IEDor8([In] object obj0) => (object) ((string) obj0).ToLower();

    internal static bool Yd4ShhWv8fHaRx2SLOkN([In] object obj0) => ((FileSystemInfo) obj0).Exists;

    internal static object OlxEENWvZDgqeAKDnZM2([In] object obj0) => (object) ((FileInfo) obj0).Create();

    internal static object v19nRHWvu8fdHDxjcjCl([In] object obj0, [In] object obj1) => ((ResourceManager) obj0).GetObject((string) obj1);

    internal static void IlWmTDWvIPVdgSQNhGwX([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object Wq1aPwWvViH6Qxh6aTtr() => (object) EleWise.ELMA.Properties.Resources.ResourceManager;

    internal static object EAebepWvS6uyQKtvhfHw([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Remove(obj1, obj2);

    internal static object CSUkmTWvipjPCPb3okLT([In] object obj0, [In] object obj1) => (object) ((IStorageOperationsProvider) obj0).GetSourceContentLocation((SystemFile) obj1);

    internal static bool ylLctpWvRMyaIenxPscI([In] object obj0) => ((string) obj0).IsNullOrEmpty();

    internal static bool UmXqvQWvq36flwwha90M([In] object obj0) => ((GetContentOptions) obj0).ForAsync;

    internal static bool eLF0OyWvK1nXCl2Fi38e([In] object obj0) => ((GetContentOptions) obj0).Seekable;

    internal static object mnBLaTWvXydwkOOdiPnV([In] object obj0) => (object) ((Crc32) obj0).HashFinalBlock();

    internal static long L0Ki8KWvTckRO7CtM0rx([In] object obj0) => ((Stream) obj0).Position;

    internal static void CDf1pFWvkjsIrOKCN8B6([In] object obj0, long contentLength) => ((BinaryFile) obj0).SetSize(contentLength);

    internal static uint echXVSWvnnnoWUYZU9Dm([In] object obj0) => ((Crc32) obj0).CrcValue;

    internal static void nxdiSCWvOeJ3E9IXmqAd([In] object obj0, uint contentCrc) => ((BinaryFile) obj0).SetCrc(contentCrc);

    internal static object a2aauTWv2AY8dosjMeK7([In] object obj0, Guid uid) => (object) ((SystemFileNHManager) obj0).LoadFileRequired(uid);

    internal static object sylKQXWveH3sZ0eGyJuU([In] object obj0) => (object) EleWise.ELMA.SR.M((string) obj0);

    internal static void aaPhOnWvPNOoYIOuVhAO([In] object obj0, [In] object obj1) => ((FileSystemFileStoreProvider) obj0).RegisterManagers((NHManagerRegisterParams) obj1);

    internal static object axH4XNWv11uPkL4IUtwA([In] object obj0) => (object) ((NHManagerRegisterParams) obj0).Builder;

    internal static void TqcEsVWvN5QeTkCskFMV([In] object obj0, [In] object obj1) => ((FileSystemFileStoreProvider) obj0).RegisterAdditionalServices((ContainerBuilder) obj1);

    internal static Type k8UC08Wv34gfPyeouddv([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    /// <summary>Файл с ленивой загрузкой</summary>
    [Serializable]
    public class LazyBinaryFile : BinaryFile
    {
      private bool _loaded;
      private bool _fileLoaded;
      private readonly string _privateFilesPath;
      private readonly bool _checkFile;
      private Uri _location;
      private uint contentCrc;
      private long? contentLength;
      private bool fileWasStubbed;
      private static FileSystemFileStoreProvider.LazyBinaryFile itvTthQNLYCBxs2clHIC;

      /// <summary>Загружен ли файл</summary>
      public bool Loaded => this._loaded;

      /// <summary>Конструктор</summary>
      /// <param name="id"></param>
      /// <param name="privateFilesPath"></param>
      public LazyBinaryFile(string id, string privateFilesPath)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        this.\u002Ector(id, privateFilesPath, true);
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0)
          num = 0;
        switch (num)
        {
        }
      }

      /// <summary>Конструктор</summary>
      /// <param name="id"></param>
      /// <param name="privateFilesPath"></param>
      /// <param name="checkFile"></param>
      public LazyBinaryFile(string id, string privateFilesPath, bool checkFile)
      {
        FileSystemFileStoreProvider.LazyBinaryFile.wJcL8uQNcXKOwNYd2lfc();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num1 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
          num1 = 0;
        while (true)
        {
          int num2;
          switch (num1)
          {
            case 1:
              goto label_4;
            case 2:
              this._checkFile = checkFile;
              num2 = 3;
              break;
            case 3:
              this.Id = id;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 1 : 0;
              continue;
            default:
              this._privateFilesPath = privateFilesPath;
              num2 = 2;
              break;
          }
          num1 = num2;
        }
label_4:;
      }

      /// <summary>Если файл не загружен, то подгружает его</summary>
      /// <param name="loadFile">Загружать ли тело файла</param>
      internal override void CheckLoaded(bool loadFile = false)
      {
        int num1 = 2;
        SystemFileNHManager serviceNotNull;
        while (true)
        {
          switch (num1)
          {
            case 1:
              if (this._loaded)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 5;
                continue;
              }
              goto default;
            case 2:
              if (!loadFile)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 1 : 1;
                continue;
              }
              goto default;
            case 3:
              goto label_53;
            case 4:
              if (this._fileLoaded)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 7 : 0;
                continue;
              }
              goto case 8;
            case 5:
              goto label_48;
            case 6:
              if (!this._loaded)
              {
                num1 = 8;
                continue;
              }
              goto case 4;
            case 7:
              goto label_45;
            case 8:
              serviceNotNull = Locator.GetServiceNotNull<SystemFileNHManager>();
              num1 = 9;
              continue;
            case 9:
              goto label_2;
            default:
              if (loadFile)
              {
                num1 = 6;
                continue;
              }
              goto case 8;
          }
        }
label_53:
        return;
label_48:
        return;
label_45:
        return;
label_2:
        try
        {
          SystemFile systemFile = serviceNotNull.LoadFile(this.Id);
          int num2 = 28;
          string str;
          while (true)
          {
            int num3;
            uint crcValue;
            switch (num2)
            {
              case 1:
                this.contentCrc = FileSystemFileStoreProvider.LazyBinaryFile.GuSGSYQ3E50vuhPDeS3a((object) systemFile.FileCrc);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 1 : 26;
                continue;
              case 2:
                this._loaded = true;
                num2 = 17;
                continue;
              case 3:
                this.contentLength = systemFile.FileSize;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 1 : 0;
                continue;
              case 4:
                goto label_7;
              case 5:
                str = (string) FileSystemFileStoreProvider.LazyBinaryFile.cuJSYWQ3fKvmdK2rbVZg((object) this._privateFilesPath, (object) str);
                num2 = 16;
                continue;
              case 6:
                this.name = (string) FileSystemFileStoreProvider.LazyBinaryFile.pcmjUGQ3B0BnaAFJPAMt((object) systemFile);
                num2 = 20;
                continue;
              case 7:
                if (!FileSystemFileStoreProvider.LazyBinaryFile.fVkBKtQ3hPCEPLFgIkj6((object) str))
                {
                  num2 = 5;
                  continue;
                }
                goto case 10;
              case 8:
                base.Uid = FileSystemFileStoreProvider.LazyBinaryFile.KhqZOMQ3CetB6btIaXol((object) systemFile);
                num2 = 21;
                continue;
              case 9:
                if (FileSystemFileStoreProvider.LazyBinaryFile.fVkBKtQ3hPCEPLFgIkj6((object) str))
                {
                  num3 = 18;
                  break;
                }
                goto label_25;
              case 10:
              case 15:
                FileSystemFileStoreProvider.LazyBinaryFile.a7FkZ6Q3QHBpGeepLYuk((object) this, (object) new Uri(str));
                num2 = 24;
                continue;
              case 11:
                base.SecondId = systemFile.Id.ToString((IFormatProvider) CultureInfo.InvariantCulture);
                num2 = 2;
                continue;
              case 12:
                base.Encrypt = FileSystemFileStoreProvider.LazyBinaryFile.ntrgEkQ381tDQtHsWYsc((object) systemFile);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 22 : 2;
                continue;
              case 13:
                str = (string) FileSystemFileStoreProvider.LazyBinaryFile.v3CHSuQ3bo2PlniIPYYO((object) this._privateFilesPath, (object) str);
                num2 = 27;
                continue;
              case 14:
                if (!this._checkFile)
                {
                  num3 = 7;
                  break;
                }
                goto case 9;
              case 16:
                this.fileWasStubbed = true;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 8 : 10;
                continue;
              case 17:
                goto label_49;
              case 18:
                crcValue = FileSystemFileStoreProvider.LazyBinaryFile.GuSGSYQ3E50vuhPDeS3a(FileSystemFileStoreProvider.LazyBinaryFile.pqqd77Q3GZj4FORwj7rA((object) systemFile));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 25 : 25;
                continue;
              case 19:
                goto label_15;
              case 20:
                base.ContentType = systemFile.ContentType;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 12 : 3;
                continue;
              case 21:
                base.CreateDate = FileSystemFileStoreProvider.LazyBinaryFile.vb81mEQ3vC9GZgW78UB2((object) systemFile);
                num2 = 6;
                continue;
              case 22:
                base.Salt = (string) FileSystemFileStoreProvider.LazyBinaryFile.OXcSIOQ3ZCJ73BjfV6Jh((object) systemFile);
                num3 = 3;
                break;
              case 23:
                if (FileSystemFileStoreProvider.LazyBinaryFile.vQwkfoQ3o6fgbgEQABae((object) systemFile))
                {
                  num2 = 13;
                  continue;
                }
                goto case 14;
              case 24:
                this._fileLoaded = true;
                num2 = 8;
                continue;
              case 25:
                if (!Crc32.CheckCrc(str, crcValue))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 7 : 19;
                  continue;
                }
                goto case 10;
              case 26:
                if (FileSystemFileStoreProvider.LazyBinaryFile.wEwJESQ3Fn7YGW1cJ2E4((object) systemFile) > 0)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 11 : 3;
                  continue;
                }
                goto case 2;
              case 27:
                this.fileWasStubbed = true;
                num2 = 15;
                continue;
              case 28:
                if (systemFile != null)
                {
                  str = (string) FileSystemFileStoreProvider.LazyBinaryFile.lPvlyyQ3WT5gkTHJLcPW((object) this._privateFilesPath, (object) (FileSystemFileStoreProvider.LazyBinaryFile.wEwJESQ3Fn7YGW1cJ2E4((object) systemFile).ToString() + Path.GetExtension(((string) FileSystemFileStoreProvider.LazyBinaryFile.pcmjUGQ3B0BnaAFJPAMt((object) systemFile)).ReplaceInvalidFileNameChars())));
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 21 : 29;
                  continue;
                }
                num2 = 4;
                continue;
              case 29:
                if (loadFile)
                {
                  num2 = 23;
                  continue;
                }
                goto case 8;
              default:
                goto label_25;
            }
            num2 = num3;
          }
label_49:
          return;
label_7:
          throw new FileNotFoundException(EleWise.ELMA.SR.T((string) FileSystemFileStoreProvider.LazyBinaryFile.YnxSItQNz93r59SNKm1G(-1872275253 >> 6 ^ -29347551), (object) this.Id));
label_15:
          throw new InvalidDataException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-342626196 - 1290888215 ^ -1633159269), (object) str));
label_25:
          throw new FileNotFoundException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218137900), (object) str));
        }
        catch (Exception ex)
        {
          int num4 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
            num4 = 0;
          while (true)
          {
            switch (num4)
            {
              case 1:
                goto label_47;
              default:
                FileSystemFileStoreProvider.LazyBinaryFile.BK9abwQ3uC5HTyGqcsDh((object) EleWise.ELMA.Logging.Logger.GetLogger(z2jc63fLkugS1X8Q9N.tE1kD1vbB(825385222 ^ 825426638)), FileSystemFileStoreProvider.LazyBinaryFile.YnxSItQNz93r59SNKm1G(-1380439818 << 3 ^ 1841576932), (object) ex);
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 1 : 1;
                continue;
            }
          }
label_47:
          throw;
        }
      }

      /// <summary>Mime-type файла</summary>
      public override string ContentType
      {
        get
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                this.CheckLoaded(false);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
                continue;
              default:
                goto label_2;
            }
          }
label_2:
          return base.ContentType;
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
                base.ContentType = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
                continue;
              case 2:
                this.CheckLoaded(false);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 1;
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

      /// <summary>Дата создания файла</summary>
      public override DateTime CreateDate
      {
        get
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                this.CheckLoaded(false);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 0;
                continue;
              default:
                goto label_3;
            }
          }
label_3:
          return base.CreateDate;
        }
        set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                this.CheckLoaded(false);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
                continue;
              case 2:
                goto label_2;
              default:
                base.CreateDate = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 2 : 1;
                continue;
            }
          }
label_2:;
        }
      }

      /// <summary>Имя файла</summary>
      public override string Name
      {
        get
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                this.CheckLoaded(false);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
                continue;
              default:
                goto label_3;
            }
          }
label_3:
          return base.Name;
        }
        set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                this.CheckLoaded(false);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
                continue;
              case 2:
                goto label_2;
              default:
                base.Name = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 2 : 1;
                continue;
            }
          }
label_2:;
        }
      }

      /// <summary>Локальный путь до файла</summary>
      [Obsolete("Свойство устарело. Для доступа к контенту используйте GetContent() и PutContent().")]
      public override string ContentFilePath
      {
        get
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                this.CheckLoaded(false);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
                continue;
              default:
                goto label_2;
            }
          }
label_2:
          return (string) FileSystemFileStoreProvider.LazyBinaryFile.pWRhxwQ3IWeaubAL0G39((object) this.ContentLocation);
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
                FileSystemFileStoreProvider.LazyBinaryFile.a7FkZ6Q3QHBpGeepLYuk((object) this, (object) new Uri(value));
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 0;
                continue;
              case 2:
                this.CheckLoaded(false);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 1 : 0;
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

      /// <summary>Местоположение контента.</summary>
      public override Uri ContentLocation
      {
        get
        {
          int num = 2;
          Uri contentLocation;
          Uri location;
          while (true)
          {
            switch (num)
            {
              case 1:
                this._location = contentLocation = (Uri) FileSystemFileStoreProvider.LazyBinaryFile.oHQwRSQ3VgRsFXwyZUDo((object) Locator.GetServiceNotNull<FileSystemFileStoreProvider>(), (object) this.Id);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
                continue;
              case 2:
                location = this._location;
                if ((object) location == null)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 1 : 1;
                  continue;
                }
                goto label_2;
              default:
                goto label_6;
            }
          }
label_2:
          return location;
label_6:
          return contentLocation;
        }
        internal set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this._location = value;
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

      /// <summary>Уникальный идентификатор</summary>
      public override Guid Uid
      {
        get
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                this.CheckLoaded(false);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
                continue;
              default:
                goto label_3;
            }
          }
label_3:
          return base.Uid;
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
                base.Uid = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 0 : 0;
                continue;
              case 2:
                this.CheckLoaded(false);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 1 : 1;
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

      /// <summary>Если есть второй Id у файла (например Id из БД)</summary>
      public override string SecondId
      {
        get
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                this.CheckLoaded(false);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
                continue;
              default:
                goto label_2;
            }
          }
label_2:
          return base.SecondId;
        }
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
                base.SecondId = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
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

      /// <summary>Зашифровано или нет</summary>
      public override bool Encrypt
      {
        get
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                this.CheckLoaded(false);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
                continue;
              default:
                goto label_2;
            }
          }
label_2:
          return base.Encrypt;
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
                base.Encrypt = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 0;
                continue;
              case 2:
                this.CheckLoaded(false);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 1;
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

      /// <summary>Соль</summary>
      public override string Salt
      {
        get
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                this.CheckLoaded(false);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
                continue;
              default:
                goto label_2;
            }
          }
label_2:
          return base.Salt;
        }
        set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                this.CheckLoaded(false);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
                continue;
              case 2:
                goto label_2;
              default:
                base.Salt = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 2 : 0;
                continue;
            }
          }
label_2:;
        }
      }

      /// <summary>Получить размер.</summary>
      /// <returns>Размер файла.</returns>
      public override long GetSize()
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!this.contentLength.HasValue)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              this.CheckLoaded(false);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 1 : 0;
              continue;
            case 3:
              goto label_2;
            default:
              this.contentLength = new long?(FileSystemFileStoreProvider.LazyBinaryFile.LqTfAOQ3iDPJAZ3OHlfh(FileSystemFileStoreProvider.LazyBinaryFile.BeaAWnQ3ScgfH4OFUWEs(), (object) this.Id));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 3 : 2;
              continue;
          }
        }
label_2:
        return this.contentLength.Value;
      }

      /// <summary>Получить crc-32 файла.</summary>
      /// <returns>crc-32 файла.</returns>
      public override uint GetCrc()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.CheckLoaded(false);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        return this.contentCrc;
      }

      /// <summary>Получить содержимое BinaryFile в виде потока.</summary>
      /// <param name="options">Характеристики потока чтения.</param>
      /// <returns>Поток.</returns>
      public override Stream GetContent(GetContentOptions options = null)
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_2;
            case 2:
              if (this.fileWasStubbed)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 3:
              this.CheckLoaded(true);
              num = 2;
              continue;
            default:
              goto label_3;
          }
        }
label_2:
        return base.GetContent(options);
label_3:
        return (Stream) new FileStream(((Uri) FileSystemFileStoreProvider.LazyBinaryFile.S9hxiBQ3RBPaYjR09KMU((object) this)).LocalPath, FileMode.Open, FileAccess.Read);
      }

      /// <summary>Загружены ли свойства объекта BinaryFile?</summary>
      /// <returns>true - загружены, false - нет.</returns>
      protected override bool IsLoaded() => this.Loaded;

      internal static bool m48kAwQNU2EBqnIQLkmu() => FileSystemFileStoreProvider.LazyBinaryFile.itvTthQNLYCBxs2clHIC == null;

      internal static FileSystemFileStoreProvider.LazyBinaryFile TqygqyQNsEFNA1OInkov() => FileSystemFileStoreProvider.LazyBinaryFile.itvTthQNLYCBxs2clHIC;

      internal static void wJcL8uQNcXKOwNYd2lfc() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static object YnxSItQNz93r59SNKm1G(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static int wEwJESQ3Fn7YGW1cJ2E4([In] object obj0) => ((SystemFile) obj0).Id;

      internal static object pcmjUGQ3B0BnaAFJPAMt([In] object obj0) => (object) ((SystemFile) obj0).Name;

      internal static object lPvlyyQ3WT5gkTHJLcPW([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

      internal static bool vQwkfoQ3o6fgbgEQABae([In] object obj0) => ((SystemFile) obj0).IsDeleted;

      internal static object v3CHSuQ3bo2PlniIPYYO([In] object obj0, [In] object obj1) => (object) FileSystemFileStoreProvider.CreateFileDelete(obj0, obj1);

      internal static bool fVkBKtQ3hPCEPLFgIkj6([In] object obj0) => File.Exists((string) obj0);

      internal static object pqqd77Q3GZj4FORwj7rA([In] object obj0) => (object) ((SystemFile) obj0).FileCrc;

      internal static uint GuSGSYQ3E50vuhPDeS3a([In] object obj0) => BinaryFile.ParseCrc((string) obj0);

      internal static object cuJSYWQ3fKvmdK2rbVZg([In] object obj0, [In] object obj1) => (object) FileSystemFileStoreProvider.CreateFileNotFound(obj0, obj1);

      internal static void a7FkZ6Q3QHBpGeepLYuk([In] object obj0, [In] object obj1) => ((BinaryFile) obj0).ContentLocation = (Uri) obj1;

      internal static Guid KhqZOMQ3CetB6btIaXol([In] object obj0) => ((SystemFile) obj0).Uid;

      internal static DateTime vb81mEQ3vC9GZgW78UB2([In] object obj0) => ((SystemFile) obj0).CreateDate;

      internal static bool ntrgEkQ381tDQtHsWYsc([In] object obj0) => ((SystemFile) obj0).Encrypt;

      internal static object OXcSIOQ3ZCJ73BjfV6Jh([In] object obj0) => (object) ((SystemFile) obj0).Salt;

      internal static void BK9abwQ3uC5HTyGqcsDh([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Info(obj1, (Exception) obj2);

      internal static object pWRhxwQ3IWeaubAL0G39([In] object obj0) => (object) ((Uri) obj0).LocalPath;

      internal static object oHQwRSQ3VgRsFXwyZUDo([In] object obj0, [In] object obj1) => (object) ((FileSystemFileStoreProvider) obj0).GetLazyFileLocation((string) obj1);

      internal static object BeaAWnQ3ScgfH4OFUWEs() => (object) DataAccessManager.FileManager;

      internal static long LqTfAOQ3iDPJAZ3OHlfh([In] object obj0, [In] object obj1) => ((IFileManager) obj0).FileSize((string) obj1);

      internal static object S9hxiBQ3RBPaYjR09KMU([In] object obj0) => (object) ((BinaryFile) obj0).ContentLocation;
    }
  }
}
