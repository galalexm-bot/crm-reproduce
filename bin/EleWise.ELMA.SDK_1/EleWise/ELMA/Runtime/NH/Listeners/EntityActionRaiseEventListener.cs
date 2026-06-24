// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.Listeners.EntityActionRaiseEventListener
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Event;
using NHibernate.Persister.Entity;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.NH.Listeners
{
  /// <summary>
  /// Прослушиватель событий изменения для обеспечения хранения истории
  /// </summary>
  [Component]
  public class EntityActionRaiseEventListener : PostFlushEventListener
  {
    internal static EntityActionRaiseEventListener rOpcLeW7IDQH3gFmSHEV;

    /// <summary>Обработчик действий с сущностью</summary>
    public IEntityActionHandler EntityActionHandler
    {
      get => this.\u003CEntityActionHandler\u003Ek__BackingField;
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
              this.\u003CEntityActionHandler\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
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

    /// <summary>После вставки</summary>
    /// <param name="event">Параметры события</param>
    public override void OnPostInsert(PostInsertEvent @event)
    {
      int num = 4;
      EntityActionEventArgs entityActionEventArgs;
      IEntity entity;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_7;
          case 2:
            goto label_9;
          case 3:
            if (entity != null)
            {
              num = 5;
              continue;
            }
            goto label_2;
          case 4:
            entity = EntityActionRaiseEventListener.ki75mOW7i8fcQIEgmQEU((object) @event) as IEntity;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 3;
            continue;
          case 5:
            entityActionEventArgs = (EntityActionEventArgs) EntityActionRaiseEventListener.nPAXKAW7RGfoU4brVUoF((object) null, (object) entity, DefaultEntityActions.CreateGuid);
            num = 6;
            continue;
          case 6:
            if (entityActionEventArgs != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
              continue;
            }
            goto label_12;
          default:
            EntityActionRaiseEventListener.XL1dShW7qf5kYTEuH9wx((object) this.EntityActionHandler, (object) entityActionEventArgs);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 1;
            continue;
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

    /// <summary>После обновления</summary>
    /// <param name="event">Параметры события</param>
    public override void OnPostUpdate(PostUpdateEvent @event)
    {
      int num1 = 11;
      while (true)
      {
        int num2 = num1;
        int index;
        string str;
        IEntity source1;
        IEntity source2;
        PropertyInfo propertyInfo;
        EditEntityActionEventArgs entityActionEventArgs;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 2:
              if (index < EntityActionRaiseEventListener.jg7wZNW7K9HVKFJS9C6S((object) @event).Length)
              {
                num2 = 14;
                continue;
              }
              goto case 9;
            case 3:
              goto label_13;
            case 4:
              if (EntityActionRaiseEventListener.jg7wZNW7K9HVKFJS9C6S((object) @event) == null)
              {
                num2 = 15;
                continue;
              }
              goto case 18;
            case 5:
              try
              {
                propertyInfo.SetValue((object) source2, EntityActionRaiseEventListener.jg7wZNW7K9HVKFJS9C6S((object) @event)[index], (object[]) null);
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
                  num3 = 0;
                switch (num3)
                {
                  default:
                    goto label_18;
                }
              }
              catch (Exception ex)
              {
                int num4 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
                  num4 = 1;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      ((ILogger) EntityActionRaiseEventListener.uKp21CW7P1Q3j5IOPd44()).Error(EntityActionRaiseEventListener.TE0LOHW71Gk3mTrH1239((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(322893104 - -1992822529 ^ -1979374615), (object) str, (object) source2.GetType().FullName), ex);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_18;
                  }
                }
              }
            case 6:
              source2 = (IEntity) EntityActionRaiseEventListener.psRJm5W7nWHeafsc6Ygt(source1.CastAsRealType<IEntity>().GetType().GetTypeWithoutProxy());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 19 : 9;
              continue;
            case 7:
              goto label_39;
            case 8:
              if (!(propertyInfo != (PropertyInfo) null))
              {
                num2 = 22;
                continue;
              }
              goto case 16;
            case 9:
              entityActionEventArgs = (EditEntityActionEventArgs) EntityActionRaiseEventListener.EEqwvXW7NONjhPDUM08j((object) source2, (object) source1, EntityActionRaiseEventListener.JFbIWNW7OWbiQnCn3fj2((object) @event.Persister));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 12 : 17;
              continue;
            case 10:
              if (source1 != null)
              {
                num2 = 4;
                continue;
              }
              goto label_19;
            case 11:
              source1 = EntityActionRaiseEventListener.ki75mOW7i8fcQIEgmQEU((object) @event) as IEntity;
              num2 = 10;
              continue;
            case 12:
            case 14:
              str = (string) EntityActionRaiseEventListener.JFbIWNW7OWbiQnCn3fj2(EntityActionRaiseEventListener.WnmbduW7XhSB1Ceevi4M((object) @event))[index];
              num2 = 20;
              continue;
            case 13:
              goto label_4;
            case 15:
              goto label_17;
            case 16:
              if (EntityActionRaiseEventListener.uZatRIW7eEkwHwTcFerM((object) propertyInfo))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 5 : 4;
                continue;
              }
              goto case 21;
            case 17:
              if (entityActionEventArgs != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
                continue;
              }
              goto label_29;
            case 18:
              if (@event.OldState.Length != 0)
              {
                if (EntityActionRaiseEventListener.rvYgIbW7kHaaxU2AwVBk((object) @event.Session, EntityActionRaiseEventListener.WnmbduW7XhSB1Ceevi4M((object) @event), EntityActionRaiseEventListener.jg7wZNW7K9HVKFJS9C6S((object) @event), EntityActionRaiseEventListener.q8xxO6W7TRCwhwaUSPJ4((object) @event), EntityActionRaiseEventListener.ki75mOW7i8fcQIEgmQEU((object) @event)))
                {
                  num2 = 6;
                  continue;
                }
                goto label_36;
              }
              else
              {
                num2 = 3;
                continue;
              }
            case 19:
              index = 0;
              num2 = 2;
              continue;
            case 20:
              propertyInfo = (PropertyInfo) EntityActionRaiseEventListener.tn29KTW720KDAxDiM3MD(source2.CastAsRealType<IEntity>().GetType(), (object) str);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 2 : 8;
              continue;
            case 21:
            case 22:
label_18:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 1;
              continue;
            default:
              goto label_33;
          }
        }
label_33:
        EntityActionRaiseEventListener.XL1dShW7qf5kYTEuH9wx((object) this.EntityActionHandler, (object) entityActionEventArgs);
        num1 = 13;
      }
label_13:
      return;
label_39:
      return;
label_4:
      return;
label_17:
      return;
label_29:
      return;
label_36:
      return;
label_19:;
    }

    /// <summary>После удаления</summary>
    /// <param name="event">Параметры события</param>
    public override void OnPostDelete(PostDeleteEvent @event)
    {
      int num = 2;
      IEntity old;
      EntityActionEventArgs entityActionEventArgs;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            if (old == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 0;
              continue;
            }
            entityActionEventArgs = EntityActionEventArgs.TryCreate(old, (IEntity) null, DefaultEntityActions.DeleteGuid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 3 : 4;
            continue;
          case 2:
            old = EntityActionRaiseEventListener.ki75mOW7i8fcQIEgmQEU((object) @event) as IEntity;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_7;
          case 4:
            if (entityActionEventArgs != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 1 : 5;
              continue;
            }
            goto label_12;
          case 5:
            EntityActionRaiseEventListener.XL1dShW7qf5kYTEuH9wx((object) this.EntityActionHandler, (object) entityActionEventArgs);
            num = 3;
            continue;
          default:
            goto label_11;
        }
      }
