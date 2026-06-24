// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Events.Audit.Impl.AuditManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Events.Audit.Impl
{
  /// <summary>Менеджер аудита</summary>
  [Service]
  public class AuditManager : IAuditManager
  {
    private static AuditManager aTYJoMGco1EAVXlYI9fW;

    /// <summary>Провайдеры объектов</summary>
    public IEnumerable<IAuditObjectProvider> ObjectProviders { get; set; }

    /// <summary>Провайдеры действий с объектами</summary>
    public IEnumerable<IAuditActionProvider> ActionProviders { get; set; }

    /// <summary>Получить список объектов</summary>
    /// <returns>Список объектов</returns>
    public IEnumerable<IAuditObject> GetObjects()
    {
      Contract.ServiceNotNull((object) this.ObjectProviders, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-688192331 - 435440695 ^ -1123899632));
      return this.ObjectProviders.SelectMany<IAuditObjectProvider, IAuditObject>((Func<IAuditObjectProvider, IEnumerable<IAuditObject>>) (p => p.GetObjects()));
    }

    /// <summary>Получить объект по уникальному идентификатору</summary>
    /// <param name="uid">Уникальный идентификатор объекта</param>
    /// <returns>ОБъект. Если не найден - null</returns>
    public IAuditObject GetObject(Guid uid)
    {
      int num1 = 3;
      IEnumerator<IAuditObjectProvider> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_3;
          case 2:
            enumerator = this.ObjectProviders.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 1 : 1;
            continue;
          case 3:
            Contract.ServiceNotNull((object) this.ObjectProviders, (string) AuditManager.hCUrdfGcG0vchK41qVbi(--1333735954 ^ 1333472636));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 2 : 2;
            continue;
          default:
            goto label_18;
        }
      }
label_3:
      IAuditObject auditObject1;
      try
      {
label_10:
        if (AuditManager.znhwu3GcEW0O7kOopS2r((object) enumerator))
          goto label_8;
        else
          goto label_11;
label_4:
        IAuditObject auditObject2;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_10;
            case 2:
              goto label_19;
            case 3:
              goto label_18;
            case 4:
              auditObject1 = auditObject2;
              num2 = 2;
              continue;
            case 5:
              goto label_8;
            default:
              if (auditObject2 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 4 : 2;
                continue;
              }
              goto label_10;
          }
        }
label_8:
        auditObject2 = enumerator.Current.GetObject(uid);
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
        {
          num2 = 0;
          goto label_4;
        }
        else
          goto label_4;
label_11:
        num2 = 3;
        goto label_4;
      }
      finally
      {
        if (enumerator != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_17;
              default:
                enumerator.Dispose();
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 1 : 1;
                continue;
            }
          }
        }
label_17:;
      }
label_19:
      return auditObject1;
label_18:
      return (IAuditObject) null;
    }

    /// <summary>Получить список действий объекта</summary>
    /// <param name="obj">Объект</param>
    /// <returns>Список действий объекта</returns>
    public IEnumerable<IAuditAction> GetActions(IAuditObject obj)
    {
      Contract.ServiceNotNull((object) this.ActionProviders, z2jc63fLkugS1X8Q9N.tE1kD1vbB(694673736 ^ -23604109 ^ -671864149));
      return this.ActionProviders.SelectMany<IAuditActionProvider, IAuditAction>((Func<IAuditActionProvider, IEnumerable<IAuditAction>>) (p => p.GetActions(obj)));
    }

    /// <summary>
    /// Получить действие объекта по уникальному идентификатору
    /// </summary>
    /// <param name="obj">Объект</param>
    /// <param name="uid">Уникальный идентификатор объекта</param>
    /// <returns>Действие. Если не найдено - null</returns>
    public IAuditAction GetAction(IAuditObject obj, Guid uid)
    {
      int num1 = 2;
      IEnumerator<IAuditActionProvider> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            enumerator = this.ActionProviders.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
            continue;
          case 2:
            AuditManager.wkMdvQGcfTtI5vot5FFq((object) this.ActionProviders, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1335262305));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 1;
            continue;
          case 3:
            goto label_3;
          default:
            goto label_5;
        }
      }
