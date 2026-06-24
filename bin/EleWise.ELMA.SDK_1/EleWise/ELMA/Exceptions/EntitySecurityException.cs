// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Exceptions.EntitySecurityException
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Security;

namespace EleWise.ELMA.Exceptions
{
  /// <summary>Ошибка доступа к сущности</summary>
  [Serializable]
  public class EntitySecurityException : SecurityException
  {
    internal static EntitySecurityException lB36HIG5N4HBtRIiMhlG;

    /// <summary>Ctor</summary>
    public EntitySecurityException()
    {
      EntitySecurityException.ylIDixG5aD1d07u2Zv6y();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="message"></param>
    public EntitySecurityException(string message)
    {
      EntitySecurityException.ylIDixG5aD1d07u2Zv6y();
      // ISSUE: explicit constructor call
      base.\u002Ector(message);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="info"></param>
    /// <param name="context"></param>
    protected EntitySecurityException(SerializationInfo info, StreamingContext context)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Тип сущности</summary>
    public Guid TypeUid
    {
      get => this.\u003CTypeUid\u003Ek__BackingField;
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
              this.\u003CTypeUid\u003Ek__BackingField = value;
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

    /// <summary>Запрошенная привилегия</summary>
    public Guid PermissionId
    {
      get => this.\u003CPermissionId\u003Ek__BackingField;
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
              this.\u003CPermissionId\u003Ek__BackingField = value;
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

    /// <summary>Идентификатор сущности</summary>
    public long EntityId
    {
      get => this.\u003CEntityId\u003Ek__BackingField;
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
              this.\u003CEntityId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
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
    /// Права доступа пользователей, которые могут дать запрошенную привилегию
    /// </summary>
    public List<Guid> Permissions { get; set; }

    internal static void ylIDixG5aD1d07u2Zv6y() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool sVsx7DG53LrbVAbam2b9() => EntitySecurityException.lB36HIG5N4HBtRIiMhlG == null;

    internal static EntitySecurityException FiJwa8G5pt1yUn1fXMGE() => EntitySecurityException.lB36HIG5N4HBtRIiMhlG;
  }
}
