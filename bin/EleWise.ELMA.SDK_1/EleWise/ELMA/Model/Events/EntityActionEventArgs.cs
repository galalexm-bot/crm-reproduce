// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Events.EntityActionEventArgs
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Dynamic;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using Newtonsoft.Json;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Events
{
  /// <summary>
  /// Параметры события для действия с сущностью. Участвует в формировании истории действий
  /// Наследник обязан иметь конструктор с параметрами <see cref="T:EleWise.ELMA.Model.Entities.IEntity" /> - сущность (может быть null), <see cref="T:System.Guid" /> - объект действия, <see cref="T:System.Guid" /> - тип действия.
  /// Также он обязан быть помечен аттрибутом <see cref="T:EleWise.ELMA.Model.Attributes.UidAttribute" /> с уникальным идентификатором
  /// </summary>
  [Uid("E190A53F-D5D9-43AD-A4F4-0A1347584F45")]
  [Component]
  public class EntityActionEventArgs : 
    EntityTypeEventArgs,
    IEntityHistoryEventArgs,
    IAuditEventArgs,
    IAuditEventHolder,
    IExtendedPropertiesContainer
  {
    protected IEntity oldEntity;
    protected IEntity newEntity;
    private Guid _unitOfWorkUid;
    /// <summary>
    /// Ключ для хранения пользователя для истории по указанному объекту
    /// </summary>
    protected const string EntityActionHistory_UsersToObjects = "EntityActionHistory_UsersToObjects";
    private IAuthenticationService authenticationService;
    internal static EntityActionEventArgs YVAAoLoB8hvlN4if1DkF;

    /// <summary>Ctor</summary>
    /// <param name="old">Старая сущность (до изменения)</param>
    /// <param name="new">Новая сущность (после изменения)</param>
    /// <param name="actionUid">Уникальный идентификатор действия</param>
    public EntityActionEventArgs(IEntity old, IEntity @new, Guid actionUid)
    {
      EntityActionEventArgs.psDvNvoBIsYeXsCBP5yk();
      this._unitOfWorkUid = Guid.Empty;
      // ISSUE: explicit constructor call
      base.\u002Ector(EntityActionEventArgs.jbEwgYoBVPxsbOLXfaT6((@new ?? old).CastAsRealType<IEntity>().GetType()));
      int num1 = 5;
      while (true)
      {
        IEnumerable<IAuditActionProvider> extensionPoints;
        int num2;
        EntityActionEventArgs entityActionEventArgs;
        switch (num1)
        {
          case 1:
            num2 = @new != null ? 1 : 0;
            break;
          case 2:
            this.newEntity = @new;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
            continue;
          case 3:
            this.ActionDate = EntityActionEventArgs.gdmBCioBKeAG9QykiPHe();
            num1 = 6;
            continue;
          case 4:
            if (old == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 1 : 1;
              continue;
            }
            num2 = 1;
            break;
          case 5:
            entityActionEventArgs = this;
            num1 = 4;
            continue;
          case 6:
            goto label_14;
          case 7:
            // ISSUE: reference to a compiler-generated method
            this.auditAction = extensionPoints.Select<IAuditActionProvider, IAuditAction>((Func<IAuditActionProvider, IAuditAction>) (p => (IAuditAction) EntityActionEventArgs.\u003C\u003Ec__DisplayClass0_0.BplUveCW5YAmHEnODqr2((object) p, (object) entityActionEventArgs.auditObject, actionUid))).FirstOrDefault<IAuditAction>((Func<IAuditAction, bool>) (a => a != null));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 8 : 2;
            continue;
          case 8:
            object obj = EntityActionEventArgs.mKTcKCoBRUJAPCIb9JCc((object) this, (object) @new);
            this.ActionAuthor = obj == null ? (IUser) EntityActionEventArgs.brFvAxoBqtVQ803bEyQx((object) this.AuthenticationService) : (IUser) obj;
            num1 = 3;
            continue;
          case 9:
            this.oldEntity = old;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 2 : 2;
            continue;
          default:
            extensionPoints = ((ComponentManager) EntityActionEventArgs.P8uiApoBi6E4p5c8YSSg()).GetExtensionPoints<IAuditActionProvider>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 4 : 7;
            continue;
        }
        string str = z2jc63fLkugS1X8Q9N.tE1kD1vbB(1052221104 - 768835541 ^ 283531413);
        EntityActionEventArgs.B17mBFoBSUJvaV8d5IHF(num2 != 0, (object) str);
        num1 = 9;
      }
label_14:;
    }

    /// <summary>Ctor</summary>
    /// <param name="old">Старая сущность (до изменения)</param>
    /// <param name="new">Новая сущность (после изменения)</param>
    /// <param name="actionUidStr">Уникальный идентификатор действия в виде строки</param>
    public EntityActionEventArgs(IEntity old, IEntity @new, string actionUidStr)
    {
      EntityActionEventArgs.psDvNvoBIsYeXsCBP5yk();
      // ISSUE: explicit constructor call
      this.\u002Ector(old, @new, new Guid(actionUidStr));
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            EntityActionEventArgs.t9B75soBXuTPEL86536s((object) actionUidStr, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951365792));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Установить пользователя для истории по объекту</summary>
    /// <param name="user">Пользователь</param>
    /// <param name="obj">Сущность</param>
    public static void SetUserForHistory(IUser user, IEntity obj)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_7;
          case 1:
            goto label_9;
          case 2:
            if (user == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
              continue;
            }
            object name = EntityActionEventArgs.fat1KIoBTH2LVBLW4egG(-1334993905 ^ -1334846803);
            // ISSUE: reference to a compiler-generated field
            Func<Dictionary<IEntity, IUser>> func = EntityActionEventArgs.\u003C\u003Ec.\u003C\u003E9__2_0;
            Func<Dictionary<IEntity, IUser>> val;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              EntityActionEventArgs.\u003C\u003Ec.\u003C\u003E9__2_0 = val = (Func<Dictionary<IEntity, IUser>>) (() => new Dictionary<IEntity, IUser>());
            }
            else
              goto label_13;
label_11:
            ContextVars.GetOrAdd<Dictionary<IEntity, IUser>>((string) name, val)[obj] = user;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 1;
            continue;
label_13:
            val = func;
            goto label_11;
          case 3:
            if (obj != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 2 : 0;
              continue;
            }
            goto label_2;
          default:
            goto label_12;
        }
      }
