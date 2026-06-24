// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.ExtensionPoints.IExternalMembershipModule
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Security.Settings;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Security.ExtensionPoints
{
  /// <summary>Интерфейс внешнего модуля авторизации</summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IExternalMembershipModule
  {
    /// <summary>Уникальный номер модуля</summary>
    Guid Uid { get; }

    /// <summary>Создать экземпляр модуля с настройками по умолчанию</summary>
    IExternalMembershipModuleSettings CreateDefaultSettings();

    /// <summary>Отображаемое имя</summary>
    string Name { get; }

    /// <summary>Описание</summary>
    string Description { get; }

    /// <summary>Группа модулей</summary>
    string Category { get; }

    /// <summary>Поиск пользователей по подстроке</summary>
    IEnumerable<IUser> FindUsers(string searchString, IExternalMembershipModuleSettings settings);

    /// <summary>Синхронизировать данные о пользователе</summary>
    void Sync(IUser user, IExternalMembershipModuleSettings settings);

    /// <summary>Проверить авторизацию пользователя</summary>
    bool ValidateUser(UserValidationContext context, IExternalMembershipModuleSettings settings);
  }
}
