// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.Modules.Importer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.BPMApps.Enum;
using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata.Services;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace EleWise.ELMA.Deploy.Import.Modules
{
  /// <summary>Импортер модуля/приложения</summary>
  internal sealed class Importer
  {
    private readonly IExportImportService exportImportService;
    private readonly ILogger logger;
    private readonly IModuleManager moduleManager;
    private readonly IModuleMetadataLoader moduleMetadataLoader;
    private static Importer YGlYoUEMb4hVsGbpar1s;

    /// <summary>Ctor</summary>
    /// <param name="exportImportService">Сервис экспорта/импорта</param>
    /// <param name="moduleManager">Менеджер управления модулями</param>
    /// <param name="moduleMetadataLoader">Сервис загрузки метаданных модуля</param>
    /// <param name="logger">Логер</param>
    public Importer(
      IExportImportService exportImportService,
      IModuleManager moduleManager,
      IModuleMetadataLoader moduleMetadataLoader,
      ILogger logger)
    {
      Importer.kaWW9REMECDCltir10la();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 4;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
        num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.logger = logger;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 1 : 0;
            continue;
          case 3:
            this.moduleManager = moduleManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
            continue;
          case 4:
            this.exportImportService = exportImportService;
            num = 3;
            continue;
          default:
            this.moduleMetadataLoader = moduleMetadataLoader;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Основной этап импорта</summary>
    /// <param name="configImportSettings">Настройки импорта</param>
    /// <returns></returns>
    /// <exception cref="T:EleWise.ELMA.Deploy.Import.Modules.ModuleDeployException">В случае ошибки при импорте</exception>
    public async Task Import(
      IReadOnlyCollection<IConfigImportSettings> configImportSettings)
    {
      int num1 = 1;
      int num2;
      Importer importer1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
            continue;
          case 2:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult();
            num1 = 3;
            continue;
          case 3:
            goto label_37;
          case 4:
            try
            {
              int num3;
              if (num2 == 0)
                num3 = 23;
              else
                goto label_19;
label_4:
              Dictionary<string, ElmaStoreComponentManifest> oldStoreComponentsInfo;
              TaskAwaiter<bool> taskAwaiter;
              TaskAwaiter<bool> awaiter;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 8 : 17;
                    continue;
                  case 2:
                    Importer importer2 = importer1;
                    Dictionary<string, ElmaStoreComponentManifest> oldManifests = oldStoreComponentsInfo;
                    IReadOnlyCollection<IConfigImportSettings> source = configImportSettings;
                    // ISSUE: reference to a compiler-generated field
                    Func<IConfigImportSettings, ElmaStoreComponentManifest> func = Importer.\u003C\u003Ec.\u003C\u003E9__6_2;
                    Func<IConfigImportSettings, ElmaStoreComponentManifest> selector;
                    if (func == null)
                    {
                      // ISSUE: reference to a compiler-generated field
                      Importer.\u003C\u003Ec.\u003C\u003E9__6_2 = selector = (Func<IConfigImportSettings, ElmaStoreComponentManifest>) (s => s.Manifest);
                    }
                    else
                      goto label_42;
label_29:
                    IEnumerable<ElmaStoreComponentManifest> newManifests = source.Select<IConfigImportSettings, ElmaStoreComponentManifest>(selector);
                    importer2.ProcessBPMAppInfo((IReadOnlyDictionary<string, ElmaStoreComponentManifest>) oldManifests, newManifests);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 21 : 9;
                    continue;
label_42:
                    selector = func;
                    goto label_29;
                  case 3:
                    importer1.Info(string.Empty);
                    num3 = 7;
                    continue;
                  case 4:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Importer.\u003CImport\u003Ed__6>(ref awaiter, this);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 8 : 1;
                    continue;
                  case 5:
                  case 13:
                    goto label_40;
                  case 6:
                  case 24:
                    // ISSUE: reference to a compiler-generated method
                    oldStoreComponentsInfo = importer1.moduleManager.GetInstalledComponentManifests().ToDictionary<ElmaStoreComponentManifest, string, ElmaStoreComponentManifest>((Func<ElmaStoreComponentManifest, string>) (i => (string) Importer.\u003C\u003Ec.ls4CbT8wpljFn68Ojd7d((object) i)), (Func<ElmaStoreComponentManifest, ElmaStoreComponentManifest>) (i => i));
                    num3 = 3;
                    continue;
                  case 7:
                    awaiter = importer1.ImportConfiguration(configImportSettings).GetAwaiter();
                    num3 = 11;
                    continue;
                  case 8:
                    goto label_34;
                  case 9:
                    goto label_19;
                  case 10:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    importer1.Info((string) Importer.\u003CImport\u003Ed__6.JemUTn8w6N9RmDNxSo3y(Importer.\u003CImport\u003Ed__6.pAaYSf8wAfagKqSiXsPm(~-122002947 ^ 121661740)));
                    num3 = 2;
                    continue;
                  case 11:
                    if (awaiter.IsCompleted)
                    {
                      num3 = 18;
                      continue;
                    }
                    goto case 12;
                  case 12:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 0;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
                    continue;
                  case 14:
                    importer1.Info(string.Empty);
                    num3 = 10;
                    continue;
                  case 15:
                    goto label_18;
                  case 16:
                    goto label_12;
                  case 17:
                  case 18:
                    if (awaiter.GetResult())
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 14 : 8;
                      continue;
                    }
                    goto label_12;
                  case 19:
                    taskAwaiter = new TaskAwaiter<bool>();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 1 : 0;
                    continue;
                  case 20:
                    importer1.Info(string.Empty);
                    num3 = 13;
                    continue;
                  case 21:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    importer1.Info((string) Importer.\u003CImport\u003Ed__6.JemUTn8w6N9RmDNxSo3y(Importer.\u003CImport\u003Ed__6.pAaYSf8wAfagKqSiXsPm(277947046 - -1479185048 ^ 1757299376)));
                    num3 = 20;
                    continue;
                  case 22:
                  case 23:
                    awaiter = taskAwaiter;
                    num3 = 19;
                    continue;
                  default:
                    taskAwaiter = awaiter;
                    num3 = 4;
                    continue;
                }
              }
label_34:
              return;
label_12:
              // ISSUE: reference to a compiler-generated method
              throw Importer.\u003CImport\u003Ed__6.QjTspw8wHeS4fj0bfIpy();
label_18:
              // ISSUE: reference to a compiler-generated method
              importer1.Info((string) Importer.\u003CImport\u003Ed__6.JemUTn8w6N9RmDNxSo3y((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138327920)));
              num3 = 5;
              goto label_4;
label_19:
              // ISSUE: reference to a compiler-generated method
              if (Importer.\u003CImport\u003Ed__6.z8jsLt8w44BOHHZ6nDMR((object) configImportSettings) != 0)
              {
                num3 = 6;
                goto label_4;
              }
              else
                goto label_18;
            }
            catch (Exception ex)
            {
              int num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0)
                num4 = 1;
              while (true)
              {
                switch (num4)
                {
                  case 0:
                    goto label_30;
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num4 = 2;
                    continue;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_27;
                }
              }
label_30:
              return;
label_27:
              return;
            }
          case 5:
