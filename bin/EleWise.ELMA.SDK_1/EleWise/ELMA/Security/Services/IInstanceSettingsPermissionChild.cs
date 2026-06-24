// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.IInstanceSettingsPermissionChild
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using System;

namespace EleWise.ELMA.Security.Services
{
  /// <summary>
  /// Интерфейс прав доступа к экземплару объекта на основе настроек родительского объекта
  /// Пример 1: доступ к версии документа настраивается в карточке документа, правами могут обладать:
  /// - автор
  /// - пользователь
  /// - группа
  /// - эл-т организационной структуры
  /// </summary>
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  public interface IInstanceSettingsPermissionChild : IInstanceSettingsPermission
  {
    /// <summary>
    /// Имя свойства-ссылки на родительскую сущность в дочернем объекте
    /// </summary>
    string ParentPropertyName { get; }

    /// <summary>
    /// Получить привилегию родительского объекта для проверки по привилегии дочернего объекта
    /// </summary>
    /// <param name="childPermissionId">ИД привилегии</param>
    /// <returns></returns>
    Guid GetParentPermissionId(Guid childPermissionId);
  }
}
