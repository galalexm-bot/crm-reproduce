// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Cache.ProxiesAssemblyActivator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Autofac.Builder;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Runtime.Db;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.Cache
{
  public class ProxiesAssemblyActivator : IDisposable
  {
    private DbPreUpdater dbPreUpdater;
    private string cacheName;
    private Dictionary<Type, IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>> interceptorsToRegister;
    internal static ProxiesAssemblyActivator DD8kA2WesEYppf5aRtis;

    public ProxiesAssemblyActivator(
      DbPreUpdater dbPreUpdater,
      string cacheName,
      Dictionary<Type, IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>> interceptorsToRegister)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.dbPreUpdater = dbPreUpdater;
      this.cacheName = cacheName;
      this.interceptorsToRegister = interceptorsToRegister;
    }

    public void Dispose()
    {
      int num1 = 4;
      int num2;
      IStartInformation startInformation1;
      while (true)
      {
        int num3;
        switch (num1)
        {
          case 1:
            startInformation1 = (IStartInformation) ProxiesAssemblyActivator.T2sD6UWPoPtWiVMV8Srj(100.0, ProxiesAssemblyActivator.IH0KU1WPWyQHRUgMY3pY(ProxiesAssemblyActivator.D9XWc7WPBP11lQ8Cvy5a(--1867379187 ^ 1867512497)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 5 : 5;
            continue;
          case 2:
            goto label_54;
          case 3:
            num3 = 0;
            break;
          case 4:
            Dictionary<Type, IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>> interceptorsToRegister = this.interceptorsToRegister;
            if (interceptorsToRegister == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 3 : 1;
              continue;
            }
            num3 = ProxiesAssemblyActivator.FVYVoIWPFhjYL0mSNbt9((object) interceptorsToRegister);
            break;
          case 5:
            goto label_4;
          default:
            if (num2 > 0)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 1;
              continue;
            }
            goto label_49;
        }
        num2 = num3;
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
      }
label_54:
      return;
label_49:
      return;
label_4:
      try
      {
        int num4;
        if (this.dbPreUpdater == null)
          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 5 : 1;
        else
          goto label_46;
label_6:
        Dictionary<Type, IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>>.Enumerator enumerator;
        IStartInformation startInformation2;
        int num5;
        while (true)
        {
          switch (num4)
          {
            case 1:
              enumerator = this.interceptorsToRegister.GetEnumerator();
              num4 = 3;
              continue;
            case 2:
              goto label_21;
            case 3:
              try
              {
label_36:
                if (enumerator.MoveNext())
                  goto label_39;
                else
                  goto label_37;
label_32:
                KeyValuePair<Type, IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>> current;
                int num6;
                while (true)
                {
                  switch (num6)
                  {
                    case 1:
                      ++num5;
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 4 : 4;
                      continue;
                    case 2:
                      goto label_39;
                    case 3:
                      current.Value.EnableClassInterceptorsCacheable<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>();
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 1 : 1;
                      continue;
                    case 4:
                      ProxiesAssemblyActivator.exUVmMWPG6I5cFkTCaJZ(ProxiesAssemblyActivator.nKIO8MWPh8isNe6MM7Dh(), (double) num5 * 100.0 / (double) num2);
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
                      continue;
                    case 5:
                      goto label_19;
                    default:
                      goto label_36;
                  }
                }
label_37:
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 3 : 5;
                goto label_32;
label_39:
                current = enumerator.Current;
                num6 = 3;
                goto label_32;
              }
              finally
              {
                enumerator.Dispose();
                int num7 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0)
                  num7 = 0;
                switch (num7)
                {
                  default:
                }
              }
            case 4:
              goto label_46;
            case 5:
            case 7:
label_48:
              num5 = 0;
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 1 : 1;
              continue;
            case 6:
label_19:
              if (this.dbPreUpdater == null)
              {
                num4 = 9;
                continue;
              }
              goto case 8;
            case 8:
              startInformation2 = (IStartInformation) ProxiesAssemblyActivator.T2sD6UWPoPtWiVMV8Srj(97.0, (object) EleWise.ELMA.SR.M(z2jc63fLkugS1X8Q9N.tE1kD1vbB(236071375 ^ 235938421)));
              num4 = 2;
              continue;
            case 9:
              goto label_33;
            case 10:
              goto label_28;
            default:
              try
              {
                InterceptionRegistrationExtensions.LoadCache((IEnumerable<Type>) this.interceptorsToRegister.Keys, ProxiesAssemblyCache.GetProxiesAssemblyCaches(this.cacheName));
                int num8 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
                  num8 = 0;
                switch (num8)
                {
                  default:
                    goto label_48;
                }
              }
              finally
              {
                int num9;
                if (startInformation2 == null)
                  num9 = 2;
                else
                  goto label_16;
label_15:
                switch (num9)
                {
                  case 1:
                  case 2:
                }
label_16:
                ProxiesAssemblyActivator.uf9T1cWPbRqW6Fnmrvrq((object) startInformation2);
                num9 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
                {
                  num9 = 1;
                  goto label_15;
                }
                else
                  goto label_15;
              }
          }
        }
label_33:
        return;
label_28:
        return;
label_21:
        try
        {
          ProxiesAssemblyCache.SaveProxiesAssemblyCaches(InterceptionRegistrationExtensions.SaveCache(), this.cacheName);
          int num10 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
            num10 = 0;
          switch (num10)
          {
            case 0:
              return;
            default:
              return;
          }
        }
        finally
        {
          if (startInformation2 != null)
          {
            int num11 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
              num11 = 0;
            while (true)
            {
              switch (num11)
              {
                case 1:
                  goto label_30;
                default:
                  ProxiesAssemblyActivator.uf9T1cWPbRqW6Fnmrvrq((object) startInformation2);
                  num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 1 : 1;
                  continue;
              }
            }
          }
label_30:;
        }
label_46:
        startInformation2 = (IStartInformation) ProxiesAssemblyActivator.T2sD6UWPoPtWiVMV8Srj(8.0, ProxiesAssemblyActivator.IH0KU1WPWyQHRUgMY3pY(ProxiesAssemblyActivator.D9XWc7WPBP11lQ8Cvy5a(1574260816 ^ 1574394664)));
        num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
        {
          num4 = 0;
          goto label_6;
        }
        else
          goto label_6;
      }
      finally
      {
        if (startInformation1 != null)
        {
          int num12 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
            num12 = 0;
          while (true)
          {
            switch (num12)
            {
              case 1:
                goto label_56;
              default:
                ProxiesAssemblyActivator.uf9T1cWPbRqW6Fnmrvrq((object) startInformation1);
                num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 1 : 1;
                continue;
            }
          }
        }
label_56:;
      }
    }

    internal static int FVYVoIWPFhjYL0mSNbt9([In] object obj0) => __nonvirtual (((Dictionary<Type, IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>>) obj0).Count);

    internal static object D9XWc7WPBP11lQ8Cvy5a(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object IH0KU1WPWyQHRUgMY3pY([In] object obj0) => (object) EleWise.ELMA.SR.M((string) obj0);

    internal static object T2sD6UWPoPtWiVMV8Srj(double completePercent, [In] object obj1) => (object) StartInformation.Operation(completePercent, (string) obj1);

    internal static void uf9T1cWPbRqW6Fnmrvrq([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object nKIO8MWPh8isNe6MM7Dh() => (object) StartInformation.Current;

    internal static void exUVmMWPG6I5cFkTCaJZ([In] object obj0, double value) => ((IStartInformation) obj0).Percent = value;

    internal static bool iIadErWecdEKS4D7VwnW() => ProxiesAssemblyActivator.DD8kA2WesEYppf5aRtis == null;

    internal static ProxiesAssemblyActivator GoErVFWezZ7KYCwJxdDU() => ProxiesAssemblyActivator.DD8kA2WesEYppf5aRtis;
  }
}
