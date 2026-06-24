// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.Previews.IFilePreviewEventHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Events;
using System;
using System.Threading.Tasks;

namespace EleWise.ELMA.Files.Previews
{
  /// <summary>Событие системы генерации предпросмотра</summary>
  public interface IFilePreviewEventHandler : IEventHandler
  {
    /// <summary>Завершение генерации файла предпросмотра</summary>
    /// <param name="fileId">Идентификатор файла, для которого создается файл предпросмотра</param>
    /// <param name="exception">Ошибка генерации файла предпросмотра</param>
    Task Complete(string fileId, Exception exception = null);
  }
}
