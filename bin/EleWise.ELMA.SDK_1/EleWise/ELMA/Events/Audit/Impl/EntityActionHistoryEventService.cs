// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Events.Audit.Impl.EntityActionHistoryEventService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.Events.Audit.Impl
{
  /// <summary>
  /// Сервис по умолчанию для управления событиями истории действий с объектом
  /// </summary>
  [Service]
  public class EntityActionHistoryEventService : IEntityActionHistoryEventService
  {
    private readonly Dictionary<Guid, Type> _typesByUid;
    private bool _initialized;
    private readonly object _lock;
    private static EntityActionHistoryEventService bLw1jvGcwkL6npB20j8c;

    /// <summary>Логгер</summary>
    public ILogger Logger
    {
      get => this.\u003CLogger\u003Ek__BackingField;
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
              this.\u003CLogger\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
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
    /// Initializes a new instance of the <see cref="T:System.Object" /> class.
    /// </summary>
    public EntityActionHistoryEventService()
    {
      EntityActionHistoryEventService.nalWVTGcHhciifuIeMGC();
      this._lock = new object();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 3;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this._initialized = false;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.Logger = (ILogger) EntityActionHistoryEventService.cTM3x8GcAgcOZwS5Ca0M();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 1 : 1;
            continue;
          default:
            this._typesByUid = new Dictionary<Guid, Type>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 2;
            continue;
        }
      }
label_3:;
    }

    public void Initialize()
    {
      int num1 = 1;
      object obj;
      bool lockTaken;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_2;
          case 1:
            if (this._initialized)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
              continue;
            }
            obj = this._lock;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 2 : 2;
            continue;
          case 2:
            lockTaken = false;
            num1 = 3;
            continue;
          case 3:
            goto label_6;
          case 4:
            goto label_45;
          default:
            goto label_31;
        }
      }
label_2:
      return;
label_45:
      return;
label_31:
      return;
label_6:
      try
      {
        Monitor.Enter(obj, ref lockTaken);
        int num2 = 5;
        IEnumerator<Type> enumerator;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_43;
            case 1:
              try
              {
label_15:
                if (EntityActionHistoryEventService.aWWFMSGcMKTB2bgCnJZ6((object) enumerator))
                  goto label_22;
                else
                  goto label_16;
label_9:
                Type current;
                UidAttribute attribute;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      attribute = AttributeHelper<UidAttribute>.GetAttribute(current, false);
                      num3 = 2;
                      continue;
                    case 2:
                      if (attribute != null)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 6;
                        continue;
                      }
                      goto label_19;
                    case 3:
                      goto label_22;
                    case 4:
                      goto label_19;
                    case 5:
                      goto label_24;
                    case 6:
                      if (!this._typesByUid.ContainsKey(EntityActionHistoryEventService.Ng4dQIGcmxoro7IXDN1b((object) attribute)))
                      {
                        num3 = 9;
                        continue;
                      }
                      goto label_24;
                    case 7:
                      goto label_34;
                    case 8:
                      goto label_15;
                    case 9:
                      // ISSUE: type reference
                      // ISSUE: type reference
                      // ISSUE: type reference
                      if (!EntityActionHistoryEventService.UJoTqmGcydfd5GPwVbab((object) current.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, (Binder) null, new Type[3]
                      {
                        EntityActionHistoryEventService.s01MLNGc0u3ML6yQxKAp(__typeref (IEntity)),
                        EntityActionHistoryEventService.s01MLNGc0u3ML6yQxKAp(__typeref (Guid)),
                        EntityActionHistoryEventService.s01MLNGc0u3ML6yQxKAp(__typeref (Guid))
                      }, (ParameterModifier[]) null), (object) null))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 10 : 6;
                        continue;
                      }
                      goto label_10;
                    case 10:
                      this._typesByUid.Add(EntityActionHistoryEventService.Ng4dQIGcmxoro7IXDN1b((object) attribute), current);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 3 : 8;
                      continue;
                    case 11:
                      goto label_10;
                    default:
                      if (!(current == (Type) null))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 1 : 1;
                        continue;
                      }
                      goto label_15;
                  }
                }
label_10:
                // ISSUE: type reference
                // ISSUE: type reference
                // ISSUE: type reference
                throw new InitializationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1409163704), (object) current.FullName, (object) EntityActionHistoryEventService.s01MLNGc0u3ML6yQxKAp(__typeref (IEntity)).FullName, (object) EntityActionHistoryEventService.s01MLNGc0u3ML6yQxKAp(__typeref (Guid)).FullName, (object) EntityActionHistoryEventService.s01MLNGc0u3ML6yQxKAp(__typeref (Guid)).FullName));
