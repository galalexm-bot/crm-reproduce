// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.PublicApi.IPublicApiNode
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Collections.Generic;

namespace EleWise.ELMA.Model.CodeGeneration.PublicApi
{
  /// <summary>Узел дерева для генерации PublicApi</summary>
  public interface IPublicApiNode
  {
    /// <summary>Путь родительского узла</summary>
    string ParentPath { get; }

    /// <summary>Собственный путь</summary>
    string Path { get; }

    /// <summary>Сгенерировать код</summary>
    /// <param name="tree">Полное дерево для генерации PublicApi</param>
    /// <returns></returns>
    IEnumerable<ISyntaxNode> Generate(
      IDictionary<string, IEnumerable<IPublicApiNode>> tree);
  }
}
