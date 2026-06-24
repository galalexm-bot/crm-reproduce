// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.IMetadataSaveFinishedEventHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Events;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Обработчик события сохранения метаданных</summary>
  public interface IMetadataSaveFinishedEventHandler : IEventHandler
  {
    /// <summary>Вызвать обработку события сохранения метаданных</summary>
    /// <param name="e">Параметры события публикации</param>
    /// <remarks>
    /// Обратите внимание: в аргументах к событию передаются метаданные интерфейсов, а не реализаций!
    /// </remarks>
    void SaveExecuted(MetadataSavedEventArgs e);
  }
}
