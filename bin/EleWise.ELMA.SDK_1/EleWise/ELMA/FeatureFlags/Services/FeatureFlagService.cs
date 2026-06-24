// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FeatureFlags.Services.FeatureFlagService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.FeatureFlags;
using EleWise.ELMA.ActorModel.Starting;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.FeatureFlags.ExtensionPoints;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.FeatureFlags.Services
{
  /// <summary>Сервис флагов функций</summary>
  [Service]
  internal sealed class FeatureFlagService : IFeatureFlagService
  {
    private readonly ILogger logger;
    private readonly IEnumerable<IFeatureFlagProvider> featureFlagProviders;
    private readonly IServerPlacementPublishService serverPlacementPublishService;
    private readonly IActorModelRuntime actorModelRuntime;
    private readonly IRuntimeApplication runtimeApplication;
    private readonly IDictionary<string, bool?> featureFlags;
    private readonly object processLockObject;
    private readonly ISet<string> needNewKeys;
    private ISet<string> processKeys;
    private bool wasActorInitHandler;
    private static FeatureFlagService FrnwkFGBzqesL6HRfPIe;

    /// <summary>Ctor</summary>
    /// <param name="featureFlagProviders">Провайдеры флагов функций</param>
    /// <param name="serverPlacementPublishService">Сервис публикации действия на всех серверах кластера ELMA</param>
    /// <param name="actorModelRuntime">Интерфейс Модели Акторов</param>
    /// <param name="runtimeApplication">Интерфейс для работы со средой исполнения приложения</param>
    public FeatureFlagService(
      IEnumerable<IFeatureFlagProvider> featureFlagProviders,
      IServerPlacementPublishService serverPlacementPublishService,
      IActorModelRuntime actorModelRuntime,
      IRuntimeApplication runtimeApplication)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.logger = Logger.GetLogger(typeof (FeatureFlagService));
      this.featureFlags = (IDictionary<string, bool?>) new Dictionary<string, bool?>();
      this.processLockObject = new object();
      this.needNewKeys = (ISet<string>) new HashSet<string>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.featureFlagProviders = featureFlagProviders;
      this.serverPlacementPublishService = serverPlacementPublishService;
      this.actorModelRuntime = actorModelRuntime;
      this.runtimeApplication = runtimeApplication;
      featureFlagProviders.ForEach<IFeatureFlagProvider>((Action<IFeatureFlagProvider>) (p =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              FeatureFlagService.MPyJ1yGWiE9UPqOiWbpK((object) p, (object) new EventHandler(this.FlagsChanged));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }));
    }

    /// <summary>Получить состояние флага</summary>
    /// <param name="name">Имя флага</param>
    /// <returns>Состояние флага</returns>
    internal bool? Enabled(string name)
    {
      bool? featureFlag;
      if (!this.featureFlags.TryGetValue(name, out featureFlag))
      {
        this.RefreshFlags(name);
        featureFlag = this.featureFlags[name];
      }
      return featureFlag;
    }

    /// <inheritdoc />
    public bool Enabled(string name, bool defaultEnabled)
    {
      int num = 3;
      bool? nullable;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (nullable.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 3:
            nullable = this.Enabled(name);
            num = 2;
            continue;
          default:
            goto label_6;
        }
      }
label_5:
      return defaultEnabled;
