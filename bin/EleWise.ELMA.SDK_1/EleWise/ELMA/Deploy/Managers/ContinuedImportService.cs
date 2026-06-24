// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Managers.ContinuedImportService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.BPMApps;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Import.Modules;
using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.Files;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Deploy.Managers
{
  /// <summary>Сервис непрерывного импорта</summary>
  /// <remarks>Обеспечивает функционал непрерывного одноинстансного импорта</remarks>
  [Service]
  internal sealed class ContinuedImportService : IContinuedImportService
  {
    private readonly ConcurrentDictionary<Guid, int> logMessages;
    private readonly IExportImportService exportImportService;
    private readonly IModuleFileDeployServiceExtended moduleFileDeployService;
    /// <summary>Сервис получения настроек импорта из файла импорта</summary>
    private readonly IConfigurationUnpackService configurationUnpackService;
    private static ContinuedImportService Qmkmn9EDzNsjaNQxr3MB;

    /// <summary>Ctor</summary>
    /// <param name="exportImportService">Сервис экспорта/импорта</param>
    /// <param name="moduleFileDeployService">Сервис развертывания модуля</param>
    /// <param name="configurationUnpackService">Сервис получения настроек импорта из файла импорта</param>
    public ContinuedImportService(
      IExportImportService exportImportService,
      IModuleFileDeployServiceExtended moduleFileDeployService,
      IConfigurationUnpackService configurationUnpackService)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.logMessages = new ConcurrentDictionary<Guid, int>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.exportImportService = exportImportService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 1 : 2;
            continue;
          case 2:
            this.moduleFileDeployService = moduleFileDeployService;
            num = 3;
            continue;
          case 3:
            this.configurationUnpackService = configurationUnpackService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
            continue;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_7:;
    }

    /// <inheritdoc />
    public Task<Guid> Import(IEnumerable<Guid> testUids, CancellationToken cancellationToken)
    {
      cancellationToken.ThrowIfCancellationRequested();
      return this.exportImportService.ContinuedImport(testUids);
    }

    /// <inheritdoc />
    public Task<IEnumerable<Guid>> Test(BinaryFile configFile, CancellationToken cancellationToken) => this.Test(configFile, (string) null, cancellationToken);

    /// <inheritdoc />
    public async Task<IEnumerable<Guid>> Test(
      BinaryFile configFile,
      string activationKey,
      CancellationToken cancellationToken)
    {
      int num1 = 4;
      int num2;
      IEnumerable<Guid> result1;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_79;
          case 1:
            try
            {
              int num3;
              if (num2 != 0)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 22 : 9;
              else
                goto label_6;
label_4:
              List<Guid> testUids;
              List<Guid> guidList;
              TaskAwaiter<IEnumerable<Guid>> taskAwaiter1;
              IEnumerator<IConfigImportSettings> enumerator;
              TaskAwaiter<IEnumerable<Guid>> awaiter1;
              IEnumerable<IConfigImportSettings> importSettings;
              List<Guid>.Enumerator enumerator1;
              List<IConfigImportSettings> list;
              IEnumerable<Guid> result2;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    if (!this.moduleFileDeployService.HasModules((IReadOnlyCollection<IConfigImportSettings>) list))
                    {
                      num3 = 14;
                      continue;
                    }
                    goto case 15;
                  case 2:
                  case 26:
                    enumerator1 = testUids.GetEnumerator();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
                    continue;
                  case 3:
                    enumerator = importSettings.GetEnumerator();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 4 : 4;
                    continue;
                  case 4:
                    num3 = 19;
                    continue;
                  case 5:
                    goto label_6;
                  case 6:
                    cancellationToken.ThrowIfCancellationRequested();
                    num3 = 25;
                    continue;
                  case 7:
                    list = this.configurationUnpackService.Unpack(configFile, checkManifests: false, tagFilter: false).ToList<IConfigImportSettings>();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 1;
                    continue;
                  case 8:
                    goto label_80;
                  case 9:
                    if (!awaiter1.IsCompleted)
                    {
                      num3 = 10;
                      continue;
                    }
                    goto case 12;
                  case 10:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 0;
                    num3 = 21;
                    continue;
                  case 11:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = 12;
                    continue;
                  case 12:
                    result2 = awaiter1.GetResult();
                    num3 = 23;
                    continue;
                  case 13:
                    taskAwaiter1 = new TaskAwaiter<IEnumerable<Guid>>();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 1 : 11;
                    continue;
                  case 14:
                  case 28:
                    importSettings = this.configurationUnpackService.FilterByTags((IEnumerable<IConfigImportSettings>) list);
                    num3 = 16;
                    continue;
                  case 15:
                    guidList = testUids;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 20 : 8;
                    continue;
                  case 16:
                    this.configurationUnpackService.ValidateComponents(importSettings);
                    num3 = 3;
                    continue;
                  case 17:
label_72:
                    enumerator = (IEnumerator<IConfigImportSettings>) null;
                    num3 = 26;
                    continue;
                  case 18:
label_36:
                    result1 = (IEnumerable<Guid>) testUids;
                    num3 = 8;
                    continue;
                  case 19:
                    try
                    {
                      int num4;
                      if (num2 != 1)
                        num4 = 5;
                      else
                        goto label_49;
label_41:
                      TaskAwaiter<Guid> taskAwaiter2;
                      TaskAwaiter<Guid> awaiter2;
                      Guid result3;
                      IConfigImportSettings current;
                      while (true)
                      {
                        switch (num4)
                        {
                          case 1:
                            // ISSUE: explicit reference operation
                            // ISSUE: reference to a compiler-generated field
                            (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Guid>, ContinuedImportService.\u003CTest\u003Ed__7>(ref awaiter2, this);
                            num4 = 2;
                            continue;
                          case 2:
                            goto label_64;
                          case 3:
                            current = enumerator.Current;
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 2 : 4;
                            continue;
                          case 4:
                            guidList = testUids;
                            num4 = 9;
                            continue;
                          case 5:
                          case 8:
                            // ISSUE: reference to a compiler-generated method
                            if (!ContinuedImportService.\u003CTest\u003Ed__7.TG55O682U7xuMPtv3YB4((object) enumerator))
                            {
                              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 1 : 7;
                              continue;
                            }
                            goto case 3;
                          case 6:
                            result3 = awaiter2.GetResult();
                            num4 = 10;
                            continue;
                          case 7:
                            goto label_72;
                          case 9:
                            awaiter2 = this.exportImportService.Test(current, activationKey, true).GetAwaiter();
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 11 : 10;
                            continue;
                          case 10:
                            guidList.Add(result3);
                            num4 = 15;
                            continue;
                          case 11:
                            if (!awaiter2.IsCompleted)
                            {
                              num4 = 12;
                              continue;
                            }
                            goto case 6;
                          case 12:
                            // ISSUE: explicit reference operation
                            // ISSUE: reference to a compiler-generated field
                            (^this).\u003C\u003E1__state = num2 = 1;
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
                            continue;
                          case 13:
                            // ISSUE: explicit reference operation
                            // ISSUE: reference to a compiler-generated field
                            (^this).\u003C\u003E1__state = num2 = -1;
                            num4 = 6;
                            continue;
                          case 14:
                            taskAwaiter2 = new TaskAwaiter<Guid>();
                            num4 = 13;
                            continue;
                          case 15:
                            guidList = (List<Guid>) null;
                            num4 = 8;
                            continue;
                          case 16:
                            goto label_49;
                          default:
                            taskAwaiter2 = awaiter2;
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 1;
                            continue;
                        }
                      }
label_64:
                      return;
label_49:
                      awaiter2 = taskAwaiter2;
                      num4 = 14;
                      goto label_41;
                    }
                    finally
                    {
                      if (num2 < 0)
                      {
                        int num5 = 3;
                        while (true)
                        {
                          switch (num5)
                          {
                            case 2:
                              // ISSUE: reference to a compiler-generated method
                              ContinuedImportService.\u003CTest\u003Ed__7.nxURhh82sMlxGPs50Qlj((object) enumerator);
                              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
                              continue;
                            case 3:
                              if (enumerator == null)
                              {
                                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 1 : 1;
                                continue;
                              }
                              goto case 2;
                            default:
                              goto label_66;
                          }
                        }
                      }
label_66:;
                    }
                  case 20:
                    awaiter1 = this.moduleFileDeployService.Test((IReadOnlyCollection<IConfigImportSettings>) list).GetAwaiter();
                    num3 = 9;
                    continue;
                  case 21:
                    taskAwaiter1 = awaiter1;
                    num3 = 29;
                    continue;
                  case 22:
                    if (num2 != 1)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 2 : 6;
                      continue;
                    }
                    goto case 4;
                  case 23:
                    guidList.AddRange(result2);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 24 : 17;
                    continue;
                  case 24:
                    guidList = (List<Guid>) null;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 2;
                    continue;
                  case 25:
                    testUids = new List<Guid>();
                    num3 = 7;
                    continue;
                  case 27:
                    goto label_73;
                  case 29:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<Guid>>, ContinuedImportService.\u003CTest\u003Ed__7>(ref awaiter1, this);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 27 : 17;
                    continue;
                  default:
                    try
                    {
label_12:
                      if (enumerator1.MoveNext())
                        goto label_14;
                      else
                        goto label_13;
label_10:
                      Guid current;
                      int num6;
                      while (true)
                      {
                        switch (num6)
                        {
                          case 1:
                            goto label_12;
                          case 2:
                            this.logMessages[current] = 0;
                            num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 1 : 0;
                            continue;
                          case 3:
                            goto label_14;
                          default:
                            goto label_36;
                        }
                      }
label_13:
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
                      goto label_10;
label_14:
                      current = enumerator1.Current;
                      num6 = 2;
                      goto label_10;
                    }
                    finally
                    {
                      if (num2 < 0)
                      {
                        int num7 = 1;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0)
                          num7 = 1;
                        while (true)
                        {
                          switch (num7)
                          {
                            case 1:
                              enumerator1.Dispose();
                              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 0 : 0;
                              continue;
                            default:
                              goto label_20;
                          }
                        }
                      }
label_20:;
                    }
                }
              }
