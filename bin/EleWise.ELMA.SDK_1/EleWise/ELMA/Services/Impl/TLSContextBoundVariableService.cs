// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.Impl.TLSContextBoundVariableService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.Context;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Services.Impl
{
  /// <summary>
  ///  Хранилище данных в <see cref="T:EleWise.ELMA.Runtime.Context.ELMAContext" />
  /// </summary>
  [Service(EnableInterceptors = false, Type = ComponentType.Server | ComponentType.WebServer | ComponentType.Web | ComponentType.DesignServer | ComponentType.Test)]
  public class TLSContextBoundVariableService : SimpleBoundVariableServiceBase
  {
    /// <summary>Ключ для поиска таблицы в TLS</summary>
    [Obsolete("Not used", true)]
    protected const string key = "EleWise.ELMA.Web.Mvc.Services.TLSContextBoundVariableService.table";
    private static TLSContextBoundVariableService wmjChvBMLVgDoaMsWy2J;

    /// <inheritdoc />
    protected override IDictionary<string, object> Dictionary => ELMAContext.Items;

    /// <inheritdoc />
    public override bool Contains(string name)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (TLSContextBoundVariableService.DtG6dbBMcJq8teqguU4K())
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return base.Contains(name);
label_3:
      return false;
    }

    /// <inheritdoc />
    public override bool TryGetValue<T>(string name, out T value)
    {
      if (ELMAContext.Initialized)
        return base.TryGetValue<T>(name, out value);
      value = default (T);
      return false;
    }

    /// <inheritdoc />
    protected override void ClearContext()
    {
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 2:
            base.ClearContext();
            num = 3;
            continue;
          case 3:
            goto label_3;
          case 4:
            if (!TLSContextBoundVariableService.mJ67SuBMzj4skNkAoWwG((object) PublishCacheContext.logger))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 1 : 1;
              continue;
            }
            break;
          case 5:
            if (TLSContextBoundVariableService.DtG6dbBMcJq8teqguU4K())
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 4 : 1;
              continue;
            }
            goto label_2;
        }
        PublishCacheContext.logger.WarnFormat((string) TLSContextBoundVariableService.dXT95WBJFxTEWCNF3uac(-1598106783 - -968262081 ^ -629915754), TLSContextBoundVariableService.Ks3oYpBJBVGf43ZCJ2W8(), (object) new StackTrace(true));
        num = 2;
      }
label_3:
      return;
label_2:;
    }

    /// <inheritdoc />
    public override void Remove(string key)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            goto label_2;
          case 2:
            if (!ELMAContext.Initialized)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 1;
              continue;
            }
            goto case 3;
          case 3:
            base.Remove(key);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
            continue;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_2:
      return;
label_7:;
    }

    public TLSContextBoundVariableService()
    {
      TLSContextBoundVariableService.tvGjqABJWSL1ADQPVu05();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool DtG6dbBMcJq8teqguU4K() => ELMAContext.Initialized;

    internal static bool nvSBgpBMUQ67RdLBAKx5() => TLSContextBoundVariableService.wmjChvBMLVgDoaMsWy2J == null;

    internal static TLSContextBoundVariableService rreRr8BMso02flT7lMNy() => TLSContextBoundVariableService.wmjChvBMLVgDoaMsWy2J;

    internal static bool mJ67SuBMzj4skNkAoWwG([In] object obj0) => ((ILogger) obj0).IsWarnEnabled();

    internal static object dXT95WBJFxTEWCNF3uac(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object Ks3oYpBJBVGf43ZCJ2W8() => (object) Environment.NewLine;

    internal static void tvGjqABJWSL1ADQPVu05() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
