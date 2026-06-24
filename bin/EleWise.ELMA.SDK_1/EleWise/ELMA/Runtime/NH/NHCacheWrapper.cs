// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.NHCacheWrapper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.NHCacheWrapper;
using EleWise.ELMA.Diagnostics;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Cache;
using NHibernate.Cache.Entry;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace EleWise.ELMA.Runtime.NH
{
  public class NHCacheWrapper : CacheBase
  {
    private static readonly ILogger logger;
    private static readonly ILogger OrgItemLog;
    private int disableCount;
    private readonly CacheBase cache;
    private readonly bool needDiagnostics;
    private static IServerPlacementPublishService serverPlacementPublishService;
    internal static EleWise.ELMA.Runtime.NH.NHCacheWrapper rUGIXnWaONKiSUfMXija;

    private string GetCacheItem(object cachedValue)
    {
      int num = 7;
      CachedItem cachedItem;
      CacheEntry cacheEntry;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_9;
          case 2:
            cacheEntry = EleWise.ELMA.Runtime.NH.NHCacheWrapper.FukoLiWaNdq5Vw2qj7b9((object) cachedItem) as CacheEntry;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 1 : 5;
            continue;
          case 3:
            goto label_12;
          case 4:
            if (cachedValue == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 1;
              continue;
            }
            goto label_10;
          case 5:
            if (cacheEntry == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 3 : 3;
              continue;
            }
            if (cacheEntry.DisassembledState != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
              continue;
            }
            goto label_19;
          case 6:
            if (cachedItem != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 2 : 2;
              continue;
            }
            goto case 4;
          case 7:
            cachedItem = cachedValue as CachedItem;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 6;
            continue;
          default:
            goto label_15;
        }
      }
label_9:
      return (string) EleWise.ELMA.Runtime.NH.NHCacheWrapper.xLCCJNWaPD3orWppXOiO(-1317790512 ^ -1317794762);
label_10:
      return (string) EleWise.ELMA.Runtime.NH.NHCacheWrapper.JxtJjXWa19n1d705ZwyV(EleWise.ELMA.Runtime.NH.NHCacheWrapper.xLCCJNWaPD3orWppXOiO(1669371371 ^ 1669500867), (object) cachedValue.GetType(), cachedValue);
label_12:
      return string.Format((string) EleWise.ELMA.Runtime.NH.NHCacheWrapper.xLCCJNWaPD3orWppXOiO(1669371371 ^ 1669500885), cachedItem.Value == null ? (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-397266137 ^ 397270078) : EleWise.ELMA.Runtime.NH.NHCacheWrapper.JxtJjXWa19n1d705ZwyV(EleWise.ELMA.Runtime.NH.NHCacheWrapper.xLCCJNWaPD3orWppXOiO(589593376 ^ -1977315327 ^ -1459425015), (object) EleWise.ELMA.Runtime.NH.NHCacheWrapper.FukoLiWaNdq5Vw2qj7b9((object) cachedItem).GetType(), cachedItem.Value));
label_15:
      object separator = EleWise.ELMA.Runtime.NH.NHCacheWrapper.xLCCJNWaPD3orWppXOiO(323422137 << 2 ^ 1293680960);
      object[] disassembledState = cacheEntry.DisassembledState;
      // ISSUE: reference to a compiler-generated field
      Func<object, int, string> func = EleWise.ELMA.Runtime.NH.NHCacheWrapper.\u003C\u003Ec.\u003C\u003E9__2_0;
      Func<object, int, string> selector;
      if (func == null)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        EleWise.ELMA.Runtime.NH.NHCacheWrapper.\u003C\u003Ec.\u003C\u003E9__2_0 = selector = (Func<object, int, string>) ((o, i) => (string) EleWise.ELMA.Runtime.NH.NHCacheWrapper.\u003C\u003Ec.m1nceoQJ0PpeIxGhwMTs(EleWise.ELMA.Runtime.NH.NHCacheWrapper.\u003C\u003Ec.vr1LPQQJxkvwDG9ijuik(694673736 ^ -23604109 ^ -672120703), (object) i, o));
      }
      else
        goto label_16;
label_18:
      IEnumerable<string> values = ((IEnumerable<object>) disassembledState).Select<object, string>(selector);
      return string.Join((string) separator, values);
label_16:
      selector = func;
      goto label_18;
label_19:
      return (string) EleWise.ELMA.Runtime.NH.NHCacheWrapper.xLCCJNWaPD3orWppXOiO(-1350312861 << 3 ^ 2082273614);
    }

    public NHCacheWrapper(CacheBase cache)
    {
      EleWise.ELMA.Runtime.NH.NHCacheWrapper.YVwhQaWa3fMmAgwUjwBX();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            if (cache == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 2;
              continue;
            }
            this.cache = cache;
            num = 3;
            continue;
          case 2:
            goto label_7;
          case 3:
            this.needDiagnostics = !(cache is IHandleDiagnostics);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
            continue;
          default:
            goto label_9;
        }
      }
