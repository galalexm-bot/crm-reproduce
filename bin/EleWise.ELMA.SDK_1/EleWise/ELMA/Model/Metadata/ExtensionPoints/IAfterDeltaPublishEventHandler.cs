// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.ExtensionPoints.IAfterDeltaPublishEventHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Events;

namespace EleWise.ELMA.Model.Metadata.ExtensionPoints
{
  /// <summary>
  /// Обработчик события публикации для обновления базы данных
  /// </summary>
  /// <remarks>На ферме выполняется на одном сервере</remarks>
  public interface IAfterDeltaPublishEventHandler : IEventHandler
  {
    /// <summary>
    /// Вызвать обработку события публикации для обновления базы данных
    /// </summary>
    /// <param name="e">Параметры события публикации</param>
    void Processing(MetadataPublishedEventArgs e);
  }
}