label_40:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 2;
            continue;
          default:
            importer1 = this;
            num1 = 4;
            continue;
        }
      }
label_37:;
    }

    /// <summary>Тестовый этап импорта</summary>
    /// <param name="testUid">Идентификатор сессии теста</param>
    /// <param name="configImportSettings">Настройки импорта</param>
    /// <param name="clearAfterTest"><c>true</c> если после тестирования необходимо очистить все связанные данные</param>
    /// <exception cref="T:EleWise.ELMA.Deploy.Import.Modules.ModuleDeployException">В случае ошибки при тесте импорта</exception>
    public async Task<IReadOnlyCollection<ModuleImportSettings>> TestImport(
      Guid testUid,
      IEnumerable<IConfigImportSettings> configImportSettings,
      bool clearAfterTest)
    {
      int num1 = 2;
      int num2;
      IReadOnlyCollection<ModuleImportSettings> list1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num1 = 3;
            continue;
          case 2:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 1 : 1;
            continue;
          case 3:
            try
            {
              TaskAwaiter<Guid> taskAwaiter1;
              TaskAwaiter<IEnumerable<TestImportMessages>> taskAwaiter2;
              TaskAwaiter taskAwaiter3;
              TaskAwaiter<IEnumerable<TestImportMessages>> awaiter1;
              TaskAwaiter<Guid> awaiter2;
              TaskAwaiter awaiter3;
              int num3;
              switch (num2)
              {
                case 0:
label_15:
                  awaiter2 = taskAwaiter1;
                  num3 = 30;
                  break;
                case 1:
label_39:
                  awaiter1 = taskAwaiter2;
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 2 : 2;
                  break;
                case 2:
label_19:
                  awaiter3 = taskAwaiter3;
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 28 : 28;
                  break;
                case 3:
label_28:
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 21 : 17;
                  break;
                default:
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 14 : 23;
                  break;
              }
              List<TestImportMessages> receivedMessages;
              while (true)
              {
                List<TestImportMessages> list2;
                int num4;
                switch (num3)
                {
                  case 1:
label_23:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    awaiter3 = Importer.\u003CTestImport\u003Ed__7.JEXwgn8wMNkJ0F9JZU74(Importer.\u003CTestImport\u003Ed__7.THxlVs8wyDP60pxqN8mW(1000));
                    num3 = 10;
                    continue;
                  case 2:
                    taskAwaiter2 = new TaskAwaiter<IEnumerable<TestImportMessages>>();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 7 : 0;
                    continue;
                  case 3:
                    taskAwaiter3 = awaiter3;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 31 : 37;
                    continue;
                  case 4:
                  case 27:
                    awaiter2.GetResult();
                    num3 = 17;
                    continue;
                  case 5:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = 34;
                    continue;
                  case 6:
                    taskAwaiter1 = awaiter2;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 13 : 15;
                    continue;
                  case 7:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = 9;
                    continue;
                  case 8:
                  case 22:
                    goto label_28;
                  case 9:
                    list2 = awaiter1.GetResult().ToList<TestImportMessages>();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
                    continue;
                  case 10:
                    if (awaiter3.IsCompleted)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 16 : 32;
                      continue;
                    }
                    goto case 26;
                  case 11:
                  case 16:
                    // ISSUE: reference to a compiler-generated method
                    awaiter1 = this.exportImportService.GetTestLog(testUid, Importer.\u003CTestImport\u003Ed__7.tA0cXT8wmr0Fhm5ytVD0((object) receivedMessages)).GetAwaiter();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 39 : 4;
                    continue;
                  case 12:
                    goto label_19;
                  case 13:
                    TestImportMessages testImportMessages = list2.LastOrDefault<TestImportMessages>();
                    if (testImportMessages == null)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 19 : 9;
                      continue;
                    }
                    num4 = testImportMessages.Type == TestImportMessagesType.Finish ? 1 : 0;
                    break;
                  case 14:
                    taskAwaiter2 = awaiter1;
                    num3 = 35;
                    continue;
                  case 15:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Guid>, Importer.\u003CTestImport\u003Ed__7>(ref awaiter2, this);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 29 : 22;
                    continue;
                  case 17:
                    receivedMessages = new List<TestImportMessages>();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 16 : 7;
                    continue;
                  case 18:
                    goto label_39;
                  case 19:
                    num4 = 0;
                    break;
                  case 20:
                    if (awaiter2.IsCompleted)
                    {
                      num3 = 27;
                      continue;
                    }
                    goto case 31;
                  case 21:
                    goto label_48;
                  case 23:
                    awaiter2 = this.exportImportService.TestModules(testUid, configImportSettings, storeSettings: !clearAfterTest).GetAwaiter();
                    num3 = 20;
                    continue;
                  case 24:
                    goto label_79;
                  case 25:
                    goto label_74;
                  case 26:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 2;
                    num3 = 3;
                    continue;
                  case 28:
                    taskAwaiter3 = new TaskAwaiter();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 2 : 5;
                    continue;
                  case 29:
                    goto label_70;
                  case 30:
                    taskAwaiter1 = new TaskAwaiter<Guid>();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 29 : 40;
                    continue;
                  case 31:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 0;
                    num3 = 6;
                    continue;
                  case 32:
                  case 34:
                    awaiter3.GetResult();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 11 : 11;
                    continue;
                  case 33:
                    goto label_15;
                  case 35:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<TestImportMessages>>, Importer.\u003CTestImport\u003Ed__7>(ref awaiter1, this);
                    num3 = 25;
                    continue;
                  case 36:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 1;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 8 : 14;
                    continue;
                  case 37:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Importer.\u003CTestImport\u003Ed__7>(ref awaiter3, this);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 24 : 1;
                    continue;
                  case 38:
                    this.ProcessTestLog((IEnumerable<TestImportMessages>) list2);
                    num3 = 13;
                    continue;
                  case 39:
                    if (!awaiter1.IsCompleted)
                    {
                      num3 = 36;
                      continue;
                    }
                    goto case 9;
                  case 40:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = 4;
                    continue;
                  default:
                    receivedMessages.AddRange((IEnumerable<TestImportMessages>) list2);
                    num3 = 38;
                    continue;
                }
                if (num4 != 0)
                  num3 = 8;
                else
                  goto label_23;
              }
