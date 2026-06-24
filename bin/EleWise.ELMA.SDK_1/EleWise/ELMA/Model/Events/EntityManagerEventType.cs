// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Events.EntityManagerEventType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Events
{
  /// <summary>Тип события менеджера сущностей</summary>
  [ShowInTypeTree(false)]
  [Uid("fe0e8526-76fd-4305-9e5f-53a960048dbe")]
  [DisplayName(typeof (__Resources_EntityManagerEventType), "DisplayName")]
  [ShowInDesigner(false)]
  [MetadataType(typeof (EnumMetadata))]
  public enum EntityManagerEventType
  {
    /// <summary>Начало загрузки</summary>
    [Uid("96cfee9d-7558-43b1-bf09-01c730594609"), DisplayName(typeof (__Resources_EntityManagerEventType), "P_Loading_DisplayName")] Loading,
    /// <summary>Завершение загрузки</summary>
    [Uid("7b5b66c7-f7dd-4200-adab-44a161ee514d"), DisplayName(typeof (__Resources_EntityManagerEventType), "P_Loaded_DisplayName")] Loaded,
  }
}
