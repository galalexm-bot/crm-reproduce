// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.FeatureFlags.UIRuntimeVersionFlagProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FeatureFlags.Components;
using EleWise.ELMA.Model;
using EleWise.ELMA.UI.FeatureFlags.Components;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.UI.FeatureFlags
{
  /// <summary>Провайдер флагов для включения/отключения рантайма</summary>
  [Component(Order = 100)]
  internal sealed class UIRuntimeVersionFlagProvider : BaseFeatureFlagProvider
  {
    private readonly IEnumerable<IUIRuntimeVersionChecker> runtimeVersionCheckers;
    private bool? result;

    /// <summary>Ctor</summary>
    /// <param name="runtimeVersionCheckers">Список реализаций точки расширения для поиска версий рантайма в частях системы</param>
    public UIRuntimeVersionFlagProvider(
      IEnumerable<IUIRuntimeVersionChecker> runtimeVersionCheckers)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.runtimeVersionCheckers = runtimeVersionCheckers;
    }

    /// <inheritdoc />
    public override IEnumerable<(string featureFlagName, bool enabled)> GetFlags(
      IEnumerable<string> featureFlagNames)
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerable<(string, bool)>) new UIRuntimeVersionFlagProvider.\u003CGetFlags\u003Ed__3(-2)
      {
        \u003C\u003E4__this = this,
        \u003C\u003E3__featureFlagNames = featureFlagNames
      };
    }

    private bool? Check() => this.runtimeVersionCheckers.FirstOrDefault<IUIRuntimeVersionChecker>((Func<IUIRuntimeVersionChecker, bool>) (a => UIRuntimeVersionFlagProvider.\u003C\u003Ec.u4C94qQEfBPL5GkL5QVy((object) a) == RuntimeVersion.Version2)) == null ? new bool?() : new bool?(true);
  }
}
