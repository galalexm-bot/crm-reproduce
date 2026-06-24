// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.OmniSharp.Models.ScriptData
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.OmniSharp.Models
{
  /// <inheritdoc />
  public class ScriptData : IScriptData
  {
    /// <summary>Ctor</summary>
    /// <param name="sources">Список исходников</param>
    /// <param name="assemblies">Список дополнительно подключаемых сборок</param>
    public ScriptData(IEnumerable<IScriptSource> sources, IEnumerable<IScriptReference> assemblies = null)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Sources = sources ?? Enumerable.Empty<IScriptSource>();
      this.Assemblies = assemblies ?? Enumerable.Empty<IScriptReference>();
    }

    /// <inheritdoc />
    public IEnumerable<IScriptSource> Sources { get; }

    /// <inheritdoc />
    public IEnumerable<IScriptReference> Assemblies { get; }
  }
}
