// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.IDynamicFormsProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Views;
using System;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>Провайдер динамических форм</summary>
  [ExtensionPoint(ServiceScope.Shell, ComponentType.Web)]
  public interface IDynamicFormsProvider
  {
    /// <summary>Уникальный идентификатор</summary>
    Guid Uid { get; }

    /// <summary>Получить тип сущности, отображаемой на форме</summary>
    /// <param name="settings">Настройки динамической формы</param>
    /// <returns></returns>
    Type GetEntityType(DynamicFormSettings settings);

    /// <summary>Выполнить сценарий</summary>
    /// <param name="entity">Сущность</param>
    /// <param name="view">Представление</param>
    /// <param name="settings">Настройки динамической формы</param>
    /// <param name="scriptName">Имя сценария</param>
    /// <param name="resultData">Дополнительные данные для результата выполнения сценария</param>
    void ExecuteScript(
      IEntity entity,
      RootViewItem view,
      DynamicFormSettings settings,
      string scriptName,
      DynamicFormResultData resultData);

    /// <summary>
    /// Получить имя сценария, который нужно выполнять при изменении значения свойства
    /// </summary>
    /// <param name="entity">Сущность</param>
    /// <param name="view">Представление</param>
    /// <param name="settings">Настройки динамической формы</param>
    /// <param name="propertyName">Имя изменившегося свойства</param>
    /// <returns></returns>
    string GetPropertyValueChangeScriptName(
      IEntity entity,
      RootViewItem view,
      DynamicFormSettings settings,
      string propertyName);
  }
}
