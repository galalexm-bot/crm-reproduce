// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Actors.ConfigurationTestStartActor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Deploy.Import;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace EleWise.ELMA.Deploy.Actors
{
  /// <summary>Актор проверки конфигурации для импорта</summary>
  internal sealed class ConfigurationTestStartActor : 
    Actor,
    IConfigurationTestStartActor,
    IActorWithGuidKey,
    IActor
  {
    /// <summary>Идентификатор актора</summary>
    internal static readonly Guid ActorId;
    private readonly IActorModelRuntime actorModelRuntime;
    private readonly ConcurrentDictionary<Guid, IReadOnlyCollection<Guid>> testedModules;
    private static ConfigurationTestStartActor G11vP2EcA53lAQ5MZc8o;

    /// <summary>Ctor</summary>
    /// <param name="actorModelRuntime">Среда исполнения акторов</param>
    public ConfigurationTestStartActor(IActorModelRuntime actorModelRuntime)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
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
            this.actorModelRuntime = actorModelRuntime;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
            continue;
          default:
            this.testedModules = new ConcurrentDictionary<Guid, IReadOnlyCollection<Guid>>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 1 : 1;
            continue;
        }
      }
label_2:;
    }

    /// <inheritdoc />
    public Task<IEnumerable<DeploySystemMessage>> GetSystemMessages(
      Guid testUid,
      int offset,
      int count)
    {
      return this.GetTestActor(testUid).GetSystemMessages(offset, count);
    }

    /// <inheritdoc />
    public Task<IEnumerable<TestImportMessages>> GetLog(Guid testUid, int offset, int count) => this.GetTestActor(testUid).GetLog(offset, count);

    /// <inheritdoc />
    public Task Clear(Guid testUid) => (Task) ConfigurationTestStartActor.SgTZoAEc00J6TB7OeUvd((object) this.GetTestActor(testUid));

    /// <inheritdoc />
    public Task<IConfigImportSettings[]> GetTestedSettings(Guid testUid)
    {
      this.testedModules.TryRemove(testUid, out IReadOnlyCollection<Guid> _);
      return this.GetTestActor(testUid).GetTestedSettings();
    }

    /// <inheritdoc />
    public Task<string> GetAppId(Guid testUid) => this.GetTestActor(testUid).GetAppId();

    /// <inheritdoc />
    public Task Test(
      Guid testUid,
      IConfigImportSettings settings,
      string activateKey,
      bool storeSettings)
    {
      return (Task) ConfigurationTestStartActor.Hlq36cEcmcIL38k4YbWP((object) this.GetTestActor(testUid), (object) settings, (object) activateKey, storeSettings);
    }

    /// <inheritdoc />
    public Task TestModules(
      Guid testUid,
      IEnumerable<IConfigImportSettings> settings,
      string activateKey,
      bool storeSettings)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      List<Guid> list = settings.Where<IConfigImportSettings>((Func<IConfigImportSettings, bool>) (setting => ConfigurationTestStartActor.\u003C\u003Ec.fYmKOP8ydAvrdl9Saumj((object) setting) != null)).Select<IConfigImportSettings, Guid>((Func<IConfigImportSettings, Guid>) (setting => ConfigurationTestStartActor.\u003C\u003Ec.BYQaIg8ylfgrJtCElvuD((object) setting.Manifest))).ToList<Guid>();
      this.testedModules[testUid] = (IReadOnlyCollection<Guid>) list;
      return this.GetTestActor(testUid).TestModules(settings, activateKey, storeSettings);
    }

    /// <inheritdoc />
    public Task<IConfigImportSettings[]> GetTestedSettingsWithCheck(Guid testUid) => this.GetTestActor(testUid).GetTestedSettingsWithCheck();

    /// <inheritdoc />
    public Task<BPMAppFakeManifest[]> GetFakeManifest(Guid testUid) => this.GetTestActor(testUid).GetFakeManifest();

    private IConfigurationTestActor GetTestActor(Guid testUid) => this.actorModelRuntime.GetActor<IConfigurationTestActor>(testUid);

    /// <inheritdoc />
    public Task<IReadOnlyCollection<Guid>> GetTestedModules() => Task.FromResult<IReadOnlyCollection<Guid>>((IReadOnlyCollection<Guid>) this.testedModules.Values.SelectMany<IReadOnlyCollection<Guid>, Guid>((Func<IReadOnlyCollection<Guid>, IEnumerable<Guid>>) (values => (IEnumerable<Guid>) values)).ToList<Guid>());

    static ConfigurationTestStartActor()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ConfigurationTestStartActor.ActorId = Guid.Empty;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
            continue;
          case 2:
            ConfigurationTestStartActor.EeGq2LEcyiVtK6pnPc4U();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool RK4JHXEc7ZTtbMkRx8Y1() => ConfigurationTestStartActor.G11vP2EcA53lAQ5MZc8o == null;

    internal static ConfigurationTestStartActor UsJdoHEcxx3M7DYbYOcb() => ConfigurationTestStartActor.G11vP2EcA53lAQ5MZc8o;

    internal static object SgTZoAEc00J6TB7OeUvd([In] object obj0) => (object) ((IConfigurationTestActor) obj0).Clear();

    internal static object Hlq36cEcmcIL38k4YbWP(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      bool storeSettings)
    {
      return (object) ((IConfigurationTestActor) obj0).Test((IConfigImportSettings) obj1, (string) obj2, storeSettings);
    }

    internal static void EeGq2LEcyiVtK6pnPc4U() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
