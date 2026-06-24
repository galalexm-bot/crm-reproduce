// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Actors.ConfigurationTestActor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.Deploy.Utils;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata.Services;
using EleWise.ELMA.Runtime.Managers;
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
  /// <summary>Актор проверки конфигурации для импорта</summary>
  internal sealed class ConfigurationTestActor : 
    Actor,
    IConfigurationTestActor,
    IActorWithGuidKey,
    IActor
  {
    private bool isStarted;
    private CancellationTokenSource cts;
    private Task externalTask;
    private IConfigImportSettings[] testedSettings;
    private IConfigImportSettings currentSettings;
    private IConfigurationTesterInternal configurationTesterInternal;
    private long timestamp;
    private Version configurationVersion;
    private readonly IBLOBStore blobStore;
    private readonly ITimestampService timestampService;
    private readonly IConfigurationImportInternalFactory configurationImportInternalFactory;
    private readonly IModuleMetadataLoader moduleMetadataLoader;
    private readonly IModuleMetadataExtractorService moduleMetadataExtractorService;
    private bool storeSettingsInBlobStore;
    private List<TestImportMessages> testMessages;
    private List<DeploySystemMessage> systemMessages;
    /// <summary>Ключ для сохранения данных данным актором</summary>
    internal static readonly string TestDataKey;
    private static ConfigurationTestActor ujSKONEz8dOWEte8dVDI;

    /// <summary>Ctor</summary>
    /// <param name="blobStore">Хранилище бинарных данных</param>
    /// <param name="timestampService">Сервис временных штампов</param>
    /// <param name="configurationImportInternalFactory">Сервис-фабрика объектов для проверки конфигураций</param>
    /// <param name="moduleMetadataLoader">Загрузчик метаданных модулей</param>
    /// <param name="moduleMetadataExtractorService">Загрузчик метаданных модулей</param>
    public ConfigurationTestActor(
      IBLOBStore blobStore,
      ITimestampService timestampService,
      IConfigurationImportInternalFactory configurationImportInternalFactory,
      IModuleMetadataLoader moduleMetadataLoader,
      IModuleMetadataExtractorService moduleMetadataExtractorService)
    {
      ConfigurationTestActor.ReKIbWEzIQDmr1rgoVc8();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 3;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
        num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.timestampService = timestampService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 3 : 4;
            continue;
          case 3:
            this.blobStore = blobStore;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 2 : 1;
            continue;
          case 4:
            this.configurationImportInternalFactory = configurationImportInternalFactory;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
            continue;
          case 5:
            this.moduleMetadataExtractorService = moduleMetadataExtractorService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 1 : 1;
            continue;
          default:
            this.moduleMetadataLoader = moduleMetadataLoader;
            num = 5;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public override Task OnActivateAsync()
    {
      int num1 = 3;
      byte[] numArray;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            if (numArray != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 3:
            numArray = (byte[]) ConfigurationTestActor.PYulLNEzSa0h6T6tymeC((object) this.blobStore, ConfigurationTestActor.sNwM7JEzVuwANmN2QH6x((object) ConfigurationTestActor.TestDataKey, (object) this.GetPrimaryKey<Guid>()));
            num1 = 2;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return (Task) ConfigurationTestActor.Y9742lEzXZ07leyC1bwB();
label_4:
      try
      {
        ConfigurationTestActor.TestData testData = (ConfigurationTestActor.TestData) ConfigurationTestActor.wPUrlyEziroy3e6wyiBy((object) numArray);
        int num2 = 3;
        while (true)
        {
          switch (num2)
          {
            case 1:
              this.timestamp = ConfigurationTestActor.IhyMbHEzqgF8KqujqBrH((object) testData);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            case 3:
              this.testedSettings = (IConfigImportSettings[]) ConfigurationTestActor.ObBJXBEzRoX9Zd3p6Wsn((object) testData);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 1 : 1;
              continue;
            default:
              this.configurationVersion = (Version) ConfigurationTestActor.me3E41EzKb6opWdCTBOu((object) testData);
              num2 = 2;
              continue;
          }
        }
      }
      catch
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
          num3 = 0;
        switch (num3)
        {
          default:
            goto label_2;
        }
      }
    }

    /// <inheritdoc />
    public override Task OnDeactivateAsync()
    {
      int num = 4;
      // ISSUE: variable of a compiler-generated type
      ConfigurationTestActor.\u003COnDeactivateAsync\u003Ed__19 stateMachine;
      AsyncTaskMethodBuilder tBuilder;
      while (true)
      {
        switch (num)
        {
          case 1:
            tBuilder.Start<ConfigurationTestActor.\u003COnDeactivateAsync\u003Ed__19>(ref stateMachine);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E1__state = -1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 5 : 1;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003Et__builder = AsyncTaskMethodBuilder.Create();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 2;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E4__this = this;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 3 : 0;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            tBuilder = stateMachine.\u003C\u003Et__builder;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 1 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <inheritdoc />
    public Task<IEnumerable<TestImportMessages>> GetLog(int offset, int count) => this.testMessages == null ? Task.FromResult<IEnumerable<TestImportMessages>>(Enumerable.Empty<TestImportMessages>()) : Task.FromResult<IEnumerable<TestImportMessages>>(DeployUtils.SafeSkip<TestImportMessages>(this.testMessages, offset, count));

    /// <inheritdoc />
    public Task<IEnumerable<DeploySystemMessage>> GetSystemMessages(int offset, int count) => this.systemMessages == null ? Task.FromResult<IEnumerable<DeploySystemMessage>>(Enumerable.Empty<DeploySystemMessage>()) : Task.FromResult<IEnumerable<DeploySystemMessage>>(DeployUtils.SafeSkip<DeploySystemMessage>(this.systemMessages, offset, count));

    /// <inheritdoc />
    public Task Test(IConfigImportSettings settings, string activateKey, bool storeSettings)
    {
      int num1 = 10;
      while (true)
      {
        int num2 = num1;
        ConfigurationTestActor configurationTestActor;
        IConfigImportSettings settings1;
        string activateKey1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!this.isStarted)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 0 : 0;
                continue;
              }
              goto label_7;
            case 2:
              this.testMessages = new List<TestImportMessages>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 3;
              continue;
            case 3:
              this.systemMessages = new List<DeploySystemMessage>();
              num2 = 6;
              continue;
            case 4:
              this.storeSettingsInBlobStore = storeSettings;
              num2 = 2;
              continue;
            case 5:
              settings1 = settings;
              num2 = 12;
              continue;
            case 6:
              goto label_14;
            case 7:
              goto label_5;
            case 8:
              goto label_7;
            case 9:
              configurationTestActor = this;
              num2 = 5;
              continue;
            case 10:
              goto label_3;
            case 11:
              this.cts = new CancellationTokenSource();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 4 : 4;
              continue;
            case 12:
              activateKey1 = activateKey;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 1 : 1;
              continue;
            default:
              goto label_8;
          }
        }
label_3:
        num1 = 9;
        continue;
label_8:
        this.isStarted = true;
        num1 = 11;
        continue;
label_14:
        this.externalTask = this.RunExternalTask((Func<Task>) (() => configurationTestActor.TestSingle(settings1, activateKey1)));
        num1 = 7;
      }
label_5:
      return (Task) ConfigurationTestActor.Y9742lEzXZ07leyC1bwB();
label_7:
      return Task.CompletedTask;
    }

    /// <summary>Выполнить проверку конфигурации</summary>
    private Task TestSingle(IConfigImportSettings settings, string activateKey)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              this.timestamp = ConfigurationTestActor.nYaGyjEzT2o1Cv7wI4oq((object) this.timestampService);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_4;
            case 3:
              goto label_6;
            case 4:
              goto label_5;
            default:
              this.configurationVersion = ConfigurationModelAssemblyBuilder.NextVersion;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 2 : 2;
              continue;
          }
        }
