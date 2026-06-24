// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.ImplicitUseKindFlags
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.ComponentModel
{
  [Flags]
  public enum ImplicitUseKindFlags
  {
    Default = 7,
    /// <summary>Only entity marked with attribute considered used.</summary>
    Access = 1,
    /// <summary>Indicates implicit assignment to a member.</summary>
    Assign = 2,
    /// <summary>
    /// Indicates implicit instantiation of a type with fixed constructor signature.
    /// That means any unused constructor parameters won't be reported as such.
    /// </summary>
    InstantiatedWithFixedConstructorSignature = 4,
    /// <summary>Indicates implicit instantiation of a type.</summary>
    InstantiatedNoFixedConstructorSignature = 8,
  }
}
