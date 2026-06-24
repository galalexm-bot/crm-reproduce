// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.ICodeItemMetadata
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>
  /// Интерфейс метаданных, определяющих элемент с программным кодом
  /// </summary>
  public interface ICodeItemMetadata : IMetadata, IXsiType
  {
    /// <summary>Имя элемента</summary>
    string Name { get; set; }

    /// <summary>Отображаемое имя</summary>
    string DisplayName { get; set; }

    /// <summary>Пространство имен</summary>
    string Namespace { get; set; }

    /// <summary>Отображаемое пространство имен</summary>
    string NamespaceForDisplay { get; set; }

    /// <summary>Полное имя типа</summary>
    string FullTypeName { get; }
  }
}