label_3:
      return (IAuditAction) null;
label_5:
      IAuditAction action;
      try
      {
label_9:
        if (AuditManager.znhwu3GcEW0O7kOopS2r((object) enumerator))
          goto label_13;
        else
          goto label_10;
label_7:
        IAuditAction auditAction;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
              if (auditAction != null)
              {
                num2 = 3;
                continue;
              }
              goto label_9;
            case 3:
              action = auditAction;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
              continue;
            case 4:
              goto label_13;
            case 5:
              goto label_9;
            default:
              goto label_4;
          }
        }
label_10:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 1 : 1;
        goto label_7;
label_13:
        auditAction = (IAuditAction) AuditManager.hBsisnGcQKOq7g7oYc3U((object) enumerator.Current, (object) obj, uid);
        num2 = 2;
        goto label_7;
      }
      finally
      {
        if (enumerator != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_19;
              default:
                enumerator.Dispose();
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 1 : 1;
                continue;
            }
          }
        }
label_19:;
      }
label_4:
      return action;
    }

    /// <summary>Получить действие по уникальному идентификатору</summary>
    /// <param name="uid"></param>
    /// <returns>Действие. Если не найдено - null</returns>
    public IAuditAction GetAction(Guid uid)
    {
      int num1 = 2;
      Guid uid1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            uid1 = uid;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 3 : 3;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 1;
            continue;
          case 3:
            goto label_4;
          default:
            goto label_3;
        }
      }
label_3:
      IAuditAction action;
      return action;
label_4:
      try
      {
        List<IAuditObject> list = this.GetObjects().ToList<IAuditObject>();
        List<IAuditAction> source = new List<IAuditAction>();
        List<IAuditObject>.Enumerator enumerator = list.GetEnumerator();
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
label_7:
              // ISSUE: reference to a compiler-generated method
              action = source.First<IAuditAction>((Func<IAuditAction, bool>) (aa => AuditManager.\u003C\u003Ec__DisplayClass12_0.AR4UpY8IUB7VUc9Ms8gn((object) aa) == uid1));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 1 : 1;
              continue;
            default:
              try
              {
label_12:
                if (enumerator.MoveNext())
                  goto label_14;
                else
                  goto label_13;
label_10:
                IAuditObject current;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_14;
                    case 2:
                      goto label_7;
                    case 3:
                      goto label_12;
                    default:
                      source.AddRange(this.GetActions(current));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 3 : 1;
                      continue;
                  }
                }
label_13:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 2 : 0;
                goto label_10;
label_14:
                current = enumerator.Current;
                num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0)
                {
                  num3 = 0;
                  goto label_10;
                }
                else
                  goto label_10;
              }
              finally
              {
                enumerator.Dispose();
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
          }
        }
      }
      catch
      {
        int num5 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
          num5 = 1;
        while (true)
        {
          switch (num5)
          {
            case 1:
              action = (IAuditAction) null;
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
      }
    }

    public AuditManager()
    {
      AuditManager.lcnd2AGcCfwnHsNkW5be();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object hCUrdfGcG0vchK41qVbi(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool znhwu3GcEW0O7kOopS2r([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static bool j4BNAbGcbnQqmltL6iiV() => AuditManager.aTYJoMGco1EAVXlYI9fW == null;

    internal static AuditManager Uvvn85Gch8OrAh0W9M0d() => AuditManager.aTYJoMGco1EAVXlYI9fW;

    internal static void wkMdvQGcfTtI5vot5FFq([In] object obj0, [In] object obj1) => Contract.ServiceNotNull(obj0, (string) obj1);

    internal static object hBsisnGcQKOq7g7oYc3U([In] object obj0, [In] object obj1, Guid uid) => (object) ((IAuditActionProvider) obj0).GetAction((IAuditObject) obj1, uid);

    internal static void lcnd2AGcCfwnHsNkW5be() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
