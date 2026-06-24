// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Validation.IRequiredFieldValidatorHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EleWise.ELMA.Model.Types.Validation
{
  /// <summary>Обработчик валидатора обязательного поля</summary>
  [ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
  public interface IRequiredFieldValidatorHandler
  {
    /// <summary>Получить правила клиентской валидации</summary>
    /// <param name="validator">Валидатор</param>
    /// <param name="metadata">Метаданные модели</param>
    /// <param name="controllerContext">Контекст контроллера</param>
    /// <param name="rules">Правила валидации</param>
    /// <param name="mainRule">Основное правило</param>
    void GetClientValidationRules(
      ModelValidator validator,
      ModelMetadata metadata,
      ControllerContext controllerContext,
      List<ModelClientValidationRule> rules,
      ModelClientValidationRule mainRule);
  }
}
