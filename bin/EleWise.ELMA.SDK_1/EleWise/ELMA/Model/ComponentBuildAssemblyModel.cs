// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.ComponentBuildAssemblyModel
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Model
{
  /// <summary>Модель компиляции компонента</summary>
  public sealed class ComponentBuildAssemblyModel
  {
    /// <summary>Ctor</summary>
    /// <param name="item">Элемент метаданных компонента</param>
    /// <param name="assemblies">Серверные сборки</param>
    /// <param name="clientAssemblies">Клиентские сборки</param>
    public ComponentBuildAssemblyModel(
      ComponentMetadataItem item,
      IEnumerable<byte[]> assemblies,
      IEnumerable<byte[]> clientAssemblies)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(item, assemblies, clientAssemblies, false);
    }

    /// <summary>Ctor</summary>
    /// <param name="item">Элемент метаданных компонента</param>
    /// <param name="assemblies">Серверные сборки</param>
    /// <param name="clientAssemblies">Клиентские сборки</param>
    /// <param name="isSystem">Системный компонент</param>
    internal ComponentBuildAssemblyModel(
      ComponentMetadataItem item,
      IEnumerable<byte[]> assemblies,
      IEnumerable<byte[]> clientAssemblies,
      bool isSystem)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Item = item;
      this.Assemblies = assemblies;
      this.ClientAssemblies = clientAssemblies;
      this.IsSystem = isSystem;
    }

    /// <summary>Элемент метаданных компонента</summary>
    public ComponentMetadataItem Item { get; }

    /// <summary>Серверные сборки</summary>
    public IEnumerable<byte[]> Assemblies { get; }

    /// <summary>Клиентские сборки</summary>
    public IEnumerable<byte[]> ClientAssemblies { get; }

    /// <summary>Системный компонент</summary>
    internal bool IsSystem { get; }
  }
}
