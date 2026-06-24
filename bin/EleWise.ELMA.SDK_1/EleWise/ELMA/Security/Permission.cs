// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Permission
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security
{
  /// <summary>
  /// Привилегия
  /// 
  /// Примеры:  создание, редактирование, просмотр и пр.
  /// 
  /// </summary>
  public class Permission : IIdentified
  {
    /// <summary>Функция для получения локализованного наименования</summary>
    private readonly Func<string> name;
    /// <summary>НЕ локализованное описание</summary>
    private readonly string description;
    /// <summary>НЕ локализованная категория</summary>
    private readonly string category;
    private static Permission NjsR2CBYWCVB2Z4o3NQn;

    /// <summary>Создание привилегии</summary>
    /// <param name="id">Идентификатор привилегии, должен быть уникальным и константным</param>
    /// <param name="name">Функция для получения локализованного наименования</param>
    /// <param name="description">SR.M("описание")</param>
    /// <param name="category">SR.M("категория")</param>
    /// <returns></returns>
    public static PermissionBuilder Create(
      Guid id,
      Func<string> name,
      string description,
      string category)
    {
      return new PermissionBuilder(id, name, description, category);
    }

    /// <summary>Создание привилегии</summary>
    /// <param name="id">Идентификатор привилегии, должен быть уникальным и константным</param>
    /// <param name="name">SR.M("наименование")</param>
    /// <param name="description">SR.M("описание")</param>
    /// <param name="category">SR.M("категория")</param>
    /// <returns></returns>
    public static PermissionBuilder Create(
      Guid id,
      string name,
      string description,
      string category)
    {
      int num = 2;
      string name1;
      while (true)
      {
        switch (num)
        {
          case 1:
            name1 = name;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
            continue;
          case 2:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 1 : 1;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return Permission.Create(id, (Func<string>) (() => EleWise.ELMA.SR.T(name1)), description, category);
    }

    /// <summary>Создание привилегии</summary>
    /// <param name="id">Идентификатор привилегии, должен быть уникальным и константным</param>
    /// <param name="name">SR.M("наименование")</param>
    /// <param name="description">SR.M("описание")</param>
    /// <param name="category">SR.M("категория")</param>
    /// <returns></returns>
    public static PermissionBuilder Create(
      string id,
      string name,
      string description,
      string category)
    {
      return (PermissionBuilder) Permission.ybstEUBYG1LTi7aHmBxx(Permission.G0UMYdBYhiN7X3eOFB7R((object) id), (object) name, (object) description, (object) category);
    }

    /// <summary>
    /// </summary>
    /// <param name="id"></param>
    /// <param name="name">Функция для получения локализованного наименования</param>
    /// <param name="description">SR.M("описание")</param>
    /// <param name="category">SR.M("категория")</param>
    [Obsolete("Use Permission.Create instead")]
    public Permission(
      Guid id,
      Func<string> name,
      string description,
      string category,
      Permission[] dependencies = null,
      string moduleUid = null,
      PermissionType permissionType = PermissionType.Global,
      Permission @base = null,
      Type entityType = null,
      bool showInGlobalSettings = true,
      bool readOnly = false)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Id = id;
      this.name = name;
      this.description = description;
      this.category = category;
      this.Dependencies = dependencies ?? new Permission[0];
      this.ModuleUid = moduleUid;
      this.PermissionType = permissionType;
      this.Base = @base;
      this.EntityType = entityType;
      this.ShowInGlobalSettings = showInGlobalSettings;
      this.ReadOnly = readOnly;
      this.CheckModuleAccess = true;
    }

    /// <summary>
    /// </summary>
    /// <param name="id"></param>
    /// <param name="name">SR.M("наименование")</param>
    /// <param name="description">SR.M("описание")</param>
    /// <param name="category">SR.M("категория")</param>
    [Obsolete("Use Permission.Create instead")]
    public Permission(
      Guid id,
      string name,
      string description,
      string category,
      Permission[] dependencies = null,
      string moduleUid = null,
      PermissionType permissionType = PermissionType.Global,
      Permission @base = null,
      Type entityType = null,
      bool showInGlobalSettings = true,
      bool readOnly = false)
    {
      Permission.qs99kDBYEDituxjVnqn1();
      // ISSUE: reference to a compiler-generated method
      // ISSUE: explicit constructor call
      this.\u002Ector(id, (Func<string>) (() => (string) Permission.\u003C\u003Ec__DisplayClass4_0.DaAc7rQPB9R7Z4eYB3iL((object) name)), description, category, dependencies, moduleUid, permissionType, @base, entityType, showInGlobalSettings, readOnly);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>
    /// </summary>
    /// <param name="id"></param>
    /// <param name="name">SR.M("наименование")</param>
    /// <param name="description">SR.M("описание")</param>
    /// <param name="category">SR.M("категория")</param>
    [Obsolete("Use Permission.Create instead")]
    public Permission(
      string id,
      string name,
      string description,
      string category,
      Permission[] dependencies = null,
      string moduleUid = null,
      PermissionType permissionType = PermissionType.Global,
      Permission @base = null,
      Type entityType = null,
      bool showInGlobalSettings = true,
      bool readOnly = false)
    {
      Permission.qs99kDBYEDituxjVnqn1();
      // ISSUE: explicit constructor call
      this.\u002Ector(Guid.Parse(id), name, description, category, dependencies, moduleUid, permissionType, @base, entityType, showInGlobalSettings, readOnly);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public object GetId() => (object) this.Id;

    public void SetId(object id)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Id = (Guid) id;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>
    /// Идентификатор привилегии, должен быть уникальным и константным
    /// </summary>
    public Guid Id
    {
      get => this.\u003CId\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Название (локализованное в текущую локаль)</summary>
    public string Name => this.name();

    /// <summary>Описание</summary>
    public string Description => (string) Permission.vwOriYBYfKVvGqoPn5bZ((object) this.description);

    /// <summary>
    /// Категория
    /// 
    /// Пример
    /// в CRM имеются следуюшие категории привилегий:
    /// - Общие настройки модуля
    /// - Компании
    /// - Контакты
    /// - и т.д.
    /// 
    /// </summary>
    [Display(Name = "Категория")]
    public string Category => (string) Permission.vwOriYBYfKVvGqoPn5bZ((object) this.category);

    /// <summary>
    /// Привилегии от которых завист данная привилегия
    /// Если роли назначается привилегия, то система автоматические добавляет все зависимые привилегии
    ///  и наоборот, если у роли удаляется зависимая привилегия то и основная привилегия удаляется.
    /// 
    /// Пример: привилегия "редактирование пользователей" зависит от "просмотр пользователей"
    /// </summary>
    public Permission[] Dependencies
    {
      get => this.\u003CDependencies\u003Ek__BackingField;
      internal set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CDependencies\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>
    /// Привилегии, от которых зависит данная привилегии полученные транзитивным отношением Dependecies
    /// </summary>
    public IEnumerable<Permission> AllDependencies => ((IEnumerable<Permission>) this.Dependencies).Union<Permission>(((IEnumerable<Permission>) this.Dependencies).SelectMany<Permission, Permission>((Func<Permission, IEnumerable<Permission>>) (d => d.AllDependencies)));

    /// <summary>Идентификатор модуля, к которому относится привилегия</summary>
    public string ModuleUid
    {
      get => this.\u003CModuleUid\u003Ek__BackingField;
      internal set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CModuleUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>
    /// Проверять ли при проверке данной привилегии доступ к модулю (по умолчанию true)
    /// </summary>
    public bool CheckModuleAccess
    {
      get => this.\u003CCheckModuleAccess\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CCheckModuleAccess\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Тип привилегии</summary>
    public PermissionType PermissionType
    {
      get => this.\u003CPermissionType\u003Ek__BackingField;
      internal set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CPermissionType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>
    /// Является привилегией InstanceSettings (не бязательно делать IPermissionRoleTypeProvider)
    /// </summary>
    public bool IsInstanceSettingsPermission
    {
      get => this.\u003CIsInstanceSettingsPermission\u003Ek__BackingField;
      internal set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CIsInstanceSettingsPermission\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Базовая привилегия</summary>
    public Permission Base
    {
      get => this.\u003CBase\u003Ek__BackingField;
      internal set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CBase\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>
    /// Админские привилегии
    /// Если пользовель имеет права на админские привилегии, то он автоматические обладает правами для текущей привилегии
    /// </summary>
    public Permission[] AdminPermissions
    {
      get => this.\u003CAdminPermissions\u003Ek__BackingField;
      internal set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CAdminPermissions\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Тип сущности, к которой относится привилегия</summary>
    public Type EntityType
    {
      get => this.\u003CEntityType\u003Ek__BackingField;
      internal set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CEntityType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>
    /// Определяет, что проверку привилегий обладают те, у кого нет данной привилегии
    /// </summary>
    public bool Inverse
    {
      get => this.\u003CInverse\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CInverse\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>
    /// Оттображать ли данную привилегию во вкладке "Глобальные настройки доступа"
    /// </summary>
    public bool ShowInGlobalSettings
    {
      get => this.\u003CShowInGlobalSettings\u003Ek__BackingField;
      internal set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CShowInGlobalSettings\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>
    /// Признак, что для данной привилегии нельзя изменять список ее обладателей
    /// </summary>
    public bool ReadOnly
    {
      get => this.\u003CReadOnly\u003Ek__BackingField;
      internal set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CReadOnly\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    public Permission ParentPermission
    {
      get => this.\u003CParentPermission\u003Ek__BackingField;
      internal set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CParentPermission\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    public Func<object, object> ParentResolve { get; internal set; }

    public bool ParentAllTargets
    {
      get => this.\u003CParentAllTargets\u003Ek__BackingField;
      internal set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CParentAllTargets\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    public Permission ProfileForPermission
    {
      get => this.\u003CProfileForPermission\u003Ek__BackingField;
      internal set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CProfileForPermission\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    public Func<Permission, string> getDisplayName { get; internal set; }

    public static bool IsInheritOrSame(Permission @base, Permission target)
    {
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!(target.Base != (Permission) null))
            {
              num = 6;
              continue;
            }
            goto label_8;
          case 2:
            goto label_8;
          case 3:
            if (!Permission.IHj5p1BYCQ4fbVwbNqVa((object) target, (object) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
              continue;
            }
            goto case 1;
          case 4:
            goto label_10;
          case 5:
            if (Permission.qNvahlBYQJeaJPiZu5ED((object) @base, (object) target))
            {
              num = 4;
              continue;
            }
            goto case 3;
          default:
            goto label_9;
        }
      }
label_8:
      return Permission.aEnii9BY81fZLJ3Ac3We((object) @base, Permission.pDVKhrBYvibd6eJdhpFT((object) target));
label_9:
      return false;
label_10:
      return true;
    }

    public override string ToString() => (string) Permission.aOYowsBYuukp4oU6FfT4(Permission.iyYjuZBYZxPjXVVfkNCi(-398663332 ^ -398616482), (object) new object[7]
    {
      (object) this.Id,
      (object) this.Name,
      (object) this.Description,
      (object) this.Category,
      (object) this.Dependencies,
      (object) this.ModuleUid,
      (object) this.PermissionType
    });

    public bool Equals(Permission other)
    {
      int num1 = 10;
      while (true)
      {
        int num2 = num1;
        Guid guid;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (Permission.itj8DqBYSOtuRITZ9KPy(Permission.ojqnE8BYVowxZyUJXkpm((object) other), (object) this.Name))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 4 : 0;
                continue;
              }
              goto label_13;
            case 2:
              goto label_5;
            case 3:
              if (Permission.itj8DqBYSOtuRITZ9KPy((object) other.Category, (object) this.Category))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 8 : 12;
                continue;
              }
              goto label_13;
            case 4:
              if (Permission.itj8DqBYSOtuRITZ9KPy(Permission.ThQ6X6BYi5vDu6BheGHp((object) other), (object) this.Description))
              {
                num2 = 3;
                continue;
              }
              goto label_13;
            case 5:
              if (!Permission.itj8DqBYSOtuRITZ9KPy(Permission.xSmTqiBYqFqLCHPa4UJq((object) other), (object) this.ModuleUid))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
                continue;
              }
              goto case 11;
            case 6:
              goto label_22;
            case 7:
              goto label_12;
            case 8:
              if (guid.Equals(this.Id))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 1;
                continue;
              }
              goto label_13;
            case 9:
              if ((object) this == (object) other)
              {
                num2 = 6;
                continue;
              }
              guid = Permission.qOGKvZBYILwWYRh2EgCH((object) other);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 3 : 8;
              continue;
            case 10:
              if ((object) other != null)
              {
                num2 = 9;
                continue;
              }
              goto label_5;
            case 11:
              if (Permission.itj8DqBYSOtuRITZ9KPy((object) Permission.aaQZiOBYKo9OyVpnZbAS((object) other), (object) this.PermissionType))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 13;
                continue;
              }
              goto label_13;
            case 12:
              if (object.Equals(Permission.c8cPOSBYRlceHX7tF6Xd((object) other), (object) this.Dependencies))
              {
                num2 = 5;
                continue;
              }
              goto label_13;
            case 13:
              goto label_3;
            default:
              goto label_13;
          }
        }
label_3:
        if (Permission.itj8DqBYSOtuRITZ9KPy(Permission.pDVKhrBYvibd6eJdhpFT((object) other), (object) this.Base))
          num1 = 7;
        else
          goto label_13;
      }
label_5:
      return false;
label_12:
      return Permission.MYLTyoBYTCLQD0W8pHl9(Permission.rh68x1BYXprbYq9m1gfl((object) other), this.EntityType);
label_13:
      return false;
label_22:
      return true;
    }

    public override bool Equals(object obj)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (obj != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
              continue;
            }
            goto label_9;
          case 2:
            goto label_2;
          case 3:
            goto label_6;
          case 4:
            goto label_9;
          default:
            if ((object) this != obj)
            {
              if (obj.GetType() != typeof (Permission))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 2 : 2;
                continue;
              }
              goto label_3;
            }
            else
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 1 : 3;
              continue;
            }
        }
      }
label_2:
      return false;
label_3:
      return this.Equals((Permission) obj);
label_6:
      return true;
label_9:
      return false;
    }

    public override int GetHashCode()
    {
      int num = 1;
      Guid id;
      while (true)
      {
        switch (num)
        {
          case 1:
            id = this.Id;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return ((((((((id.GetHashCode() * 397 ^ (this.Name != null ? this.Name.GetHashCode() : 0)) * 397 ^ (this.Description != null ? this.Description.GetHashCode() : 0)) * 397 ^ (this.Category != null ? this.Category.GetHashCode() : 0)) * 397 ^ (this.Dependencies == null ? 0 : this.Dependencies.GetHashCode())) * 397 ^ (this.ModuleUid == null ? 0 : this.ModuleUid.GetHashCode())) * 397 ^ this.CheckModuleAccess.GetHashCode()) * 397 ^ this.PermissionType.GetHashCode()) * 397 ^ (!Permission.IHj5p1BYCQ4fbVwbNqVa((object) this.Base, (object) null) ? 0 : this.Base.GetHashCode())) * 397 ^ (Permission.ywYJpuBYkZADfddCiRY9(this.EntityType, (Type) null) ? this.EntityType.GetHashCode() : 0);
    }

    public static bool operator ==(Permission a, Permission b)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if ((object) a == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 2 : 6;
              continue;
            }
            goto case 7;
          case 2:
            if ((object) a != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 1 : 1;
              continue;
            }
            goto case 5;
          case 3:
            goto label_6;
          case 4:
            goto label_8;
          case 5:
            if ((object) b == null)
            {
              num = 4;
              continue;
            }
            goto case 1;
          case 7:
            if ((object) b != null)
            {
              num = 8;
              continue;
            }
            goto label_13;
          case 8:
            if ((object) a != (object) b)
            {
              num = 3;
              continue;
            }
            goto label_7;
          default:
            goto label_13;
        }
      }
label_6:
      return Permission.eHBLjDBYno8XulFkfmei((object) a, (object) b);
label_7:
      return true;
label_8:
      return true;
label_13:
      return false;
    }

    public static bool operator !=(Permission a, Permission b) => !Permission.qNvahlBYQJeaJPiZu5ED((object) a, (object) b);

    internal static bool phf8MIBYooA9hTfLLAqN() => (object) Permission.NjsR2CBYWCVB2Z4o3NQn == null;

    internal static Permission x6YBHfBYbdE8Y4PBbaEk() => Permission.NjsR2CBYWCVB2Z4o3NQn;

    internal static Guid G0UMYdBYhiN7X3eOFB7R([In] object obj0) => Guid.Parse((string) obj0);

    internal static object ybstEUBYG1LTi7aHmBxx(Guid id, [In] object obj1, [In] object obj2, [In] object obj3) => (object) Permission.Create(id, (string) obj1, (string) obj2, (string) obj3);

    internal static void qs99kDBYEDituxjVnqn1() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object vwOriYBYfKVvGqoPn5bZ([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool qNvahlBYQJeaJPiZu5ED([In] object obj0, [In] object obj1) => (Permission) obj0 == (Permission) obj1;

    internal static bool IHj5p1BYCQ4fbVwbNqVa([In] object obj0, [In] object obj1) => (Permission) obj0 != (Permission) obj1;

    internal static object pDVKhrBYvibd6eJdhpFT([In] object obj0) => (object) ((Permission) obj0).Base;

    internal static bool aEnii9BY81fZLJ3Ac3We([In] object obj0, [In] object obj1) => Permission.IsInheritOrSame((Permission) obj0, (Permission) obj1);

    internal static object iyYjuZBYZxPjXVVfkNCi(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object aOYowsBYuukp4oU6FfT4([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, (object[]) obj1);

    internal static Guid qOGKvZBYILwWYRh2EgCH([In] object obj0) => ((Permission) obj0).Id;

    internal static object ojqnE8BYVowxZyUJXkpm([In] object obj0) => (object) ((Permission) obj0).Name;

    internal static bool itj8DqBYSOtuRITZ9KPy([In] object obj0, [In] object obj1) => object.Equals(obj0, obj1);

    internal static object ThQ6X6BYi5vDu6BheGHp([In] object obj0) => (object) ((Permission) obj0).Description;

    internal static object c8cPOSBYRlceHX7tF6Xd([In] object obj0) => (object) ((Permission) obj0).Dependencies;

    internal static object xSmTqiBYqFqLCHPa4UJq([In] object obj0) => (object) ((Permission) obj0).ModuleUid;

    internal static PermissionType aaQZiOBYKo9OyVpnZbAS([In] object obj0) => ((Permission) obj0).PermissionType;

    internal static Type rh68x1BYXprbYq9m1gfl([In] object obj0) => ((Permission) obj0).EntityType;

    internal static bool MYLTyoBYTCLQD0W8pHl9([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static bool ywYJpuBYkZADfddCiRY9([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static bool eHBLjDBYno8XulFkfmei([In] object obj0, [In] object obj1) => ((Permission) obj0).Equals((Permission) obj1);
  }
}
