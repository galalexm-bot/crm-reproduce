// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.EntityPropertyMetadata
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Mappings;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Метаданные свойства сущности</summary>
  [ClassMap(typeof (EntityPropertyMetadataMap))]
  [EleWise.ELMA.Model.Attributes.DisplayName(typeof (EntityPropertyMetadata_Resources), "DisplayName")]
  [MetadataType(typeof (EntityMetadata))]
  [Entity("MD_ENTITY_PROPERTY")]
  [DataContract]
  [EleWise.ELMA.Model.Attributes.Uid("{D5B79720-FBBF-489B-9AA6-49E1C5DA50E4}")]
  [Serializable]
  public class EntityPropertyMetadata : 
    PropertyMetadata,
    IEntityPropertyMetadata,
    IPropertyMetadata,
    INamedMetadata,
    IOrderedMetadata,
    IMetadata,
    IXsiType,
    IValidatableMetadata
  {
    public const string UID_S = "{D5B79720-FBBF-489B-9AA6-49E1C5DA50E4}";
    private static EntityPropertyMetadata noFdjybmjw4SJfjJBXHI;

    /// <summary>Метаданные класса, являющегося владельцем свойства</summary>
    [EleWise.ELMA.Model.Attributes.Uid("{787F7299-01F7-4075-9BDB-6AA1039FEF51}")]
    [EntitySettings(RelationType = RelationType.OneToOne, FieldName = "OwnerId")]
    [XmlIgnore]
    [EntityProperty]
    [Property("{72ED98CA-F260-4671-9BCD-FF1D80235F47}", "{C40FD1D3-F5D9-4323-9E51-42EBFA77E6DC}")]
    public virtual EntityMetadata Owner
    {
      get => this.\u003COwner\u003Ek__BackingField;
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
              this.\u003COwner\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
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

    /// <summary>Участвует в быстром поиске</summary>
    [EleWise.ELMA.Model.Attributes.Uid("{CFA9D44F-A49E-42D5-BA31-70D4A31B2EB8}")]
    [Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
    [XmlElement("InFastSearch")]
    [EntityProperty]
    [BoolSettings(FieldName = "InFastSearch")]
    [DataMember]
    [DefaultValue(false)]
    public virtual bool InFastSearch
    {
      get => this.\u003CInFastSearch\u003Ek__BackingField;
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
              this.\u003CInFastSearch\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
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
    /// Показывать в таблице TODO Убрать после разбиения на модули
    /// </summary>
    [DefaultValue(false)]
    [DataMember]
    [EntityProperty]
    [EleWise.ELMA.Model.Attributes.Uid("{B7D9B398-4053-44F9-B85A-753A3A56A612}")]
    [XmlElement("ShowInTable")]
    [BoolSettings(FieldName = "ShowInTable")]
    [Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
    public virtual bool ShowInTable
    {
      get => this.\u003CShowInTable\u003Ek__BackingField;
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
              this.\u003CShowInTable\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
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

    /// <summary>Входное</summary>
    [DefaultValue(false)]
    [XmlElement("Input")]
    [BoolSettings(FieldName = "Input")]
    [Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
    [EleWise.ELMA.Model.Attributes.Uid("{2C8A643A-B745-407A-95A5-482D6A00E205}")]
    [EntityProperty]
    public virtual bool Input
    {
      get => this.\u003CInput\u003Ek__BackingField;
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
              this.\u003CInput\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
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

    /// <summary>Выходное</summary>
    [EntityProperty]
    [DefaultValue(false)]
    [BoolSettings(FieldName = "Output")]
    [Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
    [EleWise.ELMA.Model.Attributes.Uid("{C2CF1D4F-9E1F-4FBA-9B1D-8341960F4794}")]
    [XmlElement("Output")]
    public virtual bool Output
    {
      get => this.\u003COutput\u003Ek__BackingField;
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
              this.\u003COutput\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
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
    /// Номер таблицы, в которой находится свойство (если свойства сущности хранятся в нескольких таблицах)
    /// </summary>
    [EntityProperty]
    [PublicationBehaviour(PublicationType.Restart)]
    [DefaultValue(0)]
    [Int32Settings(FieldName = "TableNumber")]
    [EleWise.ELMA.Model.Attributes.Uid("{4C3A170A-7EBC-4204-AFC6-1F6633FB5EFA}")]
    [Property("{C1D5FC22-B8ED-4CFA-8029-82EC19E17B7F}")]
    [XmlElement("TableNumber")]
    public virtual int TableNumber
    {
      get => this.\u003CTableNumber\u003Ek__BackingField;
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
              this.\u003CTableNumber\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
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

    /// <summary>Использовать ли в фильтре</summary>
    [XmlElement("Filterable")]
    [EleWise.ELMA.Model.Attributes.Uid("{4A355272-B6F2-46D8-ACCA-2AB0E27453D9}")]
    [PublicationBehaviour(typeof (EntityPropertyFilterableBehaviour))]
    [DataMember]
    [Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
    [BoolSettings(FieldName = "Filterable")]
    [EntityProperty]
    [DefaultValue(false)]
    public virtual bool Filterable
    {
      get => this.\u003CFilterable\u003Ek__BackingField;
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
              this.\u003CFilterable\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
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
    /// Имя таблицы для связи N-N. Используется только для хранения в БД для выборок.
    /// </summary>
    [EntityProperty]
    [DefaultValue(null)]
    [EleWise.ELMA.Model.Attributes.Uid("{2344839C-8F49-4B60-B0D1-4D1E4E9B03FA}")]
    [XmlIgnore]
    [StringSettings(MaxValueString = "2000", FieldName = "RelationTableName")]
    [Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
    public virtual string RelationTableName
    {
      get
      {
        int num1 = 2;
        EntitySettings settings;
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
                settings = this.Settings as EntitySettings;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 1 : 1;
                continue;
              case 3:
                goto label_6;
              default:
                goto label_5;
            }
          }
label_3:
          if (settings != null)
            num1 = 3;
          else
            break;
        }
label_5:
        return (string) null;
label_6:
        return (string) EntityPropertyMetadata.voWDyHbmUyUZQRGVUCGV((object) settings);
      }
      set
      {
      }
    }

    [XmlIgnore]
    public virtual SimpleTypeSettings SimpleTypeSettings => (SimpleTypeSettings) this.Settings;

    /// <summary>
    /// Получить имя таблицы, в которой хранятся значения для данного свойства
    /// </summary>
    /// <param name="entityMetadata">Метаданные сущности</param>
    /// <returns>Имя таблицы</returns>
    public virtual string GetTableName(EntityMetadata entityMetadata) => EntityPropertyMetadata.GetTableName((string) EntityPropertyMetadata.Ie9timbmshZ84hZF4KTP((object) entityMetadata), EntityPropertyMetadata.wmpkhBbmcSgRqB20y1nL((object) this));

    /// <summary>
    /// Получить имя таблицы, в которой хранятся значения для данного свойства
    /// </summary>
    /// <param name="tableName"></param>
    /// <param name="tableNumber"></param>
    /// <returns></returns>
    public static string GetTableName(string tableName, int tableNumber) => (string) EntityPropertyMetadata.oDI9pqbyB0xNRCd8vk5s((object) tableName, tableNumber <= 0 ? (object) "" : EntityPropertyMetadata.v0HBFUbyFw3sU7ZJSsIg(EntityPropertyMetadata.EReq5XbmzhdAqY4RkA1F(-87337865 ^ -87336947), (object) tableNumber));

    /// <inheritdoc />
    public virtual MetadataItemValidationError[] Validate()
    {
      int num = 1;
      IValidatableTypeDescriptor typeDescriptor;
      while (true)
      {
        switch (num)
        {
          case 1:
            typeDescriptor = MetadataServiceContext.Service.GetTypeDescriptor(EntityPropertyMetadata.FGTAl9byWCFYhv2ON7Mf((object) this), EntityPropertyMetadata.K5hUGPbyo6SyCsuVGqsg((object) this)) as IValidatableTypeDescriptor;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          case 3:
            goto label_3;
          default:
            if (typeDescriptor != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 2 : 0;
              continue;
            }
            goto label_3;
        }
      }
label_3:
      return (MetadataItemValidationError[]) null;
label_4:
      return (MetadataItemValidationError[]) EntityPropertyMetadata.qgCvijbybK5tilopwS7u((object) typeDescriptor, (object) this);
    }

    /// <summary>Загрузить значения из информации о свойстве класса</summary>
    /// <param name="propertyInfo">Информация о свойстве класса</param>
    /// <param name="filterTargetPropertyMetadata">Метаданные свойства сущности, для которого предназначается данное свойство фильтра</param>
    public override void LoadFromPropertyInfo(
      PropertyInfo propertyInfo,
      PropertyMetadata filterTargetPropertyMetadata)
    {
      int num = 9;
      EntityPropertyAttribute attribute1;
      FilterableAttribute attribute2;
      OutputAttribute attribute3;
      ShowInTableAttribute attribute4;
      InputAttribute attribute5;
      FastSearchAttribute attribute6;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_17;
          case 1:
            EntityPropertyMetadata.QKOhjSbyItd8lBPWSchH((object) this, attribute3 != null && EntityPropertyMetadata.Lsajn8byua9vorkJ0VmS((object) attribute3));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 3 : 2;
            continue;
          case 2:
            if (attribute1 == null)
            {
              num = 14;
              continue;
            }
            goto case 13;
          case 3:
            attribute1 = AttributeHelper<EntityPropertyAttribute>.GetAttribute((MemberInfo) propertyInfo, true);
            num = 2;
            continue;
          case 4:
            EntityPropertyMetadata.KH6KiTbyZ0AKiA6HhBJv((object) this, attribute5 != null && EntityPropertyMetadata.vMGvA2by8XWMuPUqtta3((object) attribute5));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 11;
            continue;
          case 5:
            attribute4 = AttributeHelper<ShowInTableAttribute>.GetAttribute((MemberInfo) propertyInfo, true);
            num = 6;
            continue;
          case 6:
            EntityPropertyMetadata.WrCtJ5byQf7yn6f0ehyP((object) this, attribute4 == null ? EntityPropertyMetadata.LDncGRbyEujnAIbsNZ8Z((object) this) : EntityPropertyMetadata.NYNfa7byflSKM7FcDk1w((object) attribute4));
            num = 10;
            continue;
          case 7:
            this.InFastSearch = attribute6 == null ? EntityPropertyMetadata.chIl3PbyhOEvikhwjIKT((object) this) : EntityPropertyMetadata.vwtVQMbyGoBJptBjl5X3((object) attribute6);
            num = 5;
            continue;
          case 8:
            attribute6 = AttributeHelper<FastSearchAttribute>.GetAttribute((MemberInfo) propertyInfo, true);
            num = 7;
            continue;
          case 9:
            base.LoadFromPropertyInfo(propertyInfo, filterTargetPropertyMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 8 : 8;
            continue;
          case 10:
            attribute2 = AttributeHelper<FilterableAttribute>.GetAttribute((MemberInfo) propertyInfo, true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 10 : 15;
            continue;
          case 11:
            attribute3 = AttributeHelper<OutputAttribute>.GetAttribute((MemberInfo) propertyInfo, true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 0;
            continue;
          case 12:
            attribute5 = AttributeHelper<InputAttribute>.GetAttribute((MemberInfo) propertyInfo, true);
            num = 4;
            continue;
          case 13:
            EntityPropertyMetadata.opkNdwbySXP5EeQjikWC((object) this, EntityPropertyMetadata.jr9fu4byVeGN3xKebX0A((object) attribute1));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
            continue;
          case 14:
            goto label_15;
          case 15:
            EntityPropertyMetadata.O9iAOqbyvfn8suDJpXZx((object) this, attribute2 != null && EntityPropertyMetadata.mspm0PbyCpyKn7oGoJKB((object) attribute2));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 11 : 12;
            continue;
          default:
            goto label_13;
        }
      }
label_17:
      return;
label_15:
      return;
label_13:;
    }

    public EntityPropertyMetadata()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool Tsi8IZbmYcAcIw5uZ0Kc() => EntityPropertyMetadata.noFdjybmjw4SJfjJBXHI == null;

    internal static EntityPropertyMetadata Q9s9vKbmLthVhXdTGx4A() => EntityPropertyMetadata.noFdjybmjw4SJfjJBXHI;

    internal static object voWDyHbmUyUZQRGVUCGV([In] object obj0) => (object) ((EntitySettings) obj0).RelationTableName;

    internal static object Ie9timbmshZ84hZF4KTP([In] object obj0) => (object) ((EntityMetadata) obj0).TableName;

    internal static int wmpkhBbmcSgRqB20y1nL([In] object obj0) => ((EntityPropertyMetadata) obj0).TableNumber;

    internal static object EReq5XbmzhdAqY4RkA1F(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object v0HBFUbyFw3sU7ZJSsIg([In] object obj0, [In] object obj1) => (object) (obj0.ToString() + obj1);

    internal static object oDI9pqbyB0xNRCd8vk5s([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static Guid FGTAl9byWCFYhv2ON7Mf([In] object obj0) => ((PropertyMetadata) obj0).TypeUid;

    internal static Guid K5hUGPbyo6SyCsuVGqsg([In] object obj0) => ((PropertyMetadata) obj0).SubTypeUid;

    internal static object qgCvijbybK5tilopwS7u([In] object obj0, [In] object obj1) => (object) ((IValidatableTypeDescriptor) obj0).Validate((IPropertyMetadata) obj1);

    internal static bool chIl3PbyhOEvikhwjIKT([In] object obj0) => ((EntityPropertyMetadata) obj0).InFastSearch;

    internal static bool vwtVQMbyGoBJptBjl5X3([In] object obj0) => ((FastSearchAttribute) obj0).Value;

    internal static bool LDncGRbyEujnAIbsNZ8Z([In] object obj0) => ((EntityPropertyMetadata) obj0).ShowInTable;

    internal static bool NYNfa7byflSKM7FcDk1w([In] object obj0) => ((ShowInTableAttribute) obj0).Value;

    internal static void WrCtJ5byQf7yn6f0ehyP([In] object obj0, bool value) => ((EntityPropertyMetadata) obj0).ShowInTable = value;

    internal static bool mspm0PbyCpyKn7oGoJKB([In] object obj0) => ((FilterableAttribute) obj0).Filterable;

    internal static void O9iAOqbyvfn8suDJpXZx([In] object obj0, bool value) => ((EntityPropertyMetadata) obj0).Filterable = value;

    internal static bool vMGvA2by8XWMuPUqtta3([In] object obj0) => ((InputAttribute) obj0).Value;

    internal static void KH6KiTbyZ0AKiA6HhBJv([In] object obj0, bool value) => ((EntityPropertyMetadata) obj0).Input = value;

    internal static bool Lsajn8byua9vorkJ0VmS([In] object obj0) => ((OutputAttribute) obj0).Value;

    internal static void QKOhjSbyItd8lBPWSchH([In] object obj0, bool value) => ((EntityPropertyMetadata) obj0).Output = value;

    internal static int jr9fu4byVeGN3xKebX0A([In] object obj0) => ((EntityPropertyAttribute) obj0).TableNumber;

    internal static void opkNdwbySXP5EeQjikWC([In] object obj0, int value) => ((EntityPropertyMetadata) obj0).TableNumber = value;
  }
}