label_7:
      return;
label_9:
      return;
label_12:
      return;
label_2:;
    }

    /// <summary>Получить пользователя для истории</summary>
    /// <param name="obj">Сущность</param>
    /// <param name="user">Пользователь</param>
    /// <returns></returns>
    public static bool TryGetUserForHistory(IEntity obj, out IUser user)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            if (obj != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 1;
              continue;
            }
            break;
          case 3:
            goto label_5;
        }
        user = (IUser) null;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 3 : 3;
      }
label_5:
      return false;
label_6:
      return ContextVars.GetOrAdd<Dictionary<IEntity, IUser>>((string) EntityActionEventArgs.fat1KIoBTH2LVBLW4egG(1012087039 ^ 1011973725), (Func<Dictionary<IEntity, IUser>>) (() => new Dictionary<IEntity, IUser>())).TryGetValue(obj, out user);
    }

    /// <summary>
    /// Попытаться создать параметры события. Если не удалось найти объект или действие, то возвращается null.
    /// </summary>
    /// <param name="old">Старая сущность (до изменения)</param>
    /// <param name="new">Новая сущность (после изменения)</param>
    /// <param name="actionUid">Уникальный идентификатор действия</param>
    /// <returns>Параметры события или null.</returns>
    public static EntityActionEventArgs TryCreate(IEntity old, IEntity @new, Guid actionUid)
    {
      EntityActionEventArgs entityActionEventArgs1;
      switch (1)
      {
        case 1:
          try
          {
            EntityActionEventArgs entityActionEventArgs2 = new EntityActionEventArgs(old, @new, actionUid);
            int num = 5;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
              num = 1;
            while (true)
            {
              switch (num)
              {
                case 2:
                  entityActionEventArgs1 = (EntityActionEventArgs) null;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 1;
                  continue;
                case 3:
                  entityActionEventArgs1 = entityActionEventArgs2;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 0 : 0;
                  continue;
                case 4:
                  if (EntityActionEventArgs.TBBnSaoBk5L5Ve20dVjF((object) entityActionEventArgs2) == null)
                  {
                    num = 2;
                    continue;
                  }
                  goto case 3;
                case 5:
                  if (entityActionEventArgs2.Action != null)
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 4 : 0;
                    continue;
                  }
                  goto case 2;
                default:
                  goto label_1;
              }
            }
          }
          catch
          {
            int num = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
              num = 1;
            while (true)
            {
              switch (num)
              {
                case 1:
                  entityActionEventArgs1 = (EntityActionEventArgs) null;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
                  continue;
                default:
                  goto label_1;
              }
            }
          }
      }
