// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.IMetadataItemSaveEventHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Events;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Обработчик события сохранения элемента метаданных</summary>
  public interface IMetadataItemSaveEventHandler : IEventHandler
  {
    /// <summary>Действие перед сохранением элемента метаданных</summary>
    /// <param name="metadataItem">Элемент метаданных</param>
    void BeforeSave(IMetadataItem metadataItem);
  }
}
