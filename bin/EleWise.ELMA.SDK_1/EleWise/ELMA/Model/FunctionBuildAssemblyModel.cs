// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.FunctionBuildAssemblyModel
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Model
{
  /// <summary>Модель компиляции функции</summary>
  public sealed class FunctionBuildAssemblyModel
  {
    /// <summary>Ctor</summary>
    /// <param name="item">Элемент метаданных функции</param>
    /// <param name="assemblies">Серверные сборки</param>
    public FunctionBuildAssemblyModel(FunctionMetadataItem item, IEnumerable<byte[]> assemblies)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Item = item;
      this.Assemblies = assemblies;
    }

    /// <summary>Элемент метаданных функции</summary>
    public FunctionMetadataItem Item { get; }

    /// <summary>Серверные сборки</summary>
    public IEnumerable<byte[]> Assemblies { get; }
  }
}
