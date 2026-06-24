// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Context.NestedScopeComponents`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Autofac;
using Autofac.Features.Metadata;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Runtime.Context
{
  public class NestedScopeComponents<T>
  {
    private readonly string scope;
    private readonly ServiceScope? scopeType;
    private ILifetimeScopeAccessor lifetimeScopeAccessor;
    private IContextBoundVariableService contextBoundVariableService;
    private readonly string key;
    private static object JDn2XPW2lMMZOVVSuuqW;

    public NestedScopeComponents(ServiceScope scopeType)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.scopeType = new ServiceScope?(scopeType);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            this.key = this.GetType().FullName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218625558);
            num = 2;
            continue;
        }
      }
label_3:;
    }

    private ILifetimeScopeAccessor Accessor()
    {
      int num = 1;
      ILifetimeScopeAccessor service;
      ILifetimeScopeAccessor lifetimeScopeAccessor;
      while (true)
      {
        switch (num)
        {
          case 1:
            lifetimeScopeAccessor = this.lifetimeScopeAccessor;
            if (lifetimeScopeAccessor == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_6;
          default:
            this.lifetimeScopeAccessor = service = Locator.GetService<ILifetimeScopeAccessor>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 2 : 1;
            continue;
        }
      }
label_2:
      return lifetimeScopeAccessor;
label_6:
      return service;
    }

    private IContextBoundVariableService ContextObjects()
    {
      int num = 1;
      IContextBoundVariableService serviceNotNull;
      IContextBoundVariableService boundVariableService;
      while (true)
      {
        switch (num)
        {
          case 1:
            boundVariableService = this.contextBoundVariableService;
            if (boundVariableService == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_6;
          default:
            this.contextBoundVariableService = serviceNotNull = Locator.GetServiceNotNull<IContextBoundVariableService>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 2;
            continue;
        }
      }
label_2:
      return boundVariableService;
label_6:
      return serviceNotNull;
    }

    public bool Available
    {
      get
      {
        int num1 = 1;
        ILifetimeScopeAccessor lifetimeScopeAccessor;
        while (true)
        {
          int num2 = num1;
          ServiceScope? scopeType;
          while (true)
          {
            switch (num2)
            {
              case 1:
                lifetimeScopeAccessor = this.Accessor();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
                continue;
              case 2:
                if (this.scope == null)
                {
                  num2 = 5;
                  continue;
                }
                goto label_5;
              case 3:
                goto label_5;
              case 4:
                if (scopeType.Value != lifetimeScopeAccessor.CurrentType)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 1 : 2;
                  continue;
                }
                goto label_7;
              case 5:
                goto label_6;
              case 6:
                scopeType = this.scopeType;
                num2 = 4;
                continue;
              case 7:
                if (scopeType.HasValue)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 6 : 0;
                  continue;
                }
                goto case 2;
              default:
                goto label_9;
            }
          }
label_9:
          scopeType = this.scopeType;
          num1 = 7;
        }
label_5:
        return object.Equals(lifetimeScopeAccessor.Current.Tag, (object) this.scope);
label_6:
        return false;
label_7:
        return true;
      }
    }

    public IEnumerable<T> Value => !this.Available ? (IEnumerable<T>) EleWise.ELMA.Helpers.EmptyArray<T>.Instance : (IEnumerable<T>) this.ContextObjects().GetOrAdd<List<T>>(this.key, (Func<List<T>>) (() => this.Accessor().Current.Resolve<IEnumerable<Meta<T>>>().Select(m =>
    {
      object obj;
      m.Metadata.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1149433385 + 173655049 ^ 1322880824), out obj);
      return new \u003C\u003Ef__AnonymousType21<T, int>(m.Value, obj != null ? (int) obj : 0);
    }).OrderBy(v => v.order).Select(v => v.value).ToList<T>()));

    internal static bool b4OCM7W2rnvqeVljq6pF() => NestedScopeComponents<T>.JDn2XPW2lMMZOVVSuuqW == null;

    internal static object KZ3En5W2gkGyRe3L5jd7() => NestedScopeComponents<T>.JDn2XPW2lMMZOVVSuuqW;
  }
}