label_1:
      return entityActionEventArgs1;
    }

    /// <summary>
    /// Попытаться создать параметры события. Если не удалось найти объект или действие, то возвращается null.
    /// </summary>
    /// <param name="old">Старая сущность (до изменения)</param>
    /// <param name="new">Новая сущность (после изменения)</param>
    /// <param name="actionUidStr">Уникальный идентификатор действия в виде строки</param>
    /// <returns>Параметры события или null.</returns>
    public static EntityActionEventArgs TryCreate(IEntity old, IEntity @new, string actionUidStr)
    {
      int num1 = 2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            EntityActionEventArgs.t9B75soBXuTPEL86536s((object) actionUidStr, EntityActionEventArgs.fat1KIoBTH2LVBLW4egG(-398663332 ^ -398546982));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 1;
            continue;
          default:
            goto label_10;
        }
      }
label_2:
      Guid actionUid;
      EntityActionEventArgs entityActionEventArgs;
      try
      {
        actionUid = new Guid(actionUidStr);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
          num2 = 0;
        switch (num2)
        {
          default:
            goto label_10;
        }
      }
      catch
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_11;
            default:
              entityActionEventArgs = (EntityActionEventArgs) null;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 1 : 1;
              continue;
          }
        }
      }
label_11:
      return entityActionEventArgs;
