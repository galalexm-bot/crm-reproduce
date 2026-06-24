// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.FeatureFlags.Components.DataClassMetadataItemUIRuntimeVersionChecker
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
  /// <summary>Поиск версии рантайма в СОД</summary>
  [Component]
  internal sealed class DataClassMetadataItemUIRuntimeVersionChecker : IUIRuntimeVersionChecker
  {
    private readonly ISessionProvider sessionProvider;
    private RuntimeVersion? result;
    private ISession session;
    internal static DataClassMetadataItemUIRuntimeVersionChecker lRgEj5BZIkbnvnUjaiFl;

    /// <summary>Ctor</summary>
    /// <param name="sessionProvider">Провайдер сессий NHibernate</param>
    public DataClassMetadataItemUIRuntimeVersionChecker(ISessionProvider sessionProvider)
    {
      DataClassMetadataItemUIRuntimeVersionChecker.kdnj6RBZiytyxUni1aBL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.sessionProvider = sessionProvider;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
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
      int num1 = 2;
      long num2;
      RuntimeVersion? nullable;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num2 = DataClassMetadataItemUIRuntimeVersionChecker.xW6o7rBZKNYGPhBuLWoP(((ICriteria) DataClassMetadataItemUIRuntimeVersionChecker.LbjEegBZqbY6kO2bmuKp((object) this.Session.CreateCriteria<DataClassMetadataItem>(), (object) new IProjection[1]
            {
              (IProjection) DataClassMetadataItemUIRuntimeVersionChecker.Kd8lEoBZRWVlZAEw0BZA((object) Projections.Id())
            })).UniqueResult());
            num1 = 4;
            continue;
          case 2:
            if (!this.result.HasValue)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 1;
              continue;
            }
            goto label_2;
          case 3:
            goto label_2;
          case 4:
            int num3 = num2 > 0L ? 1 : 0;
            this.result = nullable = new RuntimeVersion?((RuntimeVersion) num3);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 5 : 0;
            continue;
          case 5:
            nullable = nullable;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return this.result.Value;
label_4:
      return nullable.Value;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
              continue;
            case 2:
              session2 = this.session;
              if (session2 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 1 : 1;
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

    internal static void kdnj6RBZiytyxUni1aBL() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Xavo7ZBZVfBIfni9hWL3() => DataClassMetadataItemUIRuntimeVersionChecker.lRgEj5BZIkbnvnUjaiFl == null;

    internal static DataClassMetadataItemUIRuntimeVersionChecker jO7LhNBZSiGI36brNKpo() => DataClassMetadataItemUIRuntimeVersionChecker.lRgEj5BZIkbnvnUjaiFl;

    internal static object Kd8lEoBZRWVlZAEw0BZA([In] object obj0) => (object) Projections.Count((IProjection) obj0);

    internal static object LbjEegBZqbY6kO2bmuKp([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).SetProjection((IProjection[]) obj1);

    internal static long xW6o7rBZKNYGPhBuLWoP([In] object obj0) => Convert.ToInt64(obj0);
  }
}
