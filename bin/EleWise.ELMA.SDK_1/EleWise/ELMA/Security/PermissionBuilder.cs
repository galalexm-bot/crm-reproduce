// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.PermissionBuilder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security
{
  /// <summary>Билдер для формирования привилегии</summary>
  public class PermissionBuilder
  {
    private readonly Permission permission;
    private static PermissionBuilder HNtjJqBYOpv1NPOMhcDo;

    internal PermissionBuilder(Guid id, Func<string> name, string description, string category)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.permission = new Permission(id, name, description, category);
    }

    public static implicit operator Permission(PermissionBuilder builder) => (Permission) PermissionBuilder.vAVw7QBYPoIWvR5RFp0v((object) builder);

    /// <summary>Построить привилегию</summary>
    /// <returns></returns>
    public Permission Build() => this.permission;

    /// <summary>
    /// Привилегии от которых завист данная привилегия
    /// Если роли назначается привилегия, то система автоматические добавляет все зависимые привилегии
    ///  и наоборот, если у роли удаляется зависимая привилегия то и основная привилегия удаляется.
    /// 
    /// Пример: привилегия "редактирование пользователей" зависит от "просмотр пользователей"
    /// </summary>
    /// <param name="dependencies">Привилегии от которых завист данная привилегия</param>
    /// <returns></returns>
    public PermissionBuilder Dependencies(params Permission[] dependencies)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            PermissionBuilder.C5CGCMBY1UW7VhJGf5Uh((object) this.permission, (object) (dependencies ?? new Permission[0]));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return this;
    }

    /// <summary>Идентификатор модуля, к которому относится привилегия</summary>
    /// <param name="moduleUid">Идентификатор модуля, к которому относится привилегия</param>
    /// <returns></returns>
    public PermissionBuilder ModuleUid(string moduleUid)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            PermissionBuilder.UxiWb5BYN8qn0gRSNy8m((object) this.permission, (object) moduleUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return this;
    }

    /// <summary>Глобальная привилегия</summary>
    /// <returns></returns>
    public PermissionBuilder GlobalPermission()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.permission.PermissionType = PermissionType.Global;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return this;
    }

    /// <summary>Тип сущности, к которой относится привилегия</summary>
    /// <param name="entityType">Тип сущности, к которой относится привилегия</param>
    /// <returns></returns>
    public PermissionBuilder EntityType(Type entityType)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            PermissionBuilder.F14iVMBY3OcmQM7PYGJ1((object) this.permission, entityType);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return this;
    }

    /// <summary>Тип сущности, к которой относится привилегия</summary>
    /// <returns></returns>
    public PermissionBuilder EntityType<T>() => this.EntityType(InterfaceActivator.TypeOf<T>());

    /// <summary>Базовая привилегия</summary>
    /// <param name="base">Базовая привилегия</param>
    /// <returns></returns>
    public PermissionBuilder Base(Permission @base)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            PermissionBuilder.sUHyGQBYpAAlLw5stoYP((object) this.permission, (object) @base);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return this;
    }

    /// <summary>Право на тип сущности</summary>
    /// <param name="entityType">Тип сущности, к которой относится привилегия</param>
    /// <returns></returns>
    public PermissionBuilder EntityTypePermission(Type entityType)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            PermissionBuilder.Bx33ZuBYaIegtNpn7HeP((object) this.permission, PermissionType.EntityType);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return this.EntityType(entityType);
    }

    /// <summary>Право на тип сущности</summary>
    /// <typeparam name="T">Тип сущности, к которой относится привилегия</typeparam>
    /// <returns></returns>
    public PermissionBuilder EntityTypePermission<T>() => this.EntityTypePermission(InterfaceActivator.TypeOf<T>());

    /// <summary>Право на тип сущности</summary>
    /// <param name="entityType">Тип сущности, к которой относится привилегия</param>
    /// <param name="base">Базовая привилегия</param>
    /// <returns></returns>
    public PermissionBuilder EntityTypePermission(Type entityType, Permission @base) => (PermissionBuilder) PermissionBuilder.QoACWZBYDS1OuSZ5CJXr((object) this.EntityTypePermission(entityType), (object) @base);

    /// <summary>Право на тип сущности</summary>
    /// <typeparam name="T">Тип сущности, к которой относится привилегия</typeparam>
    /// <param name="base">Базовая привилегия</param>
    /// <returns></returns>
    public PermissionBuilder EntityTypePermission<T>(Permission @base) => this.EntityTypePermission(InterfaceActivator.TypeOf<T>(), @base);

    /// <summary>Привилегия уровня экземпляра типа</summary>
    /// <param name="entityType">Тип сущности, к которой относится привилегия</param>
    /// <returns></returns>
    public PermissionBuilder InstancePermission(Type entityType)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.permission.PermissionType = PermissionType.Instance;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return this.EntityType(entityType);
    }

    /// <summary>Привилегия уровня экземпляра типа</summary>
    /// <typeparam name="T">Тип сущности, к которой относится привилегия</typeparam>
    /// <returns></returns>
    public PermissionBuilder InstancePermission<T>() => this.InstancePermission(InterfaceActivator.TypeOf<T>());

    /// <summary>Привилегия уровня экземпляра типа</summary>
    /// <param name="entityType">Тип сущности, к которой относится привилегия</param>
    /// <param name="base">Базовая привилегия</param>
    /// <returns></returns>
    public PermissionBuilder InstancePermission(Type entityType, Permission @base) => (PermissionBuilder) PermissionBuilder.QoACWZBYDS1OuSZ5CJXr((object) this.InstancePermission(entityType), (object) @base);

    /// <summary>Привилегия уровня экземпляра типа</summary>
    /// <typeparam name="T">Тип сущности, к которой относится привилегия</typeparam>
    /// <param name="base">Базовая привилегия</param>
    /// <returns></returns>
    public PermissionBuilder InstancePermission<T>(Permission @base) => this.InstancePermission(InterfaceActivator.TypeOf<T>(), @base);

    /// <summary>Привилегия уровня экземпляра типа</summary>
    /// <param name="entityType">Тип сущности, к которой относится привилегия (не бязательно делать IPermissionRoleTypeProvider)</param>
    /// <returns></returns>
    public PermissionBuilder InstanceSettingsPermission(Type entityType)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.permission.IsInstanceSettingsPermission = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return this.InstancePermission(entityType);
    }

    /// <summary>Привилегия уровня экземпляра типа</summary>
    /// <typeparam name="T">Тип сущности, к которой относится привилегия (не бязательно делать IPermissionRoleTypeProvider)</typeparam>
    /// <returns></returns>
    public PermissionBuilder InstanceSettingsPermission<T>() => this.InstanceSettingsPermission(InterfaceActivator.TypeOf<T>());

    /// <summary>Привилегия уровня экземпляра типа</summary>
    /// <param name="entityType">Тип сущности, к которой относится привилегия (не бязательно делать IPermissionRoleTypeProvider)</param>
    /// <param name="base">Базовая привилегия</param>
    /// <returns></returns>
    public PermissionBuilder InstanceSettingsPermission(Type entityType, Permission @base) => this.InstanceSettingsPermission(entityType).Base(@base);

    /// <summary>Привилегия уровня экземпляра типа</summary>
    /// <typeparam name="T">Тип сущности, к которой относится привилегия (не бязательно делать IPermissionRoleTypeProvider)</typeparam>
    /// <param name="base">Базовая привилегия</param>
    /// <returns></returns>
    public PermissionBuilder InstanceSettingsPermission<T>(Permission @base) => this.InstanceSettingsPermission(InterfaceActivator.TypeOf<T>(), @base);

    /// <summary>
    /// Оттображать ли данную привилегию во вкладке "Глобальные настройки доступа"
    /// </summary>
    /// <param name="showInGlobalSettings">Оттображать ли данную привилегию во вкладке "Глобальные настройки доступа"</param>
    /// <returns></returns>
    public PermissionBuilder ShowInGlobalSettings(bool showInGlobalSettings = true)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            PermissionBuilder.R6B6VKBYt6FIDSBScjJ8((object) this.permission, showInGlobalSettings);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return this;
    }

    /// <summary>
    /// Признак, что для данной привилегии нельзя изменять список ее обладателей
    /// </summary>
    /// <param name="readOnly">Признак, что для данной привилегии нельзя изменять список ее обладателей</param>
    /// <returns></returns>
    public PermissionBuilder ReadOnly(bool readOnly = true)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            PermissionBuilder.MgeAqkBYwN5YkVpMgr36((object) this.permission, readOnly);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return this;
    }

    /// <summary>
    /// Админские привилегии
    /// Если пользовель имеет права на админские привилегии, то он автоматические обладает правами для текущей привилегии
    /// </summary>
    /// <param name="adminPermissions">Админские привилегии</param>
    /// <returns></returns>
    public PermissionBuilder AdminPermissions(params Permission[] adminPermissions)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            Permission permission = this.permission;
            Permission[] permissionArray1 = adminPermissions;
            Permission[] permissionArray2 = permissionArray1 == null ? new Permission[0] : permissionArray1;
            permission.AdminPermissions = permissionArray2;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return this;
    }

    /// <summary>
    /// Проверять ли при проверке данной привилегии доступ к модулю
    /// </summary>
    /// <param name="checkAccess">Проверять ли доступ к модулю</param>
    /// <returns></returns>
    public PermissionBuilder CheckModuleAccess(bool checkAccess)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            PermissionBuilder.CsjhSlBY4Z6BqCaiuk77((object) this.permission, checkAccess);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return this;
    }

    /// <summary>Задается проверка прав через родительский объект</summary>
    /// <typeparam name="T">EntityType</typeparam>
    /// <param name="parentResolve">Выражение для получение родительского объекта</param>
    /// <param name="parentPermission">Привилегия родительского объекта</param>
    /// <returns></returns>
    public PermissionBuilder InstanceParentPermission<T>(
      Func<T, object> parentResolve,
      Permission parentPermission)
    {
      this.permission.ParentPermission = parentPermission;
      this.permission.ParentResolve = (Func<object, object>) (target =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (target is T)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_2;
            default:
              goto label_3;
          }
        }
