// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Events.EntityTypeEventArgs
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Events.Audit;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using Newtonsoft.Json;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Events
{
  /// <summary>Параметры события, связанного с типом сущности</summary>
  public class EntityTypeEventArgs : AuditEventArgs
  {
    private EntityMetadata _metadata;
    private static EntityTypeEventArgs xq5beVoB7itg6sXTcpgR;

    /// <summary>Ctor</summary>
    /// <param name="entityType">Тип сущности</param>
    public EntityTypeEventArgs(Type entityType)
    {
      EntityTypeEventArgs.QI0yRYoBmIOfFOoY1I4L();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
        num = 1;
      UidAttribute attribute;
      while (true)
      {
        switch (num)
        {
          case 1:
            Contract.ArgumentNotNull((object) entityType, (string) EntityTypeEventArgs.kSHM8foBy5btNJIwEbXj(2008901894 << 3 ^ -1108632668));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 3 : 3;
            continue;
          case 2:
            goto label_8;
          case 3:
            this.EntityType = entityType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 0;
            continue;
          case 4:
            goto label_3;
          case 5:
            if (attribute == null)
            {
              num = 2;
              continue;
            }
            goto case 6;
          case 6:
            this.auditObject = (IAuditObject) EntityTypeEventArgs.xkfKm1oBJkQ63AZwNOp1((object) Locator.GetServiceNotNull<EntityAuditObjectProvider>(), EntityTypeEventArgs.kMngdpoBMBH7W3fBmGaD((object) attribute));
            num = 4;
            continue;
          default:
            attribute = AttributeHelper<UidAttribute>.GetAttribute(entityType, true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 3 : 5;
            continue;
        }
      }
label_8:
      return;
label_3:;
    }

    /// <summary>Ctor</summary>
    /// <param name="entityTypeUid">Идентификатор типа сущности</param>
    public EntityTypeEventArgs(Guid entityTypeUid)
    {
      EntityTypeEventArgs.QI0yRYoBmIOfFOoY1I4L();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.auditObject = (IAuditObject) EntityTypeEventArgs.xkfKm1oBJkQ63AZwNOp1((object) Locator.GetServiceNotNull<EntityAuditObjectProvider>(), entityTypeUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
            continue;
          case 2:
            this.EntityType = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(entityTypeUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>Тип сущности, заполняется в конструкторе</summary>
    [JsonIgnore]
    public Type EntityType
    {
      get => this.\u003CEntityType\u003Ek__BackingField;
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
              this.\u003CEntityType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
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
    /// Метаданные, вычисляются на основе <see cref="P:EleWise.ELMA.Model.Events.EntityTypeEventArgs.EntityType" />
    /// </summary>
    [JsonIgnore]
    public EntityMetadata Metadata
    {
      get
      {
        int num = 1;
        EntityMetadata metadata1;
        EntityMetadata metadata2;
        while (true)
        {
          switch (num)
          {
            case 1:
              metadata2 = this._metadata;
              if (metadata2 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_6;
            default:
              this._metadata = metadata1 = (EntityMetadata) MetadataLoader.LoadMetadata(this.EntityType);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 1 : 2;
              continue;
          }
        }
label_2:
        return metadata2;
label_6:
        return metadata1;
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
        extendedProperties[z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124609100)] = (object) this.Metadata;
        return extendedProperties;
      }
    }

    public override bool Equals(object obj)
    {
      int num1 = 4;
      EntityTypeEventArgs entityTypeEventArgs;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
              goto label_7;
            case 3:
              if (entityTypeEventArgs != null)
              {
                num2 = 5;
                continue;
              }
              goto label_3;
            case 4:
              entityTypeEventArgs = obj as EntityTypeEventArgs;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 2 : 3;
              continue;
            case 5:
              goto label_4;
            default:
              goto label_6;
          }
        }
label_4:
        if (!base.Equals(obj))
          num1 = 2;
        else
          goto label_6;
      }
label_3:
      return false;
label_6:
      return EntityTypeEventArgs.oiwwHroB9NflGHG7PQ0l(entityTypeEventArgs.EntityType, this.EntityType);
label_7:
      return false;
    }

    public override int GetHashCode() => base.GetHashCode() * 397 ^ (!EntityTypeEventArgs.yhUrt4oBd81EpoF4CDBp(this.EntityType, (Type) null) ? 0 : this.EntityType.GetHashCode());

    internal static void QI0yRYoBmIOfFOoY1I4L() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object kSHM8foBy5btNJIwEbXj(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static Guid kMngdpoBMBH7W3fBmGaD([In] object obj0) => ((UidAttribute) obj0).Uid;

    internal static object xkfKm1oBJkQ63AZwNOp1([In] object obj0, Guid uid) => (object) ((EntityAuditObjectProvider) obj0).GetObject(uid);

    internal static bool BMMBY9oBxwtPHvkrXwmk() => EntityTypeEventArgs.xq5beVoB7itg6sXTcpgR == null;

    internal static EntityTypeEventArgs hmEbRHoB0ejc1qYjdFPh() => EntityTypeEventArgs.xq5beVoB7itg6sXTcpgR;

    internal static bool oiwwHroB9NflGHG7PQ0l([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static bool yhUrt4oBd81EpoF4CDBp([In] Type obj0, [In] Type obj1) => obj0 != obj1;
  }
}
