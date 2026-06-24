// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Actors.ImportExecutorActor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Managers;
using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.Deploy.Utils;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Deploy.Actors
{
  /// <summary>Актор выполнения импорта</summary>
  internal sealed class ImportExecutorActor : Actor, IImportExecutorActor, IActorWithGuidKey, IActor
  {
    /// <summary>
    /// Ключ состояния продолжаемого импорта в <see cref="T:EleWise.ELMA.Runtime.Managers.IBLOBStore" />
    /// </summary>
    internal static readonly string StateKey;
    /// <summary>
    /// Ключ таймстампа последнего импорта в <see cref="T:EleWise.ELMA.Runtime.Managers.IBLOBStore" />
    /// </summary>
    internal static readonly string TimestampKey;
    private readonly IAuthenticationService authenticationService;
    private readonly IBLOBStore blobStore;
    private readonly IExportImportFileService fileService;
    private readonly IDeployManager deployManager;
    private readonly ITimestampService timestampService;
    private readonly IConfigurationImportInternalFactory configurationImportInternalFactory;
    private List<DeployLogMessage> log;
    private List<DeploySystemMessage> systemMessages;
    private bool isStarted;
    private CancellationTokenSource cts;
    private Task externalTask;
    private ContinuedImportState continuedImportState;
    private static ImportExecutorActor LocliPEzzG8o2rWpsNP5;

    /// <summary>Ctor</summary>
    /// <param name="authenticationService">Сервис аутентификации</param>
    /// <param name="blobStore">Хранилище блобов</param>
    /// <param name="fileService">Сервис управления файлами импорта</param>
    /// <param name="deployManager">Менеджер экспорта-импорта конфигурации</param>
    /// <param name="timestampService">Сервис временных штампов</param>
    /// <param name="configurationImportInternalFactory">Сервис-фабрика объектов для импорта конфигураций</param>
    public ImportExecutorActor(
      IAuthenticationService authenticationService,
      IBLOBStore blobStore,
      IExportImportFileService fileService,
      IDeployManager deployManager,
      ITimestampService timestampService,
      IConfigurationImportInternalFactory configurationImportInternalFactory)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 3;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
        num = 4;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.fileService = fileService;
            num = 5;
            continue;
          case 2:
            this.blobStore = blobStore;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 1;
            continue;
          case 3:
            this.timestampService = timestampService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 4 : 6;
            continue;
          case 4:
            this.authenticationService = authenticationService;
            num = 2;
            continue;
          case 5:
            this.deployManager = deployManager;
            num = 3;
            continue;
          case 6:
            this.configurationImportInternalFactory = configurationImportInternalFactory;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
            continue;
          default:
            goto label_10;
        }
      }
label_3:
      return;
label_10:;
    }

    /// <inheritdoc />
    public override Task OnDeactivateAsync()
    {
      int num1 = 2;
      // ISSUE: variable of a compiler-generated type
      ImportExecutorActor.\u003COnDeactivateAsync\u003Ed__15 stateMachine;
      while (true)
      {
        int num2 = num1;
        AsyncTaskMethodBuilder tBuilder;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003Et__builder = AsyncTaskMethodBuilder.Create();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 0;
              continue;
            case 2:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E4__this = this;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_6;
            case 4:
              goto label_8;
            case 5:
              tBuilder.Start<ImportExecutorActor.\u003COnDeactivateAsync\u003Ed__15>(ref stateMachine);
              num2 = 3;
              continue;
            default:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E1__state = -1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 4 : 4;
              continue;
          }
        }
label_8:
        // ISSUE: reference to a compiler-generated field
        tBuilder = stateMachine.\u003C\u003Et__builder;
        num1 = 5;
      }