label_3:
      return;
label_9:
      return;
label_7:
      throw new ArgumentNullException((string) EleWise.ELMA.Runtime.NH.NHCacheWrapper.xLCCJNWaPD3orWppXOiO(-342626196 - 1290888215 ^ -1633642815));
    }

    public override void Clear()
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_2;
          case 1:
            DiagnosticsManager.StartCall<CacheWriteInfo>((Func<CacheWriteInfo>) (() =>
            {
              int num2 = 2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_3;
                  case 2:
                    if (this.needDiagnostics)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 1 : 1;
                      continue;
                    }
                    goto label_2;
                  default:
                    goto label_2;
                }
              }
label_2:
              return (CacheWriteInfo) null;
label_3:
              CacheWriteInfo cacheWriteInfo = new CacheWriteInfo();
              EleWise.ELMA.Runtime.NH.NHCacheWrapper.tOKHPuWaJd6L27P48xCG((object) cacheWriteInfo, EleWise.ELMA.Runtime.NH.NHCacheWrapper.TRtOleWaacjeHBr4q500((object) this));
              EleWise.ELMA.Runtime.NH.NHCacheWrapper.pcgXT2Wa9QOpoBuEYmwP((object) cacheWriteInfo, EleWise.ELMA.Runtime.NH.NHCacheWrapper.xLCCJNWaPD3orWppXOiO(1470440286 ^ 1470578004));
              return cacheWriteInfo;
            }), (System.Action) (() =>
            {
              int num3 = 1;
              while (true)
              {
                switch (num3)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    this.cache.Clear();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public override void Destroy()
    {
    }

    public override object Get(object key)
    {
      int num1 = 2;
      CacheReadInfo cacheReadInfo1;
      EleWise.ELMA.Runtime.NH.NHCacheWrapper nhCacheWrapper;
      object key1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            nhCacheWrapper = this;
            num1 = 3;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 1 : 1;
            continue;
          case 3:
            key1 = key;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 3 : 4;
            continue;
          case 4:
            cacheReadInfo1 = DiagnosticsManager.StartCall<CacheReadInfo>((Func<CacheReadInfo>) (() =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    if (!nhCacheWrapper.needDiagnostics)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
                      continue;
                    }
                    goto label_3;
                  default:
                    goto label_2;
                }
              }
label_2:
              return (CacheReadInfo) null;
label_3:
              CacheReadInfo cacheReadInfo2 = new CacheReadInfo();
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              EleWise.ELMA.Runtime.NH.NHCacheWrapper.\u003C\u003Ec__DisplayClass6_0.QKfY9qQJdqXgTu3TFemv((object) cacheReadInfo2, EleWise.ELMA.Runtime.NH.NHCacheWrapper.\u003C\u003Ec__DisplayClass6_0.cde8VkQJ9oi4py53qOyn((object) nhCacheWrapper));
              cacheReadInfo2.Key = nhCacheWrapper.GetCacheKey(key1);
              return cacheReadInfo2;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
            continue;
          case 5:
            goto label_40;
          default:
            goto label_5;
        }
      }
label_5:
      object obj;
      try
      {
        object cachedValue = EleWise.ELMA.Runtime.NH.NHCacheWrapper.lMUEv0WapIAViYEgcSTb((object) this.cache, key1);
        int num3 = 11;
        while (true)
        {
          int num4;
          switch (num3)
          {
            case 1:
            case 12:
            case 21:
              if (cacheReadInfo1 == null)
              {
                num4 = 13;
                break;
              }
              goto case 3;
            case 2:
              goto label_40;
            case 3:
              cacheReadInfo1.Success = cachedValue != null;
              num3 = 15;
              continue;
            case 4:
            case 20:
              EleWise.ELMA.Runtime.NH.NHCacheWrapper.XdWaFaWawAFFu3woS0SH((object) EleWise.ELMA.Runtime.NH.NHCacheWrapper.OrgItemLog, EleWise.ELMA.Runtime.NH.NHCacheWrapper.JxtJjXWa19n1d705ZwyV(EleWise.ELMA.Runtime.NH.NHCacheWrapper.xLCCJNWaPD3orWppXOiO(-1204263869 ^ -1341583247 ^ 137588614), key1, (object) this.GetCacheItem(cachedValue)));
              num3 = 19;
              continue;
            case 5:
            case 22:
              if (!(key1 is CacheKey))
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 17 : 3;
                continue;
              }
              goto case 7;
            case 6:
              EleWise.ELMA.Runtime.NH.NHCacheWrapper.logger.DebugFormat((string) EleWise.ELMA.Runtime.NH.NHCacheWrapper.xLCCJNWaPD3orWppXOiO(1470998129 - 231418599 ^ 1239441760), EleWise.ELMA.Runtime.NH.NHCacheWrapper.TRtOleWaacjeHBr4q500((object) this));
              num4 = 21;
              break;
            case 7:
              if (EleWise.ELMA.Runtime.NH.NHCacheWrapper.MTd7ALWaDRLljt0F5ZAx(EleWise.ELMA.Runtime.NH.NHCacheWrapper.CHauGdWatiuokvvUZHVX((object) (CacheKey) key1), EleWise.ELMA.Runtime.NH.NHCacheWrapper.xLCCJNWaPD3orWppXOiO(-1939377524 ^ -1939510822)))
              {
                num3 = 4;
                continue;
              }
              goto default;
            case 8:
              if (this.disableCount <= 0)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 1 : 1;
                continue;
              }
              goto case 16;
            case 9:
              EleWise.ELMA.Runtime.NH.NHCacheWrapper.logger.DebugFormat((string) EleWise.ELMA.Runtime.NH.NHCacheWrapper.xLCCJNWaPD3orWppXOiO(92412609 - 1050237057 ^ -957687582), (object) this.RegionName);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 1 : 10;
              continue;
            case 10:
              cachedValue = (object) null;
              num3 = 12;
              continue;
            case 11:
              if (this.IsDisabled(cachedValue))
              {
                num3 = 9;
                continue;
              }
              goto case 8;
            case 13:
            case 15:
              if (!EleWise.ELMA.Runtime.NH.NHCacheWrapper.OrgItemLog.IsEnabled(EleWise.ELMA.Logging.LogLevel.Debug))
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
                continue;
              }
              goto case 14;
            case 14:
              if (!(key1 is string))
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 5 : 0;
                continue;
              }
              goto case 18;
            case 16:
              if (cachedValue != null)
              {
                num4 = 6;
                break;
              }
              goto case 1;
            case 18:
              if (EleWise.ELMA.Runtime.NH.NHCacheWrapper.MTd7ALWaDRLljt0F5ZAx((object) (string) key1, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2139092790)))
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 20 : 8;
                continue;
              }
              goto case 5;
            default:
              obj = cachedValue;
              num3 = 2;
              continue;
          }
          num3 = num4;
        }
      }
      finally
      {
        if (cacheReadInfo1 != null)
        {
          int num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
            num5 = 0;
          while (true)
          {
            switch (num5)
            {
              case 1:
                goto label_38;
              default:
                EleWise.ELMA.Runtime.NH.NHCacheWrapper.zdpqyRWa4MDDbEINswAx((object) cacheReadInfo1);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 1 : 1;
                continue;
            }
          }
        }
label_38:;
      }
