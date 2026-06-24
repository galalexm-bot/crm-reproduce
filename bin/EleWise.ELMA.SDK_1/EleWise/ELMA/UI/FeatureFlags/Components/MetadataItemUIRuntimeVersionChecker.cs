// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.FeatureFlags.Components.MetadataItemUIRuntimeVersionChecker
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
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.FeatureFlags.Components
{
  /// <summary>Поиск версии рантайма в метаданных объектов</summary>
  [Component]
  internal sealed class MetadataItemUIRuntimeVersionChecker : IUIRuntimeVersionChecker
  {
    private readonly ISessionProvider sessionProvider;
    private RuntimeVersion? result;
    private ISession session;
    private static MetadataItemUIRuntimeVersionChecker q24lPXBZDXgLZwsU0XbD;

    /// <summary>Ctor</summary>
    /// <param name="sessionProvider">Провайдер сессий NHibernate</param>
    public MetadataItemUIRuntimeVersionChecker(ISessionProvider sessionProvider)
    {
      MetadataItemUIRuntimeVersionChecker.YvVWpHBZ4ctgBvYREEPi();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.sessionProvider = sessionProvider;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public RuntimeVersion CheckRuntimeVersion()
    {
      int num1 = 5;
      RuntimeVersion? nullable;
      long num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_4;
          case 2:
            nullable = nullable;
            num1 = 3;
            continue;
          case 3:
            goto label_3;
          case 4:
            num2 = MetadataItemUIRuntimeVersionChecker.xJ9bAiBZmNprfCpdi4dT(MetadataItemUIRuntimeVersionChecker.sQqTXdBZ0dTH6cpVGsWl(MetadataItemUIRuntimeVersionChecker.dWPrl8BZxk3Ef4B7BtEg(MetadataItemUIRuntimeVersionChecker.aiIJ4EBZHayxlQ4RyeOC((object) this.Session.CreateCriteria<IMetadataItem>(), MetadataItemUIRuntimeVersionChecker.tAIRVEBZ6Ax4FsbbXnSL((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(132912447 ^ 132964585))), (object) new IProjection[1]
            {
              (IProjection) MetadataItemUIRuntimeVersionChecker.J5uk6OBZ7felwxU9AN5a(MetadataItemUIRuntimeVersionChecker.X9IrRJBZAxyInxBgAbwM())
            })));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
            continue;
          case 5:
            if (!this.result.HasValue)
            {
              num1 = 4;
              continue;
            }
            goto label_4;
          default:
            int num3 = num2 > 0L ? 1 : 0;
            this.result = nullable = new RuntimeVersion?((RuntimeVersion) num3);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 1 : 2;
            continue;
        }
      }
label_3:
      return nullable.Value;
label_4:
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
              this.session = session1 = (ISession) MetadataItemUIRuntimeVersionChecker.FujQVABZyS4VbfGUXdmo((object) this.sessionProvider, (object) "");
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
              continue;
            case 2:
              session2 = this.session;
              if (session2 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 1 : 0;
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

    internal static void YvVWpHBZ4ctgBvYREEPi() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool FmuAcQBZtAPVxi6GTs4s() => MetadataItemUIRuntimeVersionChecker.q24lPXBZDXgLZwsU0XbD == null;

    internal static MetadataItemUIRuntimeVersionChecker bNelFQBZwdCjk9kbmeS2() => MetadataItemUIRuntimeVersionChecker.q24lPXBZDXgLZwsU0XbD;

    internal static object tAIRVEBZ6Ax4FsbbXnSL([In] object obj0) => (object) Restrictions.IsNotNull((string) obj0);

    internal static object aiIJ4EBZHayxlQ4RyeOC([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).Add((ICriterion) obj1);

    internal static object X9IrRJBZAxyInxBgAbwM() => (object) Projections.Id();

    internal static object J5uk6OBZ7felwxU9AN5a([In] object obj0) => (object) Projections.Count((IProjection) obj0);

    internal static object dWPrl8BZxk3Ef4B7BtEg([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).SetProjection((IProjection[]) obj1);

    internal static object sQqTXdBZ0dTH6cpVGsWl([In] object obj0) => ((ICriteria) obj0).UniqueResult();

    internal static long xJ9bAiBZmNprfCpdi4dT([In] object obj0) => Convert.ToInt64(obj0);

    internal static object FujQVABZyS4VbfGUXdmo([In] object obj0, [In] object obj1) => (object) ((ISessionProvider) obj0).GetSession((string) obj1);
  }
}
