// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.IUploadedContentLocationMapperService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.Services
{
  /// <summary>
  /// Сервис сопоставления местоположения закачанного файла.
  /// </summary>
  public interface IUploadedContentLocationMapperService
  {
    /// <summary>
    /// Получить местоположение закачанного контента по шлюзу и идентификатору.
    /// </summary>
    /// <param name="gatewayId">Имя шлюза.</param>
    /// <param name="id">Идентификатор файла.</param>
    /// <returns>Местоположение закачанного контента.</returns>
    Uri GetUploadedContentLocation(string gatewayId, string id);
  }
}