label_40:
      return obj;
    }

    public override object Lock(object key)
    {
      int num1 = 2;
      CacheLockInfo cacheLockInfo1;
      object key1;
      while (true)
      {
        int num2 = num1;
        EleWise.ELMA.Runtime.NH.NHCacheWrapper nhCacheWrapper;
        while (true)
        {
          switch (num2)
          {
            case 1:
              nhCacheWrapper = this;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
              continue;
            case 2:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 1 : 1;
              continue;
            case 3:
              if (((CacheKey) key1).EntityOrRoleName == (string) EleWise.ELMA.Runtime.NH.NHCacheWrapper.xLCCJNWaPD3orWppXOiO(--1333735954 ^ 1333602628))
              {
                num2 = 4;
                continue;
              }
              goto label_3;
            case 4:
              EleWise.ELMA.Runtime.NH.NHCacheWrapper.XdWaFaWawAFFu3woS0SH((object) EleWise.ELMA.Runtime.NH.NHCacheWrapper.OrgItemLog, EleWise.ELMA.Runtime.NH.NHCacheWrapper.W2c4UfWaHW7548EPHbPN(EleWise.ELMA.Runtime.NH.NHCacheWrapper.xLCCJNWaPD3orWppXOiO(-218496594 ^ -218621344), key1));
              num2 = 14;
              continue;
            case 5:
              goto label_5;
            case 6:
              if (!((string) key1 == (string) EleWise.ELMA.Runtime.NH.NHCacheWrapper.xLCCJNWaPD3orWppXOiO(993438473 ^ 993308731)))
              {
                num2 = 11;
                continue;
              }
              goto case 4;
            case 7:
              if (EleWise.ELMA.Runtime.NH.NHCacheWrapper.yuNeO9Wa6NkbOq6d4lfN((object) EleWise.ELMA.Runtime.NH.NHCacheWrapper.OrgItemLog, EleWise.ELMA.Logging.LogLevel.Debug))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 10 : 0;
                continue;
              }
              goto label_3;
            case 8:
            case 11:
              if (key1 is CacheKey)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 3 : 2;
                continue;
              }
              goto label_3;
            case 9:
            case 13:
              cacheLockInfo1 = DiagnosticsManager.StartCall<CacheLockInfo>((Func<CacheLockInfo>) (() =>
              {
                int num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      if (nhCacheWrapper.needDiagnostics)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
                        continue;
                      }
                      goto label_2;
                    case 2:
                      goto label_2;
                    default:
                      goto label_3;
                  }
                }
label_2:
                return (CacheLockInfo) null;
label_3:
                CacheLockInfo cacheLockInfo2 = new CacheLockInfo();
                // ISSUE: reference to a compiler-generated method
                EleWise.ELMA.Runtime.NH.NHCacheWrapper.\u003C\u003Ec__DisplayClass7_0.eU5LqLQJjJlsBwUXWZ6l((object) cacheLockInfo2, (object) nhCacheWrapper.RegionName);
                cacheLockInfo2.Key = nhCacheWrapper.GetCacheKey(key1);
                return cacheLockInfo2;
              }));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 5;
              continue;
            case 10:
              if (!(key1 is string))
              {
                num2 = 8;
                continue;
              }
              goto case 6;
            case 12:
              goto label_28;
            case 14:
              goto label_3;
            case 15:
              goto label_18;
            default:
              key1 = key;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 2 : 7;
              continue;
          }
        }