label_79:
              return;
label_74:
              return;
label_70:
              return;
label_48:
              try
              {
                int num5;
                if (num2 != 3)
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
                else
                  goto label_61;
label_50:
                TaskAwaiter<IEnumerable<IImportSettings>> taskAwaiter4;
                TaskAwaiter<IEnumerable<IImportSettings>> awaiter4;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      taskAwaiter4 = awaiter4;
                      num5 = 4;
                      continue;
                    case 2:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num2 = -1;
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 3;
                      continue;
                    case 3:
                    case 5:
                      list1 = (IReadOnlyCollection<ModuleImportSettings>) awaiter4.GetResult().OfType<ModuleImportSettings>().ToList<ModuleImportSettings>();
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 7 : 2;
                      continue;
                    case 4:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<IImportSettings>>, Importer.\u003CTestImport\u003Ed__7>(ref awaiter4, this);
                      num5 = 10;
                      continue;
                    case 6:
                      goto label_61;
                    case 7:
                      goto label_2;
                    case 8:
                      goto label_55;
                    case 9:
                      if (awaiter4.IsCompleted)
                      {
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 4 : 5;
                        continue;
                      }
                      goto case 11;
                    case 10:
                      goto label_65;
                    case 11:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num2 = 3;
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 1 : 1;
                      continue;
                    case 12:
                      taskAwaiter4 = new TaskAwaiter<IEnumerable<IImportSettings>>();
                      num5 = 2;
                      continue;
                    default:
                      // ISSUE: reference to a compiler-generated method
                      if (receivedMessages.FirstOrDefault<TestImportMessages>((Func<TestImportMessages, bool>) (m => Importer.\u003C\u003Ec.oebHVu8wayKG6WVhV1N9((object) m) == TestImportMessagesType.Error)) == null)
                      {
                        awaiter4 = this.exportImportService.GetImportSettings(testUid).GetAwaiter();
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 9 : 8;
                        continue;
                      }
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 7 : 8;
                      continue;
                  }
                }