label_6:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <inheritdoc />
    public Task<IEnumerable<DeployLogMessage>> GetLog(int offset, int count) => this.log == null ? Task.FromResult<IEnumerable<DeployLogMessage>>(Enumerable.Empty<DeployLogMessage>()) : Task.FromResult<IEnumerable<DeployLogMessage>>(DeployUtils.SafeSkip<DeployLogMessage>(this.log, offset, count));

    /// <inheritdoc />
    public Task<IEnumerable<DeployLogMessage>> GetLastLog(int count)
    {
      if (this.log == null || count <= 0)
        return Task.FromResult<IEnumerable<DeployLogMessage>>(Enumerable.Empty<DeployLogMessage>());
      count = Math.Min(count, this.log.Count);
      return Task.FromResult<IEnumerable<DeployLogMessage>>(DeployUtils.SafeSkip<DeployLogMessage>(this.log, this.log.Count - count, count));
    }

    /// <inheritdoc />
    public Task<IEnumerable<DeploySystemMessage>> GetSystemMessages(int offset, int count) => this.systemMessages == null ? Task.FromResult<IEnumerable<DeploySystemMessage>>(Enumerable.Empty<DeploySystemMessage>()) : Task.FromResult<IEnumerable<DeploySystemMessage>>(DeployUtils.SafeSkip<DeploySystemMessage>(this.systemMessages, offset, count));

    /// <inheritdoc />
    public Task Import(IImportSettings settings)
    {
      int num1 = 5;
      ImportExecutorActor importExecutorActor;
      IImportSettings settings1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            this.externalTask = this.RunExternalTask((Func<Task>) (() =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    object obj = ImportExecutorActor.\u003C\u003Ec__DisplayClass19_0.p2iPZ68MYaw9GQE5apHH((object) importExecutorActor.configurationImportInternalFactory, (object) settings1);
                    ((IConfigurationImporterInternal) obj).OnImportFinished += new EventHandler<EventArgs>(FinishImportHandler);
                    ImportExecutorActor importExecutorActor1 = importExecutorActor;
                    IUser currentUser = importExecutorActor.authenticationService.GetCurrentUser();
                    // ISSUE: reference to a compiler-generated method
                    long? userId = (currentUser == null ? (object) null : ImportExecutorActor.\u003C\u003Ec__DisplayClass19_0.h0OgQ88MLRQATGOCLQ3S((object) currentUser)) as long?;
                    ((IConfigurationImporter) obj).RunImport(importExecutorActor1.CreateRunImportParameters(userId));
                    ((IConfigurationImporterInternal) obj).OnImportFinished -= new EventHandler<EventArgs>(FinishImportHandler);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_2;
                }
              }
label_2:
              // ISSUE: reference to a compiler-generated method
              return (Task) ImportExecutorActor.\u003C\u003Ec__DisplayClass19_0.vGZoPY8MUSTjqCpRLtAq();
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_7;
          case 3:
            settings1 = settings;
            num1 = 6;
            continue;
          case 4:
            importExecutorActor = this;
            num1 = 3;
            continue;
          case 5:
            num1 = 4;
            continue;
          case 6:
            if (this.isStarted)
            {
              num1 = 2;
              continue;
            }
            this.PrepareToStart();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 1 : 1;
            continue;
          default:
            goto label_10;
        }
      }
label_7:
      return (Task) ImportExecutorActor.meI7oAfFWdAvtbUBB2Qi();