label_3:
        if (this.disableCount <= 0)
        {
          num1 = 13;
          continue;
        }
label_18:
        EleWise.ELMA.Runtime.NH.NHCacheWrapper.logger.DebugFormat((string) EleWise.ELMA.Runtime.NH.NHCacheWrapper.xLCCJNWaPD3orWppXOiO(1819636893 << 3 ^ 1672068874), EleWise.ELMA.Runtime.NH.NHCacheWrapper.TRtOleWaacjeHBr4q500((object) this));
        num1 = 9;
      }
label_5:
      object obj;
      try
      {
        obj = EleWise.ELMA.Runtime.NH.NHCacheWrapper.H4NftQWaAk9TegcWOE1l((object) this.cache, key1);
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
          num4 = 0;
        switch (num4)
        {
        }
      }
      finally
      {
        int num5;
        if (cacheLockInfo1 == null)
          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 1 : 1;
        else
          goto label_11;
label_10:
        switch (num5)
        {
          case 2:
            break;
          default:
        }
label_11:
        cacheLockInfo1.Dispose();
        num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
        {
          num5 = 0;
          goto label_10;
        }
        else
          goto label_10;
      }
label_28:
      return obj;
    }

    public override long NextTimestamp() => EleWise.ELMA.Runtime.NH.NHCacheWrapper.Di5936Wa7HKOxRLo0hDV((object) this.cache);

    public override void Put(object key, object value)
    {
      int num1 = 7;
      while (true)
      {
        int num2 = num1;
        EleWise.ELMA.Runtime.NH.NHCacheWrapper nhCacheWrapper;
        object key1;
        object value1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_25;
            case 2:
            case 19:
              if (key1 is CacheKey)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 2 : 5;
                continue;
              }
              goto label_20;
            case 3:
              if (this.disableCount > 0)
              {
                num2 = 8;
                continue;
              }
              goto case 16;
            case 4:
            case 10:
            case 12:
              goto label_20;
            case 5:
              if (!EleWise.ELMA.Runtime.NH.NHCacheWrapper.MTd7ALWaDRLljt0F5ZAx(EleWise.ELMA.Runtime.NH.NHCacheWrapper.CHauGdWatiuokvvUZHVX((object) (CacheKey) key1), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852970670)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 10 : 3;
                continue;
              }
              goto case 14;
            case 6:
              nhCacheWrapper = this;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 7 : 11;
              continue;
            case 7:
              num2 = 6;
              continue;
            case 8:
              EleWise.ELMA.Runtime.NH.NHCacheWrapper.logger.DebugFormat((string) EleWise.ELMA.Runtime.NH.NHCacheWrapper.xLCCJNWaPD3orWppXOiO(-16752921 ^ -16629079), EleWise.ELMA.Runtime.NH.NHCacheWrapper.TRtOleWaacjeHBr4q500((object) this));
              num2 = 16;
              continue;
            case 9:
              if (!(key1 is string))
              {
                num2 = 2;
                continue;
              }
              goto case 18;
            case 11:
              key1 = key;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
              continue;
            case 13:
              goto label_4;
            case 14:
              EleWise.ELMA.Runtime.NH.NHCacheWrapper.OrgItemLog.Debug(EleWise.ELMA.Runtime.NH.NHCacheWrapper.yIG8KLWa0ft6loXOW2LH(EleWise.ELMA.Runtime.NH.NHCacheWrapper.xLCCJNWaPD3orWppXOiO(1917998801 >> 2 ^ 479627558), key1, (object) this.GetCacheItem(value1), EleWise.ELMA.Runtime.NH.NHCacheWrapper.NEQNEfWaxHTn5NigC11C()));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 1 : 4;
              continue;
            case 15:
              this.Remove(key1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 1 : 1;
              continue;
            case 16:
              if (!EleWise.ELMA.Runtime.NH.NHCacheWrapper.yuNeO9Wa6NkbOq6d4lfN((object) EleWise.ELMA.Runtime.NH.NHCacheWrapper.OrgItemLog, EleWise.ELMA.Logging.LogLevel.Debug))
              {
                num2 = 12;
                continue;
              }
              goto case 9;
            case 17:
              if (!this.IsDisabled(value1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 3 : 0;
                continue;
              }
              goto case 20;
            case 18:
              if (!((string) key1 == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281970806)))
              {
                num2 = 19;
                continue;
              }
              goto case 14;
            case 20:
              EleWise.ELMA.Runtime.NH.NHCacheWrapper.logger.DebugFormat((string) EleWise.ELMA.Runtime.NH.NHCacheWrapper.xLCCJNWaPD3orWppXOiO(132912447 ^ 133040437), (object) this.RegionName);
              num2 = 15;
              continue;
            default:
              value1 = value;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 12 : 17;
              continue;
          }
        }