label_2:
        return (object) null;
label_3:
        return parentResolve((T) target);
      });
      return this.InstancePermission<T>();
    }

    public PermissionBuilder InstanceParentPermissionAll<T>(
      Func<T, IEnumerable<object>> parentResolve,
      Permission parentPermission)
    {
      this.permission.ParentAllTargets = true;
      return this.InstanceParentPermission<T>((Func<T, object>) parentResolve, parentPermission);
    }

    public PermissionBuilder InstanceParentPermissionAny<T>(
      Func<T, IEnumerable<object>> parentResolve,
      Permission parentPermission)
    {
      this.permission.ParentAllTargets = false;
      return this.InstanceParentPermission<T>((Func<T, object>) parentResolve, parentPermission);
    }

    /// <summary>Задается проверка прав через родительский объект</summary>
    /// <typeparam name="T">EntityType</typeparam>
    /// <param name="parentResolve">Выражение для получение родительского объекта</param>
    /// <param name="parentPermission">Привилегия родительского объекта</param>
    /// <param name="base">Базовая привилегия</param>
    /// <returns></returns>
    public PermissionBuilder InstanceParentPermission<T>(
      Func<T, object> parentResolve,
      Permission parentPermission,
      Permission @base)
    {
      return this.InstanceParentPermission<T>(parentResolve, parentPermission).Base(@base);
    }

    public PermissionBuilder InstanceParentPermissionAll<T>(
      Func<T, IEnumerable<object>> parentResolve,
      Permission parentPermission,
      Permission @base)
    {
      return this.InstanceParentPermissionAll<T>(parentResolve, parentPermission).Base(@base);
    }

    public PermissionBuilder InstanceParentPermissionAny<T>(
      Func<T, IEnumerable<object>> parentResolve,
      Permission parentPermission,
      Permission @base)
    {
      return this.InstanceParentPermissionAny<T>(parentResolve, parentPermission).Base(@base);
    }

    /// <summary>Задается привилегия для профайлера</summary>
    /// <typeparam name="T">EntityType</typeparam>
    /// <param name="profileForPermission">Привилегия объекта, которая проверяется в профайлере</param>
    /// <returns></returns>
    /// <remarks>Для работы данного типа привилегии необходимо реализовать точку расширения EleWise.ELMA.Security.Services.IProfileResolver/&gt;</remarks>
    public PermissionBuilder ProfilePermission<T>(Permission profileForPermission)
    {
      this.permission.ProfileForPermission = profileForPermission;
      return this.InstancePermission<T>();
    }

    /// <summary>Задается привилегия для профайлера</summary>
    /// <typeparam name="T">EntityType</typeparam>
    /// <param name="profileForPermission">Привилегия объекта, которая проверяется в профайлере</param>
    /// <returns></returns>
    /// <param name="base">Базовая привилегия</param>
    /// <remarks>Для работы данного типа привилегии необходимо реализовать точку расширения EleWise.ELMA.Security.Services.IProfileResolver/&gt;</remarks>
    public PermissionBuilder ProfilePermission<T>(Permission profileForPermission, Permission @base) => this.ProfilePermission<T>(profileForPermission).Base(@base);

    /// <summary>Задается привилегия для профайлера</summary>
    /// <typeparam name="T">EntityType</typeparam>
    /// <param name="profileForPermission">Привилегия объекта, которая проверяется в профайлере (не бязательно делать IPermissionRoleTypeProvider)</param>
    /// <returns></returns>
    /// <remarks>Для работы данного типа привилегии необходимо реализовать точку расширения EleWise.ELMA.Security.Services.IProfileResolver/&gt;</remarks>
    public PermissionBuilder ProfileInstanceSettingsPermission<T>(Permission profileForPermission)
    {
      this.permission.ProfileForPermission = profileForPermission;
      return this.InstanceSettingsPermission<T>();
    }

    /// <summary>Задается привилегия для профайлера</summary>
    /// <typeparam name="T">EntityType</typeparam>
    /// <param name="profileForPermission">Привилегия объекта, которая проверяется в профайлере (не бязательно делать IPermissionRoleTypeProvider)</param>
    /// <returns></returns>
    /// <param name="base">Базовая привилегия</param>
    /// <remarks>Для работы данного типа привилегии необходимо реализовать точку расширения EleWise.ELMA.Security.Services.IProfileResolver/&gt;</remarks>
    public PermissionBuilder ProfileInstanceSettingsPermission<T>(
      Permission profileForPermission,
      Permission @base)
    {
      return this.ProfileInstanceSettingsPermission<T>(profileForPermission).Base(@base);
    }

    internal static object vAVw7QBYPoIWvR5RFp0v([In] object obj0) => (object) ((PermissionBuilder) obj0).Build();

    internal static void C5CGCMBY1UW7VhJGf5Uh([In] object obj0, [In] object obj1) => ((Permission) obj0).Dependencies = (Permission[]) obj1;

    internal static bool J7b51xBY2aZBmWZR6aIM() => PermissionBuilder.HNtjJqBYOpv1NPOMhcDo == null;

    internal static PermissionBuilder VqbR0wBYeYy5h1ne2mXX() => PermissionBuilder.HNtjJqBYOpv1NPOMhcDo;

    internal static void UxiWb5BYN8qn0gRSNy8m([In] object obj0, [In] object obj1) => ((Permission) obj0).ModuleUid = (string) obj1;

    internal static void F14iVMBY3OcmQM7PYGJ1([In] object obj0, Type value) => ((Permission) obj0).EntityType = value;

    internal static void sUHyGQBYpAAlLw5stoYP([In] object obj0, [In] object obj1) => ((Permission) obj0).Base = (Permission) obj1;

    internal static void Bx33ZuBYaIegtNpn7HeP([In] object obj0, PermissionType value) => ((Permission) obj0).PermissionType = value;

    internal static object QoACWZBYDS1OuSZ5CJXr([In] object obj0, [In] object obj1) => (object) ((PermissionBuilder) obj0).Base((Permission) obj1);

    internal static void R6B6VKBYt6FIDSBScjJ8([In] object obj0, bool value) => ((Permission) obj0).ShowInGlobalSettings = value;

    internal static void MgeAqkBYwN5YkVpMgr36([In] object obj0, bool value) => ((Permission) obj0).ReadOnly = value;

    internal static void CsjhSlBY4Z6BqCaiuk77([In] object obj0, bool value) => ((Permission) obj0).CheckModuleAccess = value;
  }
}
