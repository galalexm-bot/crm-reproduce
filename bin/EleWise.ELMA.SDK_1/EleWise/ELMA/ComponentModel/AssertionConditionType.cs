// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.AssertionConditionType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.ComponentModel
{
  /// <summary>
  /// Specifies assertion type. If the assertion method argument satisfies the condition,
  /// then the execution continues. Otherwise, execution is assumed to be halted.
  /// </summary>
  public enum AssertionConditionType
  {
    /// <summary>Marked parameter should be evaluated to true.</summary>
    IS_TRUE,
    /// <summary>Marked parameter should be evaluated to false.</summary>
    IS_FALSE,
    /// <summary>Marked parameter should be evaluated to null value.</summary>
    IS_NULL,
    /// <summary>Marked parameter should be evaluated to not null value.</summary>
    IS_NOT_NULL,
  }
}