label_65:
                return;
label_55:
                // ISSUE: reference to a compiler-generated method
                throw Importer.\u003CTestImport\u003Ed__7.KkiGTD8wJPGc0O2Ho39Z();
label_61:
                awaiter4 = taskAwaiter4;
                num5 = 12;
                goto label_50;
              }
              finally
              {
                if (num2 < 0)
                {
                  int num6 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
                    num6 = 1;
                  while (true)
                  {
                    switch (num6)
                    {
                      case 1:
                        if (!clearAfterTest)
                        {
                          num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 3 : 3;
                          continue;
                        }
                        break;
                      case 2:
                      case 3:
                        goto label_75;
                    }
                    // ISSUE: reference to a compiler-generated method
                    Importer.\u003CTestImport\u003Ed__7.EjdIXb8w9OfFIfE8OFwg((object) this.exportImportService, testUid);
                    num6 = 2;
                  }
                }
label_75:;
              }
            }
            catch (Exception ex)
            {
              int num7 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
                num7 = 1;
              while (true)
              {
                switch (num7)
                {
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
                    continue;
                  case 2:
                    goto label_59;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 2;
                    continue;
                }
              }
label_59:
              return;
            }
          case 4:
            goto label_82;
          case 5:
label_2:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
            continue;
          default:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(list1);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 4 : 4;
            continue;
        }
      }