label_10:
      return (EntityActionEventArgs) EntityActionEventArgs.dSc5RYoBn5R5VLn0s2v6((object) old, (object) @new, actionUid);
    }

    /// <summary>Старая сущность (до изменения)</summary>
    [JsonIgnore]
    public virtual IEntity Old
    {
      get => this.oldEntity;
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
              this.oldEntity = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
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

    /// <summary>Новая сущность (после изменения)</summary>
    [JsonIgnore]
    public virtual IEntity New
    {
      get => this.newEntity;
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
              this.newEntity = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
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

    /// <summary>Время генерации события, задается в конструкторе</summary>
    public DateTime ActionDate
    {
      get => this.\u003CActionDate\u003Ek__BackingField;
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
              this.\u003CActionDate\u003Ek__BackingField = value;
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

    /// <summary>Пользователь, запустивший событие</summary>
    [JsonIgnore]
    public IUser ActionAuthor
    {
      get => this.\u003CActionAuthor\u003Ek__BackingField;
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
              this.\u003CActionAuthor\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
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
    /// Уникальный идентификатор единицы работы, в которой было сгенерировано данное событие.
    /// Для новых событий равно <c><see cref="F:System.Guid.Empty" /></c>
    /// </summary>
    public Guid UnitOfWorkUid
    {
      get => this._unitOfWorkUid;
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
              this._unitOfWorkUid = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
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
    /// Множественное событие сгруппировано по UnitOfWork, ActionType, ActionObjectUid
    /// </summary>
    public bool Multiple
    {
      get => this.\u003CMultiple\u003Ek__BackingField;
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
              this.\u003CMultiple\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 0;
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
    /// Получить словарь объектов по имени, которые могут быть использованы в шаблонах
    /// </summary>
    [JsonIgnore]
    public override IDictionary<string, object> ExtendedProperties
    {
      get
      {
        IDictionary<string, object> extendedProperties = base.ExtendedProperties;
        if (this.Old != null)
          extendedProperties[z2jc63fLkugS1X8Q9N.tE1kD1vbB(~289714581 ^ -289685456)] = (object) this.Old;
        else if (extendedProperties.ContainsKey(z2jc63fLkugS1X8Q9N.tE1kD1vbB(694673736 ^ -23604109 ^ -672089247)))
          extendedProperties.Remove(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917998801 >> 2 ^ 479468526));
        if (this.New != null)
          extendedProperties[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426456882 ^ 2009939514 ^ -583629282)] = (object) this.New;
        else if (extendedProperties.ContainsKey(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1199946765 ^ 1200093927)))
          extendedProperties.Remove(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882272376));
        if (this.ActionAuthor != null)
          extendedProperties[z2jc63fLkugS1X8Q9N.tE1kD1vbB(1199946765 ^ 1199913511)] = (object) this.ActionAuthor;
        else if (extendedProperties.ContainsKey(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1574260816 ^ 1574295162)))
          extendedProperties.Remove(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1839087379 - 334718690 ^ 2121194529));
        DateTime actionDate = this.ActionDate;
        extendedProperties[z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-397266137 ^ 397380140)] = (object) this.ActionDate;
        return extendedProperties;
      }
    }

    /// <summary>Получить дополнительные данные для сохранения в БД</summary>
    /// <returns>Массив байт с данными</returns>
    /// <remarks>Например, можно сериализовать некоторые параметры при помощи <see cref="T:EleWise.ELMA.Serialization.ClassSerializationHelper" /></remarks>
    public virtual byte[] GetAdditionalData() => (byte[]) null;

    /// <summary>Восстановить значения из дополнительных данных БД</summary>
    /// <param name="data">Массив байт с дополнительными данными</param>
    /// <remarks>Например, можно десериализовать некоторые параметры при помощи <see cref="T:EleWise.ELMA.Serialization.ClassSerializationHelper" /></remarks>
    public virtual void SetAdditionalData(byte[] data)
    {
    }

    public bool Equals(EntityActionEventArgs other)
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        DateTime actionDate;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 4:
            case 8:
            case 16:
            case 19:
            case 25:
            case 31:
            case 38:
            case 40:
            case 44:
            case 53:
              goto label_43;
            case 2:
              if (!base.Equals((object) other))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 1 : 1;
                continue;
              }
              goto case 50;
            case 3:
              if (EntityActionEventArgs.zYmRJEoBPMs4IBFKZ77M((object) this) != null)
              {
                num2 = 21;
                continue;
              }
              goto case 5;
            case 5:
            case 7:
              if (EntityActionEventArgs.zYmRJEoBPMs4IBFKZ77M((object) other) != null)
              {
                num2 = 13;
                continue;
              }
              goto label_43;
            case 6:
              if (!EntityActionEventArgs.xQqhyQoBebPCWrp2EZ5M((object) ((IIdentified) EntityActionEventArgs.NMhi73oBNghfXhR3QeP4((object) other)).GetId().ToString(), (object) this.ActionAuthor.GetId().ToString()))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 40 : 4;
                continue;
              }
              goto label_42;
            case 9:
              if (EntityActionEventArgs.tFCt2RoB2GpoXhGt3gHN(EntityActionEventArgs.mSBSiHoBOx1pVIWxjuAV((object) this)) != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 45 : 41;
                continue;
              }
              goto label_43;
            case 10:
              if (EntityActionEventArgs.mSBSiHoBOx1pVIWxjuAV((object) this) == null)
              {
                num2 = 22;
                continue;
              }
              goto case 39;
            case 11:
              if (EntityActionEventArgs.tFCt2RoB2GpoXhGt3gHN((object) this.ActionAuthor) == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 11 : 20;
                continue;
              }
              goto case 43;
            case 12:
              if (this.ActionAuthor == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
                continue;
              }
              goto case 51;
            case 13:
              if (EntityActionEventArgs.zYmRJEoBPMs4IBFKZ77M((object) this) == null)
              {
                num2 = 25;
                continue;
              }
              goto case 42;
            case 14:
              if (EntityActionEventArgs.zYmRJEoBPMs4IBFKZ77M((object) other) == null)
              {
                num2 = 18;
                continue;
              }
              goto case 30;
            case 17:
              if (EntityActionEventArgs.tFCt2RoB2GpoXhGt3gHN(EntityActionEventArgs.zYmRJEoBPMs4IBFKZ77M((object) this)) == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 55 : 39;
                continue;
              }
              goto case 5;
            case 18:
              if (EntityActionEventArgs.zYmRJEoBPMs4IBFKZ77M((object) this) == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 44 : 56;
                continue;
              }
              goto case 30;
            case 21:
              if (EntityActionEventArgs.tFCt2RoB2GpoXhGt3gHN((object) other.New) != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 7 : 7;
                continue;
              }
              goto case 17;
            case 22:
            case 32:
            case 34:
            case 49:
              if (EntityActionEventArgs.mSBSiHoBOx1pVIWxjuAV((object) other) != null)
                goto case 52;
              else
                goto label_47;
            case 23:
              if (EntityActionEventArgs.tFCt2RoB2GpoXhGt3gHN(EntityActionEventArgs.mSBSiHoBOx1pVIWxjuAV((object) this)) != null)
              {
                num2 = 32;
                continue;
              }
              goto case 14;
            case 24:
              if (EntityActionEventArgs.tFCt2RoB2GpoXhGt3gHN(EntityActionEventArgs.mSBSiHoBOx1pVIWxjuAV((object) other)) != null)
              {
                num2 = 9;
                continue;
              }
              goto label_43;
            case 26:
              if (((IIdentified) EntityActionEventArgs.zYmRJEoBPMs4IBFKZ77M((object) this)).GetId() != null)
              {
                num2 = 27;
                continue;
              }
              goto label_43;
            case 27:
              if (!EntityActionEventArgs.xQqhyQoBebPCWrp2EZ5M((object) EntityActionEventArgs.tFCt2RoB2GpoXhGt3gHN(EntityActionEventArgs.zYmRJEoBPMs4IBFKZ77M((object) other)).ToString(), (object) EntityActionEventArgs.tFCt2RoB2GpoXhGt3gHN(EntityActionEventArgs.zYmRJEoBPMs4IBFKZ77M((object) this)).ToString()))
              {
                num2 = 38;
                continue;
              }
              goto case 35;
            case 28:
              if (this.ActionAuthor != null)
                goto case 29;
              else
                goto label_59;
            case 29:
              if (((IIdentified) EntityActionEventArgs.NMhi73oBNghfXhR3QeP4((object) other)).GetId() != null)
              {
                num2 = 36;
                continue;
              }
              goto label_43;
            case 30:
              if (other.New != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 3 : 2;
                continue;
              }
              goto case 5;
            case 33:
              if (EntityActionEventArgs.mSBSiHoBOx1pVIWxjuAV((object) other) != null)
                goto case 10;
              else
                goto label_45;
            case 35:
            case 55:
            case 56:
              actionDate = this.ActionDate;
              num2 = 46;
              continue;
            case 36:
              if (this.ActionAuthor.GetId() != null)
              {
                num2 = 6;
                continue;
              }
              goto label_43;
            case 37:
              if (other.ActionAuthor == null)
              {
                num2 = 12;
                continue;
              }
              goto case 51;
            case 39:
              if (EntityActionEventArgs.tFCt2RoB2GpoXhGt3gHN(EntityActionEventArgs.mSBSiHoBOx1pVIWxjuAV((object) other)) != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 10 : 49;
                continue;
              }
              goto case 23;
            case 41:
              if (this.ActionAuthor == null)
                goto case 43;
              else
                goto label_22;
            case 42:
              if (other.New.GetId() != null)
                goto case 26;
              else
                goto label_57;
            case 43:
            case 54:
              if (EntityActionEventArgs.NMhi73oBNghfXhR3QeP4((object) other) != null)
                goto case 28;
              else
                goto label_6;
            case 45:
              if (!EntityActionEventArgs.xQqhyQoBebPCWrp2EZ5M((object) EntityActionEventArgs.tFCt2RoB2GpoXhGt3gHN(EntityActionEventArgs.mSBSiHoBOx1pVIWxjuAV((object) other)).ToString(), (object) EntityActionEventArgs.tFCt2RoB2GpoXhGt3gHN(EntityActionEventArgs.mSBSiHoBOx1pVIWxjuAV((object) this)).ToString()))
              {
                num2 = 53;
                continue;
              }
              goto case 14;
            case 46:
              if (!actionDate.Equals(EntityActionEventArgs.hQiDxeoB17Fru5JYuOxv((object) other)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 8 : 1;
                continue;
              }
              goto case 37;
            case 47:
              if (this.Old != null)
              {
                num2 = 33;
                continue;
              }
              goto case 14;
            case 48:
              if (EntityActionEventArgs.tFCt2RoB2GpoXhGt3gHN(EntityActionEventArgs.NMhi73oBNghfXhR3QeP4((object) other)) == null)
                goto case 11;
              else
                goto label_34;
            case 50:
              if (EntityActionEventArgs.mSBSiHoBOx1pVIWxjuAV((object) other) == null)
              {
                num2 = 47;
                continue;
              }
              goto case 33;
            case 51:
              if (other.ActionAuthor != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 41 : 8;
                continue;
              }
              goto case 43;
            case 52:
              if (EntityActionEventArgs.mSBSiHoBOx1pVIWxjuAV((object) this) == null)
              {
                num2 = 4;
                continue;
              }
              goto case 24;
            default:
              goto label_42;
          }
        }
