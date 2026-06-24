// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.ActorContextService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Services
{
  /// <inheritdoc />
  [Service]
  internal sealed class ActorContextService : IActorContextManagementService, IActorContextService
  {
    /// <summary>Сервис работы с контекстом</summary>
    private readonly ILazy<IContextBoundVariableService> contextService;
    private static ActorContextService RC37dkBaeEACq7YsK1i1;

    /// <summary>Ctor</summary>
    /// <param name="contextService">Сервис работы с контекстом</param>
    public ActorContextService(ILazy<IContextBoundVariableService> contextService)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.contextService = contextService;
    }

    /// <inheritdoc />
    public IDictionary<string, object> Get() => this.contextService.IsRegistered ? (IDictionary<string, object>) this.contextService.Value.GetOrAdd<SerializableDictionary<string, object>>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488831067), (Func<SerializableDictionary<string, object>>) (() => new SerializableDictionary<string, object>())) : (IDictionary<string, object>) null;

    /// <inheritdoc />
    public bool TryGet(string key, out object value)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.contextService.IsRegistered)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
              continue;
            }
            value = (object) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 2 : 2;
            continue;
          case 2:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_4:
      return false;
label_5:
      IContextBoundVariableService contextBoundVariableService = this.contextService.Value;
      object name = ActorContextService.JERnkgBaNvbjQjqdjUvs(1654249598 >> 2 ^ 413610609);
      // ISSUE: reference to a compiler-generated field
      Func<SerializableDictionary<string, object>> func = ActorContextService.\u003C\u003Ec.\u003C\u003E9__4_0;
      Func<SerializableDictionary<string, object>> factory;
      if (func == null)
      {
        // ISSUE: reference to a compiler-generated field
        ActorContextService.\u003C\u003Ec.\u003C\u003E9__4_0 = factory = (Func<SerializableDictionary<string, object>>) (() => new SerializableDictionary<string, object>());
      }
      else
        goto label_6;
label_8:
      return contextBoundVariableService.GetOrAdd<SerializableDictionary<string, object>>((string) name, factory).TryGetValue(key, out value);
label_6:
      factory = func;
      goto label_8;
    }

    /// <inheritdoc />
    public void Set(string key, object value)
    {
      int num = 1;
      SerializableDictionary<string, object> orAdd;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (ActorContextService.rSUHYnBa3GhWhFubiyKN((object) this.contextService))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            ActorContextService.XjsOknBapoYXxtjLFn7d((object) this.contextService.Value, ActorContextService.JERnkgBaNvbjQjqdjUvs(694673736 ^ -23604109 ^ -672042667), (object) orAdd);
            num = 4;
            continue;
          case 3:
            orAdd[key] = value;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 1 : 2;
            continue;
          case 4:
            goto label_2;
          default:
            orAdd = this.contextService.Value.GetOrAdd<SerializableDictionary<string, object>>((string) ActorContextService.JERnkgBaNvbjQjqdjUvs(-244066886 - -48452443 ^ -195662469), (Func<SerializableDictionary<string, object>>) (() => new SerializableDictionary<string, object>()));
            num = 3;
            continue;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <inheritdoc />
    public void Set(IDictionary<string, object> incomingContext)
    {
      if (incomingContext == null || incomingContext.Count == 0 || !this.contextService.IsRegistered)
        return;
      SerializableDictionary<string, object> orAdd = this.contextService.Value.GetOrAdd<SerializableDictionary<string, object>>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1597012150 ^ 1597062360), (Func<SerializableDictionary<string, object>>) (() => new SerializableDictionary<string, object>()));
      foreach (KeyValuePair<string, object> keyValuePair in (IEnumerable<KeyValuePair<string, object>>) incomingContext)
        orAdd[keyValuePair.Key] = keyValuePair.Value;
      this.contextService.Value.Set(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-122002947 ^ 121952876), (object) orAdd);
    }

    internal static object JERnkgBaNvbjQjqdjUvs(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool REsss5BaPk9Fg9grmZy0() => ActorContextService.RC37dkBaeEACq7YsK1i1 == null;

    internal static ActorContextService XZCXqgBa1h0sNOh4Fvwb() => ActorContextService.RC37dkBaeEACq7YsK1i1;

    internal static bool rSUHYnBa3GhWhFubiyKN([In] object obj0) => ((ILazy<IContextBoundVariableService>) obj0).IsRegistered;

    internal static void XjsOknBapoYXxtjLFn7d([In] object obj0, [In] object obj1, [In] object obj2) => ((IAbstractBoundVariableService) obj0).Set((string) obj1, obj2);
  }
}
