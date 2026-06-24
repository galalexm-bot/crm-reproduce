// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.DTO.Managers.IFormMetadataItemHeaderDTOManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using System;

namespace EleWise.ELMA.UI.DTO.Managers
{
  public interface IFormMetadataItemHeaderDTOManager : IConfigurationService
  {
    /// <summary>Получить следующий номер публикуемой версии формы</summary>
    /// <param name="headerId">Идентификатор заголовка формы</param>
    /// <returns>Номер версии</returns>
    long GetPublishingVersionNumber(long headerId);

    /// <summary>Удалить</summary>
    /// <param name="headerId">Идентификатор заголовка формы</param>
    void Delete(long headerId);

    /// <summary>Проверить идентификатор страницы</summary>
    /// <param name="headerId">Id заголовка</param>
    /// <param name="metadataType">Тип метаданных</param>
    /// <param name="name">Идентификатор страницы</param>
    /// <param name="errorMessage">Сообщение об ошибке</param>
    /// <returns></returns>
    bool ValidateName(long headerId, Guid metadataType, string name, out string errorMessage);

    /// <summary>Проверить отображаемое имя страницы</summary>
    /// <param name="headerId">Id заголовка</param>
    /// <param name="metadataType">Тип метаданных</param>
    /// <param name="displayName">Отображаемое имя страницы</param>
    /// <param name="errorMessage">Сообщение об ошибке</param>
    /// <returns></returns>
    bool ValidateDisplayName(
      long headerId,
      Guid metadataType,
      string displayName,
      out string errorMessage);

    /// <summary>
    /// Получить отображаемую информацию о странице или портлете
    /// </summary>
    /// <param name="uid"></param>
    /// <returns></returns>
    string GetDisplayName(Guid uid);
  }
}
