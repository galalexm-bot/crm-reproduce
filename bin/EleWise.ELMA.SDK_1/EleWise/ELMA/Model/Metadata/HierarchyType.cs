// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.HierarchyType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Тип иерархии</summary>
  [MetadataType(typeof (EnumMetadata))]
  [Uid("6bca7871-a483-4db7-bbbe-1ba839df0cbc")]
  [ShowInTypeTree(false)]
  [DisplayName(typeof (__Resources_HierarchyType), "DisplayName")]
  [ShowInDesigner(false)]
  public enum HierarchyType
  {
    /// <summary>Группы и элементы</summary>
    [DisplayName(typeof (__Resources_HierarchyType), "P_GroupAndElements_DisplayName"), Uid("8554aca4-afd0-4568-804c-a648335ffa99")] GroupAndElements,
    /// <summary>Элементы</summary>
    [DisplayName(typeof (__Resources_HierarchyType), "P_Elements_DisplayName"), Uid("0038656c-c769-425a-9940-bcb55023a38b")] Elements,
  }
}
