// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Entities.EntityInfoBase
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web.Script.Serialization;

namespace EleWise.ELMA.Model.Entities
{
  /// <summary>
  /// Базовый класс для определения информации об одной, либо нескольких сущностях
  /// </summary>
  [Component]
  [Serializable]
  public abstract class EntityInfoBase : IXsiType
  {
    internal static EntityInfoBase V2yof3h8LhGNhjFsWv1m;

    public string Serialize()
    {
      int num = 5;
      EntityInfo entityInfo;
      EntityListInfo entityListInfo;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_7;
          case 2:
            if (entityInfo != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 1 : 0;
              continue;
            }
            goto label_6;
          case 3:
            if (entityListInfo == null)
            {
              num = 2;
              continue;
            }
            goto label_8;
          case 4:
            entityInfo = this as EntityInfo;
            num = 3;
            continue;
          case 5:
            entityListInfo = this as EntityListInfo;
            num = 4;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return "";
label_7:
      return (string) EntityInfoBase.r0oi83h8cerJErkuPA6a((object) new JsonSerializer(), (object) entityInfo);
label_8:
      return (string) EntityInfoBase.r0oi83h8cerJErkuPA6a((object) new JsonSerializer(), EntityInfoBase.GNrqmhh8zWdtdfbeEHjX((object) entityListInfo.Items));
    }

    public static EntityInfoBase Deserialize(string serialized)
    {
      int num1 = 2;
      EntityListInfo entityListInfo;
      while (true)
      {
        int num2 = num1;
        List<EntityInfo> list;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (EntityInfoBase.m6XjgHhZWHZ6lQpd509H((object) serialized, EntityInfoBase.DgqyoUhZB3gsqslRxmiK(1052221104 - 768835541 ^ 283437113)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 2:
              if (!EntityInfoBase.JZ80FJhZFXVgx9t9n6of((object) serialized))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 1 : 1;
                continue;
              }
              goto label_8;
            case 3:
              goto label_3;
            case 4:
              list = ((IEnumerable<EntityInfo>) new JsonSerializer().Deserialize<EntityInfo[]>(serialized)).ToList<EntityInfo>();
              num2 = 7;
              continue;
            case 5:
              goto label_8;
            case 6:
              entityListInfo.Items.AddRange((IEnumerable<EntityInfo>) list);
              num2 = 3;
              continue;
            case 7:
              goto label_12;
            default:
              entityListInfo = new EntityListInfo();
              num2 = 4;
              continue;
          }
        }
label_12:
        if (list != null)
          num1 = 6;
        else
          break;
      }
label_3:
      return (EntityInfoBase) entityListInfo;
label_4:
      return (EntityInfoBase) new JsonSerializer().Deserialize<EntityInfo>(serialized);
label_8:
      return (EntityInfoBase) null;
    }

    protected EntityInfoBase()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object r0oi83h8cerJErkuPA6a([In] object obj0, [In] object obj1) => (object) ((JavaScriptSerializer) obj0).Serialize(obj1);

    internal static object GNrqmhh8zWdtdfbeEHjX([In] object obj0) => (object) ((List<EntityInfo>) obj0).ToArray();

    internal static bool qbNWCIh8UcpRCNm0Y1T0() => EntityInfoBase.V2yof3h8LhGNhjFsWv1m == null;

    internal static EntityInfoBase UX3VyEh8silk16ZQdm6y() => EntityInfoBase.V2yof3h8LhGNhjFsWv1m;

    internal static bool JZ80FJhZFXVgx9t9n6of([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object DgqyoUhZB3gsqslRxmiK(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool m6XjgHhZWHZ6lQpd509H([In] object obj0, [In] object obj1) => ((string) obj0).StartsWith((string) obj1);
  }
}
