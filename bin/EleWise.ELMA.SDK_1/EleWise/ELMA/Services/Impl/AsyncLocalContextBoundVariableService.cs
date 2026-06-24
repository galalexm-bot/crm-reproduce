// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.Impl.AsyncLocalContextBoundVariableService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;

namespace EleWise.ELMA.Services.Impl
{
  /// <summary>
  /// Хранилище данных в <see cref="T:System.Threading.AsyncLocal`1" />
  /// </summary>
  [Service(EnableInterceptors = false, Type = ComponentType.Design)]
  internal sealed class AsyncLocalContextBoundVariableService : SimpleBoundVariableServiceBase
  {
    private readonly AsyncLocal<IDictionary<string, object>> dictionary;
    private static AsyncLocalContextBoundVariableService j63sY3Bms5R22u1kqErR;

    /// <inheritdoc />
    protected override IDictionary<string, object> Dictionary => this.dictionary.Value ?? (this.dictionary.Value = (IDictionary<string, object>) new ConcurrentDictionary<string, object>());

    public AsyncLocalContextBoundVariableService()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.dictionary = new AsyncLocal<IDictionary<string, object>>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool jSAkw1Bmc1TEOFh2EpWZ() => AsyncLocalContextBoundVariableService.j63sY3Bms5R22u1kqErR == null;

    internal static AsyncLocalContextBoundVariableService avU0MLBmzieio8FaeZg5() => AsyncLocalContextBoundVariableService.j63sY3Bms5R22u1kqErR;
  }
}