label_20:
        DiagnosticsManager.StartCall<CacheWriteInfo>((Func<CacheWriteInfo>) (() =>
        {
          int num3 = 2;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_5;
              case 2:
                if (nhCacheWrapper.needDiagnostics)
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 1 : 1;
                  continue;
                }
                goto label_4;
              default:
                goto label_4;
            }
          }
label_4:
          return (CacheWriteInfo) null;
label_5:
          CacheWriteInfo cacheWriteInfo = new CacheWriteInfo();
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          EleWise.ELMA.Runtime.NH.NHCacheWrapper.\u003C\u003Ec__DisplayClass9_0.VqiLjvQJcsNhmHTFyNDr((object) cacheWriteInfo, EleWise.ELMA.Runtime.NH.NHCacheWrapper.\u003C\u003Ec__DisplayClass9_0.wlGRQSQJs3Sm8IbSpXDV((object) nhCacheWrapper));
          // ISSUE: reference to a compiler-generated method
          EleWise.ELMA.Runtime.NH.NHCacheWrapper.\u003C\u003Ec__DisplayClass9_0.MRhx8pQJzE9f2KZdilcH((object) cacheWriteInfo, (object) nhCacheWrapper.GetCacheKey(key1));
          return cacheWriteInfo;
        }), (System.Action) (() =>
        {
          int num4 = 1;
          while (true)
          {
            switch (num4)
            {
              case 0:
                goto label_2;
              case 1:
                // ISSUE: reference to a compiler-generated method
                EleWise.ELMA.Runtime.NH.NHCacheWrapper.\u003C\u003Ec__DisplayClass9_0.c5SJ3HQ9FyUZljQxMva4((object) nhCacheWrapper.cache, key1, value1);
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }));
        num1 = 13;
      }
label_25:
      return;
label_4:;
    }

    public override string RegionName => (string) EleWise.ELMA.Runtime.NH.NHCacheWrapper.TRtOleWaacjeHBr4q500((object) this.cache);

    public override void Remove(object key)
    {
      int num1 = 9;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          EleWise.ELMA.Runtime.NH.NHCacheWrapper nhCacheWrapper;
          object key1;
          switch (num2)
          {
            case 1:
              if (!EleWise.ELMA.Runtime.NH.NHCacheWrapper.MTd7ALWaDRLljt0F5ZAx(EleWise.ELMA.Runtime.NH.NHCacheWrapper.CHauGdWatiuokvvUZHVX((object) (CacheKey) key1), EleWise.ELMA.Runtime.NH.NHCacheWrapper.xLCCJNWaPD3orWppXOiO(-488881205 ^ -488744803)))
              {
                num2 = 2;
                continue;
              }
              goto case 6;
            case 3:
              if (!EleWise.ELMA.Runtime.NH.NHCacheWrapper.yuNeO9Wa6NkbOq6d4lfN((object) EleWise.ELMA.Runtime.NH.NHCacheWrapper.OrgItemLog, EleWise.ELMA.Logging.LogLevel.Debug))
                break;
              goto label_7;
            case 4:
              key1 = key;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 3;
              continue;
            case 5:
              if (EleWise.ELMA.Runtime.NH.NHCacheWrapper.MTd7ALWaDRLljt0F5ZAx((object) (string) key1, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461500075)))
              {
                num2 = 12;
                continue;
              }
              goto case 11;
            case 6:
            case 12:
              EleWise.ELMA.Runtime.NH.NHCacheWrapper.OrgItemLog.DebugFormat((string) EleWise.ELMA.Runtime.NH.NHCacheWrapper.W2c4UfWaHW7548EPHbPN(EleWise.ELMA.Runtime.NH.NHCacheWrapper.xLCCJNWaPD3orWppXOiO(372753449 ^ 372627613), key1));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
              continue;
            case 7:
              goto label_11;
            case 8:
              nhCacheWrapper = this;
              num2 = 4;
              continue;
            case 9:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 8 : 5;
              continue;
            case 11:
              if (!(key1 is CacheKey))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 10 : 10;
                continue;
              }
              goto case 1;
            case 13:
              if (key1 is string)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 5;
                continue;
              }
              goto case 11;
          }
          DiagnosticsManager.StartCall<CacheWriteInfo>((Func<CacheWriteInfo>) (() =>
          {
            int num3 = 1;
            while (true)
            {
              switch (num3)
              {
                case 1:
                  if (!nhCacheWrapper.needDiagnostics)
                  {
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 0;
                    continue;
                  }
                  goto label_5;
                default:
                  goto label_4;
              }
            }
label_4:
            return (CacheWriteInfo) null;
label_5:
            CacheWriteInfo cacheWriteInfo = new CacheWriteInfo();
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            EleWise.ELMA.Runtime.NH.NHCacheWrapper.\u003C\u003Ec__DisplayClass12_0.umFJN9Q9hNBWEev8HlPY((object) cacheWriteInfo, EleWise.ELMA.Runtime.NH.NHCacheWrapper.\u003C\u003Ec__DisplayClass12_0.UpxEW5Q9bSV9sld6A6QI((object) nhCacheWrapper));
            // ISSUE: reference to a compiler-generated method
            EleWise.ELMA.Runtime.NH.NHCacheWrapper.\u003C\u003Ec__DisplayClass12_0.RExTu1Q9GkXOnU5gsDWO((object) cacheWriteInfo, (object) nhCacheWrapper.GetCacheKey(key1));
            // ISSUE: reference to a compiler-generated method
            EleWise.ELMA.Runtime.NH.NHCacheWrapper.\u003C\u003Ec__DisplayClass12_0.Vw633UQ9E9lvyFkq11t3((object) cacheWriteInfo, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(322893104 - -1992822529 ^ -1979211607));
            return cacheWriteInfo;
          }), (System.Action) (() =>
          {
            int num4 = 1;
            while (true)
            {
              switch (num4)
              {
                case 0:
                  goto label_2;
                case 1:
                  // ISSUE: reference to a compiler-generated method
                  EleWise.ELMA.Runtime.NH.NHCacheWrapper.\u003C\u003Ec__DisplayClass12_0.WCNSMhQ9fHt6hbO2ckHq((object) nhCacheWrapper.cache, key1);
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 0 : 0;
                  continue;
                default:
                  goto label_4;
              }
            }
label_2:
            return;
label_4:;
          }));
          num2 = 7;
        }
