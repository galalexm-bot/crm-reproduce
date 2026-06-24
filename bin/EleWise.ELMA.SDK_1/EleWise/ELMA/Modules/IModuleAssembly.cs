// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Modules.IModuleAssembly
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Reflection;

namespace EleWise.ELMA.Modules
{
  /// <summary>Сборка, являющаяся составной частью модуля</summary>
  public interface IModuleAssembly : IApplicationUnit
  {
    /// <summary>Сборка</summary>
    Assembly Assembly { get; }
  }
}