label_4:
        this.testedSettings = new IConfigImportSettings[1]
        {
          settings
        };
        num1 = 3;
      }
label_5:
      return Task.CompletedTask;
label_6:
      try
      {
        this.TestSettingsSync(settings, activateKey);
        int num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
          num3 = 1;
        while (true)
        {
          switch (num3)
          {
            case 1:
              this.testMessages.Add(new TestImportMessages(TestImportMessagesType.Finish));
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 0;
              continue;
            default:
              goto label_5;
          }
        }
      }
      catch
      {
        int num4 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0)
          num4 = 0;
        while (true)
        {
          switch (num4)
          {
            case 1:
              this.testedSettings = (IConfigImportSettings[]) null;
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 0 : 0;
              continue;
            default:
              goto label_14;
          }
        }
label_14:
        throw;
      }
    }

    /// <summary>Выполнить проверку конфигурации</summary>
    private void TestSettingsSync(IConfigImportSettings settings, string activateKey)
    {
      int num = 6;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.configurationTesterInternal.BeforeAddTestMessage -= new Action<TestImportMessages>(this.OnAddTestMessage);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 3 : 1;
            continue;
          case 2:
            goto label_2;
          case 3:
            this.systemMessages.AddRange((IEnumerable<DeploySystemMessage>) this.configurationTesterInternal.GetTestSystemMessages());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 2 : 2;
            continue;
          case 4:
            this.configurationTesterInternal.RunTest((IRunTestParameters) new RunTestParameters(activateKey, this.cts.Token));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 1 : 0;
            continue;
          case 5:
            this.configurationTesterInternal = (IConfigurationTesterInternal) ConfigurationTestActor.A3O2j1EzkJCG2qrtdtAu((object) this.configurationImportInternalFactory, (object) settings);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
            continue;
          case 6:
            this.currentSettings = settings;
            num = 5;
            continue;
          default:
            this.configurationTesterInternal.BeforeAddTestMessage += new Action<TestImportMessages>(this.OnAddTestMessage);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 4 : 2;
            continue;
        }
      }