label_7:
        num1 = 13;
      }
label_11:;
    }

    public override int Timeout => EleWise.ELMA.Runtime.NH.NHCacheWrapper.yUR1aOWamwJii09Tq0j4((object) this.cache);

    public override void Unlock(object key, object lockValue)
    {
      int num1 = 8;
      EleWise.ELMA.Runtime.NH.NHCacheWrapper nhCacheWrapper;
      object key1;
      object lockValue1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_14;
          case 2:
            EleWise.ELMA.Runtime.NH.NHCacheWrapper.logger.DebugFormat((string) EleWise.ELMA.Runtime.NH.NHCacheWrapper.xLCCJNWaPD3orWppXOiO(-1598106783 - -968262081 ^ -629716538), EleWise.ELMA.Runtime.NH.NHCacheWrapper.TRtOleWaacjeHBr4q500((object) this));
            num1 = 5;
            continue;
          case 3:
            if (key1 is CacheKey)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 5 : 11;
              continue;
            }
            goto case 15;
          case 4:
          case 5:
            DiagnosticsManager.StartCall<CacheLockInfo>((Func<CacheLockInfo>) (() =>
            {
              int num2 = 2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_3;
                  case 2:
                    if (nhCacheWrapper.needDiagnostics)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 1 : 1;
                      continue;
                    }
                    goto label_2;
                  default:
                    goto label_2;
                }
              }
label_2:
              return (CacheLockInfo) null;
