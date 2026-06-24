// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.Components.CompatibilityChecker`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Metadata.Components
{
  /// <inheritdoc />
  internal abstract class CompatibilityChecker<T> : ICompatibilityChecker<T>, ICompatibilityChecker
  {
    internal static object mcfclNhWFGeGB9ue8nJw;

    /// <inheritdoc />
    public bool Check(object obj) => obj is T;

    /// <inheritdoc />
    public ICollection<string> CheckCompatibility(object old, object @new) => this.CheckCompatibility((T) old, (T) @new);

    /// <inheritdoc />
    public abstract ICollection<string> CheckCompatibility(T old, T @new);

    protected CompatibilityChecker()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool TivvXvhWBJGC03jDxf2X() => CompatibilityChecker<T>.mcfclNhWFGeGB9ue8nJw == null;

    internal static object i9AOdrhWW2Sv1hDRRuCH() => CompatibilityChecker<T>.mcfclNhWFGeGB9ue8nJw;
  }
}
