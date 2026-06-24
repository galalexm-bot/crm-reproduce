// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.FeatureFlags.Components.ComponentMetadataItemUIRuntimeVersionChecker
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.FeatureFlags.Components
{
  /// <summary>Поиск версии рантайма в компонентах</summary>
  [Component]
  internal sealed class ComponentMetadataItemUIRuntimeVersionChecker : IUIRuntimeVersionChecker
  {
    private readonly ISessionProvider sessionProvider;
    private RuntimeVersion? result;
    private ISession session;
    private static ComponentMetadataItemUIRuntimeVersionChecker Y6L9NvBZETewM3K4gNxC;

    /// <summary>Ctor</summary>
    /// <param name="sessionProvider">Провайдер сессий NHibernate</param>
    public ComponentMetadataItemUIRuntimeVersionChecker(ISessionProvider sessionProvider)
    {
      ComponentMetadataItemUIRuntimeVersionChecker.vvmYUgBZC1qHyxvjlZIf();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.sessionProvider = sessionProvider;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <inheritdoc />
    public RuntimeVersion CheckRuntimeVersion()
    {
      int num1 = 3;
      RuntimeVersion? nullable;
      long num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            goto label_3;
          case 3:
            if (!this.result.HasValue)
            {
              num2 = ComponentMetadataItemUIRuntimeVersionChecker.hDO7VnBZuvGQhQNhkRaY(((ICriteria) ComponentMetadataItemUIRuntimeVersionChecker.EawC9aBZZmN4TW8mKflV((object) this.Session.CreateCriteria<ComponentMetadataItem>(), (object) new IProjection[1]
              {
                (IProjection) ComponentMetadataItemUIRuntimeVersionChecker.CA0JNVBZ8hi5VTTHLvFn(ComponentMetadataItemUIRuntimeVersionChecker.jPlXFjBZviZ6DoN9yw8n())
              })).UniqueResult());
              num1 = 4;
              continue;
            }
            num1 = 2;
            continue;
          case 4:
            int num3 = num2 <= 0L ? 0 : 1;
            this.result = nullable = new RuntimeVersion?((RuntimeVersion) num3);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
            continue;
          default:
            nullable = nullable;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 1 : 1;
            continue;
        }
      }
label_2:
      return nullable.Value;
label_3:
      return this.result.Value;
    }

    private ISession Session
    {
      get
      {
        int num = 2;
        ISession session1;
        ISession session2;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.session = session1 = this.sessionProvider.GetSession("");
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
              continue;
            case 2:
              session2 = this.session;
              if (session2 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 1 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_6;
          }
        }
label_2:
        return session2;
label_6:
        return session1;
      }
    }

    internal static void vvmYUgBZC1qHyxvjlZIf() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool DJHyvPBZfh6lu1XK2y3P() => ComponentMetadataItemUIRuntimeVersionChecker.Y6L9NvBZETewM3K4gNxC == null;

    internal static ComponentMetadataItemUIRuntimeVersionChecker jnfEJQBZQCp8II0OpJf2() => ComponentMetadataItemUIRuntimeVersionChecker.Y6L9NvBZETewM3K4gNxC;

    internal static object jPlXFjBZviZ6DoN9yw8n() => (object) Projections.Id();

    internal static object CA0JNVBZ8hi5VTTHLvFn([In] object obj0) => (object) Projections.Count((IProjection) obj0);

    internal static object EawC9aBZZmN4TW8mKflV([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).SetProjection((IProjection[]) obj1);

    internal static long hDO7VnBZuvGQhQNhkRaY([In] object obj0) => Convert.ToInt64(obj0);
  }
}
