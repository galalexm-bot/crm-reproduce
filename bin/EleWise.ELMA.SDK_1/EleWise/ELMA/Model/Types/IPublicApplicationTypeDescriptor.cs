// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.IPublicApplicationTypeDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.API.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>
  /// Дополнительный интерфейс типа, предоставляющий информацию о доступности отображения свойства во внешних приложениях
  /// </summary>
  public interface IPublicApplicationTypeDescriptor
  {
    /// <summary>Доступен ли в режиме "Только для чтения"</summary>
    /// <param name="subTypeUid">Уникальный идентификатор подтипа</param>
    /// <returns>True, если доступен</returns>
    bool IsPublicApplicationDisplayEnabled(Guid subTypeUid);

    /// <summary>Доступен ли в режиме редактирования</summary>
    /// <param name="subTypeUid">Уникальный идентификатор подтипа</param>
    /// <returns>True, если доступен</returns>
    bool IsPublicApplicationEditorEnabled(Guid subTypeUid);

    /// <summary>
    /// Определить доступность отображения свойства во внешних приложениях
    /// </summary>
    /// <param name="classMetadata">Метаданные класса, в котором содержится свойство</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="viewItem">Параметры отображения свойства</param>
    /// <param name="parentPropertyName">Имя родительского свойства</param>
    /// <param name="errors">Текущий спсиок ошибок</param>
    void CheckPublicApplicationCompatibility(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      PropertyViewItem viewItem,
      string parentPropertyName,
      List<IPublicApplicationCompatibilityError> errors);
  }
}
