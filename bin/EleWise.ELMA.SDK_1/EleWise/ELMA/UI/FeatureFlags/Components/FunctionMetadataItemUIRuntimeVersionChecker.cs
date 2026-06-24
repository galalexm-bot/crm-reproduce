// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.FeatureFlags.Components.FunctionMetadataItemUIRuntimeVersionChecker
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.NH;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.FeatureFlags.Components
{
  /// <summary>Поиск версии рантайма в функциях</summary>
  [Component]
  internal sealed class FunctionMetadataItemUIRuntimeVersionChecker : IUIRuntimeVersionChecker
  {
    private readonly ISessionProvider sessionProvider;
    private RuntimeVersion? result;
    private ISession session;
    internal static FunctionMetadataItemUIRuntimeVersionChecker qB5boLBZXMMdZlSjSmj4;

    /// <summary>Ctor</summary>
    /// <param name="sessionProvider">Провайдер сессий NHibernate</param>
    public FunctionMetadataItemUIRuntimeVersionChecker(ISessionProvider sessionProvider)
    {
      FunctionMetadataItemUIRuntimeVersionChecker.IVlRtuBZn7r4Sww8KKpA();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.sessionProvider = sessionProvider;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public RuntimeVersion CheckRuntimeVersion()
    {
      int num1 = 2;
      long num2;
      RuntimeVersion? nullable;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            if (!this.result.HasValue)
            {
              num2 = FunctionMetadataItemUIRuntimeVersionChecker.GWmxPtBZ1uEGkftY1O0j(FunctionMetadataItemUIRuntimeVersionChecker.OmUuA0BZPYBSHhuSwKUg(FunctionMetadataItemUIRuntimeVersionChecker.l80IYoBZeWBRL4gt2mvS((object) this.Session.CreateCriteria<FunctionMetadataItem>(), (object) new IProjection[1]
              {
                (IProjection) FunctionMetadataItemUIRuntimeVersionChecker.VSgq2fBZ2Ds1ERvr2eKm(FunctionMetadataItemUIRuntimeVersionChecker.Tghq4UBZOx4mxlusaCF8())
              })));
              num1 = 3;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 1;
            continue;
          case 3:
            int num3 = num2 <= 0L ? 0 : 1;
            this.result = nullable = new RuntimeVersion?((RuntimeVersion) num3);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
            continue;
          case 4:
            goto label_7;
          default:
            nullable = nullable;
            num1 = 4;
            continue;
        }
      }
label_2:
      return this.result.Value;
label_7:
      return nullable.Value;
    }

    private ISession Session
    {
      get
      {
        int num = 1;
        ISession session1;
        ISession session2;
        while (true)
        {
          switch (num)
          {
            case 1:
              session2 = this.session;
              if (session2 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_6;
            default:
              this.session = session1 = (ISession) FunctionMetadataItemUIRuntimeVersionChecker.hBwJDqBZNAcTGoonsCrA((object) this.sessionProvider, (object) "");
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 2 : 2;
              continue;
          }
        }
label_2:
        return session2;
label_6:
        return session1;
      }
    }

    internal static void IVlRtuBZn7r4Sww8KKpA() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool cao9eTBZTKilWlbkgd8V() => FunctionMetadataItemUIRuntimeVersionChecker.qB5boLBZXMMdZlSjSmj4 == null;

    internal static FunctionMetadataItemUIRuntimeVersionChecker Gn1l7pBZkbt69F5CqZWY() => FunctionMetadataItemUIRuntimeVersionChecker.qB5boLBZXMMdZlSjSmj4;

    internal static object Tghq4UBZOx4mxlusaCF8() => (object) Projections.Id();

    internal static object VSgq2fBZ2Ds1ERvr2eKm([In] object obj0) => (object) Projections.Count((IProjection) obj0);

    internal static object l80IYoBZeWBRL4gt2mvS([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).SetProjection((IProjection[]) obj1);

    internal static object OmUuA0BZPYBSHhuSwKUg([In] object obj0) => ((ICriteria) obj0).UniqueResult();

    internal static long GWmxPtBZ1uEGkftY1O0j([In] object obj0) => Convert.ToInt64(obj0);

    internal static object hBwJDqBZNAcTGoonsCrA([In] object obj0, [In] object obj1) => (object) ((ISessionProvider) obj0).GetSession((string) obj1);
  }
}