label_2:
      return;
label_7:
      return;
label_11:
      return;
label_12:;
    }

    public EntityActionRaiseEventListener()
    {
      EntityActionRaiseEventListener.MG7HYLW731hynOcHR7ml();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool XrwjRsW7VSHhfy7DgWKG() => EntityActionRaiseEventListener.rOpcLeW7IDQH3gFmSHEV == null;

    internal static EntityActionRaiseEventListener ywrDunW7S1KGQ2wyZ9AU() => EntityActionRaiseEventListener.rOpcLeW7IDQH3gFmSHEV;

    internal static object ki75mOW7i8fcQIEgmQEU([In] object obj0) => ((AbstractPostDatabaseOperationEvent) obj0).Entity;

    internal static object nPAXKAW7RGfoU4brVUoF([In] object obj0, [In] object obj1, Guid actionUid) => (object) EntityActionEventArgs.TryCreate((IEntity) obj0, (IEntity) obj1, actionUid);

    internal static void XL1dShW7qf5kYTEuH9wx([In] object obj0, [In] object obj1) => ((IEntityActionHandler) obj0).ActionExecuted((EntityActionEventArgs) obj1);

    internal static object jg7wZNW7K9HVKFJS9C6S([In] object obj0) => (object) ((PostUpdateEvent) obj0).OldState;

    internal static object WnmbduW7XhSB1Ceevi4M([In] object obj0) => (object) ((AbstractPostDatabaseOperationEvent) obj0).Persister;

    internal static object q8xxO6W7TRCwhwaUSPJ4([In] object obj0) => (object) ((PostUpdateEvent) obj0).State;

    internal static bool rvYgIbW7kHaaxU2AwVBk(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3,
      [In] object obj4)
    {
      return ((ISession) obj0).IsDirtyEntity((IEntityPersister) obj1, (object[]) obj2, (object[]) obj3, obj4);
    }

    internal static object psRJm5W7nWHeafsc6Ygt(Type t) => InterfaceActivator.Create(t);

    internal static object JFbIWNW7OWbiQnCn3fj2([In] object obj0) => (object) ((IEntityPersister) obj0).PropertyNames;

    internal static object tn29KTW720KDAxDiM3MD(Type type, [In] object obj1) => (object) type.GetReflectionProperty((string) obj1);

    internal static bool uZatRIW7eEkwHwTcFerM([In] object obj0) => ((PropertyInfo) obj0).CanWrite;

    internal static object uKp21CW7P1Q3j5IOPd44() => (object) Logger.Log;

    internal static object TE0LOHW71Gk3mTrH1239([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object EEqwvXW7NONjhPDUM08j([In] object obj0, [In] object obj1, [In] object obj2) => (object) EditEntityActionEventArgs.TryCreate((IEntity) obj0, (IEntity) obj1, (string[]) obj2);

    internal static void MG7HYLW731hynOcHR7ml() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
