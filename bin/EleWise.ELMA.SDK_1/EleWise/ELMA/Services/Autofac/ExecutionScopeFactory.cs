// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.Autofac.ExecutionScopeFactory
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Autofac;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services.Scope;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Services.Autofac
{
  /// <inheritdoc />
  [Service]
  internal sealed class ExecutionScopeFactory : IExecutionScopeFactory
  {
    private readonly ILifetimeScope globalScope;
    internal static ExecutionScopeFactory PLY8TvBmYtZUb04ISW5W;

    /// <summary>Ctor</summary>
    /// <param name="globalScope">Глобальный контекст выполнения</param>
    public ExecutionScopeFactory(ILifetimeScope globalScope)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.globalScope = globalScope;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public IExecutionScopeBuilder CreateScope() => (IExecutionScopeBuilder) new ExecutionScopeBuilder(this.globalScope);

    internal static bool LiEOI3BmLoopHdiMRGOm() => ExecutionScopeFactory.PLY8TvBmYtZUb04ISW5W == null;

    internal static ExecutionScopeFactory WYEovHBmUEkwpsoSrbgY() => ExecutionScopeFactory.PLY8TvBmYtZUb04ISW5W;
  }
}