label_19:
                // ISSUE: type reference
                throw new InitializationException(EleWise.ELMA.SR.T((string) EntityActionHistoryEventService.flQeoeGcx0qWAXc1lEuI(-1998538950 ^ -1998280512), (object) current.FullName, (object) EntityActionHistoryEventService.s01MLNGc0u3ML6yQxKAp(__typeref (UidAttribute)).FullName));
label_24:
                // ISSUE: type reference
                throw new InitializationException(EleWise.ELMA.SR.T((string) EntityActionHistoryEventService.flQeoeGcx0qWAXc1lEuI(1033719030 - 2012070891 ^ -978605673), (object) current.FullName, (object) EntityActionHistoryEventService.s01MLNGc0u3ML6yQxKAp(__typeref (UidAttribute)).FullName));
label_16:
                num3 = 7;
                goto label_9;
label_22:
                current = enumerator.Current;
                num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
                {
                  num3 = 0;
                  goto label_9;
                }
                else
                  goto label_9;
              }
              finally
              {
                if (enumerator != null)
                {
                  int num4 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0)
                    num4 = 0;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                        EntityActionHistoryEventService.w14UG9GcJepHKn45A11q((object) enumerator);
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_33;
                    }
                  }
                }
label_33:;
              }
            case 2:
              enumerator = ((ComponentManager) EntityActionHistoryEventService.HoF81sGc7cwyaYAy4iEN()).GetExtensionPointTypes<IEntityHistoryEventArgs>().GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 1 : 0;
              continue;
            case 3:
label_34:
              this._initialized = true;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
              continue;
            case 4:
              goto label_39;
            case 5:
              if (this._initialized)
              {
                num2 = 4;
                continue;
              }
              goto case 2;
            default:
              goto label_38;
          }
        }
label_43:
        return;
label_39:
        return;
label_38:;
      }
      finally
      {
        int num5;
        if (!lockTaken)
          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
        else
          goto label_44;
label_42:
        switch (num5)
        {
          case 1:
            break;
          default:
        }
label_44:
        Monitor.Exit(obj);
        num5 = 2;
        goto label_42;
      }
    }

    public TEventArgs Create<TEventArgs>(
      IEntity entity,
      Guid objectUid,
      Guid actionUid,
      Guid eventArgsUid)
      where TEventArgs : class, IEntityHistoryEventArgs
    {
      this.Initialize();
      Type eventArgsType = this.GetEventArgsType(eventArgsUid);
      if (eventArgsType == (Type) null)
        return default (TEventArgs);
      return (TEventArgs) Activator.CreateInstance(eventArgsType, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, (Binder) null, new object[3]
      {
        (object) entity,
        (object) objectUid,
        (object) actionUid
      }, (CultureInfo) null);
    }

    public Type GetEventArgsType(Guid eventArgsUid)
    {
      int num = 1;
      Type eventArgsType;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Initialize();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          default:
            this._typesByUid.TryGetValue(eventArgsUid, out eventArgsType);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 2 : 2;
            continue;
        }
      }
label_4:
      return eventArgsType;
    }

    internal static bool iPY3GmGc4nMiC5EY0R42() => EntityActionHistoryEventService.bLw1jvGcwkL6npB20j8c == null;

    internal static EntityActionHistoryEventService gTSfuyGc6uAlIHQrahSr() => EntityActionHistoryEventService.bLw1jvGcwkL6npB20j8c;

    internal static void nalWVTGcHhciifuIeMGC() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object cTM3x8GcAgcOZwS5Ca0M() => (object) NullLogger.Instance;

    internal static object HoF81sGc7cwyaYAy4iEN() => (object) ComponentManager.Current;

    internal static object flQeoeGcx0qWAXc1lEuI(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static Type s01MLNGc0u3ML6yQxKAp([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static Guid Ng4dQIGcmxoro7IXDN1b([In] object obj0) => ((UidAttribute) obj0).Uid;

    internal static bool UJoTqmGcydfd5GPwVbab([In] object obj0, [In] object obj1) => (ConstructorInfo) obj0 == (ConstructorInfo) obj1;

    internal static bool aWWFMSGcMKTB2bgCnJZ6([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void w14UG9GcJepHKn45A11q([In] object obj0) => ((IDisposable) obj0).Dispose();
  }
}