label_2:;
    }

    /// <inheritdoc />
    public Task TestModules(
      IEnumerable<IConfigImportSettings> settings,
      string activateKey,
      bool storeSettings)
    {
      if (this.isStarted)
        return Task.CompletedTask;
      this.isStarted = true;
      this.cts = new CancellationTokenSource();
      this.storeSettingsInBlobStore = storeSettings;
      this.testMessages = new List<TestImportMessages>();
      this.systemMessages = new List<DeploySystemMessage>();
      this.externalTask = this.RunExternalTask((Func<Task>) (() => this.TestModulesInternal(settings, activateKey)));
      return Task.CompletedTask;
    }

    /// <summary>Выполнить проверку списка конфигураций</summary>
    private Task TestModulesInternal(
      IEnumerable<IConfigImportSettings> configImportSettings,
      string activateKey)
    {
      this.timestamp = this.timestampService.GetTimestamp();
      this.configurationVersion = ConfigurationModelAssemblyBuilder.NextVersion;
      try
      {
        ModuleTester moduleTester = new ModuleTester(this.moduleMetadataExtractorService, this.moduleMetadataLoader, new Action<IConfigImportSettings, string>(this.TestSettingsSync));
        moduleTester.MessageAdded += new Action<TestImportMessages>(this.OnAddTestMessage);
        IReadOnlyCollection<IConfigImportSettings> source = moduleTester.TestModules(configImportSettings, activateKey);
        moduleTester.MessageAdded -= new Action<TestImportMessages>(this.OnAddTestMessage);
        this.testedSettings = source.ToArray<IConfigImportSettings>();
      }
      catch (Exception ex)
      {
        this.testMessages.Add(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1445902765 ^ -1980277732 ^ 539170339), (object) ex.ToString())));
      }
      this.testMessages.Add(new TestImportMessages(TestImportMessagesType.Finish));
      return Task.CompletedTask;
    }

    /// <inheritdoc />
    public Task<IConfigImportSettings[]> GetTestedSettingsWithCheck()
    {
      if (this.testedSettings == null)
        return Task.FromException<IConfigImportSettings[]>((Exception) new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1178210108 ^ 1178534890))));
      byte[] numArray = this.blobStore.LoadOrNull(ImportExecutorActor.TimestampKey);
      if (numArray != null && this.timestamp < BitConverter.ToInt64(numArray, 0))
      {
        this.ClearTestData();
        return Task.FromException<IConfigImportSettings[]>((Exception) new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(647913418 ^ 647713520))));
      }
      if (ConfigurationModelAssemblyBuilder.NextVersion.CompareTo(this.configurationVersion) == 0)
        return Task.FromResult<IConfigImportSettings[]>(this.testedSettings);
      this.ClearTestData();
      return Task.FromException<IConfigImportSettings[]>((Exception) new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107653852))));
    }

    /// <inheritdoc />
    public Task<BPMAppFakeManifest[]> GetFakeManifest() => this.testedSettings == null ? Task.FromResult<BPMAppFakeManifest[]>(Array.Empty<BPMAppFakeManifest>()) : Task.FromResult<BPMAppFakeManifest[]>(((IEnumerable<IConfigImportSettings>) this.testedSettings).Select<IConfigImportSettings, BPMAppFakeManifest>((Func<IConfigImportSettings, BPMAppFakeManifest>) (s => s.FakeManifest)).ToArray<BPMAppFakeManifest>());

    /// <inheritdoc />
    public Task Clear()
    {
      switch (1)
      {
        case 1:
          try
          {
            this.ClearTestData();
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0)
              num = 0;
            switch (num)
            {
            }
          }
          finally
          {
            this.DeactivateOnIdle();
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
              num = 0;
            switch (num)
            {
              default:
            }
          }
          break;
      }
      return (Task) ConfigurationTestActor.Y9742lEzXZ07leyC1bwB();
    }

    /// <inheritdoc />
    public Task<IConfigImportSettings[]> GetTestedSettings() => this.testedSettings == null ? Task.FromResult<IConfigImportSettings[]>(Array.Empty<IConfigImportSettings>()) : Task.FromResult<IConfigImportSettings[]>(this.testedSettings);

    /// <inheritdoc />
    public Task<string> GetAppId() => Task.FromResult<string>(this.configurationTesterInternal?.AppId);

    private void ClearTestData()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_5;
          case 1:
            if (this.testedSettings == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 2:
            this.testedSettings = (IConfigImportSettings[]) null;
            num = 4;
            continue;
          case 3:
            ConfigurationTestActor.Md53k6Ezn5yx7jy9AymB((object) this.blobStore, ConfigurationTestActor.sNwM7JEzVuwANmN2QH6x((object) ConfigurationTestActor.TestDataKey, (object) this.GetPrimaryKey<Guid>()));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 2;
            continue;
          case 4:
            goto label_2;
          default:
            goto label_8;
        }
      }
