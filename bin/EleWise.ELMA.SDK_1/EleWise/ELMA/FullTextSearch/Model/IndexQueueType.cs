// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Model.IndexQueueType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.FullTextSearch.Model
{
  /// <summary>IndexQueueType</summary>
  /// <remarks>
  /// Типы элементов очереди индексации для полнотекстового поиска
  /// </remarks>
  [MetadataType(typeof (EnumMetadata))]
  [Description(typeof (__Resources_IndexQueueType), "Description")]
  [DisplayName(typeof (__Resources_IndexQueueType), "DisplayName")]
  [Uid("0169be84-5ba8-45d1-a112-2db1a1ffdc56")]
  public enum IndexQueueType
  {
    /// <summary>Полная переиндексация</summary>
    [Uid("1174a2ee-617f-4dad-a511-a84042640d90"), DisplayName(typeof (__Resources_IndexQueueType), "P_IndexAll_DisplayName")] IndexAll,
    /// <summary>Переиндексация по типу</summary>
    [Uid("74c8654a-cd2b-4541-bda2-bbe897698f02"), DisplayName(typeof (__Resources_IndexQueueType), "P_IndexByType_DisplayName")] IndexByType,
    /// <summary>Индексация объекта</summary>
    [DisplayName(typeof (__Resources_IndexQueueType), "P_IndexObject_DisplayName"), Uid("13418dd4-126b-40b6-9894-44558dc4b9e2")] IndexObject,
    /// <summary>Переиндексация объекта</summary>
    [Uid("48401d11-e0a5-47e6-a82a-b87ecce86ddd"), DisplayName(typeof (__Resources_IndexQueueType), "P_ReIndexObject_DisplayName")] ReIndexObject,
    /// <summary>Частичная переиндексация объекта</summary>
    [Uid("fc68bdd3-f3ac-4d78-8c44-3ff07785d242"), DisplayName(typeof (__Resources_IndexQueueType), "P_ReIndexObjectPart_DisplayName")] ReIndexObjectPart,
  }
}