label_6:
        num1 = 31;
        continue;
label_22:
        num1 = 48;
        continue;
label_34:
        num1 = 43;
        continue;
label_45:
        num1 = 34;
        continue;
label_47:
        num1 = 44;
        continue;
label_57:
        num1 = 16;
        continue;
label_59:
        num1 = 19;
      }
label_42:
      return EntityActionEventArgs.o8A79ToB3dtxTnt30rMK((object) other) == this.UnitOfWorkUid;
label_43:
      return false;
    }

    public override bool Equals(object obj)
    {
      int num = 2;
      EntityActionEventArgs other;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (other == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 2:
            other = obj as EntityActionEventArgs;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 1 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return false;
label_3:
      return this.Equals(other);
    }

    public override int GetHashCode() => ((((base.GetHashCode() * 397 ^ (EntityActionEventArgs.mSBSiHoBOx1pVIWxjuAV((object) this) == null || EntityActionEventArgs.tFCt2RoB2GpoXhGt3gHN(EntityActionEventArgs.mSBSiHoBOx1pVIWxjuAV((object) this)) == null ? 0 : EntityActionEventArgs.tFCt2RoB2GpoXhGt3gHN((object) this.Old).GetHashCode())) * 397 ^ (EntityActionEventArgs.zYmRJEoBPMs4IBFKZ77M((object) this) == null || EntityActionEventArgs.tFCt2RoB2GpoXhGt3gHN(EntityActionEventArgs.zYmRJEoBPMs4IBFKZ77M((object) this)) == null ? 0 : ((IIdentified) EntityActionEventArgs.zYmRJEoBPMs4IBFKZ77M((object) this)).GetId().GetHashCode())) * 397 ^ this.ActionDate.GetHashCode()) * 397 ^ (this.ActionAuthor == null || EntityActionEventArgs.tFCt2RoB2GpoXhGt3gHN((object) this.ActionAuthor) == null ? 0 : this.ActionAuthor.GetId().GetHashCode())) * 397 ^ this.UnitOfWorkUid.GetHashCode();

    /// <summary>
    /// Используем кэширование (эвенты создаются вручную, инъекцию не получится использовать)
    /// </summary>
    protected IAuthenticationService AuthenticationService
    {
      get
      {
        int num = 1;
        IAuthenticationService serviceNotNull;
        IAuthenticationService authenticationService;
        while (true)
        {
          switch (num)
          {
            case 1:
              authenticationService = this.authenticationService;
              if (authenticationService == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_6;
            default:
              this.authenticationService = serviceNotNull = Locator.GetServiceNotNull<IAuthenticationService>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 2 : 2;
              continue;
          }
        }
label_2:
        return authenticationService;
label_6:
        return serviceNotNull;
      }
    }

    /// <summary>Получить пользователя для истории</summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    protected virtual IUser GetUserForHistory(IEntity obj)
    {
      int num = 1;
      IUser user;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (EntityActionEventArgs.TryGetUserForHistory(obj, out user))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return user;
label_3:
      return this.AuthenticationService.GetCurrentUser<IUser>();
    }

    /// <summary>Ctor</summary>
    /// <param name="entity">Сущность связанная с действием</param>
    /// <param name="objectUid">Уникальный идентификатор объекта действия</param>
    /// <param name="actionUid">Уникальный идентификатор действия</param>
    protected EntityActionEventArgs(IEntity entity, Guid objectUid, Guid actionUid)
    {
      EntityActionEventArgs.psDvNvoBIsYeXsCBP5yk();
      this._unitOfWorkUid = Guid.Empty;
      // ISSUE: explicit constructor call
      base.\u002Ector(objectUid);
      int num = 6;
      IEnumerable<IAuditActionProvider> extensionPoints;
      EntityActionEventArgs entityActionEventArgs;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_9;
          case 1:
            this.ActionDate = DateTime.Now;
            num = 5;
            continue;
          case 2:
            this.oldEntity = entity;
            num = 3;
            continue;
          case 3:
            this.newEntity = entity;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 4 : 4;
            continue;
          case 4:
            extensionPoints = ((ComponentManager) EntityActionEventArgs.P8uiApoBi6E4p5c8YSSg()).GetExtensionPoints<IAuditActionProvider>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 7 : 1;
            continue;
          case 5:
            this.ActionAuthor = (IUser) (EntityActionEventArgs.mKTcKCoBRUJAPCIb9JCc((object) this, (object) entity) ?? EntityActionEventArgs.brFvAxoBqtVQ803bEyQx((object) this.AuthenticationService));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
            continue;
          case 6:
            entityActionEventArgs = this;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 2;
            continue;
          case 7:
            // ISSUE: reference to a compiler-generated method
            IEnumerable<IAuditAction> source = extensionPoints.Select<IAuditActionProvider, IAuditAction>((Func<IAuditActionProvider, IAuditAction>) (p => (IAuditAction) EntityActionEventArgs.\u003C\u003Ec__DisplayClass41_0.idjaGCCoBOjHX0vA9Xe3((object) p, (object) entityActionEventArgs.auditObject, actionUid)));
            // ISSUE: reference to a compiler-generated field
            Func<IAuditAction, bool> func = EntityActionEventArgs.\u003C\u003Ec.\u003C\u003E9__41_1;
            Func<IAuditAction, bool> predicate;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              EntityActionEventArgs.\u003C\u003Ec.\u003C\u003E9__41_1 = predicate = (Func<IAuditAction, bool>) (a => a != null);
            }
            else
              goto label_13;
label_11:
            this.auditAction = source.FirstOrDefault<IAuditAction>(predicate);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 1 : 1;
            continue;
label_13:
            predicate = func;
            goto label_11;
          default:
            goto label_2;
        }
      }