label_82:;
    }

    private async Task<bool> ImportConfiguration(
      IReadOnlyCollection<IConfigImportSettings> configImportSettings)
    {
      int num1 = 2;
      while (true)
      {
        int num2;
        bool result1;
        switch (num1)
        {
          case 1:
            num1 = 3;
            continue;
          case 2:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 1 : 1;
            continue;
          case 3:
            try
            {
              TaskAwaiter<Guid> taskAwaiter1;
              TaskAwaiter<IEnumerable<DeployLogMessage>> taskAwaiter2;
              TaskAwaiter taskAwaiter3;
              TaskAwaiter<Guid> awaiter1;
              TaskAwaiter awaiter2;
              TaskAwaiter<IEnumerable<DeployLogMessage>> awaiter3;
              int num3;
              switch (num2)
              {
                case 0:
label_6:
                  awaiter1 = taskAwaiter1;
                  num3 = 54;
                  break;
                case 1:
label_23:
                  awaiter3 = taskAwaiter2;
                  num3 = 47;
                  break;
                case 2:
label_45:
                  awaiter1 = taskAwaiter1;
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
                  break;
                case 3:
label_29:
                  awaiter2 = taskAwaiter3;
                  num3 = 19;
                  break;
                default:
                  num3 = 49;
                  break;
              }
              while (true)
              {
                Guid importUid;
                int messageCount;
                bool success;
                Guid guid;
                int num4;
                Guid result2;
                bool flag;
                List<DeployLogMessage> list;
                switch (num3)
                {
                  case 1:
                    taskAwaiter1 = awaiter1;
                    num4 = 21;
                    break;
                  case 2:
                    taskAwaiter3 = awaiter2;
                    num4 = 39;
                    break;
                  case 3:
                    result2 = awaiter1.GetResult();
                    num3 = 53;
                    continue;
                  case 4:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 2;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 1 : 0;
                    continue;
                  case 5:
                    // ISSUE: reference to a compiler-generated method
                    flag = Importer.\u003CImportConfiguration\u003Ed__8.RBqDWF8w5q50WKt3UjqE(guid, result2);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 18 : 7;
                    continue;
                  case 6:
                  case 37:
                    list = awaiter3.GetResult().ToList<DeployLogMessage>();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 26;
                    continue;
                  case 7:
                    if (flag)
                    {
                      num3 = 12;
                      continue;
                    }
                    goto case 32;
                  case 8:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<DeployLogMessage>>, Importer.\u003CImportConfiguration\u003Ed__8>(ref awaiter3, this);
                    num3 = 44;
                    continue;
                  case 9:
                    taskAwaiter2 = awaiter3;
                    num3 = 8;
                    continue;
                  case 10:
                    if (awaiter3.IsCompleted)
                    {
                      num3 = 6;
                      continue;
                    }
                    goto case 42;
                  case 11:
                    goto label_67;
                  case 12:
                    guid = importUid;
                    num3 = 48;
                    continue;
                  case 13:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    awaiter2 = Importer.\u003CImportConfiguration\u003Ed__8.UU1MkT8wYjanTIpypab4(Importer.\u003CImportConfiguration\u003Ed__8.MU0p138wjRipHhtVtsVM(1000));
                    num3 = 51;
                    continue;
                  case 14:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 3;
                    num3 = 2;
                    continue;
                  case 15:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 0;
                    num3 = 16;
                    continue;
                  case 16:
                    taskAwaiter1 = awaiter1;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 46 : 46;
                    continue;
                  case 17:
                    success = true;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 36 : 1;
                    continue;
                  case 18:
                    guid = new Guid();
                    num3 = 32;
                    continue;
                  case 19:
                    taskAwaiter3 = new TaskAwaiter();
                    num3 = 34;
                    continue;
                  case 20:
                    goto label_71;
                  case 21:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Guid>, Importer.\u003CImportConfiguration\u003Ed__8>(ref awaiter1, this);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 11 : 9;
                    continue;
                  case 22:
                    result1 = success;
                    num4 = 20;
                    break;
                  case 23:
                    goto label_23;
                  case 24:
                    // ISSUE: reference to a compiler-generated method
                    flag = Importer.\u003CImportConfiguration\u003Ed__8.vw9Lcc8wgFkyKtV1gBT7((object) list) == 0;
                    num3 = 7;
                    continue;
                  case 25:
                    awaiter2.GetResult();
                    num4 = 52;
                    break;
                  case 26:
                    success = success && this.ProcessImportLog((IEnumerable<DeployLogMessage>) list);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 29 : 21;
                    continue;
                  case 27:
                    goto label_6;
                  case 28:
                    goto label_63;
                  case 29:
                    messageCount += list.Count;
                    num3 = 24;
                    continue;
                  case 30:
                    goto label_41;
                  case 31:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = 3;
                    continue;
                  case 32:
                    if (!flag)
                    {
                      num3 = 13;
                      continue;
                    }
                    goto case 22;
                  case 33:
                    messageCount = 0;
                    num3 = 17;
                    continue;
                  case 34:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 8 : 25;
                    continue;
                  case 35:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num4 = 37;
                    break;
                  case 36:
                  case 52:
                    awaiter3 = this.exportImportService.GetImportLog(importUid, messageCount).GetAwaiter();
                    num3 = 10;
                    continue;
                  case 38:
                    if (!awaiter1.IsCompleted)
                    {
                      num3 = 4;
                      continue;
                    }
                    goto case 40;
                  case 39:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Importer.\u003CImportConfiguration\u003Ed__8>(ref awaiter2, this);
                    num3 = 30;
                    continue;
                  case 40:
                    result2 = awaiter1.GetResult();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 3 : 5;
                    continue;
                  case 41:
                    goto label_29;
                  case 42:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 1;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 9 : 4;
                    continue;
                  case 43:
                    goto label_45;
                  case 44:
                    goto label_32;
                  case 45:
                    if (!awaiter1.IsCompleted)
                    {
                      num3 = 15;
                      continue;
                    }
                    goto case 3;
                  case 46:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Guid>, Importer.\u003CImportConfiguration\u003Ed__8>(ref awaiter1, this);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 28 : 15;
                    continue;
                  case 47:
                    taskAwaiter2 = new TaskAwaiter<IEnumerable<DeployLogMessage>>();
                    num3 = 35;
                    continue;
                  case 48:
                    awaiter1 = this.exportImportService.GetCurrentImportId().GetAwaiter();
                    num3 = 38;
                    continue;
                  case 49:
                    awaiter1 = this.exportImportService.ContinuedImport((IEnumerable<IConfigImportSettings>) configImportSettings).GetAwaiter();
                    num3 = 45;
                    continue;
                  case 50:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 40 : 11;
                    continue;
                  case 51:
                    if (!awaiter2.IsCompleted)
                    {
                      num3 = 14;
                      continue;
                    }
                    goto case 25;
                  case 53:
                    importUid = result2;
                    num3 = 33;
                    continue;
                  case 54:
                    taskAwaiter1 = new TaskAwaiter<Guid>();
                    num3 = 31;
                    continue;
                  default:
                    taskAwaiter1 = new TaskAwaiter<Guid>();
                    num4 = 50;
                    break;
                }
                num3 = num4;
              }
label_67:
              return;
label_63:
              return;
label_41:
              return;
label_32:
              return;
            }
            catch (Exception ex)
            {
              int num5 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0)
                num5 = 0;
              while (true)
              {
                switch (num5)
                {
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num5 = 2;
                    continue;
                  case 2:
                    goto label_25;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 1 : 0;
                    continue;
                }
              }
label_25:
              return;
            }
          case 4:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result1);
            num1 = 5;
            continue;
          case 5:
            goto label_70;
        }
