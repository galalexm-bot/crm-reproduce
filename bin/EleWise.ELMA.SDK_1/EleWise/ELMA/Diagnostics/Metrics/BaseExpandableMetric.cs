// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Metrics.BaseExpandableMetric
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.Diagnostics.Metrics
{
  /// <summary>Базовый класс метрики, поддерживающий расширение</summary>
  public abstract class BaseExpandableMetric : IExpandableMetric, IMetric
  {
    private List<IMetric> additionalParameters;
    private readonly ReaderWriterLockSlim rwLock;
    private static BaseExpandableMetric Eii6X9E8RW85aFymXqI4;

    /// <inheritdoc />
    public abstract Guid Uid { get; }

    /// <inheritdoc />
    public IEnumerable<IMetric> AdditionalParameters
    {
      get
      {
        this.rwLock.EnterReadLock();
        try
        {
          return (IEnumerable<IMetric>) this.additionalParameters;
        }
        finally
        {
          this.rwLock.ExitReadLock();
        }
      }
    }

    /// <inheritdoc />
    public void AddAdditionalParameters(IMetric metric)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.additionalParameters.Add(metric);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            // ISSUE: reference to a compiler-generated method
            this.additionalParameters = this.additionalParameters.OrderBy<IMetric, Guid>((Func<IMetric, Guid>) (s => BaseExpandableMetric.\u003C\u003Ec.AvpSZq8KhX4xpMZKVObA((object) s))).ToList<IMetric>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    /// <inheritdoc />
    public virtual void Merge(IMetric metric)
    {
      int num1 = 7;
      IExpandableMetric expandableMetric;
      List<IMetric> metricList;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_72;
          case 1:
            if (!BaseExpandableMetric.k8K4IJE8XU4ekh0L5t80((object) this.rwLock, 50))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
              continue;
            }
            goto case 5;
          case 2:
            goto label_67;
          case 3:
            goto label_7;
          case 4:
            goto label_3;
          case 5:
            metricList = new List<IMetric>();
            num1 = 3;
            continue;
          case 6:
            if (expandableMetric != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 1 : 1;
              continue;
            }
            goto label_51;
          case 7:
            expandableMetric = metric as IExpandableMetric;
            num1 = 6;
            continue;
          default:
            goto label_63;
        }
      }
label_72:
      return;
label_67:
      return;
label_3:
      return;
label_63:
      return;
label_51:
      return;
label_7:
      try
      {
        List<IMetric>.Enumerator enumerator1 = this.additionalParameters.GetEnumerator();
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
          num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              try
              {
                IEnumerator<IMetric> enumerator2 = expandableMetric.AdditionalParameters.GetEnumerator();
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
                  num3 = 0;
                switch (num3)
                {
                  default:
                    try
                    {
                      bool flag1 = enumerator1.MoveNext();
                      int num4 = 1;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
                        num4 = 1;
                      while (true)
                      {
                        int num5;
                        IMetric current1;
                        IMetric current2;
                        int num6;
                        Guid guid;
                        bool flag2;
                        switch (num4)
                        {
                          case 1:
                            flag2 = BaseExpandableMetric.bDqJlZE8T9sQ4XxMo7Rt((object) enumerator2);
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 18 : 0;
                            continue;
                          case 2:
                            flag1 = enumerator1.MoveNext();
                            num4 = 16;
                            continue;
                          case 3:
                            if (flag1)
                            {
                              num5 = 9;
                              break;
                            }
                            goto case 5;
                          case 4:
                            flag2 = enumerator2.MoveNext();
                            num4 = 25;
                            continue;
                          case 5:
                            metricList.Add(enumerator2.Current);
                            num4 = 4;
                            continue;
                          case 6:
                            metricList.Add(current1);
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 11 : 11;
                            continue;
                          case 7:
                          case 24:
                            if (num6 == 0)
                            {
                              num4 = 30;
                              continue;
                            }
                            goto case 6;
                          case 8:
                          case 12:
                          case 18:
                          case 19:
                          case 23:
                          case 25:
                            if (!(flag1 | flag2))
                            {
                              num4 = 21;
                              continue;
                            }
                            goto case 3;
                          case 9:
                          case 15:
                            if (!flag2)
                            {
                              num5 = 13;
                              break;
                            }
                            goto case 29;
                          case 10:
                            guid = BaseExpandableMetric.blAc6cE8kId2btyjQQ68((object) current2);
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 2 : 27;
                            continue;
                          case 11:
                            flag2 = BaseExpandableMetric.bDqJlZE8T9sQ4XxMo7Rt((object) enumerator2);
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 12 : 5;
                            continue;
                          case 13:
                          case 28:
                            metricList.Add(enumerator1.Current);
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 11 : 26;
                            continue;
                          case 14:
                            current1 = enumerator2.Current;
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 3 : 10;
                            continue;
                          case 16:
                            flag2 = enumerator2.MoveNext();
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 8 : 8;
                            continue;
                          case 17:
                            metricList.Add(current2);
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 0;
                            continue;
                          case 20:
                            metricList.Add(current2);
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 2 : 0;
                            continue;
                          case 21:
                            goto label_10;
                          case 22:
                            if (num6 >= 0)
                            {
                              num4 = 24;
                              continue;
                            }
                            goto case 17;
                          case 26:
                            flag1 = enumerator1.MoveNext();
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 23 : 23;
                            continue;
                          case 27:
                            num6 = guid.CompareTo(BaseExpandableMetric.blAc6cE8kId2btyjQQ68((object) current1));
                            num4 = 22;
                            continue;
                          case 29:
                            current2 = enumerator1.Current;
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 14 : 10;
                            continue;
                          case 30:
                            BaseExpandableMetric.clF0E7E8n4QoDehQt0yD((object) current2, (object) current1);
                            num4 = 20;
                            continue;
                          default:
                            flag1 = enumerator1.MoveNext();
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 19;
                            continue;
                        }
                        num4 = num5;
                      }
                    }
                    finally
                    {
                      int num7;
                      if (enumerator2 == null)
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 0 : 0;
                      else
                        goto label_49;
label_48:
                      switch (num7)
                      {
                        case 2:
                          break;
                        default:
                      }
label_49:
                      BaseExpandableMetric.D0OSiXE8OPuhjAfrlPSD((object) enumerator2);
                      num7 = 1;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
                      {
                        num7 = 1;
                        goto label_48;
                      }
                      else
                        goto label_48;
                    }
                }
              }
              finally
              {
                enumerator1.Dispose();
                int num8 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
                  num8 = 0;
                switch (num8)
                {
                  default:
                }
              }
            case 2:
              goto label_58;
          }