label_5:
      return;
label_2:
      return;
label_8:;
    }

    /// <summary>Заполнение результатов теста</summary>
    /// <param name="testMessage">Сообщение</param>
    private void OnAddTestMessage(TestImportMessages testMessage)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_7;
          case 1:
            IConfigImportSettings currentSettings = this.currentSettings;
            if (currentSettings == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
              continue;
            }
            currentSettings.TestResult.Add(testMessage);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 4 : 0;
            continue;
          case 2:
            this.testMessages.Add(testMessage);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 1 : 1;
            continue;
          case 3:
            if (ConfigurationTestActor.ueCTpyEzOCQdmD8kETbR((object) testMessage) != TestImportMessagesType.Finish)
            {
              num = 2;
              continue;
            }
            goto case 1;
          case 4:
            goto label_2;
          default:
            goto label_10;
        }
      }
label_7:
      return;
label_2:
      return;
label_10:;
    }

    static ConfigurationTestActor()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ConfigurationTestActor.TestDataKey = (string) ConfigurationTestActor.SkW0GoEz2wiae9oA7cyA(132912447 ^ 132716775);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static void ReKIbWEzIQDmr1rgoVc8() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool oqQwEGEzZtcuvq2gCT52() => ConfigurationTestActor.ujSKONEz8dOWEte8dVDI == null;

    internal static ConfigurationTestActor WDlGCnEzufHSgVmZcBc1() => ConfigurationTestActor.ujSKONEz8dOWEte8dVDI;

    internal static object sNwM7JEzVuwANmN2QH6x([In] object obj0, [In] object obj1) => (object) (obj0.ToString() + obj1);

    internal static object PYulLNEzSa0h6T6tymeC([In] object obj0, [In] object obj1) => (object) ((IBLOBStore) obj0).LoadOrNull((string) obj1);

    internal static object wPUrlyEziroy3e6wyiBy([In] object obj0) => ClassSerializationHelper.DeserializeObject((byte[]) obj0);

    internal static object ObBJXBEzRoX9Zd3p6Wsn([In] object obj0) => (object) ((ConfigurationTestActor.TestData) obj0).ImportSettings;

    internal static long IhyMbHEzqgF8KqujqBrH([In] object obj0) => ((ConfigurationTestActor.TestData) obj0).Timestamp;

    internal static object me3E41EzKb6opWdCTBOu([In] object obj0) => (object) ((ConfigurationTestActor.TestData) obj0).ConfigurationVersion;

    internal static object Y9742lEzXZ07leyC1bwB() => (object) Task.CompletedTask;

    internal static long nYaGyjEzT2o1Cv7wI4oq([In] object obj0) => ((ITimestampService) obj0).GetTimestamp();

    internal static object A3O2j1EzkJCG2qrtdtAu([In] object obj0, [In] object obj1) => (object) ((IConfigurationImportInternalFactory) obj0).CreateTester((IImportSettings) obj1);

    internal static void Md53k6Ezn5yx7jy9AymB([In] object obj0, [In] object obj1) => ((IBLOBStore) obj0).Remove((string) obj1);

    internal static TestImportMessagesType ueCTpyEzOCQdmD8kETbR([In] object obj0) => ((TestImportMessages) obj0).Type;

    internal static object SkW0GoEz2wiae9oA7cyA(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    [Serializable]
    private class TestData
    {
      internal static object w1xo1a8yrnH6UKok1cM5;

      public IConfigImportSettings[] ImportSettings { get; }

      public long Timestamp { get; }

      public Version ConfigurationVersion { get; }

      public TestData(
        IConfigImportSettings[] importSettings,
        long timestamp,
        Version configVersion)
      {
        ConfigurationTestActor.TestData.KFSq7X8yj4Uu5RxKAhqc();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.Timestamp = timestamp;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
              continue;
            case 2:
              this.ImportSettings = importSettings;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_2;
            default:
              this.ConfigurationVersion = configVersion;
              num = 3;
              continue;
          }
        }
label_2:;
      }

      internal static void KFSq7X8yj4Uu5RxKAhqc() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool Glx4iR8ygCIAuNoadGGc() => ConfigurationTestActor.TestData.w1xo1a8yrnH6UKok1cM5 == null;

      internal static ConfigurationTestActor.TestData KDSxjt8y5PfGyv4cDVTQ() => (ConfigurationTestActor.TestData) ConfigurationTestActor.TestData.w1xo1a8yrnH6UKok1cM5;
    }
  }
}
