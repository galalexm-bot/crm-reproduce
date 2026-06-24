// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.Autofac.ExecutionScope
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Autofac;
using Autofac.Core;
using EleWise.ELMA.Services.Scope;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Services.Autofac
{
  /// <summary>Контекст выполнения</summary>
  internal sealed class ExecutionScope : IExecutionScope, IDisposable
  {
    private readonly ILifetimeScope innerScope;
    private readonly ILifetimeScope parentScope;
    [ThreadStatic]
    private static ILifetimeScope currentScope;
    internal static ExecutionScope PybiBFBmmxGROGCHj4y6;

    /// <summary>Ctor</summary>
    /// <param name="globalScope">Глобальный контекст выполнения</param>
    /// <param name="registrations">Список регистраций в новом контексте выполнения</param>
    internal ExecutionScope(
      ILifetimeScope globalScope,
      IEnumerable<IComponentRegistration> registrations)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      Contract.ArgumentNotNull((object) globalScope, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107920650));
      Contract.ArgumentNotNull((object) registrations, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1218962250 ^ 1218871368));
      this.parentScope = ExecutionScope.currentScope ?? globalScope;
      this.innerScope = this.parentScope.BeginLifetimeScope((Action<ContainerBuilder>) (containerBuilder =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              registrations.ForEach<IComponentRegistration>(new Action<IComponentRegistration>(((RegistrationExtensions) containerBuilder).RegisterComponent));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }));
      ExecutionScope.currentScope = this.innerScope;
    }

    /// <inheritdoc />
    public T Resolve<T>() where T : class => this.innerScope.Resolve<T>();

    /// <inheritdoc />
    public object Resolve(Type objectType) => ExecutionScope.bZ34T6BmJsC00F9nDi6O((object) this.innerScope, objectType);

    /// <inheritdoc />
    public void Dispose()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ExecutionScope.currentScope = this.parentScope;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
            continue;
          case 2:
            ExecutionScope.o1qRdfBm939ab52hwjE7((object) this.innerScope);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object bZ34T6BmJsC00F9nDi6O([In] object obj0, [In] Type obj1) => ((IComponentContext) obj0).Resolve(obj1);

    internal static bool KoDi2NBmyAhgXmFFeHUL() => ExecutionScope.PybiBFBmmxGROGCHj4y6 == null;

    internal static ExecutionScope JeImXkBmMeFBxENDAI69() => ExecutionScope.PybiBFBmmxGROGCHj4y6;

    internal static void o1qRdfBm939ab52hwjE7([In] object obj0) => ((IDisposable) obj0).Dispose();
  }
}