label_10:
          BaseExpandableMetric.HoYKpnE828n0KVVQ5Xgi((object) this.rwLock);
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 2 : 2;
        }
label_58:
        try
        {
          BaseExpandableMetric.U8R6LhE8eYh9ajRNiRDH((object) this.additionalParameters);
          int num9 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
            num9 = 1;
          while (true)
          {
            switch (num9)
            {
              case 0:
                goto label_61;
              case 1:
                this.additionalParameters = metricList;
                num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
                continue;
              default:
                goto label_56;
            }
          }
label_61:
          return;
label_56:;
        }
        finally
        {
          BaseExpandableMetric.Tj3jpGE8Puv8DAYxWQn0((object) this.rwLock);
          int num10 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
            num10 = 0;
          switch (num10)
          {
            default:
          }
        }
      }
      finally
      {
        this.rwLock.ExitUpgradeableReadLock();
        int num11 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
          num11 = 0;
        switch (num11)
        {
          default:
        }
      }
    }

    protected BaseExpandableMetric()
    {
      BaseExpandableMetric.aMV3CxE81IKLP3Fx4etQ();
      this.additionalParameters = new List<IMetric>();
      this.rwLock = new ReaderWriterLockSlim();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool zOjxwNE8qeNNedPhKMGi() => BaseExpandableMetric.Eii6X9E8RW85aFymXqI4 == null;

    internal static BaseExpandableMetric QRHagOE8KYct3qSjYOy3() => BaseExpandableMetric.Eii6X9E8RW85aFymXqI4;

    internal static bool k8K4IJE8XU4ekh0L5t80([In] object obj0, [In] int obj1) => ((ReaderWriterLockSlim) obj0).TryEnterUpgradeableReadLock(obj1);

    internal static bool bDqJlZE8T9sQ4XxMo7Rt([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static Guid blAc6cE8kId2btyjQQ68([In] object obj0) => ((IMetric) obj0).Uid;

    internal static void clF0E7E8n4QoDehQt0yD([In] object obj0, [In] object obj1) => ((IMetric) obj0).Merge((IMetric) obj1);

    internal static void D0OSiXE8OPuhjAfrlPSD([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void HoYKpnE828n0KVVQ5Xgi([In] object obj0) => ((ReaderWriterLockSlim) obj0).EnterWriteLock();

    internal static void U8R6LhE8eYh9ajRNiRDH([In] object obj0) => ((List<IMetric>) obj0).Clear();

    internal static void Tj3jpGE8Puv8DAYxWQn0([In] object obj0) => ((ReaderWriterLockSlim) obj0).ExitWriteLock();

    internal static void aMV3CxE81IKLP3Fx4etQ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