label_10:
      return (Task) ImportExecutorActor.meI7oAfFWdAvtbUBB2Qi();

      void FinishImportHandler(object sender, EventArgs args)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              importExecutorActor.FinishImport();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
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
    public Task<bool> IsActive() => Task.FromResult<bool>(this.isStarted || this.HasContinuedImport());

    /// <inheritdoc />
    public Task ContinuedImport(IEnumerable<IConfigImportSettings> settings)
    {
      if (this.isStarted)
        return Task.CompletedTask;
      this.PrepareToStart();
      this.externalTask = this.RunExternalTask((Func<Task>) (() =>
      {
        int num1 = 4;
        while (true)
        {
          int num2 = num1;
          BPMAppFakeManifest[] array;
          while (true)
          {
            switch (num2)
            {
              case 1:
                this.isStarted = false;
                num2 = 2;
                continue;
              case 2:
                goto label_7;
              case 3:
                IUser currentUser = this.authenticationService.GetCurrentUser();
                // ISSUE: reference to a compiler-generated method
                this.continuedImportState = new ContinuedImportState((currentUser == null ? (object) null : ImportExecutorActor.\u003C\u003Ec__DisplayClass21_0.V6O2b08JBDCxGFYmerk1((object) currentUser)) as long?, settings, array);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 0 : 0;
                continue;
              case 4:
                goto label_8;
              case 5:
                this.FinishImport();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 1 : 1;
                continue;
              default:
                // ISSUE: reference to a compiler-generated method
                if (new ContinuedImporter(this.continuedImportState, this.CreateRunImportParameters(new long?(ImportExecutorActor.\u003C\u003Ec__DisplayClass21_0.vAQI488JWepso9qbwVwV((object) this.continuedImportState))), this.blobStore, this.fileService, this.deployManager, this.configurationImportInternalFactory).ExecuteImport())
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 3 : 5;
                  continue;
                }
                goto case 1;
            }
          }
label_8:
          array = settings.Select<IConfigImportSettings, BPMAppFakeManifest>((Func<IConfigImportSettings, BPMAppFakeManifest>) (s => s.FakeManifest)).Where<BPMAppFakeManifest>((Func<BPMAppFakeManifest, bool>) (m => m != null)).ToArray<BPMAppFakeManifest>();
          num1 = 3;
        }
label_7:
        return Task.CompletedTask;
      }));
      return Task.CompletedTask;
    }

    /// <inheritdoc />
    public Task ContinueImport()
    {
      int num1 = 3;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_5;
          case 2:
            goto label_6;
          case 3:
            if (this.isStarted)
            {
              num1 = 2;
              continue;
            }
            this.PrepareToStart();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
            continue;
          default:
            this.externalTask = this.RunExternalTask((Func<Task>) (() =>
            {
              switch (1)
              {
                case 1:
                  Task task;
                  try
                  {
                    byte[] numArray = (byte[]) ImportExecutorActor.lbuRVwfFEWxVxvhb9ImP((object) this.blobStore, (object) ImportExecutorActor.StateKey);
                    int num2 = 8;
                    while (true)
                    {
                      switch (num2)
                      {
                        case 1:
                          this.FinishImport();
                          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 3 : 3;
                          continue;
                        case 2:
                          this.FinishImport();
                          num2 = 7;
                          continue;
                        case 3:
                          task = (Task) ImportExecutorActor.meI7oAfFWdAvtbUBB2Qi();
                          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
                          continue;
                        case 4:
                          this.log.AddRange((IEnumerable<DeployLogMessage>) this.continuedImportState.LogMessages);
                          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 4 : 6;
                          continue;
                        case 5:
                          this.continuedImportState = (ContinuedImportState) ImportExecutorActor.PULCApfFfLaTDBKCEZ2n((object) numArray);
                          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 4 : 0;
                          continue;
                        case 6:
                          if (new ContinuedImporter(this.continuedImportState, this.CreateRunImportParameters(new long?(this.continuedImportState.UserId)), this.blobStore, this.fileService, this.deployManager, this.configurationImportInternalFactory).ExecuteImport())
                          {
                            num2 = 2;
                            continue;
                          }
                          goto label_16;
                        case 7:
                          goto label_16;
                        case 8:
                          if (numArray == null)
                          {
                            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 1 : 1;
                            continue;
                          }
                          goto case 5;
                        default:
                          goto label_17;
                      }
                    }
                  }
                  catch (Exception ex)
                  {
                    int num3 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
                      num3 = 0;
                    while (true)
                    {
                      switch (num3)
                      {
                        case 1:
                          goto label_16;
                        default:
                          ImportExecutorActor.HuF9iZfFvtVtimUobrt0(ImportExecutorActor.qHjdhZfFQHOZ3kNeteuB(), ImportExecutorActor.PmsumkfFCC7WSvYYja57(ImportExecutorActor.XVuoNgfFGwByBUS7qSUC(~210725948 ^ -210395947)), (object) ex);
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 1 : 1;
                          continue;
                      }
                    }
                  }
label_17:
                  return task;
              }
label_16:
              return (Task) ImportExecutorActor.meI7oAfFWdAvtbUBB2Qi();
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 1;
            continue;
        }
      }
label_5:
      return Task.CompletedTask;
label_6:
      return (Task) ImportExecutorActor.meI7oAfFWdAvtbUBB2Qi();
    }

    /// <inheritdoc />
    public Task<IEnumerable<BPMAppFakeManifest>> GetFakeManifests() => Task.FromResult<IEnumerable<BPMAppFakeManifest>>((IEnumerable<BPMAppFakeManifest>) this.continuedImportState?.Manifests);

    /// <summary>Есть ли незавершенная сессия продолжаемого импорта</summary>
    private bool HasContinuedImport() => this.blobStore.LoadOrNull(ImportExecutorActor.StateKey) != null;

    /// <summary>Завершить импорт</summary>
    private void FinishImport()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.blobStore.Save(ImportExecutorActor.TimestampKey, (byte[]) ImportExecutorActor.uSv8iSfFbUSEUh0I994N(ImportExecutorActor.GyPABkfFo4MQ5dvit8xC((object) this.timestampService)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
            continue;
          case 2:
            this.isStarted = false;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>Инициализировать поля перед запуском импорта</summary>
    private void PrepareToStart()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            this.log = new List<DeployLogMessage>();
            num = 4;
            continue;
          case 3:
            this.isStarted = true;
            num = 2;
            continue;
          case 4:
            this.systemMessages = new List<DeploySystemMessage>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
            continue;
          default:
            this.cts = new CancellationTokenSource();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 1 : 0;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Создать параметры запуска импорта</summary>
    private IRunImportParameters CreateRunImportParameters(long? userId) => (IRunImportParameters) new RunImportParameters(userId, this.log, this.systemMessages, this.cts.Token);

    /// <inheritdoc />
    public Task<IContinuedImportState> GetImportState() => Task.FromResult<IContinuedImportState>((IContinuedImportState) this.continuedImportState);

    static ImportExecutorActor()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            ImportExecutorActor.StateKey = (string) ImportExecutorActor.XVuoNgfFGwByBUS7qSUC(1917998801 >> 2 ^ 479304670);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
            continue;
          case 2:
            ImportExecutorActor.JAyQb3fFhJr49H1UTTTr();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 1 : 0;
            continue;
          case 3:
            goto label_2;
          default:
            ImportExecutorActor.TimestampKey = (string) ImportExecutorActor.XVuoNgfFGwByBUS7qSUC(-787452571 ^ -787127391);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 2 : 3;
            continue;
        }
      }
label_2:;
    }

    internal static bool dNBL2lfFFC2GikRKNEd2() => ImportExecutorActor.LocliPEzzG8o2rWpsNP5 == null;

    internal static ImportExecutorActor eiRCPvfFBwx7ivDuTyK1() => ImportExecutorActor.LocliPEzzG8o2rWpsNP5;

    internal static object meI7oAfFWdAvtbUBB2Qi() => (object) Task.CompletedTask;

    internal static long GyPABkfFo4MQ5dvit8xC([In] object obj0) => ((ITimestampService) obj0).GetTimestamp();

    internal static object uSv8iSfFbUSEUh0I994N([In] long obj0) => (object) BitConverter.GetBytes(obj0);

    internal static void JAyQb3fFhJr49H1UTTTr() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object XVuoNgfFGwByBUS7qSUC(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object lbuRVwfFEWxVxvhb9ImP([In] object obj0, [In] object obj1) => (object) ((IBLOBStore) obj0).LoadOrNull((string) obj1);

    internal static object PULCApfFfLaTDBKCEZ2n([In] object obj0) => ClassSerializationHelper.DeserializeObject((byte[]) obj0);

    internal static object qHjdhZfFQHOZ3kNeteuB() => (object) Logger.Log;

    internal static object PmsumkfFCC7WSvYYja57([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static void HuF9iZfFvtVtimUobrt0([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);
  }
}