label_73:
              return;
label_6:
              awaiter1 = taskAwaiter1;
              num3 = 13;
              goto label_4;
            }
            catch (Exception ex)
            {
              int num8 = 2;
              while (true)
              {
                switch (num8)
                {
                  case 1:
                    goto label_61;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
                    continue;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 1 : 1;
                    continue;
                }
              }
label_61:
              return;
            }
          case 2:
label_80:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = 5;
            continue;
          case 3:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 1 : 0;
            continue;
          case 4:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 3 : 1;
            continue;
          case 5:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result1);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
            continue;
          default:
            goto label_76;
        }
      }
label_79:
      return;
label_76:;
    }

    /// <inheritdoc />
    public Task<IEnumerable<BPMAppFakeManifest>> GetImportManifests(
      Guid uid,
      CancellationToken cancellationToken)
    {
      cancellationToken.ThrowIfCancellationRequested();
      return this.exportImportService.GetImportManifests(uid);
    }

    /// <inheritdoc />
    public Task<List<TestImportMessages>> GetTestLog(
      Guid testUid,
      CancellationToken cancellationToken)
    {
      return this.GetLog<TestImportMessages>(testUid, this.logMessages, new Func<Guid, int, int, Task<IEnumerable<TestImportMessages>>>(this.exportImportService.GetTestLog));
    }

    /// <inheritdoc />
    public Task<IEnumerable<IImportSettings>> GetImportSettings(Guid testUid) => this.exportImportService.GetImportSettings(testUid);

    /// <summary>Получить сообщения лога</summary>
    /// <typeparam name="T">Тип сообщений</typeparam>
    /// <param name="sessionId">Идентификатор сессии</param>
    /// <param name="messageCountDictionary">Словарь с данными о количестве сообщений на клиенте</param>
    /// <param name="getLogsFunc">Метод получения логов</param>
    /// <returns>Список сообщений лога</returns>
    private async Task<List<T>> GetLog<T>(
      Guid sessionId,
      ConcurrentDictionary<Guid, int> messageCountDictionary,
      Func<Guid, int, int, Task<IEnumerable<T>>> getLogsFunc)
    {
      int num1 = 3;
      while (true)
      {
        int num2;
        List<T> result;
        switch (num1)
        {
          case 1:
            goto label_32;
          case 2:
            try
            {
              int num3;
              if (num2 != 0)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 9 : 0;
              else
                goto label_24;
label_7:
              TaskAwaiter<IEnumerable<T>> taskAwaiter;
              int num4;
              TaskAwaiter<IEnumerable<T>> awaiter;
              Guid key;
              List<T> list;
              ConcurrentDictionary<Guid, int> concurrentDictionary;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                  case 6:
                    goto label_4;
                  case 2:
                    concurrentDictionary[key] += list.Count;
                    num3 = 5;
                    continue;
                  case 3:
                    concurrentDictionary = messageCountDictionary;
                    num3 = 17;
                    continue;
                  case 4:
                    goto label_24;
                  case 5:
                    result = list;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 1;
                    continue;
                  case 7:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = 16;
                    continue;
                  case 8:
                    goto label_29;
                  case 9:
                    if (!messageCountDictionary.TryGetValue(sessionId, out num4))
                    {
                      num3 = 10;
                      continue;
                    }
                    goto case 15;
                  case 10:
                    result = (List<T>) null;
                    num3 = 6;
                    continue;
                  case 11:
                    taskAwaiter = awaiter;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 14 : 1;
                    continue;
                  case 12:
                    taskAwaiter = new TaskAwaiter<IEnumerable<T>>();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 7 : 0;
                    continue;
                  case 13:
                    if (!awaiter.IsCompleted)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
                      continue;
                    }
                    goto case 16;
                  case 14:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<T>>, ContinuedImportService.\u003CGetLog\u003Ed__11<T>>(ref awaiter, this);
                    num3 = 8;
                    continue;
                  case 15:
                    awaiter = getLogsFunc(sessionId, num4, 0).GetAwaiter();
                    num3 = 13;
                    continue;
                  case 16:
                    list = awaiter.GetResult().ToList<T>();
                    num3 = 3;
                    continue;
                  case 17:
                    key = sessionId;
                    num3 = 2;
                    continue;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 0;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 5 : 11;
                    continue;
                }
              }
label_29:
              return;
label_24:
              awaiter = taskAwaiter;
              num3 = 12;
              goto label_7;
            }
            catch (Exception ex)
            {
              int num5 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
                num5 = 0;
              while (true)
              {
                switch (num5)
                {
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 2 : 2;
                    continue;
                  case 2:
                    goto label_25;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 1 : 0;
                    continue;
                }
              }
label_25:
              return;
            }
          case 3:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 2;
            continue;
          case 4:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 1 : 1;
            continue;
        }
label_4:
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        (^this).\u003C\u003E1__state = -2;
        num1 = 4;
      }
label_32:;
    }

    internal static bool jVpD7LEtFdcJTVoB02Rt() => ContinuedImportService.Qmkmn9EDzNsjaNQxr3MB == null;

    internal static ContinuedImportService Q7FLehEtBeaa7X2ma9ML() => ContinuedImportService.Qmkmn9EDzNsjaNQxr3MB;
  }
}
