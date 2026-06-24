// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.DataClassBuildAssemblyModel
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Model
{
  /// <summary>Модель компиляции DataClass</summary>
  public sealed class DataClassBuildAssemblyModel
  {
    /// <summary>Ctor</summary>
    /// <param name="items">Элементы метаданных DataClass</param>
    /// <param name="assemblies">Серверные сборки</param>
    /// <param name="clientAssemblies">Клиентские сборки</param>
    public DataClassBuildAssemblyModel(
      DataClassMetadataItem[] items,
      IEnumerable<byte[]> assemblies,
      IEnumerable<byte[]> clientAssemblies)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Items = items;
      this.Assemblies = assemblies;
      this.ClientAssemblies = clientAssemblies;
    }

    /// <summary>Элементы метаданных DataClass</summary>
    public DataClassMetadataItem[] Items { get; }

    /// <summary>Серверные сборки</summary>
    public IEnumerable<byte[]> Assemblies { get; }

    /// <summary>Клиентские сборки</summary>
    public IEnumerable<byte[]> ClientAssemblies { get; }
  }
}
