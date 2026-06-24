// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Components.ExternalMembershipModule`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.ExtensionPoints;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Security.Settings;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Security.Components
{
  /// <summary>Базовый класс внешнего модуля авторизации</summary>
  [Component]
  public abstract class ExternalMembershipModule<TS> : IExternalMembershipModule where TS : ExternalMembershipModuleSettings, new()
  {
    private static object EqsWsYBUE7T5sHUCIq9e;

    /// <summary>Уникальный номер модуля</summary>
    public abstract Guid Uid { get; }

    /// <summary>Отображаемое имя</summary>
    public abstract string Name { get; }

    /// <summary>Описание</summary>
    public abstract string Description { get; }

    /// <summary>Группа модулей</summary>
    public virtual string Category => string.Empty;

    /// <summary>Создать экземпляр модуля с настройками по умолчанию</summary>
    public virtual IExternalMembershipModuleSettings CreateDefaultSettings()
    {
      TS defaultSettings = new TS();
      defaultSettings.InstanceUid = Guid.NewGuid();
      return (IExternalMembershipModuleSettings) defaultSettings;
    }

    /// <summary>Поиск пользователей по подстроке</summary>
    public abstract IEnumerable<IUser> FindUsers(
      string searchString,
      IExternalMembershipModuleSettings settings);

    /// <summary>Синхронизировать данные о пользователе</summary>
    public abstract void Sync(IUser user, IExternalMembershipModuleSettings settings);

    /// <summary>Проверить авторизацию пользователя</summary>
    public abstract bool ValidateUser(
      UserValidationContext context,
      IExternalMembershipModuleSettings settings);

    protected ExternalMembershipModule()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool TZnWEFBUfREGEVdfGao7() => ExternalMembershipModule<TS>.EqsWsYBUE7T5sHUCIq9e == null;

    internal static object Eo8ZrjBUQqBLk0x8hHy0() => ExternalMembershipModule<TS>.EqsWsYBUE7T5sHUCIq9e;
  }
}