label_6:
      return nullable.GetValueOrDefault();
    }

    private void FlagsChanged(object sender, EventArgs e)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.RefreshFlags((string) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    private void RefreshFlags(string newFlag)
    {
      switch (1)
      {
        case 1:
          try
          {
            int num1;
            if (newFlag == null)
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
            else
              goto label_11;
label_3:
            object processLockObject;
            bool lockTaken1;
            IDictionary<string, bool?> featureFlags;
            while (true)
            {
              int? nullable1;
              int? nullable2;
              int num2;
              int? nullable3;
              switch (num1)
              {
                case 1:
                  try
                  {
                    Monitor.Enter((object) featureFlags, ref lockTaken1);
                    int num3 = 2;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
                      num3 = 2;
                    while (true)
                    {
                      switch (num3)
                      {
                        case 1:
                          goto label_125;
                        case 2:
                          if (this.featureFlags.ContainsKey(newFlag))
                          {
                            num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 1 : 1;
                            continue;
                          }
                          goto case 3;
                        case 3:
                          this.needNewKeys.Add(newFlag);
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 0;
                          continue;
                        default:
                          goto label_4;
                      }
                    }
label_125:
                    return;
                  }
                  finally
                  {
                    if (lockTaken1)
                    {
                      int num4 = 1;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0)
                        num4 = 1;
                      while (true)
                      {
                        switch (num4)
                        {
                          case 1:
                            FeatureFlagService.ej24GyGWWhtoweBvJ1Vn((object) featureFlags);
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
                            continue;
                          default:
                            goto label_26;
                        }
                      }
                    }
label_26:;
                  }
                case 2:
                  goto label_120;
                case 3:
                case 10:
label_4:
                  processLockObject = this.processLockObject;
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 12 : 3;
                  continue;
                case 4:
                  nullable3 = nullable1;
                  break;
                case 5:
                  goto label_27;
                case 6:
                  if (!(nullable2.GetValueOrDefault() == num2 & nullable2.HasValue))
                  {
                    num1 = 10;
                    continue;
                  }
                  goto label_116;
                case 8:
                  num2 = FeatureFlagService.TAbogBGWodWY9QKrPXgw((object) this.featureFlags);
                  num1 = 6;
                  continue;
                case 9:
                  goto label_113;
                case 11:
                  nullable1 = new int?();
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 4 : 4;
                  continue;
                case 12:
                  lockTaken1 = false;
                  num1 = 5;
                  continue;
                case 13:
                  lockTaken1 = false;
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 1 : 1;
                  continue;
                case 14:
                  ISet<string> processKeys = this.processKeys;
                  if (processKeys == null)
                  {
                    num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 11 : 3;
                    continue;
                  }
                  nullable3 = new int?(processKeys.Count);
                  break;
                case 15:
                  goto label_109;
                case 16:
                  goto label_11;
                default:
                  if (FeatureFlagService.TAbogBGWodWY9QKrPXgw((object) this.featureFlags) == 0)
                  {
                    num1 = 9;
                    continue;
                  }
                  goto case 14;
              }
              nullable2 = nullable3;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 8 : 2;
            }
label_120:
            break;
label_113:
            break;
label_109:
            break;
label_116:
            break;
label_27:
            try
            {
              Monitor.Enter(processLockObject, ref lockTaken1);
              int num5 = 27;
              while (true)
              {
                int num6;
                bool lockTaken2;
                // ISSUE: variable of a compiler-generated type
                FeatureFlagService.\u003C\u003Ec__DisplayClass14_0 cDisplayClass140;
                // ISSUE: variable of a compiler-generated type
                FeatureFlagService.\u003C\u003Ec__DisplayClass14_1 cDisplayClass141;
                IEnumerator<IFeatureFlagProvider> enumerator;
                bool flag;
                switch (num5)
                {
                  case 1:
                    try
                    {
                      Monitor.Enter((object) featureFlags, ref lockTaken2);
                      int num7 = 4;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0)
                        num7 = 5;
                      while (true)
                      {
                        switch (num7)
                        {
                          case 1:
                            if (!this.needNewKeys.Contains(newFlag))
                            {
                              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 2;
                              continue;
                            }
                            break;
                          case 2:
                            goto label_121;
                          case 4:
                            FeatureFlagService.hpZcqmGWbtcONBn6pBVa((object) this.needNewKeys);
                            num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 6 : 0;
                            continue;
                          case 5:
                            if (newFlag == null)
                            {
                              num7 = 3;
                              continue;
                            }
                            goto case 1;
                          case 6:
                            goto label_34;
                        }
                        this.processKeys = (ISet<string>) this.featureFlags.Keys.Union<string>((IEnumerable<string>) this.needNewKeys).ToHashSet<string>();
                        num7 = 4;
                      }
label_121:
                      return;
                    }
                    finally
                    {
                      if (lockTaken2)
                      {
                        int num8 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
                          num8 = 1;
                        while (true)
                        {
                          switch (num8)
                          {
                            case 1:
                              FeatureFlagService.ej24GyGWWhtoweBvJ1Vn((object) featureFlags);
                              num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
                              continue;
                            default:
                              goto label_79;
                          }
                        }
                      }
label_79:;
                    }
                  case 2:
                    // ISSUE: reference to a compiler-generated field
                    cDisplayClass141.CS\u0024\u003C\u003E8__locals1 = cDisplayClass140;
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 9 : 30;
                    continue;
                  case 3:
                    // ISSUE: object of a compiler-generated type is created
                    cDisplayClass141 = new FeatureFlagService.\u003C\u003Ec__DisplayClass14_1();
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 2 : 2;
                    continue;
                  case 4:
                    featureFlags = this.featureFlags;
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 10 : 12;
                    continue;
                  case 5:
                    flag = true;
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 6 : 8;
                    continue;
                  case 6:
                  case 26:
                    // ISSUE: reference to a compiler-generated field
                    cDisplayClass140.needActorReinit = false;
                    num6 = 4;
                    break;
                  case 7:
                    goto label_108;
                  case 8:
                  case 21:
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    ((IEnumerable<string>) this.processKeys.Except<string>((IEnumerable<string>) cDisplayClass141.CS\u0024\u003C\u003E8__locals1.newFeatureFlags.Keys).ToArray<string>()).ForEach<string>(new Action<string>(cDisplayClass141.\u003CRefreshFlags\u003Eb__5));
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 19 : 2;
                    continue;
                  case 9:
                    try
                    {
                      Monitor.Enter((object) featureFlags, ref lockTaken2);
                      int num9 = 1;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
                        num9 = 1;
                      while (true)
                      {
                        switch (num9)
                        {
                          case 1:
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated method
                            cDisplayClass140.newFeatureFlags.ForEach<KeyValuePair<string, bool?>>(new Action<KeyValuePair<string, bool?>>(cDisplayClass140.\u003CRefreshFlags\u003Eb__6));
                            num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
                            continue;
                          case 2:
                            goto label_40;
                          default:
                            this.processKeys = (ISet<string>) null;
                            num9 = 2;
                            continue;
                        }
                      }
                    }
                    finally
                    {
                      if (lockTaken2)
                      {
                        int num10 = 1;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
                          num10 = 0;
                        while (true)
                        {
                          switch (num10)
                          {
                            case 1:
                              Monitor.Exit((object) featureFlags);
                              num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
                              continue;
                            default:
                              goto label_98;
                          }
                        }
                      }
label_98:;
                    }
                  case 10:
                    goto label_104;
                  case 11:
                    // ISSUE: reference to a compiler-generated field
                    cDisplayClass140.\u003C\u003E4__this = this;
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 18 : 29;
                    continue;
                  case 12:
                    lockTaken2 = false;
                    num5 = 9;
                    continue;
                  case 13:
                    enumerator = this.featureFlagProviders.GetEnumerator();
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 8 : 14;
                    continue;
                  case 14:
                    try
                    {
label_48:
                      if (enumerator.MoveNext())
                        goto label_51;
                      else
                        goto label_49;
label_45:
                      List<(string, bool)> list;
                      IFeatureFlagProvider current;
                      int num11;
                      while (true)
                      {
                        switch (num11)
                        {
                          case 1:
                            goto label_48;
                          case 2:
                            List<(string, bool)> valueTupleList1 = list;
                            // ISSUE: reference to a compiler-generated field
                            Action<(string, bool)> action1 = cDisplayClass140.\u003C\u003E9__3;
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated method
                            Action<(string, bool)> action2 = action1 == null ? (cDisplayClass140.\u003C\u003E9__3 = new Action<(string, bool)>(cDisplayClass140.\u003CRefreshFlags\u003Eb__3)) : action1;
                            valueTupleList1.ForEach(action2);
                            num11 = 9;
                            continue;
                          case 3:
                            goto label_35;
                          case 4:
                            // ISSUE: reference to a compiler-generated field
                            FeatureFlagService.fVImIIGWC3q1kfVbMqpw(FeatureFlagService.fVImIIGWC3q1kfVbMqpw((object) ((StringBuilder) FeatureFlagService.KqOPj2GWfP2pZX7B0MVU((object) cDisplayClass140.message)).Append((string) FeatureFlagService.sNu74NGWGwEi0m6amDUJ(-441065788 ^ -2092910478 ^ 1727403064)), FeatureFlagService.OqOoxnGWQm9lmOYLNBxb((object) current.GetType())), FeatureFlagService.sNu74NGWGwEi0m6amDUJ(1669212571 ^ 1669298393));
                            num11 = 2;
                            continue;
                          case 5:
                            List<(string, bool)> valueTupleList2 = list;
                            // ISSUE: reference to a compiler-generated field
                            Action<(string, bool)> action3 = cDisplayClass140.\u003C\u003E9__4;
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated method
                            Action<(string, bool)> action4 = action3 == null ? (cDisplayClass140.\u003C\u003E9__4 = new Action<(string, bool)>(cDisplayClass140.\u003CRefreshFlags\u003Eb__4)) : action3;
                            valueTupleList2.ForEach(action4);
                            num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 1 : 1;
                            continue;
                          case 6:
                            if (FeatureFlagService.IG9f9iGWEJtnQCTaEOFc((object) list) > 0)
                            {
                              num11 = 8;
                              continue;
                            }
                            goto label_48;
                          case 7:
                            goto label_51;
                          case 8:
                            // ISSUE: reference to a compiler-generated field
                            if (cDisplayClass140.message != null)
                            {
                              num11 = 4;
                              continue;
                            }
                            goto case 5;
                          case 9:
                            flag = true;
                            num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 2 : 5;
                            continue;
                          default:
                            // ISSUE: reference to a compiler-generated field
                            IEnumerable<(string, bool)> flags = current.GetFlags(this.processKeys.Except<string>((IEnumerable<string>) cDisplayClass140.newFeatureFlags.Keys));
                            // ISSUE: reference to a compiler-generated field
                            Func<(string, bool), bool> func = cDisplayClass140.\u003C\u003E9__2;
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated method
                            Func<(string, bool), bool> predicate = func == null ? (cDisplayClass140.\u003C\u003E9__2 = new Func<(string, bool), bool>(cDisplayClass140.\u003CRefreshFlags\u003Eb__2)) : func;
                            list = flags.Where<(string, bool)>(predicate).ToList<(string, bool)>();
                            num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 6 : 0;
                            continue;
                        }
                      }
label_49:
                      num11 = 3;
                      goto label_45;
label_51:
                      current = enumerator.Current;
                      num11 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
                      {
                        num11 = 0;
                        goto label_45;
                      }
                      else
                        goto label_45;
                    }
                    finally
                    {
                      if (enumerator != null)
                      {
                        int num12 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
                          num12 = 0;
                        while (true)
                        {
                          switch (num12)
                          {
                            case 1:
                              goto label_64;
                            default:
                              enumerator.Dispose();
                              num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 1;
                              continue;
                          }
                        }
                      }
label_64:;
                    }
                  case 15:
                    // ISSUE: reference to a compiler-generated field
                    cDisplayClass140.message = FeatureFlagService.seceCNGWh0j4XN3yckTE((object) this.logger) ? new StringBuilder((string) FeatureFlagService.sNu74NGWGwEi0m6amDUJ(1581325282 << 3 ^ -234133082)) : (StringBuilder) null;
                    num6 = 25;
                    break;
                  case 16:
                    // ISSUE: reference to a compiler-generated field
                    if (!(this.wasActorInitHandler & cDisplayClass140.needActorReinit))
                    {
                      num5 = 10;
                      continue;
                    }
                    goto case 28;
                  case 17:
                    lockTaken2 = false;
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 1;
                    continue;
                  case 18:
                    // ISSUE: reference to a compiler-generated field
                    FeatureFlagService.lg6cPHGWutqdM0phRFlc((object) this.logger, (object) cDisplayClass140.message);
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 6 : 26;
                    continue;
                  case 19:
                    if (!flag)
                    {
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 2 : 6;
                      continue;
                    }
                    goto case 18;
                  case 20:
                    // ISSUE: reference to a compiler-generated field
                    if (!cDisplayClass141.needLog)
                    {
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 14 : 21;
                      continue;
                    }
                    goto case 22;
                  case 22:
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    FeatureFlagService.fVImIIGWC3q1kfVbMqpw(FeatureFlagService.KqOPj2GWfP2pZX7B0MVU((object) cDisplayClass141.CS\u0024\u003C\u003E8__locals1.message), FeatureFlagService.sNu74NGWGwEi0m6amDUJ(-882126494 ^ -882350154));
                    num5 = 5;
                    continue;
                  case 23:
label_40:
                    // ISSUE: reference to a compiler-generated method
                    this.serverPlacementPublishService.Publish<IFeatureFlagActor>(new Func<IFeatureFlagActor, Task>(cDisplayClass140.\u003CRefreshFlags\u003Eb__0), true, (Action<Guid, Exception>) null);
                    num5 = 16;
                    continue;
                  case 24:
label_35:
                    // ISSUE: reference to a compiler-generated field
                    if (FeatureFlagService.MglI6NGWvQq5LxEmU9uJ((object) this.processKeys) > FeatureFlagService.IR8T9RGW87rssCe2xAsY((object) cDisplayClass140.newFeatureFlags))
                    {
                      num5 = 3;
                      continue;
                    }
                    goto case 19;
                  case 25:
                    flag = false;
                    num5 = 13;
                    continue;
                  case 27:
                    // ISSUE: object of a compiler-generated type is created
                    cDisplayClass140 = new FeatureFlagService.\u003C\u003Ec__DisplayClass14_0();
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 11 : 11;
                    continue;
                  case 28:
                    FeatureFlagService.GBUogCGWVmpfPnkWHBRF((object) ((ComponentManager) FeatureFlagService.V3GTlRGWI2bJU8ykpGgc()).GetExtensionPoints<IActorInitHandler>().Select<IActorInitHandler, Task>((Func<IActorInitHandler, Task>) (h =>
                    {
                      int num13 = 4;
                      // ISSUE: variable of a compiler-generated type
                      FeatureFlagService.\u003C\u003CRefreshFlags\u003Eb__14_1\u003Ed stateMachine;
                      AsyncTaskMethodBuilder tBuilder;
                      while (true)
                      {
                        switch (num13)
                        {
                          case 1:
                            tBuilder.Start<FeatureFlagService.\u003C\u003CRefreshFlags\u003Eb__14_1\u003Ed>(ref stateMachine);
                            num13 = 6;
                            continue;
                          case 2:
                            // ISSUE: reference to a compiler-generated field
                            stateMachine.\u003C\u003E1__state = -1;
                            num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
                            continue;
                          case 3:
                            // ISSUE: reference to a compiler-generated field
                            stateMachine.h = h;
                            num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 5 : 0;
                            continue;
                          case 4:
                            // ISSUE: reference to a compiler-generated field
                            stateMachine.\u003C\u003E4__this = this;
                            num13 = 3;
                            continue;
                          case 5:
                            // ISSUE: reference to a compiler-generated field
                            stateMachine.\u003C\u003Et__builder = FeatureFlagService.JxEmHfGWRQPYkye7o18Y();
                            num13 = 2;
                            continue;
                          case 6:
                            goto label_5;
                          default:
                            // ISSUE: reference to a compiler-generated field
                            tBuilder = stateMachine.\u003C\u003Et__builder;
                            num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 1 : 1;
                            continue;
                        }
                      }
label_5:
                      // ISSUE: reference to a compiler-generated field
                      return stateMachine.\u003C\u003Et__builder.Task;
                    })).ToArray<Task>());
                    num5 = 7;
                    continue;
                  case 29:
                    featureFlags = this.featureFlags;
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 17 : 0;
                    continue;
                  case 30:
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    cDisplayClass141.needLog = cDisplayClass141.CS\u0024\u003C\u003E8__locals1.message != null && FeatureFlagService.gKpTN3GWZoyi01fj0WxG((object) this.logger);
                    num5 = 20;
                    continue;
                  default:
label_34:
                    // ISSUE: reference to a compiler-generated field
                    cDisplayClass140.newFeatureFlags = new Dictionary<string, bool?>();
                    num5 = 15;
                    continue;
                }
                num5 = num6;
              }
label_108:
              break;
label_104:
              break;
            }
            finally
            {
              int num14;
              if (!lockTaken1)
                num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 1;
              else
                goto label_114;
label_112:
              switch (num14)
              {
                case 2:
                  break;
                default:
              }
label_114:
              Monitor.Exit(processLockObject);
              num14 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
              {
                num14 = 0;
                goto label_112;
              }
              else
                goto label_112;
            }
label_11:
            featureFlags = this.featureFlags;
            num1 = 13;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
            {
              num1 = 10;
              goto label_3;
            }
            else
              goto label_3;
          }
          catch (Exception ex)
          {
            int num = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
              num = 1;
            while (true)
            {
              switch (num)
              {
                case 0:
                  goto label_96;
                case 1:
                  FeatureFlagService.hcxKHIGWSbnrf1IAllNE((object) this.logger, (object) ex);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
                  continue;
                default:
                  goto label_91;
              }
            }
label_96:
            break;
label_91:
            break;
          }
      }
    }

    internal static bool Sj8Fn1GWFiDdsJRgTFv7() => FeatureFlagService.FrnwkFGBzqesL6HRfPIe == null;

    internal static FeatureFlagService q2i9FCGWBaD58Wodt3bX() => FeatureFlagService.FrnwkFGBzqesL6HRfPIe;

    internal static void ej24GyGWWhtoweBvJ1Vn([In] object obj0) => Monitor.Exit(obj0);

    internal static int TAbogBGWodWY9QKrPXgw([In] object obj0) => ((ICollection<KeyValuePair<string, bool?>>) obj0).Count;

    internal static void hpZcqmGWbtcONBn6pBVa([In] object obj0) => ((ICollection<string>) obj0).Clear();

    internal static bool seceCNGWh0j4XN3yckTE([In] object obj0) => ((ILogger) obj0).IsInfoEnabled();

    internal static object sNu74NGWGwEi0m6amDUJ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static int IG9f9iGWEJtnQCTaEOFc([In] object obj0) => ((List<(string, bool)>) obj0).Count;

    internal static object KqOPj2GWfP2pZX7B0MVU([In] object obj0) => (object) ((StringBuilder) obj0).AppendLine();

    internal static object OqOoxnGWQm9lmOYLNBxb([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static object fVImIIGWC3q1kfVbMqpw([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).Append((string) obj1);

    internal static int MglI6NGWvQq5LxEmU9uJ([In] object obj0) => ((ICollection<string>) obj0).Count;

    internal static int IR8T9RGW87rssCe2xAsY([In] object obj0) => ((Dictionary<string, bool?>) obj0).Count;

    internal static bool gKpTN3GWZoyi01fj0WxG([In] object obj0) => ((ILogger) obj0).IsDebugEnabled();

    internal static void lg6cPHGWutqdM0phRFlc([In] object obj0, [In] object obj1) => ((ILogger) obj0).Info(obj1);

    internal static object V3GTlRGWI2bJU8ykpGgc() => (object) ComponentManager.Current;

    internal static void GBUogCGWVmpfPnkWHBRF([In] object obj0) => Task.WaitAll((Task[]) obj0);

    internal static void hcxKHIGWSbnrf1IAllNE([In] object obj0, [In] object obj1) => ((ILogger) obj0).Error(obj1);

    internal static void MPyJ1yGWiE9UPqOiWbpK([In] object obj0, [In] object obj1) => ((IFeatureFlagProvider) obj0).FlagsChanged += (EventHandler) obj1;

    internal static AsyncTaskMethodBuilder JxEmHfGWRQPYkye7o18Y() => AsyncTaskMethodBuilder.Create();

    [Component]
    private sealed class ActorInitHandler : IActorInitHandler
    {
      private readonly object featureFlagService;
      private static object xdXwPsv9Np6t2IJqsR4I;

      public ActorInitHandler(FeatureFlagService featureFlagService)
      {
        FeatureFlagService.ActorInitHandler.Vaeb3Lv9avqrYxrhis17();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
          num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              this.featureFlagService = (object) featureFlagService;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_3:
        return;
label_5:;
      }

      public Task Init(IActorModelRuntime actorModelRuntime)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              ((FeatureFlagService) this.featureFlagService).wasActorInitHandler = true;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        return (Task) FeatureFlagService.ActorInitHandler.pUEYNdv9DDdy5teKpPtU();
      }

      internal static void Vaeb3Lv9avqrYxrhis17() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool S9rKrYv93SXuCuoYTNEq() => FeatureFlagService.ActorInitHandler.xdXwPsv9Np6t2IJqsR4I == null;

      internal static FeatureFlagService.ActorInitHandler Uvar5Hv9pNQILesFOZEE() => (FeatureFlagService.ActorInitHandler) FeatureFlagService.ActorInitHandler.xdXwPsv9Np6t2IJqsR4I;

      internal static object pUEYNdv9DDdy5teKpPtU() => (object) Task.CompletedTask;
    }

    [Component]
    private sealed class ServerStatusEventHandler : IServerStatusEventHandler, IEventHandler
    {
      private readonly object featureFlagService;
      private readonly object actorModelRuntime;
      private readonly object runtimeApplication;
      private static object cuK9uhv9tbe1RdWt4rJ2;

      public ServerStatusEventHandler(
        FeatureFlagService featureFlagService,
        IActorModelRuntime actorModelRuntime,
        IRuntimeApplication runtimeApplication)
      {
        FeatureFlagService.ServerStatusEventHandler.YG5bVNv965y6KheWZpp5();
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
              this.featureFlagService = (object) featureFlagService;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 3 : 0;
              continue;
            case 3:
              this.actorModelRuntime = (object) actorModelRuntime;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 0 : 0;
              continue;
            default:
              this.runtimeApplication = (object) runtimeApplication;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 1 : 0;
              continue;
          }
        }
label_2:;
      }

      public void ServerStarted(Guid serverUid, Version serverVersion)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              ((IActorModelRuntime) this.actorModelRuntime).GetActor<IFeatureFlagActor>(serverUid).UpdateCache(FeatureFlagService.ServerStatusEventHandler.jxPbaWv9HHve3EUQmtgM(this.runtimeApplication), ((FeatureFlagService) this.featureFlagService).featureFlags);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      public void ServerStarting(Guid serverUid)
      {
      }

      public void ServerStoped(Guid serverUid)
      {
      }

      internal static void YG5bVNv965y6KheWZpp5() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool v2W7t6v9wlY5Ix0bTqO4() => FeatureFlagService.ServerStatusEventHandler.cuK9uhv9tbe1RdWt4rJ2 == null;

      internal static FeatureFlagService.ServerStatusEventHandler sbbVe5v94PC0ROUbZqQL() => (FeatureFlagService.ServerStatusEventHandler) FeatureFlagService.ServerStatusEventHandler.cuK9uhv9tbe1RdWt4rJ2;

      internal static Guid jxPbaWv9HHve3EUQmtgM([In] object obj0) => ((IRuntimeApplication) obj0).ConnectionUid;
    }
  }
}
