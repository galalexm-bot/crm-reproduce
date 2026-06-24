// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.Impl.ScriptLoader
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.Manager;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Services.Impl
{
  /// <inheritdoc cref="T:EleWise.ELMA.Services.IScriptLoader" />
  [Service]
  internal sealed class ScriptLoader : IScriptLoader
  {
    private readonly ScriptModuleManager scriptModuleManager;
    internal static ScriptLoader orxC5dBMFlJmJXaEavyE;

    /// <summary>Ctor</summary>
    /// <param name="scriptModuleManager">Менеджер модулей скриптов</param>
    public ScriptLoader(ScriptModuleManager scriptModuleManager)
    {
      ScriptLoader.NcJ1j2BMoT1bI4B0jy3H();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.scriptModuleManager = scriptModuleManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
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
    public ScriptModule GetScript(Guid? uid) => !uid.HasValue ? (ScriptModule) null : this.scriptModuleManager.Load(uid.Value);

    internal static void NcJ1j2BMoT1bI4B0jy3H() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool HHq2MjBMBPot7e4iX6Lb() => ScriptLoader.orxC5dBMFlJmJXaEavyE == null;

    internal static ScriptLoader eBYvJGBMWr9GgJB9a6VB() => ScriptLoader.orxC5dBMFlJmJXaEavyE;
  }
}