label_3:
              CacheLockInfo cacheLockInfo = new CacheLockInfo();
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              EleWise.ELMA.Runtime.NH.NHCacheWrapper.\u003C\u003Ec__DisplayClass15_0.NLS2cKQ9uuOAYkGywboa((object) cacheLockInfo, EleWise.ELMA.Runtime.NH.NHCacheWrapper.\u003C\u003Ec__DisplayClass15_0.dv8HcqQ9ZTNI8bB3CuNC((object) nhCacheWrapper));
              // ISSUE: reference to a compiler-generated method
              EleWise.ELMA.Runtime.NH.NHCacheWrapper.\u003C\u003Ec__DisplayClass15_0.HbHGlKQ9ISPDRp0Db9eT((object) cacheLockInfo, (object) nhCacheWrapper.GetCacheKey(key1));
              // ISSUE: reference to a compiler-generated method
              EleWise.ELMA.Runtime.NH.NHCacheWrapper.\u003C\u003Ec__DisplayClass15_0.c2TgEhQ9VkK2K404UqvN((object) cacheLockInfo, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(572119659 - -337058038 ^ 909475781));
              return cacheLockInfo;
            }), (System.Action) (() =>
            {
              int num3 = 1;
              while (true)
              {
                switch (num3)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    EleWise.ELMA.Runtime.NH.NHCacheWrapper.\u003C\u003Ec__DisplayClass15_0.rq5FnNQ9S9MjxdesKE9K((object) nhCacheWrapper.cache, key1, lockValue1);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 1 : 1;
            continue;
          case 6:
            if (EleWise.ELMA.Runtime.NH.NHCacheWrapper.yuNeO9Wa6NkbOq6d4lfN((object) EleWise.ELMA.Runtime.NH.NHCacheWrapper.OrgItemLog, EleWise.ELMA.Logging.LogLevel.Debug))
            {
              num1 = 14;
              continue;
            }
            goto case 15;
          case 7:
            nhCacheWrapper = this;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 2 : 12;
            continue;
          case 8:
            num1 = 7;
            continue;
          case 9:
            lockValue1 = lockValue;
            num1 = 6;
            continue;
          case 11:
            if ((string) EleWise.ELMA.Runtime.NH.NHCacheWrapper.CHauGdWatiuokvvUZHVX((object) (CacheKey) key1) == (string) EleWise.ELMA.Runtime.NH.NHCacheWrapper.xLCCJNWaPD3orWppXOiO(1012087039 ^ 1011950505))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
              continue;
            }
            goto case 15;
          case 12:
            key1 = key;
            num1 = 9;
            continue;
          case 13:
            if (EleWise.ELMA.Runtime.NH.NHCacheWrapper.MTd7ALWaDRLljt0F5ZAx((object) (string) key1, EleWise.ELMA.Runtime.NH.NHCacheWrapper.xLCCJNWaPD3orWppXOiO(-1998538950 ^ -1998410744)))
            {
              num1 = 10;
              continue;
            }
            goto case 3;
          case 14:
            if (key1 is string)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 13 : 2;
              continue;
            }
            goto case 3;
          case 15:
            if (this.disableCount <= 0)
            {
              num1 = 4;
              continue;
            }
            goto case 2;
          default:
            EleWise.ELMA.Runtime.NH.NHCacheWrapper.OrgItemLog.Debug((object) string.Format((string) EleWise.ELMA.Runtime.NH.NHCacheWrapper.xLCCJNWaPD3orWppXOiO(~210725948 ^ -210596081), key1));
            num1 = 15;
            continue;
        }
      }
label_14:;
    }

    /// <summary>Выключить кэш для регионов</summary>
    /// <param name="regions">Регионы</param>
    internal static Task DisableCache(IList<string> regions) => regions.Count != 0 ? EleWise.ELMA.Runtime.NH.NHCacheWrapper.serverPlacementPublishService.For<INHCacheWrapperSynchronizer>().Publish((Func<INHCacheWrapperSynchronizer, Task>) (a => a.DisableCache(regions))) : Task.CompletedTask;

    /// <summary>Включить кэш для регионов</summary>
    /// <param name="regions">Регионы</param>
    internal static Task EnableCache(IList<string> regions) => regions.Count != 0 ? EleWise.ELMA.Runtime.NH.NHCacheWrapper.serverPlacementPublishService.For<INHCacheWrapperSynchronizer>().Publish((Func<INHCacheWrapperSynchronizer, Task>) (a => a.EnableCache(regions))) : Task.CompletedTask;

    private string GetCacheKey(object identifier)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (identifier == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return string.Empty;
label_3:
      return identifier.ToString();
    }

    private bool IsDisabled(object value)
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            goto label_3;
          case 3:
            goto label_4;
          case 4:
            if (this.disableCount <= 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 3 : 1;
              continue;
            }
            break;
        }
        if (!(value is ReadWriteCache.ILockable lockable))
          num = 2;
        else
          break;
      }
label_2:
      return !EleWise.ELMA.Runtime.NH.NHCacheWrapper.FhwkBoWayivketCKB2Xb((object) lockable);
label_3:
      return true;
label_4:
      return false;
    }

    /// <summary>Выключить кэш</summary>
    internal void Disable()
    {
      int num1 = 6;
      int num2;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_9;
          case 1:
            goto label_3;
          case 2:
            this.Clear();
            num1 = 4;
            continue;
          case 3:
            EleWise.ELMA.Runtime.NH.NHCacheWrapper.logger.DebugFormat((string) EleWise.ELMA.Runtime.NH.NHCacheWrapper.xLCCJNWaPD3orWppXOiO(-1317790512 ^ -1317666402), EleWise.ELMA.Runtime.NH.NHCacheWrapper.TRtOleWaacjeHBr4q500((object) this), (object) this.disableCount);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 0 : 0;
            continue;
          case 4:
            EleWise.ELMA.Runtime.NH.NHCacheWrapper.logger.InfoFormat((string) EleWise.ELMA.Runtime.NH.NHCacheWrapper.xLCCJNWaPD3orWppXOiO(381945751 ^ 1158627804 ^ 1405705051), EleWise.ELMA.Runtime.NH.NHCacheWrapper.TRtOleWaacjeHBr4q500((object) this));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 1;
            continue;
          case 5:
            if (num2 != 0)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 3 : 3;
              continue;
            }
            goto case 2;
          case 6:
            num2 = this.disableCount++;
            num1 = 5;
            continue;
          default:
            goto label_2;
        }
      }
label_9:
      return;
label_3:
      return;
