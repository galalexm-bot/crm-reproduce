// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.ImplicitUseTargetFlags
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.ComponentModel
{
  /// <summary>
  /// Specify what is considered used implicitly when marked
  /// with <see cref="T:EleWise.ELMA.ComponentModel.MeansImplicitUseAttribute" /> or <see cref="T:EleWise.ELMA.ComponentModel.UsedImplicitlyAttribute" />.
  /// </summary>
  [Flags]
  public enum ImplicitUseTargetFlags
  {
    Default = 1,
    Itself = Default, // 0x00000001
    /// <summary>Members of entity marked with attribute are considered used.</summary>
    Members = 2,
    /// <summary>Entity marked with attribute and all its members considered used.</summary>
    WithMembers = Members | Itself, // 0x00000003
  }
}