label_9:
      return;
label_2:;
    }

    internal static void psDvNvoBIsYeXsCBP5yk() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static Type jbEwgYoBVPxsbOLXfaT6(Type type) => type.GetTypeWithoutProxy();

    internal static void B17mBFoBSUJvaV8d5IHF(bool condition, [In] object obj1) => Contract.CheckArgument(condition, (string) obj1);

    internal static object P8uiApoBi6E4p5c8YSSg() => (object) ComponentManager.Current;

    internal static object mKTcKCoBRUJAPCIb9JCc([In] object obj0, [In] object obj1) => (object) ((EntityActionEventArgs) obj0).GetUserForHistory((IEntity) obj1);

    internal static object brFvAxoBqtVQ803bEyQx([In] object obj0) => (object) ((IAuthenticationService) obj0).GetCurrentUser();

    internal static DateTime gdmBCioBKeAG9QykiPHe() => DateTime.Now;

    internal static bool RMM7YxoBZok8TxhwHG23() => EntityActionEventArgs.YVAAoLoB8hvlN4if1DkF == null;

    internal static EntityActionEventArgs fM9aI9oBuCQepbYlAQ0A() => EntityActionEventArgs.YVAAoLoB8hvlN4if1DkF;

    internal static void t9B75soBXuTPEL86536s([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object fat1KIoBTH2LVBLW4egG(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object TBBnSaoBk5L5Ve20dVjF([In] object obj0) => (object) ((AuditEventArgs) obj0).Object;

    internal static object dSc5RYoBn5R5VLn0s2v6([In] object obj0, [In] object obj1, Guid actionUid) => (object) EntityActionEventArgs.TryCreate((IEntity) obj0, (IEntity) obj1, actionUid);

    internal static object mSBSiHoBOx1pVIWxjuAV([In] object obj0) => (object) ((EntityActionEventArgs) obj0).Old;

    internal static object tFCt2RoB2GpoXhGt3gHN([In] object obj0) => ((IIdentified) obj0).GetId();

    internal static bool xQqhyQoBebPCWrp2EZ5M([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static object zYmRJEoBPMs4IBFKZ77M([In] object obj0) => (object) ((EntityActionEventArgs) obj0).New;

    internal static DateTime hQiDxeoB17Fru5JYuOxv([In] object obj0) => ((EntityActionEventArgs) obj0).ActionDate;

    internal static object NMhi73oBNghfXhR3QeP4([In] object obj0) => (object) ((EntityActionEventArgs) obj0).ActionAuthor;

    internal static Guid o8A79ToB3dtxTnt30rMK([In] object obj0) => ((EntityActionEventArgs) obj0).UnitOfWorkUid;
  }
}
