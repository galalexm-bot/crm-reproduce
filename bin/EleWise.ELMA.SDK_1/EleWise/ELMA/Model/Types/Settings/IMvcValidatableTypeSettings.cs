// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Settings.IMvcValidatableTypeSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Collections.Generic;
using System.Web.Mvc;

namespace EleWise.ELMA.Model.Types.Settings
{
  /// <summary>
  /// Интерфейс для настроек типа данных, которые поддерживают MVC-валидаторы
  /// </summary>
  public interface IMvcValidatableTypeSettings
  {
    /// <summary>Применить правила валидации</summary>
    /// <param name="rules">Спсиок правил, который нужно изменить</param>
    /// <param name="metadata">Метаданные MVC</param>
    /// <param name="context">Контекст контроллера MVC</param>
    /// <param name="originalPropertySettings">Оригинальные настройки, заданные в свойстве</param>
    /// <returns></returns>
    void ApplyValidationRules(
      ICollection<ModelClientValidationRule> rules,
      ModelMetadata metadata,
      ControllerContext context,
      TypeSettings originalPropertySettings);
  }
}