label_71:
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        (^this).\u003C\u003E1__state = -2;
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 4 : 3;
      }
label_70:;
    }

    private void ProcessBPMAppInfo(
      IReadOnlyDictionary<string, ElmaStoreComponentManifest> oldManifests,
      IEnumerable<ElmaStoreComponentManifest> newManifests)
    {
      foreach (ElmaStoreComponentManifest newManifest in newManifests)
      {
        if (oldManifests.ContainsKey(newManifest.Id))
        {
          ElmaStoreComponentManifest oldManifest = oldManifests[newManifest.Id];
          if (!(newManifest.SemanticVersion > oldManifest.SemanticVersion))
            this.moduleManager.SaveStoreComponentInfo((IStoreComponentInfo) new ManifestStoreComponentInfo((ElmaStoreComponentManifest) null, oldManifest, (ElmaStoreComponentFile) null, (ElmaStoreComponentFile) null), StoreComponentStatus.Active);
        }
      }
    }

    private bool ProcessImportLog(IEnumerable<DeployLogMessage> messages)
    {
      bool flag = true;
      foreach (DeployLogMessage message in messages)
      {
        switch (message.MessageType)
        {
          case DeployLogMessageType.Warn:
            this.Warn(message.MessageText);
            continue;
          case DeployLogMessageType.Error:
            this.Error(message.MessageText);
            flag = false;
            continue;
          case DeployLogMessageType.SystemImportStatus:
            if (message.ImportStatus == BPMAppItemImportStatus.Error)
            {
              this.Error(message.MessageText);
              flag = false;
              continue;
            }
            break;
        }
        this.Trace(message.MessageText);
      }
      return flag;
    }

    private void ProcessTestLog(IEnumerable<TestImportMessages> messages)
    {
      foreach (TestImportMessages message in messages)
      {
        switch (message.Type)
        {
          case TestImportMessagesType.Warning:
            this.Warn(message.Text);
            continue;
          case TestImportMessagesType.Error:
            this.Error(message.Text);
            continue;
          default:
            this.Info(message.Text);
            continue;
        }
      }
    }

    private void Error(string message)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_4;
          case 1:
            ILogger logger = this.logger;
            string str = message;
            string format = str == null ? string.Empty : str;
            object[] objArray = Array.Empty<object>();
            logger.Log(EleWise.ELMA.Logging.LogLevel.Error, (Exception) null, format, objArray);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_4:
      return;
label_2:;
    }

    private void Info(string message)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_4;
          case 1:
            ILogger logger = this.logger;
            string str = message;
            string format = str == null ? string.Empty : str;
            object[] objArray = Array.Empty<object>();
            logger.Log(EleWise.ELMA.Logging.LogLevel.Information, (Exception) null, format, objArray);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_4:
      return;
label_2:;
    }

    private void Trace(string message)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_4;
          case 1:
            ILogger logger = this.logger;
            string str = message;
            string format = str == null ? string.Empty : str;
            object[] objArray = Array.Empty<object>();
            logger.Log(EleWise.ELMA.Logging.LogLevel.Trace, (Exception) null, format, objArray);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_4:
      return;
label_2:;
    }

    private void Warn(string message)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.logger.Log(EleWise.ELMA.Logging.LogLevel.Warning, (Exception) null, message ?? string.Empty);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    internal static void kaWW9REMECDCltir10la() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool aQR5AwEMh0bghiwXCZtq() => Importer.YGlYoUEMb4hVsGbpar1s == null;

    internal static Importer iVNIf9EMGs1AYBiMJD7P() => Importer.YGlYoUEMb4hVsGbpar1s;
  }
}