label_2:;
    }

    /// <summary>Включить кэш</summary>
    internal void Enable()
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        int num3;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
              EleWise.ELMA.Runtime.NH.NHCacheWrapper.logger.DebugFormat((string) EleWise.ELMA.Runtime.NH.NHCacheWrapper.xLCCJNWaPD3orWppXOiO(-951514650 ^ -951380954), EleWise.ELMA.Runtime.NH.NHCacheWrapper.TRtOleWaacjeHBr4q500((object) this), (object) this.disableCount);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 5;
              continue;
            case 3:
              if (num3 != 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 2 : 2;
                continue;
              }
              break;
            case 4:
              goto label_8;
            case 5:
              goto label_7;
          }
          EleWise.ELMA.Runtime.NH.NHCacheWrapper.logger.InfoFormat((string) EleWise.ELMA.Runtime.NH.NHCacheWrapper.xLCCJNWaPD3orWppXOiO(-398663332 ^ -398525244), EleWise.ELMA.Runtime.NH.NHCacheWrapper.TRtOleWaacjeHBr4q500((object) this));
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 1;
        }
label_8:
        num3 = --this.disableCount;
        num1 = 3;
      }
label_3:
      return;
label_7:;
    }

    static NHCacheWrapper()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            EleWise.ELMA.Runtime.NH.NHCacheWrapper.logger = (ILogger) EleWise.ELMA.Runtime.NH.NHCacheWrapper.b7AlHtWaMiOCT6bQXE0u(typeof (EleWise.ELMA.Runtime.NH.NHCacheWrapper));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 1 : 1;
            continue;
          case 3:
            EleWise.ELMA.Runtime.NH.NHCacheWrapper.serverPlacementPublishService = Locator.GetServiceNotNull<IServerPlacementPublishService>();
            num = 4;
            continue;
          case 4:
            goto label_2;
          default:
            EleWise.ELMA.Runtime.NH.NHCacheWrapper.OrgItemLog = Logger.GetLogger((string) EleWise.ELMA.Runtime.NH.NHCacheWrapper.xLCCJNWaPD3orWppXOiO(1218962250 ^ 1218834704));
            num = 3;
            continue;
        }
      }
label_2:;
    }

    internal static object xLCCJNWaPD3orWppXOiO(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object JxtJjXWa19n1d705ZwyV([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object FukoLiWaNdq5Vw2qj7b9([In] object obj0) => ((CachedItem) obj0).Value;

    internal static bool uND9Q1Wa28HnELKjQddK() => EleWise.ELMA.Runtime.NH.NHCacheWrapper.rUGIXnWaONKiSUfMXija == null;

    internal static EleWise.ELMA.Runtime.NH.NHCacheWrapper hDRFl4WaekUT9US6JL99() => EleWise.ELMA.Runtime.NH.NHCacheWrapper.rUGIXnWaONKiSUfMXija;

    internal static void YVwhQaWa3fMmAgwUjwBX() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object lMUEv0WapIAViYEgcSTb([In] object obj0, [In] object obj1) => ((CacheBase) obj0).Get(obj1);

    internal static object TRtOleWaacjeHBr4q500([In] object obj0) => (object) ((CacheBase) obj0).RegionName;

    internal static bool MTd7ALWaDRLljt0F5ZAx([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static object CHauGdWatiuokvvUZHVX([In] object obj0) => (object) ((CacheKey) obj0).EntityOrRoleName;

    internal static void XdWaFaWawAFFu3woS0SH([In] object obj0, [In] object obj1) => ((ILogger) obj0).Debug(obj1);

    internal static void zdpqyRWa4MDDbEINswAx([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool yuNeO9Wa6NkbOq6d4lfN([In] object obj0, EleWise.ELMA.Logging.LogLevel level) => ((ILogger) obj0).IsEnabled(level);

    internal static object W2c4UfWaHW7548EPHbPN([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static object H4NftQWaAk9TegcWOE1l([In] object obj0, [In] object obj1) => ((CacheBase) obj0).Lock(obj1);

    internal static long Di5936Wa7HKOxRLo0hDV([In] object obj0) => ((CacheBase) obj0).NextTimestamp();

    internal static object NEQNEfWaxHTn5NigC11C() => (object) Environment.StackTrace;

    internal static object yIG8KLWa0ft6loXOW2LH(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) string.Format((string) obj0, obj1, obj2, obj3);
    }

    internal static int yUR1aOWamwJii09Tq0j4([In] object obj0) => ((CacheBase) obj0).Timeout;

    internal static bool FhwkBoWayivketCKB2Xb([In] object obj0) => ((ReadWriteCache.ILockable) obj0).IsLock;

    internal static object b7AlHtWaMiOCT6bQXE0u(Type componentType) => (object) Logger.GetLogger(componentType);

    internal static void tOKHPuWaJd6L27P48xCG([In] object obj0, [In] object obj1) => ((CacheQueryInfo) obj0).Region = (string) obj1;

    internal static void pcgXT2Wa9QOpoBuEYmwP([In] object obj0, [In] object obj1) => ((CacheQueryInfo) obj0).Operation = (string) obj1;
  }
}
