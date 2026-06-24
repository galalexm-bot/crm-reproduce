// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.EntityMetadata
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Mappings;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Metadata.PublicationBehaviours;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Metadata;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Метаданные сущности</summary>
  [ClassMap(typeof (EntityMetadataMap))]
  [EleWise.ELMA.Model.Attributes.DisplayName(typeof (EntityMetadata_Resources), "DisplayName")]
  [Entity("MD_ENTITY")]
  [DataContract]
  [XmlRoot("Entity")]
  [MetadataType(typeof (EntityMetadata))]
  [EleWise.ELMA.Model.Attributes.AllowCreateHeirs(true)]
  [EleWise.ELMA.Model.Attributes.Uid("{C40FD1D3-F5D9-4323-9E51-42EBFA77E6DC}")]
  [Serializable]
  public class EntityMetadata : 
    ClassMetadata,
    IEntityMetadata,
    IRootMetadata,
    IMetadata,
    IXsiType,
    ICodeItemMetadata,
    IGroupedMetadata,
    ICompositeMetadata,
    IEntityCatalog,
    IEntityIdentifier,
    ITablePartContainer,
    IDeltaRootMetadata
  {
    /// <summary>Уникальный идентификатор</summary>
    public static readonly Guid UID;
    /// <summary>Имя свойства со ссылкой на родительский объект</summary>
    public const string PARENT_PROPERTY_NAME = "Parent";
    /// <summary>
    /// Имя свойства, определяющего, является ли объект группой
    /// </summary>
    public const string ISGROUP_PROPERTY_NAME = "IsGroup";
    /// <summary>Имя свойства определяющего тип метаданных сущности</summary>
    public const string TYPEUID_PROPERTY_NAME = "TypeUid";
    /// <summary>
    /// Уникальный идентификатор сущности "Метаданные сущности"
    /// </summary>
    public const string UID_S = "{C40FD1D3-F5D9-4323-9E51-42EBFA77E6DC}";
    /// <summary>Максимальная длина имени таблицы</summary>
    public const int MAX_TABLE_NAME_LENGTH = 28;
    /// <summary>Имя свойства модели для метаданных модели отображения</summary>
    public const string ModelPropertyName = "Model";
    /// <summary>Суффикс имени метаданных модели отображения</summary>
    public const string ViewModelContext = "ViewModelContext";
    [NonSerialized]
    private Iesi.Collections.Generic.ISet<EntityPropertyMetadata> entityProperties;
    [NonSerialized]
    private Iesi.Collections.Generic.ISet<TablePartMetadata> entityTableParts;
    private EntityMetadataType _type;
    private List<TablePartMetadata> tableParts;
    [NonSerialized]
    private IEnumerator<TablePartMetadata> tablePartsEnumerator;
    private static EntityMetadata eFWmq3b9FDeoybGQB57N;

    /// <summary>Тип метаданных сущности</summary>
    [PublicationBehaviour(PublicationType.Restart)]
    [DefaultValue(EntityMetadataType.Entity)]
    [DataMember]
    public virtual EntityMetadataType Type
    {
      get => this._type;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (value == EntityMetadataType.InterfaceImplementation)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
                continue;
              }
              goto case 5;
            case 2:
              this.OnTypeChanged();
              num = 4;
              continue;
            case 3:
              EntityMetadata.N11SS9b9oURMEiShgfm2((object) this, (object) null);
              num = 5;
              continue;
            case 4:
              goto label_2;
            case 5:
              this._type = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 1 : 2;
              continue;
            default:
              if (this._type != EntityMetadataType.InterfaceImplementation)
              {
                num = 3;
                continue;
              }
              goto case 5;
          }
        }
label_2:;
      }
    }

    /// <summary>
    /// Для EntityMetadataType.Interface определяет уникальный идентификатор реализующей сущности.
    /// Для EntityMetadataType.InterfaceImplementation определяет уникальный идентификатор интерфейса.
    /// </summary>
    [PublicationBehaviour(PublicationType.Restart)]
    [DataMember]
    public virtual Guid ImplementationUid
    {
      get => this.\u003CImplementationUid\u003Ek__BackingField;
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
              this.\u003CImplementationUid\u003Ek__BackingField = value;
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
    /// Является ли сущностью с уникальным идентификатором (содержит свойство с именем Uid и типом Guid)
    /// </summary>
    [DefaultValue(true)]
    [PublicationBehaviour(PublicationType.Restart)]
    [DataMember]
    [XmlElement("IsUnique")]
    public virtual bool IsUnique
    {
      get => this.\u003CIsUnique\u003Ek__BackingField;
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
              this.\u003CIsUnique\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
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

    /// <summary>Uid типа идентификатора</summary>
    [XmlElement("IdTypeUid")]
    [DataMember]
    [PublicationBehaviour(PublicationType.Restart)]
    public virtual Guid IdTypeUid
    {
      get => this.\u003CIdTypeUid\u003Ek__BackingField;
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
              this.\u003CIdTypeUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
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

    /// <summary>Имя таблицы в БД</summary>
    [PublicationBehaviour(PublicationType.Restart)]
    [DataMember]
    [StringSettings(MaxValueString = "2000", FieldName = "TableName")]
    [EntityProperty]
    [Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
    [EleWise.ELMA.Model.Attributes.Uid("{7FC83360-EC31-4E35-9694-4A9F136DC6E0}")]
    [XmlElement("TableName")]
    public virtual string TableName
    {
      get => this.\u003CTableName\u003Ek__BackingField;
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
              this.\u003CTableName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
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
    /// Номер последней таблицы (если свойства сущности хранятся в нескольких таблицах)
    /// </summary>
    [EntityProperty]
    [DefaultValue(0)]
    [PublicationBehaviour(PublicationType.Restart)]
    [Int16Settings(FieldName = "LastTableNumber")]
    [XmlElement("LastTableNumber")]
    [EleWise.ELMA.Model.Attributes.Uid("{A4CDAFD6-38C0-4793-ABF6-B3D923EB2A59}")]
    [Property("{C1D5FC22-B8ED-4CFA-8029-82EC19E17B7F}")]
    [DataMember]
    public virtual short LastTableNumber
    {
      get => this.\u003CLastTableNumber\u003Ek__BackingField;
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
              this.\u003CLastTableNumber\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 0 : 0;
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

    /// <summary>Использовать "мягкое" удаление</summary>
    [XmlElement("IsSoftDeletable")]
    [DataMember]
    [PublicationBehaviour(PublicationType.Restart)]
    public virtual bool IsSoftDeletable
    {
      get => this.\u003CIsSoftDeletable\u003Ek__BackingField;
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
              this.\u003CIsSoftDeletable\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
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

    /// <summary>Хранить историю изменения сущности</summary>
    [XmlElement("SaveHistory")]
    [DataMember]
    [DefaultValue(false)]
    [PublicationBehaviour(PublicationType.Restart)]
    public virtual bool SaveHistory
    {
      get => this.\u003CSaveHistory\u003Ek__BackingField;
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
              this.\u003CSaveHistory\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
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

    /// <summary>Действие при копировании связанного объекта</summary>
    [DefaultValue(CopyAction.Default)]
    [XmlElement("CopyAction")]
    [Property("{849C1AC9-4D46-4194-8CBB-43F84ADF9C17}", "ded50eaa-8f9d-4457-b083-60b8b721705b")]
    [EnumSettings(FieldName = "CopyAction")]
    public virtual CopyAction CopyAction
    {
      get => this.\u003CCopyAction\u003Ek__BackingField;
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
              this.\u003CCopyAction\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
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

    /// <summary>Использовать ли кэширование для сущности</summary>
    [XmlElement("CacheEntity")]
    [EntityProperty]
    [DefaultValue(false)]
    [PublicationBehaviour(PublicationType.Restart)]
    [EleWise.ELMA.Model.Attributes.Uid("{A975D52C-D261-4AE4-8013-097A97A4EA62}")]
    [Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
    [BoolSettings(FieldName = "CacheEntity")]
    public virtual bool CacheEntity
    {
      get => this.\u003CCacheEntity\u003Ek__BackingField;
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
              this.\u003CCacheEntity\u003Ek__BackingField = value;
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
    /// Показывать в дереве справочников (в разделе "Справочники" веб-приложения)
    /// </summary>
    [XmlElement("ShowInCatalogList")]
    [DefaultValue(false)]
    [DataMember]
    [EntityProperty]
    [EleWise.ELMA.Model.Attributes.Uid("{FBC0B869-468A-4BE3-B49E-6789072C93D2}")]
    [Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
    [BoolSettings(FieldName = "ShowInCatalogList")]
    public virtual bool ShowInCatalogList
    {
      get => this.\u003CShowInCatalogList\u003Ek__BackingField;
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
              this.\u003CShowInCatalogList\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 0 : 0;
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

    /// <summary>Генерировать ли класс для фильтра</summary>
    [EntityProperty]
    [BoolSettings(FieldName = "Filterable")]
    [Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
    [DefaultValue(false)]
    [EleWise.ELMA.Model.Attributes.Uid("{D450CAC0-1DBB-4965-A3F5-35827F29BD98}")]
    [XmlElement("Filterable")]
    [PublicationBehaviour(PublicationType.Delta)]
    [DataMember]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
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
    /// Полные имена типов с именем сборки (AssemblyQualifiedName) реализуемых интерфейсов
    /// </summary>
    [DefaultValue(null)]
    [XmlElement("FilterImplementedInterfaces")]
    [PublicationBehaviour(PublicationType.Restart)]
    public virtual List<string> FilterImplementedInterfaces { get; set; }

    /// <summary>
    /// Является ли иерархический объектом.
    /// Если True, то у сущности создается свойство Parent (а также IsGroup, если тип иерархии включает группы)
    /// </summary>
    [BoolSettings(FieldName = "Hierarchical")]
    [Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
    [EntityProperty]
    [DataMember]
    [PublicationBehaviour(PublicationType.Restart)]
    [DefaultValue(false)]
    [XmlElement("Hierarchical")]
    [EleWise.ELMA.Model.Attributes.Uid("{4116F9CD-D92E-4387-93F5-456C92734EC4}")]
    public virtual bool Hierarchical
    {
      get => this.\u003CHierarchical\u003Ek__BackingField;
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
              this.\u003CHierarchical\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
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

    /// <summary>Тип иерархии (имеет значение, если Hierarchical=true)</summary>
    [XmlElement("HierarchyType")]
    [Property("{849C1AC9-4D46-4194-8CBB-43F84ADF9C17}", "6bca7871-a483-4db7-bbbe-1ba839df0cbc")]
    [EnumSettings(FieldName = "HierarchyType")]
    [EntityProperty]
    [PublicationBehaviour(PublicationType.Restart)]
    [DataMember]
    [EleWise.ELMA.Model.Attributes.Uid("{5CBF580D-FE24-4B6C-958B-F6D24ECC1EEA}")]
    [DefaultValue(HierarchyType.GroupAndElements)]
    public virtual HierarchyType HierarchyType
    {
      get => this.\u003CHierarchyType\u003Ek__BackingField;
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
              this.\u003CHierarchyType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
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
    /// Уникальный идентификатор свойства, содержащего ссылку на родительский объект (если сущность поддерживает иерархию) или запись блока
    /// </summary>
    [EntityProperty]
    [PublicationBehaviour(PublicationType.Restart)]
    [DataMember]
    [GuidSettings(FieldName = "ParentPropertyUid")]
    [EleWise.ELMA.Model.Attributes.Uid("{BDF533BF-936B-4C9F-BBF1-C28FEBA32CAD}")]
    [XmlElement("ParentPropertyUid")]
    [Property("{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}")]
    public virtual Guid ParentPropertyUid
    {
      get => this.\u003CParentPropertyUid\u003Ek__BackingField;
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
              this.\u003CParentPropertyUid\u003Ek__BackingField = value;
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

    /// <summary>
    /// Скрыть вкладку вложенных свойств при редактировании контрола сущности в конструкторе форм
    /// </summary>
    [BoolSettings(FieldName = "HideChildItemsTab")]
    [DefaultValue(false)]
    [DataMember]
    [EleWise.ELMA.Model.Attributes.Uid("{EA3218DA-7028-4FD8-83A9-D1023A73F025}")]
    [XmlElement("HideChildItemsTab")]
    [Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
    public virtual bool HideChildItemsTab
    {
      get => this.\u003CHideChildItemsTab\u003Ek__BackingField;
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
              this.\u003CHideChildItemsTab\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 0;
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

    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerializeParentPropertyUid() => EntityMetadata.qefXcqb9hAjwEVDPpQRp(EntityMetadata.lqhap5b9bdMAR1MQaMPm((object) this), Guid.Empty);

    /// <summary>
    /// Уникальный идентификатор свойства, определяеющего, явряется ли объект группой
    /// </summary>
    [GuidSettings(FieldName = "IsGroupPropertyUid")]
    [EntityProperty]
    [PublicationBehaviour(PublicationType.Restart)]
    [Property("{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}")]
    [EleWise.ELMA.Model.Attributes.Uid("{F41506A0-0103-4377-9A22-71DB6F8D15B7}")]
    [DataMember]
    [XmlElement("IsGroupPropertyUid")]
    public virtual Guid IsGroupPropertyUid
    {
      get => this.\u003CIsGroupPropertyUid\u003Ek__BackingField;
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
              this.\u003CIsGroupPropertyUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
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

    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerializeIsGroupPropertyUid() => EntityMetadata.qefXcqb9hAjwEVDPpQRp(EntityMetadata.fXq5Etb9Gah8L83xNNAu((object) this), Guid.Empty);

    /// <summary>Метаданные фильтра сущности. Содержит дополнительные</summary>
    [PublicationBehaviour(PublicationType.Delta)]
    public virtual EntityFilterMetadata Filter
    {
      get => this.\u003CFilter\u003Ek__BackingField;
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
              this.\u003CFilter\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
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

    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerializeFilter() => EntityMetadata.PaOtoHb9E3CwqyjLdxE5((object) this);

    /// <summary>
    /// Уникальные идентификаторы реализуемых интерфейсов-расширений
    /// </summary>
    [PublicationBehaviour(PublicationType.Restart)]
    public virtual List<Guid> ImplementedExtensionUids { get; set; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerializeImplementedExtensionUids()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.ImplementedExtensionUids != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return EntityMetadata.qBGDwOb9fiX3pH6jfTOG((object) this.ImplementedExtensionUids) > 0;
label_5:
      return false;
    }

    /// <summary>Имя свойства привилегий</summary>
    [DefaultValue("")]
    [XmlElement("PermissionsPropertyName")]
    [DataMember]
    [EleWise.ELMA.Model.Attributes.Uid("{80C9EB2E-A795-4249-AC27-0B05100E4380}")]
    [Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
    [StringSettings(FieldName = "PermissionsPropertyName")]
    public virtual string PermissionsPropertyName
    {
      get => this.\u003CPermissionsPropertyName\u003Ek__BackingField;
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
              this.\u003CPermissionsPropertyName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
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
    /// Поддерживает настройку прав доступа на уровне экземпляра
    /// </summary>
    [DataMember]
    [PublicationBehaviour(PublicationType.Restart)]
    [DefaultValue(false)]
    [XmlElement("InstancePermissionsSupport")]
    [Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
    [EleWise.ELMA.Model.Attributes.Uid("{C0705251-9EF6-47FD-A6C4-3CA0DAF0E6BA}")]
    [BoolSettings(FieldName = "InstancePermissionsSupport")]
    public virtual bool InstancePermissionsSupport
    {
      get => this.\u003CInstancePermissionsSupport\u003Ek__BackingField;
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
              this.\u003CInstancePermissionsSupport\u003Ek__BackingField = value;
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

    /// <summary>Имя класса привилегий</summary>
    [DefaultValue("")]
    [StringSettings(FieldName = "PermissionsMetadataName")]
    [DataMember]
    [XmlElement("PermissionsMetadataName")]
    [EleWise.ELMA.Model.Attributes.Uid("{B7087D28-5FBD-4535-984E-D9B2A62D9320}")]
    [Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
    public virtual string PermissionsMetadataName
    {
      get => this.\u003CPermissionsMetadataName\u003Ek__BackingField;
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
              this.\u003CPermissionsMetadataName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
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

    /// <summary>Действия с сущностью</summary>
    [PublicationBehaviour(PublicationType.Restart)]
    public virtual EntityActionsMetadata Actions
    {
      get => this.\u003CActions\u003Ek__BackingField;
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
              this.\u003CActions\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
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

    /// <summary>Блоки</summary>
    [XmlArray("TableParts")]
    [EleWise.ELMA.Model.Attributes.Uid("{CD1CBFBE-B671-444A-AFA4-D45FE4BEC966}")]
    [PublicationBehaviour(typeof (NotRestartIfCollectionItemAddBehaviour))]
    public virtual List<TablePartMetadata> TableParts
    {
      get
      {
        try
        {
          (this.tablePartsEnumerator ?? (this.tablePartsEnumerator = (IEnumerator<TablePartMetadata>) this.tableParts?.GetEnumerator()))?.Reset();
        }
        catch (InvalidOperationException ex)
        {
          this.tableParts.ForEach((Action<TablePartMetadata>) (p =>
          {
            int num = 1;
            while (true)
            {
              switch (num)
              {
                case 0:
                  goto label_2;
                case 1:
                  p.Namespace = (string) EntityMetadata.y54tYUb9HRDqD1yuI3TS((object) this);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
                  continue;
                default:
                  goto label_4;
              }
            }
label_2:
            return;
label_4:;
          }));
          this.tablePartsEnumerator = (IEnumerator<TablePartMetadata>) this.tableParts.GetEnumerator();
        }
        return this.tableParts;
      }
      set
      {
        this.tableParts = value;
        this.tableParts?.ForEach((Action<TablePartMetadata>) (p =>
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                p.Namespace = (string) EntityMetadata.y54tYUb9HRDqD1yuI3TS((object) this);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }));
        this.tablePartsEnumerator = (IEnumerator<TablePartMetadata>) this.tableParts?.GetEnumerator();
      }
    }

    /// <inheritdoc />
    ICollection<ITablePartMetadata> ITablePartContainer.TableParts
    {
      get => (ICollection<ITablePartMetadata>) this.TableParts.Cast<ITablePartMetadata>().ToList<ITablePartMetadata>();
      set => this.TableParts = value.Cast<TablePartMetadata>().ToList<TablePartMetadata>();
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerializeTableParts()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.TableParts != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return EntityMetadata.NBP8txb9QO9i1sO5C5ks((object) this.TableParts) > 0;
label_3:
      return false;
    }

    /// <summary>Метаданные модели отображения</summary>
    [EleWise.ELMA.Model.Attributes.Uid("{C4B53CE9-1697-4F72-A154-096885069AD1}")]
    [XmlSerializableObjectSettings(FieldName = "ViewModelMetadata")]
    [Property("{66C7898B-E56B-49E0-BFB8-9F9C4A7A0C52}")]
    [XmlElement("ViewModelMetadata")]
    [EntityProperty]
    public virtual DataClassMetadata ViewModelMetadata
    {
      get => this.\u003CViewModelMetadata\u003Ek__BackingField;
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
              this.\u003CViewModelMetadata\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 0 : 0;
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
    /// Получить список свойств и блоков единым списком, упорядоченным по свойству Order (из свойств Properties и TableParts)
    /// </summary>
    /// <returns></returns>
    public virtual IEnumerable<IPropertyMetadata> GetPropertiesAndTableParts() => ContextVars.GetOrAdd<IEnumerable<IPropertyMetadata>>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1839087379 - 334718690 ^ 2121049221) + (object) this.Uid + (object) EleWise.ELMA.SR.CurrentLCID, new Func<IEnumerable<IPropertyMetadata>>(this.GetPropertiesAndTablePartsWhithoutCache));

    /// <summary>
    /// Получить список свойств и блоков единым списком, без упорядочивания по свойству Order (из свойств Properties и TableParts)
    /// </summary>
    /// <returns>Список свойств и блоков</returns>
    public virtual IEnumerable<IPropertyMetadata> GetPropertiesAndTablePartsWithoutSort() => Enumerable.Empty<IPropertyMetadata>().Concat<IPropertyMetadata>((IEnumerable<IPropertyMetadata>) this.Properties).Concat<IPropertyMetadata>((IEnumerable<IPropertyMetadata>) this.TableParts);

    private void ClearPropertiesAndTablePartsCache()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            EntityMetadata.TOyAxrb9Z8qREYNOj16V((object) (EntityMetadata.MSCsnub9C12rHGsiMtFQ(1461825605 - 1531863589 ^ -70143826).ToString() + (object) EntityMetadata.J7Gxqcb9vHIMg9692ytg((object) this) + (object) EntityMetadata.oadomhb98ijCXwOTXsRE()));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
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
    /// Получить список свойств и блоков единым списком, упорядоченным по свойству Order (из свойств Properties и TableParts) не добавляя в кэш
    /// </summary>
    /// <returns></returns>
    public virtual IEnumerable<IPropertyMetadata> GetPropertiesAndTablePartsWhithoutCache()
    {
      List<IPropertyMetadata> partsWhithoutCache = new List<IPropertyMetadata>();
      if (this.Properties != null)
        partsWhithoutCache.AddRange((IEnumerable<IPropertyMetadata>) this.Properties);
      if (this.TableParts != null)
        partsWhithoutCache.AddRange((IEnumerable<IPropertyMetadata>) this.TableParts);
      partsWhithoutCache.Sort((Comparison<IPropertyMetadata>) ((p1, p2) =>
      {
        int num1 = 8;
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
                // ISSUE: reference to a compiler-generated method
                if (p1.Order >= EntityMetadata.\u003C\u003Ec.YWwWWkCA92EAly0P5TJC((object) p2))
                {
                  num2 = 4;
                  continue;
                }
                goto label_12;
              case 3:
                goto label_4;
              case 4:
                goto label_11;
              case 5:
              case 7:
                goto label_5;
              case 6:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if (EntityMetadata.\u003C\u003Ec.jk0fmxCAJZA57Rfp8pq8(EntityMetadata.\u003C\u003Ec.wojuqfCAMDfhKcqU9gqp((object) p2), (System.Type) null))
                {
                  num2 = 5;
                  continue;
                }
                // ISSUE: reference to a compiler-generated method
                if (p1.DeclaringType.IsAssignableFrom(EntityMetadata.\u003C\u003Ec.wojuqfCAMDfhKcqU9gqp((object) p2)))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 3 : 3;
                  continue;
                }
                goto label_3;
              case 8:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if (EntityMetadata.\u003C\u003Ec.jk0fmxCAJZA57Rfp8pq8(EntityMetadata.\u003C\u003Ec.wojuqfCAMDfhKcqU9gqp((object) p1), EntityMetadata.\u003C\u003Ec.wojuqfCAMDfhKcqU9gqp((object) p2)))
                {
                  num2 = 7;
                  continue;
                }
                break;
            }
            // ISSUE: reference to a compiler-generated method
            if (!EntityMetadata.\u003C\u003Ec.jk0fmxCAJZA57Rfp8pq8(p1.DeclaringType, (System.Type) null))
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 6 : 6;
            else
              break;
          }
label_5:
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          if (EntityMetadata.\u003C\u003Ec.YWwWWkCA92EAly0P5TJC((object) p1) != EntityMetadata.\u003C\u003Ec.YWwWWkCA92EAly0P5TJC((object) p2))
            num1 = 2;
          else
            goto label_13;
        }
label_3:
        return 1;
label_4:
        return -1;
label_11:
        return 1;
label_12:
        return -1;
label_13:
        return 0;
      }));
      return (IEnumerable<IPropertyMetadata>) partsWhithoutCache;
    }

    /// <summary>
    /// Рекурсивное получение списка всех свойств и блоков, относящихся к метаданным (включая свойства и блоки всех вложенных блоков)
    /// </summary>
    /// <returns></returns>
    public virtual IEnumerable<IPropertyMetadata> GetAllPropertiesAndTableParts()
    {
      IEnumerable<TablePartMetadata> allTableParts = this.GetAllTableParts();
      return ((IEnumerable<IPropertyMetadata>) this.Properties.Concat<PropertyMetadata>(allTableParts.SelectMany<TablePartMetadata, PropertyMetadata>((Func<TablePartMetadata, IEnumerable<PropertyMetadata>>) (tp => (IEnumerable<PropertyMetadata>) tp.Properties)))).Concat<IPropertyMetadata>(allTableParts.OfType<IPropertyMetadata>());
    }

    /// <summary>
    /// Рекурсивное получение списка всех блоков, относящихся к метаданным (включая все вложенные)
    /// </summary>
    /// <returns></returns>
    public virtual IEnumerable<TablePartMetadata> GetAllTableParts() => this.TableParts.SelectRecursive<TablePartMetadata>((Func<TablePartMetadata, IEnumerable<TablePartMetadata>>) (tp => (IEnumerable<TablePartMetadata>) tp.TableParts));

    /// <summary>
    /// Рекурсивное получение списка всех свойств, относящихся к метаданным (включая свойства всех вложенных блоков)
    /// </summary>
    /// <returns></returns>
    public virtual IEnumerable<PropertyMetadata> GetAllProperties() => this.Properties.Concat<PropertyMetadata>(this.GetAllTableParts().SelectMany<TablePartMetadata, PropertyMetadata>((Func<TablePartMetadata, IEnumerable<PropertyMetadata>>) (tp => (IEnumerable<PropertyMetadata>) tp.Properties)));

    /// <summary>
    /// True, если тип метаданных сущности Interface или InterfaceExtension
    /// </summary>
    public override bool IsInterfaceType
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.Type != EntityMetadataType.Interface)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            default:
              goto label_4;
          }
        }
label_4:
        return EntityMetadata.u9181Tb9uKSltlGfBVHS((object) this) == EntityMetadataType.InterfaceExtension;
label_5:
        return true;
      }
    }

    /// <summary>Имя типа</summary>
    public override string TypeName
    {
      get
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_5;
            case 2:
              if (!EntityMetadata.MwvFZob9IeSSvNL1DMg8((object) this))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 1;
                continue;
              }
              goto label_2;
            default:
              goto label_2;
          }
        }
label_2:
        string str = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1875938711);
        goto label_6;
label_5:
        str = string.Empty;
label_6:
        object obj = EntityMetadata.L0eoFnb9VOa5jPxqCHeG((object) this);
        return (string) EntityMetadata.PHyYiEb9SSaAJUBVCAYB((object) str, obj);
      }
    }

    /// <summary>Создать свойство (без добавления в список)</summary>
    /// <param name="initNew">Инициализировать как новое свойство</param>
    /// <returns>Свойство с новым Uid-ом</returns>
    public override PropertyMetadata CreateProperty(bool initNew = false)
    {
      int num = 1;
      EntityPropertyMetadata property;
      while (true)
      {
        switch (num)
        {
          case 1:
            property = new EntityPropertyMetadata();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
            continue;
          case 2:
            EntityMetadata.lPF5ZBb9ifiYo8kCSAXA((object) property);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 3 : 3;
            continue;
          case 3:
            goto label_3;
          default:
            if (initNew)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 2 : 2;
              continue;
            }
            goto label_3;
        }
      }
label_3:
      return (PropertyMetadata) property;
    }

    /// <summary>Создать блок (без добавления в список)</summary>
    /// <returns>Блок с новым Uid-ом</returns>
    public virtual TablePartMetadata CreateTablePart()
    {
      int num = 1;
      TablePartMetadata tp;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            tp.Properties.First<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => EntityMetadata.\u003C\u003Ec__DisplayClass132_0.y6K0J9C7oQvy7hd3uDS8(EntityMetadata.\u003C\u003Ec__DisplayClass132_0.YPgeulC7B6YctksvgNve((object) p), EntityMetadata.\u003C\u003Ec__DisplayClass132_0.QQYI7FC7WlinKeJmMW1C((object) tp)))).SubTypeUid = this.Uid;
            num = 3;
            continue;
          case 3:
            goto label_2;
          case 4:
            EntityMetadata.oIgoITb9RViQbgYAReRL((object) tp, !EntityMetadata.MwvFZob9IeSSvNL1DMg8((object) this) ? this.Type : EntityMetadataType.Interface);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 2 : 2;
            continue;
          case 5:
            EntityMetadata.lPF5ZBb9ifiYo8kCSAXA((object) tp);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 4 : 2;
            continue;
          default:
            tp = new TablePartMetadata();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 5 : 2;
            continue;
        }
      }
label_2:
      return tp;
    }

    /// <summary>
    /// Создать свойство "Уникальный идентификатор".
    /// Если уже существует свойство с именем "Uid" и типом Guid, то оно помечается как системное.
    /// </summary>
    /// <returns>Свойство "Уникальный идентификатор"</returns>
    public virtual EntityPropertyMetadata CreateUidProperty()
    {
      int num1 = 26;
      EntityPropertyMetadata uidProperty;
      while (true)
      {
        int num2 = num1;
        int index1;
        while (true)
        {
          PropertyMetadata propertyMetadata1;
          int index2;
          int num3;
          switch (num2)
          {
            case 1:
            case 17:
              EntityMetadata.BnubhCb9kbqvLIeQlx1u((object) uidProperty, true);
              num2 = 10;
              continue;
            case 2:
              EntityMetadata.g2fiOOb9PyTZjcDlU9Ag((object) uidProperty, EntityMetadata.b1ufNYb9K4idafNcePoK(EntityMetadata.MSCsnub9C12rHGsiMtFQ(572119659 - -337058038 ^ 909120965)));
              num2 = 3;
              continue;
            case 3:
              EntityMetadata.w7OViVb91h3XMINgZWZj((object) uidProperty, GuidDescriptor.UID);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
              continue;
            case 4:
              propertyMetadata1 = this.Properties.LastOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p1 => p1.IsSystem));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 1 : 14;
              continue;
            case 5:
              List<ViewAttribute> attributes1 = ((PropertyViewSettings) EntityMetadata.yGx9M3b9poYb02kSUB7r((object) uidProperty)).Attributes;
              ViewAttribute viewAttribute1 = new ViewAttribute();
              EntityMetadata.fDRrvkb929508rMJxgN0((object) viewAttribute1, ViewType.All);
              EntityMetadata.OQqFrWb9ekqUafT8xCPG((object) viewAttribute1, Visibility.Hidden);
              attributes1.Add(viewAttribute1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 1 : 4;
              continue;
            case 6:
              this.Properties.Insert(index2, (PropertyMetadata) uidProperty);
              num2 = 17;
              continue;
            case 7:
            case 22:
              goto label_9;
            case 8:
              if (EntityMetadata.qefXcqb9hAjwEVDPpQRp(EntityMetadata.hA3Rycb9q2I5RhZxCxYD((object) uidProperty), GuidDescriptor.UID))
              {
                num2 = 23;
                continue;
              }
              if (EntityMetadata.gYPuP4b9T0mpf93rLLAH((object) uidProperty))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 7 : 4;
                continue;
              }
              goto case 9;
            case 9:
              int num4 = this.Properties.IndexOf((PropertyMetadata) uidProperty);
              List<PropertyMetadata> properties = this.Properties;
              // ISSUE: reference to a compiler-generated field
              Func<PropertyMetadata, bool> func = EntityMetadata.\u003C\u003Ec.\u003C\u003E9__133_2;
              Func<PropertyMetadata, bool> predicate;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                EntityMetadata.\u003C\u003Ec.\u003C\u003E9__133_2 = predicate = (Func<PropertyMetadata, bool>) (p1 => EntityMetadata.\u003C\u003Ec.N6xDBnCAla31u5hR2x1g((object) p1));
              }
              else
                goto label_39;
label_34:
              PropertyMetadata propertyMetadata2 = properties.LastOrDefault<PropertyMetadata>(predicate);
              index2 = propertyMetadata2 != null ? this.Properties.IndexOf(propertyMetadata2) + 1 : 0;
              int num5 = index2;
              if (num4 <= num5)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 1;
                continue;
              }
              goto case 13;
label_39:
              predicate = func;
              goto label_34;
            case 10:
              EntityMetadata.V7Vepwb9nDPbbk7y64VT((object) uidProperty, false);
              num2 = 18;
              continue;
            case 11:
              EntityMetadata.AWB1Jfb9OTSd0Tm9X2uR((object) ((PropertyViewSettings) EntityMetadata.yGx9M3b9poYb02kSUB7r((object) uidProperty)).Attributes);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 5 : 3;
              continue;
            case 12:
              EntityMetadata.BnubhCb9kbqvLIeQlx1u((object) uidProperty, true);
              num2 = 24;
              continue;
            case 13:
              this.Properties.Remove((PropertyMetadata) uidProperty);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 4 : 6;
              continue;
            case 14:
              if (propertyMetadata1 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 15 : 19;
                continue;
              }
              num3 = this.Properties.IndexOf(propertyMetadata1) + 1;
              break;
            case 15:
              goto label_26;
            case 16:
              goto label_15;
            case 18:
              EntityMetadata.AWB1Jfb9OTSd0Tm9X2uR((object) uidProperty.ViewSettings.Attributes);
              num2 = 20;
              continue;
            case 19:
              num3 = 0;
              break;
            case 20:
              List<ViewAttribute> attributes2 = uidProperty.ViewSettings.Attributes;
              ViewAttribute viewAttribute2 = new ViewAttribute();
              EntityMetadata.fDRrvkb929508rMJxgN0((object) viewAttribute2, ViewType.All);
              EntityMetadata.OQqFrWb9ekqUafT8xCPG((object) viewAttribute2, Visibility.Hidden);
              attributes2.Add(viewAttribute2);
              num2 = 22;
              continue;
            case 21:
              uidProperty.Name = (string) EntityMetadata.MSCsnub9C12rHGsiMtFQ(1012087039 ^ 1012094829);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 2 : 0;
              continue;
            case 23:
              goto label_28;
            case 24:
              goto label_13;
            case 25:
              if (uidProperty == null)
              {
                uidProperty = (EntityPropertyMetadata) this.CreateProperty(true);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 9 : 12;
                continue;
              }
              num2 = 8;
              continue;
            case 26:
              // ISSUE: reference to a compiler-generated method
              uidProperty = (EntityPropertyMetadata) this.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p1 => (string) EntityMetadata.\u003C\u003Ec.GGYkN3CAd3wqJB9NGQDp((object) p1) == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281869526)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 25 : 3;
              continue;
            default:
              EntityPropertyMetadata propertyMetadata3 = uidProperty;
              GuidSettings guidSettings = new GuidSettings();
              EntityMetadata.NNeqY5b9Ndm2DB1YGjSx((object) guidSettings, EntityMetadata.MSCsnub9C12rHGsiMtFQ(-2107978722 ^ -2107989108));
              EntityMetadata.vnLabEb93VkFKvrto4Q8((object) propertyMetadata3, (object) guidSettings);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 11 : 11;
              continue;
          }
          index1 = num3;
          num2 = 15;
        }
label_13:
        EntityMetadata.V7Vepwb9nDPbbk7y64VT((object) uidProperty, false);
        num1 = 21;
        continue;
label_26:
        this.Properties.Insert(index1, (PropertyMetadata) uidProperty);
        num1 = 16;
      }
label_9:
      return uidProperty;
label_15:
      return uidProperty;
label_28:
      throw new MetadataException((string) EntityMetadata.kCmmwvb9XTupj8fvNH47((object) EleWise.ELMA.SR.T((string) EntityMetadata.MSCsnub9C12rHGsiMtFQ(-244066886 - -48452443 ^ -195700775)), EntityMetadata.MSCsnub9C12rHGsiMtFQ(1470998129 - 231418599 ^ 1239553048), EntityMetadata.b1ufNYb9K4idafNcePoK(EntityMetadata.MSCsnub9C12rHGsiMtFQ(1470440286 ^ 1470481914))));
    }

    public virtual EntityPropertyMetadata GetUidProperty() => base.GetUidProperty() as EntityPropertyMetadata;

    /// <summary>
    /// Создать свойство со ссылкой на родительский объект (для поддержки иерархии)
    /// </summary>
    /// <param name="add">Добавлять в список свойств</param>
    /// <returns>Свойство со ссылкой на родительский объект</returns>
    public virtual EntityPropertyMetadata CreateParentProperty(bool add = true)
    {
      int num1 = 11;
      EntityPropertyMetadata property;
      while (true)
      {
        PropertyMetadata propertyMetadata1;
        int index;
        int num2;
        switch (num1)
        {
          case 1:
            num2 = this.Properties.IndexOf(propertyMetadata1) + 1;
            break;
          case 2:
            if (propertyMetadata1 != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 1 : 0;
              continue;
            }
            goto case 13;
          case 3:
          case 15:
            goto label_10;
          case 4:
            // ISSUE: reference to a compiler-generated method
            propertyMetadata1 = this.Properties.LastOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p1 => EntityMetadata.\u003C\u003Ec.N6xDBnCAla31u5hR2x1g((object) p1)));
            num1 = 2;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            if (this.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p1 => EntityMetadata.\u003C\u003Ec.jxorCUCAgFwwYEOdnlSU((object) p1.Name, EntityMetadata.\u003C\u003Ec.cMl811CAr7rfBZp3KZEu(~-306453669 ^ 306482322)))) == null)
            {
              num1 = 6;
              continue;
            }
            goto label_11;
          case 6:
            if (!add)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 3 : 1;
              continue;
            }
            goto case 4;
          case 7:
            EntityPropertyMetadata propertyMetadata2 = property;
            EntitySettings entitySettings = new EntitySettings();
            EntityMetadata.NNeqY5b9Ndm2DB1YGjSx((object) entitySettings, EntityMetadata.MSCsnub9C12rHGsiMtFQ(-1445902765 ^ -1980277732 ^ 539396729));
            EntityMetadata.vnLabEb93VkFKvrto4Q8((object) propertyMetadata2, (object) entitySettings);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 5 : 1;
            continue;
          case 8:
            EntityMetadata.g2fiOOb9PyTZjcDlU9Ag((object) property, (object) EleWise.ELMA.SR.T((string) EntityMetadata.MSCsnub9C12rHGsiMtFQ(1574260816 ^ 1574413598)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 7 : 16;
            continue;
          case 9:
            goto label_11;
          case 10:
            EntityMetadata.BnubhCb9kbqvLIeQlx1u((object) property, true);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
            continue;
          case 11:
            property = (EntityPropertyMetadata) this.CreateProperty(true);
            num1 = 10;
            continue;
          case 12:
            this.Properties.Insert(index, (PropertyMetadata) property);
            num1 = 15;
            continue;
          case 13:
            num2 = 0;
            break;
          case 14:
            EntityMetadata.rQfP93b9D6GkAtUefhfj((object) property, this.Uid);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 3 : 7;
            continue;
          case 16:
            property.TypeUid = EntityDescriptor.UID;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 7 : 14;
            continue;
          default:
            EntityMetadata.cVHUUMb9aSBjpFl1k110((object) property, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886609991));
            num1 = 8;
            continue;
        }
        index = num2;
        num1 = 12;
      }
label_10:
      return property;
label_11:
      throw new MetadataException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105367370), EntityMetadata.MSCsnub9C12rHGsiMtFQ(-53329496 >> 4 ^ -3296212)));
    }

    /// <summary>
    /// Создать свойство, определяющее, является ли объект группой
    /// </summary>
    /// <param name="add">Добавлять в список свойств</param>
    /// <returns>Свойство, определяющее, является ли объект группой</returns>
    public virtual EntityPropertyMetadata CreateIsGroupProperty(bool add = true)
    {
      int num1 = 2;
      EntityPropertyMetadata property;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          int index;
          PropertyMetadata propertyMetadata;
          int num3;
          switch (num2)
          {
            case 1:
              goto label_5;
            case 2:
              property = (EntityPropertyMetadata) this.CreateProperty(true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 1 : 1;
              continue;
            case 3:
              num3 = 0;
              break;
            case 4:
              EntityMetadata.cVHUUMb9aSBjpFl1k110((object) property, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669371371 ^ 1669474043));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
              continue;
            case 5:
            case 10:
              goto label_10;
            case 6:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (this.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p1 => EntityMetadata.\u003C\u003Ec.jxorCUCAgFwwYEOdnlSU(EntityMetadata.\u003C\u003Ec.GGYkN3CAd3wqJB9NGQDp((object) p1), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345243948)))) == null)
              {
                if (!add)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 5 : 1;
                  continue;
                }
                goto case 13;
              }
              else
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 8 : 7;
                continue;
              }
            case 7:
              goto label_4;
            case 8:
              goto label_6;
            case 9:
              if (propertyMetadata == null)
              {
                num2 = 3;
                continue;
              }
              num3 = this.Properties.IndexOf(propertyMetadata) + 1;
              break;
            case 11:
              EntityMetadata.w7OViVb91h3XMINgZWZj((object) property, BoolDescriptor.UID);
              num2 = 12;
              continue;
            case 12:
              EntityMetadata.V7Vepwb9nDPbbk7y64VT((object) property, false);
              num2 = 7;
              continue;
            case 13:
              propertyMetadata = this.Properties.LastOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p1 => p1.IsSystem));
              num2 = 9;
              continue;
            case 14:
              this.Properties.Insert(index, (PropertyMetadata) property);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 4 : 10;
              continue;
            default:
              goto label_13;
          }
          index = num3;
          num2 = 14;
        }
label_4:
        EntityPropertyMetadata propertyMetadata1 = property;
        BoolSettings boolSettings = new BoolSettings();
        EntityMetadata.NNeqY5b9Ndm2DB1YGjSx((object) boolSettings, EntityMetadata.MSCsnub9C12rHGsiMtFQ(1012087039 ^ 1011977199));
        EntityMetadata.vnLabEb93VkFKvrto4Q8((object) propertyMetadata1, (object) boolSettings);
        num1 = 6;
        continue;
label_5:
        EntityMetadata.BnubhCb9kbqvLIeQlx1u((object) property, true);
        num1 = 4;
        continue;
label_13:
        EntityMetadata.g2fiOOb9PyTZjcDlU9Ag((object) property, EntityMetadata.b1ufNYb9K4idafNcePoK(EntityMetadata.MSCsnub9C12rHGsiMtFQ(-1822890472 ^ -1822811716)));
        num1 = 11;
      }
label_6:
      throw new MetadataException(EleWise.ELMA.SR.T((string) EntityMetadata.MSCsnub9C12rHGsiMtFQ(-2107978722 ^ -2108148918), EntityMetadata.MSCsnub9C12rHGsiMtFQ(1051276242 - 990076387 ^ 61302527)));
label_10:
      return property;
    }

    /// <summary>
    /// Создать метаданные сущности, реализующей интерфейс, который описывают текущие метаданные
    /// </summary>
    /// <param name="extensions">Список метаданных расширений</param>
    /// <returns>Метаданные сущности</returns>
    public virtual EntityMetadata CreateInterfaceImplementationMetadata(
      List<EntityMetadata> extensions = null)
    {
      EntityMetadata metadata1 = ClassSerializationHelper.CloneObjectByXml<EntityMetadata>(this);
      metadata1.Uid = this.ImplementationUid;
      metadata1.ImplementationUid = this.Uid;
      metadata1.Type = EntityMetadataType.InterfaceImplementation;
      this.ReplaceTablePartImplementationUids(metadata1);
      List<PropertyMetadata> properties1 = metadata1.Properties;
      // ISSUE: explicit non-virtual call
      // ISSUE: reference to a compiler-generated method
      int val1_1 = (properties1 != null ? (__nonvirtual (properties1.Count) > 0 ? 1 : 0) : 0) != 0 ? metadata1.Properties.Max<PropertyMetadata>((Func<PropertyMetadata, int>) (p => EntityMetadata.\u003C\u003Ec.rwLexwCA5C07smdsMUmj((object) p))) : 0;
      List<TablePartMetadata> tableParts1 = metadata1.TableParts;
      // ISSUE: explicit non-virtual call
      int val2_1 = (tableParts1 != null ? (__nonvirtual (tableParts1.Count) > 0 ? 1 : 0) : 0) != 0 ? metadata1.TableParts.Max<TablePartMetadata>((Func<TablePartMetadata, int>) (p => p.Order)) : 0;
      int num1 = Math.Max(val1_1, val2_1);
      bool flag = false;
      if (extensions != null && extensions.Count > 0)
      {
        metadata1.ImplementedExtensionUids = new List<Guid>();
        foreach (EntityMetadata entityMetadata in (IEnumerable<EntityMetadata>) extensions.OrderBy<EntityMetadata, bool>((Func<EntityMetadata, bool>) (e => e.IsConfig())))
        {
          metadata1.ImplementedExtensionUids.Add(entityMetadata.Uid);
          EntityMetadata extCloned = ClassSerializationHelper.CloneObjectByXml<EntityMetadata>(entityMetadata);
          this.ReplaceTablePartImplementationUids(extCloned, metadata1.Namespace);
          if (entityMetadata.ImplementedInterfaces != null && entityMetadata.ImplementedInterfaces.Any<string>())
          {
            if (metadata1.ImplementedInterfaces == null)
              metadata1.ImplementedInterfaces = new List<string>();
            foreach (string implementedInterface in entityMetadata.ImplementedInterfaces)
            {
              if (!metadata1.ImplementedInterfaces.Contains(implementedInterface))
                metadata1.ImplementedInterfaces.Add(implementedInterface);
            }
          }
          List<PropertyMetadata> properties2 = extCloned.Properties;
          // ISSUE: explicit non-virtual call
          // ISSUE: reference to a compiler-generated method
          int val1_2 = (properties2 != null ? (__nonvirtual (properties2.Count) > 0 ? 1 : 0) : 0) != 0 ? extCloned.Properties.Min<PropertyMetadata>((Func<PropertyMetadata, int>) (p => EntityMetadata.\u003C\u003Ec.rwLexwCA5C07smdsMUmj((object) p))) : 0;
          List<TablePartMetadata> tableParts2 = extCloned.TableParts;
          // ISSUE: explicit non-virtual call
          // ISSUE: reference to a compiler-generated method
          int val2_2 = (tableParts2 != null ? (__nonvirtual (tableParts2.Count) > 0 ? 1 : 0) : 0) != 0 ? extCloned.TableParts.Min<TablePartMetadata>((Func<TablePartMetadata, int>) (p => EntityMetadata.\u003C\u003Ec.wg1mU8CAjd2WyTJ9U6RM((object) p))) : 0;
          int num2 = Math.Min(val1_2, val2_2);
          int num3 = num1 + 1 - num2;
          foreach (PropertyMetadata propertyMetadata in extCloned.Properties.EmptyIfNull<PropertyMetadata>())
          {
            propertyMetadata.Order += num3;
            if (propertyMetadata.Order > num1)
              num1 = propertyMetadata.Order;
            metadata1.Properties.Add(propertyMetadata);
            flag = true;
          }
          foreach (TablePartMetadata tablePartMetadata in extCloned.TableParts.EmptyIfNull<TablePartMetadata>())
          {
            tablePartMetadata.Order += num3;
            if (tablePartMetadata.Order > num1)
              num1 = tablePartMetadata.Order;
            metadata1.TableParts.Add(tablePartMetadata);
            flag = true;
          }
          PropertiesHelper initializerCache = AbstractMetadata.GetInitializerCache(typeof (PropertyMetadata));
          foreach (PropertyMetadata property in metadata1.Properties)
          {
            PropertyMetadata prop = property;
            PropertiesContainer properties3 = extCloned.PropertiesDiffContainer.FirstOrDefault<PropertiesContainer>((Func<PropertiesContainer, bool>) (c =>
            {
              int num4 = 1;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    if (c.GetPropertyValue((string) EntityMetadata.\u003C\u003Ec__DisplayClass137_1.CbyieQC7IGtJRUC3046f(-35995181 ^ -36000191), (object[]) null) is string)
                    {
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
                      continue;
                    }
                    goto label_5;
                  default:
                    goto label_4;
                }
              }
label_4:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              return EntityMetadata.\u003C\u003Ec__DisplayClass137_1.rjYEGsC7imjgQTudQfdi((object) (string) EntityMetadata.\u003C\u003Ec__DisplayClass137_1.OLqYjwC7V0AqqWdlC8cV((object) c, EntityMetadata.\u003C\u003Ec__DisplayClass137_1.CbyieQC7IGtJRUC3046f(322893104 - -1992822529 ^ -1979225181), (object) null), EntityMetadata.\u003C\u003Ec__DisplayClass137_1.O6aVAaC7SdgSaQMLs2Uo((object) prop), StringComparison.OrdinalIgnoreCase);
label_5:
              return false;
            }));
            if (properties3 != null)
              initializerCache.SetValues(properties3, (object) property);
          }
          if (extCloned.Filterable)
          {
            metadata1.Filterable = true;
            if (extCloned.Filter != null && extCloned.Filter.Properties.Any<PropertyMetadata>())
            {
              foreach (PropertyMetadata property in extCloned.Filter.Properties)
                metadata1.Filter.Properties.Add(property);
            }
          }
          if (extCloned.FormViews != null)
          {
            foreach (FormView formView1 in extCloned.FormViews)
            {
              FormView formView = formView1;
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              FormView formView2 = metadata1.FormViews.FirstOrDefault<FormView>((Func<FormView, bool>) (v => EntityMetadata.\u003C\u003Ec__DisplayClass137_2.HNw0T9C7TpjoAGTgL9OI((object) v) == EntityMetadata.\u003C\u003Ec__DisplayClass137_2.HNw0T9C7TpjoAGTgL9OI((object) formView)));
              if (formView2 != null)
              {
                if (formView2.CanUseCommonView)
                {
                  formView2.ViewInCommon = formView.ViewInCommon;
                  if (formView2.CanUseCommonRazorView)
                  {
                    formView2.UseRazorView = formView.UseRazorView;
                    formView2.UseStandartView = formView.UseStandartView;
                    formView2.RazorCommonViewName = formView.RazorCommonViewName;
                  }
                }
                if (formView2.CanUseTabView)
                {
                  formView2.ViewInTab = formView.ViewInTab;
                  formView2.ViewInTabName = formView.ViewInTabName;
                  if (formView2.CanUseTabRazorView)
                  {
                    formView2.UseRazorView = formView.UseRazorView;
                    formView2.UseStandartView = formView.UseStandartView;
                    formView2.RazorTabViewName = formView.RazorTabViewName;
                  }
                }
              }
            }
          }
          if (!string.IsNullOrEmpty(extCloned.ScriptModuleTypeName))
            metadata1.ScriptModuleTypeName = extCloned.ScriptModuleTypeName;
          if (!string.IsNullOrEmpty(extCloned.OnViewLoadScriptName))
            metadata1.OnViewLoadScriptName = extCloned.OnViewLoadScriptName;
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          if (extCloned.TitlePropertyUid != Guid.Empty && extCloned.Properties.Exists((Predicate<PropertyMetadata>) (p => EntityMetadata.\u003C\u003Ec__DisplayClass137_0.YVtsENC7CjROhEynTUqm(EntityMetadata.\u003C\u003Ec__DisplayClass137_0.ddtbWyC7fkoHggm6o63N((object) p), EntityMetadata.\u003C\u003Ec__DisplayClass137_0.jxUNg2C7QIr5y5FVOR4S((object) extCloned)))))
            metadata1.TitlePropertyUid = extCloned.TitlePropertyUid;
          if (extCloned.CacheEntity)
            metadata1.CacheEntity = true;
          if (!metadata1.SaveHistory && extCloned.SaveHistory)
            metadata1.SaveHistory = true;
        }
      }
      if (metadata1.BaseClassUid != Guid.Empty)
      {
        EntityMetadata metadata2 = (EntityMetadata) MetadataServiceContext.Service.GetMetadata(metadata1.BaseClassUid);
        if (metadata2 != null)
          metadata1.BaseClassUid = metadata2.ImplementationUid;
      }
      metadata1.Forms = new List<FormViewItem>();
      metadata1.FormTransformations = new List<FormViewItemTransformation>();
      if (flag)
        metadata1.ClearPropertiesAndTablePartsCache();
      return metadata1;
    }

    /// <summary>Создать метаданные модели отображения</summary>
    /// <returns>Метаданные модели отображения</returns>
    public virtual DataClassMetadata CreateViewModelMetadata()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (EntityMetadata.ocqdN7b9tuUUs37e14Qy((object) this) == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_4:
      throw new MetadataException(EleWise.ELMA.SR.T((string) EntityMetadata.MSCsnub9C12rHGsiMtFQ(-1921202237 ^ -1921107957)));
label_5:
      DataClassMetadata viewModelMetadata = new DataClassMetadata(EntityMetadata.BHxaGSb9wF2CMrJKn4Lg((object) this));
      EntityMetadata.ebwKYKb96UFZbo9eMBEK((object) viewModelMetadata, EntityMetadata.Jc5v0Bb94pyOyugernvS());
      EntityMetadata.cVHUUMb9aSBjpFl1k110((object) viewModelMetadata, EntityMetadata.MSCsnub9C12rHGsiMtFQ(1654249598 >> 2 ^ 413450795));
      EntityMetadata.sxyCdbb9AGlPxFTYtSP7((object) viewModelMetadata, EntityMetadata.y54tYUb9HRDqD1yuI3TS((object) this));
      EntityMetadata.cLFuxub9xymhDZViiMHn((object) viewModelMetadata, EntityMetadata.yHx0eDb97ZQdEld1Hf8f((object) this));
      viewModelMetadata.DisplayName = (string) EntityMetadata.b1ufNYb9K4idafNcePoK(EntityMetadata.MSCsnub9C12rHGsiMtFQ(-488881205 ^ -488684561));
      viewModelMetadata.Properties.Add((PropertyMetadata) this.CreateModelProperty());
      return viewModelMetadata;
    }

    /// <summary>Сборка, в которой находится данный тип сущности</summary>
    [XmlIgnore]
    public virtual AssemblyModelsMetadata Assembly
    {
      get => this.\u003CAssembly\u003Ek__BackingField;
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
              this.\u003CAssembly\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
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

    /// <summary>Тип метаданных сущности</summary>
    [XmlIgnore]
    public virtual Guid TypeUid
    {
      get => EntityMetadata.UID;
      set
      {
      }
    }

    /// <summary>Список свойств для хранения в БД</summary>
    [EleWise.ELMA.Model.Attributes.Uid("{212818F7-A0C4-40AA-A7EE-EDD40E46A4EB}")]
    [XmlIgnore]
    [EntityProperty]
    [EntitySettings(RelationType = RelationType.OneToMany, KeyColumnUidStr = "{787F7299-01F7-4075-9BDB-6AA1039FEF51}", CascadeMode = CascadeMode.All)]
    [Property("{72ED98CA-F260-4671-9BCD-FF1D80235F47}", "{D5B79720-FBBF-489B-9AA6-49E1C5DA50E4}")]
    public virtual Iesi.Collections.Generic.ISet<EntityPropertyMetadata> EntityProperties
    {
      get
      {
        if (this.entityProperties == null)
          this.entityProperties = (Iesi.Collections.Generic.ISet<EntityPropertyMetadata>) new HashedSet<EntityPropertyMetadata>();
        return this.entityProperties;
      }
      set => this.entityProperties = value;
    }

    /// <summary>Список блоков для хранения в БД</summary>
    [EntitySettings(RelationType = RelationType.OneToMany, KeyColumnUidStr = "{787F7299-01F7-4075-9BDB-6AA1039FEF51}", CascadeMode = CascadeMode.All)]
    [Property("{72ED98CA-F260-4671-9BCD-FF1D80235F47}", "{D5B79720-FBBF-489B-9AA6-49E1C5DA50E4}")]
    [EleWise.ELMA.Model.Attributes.Uid("{22923FDF-4E29-4D56-9DCC-BB294F27BF0C}")]
    [XmlIgnore]
    [EntityProperty]
    public virtual Iesi.Collections.Generic.ISet<TablePartMetadata> EntityTableParts
    {
      get
      {
        if (this.entityTableParts == null)
          this.entityTableParts = (Iesi.Collections.Generic.ISet<TablePartMetadata>) new HashedSet<TablePartMetadata>();
        return this.entityTableParts;
      }
      set => this.entityTableParts = value;
    }

    /// <summary>Инициализировать новый объект метаданных</summary>
    public override void InitNew()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            EntityMetadata.psBHYsb90g78LsEp1ucu((object) this, Guid.NewGuid());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
            continue;
          case 3:
            base.InitNew();
            num = 2;
            continue;
          default:
            this.TableViews.Add((TableView) EntityMetadata.OJWLMcb9mWy1T2ai3Kdt((object) this));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 1 : 0;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Выполнить действия после загрузки объекта метаданных</summary>
    public override void AfterLoad()
    {
      int num1 = 4;
      List<TablePartMetadata>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            EntityMetadata.IkDQXwb9JE7bQi6a0nL8((object) this);
            num1 = 7;
            continue;
          case 2:
            if (EntityMetadata.u9181Tb9uKSltlGfBVHS((object) this) != EntityMetadataType.Interface)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 5 : 5;
              continue;
            }
            goto default;
          case 3:
            if (!EntityMetadata.ApXtOSb9MLRuRuyVK86M(EntityMetadata.LAE7Hpb9y5reETi4PX5l((object) this), Guid.Empty))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 10 : 6;
              continue;
            }
            goto case 6;
          case 4:
            base.AfterLoad();
            num1 = 3;
            continue;
          case 5:
            if (EntityMetadata.u9181Tb9uKSltlGfBVHS((object) this) == EntityMetadataType.Entity)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 0 : 0;
              continue;
            }
            goto case 7;
          case 6:
            if (this.IsUnique)
            {
              num1 = 2;
              continue;
            }
            goto case 7;
          case 7:
          case 10:
            enumerator = this.TableParts.GetEnumerator();
            num1 = 8;
            continue;
          case 8:
            goto label_8;
          case 9:
            goto label_18;
          default:
            if (!this.Properties.Any<PropertyMetadata>((Func<PropertyMetadata, bool>) (p =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    if (!EntityMetadata.\u003C\u003Ec.N6xDBnCAla31u5hR2x1g((object) p))
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 0 : 0;
                      continue;
                    }
                    goto label_4;
                  case 2:
                    goto label_4;
                  default:
                    goto label_5;
                }
              }
label_4:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              return EntityMetadata.\u003C\u003Ec.jxorCUCAgFwwYEOdnlSU((object) p.Name, EntityMetadata.\u003C\u003Ec.cMl811CAr7rfBZp3KZEu(-1852837372 ^ -1852858986));
label_5:
              return false;
            })))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 1;
              continue;
            }
            goto case 7;
        }
      }
label_18:
      return;
label_8:
      try
      {
label_10:
        if (enumerator.MoveNext())
          goto label_12;
        else
          goto label_11;
label_9:
        int num3;
        switch (num3)
        {
          case 1:
            return;
          case 2:
            goto label_12;
          default:
            goto label_10;
        }
label_11:
        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 1 : 1;
        goto label_9;
label_12:
        EntityMetadata.TrDXsSb99aXcKjIghbY7((object) enumerator.Current);
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0)
        {
          num3 = 0;
          goto label_9;
        }
        else
          goto label_9;
      }
      finally
      {
        enumerator.Dispose();
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
          num4 = 0;
        switch (num4)
        {
          default:
        }
      }
    }

    /// <summary>Загрузить метаданные из скомпилированного типа</summary>
    /// <param name="type">Тип</param>
    /// <param name="inherit">True, если нужно выбирать свойства, включая родительские классы</param>
    public override void LoadFromType(System.Type type, bool inherit = true)
    {
      int num1 = 28;
      while (true)
      {
        int num2 = num1;
        CacheEntityAttribute attribute1;
        IEnumerator<InterfaceImplementationAttribute> enumerator1;
        ViewModelMetadataAttribute metadataAttribute;
        IEnumerator<TablePartAttribute> enumerator2;
        ActionsTypeAttribute attribute2;
        FilterableAttribute attribute3;
        HideChildItemsTabAttribute attribute4;
        while (true)
        {
          FilterTypeAttribute attribute5;
          System.Type type1;
          EntityAttribute entityAttribute;
          IEnumerable<ImplementAttribute> source1;
          System.Type type2;
          NonUniqueAttribute attribute6;
          IdTypeAttribute attribute7;
          InstancePermissionAttribute attribute8;
          object[] source2;
          IEnumerator<PropertyInfo> enumerator3;
          ImplementationUidAttribute attribute9;
          EntityActionsMetadata entityActionsMetadata;
          HierarchicalAttribute attribute10;
          IEnumerator<ImplementAttribute> enumerator4;
          CopyActionAttribute attribute11;
          EntityMetadataTypeAttribute attribute12;
          ShowInCatalogListAttribute attribute13;
          SaveHistoryAttribute attribute14;
          object obj;
          switch (num2)
          {
            case 1:
              goto label_144;
            case 2:
              attribute11 = AttributeHelper<CopyActionAttribute>.GetAttribute(type, true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 3 : 45;
              continue;
            case 3:
              // ISSUE: type reference
              // ISSUE: reference to a compiler-generated method
              enumerator3 = ((IEnumerable<PropertyInfo>) EntityMetadata.klJ2Vfbdu0KELvfD4V1D(EntityMetadata.oBU7eQbdZsE0laKLGO8n((object) attribute5))).Where<PropertyInfo>((Func<PropertyInfo, bool>) (p => p.IsDefined(EntityMetadata.\u003C\u003Ec.FRkq2fCAYdFmZ5t0pMWi(__typeref (CustomFilterPropertyAttribute)), false))).GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 10 : 5;
              continue;
            case 4:
            case 29:
              attribute5 = AttributeHelper<FilterTypeAttribute>.GetAttribute(type, false);
              num2 = 76;
              continue;
            case 5:
            case 58:
              if (!EntityMetadata.BLVeRwbdO7qvo6d4C1W1(type2, (System.Type) null))
              {
                num2 = 8;
                continue;
              }
              goto case 49;
            case 6:
            case 23:
            case 59:
label_17:
              type2 = (System.Type) null;
              num2 = 44;
              continue;
            case 7:
              this.PermissionsMetadataName = attribute8.PermissionClassName;
              num2 = 71;
              continue;
            case 8:
            case 66:
              if (!EntityMetadata.CaiuSJbd2806THtDdLdT(type2, (System.Type) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 11 : 4;
                continue;
              }
              // ISSUE: type reference
              obj = EntityMetadata.AKn3LabdRWww6uyU8Ydd(type2, EntityMetadata.kZ2Y2ub9r2rmNOvWuj99(__typeref (InterfaceImplementationAttribute)), false);
              break;
            case 9:
              EntityMetadata.OmlFbIbdQqXCeMRuOLDH((object) this, attribute10 == null ? Guid.Empty : EntityMetadata.qJVdoSbdfMe9B4oe4tuI((object) attribute10));
              num2 = 34;
              continue;
            case 10:
              try
              {
label_25:
                if (EntityMetadata.KEZQ1pbdSfnpcdDt0W12((object) enumerator3))
                  goto label_23;
                else
                  goto label_26;
label_20:
                PropertyMetadata property;
                PropertyInfo current;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      this.Filter.Properties.Add(property);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_109;
                    case 3:
                      goto label_23;
                    case 4:
                      EntityMetadata.uHu7aXbdVTG2YB83vSFT((object) property, (object) current, (object) null);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 1 : 0;
                      continue;
                    case 5:
                      property = ((ClassMetadata) EntityMetadata.HRLsL2bdIi4wO66BKjPO((object) this)).CreateProperty();
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 4 : 4;
                      continue;
                    default:
                      goto label_25;
                  }
                }
label_23:
                current = enumerator3.Current;
                num3 = 5;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
                {
                  num3 = 5;
                  goto label_20;
                }
                else
                  goto label_20;
label_26:
                num3 = 2;
                goto label_20;
              }
              finally
              {
                if (enumerator3 != null)
                {
                  int num4 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
                    num4 = 0;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                        goto label_33;
                      default:
                        enumerator3.Dispose();
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 1;
                        continue;
                    }
                  }
                }
label_33:;
              }
            case 11:
              obj = (object) null;
              break;
            case 12:
              goto label_44;
            case 13:
              EntityMetadata.F7SfXDbdiaZJrOyaHi7m((object) this, (object) entityActionsMetadata);
              num2 = 74;
              continue;
            case 14:
              EntityMetadata.XeQyMHb9sVDtMqpC08oj((object) this, attribute13 != null && EntityMetadata.GYXWE4b9UqgouNX1nIkT((object) attribute13));
              num2 = 21;
              continue;
            case 15:
              type2 = EntityMetadata.G4ppswbdnRCWxyrbf5li((object) type1.Assembly, EntityMetadata.PHyYiEb9SSaAJUBVCAYB((object) type1.FullName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281858172)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 62 : 65;
              continue;
            case 16:
              goto label_42;
            case 17:
              EntityMetadata.tAUjRXb95rtqbrPhFU60((object) this, EntityMetadata.xWdkZPb9gtNWHU7xREpe((object) entityAttribute));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 46 : 46;
              continue;
            case 18:
              goto label_68;
            case 19:
              attribute10 = AttributeHelper<HierarchicalAttribute>.GetAttribute(type, false);
              num2 = 55;
              continue;
            case 20:
              if (source2.Length == 0)
              {
                num2 = 60;
                continue;
              }
              goto case 24;
            case 21:
              attribute3 = AttributeHelper<FilterableAttribute>.GetAttribute(type, true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 1 : 1;
              continue;
            case 22:
              if (!source1.Any<ImplementAttribute>())
              {
                num2 = 6;
                continue;
              }
              goto case 57;
            case 24:
              this.FilterImplementedInterfaces = new List<string>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 25 : 7;
              continue;
            case 25:
              enumerator1 = source2.Cast<InterfaceImplementationAttribute>().GetEnumerator();
              num2 = 12;
              continue;
            case 26:
            case 69:
label_109:
              attribute2 = AttributeHelper<ActionsTypeAttribute>.GetAttribute(type, false);
              num2 = 18;
              continue;
            case 27:
              attribute7 = AttributeHelper<IdTypeAttribute>.GetAttribute(type, true);
              num2 = 43;
              continue;
            case 28:
              base.LoadFromType(type, inherit);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 14 : 27;
              continue;
            case 30:
              EntityMetadata.wHlVC2bdEXxCqG659NnF((object) this, attribute10 != null ? attribute10.ParentPropertyUid : Guid.Empty);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 9 : 8;
              continue;
            case 31:
              attribute14 = AttributeHelper<SaveHistoryAttribute>.GetAttribute(type, true);
              num2 = 54;
              continue;
            case 32:
              try
              {
label_124:
                if (EntityMetadata.KEZQ1pbdSfnpcdDt0W12((object) enumerator4))
                  goto label_115;
                else
                  goto label_125;
label_114:
                ImplementAttribute current;
                UidAttribute attribute15;
                EntityMetadataTypeAttribute attribute16;
                int num5;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      goto label_17;
                    case 2:
                      this.ImplementedExtensionUids.Add(attribute15.Uid);
                      num5 = 6;
                      continue;
                    case 3:
                      this.ImplementedExtensionUids = new List<Guid>();
                      num5 = 2;
                      continue;
                    case 4:
                      if (EntityMetadata.PZdfZcbdkeggfel0yDKp((object) attribute16) == EntityMetadataType.InterfaceExtension)
                      {
                        num5 = 8;
                        continue;
                      }
                      goto label_124;
                    case 5:
                      attribute16 = AttributeHelper<EntityMetadataTypeAttribute>.GetAttribute(EntityMetadata.UcJxLhbdTKIoRmoAo4Pn((object) current), false);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 9 : 3;
                      continue;
                    case 6:
                      goto label_124;
                    case 7:
                      goto label_115;
                    case 8:
                      if (this.ImplementedExtensionUids == null)
                      {
                        num5 = 3;
                        continue;
                      }
                      goto case 2;
                    case 9:
                      if (attribute15 != null)
                      {
                        num5 = 10;
                        continue;
                      }
                      goto label_124;
                    case 10:
                      if (attribute16 != null)
                      {
                        num5 = 4;
                        continue;
                      }
                      goto label_124;
                    case 11:
                      if (current.InterfaceType != (System.Type) null)
                      {
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
                        continue;
                      }
                      goto label_124;
                    default:
                      attribute15 = AttributeHelper<UidAttribute>.GetAttribute(current.InterfaceType, false);
                      num5 = 5;
                      continue;
                  }
                }
label_115:
                current = enumerator4.Current;
                num5 = 11;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
                {
                  num5 = 11;
                  goto label_114;
                }
                else
                  goto label_114;
label_125:
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 1;
                goto label_114;
              }
              finally
              {
                int num6;
                if (enumerator4 == null)
                  num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
                else
                  goto label_136;
label_135:
                switch (num6)
                {
                  case 1:
                    break;
                  default:
                }
label_136:
                EntityMetadata.o1gF4NbdXKddorlqXlai((object) enumerator4);
                num6 = 2;
                goto label_135;
              }
            case 33:
              attribute6 = AttributeHelper<NonUniqueAttribute>.GetAttribute(type, false);
              num2 = 37;
              continue;
            case 34:
              attribute8 = AttributeHelper<InstancePermissionAttribute>.GetAttribute(type, true);
              num2 = 47;
              continue;
            case 35:
              entityActionsMetadata = new EntityActionsMetadata();
              num2 = 56;
              continue;
            case 36:
              attribute4 = AttributeHelper<HideChildItemsTabAttribute>.GetAttribute(type, false);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 27 : 61;
              continue;
            case 37:
              EntityMetadata.m6CfLsbdBG0hbabpsM4T((object) this, attribute6 == null);
              num2 = 36;
              continue;
            case 38:
              if (metadataAttribute != null)
              {
                num2 = 77;
                continue;
              }
              goto label_143;
            case 39:
            case 41:
              // ISSUE: type reference
              entityAttribute = (EntityAttribute) ((IEnumerable<object>) type.GetReflectionCustomAttributes(EntityMetadata.kZ2Y2ub9r2rmNOvWuj99(__typeref (EntityAttribute)), false)).FirstOrDefault<object>();
              num2 = 42;
              continue;
            case 40:
              EntityMetadata.aoUZ2Fbdvk8afxpj32lp((object) this, EntityMetadata.GCefPVbdC6XrSZW9WgOk((object) attribute8));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 1 : 7;
              continue;
            case 42:
              if (entityAttribute != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 17 : 13;
                continue;
              }
              goto case 46;
            case 43:
              if (attribute7 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 23 : 41;
                continue;
              }
              goto case 72;
            case 44:
              type1 = type;
              num2 = 5;
              continue;
            case 45:
              this.CopyAction = attribute11 == null ? CopyAction.Default : EntityMetadata.Ew7sn5b9LHrFHKfpApCg((object) attribute11);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
              continue;
            case 46:
              attribute12 = AttributeHelper<EntityMetadataTypeAttribute>.GetAttribute(type, true);
              num2 = 75;
              continue;
            case 47:
              if (attribute8 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 3 : 4;
                continue;
              }
              goto case 40;
            case 48:
            case 60:
              goto label_36;
            case 49:
              if (!EntityMetadata.CaiuSJbd2806THtDdLdT(type1, (System.Type) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 66 : 14;
                continue;
              }
              goto case 15;
            case 50:
              if (EntityMetadata.MwvFZob9IeSSvNL1DMg8((object) this))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 3 : 16;
                continue;
              }
              goto case 67;
            case 51:
              this.ImplementationUid = attribute9 != null ? EntityMetadata.P4eRyHb9YsgKQTZ07iSG((object) attribute9) : Guid.Empty;
              num2 = 31;
              continue;
            case 52:
label_11:
              // ISSUE: type reference
              source1 = type.GetReflectionCustomAttributes(EntityMetadata.kZ2Y2ub9r2rmNOvWuj99(__typeref (ImplementAttribute)), false).Cast<ImplementAttribute>();
              num2 = 73;
              continue;
            case 53:
              if (source2 != null)
              {
                num2 = 20;
                continue;
              }
              goto label_36;
            case 54:
              this.SaveHistory = attribute14 != null && attribute14.SaveHistory;
              num2 = 2;
              continue;
            case 55:
              EntityMetadata.JQVfpJbdb0Psh84IQk7J((object) this, attribute10 != null);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 64 : 5;
              continue;
            case 56:
              entityActionsMetadata.LoadFromType(attribute2.ActionsType, true);
              num2 = 13;
              continue;
            case 57:
              enumerator4 = source1.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 8 : 32;
              continue;
            case 61:
              goto label_146;
            case 62:
              goto label_9;
            case 63:
              this.CacheEntity = attribute1 != null && EntityMetadata.hgBftQbdFQTxc8uGuTpE((object) attribute1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 1 : 33;
              continue;
            case 64:
              EntityMetadata.B7FEYZbdGmNWw4wjp6iy((object) this, attribute10 != null ? EntityMetadata.Na4DuRbdhRMFSyVorWOn((object) attribute10) : HierarchyType.GroupAndElements);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 14 : 30;
              continue;
            case 65:
              type1 = type1.BaseType;
              num2 = 58;
              continue;
            case 67:
              attribute9 = AttributeHelper<ImplementationUidAttribute>.GetAttribute(type, true);
              num2 = 51;
              continue;
            case 68:
              goto label_150;
            case 70:
              try
              {
label_85:
                if (enumerator2.MoveNext())
                  goto label_87;
                else
                  goto label_86;
label_83:
                TablePartMetadata tablePartMetadata;
                TablePartAttribute current;
                int num7;
                while (true)
                {
                  switch (num7)
                  {
                    case 1:
                      this.TableParts.Add(tablePartMetadata);
                      num7 = 5;
                      continue;
                    case 2:
                      tablePartMetadata = new TablePartMetadata();
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 6 : 0;
                      continue;
                    case 3:
                      goto label_11;
                    case 4:
                      EntityMetadata.kAi9VXbdKnTAuSWTm4QJ((object) tablePartMetadata, type);
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 1 : 1;
                      continue;
                    case 5:
                      goto label_85;
                    case 6:
                      tablePartMetadata.LoadFromType(EntityMetadata.luY4dCbdqdrYeoMnf6IJ((object) current), true);
                      num7 = 4;
                      continue;
                    default:
                      goto label_87;
                  }
                }
label_86:
                num7 = 3;
                goto label_83;
label_87:
                current = enumerator2.Current;
                num7 = 2;
                goto label_83;
              }
              finally
              {
                if (enumerator2 != null)
                {
                  int num8 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
                    num8 = 0;
                  while (true)
                  {
                    switch (num8)
                    {
                      case 1:
                        goto label_96;
                      default:
                        EntityMetadata.o1gF4NbdXKddorlqXlai((object) enumerator2);
                        num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 1;
                        continue;
                    }
                  }
                }
label_96:;
              }
            case 71:
              EntityMetadata.k8BiJhbd8gvf9BwTNjwN((object) this, (object) attribute8.PermissionPropertyName);
              num2 = 29;
              continue;
            case 72:
              EntityMetadata.FN7c6fb9lpZKsUEgrGJD((object) this, EntityMetadata.bsUXS9b9dZsOW9nvqA6r((object) attribute7));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 39 : 13;
              continue;
            case 73:
              if (source1 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 35 : 59;
                continue;
              }
              goto case 22;
            case 74:
              goto label_43;
            case 75:
              EntityMetadata.oIgoITb9RViQbgYAReRL((object) this, attribute12 == null ? EntityMetadataType.Entity : attribute12.Type);
              num2 = 50;
              continue;
            case 76:
              if (attribute5 != null)
                goto case 3;
              else
                goto label_59;
            case 77:
              EntityMetadata.zSU12RbdPlp5SdyfTrSC((object) this, (object) metadataAttribute.ViewModelMetadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 68 : 6;
              continue;
            default:
              attribute13 = AttributeHelper<ShowInCatalogListAttribute>.GetAttribute(type, false);
              num2 = 14;
              continue;
          }
          source2 = (object[]) obj;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 25 : 53;
        }
label_9:
        attribute1 = AttributeHelper<CacheEntityAttribute>.GetAttribute(type, true);
        num1 = 63;
        continue;
label_36:
        // ISSUE: type reference
        metadataAttribute = type.GetReflectionCustomAttributes(EntityMetadata.kZ2Y2ub9r2rmNOvWuj99(__typeref (ViewModelMetadataAttribute)), false).Cast<ViewModelMetadataAttribute>().FirstOrDefault<ViewModelMetadataAttribute>();
        num1 = 38;
        continue;
label_42:
        EntityMetadata.cVHUUMb9aSBjpFl1k110((object) this, EntityMetadata.T1RBaZb9jGqJ9pFHRAUO(EntityMetadata.L0eoFnb9VOa5jPxqCHeG((object) this), 1));
        num1 = 67;
        continue;
label_43:
        // ISSUE: type reference
        enumerator2 = ((IEnumerable) EntityMetadata.AKn3LabdRWww6uyU8Ydd(type, EntityMetadata.kZ2Y2ub9r2rmNOvWuj99(__typeref (TablePartAttribute)), inherit)).Cast<TablePartAttribute>().GetEnumerator();
        num1 = 70;
        continue;
label_44:
        try
        {
label_46:
          if (enumerator1.MoveNext())
            goto label_49;
          else
            goto label_47;
label_45:
          InterfaceImplementationAttribute current;
          int num9;
          while (true)
          {
            switch (num9)
            {
              case 1:
                goto label_36;
              case 2:
                this.FilterImplementedInterfaces.Add((string) EntityMetadata.lOdcPobde3ox0w7WuctH((object) current));
                num9 = 3;
                continue;
              case 3:
                goto label_46;
              default:
                goto label_49;
            }
          }
label_47:
          num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 1 : 1;
          goto label_45;
label_49:
          current = enumerator1.Current;
          num9 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
          {
            num9 = 2;
            goto label_45;
          }
          else
            goto label_45;
        }
        finally
        {
          if (enumerator1 != null)
          {
            int num10 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
              num10 = 0;
            while (true)
            {
              switch (num10)
              {
                case 1:
                  goto label_56;
                default:
                  EntityMetadata.o1gF4NbdXKddorlqXlai((object) enumerator1);
                  num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 1 : 0;
                  continue;
              }
            }
          }
label_56:;
        }
label_59:
        num1 = 26;
        continue;
label_68:
        if (attribute2 != null)
        {
          num1 = 35;
          continue;
        }
        goto label_43;
label_144:
        EntityMetadata.vHdbBkb9zEsPIt8PRMco((object) this, attribute3 != null && EntityMetadata.a6Sl1Db9cJ8MtAIjDdhJ((object) attribute3));
        num1 = 62;
        continue;
label_146:
        EntityMetadata.LoBFLsbdoNMoMO70VHiT((object) this, attribute4 != null && EntityMetadata.fOMykkbdWbMZPLcfdcjX((object) attribute4));
        num1 = 19;
      }
label_150:
      return;
label_143:;
    }

    /// <summary>Применить изменения, не требующие перезапуска сервера</summary>
    public override void ApplyRestartUnrequiredChanges(bool inherit)
    {
      int num1 = 22;
      Dictionary<Guid, IPropertyMetadata> dictionary;
      IEnumerator<IPropertyMetadata> enumerator1;
      while (true)
      {
        MetadataItemManager metadataItemManager1;
        EntityMetadata implementationMetadata;
        EntityMetadata entityMetadata1;
        List<Guid>.Enumerator enumerator2;
        EntityMetadata entityMetadata2;
        EntityMetadata entityMetadata3;
        MetadataItemManager metadataItemManager2;
        List<EntityMetadata> changedExtensions;
        switch (num1)
        {
          case 1:
            if (metadataItemManager1 != null)
            {
              num1 = 28;
              continue;
            }
            goto label_38;
          case 2:
            goto label_72;
          case 3:
            goto label_36;
          case 4:
            entityMetadata2 = (EntityMetadata) MetadataLoader.LoadMetadata(EntityMetadata.LAE7Hpb9y5reETi4PX5l((object) this), loadImplementation: false);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 18 : 15;
            continue;
          case 5:
label_57:
            if (entityMetadata1 == null)
            {
              num1 = 8;
              continue;
            }
            goto case 17;
          case 6:
            entityMetadata3 = (EntityMetadata) MetadataLoader.LoadMetadata(EntityMetadata.w8ojd4bdN2h9nP2oNp2p((object) this), false, false);
            goto label_69;
          case 7:
            try
            {
label_26:
              if (enumerator2.MoveNext())
                goto label_21;
              else
                goto label_27;
label_19:
              Guid current;
              int num2;
              while (true)
              {
                EntityMetadata entityMetadata4;
                switch (num2)
                {
                  case 1:
                  case 6:
                    goto label_26;
                  case 2:
                    entityMetadata4 = EntityMetadata.sMk9Iabd3ltQ9tJG6HDF((object) metadataItemManager1, current) as EntityMetadata;
                    num2 = 3;
                    continue;
                  case 3:
                    if (entityMetadata4 == null)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 6 : 5;
                      continue;
                    }
                    break;
                  case 4:
                    goto label_21;
                  case 5:
                    goto label_57;
                }
                changedExtensions.Add(entityMetadata4);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 1 : 0;
              }
label_21:
              current = enumerator2.Current;
              num2 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
              {
                num2 = 2;
                goto label_19;
              }
              else
                goto label_19;
label_27:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 5 : 5;
              goto label_19;
            }
            finally
            {
              enumerator2.Dispose();
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0)
                num3 = 0;
              switch (num3)
              {
                default:
              }
            }
          case 8:
            if (EntityMetadata.IN0xpWbdpMAt1cDhitZm((object) changedExtensions) <= 0)
            {
              num1 = 9;
              continue;
            }
            goto case 17;
          case 9:
          case 14:
            if (!inherit)
            {
              num1 = 2;
              continue;
            }
            goto case 24;
          case 10:
            goto label_32;
          case 11:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 15 : 26;
            continue;
          case 12:
            goto label_66;
          case 13:
            goto label_51;
          case 15:
            this.DefaultForms = (ClassDefaultForms) null;
            num1 = 14;
            continue;
          case 16:
            if (this.ImplementedExtensionUids != null)
            {
              num1 = 19;
              continue;
            }
            goto case 5;
          case 17:
            entityMetadata3 = entityMetadata1;
            if (entityMetadata3 == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 6;
              continue;
            }
            goto label_69;
          case 18:
            if (entityMetadata2 == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 2 : 12;
              continue;
            }
            goto case 27;
          case 19:
            enumerator2 = this.ImplementedExtensionUids.GetEnumerator();
            num1 = 7;
            continue;
          case 20:
            enumerator1 = ((IEnumerable<IPropertyMetadata>) this.Properties).EmptyIfNull<IPropertyMetadata>().Concat<IPropertyMetadata>(((IEnumerable<IPropertyMetadata>) this.TableParts).EmptyIfNull<IPropertyMetadata>()).GetEnumerator();
            num1 = 3;
            continue;
          case 21:
            if (!EntityMetadata.gxA5fpbd1mI5H7HnfHLx())
            {
              num1 = 23;
              continue;
            }
            metadataItemManager2 = Locator.GetService<MetadataItemManager>();
            break;
          case 22:
            base.ApplyRestartUnrequiredChanges(inherit);
            num1 = 21;
            continue;
          case 23:
            metadataItemManager2 = (MetadataItemManager) null;
            break;
          case 24:
            if (EntityMetadata.qefXcqb9hAjwEVDPpQRp(EntityMetadata.LAE7Hpb9y5reETi4PX5l((object) this), Guid.Empty))
            {
              num1 = 4;
              continue;
            }
            goto label_70;
          case 25:
            changedExtensions = new List<EntityMetadata>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 13 : 16;
            continue;
          case 26:
            entityMetadata1 = EntityMetadata.sMk9Iabd3ltQ9tJG6HDF((object) metadataItemManager1, EntityMetadata.w8ojd4bdN2h9nP2oNp2p((object) this)) as EntityMetadata;
            num1 = 25;
            continue;
          case 27:
            IEnumerable<IPropertyMetadata> source = ((IEnumerable<IPropertyMetadata>) entityMetadata2.Properties).EmptyIfNull<IPropertyMetadata>().Concat<IPropertyMetadata>(((IEnumerable<IPropertyMetadata>) entityMetadata2.TableParts).EmptyIfNull<IPropertyMetadata>());
            // ISSUE: reference to a compiler-generated field
            Func<IPropertyMetadata, Guid> func = EntityMetadata.\u003C\u003Ec.\u003C\u003E9__155_2;
            Func<IPropertyMetadata, Guid> keySelector;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              EntityMetadata.\u003C\u003Ec.\u003C\u003E9__155_2 = keySelector = (Func<IPropertyMetadata, Guid>) (p => EntityMetadata.\u003C\u003Ec.K16vuXCALP1bQ71C13xU((object) p));
            }
            else
              goto label_75;
label_74:
            dictionary = source.ToDictionary<IPropertyMetadata, Guid>(keySelector);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 11 : 20;
            continue;
label_75:
            keySelector = func;
            goto label_74;
          case 28:
            if (this.Type == EntityMetadataType.InterfaceImplementation)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 5 : 11;
              continue;
            }
            goto case 9;
          default:
            EntityMetadata.ItvkAkbdaGHmfAu5jPyF((object) this, (object) implementationMetadata);
            num1 = 15;
            continue;
        }
        metadataItemManager1 = metadataItemManager2;
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 1;
        continue;
label_69:
        implementationMetadata = entityMetadata3.CreateInterfaceImplementationMetadata(this.ImplementedExtensionUids == null ? (List<EntityMetadata>) null : this.ImplementedExtensionUids.Select<Guid, EntityMetadata>((Func<Guid, EntityMetadata>) (uid =>
        {
          int num4 = 2;
          EntityMetadata entityMetadata5;
          Guid uid1;
          while (true)
          {
            switch (num4)
            {
              case 1:
                uid1 = uid;
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 3 : 0;
                continue;
              case 2:
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 1 : 1;
                continue;
              case 3:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                entityMetadata5 = changedExtensions.FirstOrDefault<EntityMetadata>((Func<EntityMetadata, bool>) (e => EntityMetadata.\u003C\u003Ec__DisplayClass155_1.QcZA7PC7pkpwvqYxYXZe(EntityMetadata.\u003C\u003Ec__DisplayClass155_1.yBU3p4C73eQeP5HKwiJ5((object) e), uid1)));
                if (entityMetadata5 == null)
                {
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
                  continue;
                }
                goto label_2;
              default:
                goto label_7;
            }
          }
label_2:
          return entityMetadata5;
label_7:
          return (EntityMetadata) MetadataLoader.LoadMetadata(uid1, false, false);
        })).ToList<EntityMetadata>());
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
      }
label_72:
      return;
label_32:
      return;
label_66:
      return;
label_51:
      return;
label_38:
      return;
label_70:
      return;
label_36:
      try
      {
label_41:
        if (EntityMetadata.KEZQ1pbdSfnpcdDt0W12((object) enumerator1))
          goto label_43;
        else
          goto label_42;
label_37:
        IPropertyMetadata current;
        IPropertyMetadata propertyMetadata;
        int num5;
        while (true)
        {
          switch (num5)
          {
            case 1:
              EntityMetadata.ItvkAkbdaGHmfAu5jPyF((object) current, (object) propertyMetadata);
              num5 = 4;
              continue;
            case 2:
              if (dictionary.TryGetValue(EntityMetadata.t8hAWabdDTeMjAp2Scjc((object) current), out propertyMetadata))
              {
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 1;
                continue;
              }
              goto label_41;
            case 3:
              goto label_46;
            case 4:
              goto label_41;
            default:
              goto label_43;
          }
        }
label_46:
        return;
label_42:
        num5 = 3;
        goto label_37;
label_43:
        current = enumerator1.Current;
        num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0)
        {
          num5 = 2;
          goto label_37;
        }
        else
          goto label_37;
      }
      finally
      {
        if (enumerator1 != null)
        {
          int num6 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
            num6 = 0;
          while (true)
          {
            switch (num6)
            {
              case 1:
                goto label_53;
              default:
                EntityMetadata.o1gF4NbdXKddorlqXlai((object) enumerator1);
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 1 : 0;
                continue;
            }
          }
        }
label_53:;
      }
    }

    /// <summary>Получить метаданные составных частей</summary>
    /// <returns>Метаданные составных частей</returns>
    public virtual IEnumerable<IMetadata> GetCompositeParts() => (IEnumerable<IMetadata>) this.TableParts;

    protected override IEnumerable<PropertyInfo> GetPropertyInfosWithMetadata(
      System.Type type,
      bool inherit)
    {
      List<PropertyInfo> infosWithMetadata = new List<PropertyInfo>();
      for (; type != (System.Type) null; type = type.BaseType)
      {
        BindingFlags bindingAttr = BindingFlags.Instance | BindingFlags.Public;
        BaseClassAttribute attribute1 = AttributeHelper<BaseClassAttribute>.GetAttribute(type, true);
        bool flag = attribute1 != null && attribute1.BaseClassUid != Guid.Empty;
        if (flag)
          bindingAttr |= BindingFlags.DeclaredOnly;
        List<PropertyInfo> list = ((IEnumerable<PropertyInfo>) type.GetReflectionProperties(bindingAttr)).Where<PropertyInfo>((Func<PropertyInfo, bool>) (p =>
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                // ISSUE: reference to a compiler-generated method
                if (!EntityMetadata.\u003C\u003Ec.Fe9RktCAUIvTFqrywH8Z((object) p, typeof (EntityPropertyAttribute), false))
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
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
          // ISSUE: type reference
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          return !EntityMetadata.\u003C\u003Ec.Fe9RktCAUIvTFqrywH8Z((object) p, EntityMetadata.\u003C\u003Ec.FRkq2fCAYdFmZ5t0pMWi(__typeref (TablePartPropertyAttribute)), false);
label_3:
          return false;
        })).ToList<PropertyInfo>();
        // ISSUE: type reference
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if (list.Any<PropertyInfo>((Func<PropertyInfo, bool>) (p => EntityMetadata.\u003C\u003Ec.Fe9RktCAUIvTFqrywH8Z((object) p, EntityMetadata.\u003C\u003Ec.FRkq2fCAYdFmZ5t0pMWi(__typeref (OrderAttribute)), true))))
          list = list.OrderBy<PropertyInfo, int>((Func<PropertyInfo, int>) (p =>
          {
            int num = 3;
            OrderAttribute attribute2;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_6;
                case 2:
                  if (attribute2 != null)
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 1 : 1;
                    continue;
                  }
                  goto label_5;
                case 3:
                  attribute2 = AttributeHelper<OrderAttribute>.GetAttribute((MemberInfo) p, true);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 2;
                  continue;
                default:
                  goto label_5;
              }
            }
label_5:
            return 0;
label_6:
            // ISSUE: reference to a compiler-generated method
            return EntityMetadata.\u003C\u003Ec.Ewv0A3CAssoYwJU8PIo8((object) attribute2);
          })).ToList<PropertyInfo>();
        infosWithMetadata.InsertRange(0, (IEnumerable<PropertyInfo>) list);
        if (!inherit || !flag)
          break;
      }
      return (IEnumerable<PropertyInfo>) infosWithMetadata;
    }

    protected override void OnNamespaceChanged()
    {
      int num1 = 2;
      List<TablePartMetadata>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (this.TableParts != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 1 : 3;
              continue;
            }
            goto label_14;
          case 2:
            base.OnNamespaceChanged();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 1;
            continue;
          case 3:
            enumerator = this.TableParts.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
            continue;
          case 4:
            goto label_18;
          default:
            goto label_6;
        }
      }
label_18:
      return;
label_14:
      return;
label_6:
      try
      {
label_12:
        if (enumerator.MoveNext())
          goto label_10;
        else
          goto label_13;
label_8:
        int num2;
        switch (num2)
        {
          case 1:
            break;
          case 2:
            return;
          default:
            goto label_12;
        }
label_10:
        EntityMetadata.sxyCdbb9AGlPxFTYtSP7((object) enumerator.Current, EntityMetadata.y54tYUb9HRDqD1yuI3TS((object) this));
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
        {
          num2 = 0;
          goto label_8;
        }
        else
          goto label_8;
label_13:
        num2 = 2;
        goto label_8;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    protected virtual void OnTypeChanged()
    {
      int num1 = 2;
      List<TablePartMetadata>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_16;
          case 1:
            goto label_12;
          case 2:
            if (this.TableParts == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 1 : 0;
              continue;
            }
            goto case 3;
          case 3:
            enumerator = this.TableParts.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 4 : 2;
            continue;
          case 4:
            goto label_4;
          default:
            goto label_10;
        }
      }
label_16:
      return;
label_12:
      return;
label_10:
      return;
label_4:
      try
      {
label_7:
        if (enumerator.MoveNext())
          goto label_9;
        else
          goto label_8;
label_5:
        int num2;
        switch (num2)
        {
          case 0:
            return;
          case 1:
            goto label_9;
          case 2:
            goto label_7;
          default:
            return;
        }
label_8:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 0;
        goto label_5;
label_9:
        EntityMetadata.oIgoITb9RViQbgYAReRL((object) enumerator.Current, !EntityMetadata.MwvFZob9IeSSvNL1DMg8((object) this) ? EntityMetadata.u9181Tb9uKSltlGfBVHS((object) this) : EntityMetadataType.Interface);
        num2 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
        {
          num2 = 1;
          goto label_5;
        }
        else
          goto label_5;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    /// <summary>
    /// Получить список форм данного класса (учитывая унаследованные формы и преобразования форм)
    /// </summary>
    protected override void GetForms(List<FormViewItem> forms, ClassDefaultForms defaultForms)
    {
      if (this.Type == EntityMetadataType.InterfaceImplementation)
      {
        (this.BaseClassUid != Guid.Empty ? (EntityMetadata) MetadataServiceContext.Service.GetMetadata(this.BaseClassUid, false) : (EntityMetadata) null)?.GetForms(forms, defaultForms);
        EntityMetadata metadata1 = (EntityMetadata) MetadataServiceContext.Service.GetMetadata(this.ImplementationUid, false);
        ClassMetadata.AddForms(forms, (ClassMetadata) metadata1, defaultForms);
        ClassMetadata.AddFormsSettings((ClassMetadata) metadata1, defaultForms);
        if (this.ImplementedExtensionUids == null || this.ImplementedExtensionUids.Count <= 0)
          return;
        EntityMetadata metadata2 = (EntityMetadata) null;
        bool flag = MetadataServiceContext.MetadataRuntimeServiceOrNull != null;
        foreach (Guid implementedExtensionUid in this.ImplementedExtensionUids)
        {
          EntityMetadata metadata3 = (EntityMetadata) MetadataServiceContext.Service.GetMetadata(implementedExtensionUid, false);
          if (flag && metadata2 == null && implementedExtensionUid.IsConfigMetadata())
          {
            metadata2 = metadata3;
          }
          else
          {
            ClassMetadata.AddForms(forms, (ClassMetadata) metadata3, defaultForms);
            ClassMetadata.AddFormsSettings((ClassMetadata) metadata3, defaultForms);
          }
        }
        if (metadata2 == null)
          return;
        ClassMetadata.AddForms(forms, (ClassMetadata) metadata2, defaultForms);
        ClassMetadata.AddFormsSettings((ClassMetadata) metadata2, defaultForms);
      }
      else if (this.Type == EntityMetadataType.InterfaceExtension)
      {
        EntityMetadata metadata = (EntityMetadata) MetadataServiceContext.Service.GetMetadata(this.BaseClassUid, false);
        forms.AddRange(metadata.GetForms());
        ClassMetadata.AddForms(forms, (ClassMetadata) this, defaultForms);
        ClassMetadata.AddFormsSettings((ClassMetadata) this, defaultForms);
      }
      else
        base.GetForms(forms, defaultForms);
    }

    /// <inheritdoc />
    public override ClassDefaultForms DefaultForms
    {
      get
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 1:
              EntityMetadata.cbCwSdbdtHSPulP8HTqR((object) this);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
              continue;
            case 3:
              if (base.DefaultForms != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 2 : 2;
                continue;
              }
              goto case 1;
            default:
              goto label_5;
          }
        }
label_5:
        return base.DefaultForms;
      }
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
              base.DefaultForms = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
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

    /// <inheritdoc />
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override bool ShouldSerializeDefaultForms()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.Type != EntityMetadataType.InterfaceImplementation)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return base.ShouldSerializeDefaultForms();
label_5:
      return false;
    }

    /// <summary>
    /// Инициализировать идентификаторы форм по умолчанию для метаданных реализации сущности
    /// </summary>
    protected internal virtual void InitializeImplDefaultForms()
    {
      int num = 3;
      List<FormViewItem> forms;
      ClassDefaultForms defaultForms;
      ClassDefaultForms classDefaultForms;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            this.DefaultForms = classDefaultForms = new ClassDefaultForms();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 0 : 0;
            continue;
          case 3:
            forms = new List<FormViewItem>();
            num = 2;
            continue;
          case 4:
            this.GetForms(forms, defaultForms);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 1;
            continue;
          default:
            defaultForms = classDefaultForms;
            num = 4;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Создать метаданные свойства модели отображения</summary>
    protected virtual ViewModelPropertyMetadata CreateModelProperty()
    {
      ViewModelPropertyMetadata modelProperty = new ViewModelPropertyMetadata();
      EntityMetadata.ebwKYKb96UFZbo9eMBEK((object) modelProperty, EntityMetadata.Jc5v0Bb94pyOyugernvS());
      EntityMetadata.cVHUUMb9aSBjpFl1k110((object) modelProperty, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638455203));
      modelProperty.DisplayName = EleWise.ELMA.SR.T((string) EntityMetadata.MSCsnub9C12rHGsiMtFQ(~541731958 ^ -541666325));
      EntityMetadata.w7OViVb91h3XMINgZWZj((object) modelProperty, EntityDescriptor.UID);
      modelProperty.SubTypeUid = !this.IsInterfaceType ? EntityMetadata.w8ojd4bdN2h9nP2oNp2p((object) this) : EntityMetadata.J7Gxqcb9vHIMg9692ytg((object) this);
      EntityMetadata.BnubhCb9kbqvLIeQlx1u((object) modelProperty, true);
      return modelProperty;
    }

    private void ReplaceTablePartImplementationUids(EntityMetadata metadata, string implNamespace = null)
    {
      int num1 = 3;
      List<TablePartMetadata>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_24;
          case 1:
            goto label_5;
          case 2:
            enumerator = metadata.TableParts.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 1 : 1;
            continue;
          case 3:
            if (metadata.TableParts != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 2 : 1;
              continue;
            }
            goto label_20;
          default:
            goto label_14;
        }
      }
label_24:
      return;
label_14:
      return;
label_20:
      return;
label_5:
      try
      {
label_16:
        if (enumerator.MoveNext())
          goto label_15;
        else
          goto label_17;
label_6:
        TablePartMetadata current;
        Guid guid;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              current.Type = EntityMetadataType.InterfaceImplementation;
              num2 = 8;
              continue;
            case 2:
              EntityMetadata.sxyCdbb9AGlPxFTYtSP7((object) current, (object) implNamespace);
              num2 = 9;
              continue;
            case 3:
              current.ImplementationUid = guid;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 1;
              continue;
            case 4:
            case 9:
              this.ReplaceTablePartImplementationUids((EntityMetadata) current);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 7 : 5;
              continue;
            case 5:
              guid = EntityMetadata.J7Gxqcb9vHIMg9692ytg((object) current);
              num2 = 6;
              continue;
            case 6:
              EntityMetadata.ebwKYKb96UFZbo9eMBEK((object) current, EntityMetadata.w8ojd4bdN2h9nP2oNp2p((object) current));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 3 : 1;
              continue;
            case 7:
              goto label_16;
            case 8:
              if (EntityMetadata.eItW63bdwOs7L4iR5LUU((object) implNamespace))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 2 : 4;
                continue;
              }
              goto case 2;
            case 10:
              goto label_7;
            default:
              goto label_15;
          }
        }
label_7:
        return;
label_15:
        current = enumerator.Current;
        num2 = 5;
        goto label_6;
label_17:
        num2 = 10;
        goto label_6;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    PublicationType IDeltaRootMetadata.GetPublicationTypeOnChange(IMetadata oldMetadata)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (EntityMetadata.u9181Tb9uKSltlGfBVHS((object) this) != EntityMetadataType.Entity)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 1 : 0;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return PublicationType.Restart;
label_5:
      return EntityMetadata.B36o0Hbd4utvh7tjYrWJ((object) oldMetadata, (object) this);
    }

    public EntityMetadata()
    {
      EntityMetadata.axqH2Nbd6sTZrLx8YoTp();
      // ISSUE: reference to a compiler-generated field
      this.\u003CIsUnique\u003Ek__BackingField = true;
      // ISSUE: reference to a compiler-generated field
      this.\u003CIdTypeUid\u003Ek__BackingField = Int64Descriptor.UID;
      // ISSUE: reference to a compiler-generated field
      this.\u003CIsSoftDeletable\u003Ek__BackingField = true;
      // ISSUE: reference to a compiler-generated field
      this.\u003CFilterImplementedInterfaces\u003Ek__BackingField = new List<string>();
      // ISSUE: reference to a compiler-generated field
      this.\u003CFilter\u003Ek__BackingField = new EntityFilterMetadata();
      // ISSUE: reference to a compiler-generated field
      this.\u003CActions\u003Ek__BackingField = new EntityActionsMetadata();
      this.entityProperties = (Iesi.Collections.Generic.ISet<EntityPropertyMetadata>) new HashedSet<EntityPropertyMetadata>();
      this.entityTableParts = (Iesi.Collections.Generic.ISet<TablePartMetadata>) new HashedSet<TablePartMetadata>();
      this.tableParts = new List<TablePartMetadata>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static EntityMetadata()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            EntityMetadata.axqH2Nbd6sTZrLx8YoTp();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            EntityMetadata.UID = new Guid((string) EntityMetadata.MSCsnub9C12rHGsiMtFQ(516838154 ^ 516772728));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    internal static void N11SS9b9oURMEiShgfm2([In] object obj0, [In] object obj1) => ((ClassMetadata) obj0).DefaultForms = (ClassDefaultForms) obj1;

    internal static bool E3Z17Ab9BxCJrLLg72tk() => EntityMetadata.eFWmq3b9FDeoybGQB57N == null;

    internal static EntityMetadata S25dpdb9W3nAayQ9tOs6() => EntityMetadata.eFWmq3b9FDeoybGQB57N;

    internal static Guid lqhap5b9bdMAR1MQaMPm([In] object obj0) => ((EntityMetadata) obj0).ParentPropertyUid;

    internal static bool qefXcqb9hAjwEVDPpQRp([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static Guid fXq5Etb9Gah8L83xNNAu([In] object obj0) => ((EntityMetadata) obj0).IsGroupPropertyUid;

    internal static bool PaOtoHb9E3CwqyjLdxE5([In] object obj0) => ((EntityMetadata) obj0).Filterable;

    internal static int qBGDwOb9fiX3pH6jfTOG([In] object obj0) => ((List<Guid>) obj0).Count;

    internal static int NBP8txb9QO9i1sO5C5ks([In] object obj0) => ((List<TablePartMetadata>) obj0).Count;

    internal static object MSCsnub9C12rHGsiMtFQ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static Guid J7Gxqcb9vHIMg9692ytg([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static int oadomhb98ijCXwOTXsRE() => EleWise.ELMA.SR.CurrentLCID;

    internal static void TOyAxrb9Z8qREYNOj16V([In] object obj0) => ContextVars.Remove((string) obj0);

    internal static EntityMetadataType u9181Tb9uKSltlGfBVHS([In] object obj0) => ((EntityMetadata) obj0).Type;

    internal static bool MwvFZob9IeSSvNL1DMg8([In] object obj0) => ((ClassMetadata) obj0).IsInterfaceType;

    internal static object L0eoFnb9VOa5jPxqCHeG([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object PHyYiEb9SSaAJUBVCAYB([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static void lPF5ZBb9ifiYo8kCSAXA([In] object obj0) => ((AbstractMetadata) obj0).InitNew();

    internal static void oIgoITb9RViQbgYAReRL([In] object obj0, EntityMetadataType value) => ((EntityMetadata) obj0).Type = value;

    internal static Guid hA3Rycb9q2I5RhZxCxYD([In] object obj0) => ((PropertyMetadata) obj0).TypeUid;

    internal static object b1ufNYb9K4idafNcePoK([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object kCmmwvb9XTupj8fvNH47([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static bool gYPuP4b9T0mpf93rLLAH([In] object obj0) => ((PropertyMetadata) obj0).IsSystem;

    internal static void BnubhCb9kbqvLIeQlx1u([In] object obj0, bool value) => ((PropertyMetadata) obj0).IsSystem = value;

    internal static void V7Vepwb9nDPbbk7y64VT([In] object obj0, bool value) => ((PropertyMetadata) obj0).Nullable = value;

    internal static void AWB1Jfb9OTSd0Tm9X2uR([In] object obj0) => ((List<ViewAttribute>) obj0).Clear();

    internal static void fDRrvkb929508rMJxgN0([In] object obj0, ViewType value) => ((ViewAttribute) obj0).ViewType = value;

    internal static void OQqFrWb9ekqUafT8xCPG([In] object obj0, Visibility value) => ((ViewAttribute) obj0).Visibility = value;

    internal static void g2fiOOb9PyTZjcDlU9Ag([In] object obj0, [In] object obj1) => ((NamedMetadata) obj0).DisplayName = (string) obj1;

    internal static void w7OViVb91h3XMINgZWZj([In] object obj0, Guid value) => ((PropertyMetadata) obj0).TypeUid = value;

    internal static void NNeqY5b9Ndm2DB1YGjSx([In] object obj0, [In] object obj1) => ((SimpleTypeSettings) obj0).FieldName = (string) obj1;

    internal static void vnLabEb93VkFKvrto4Q8([In] object obj0, [In] object obj1) => ((PropertyMetadata) obj0).Settings = (TypeSettings) obj1;

    internal static object yGx9M3b9poYb02kSUB7r([In] object obj0) => (object) ((PropertyMetadata) obj0).ViewSettings;

    internal static void cVHUUMb9aSBjpFl1k110([In] object obj0, [In] object obj1) => ((NamedMetadata) obj0).Name = (string) obj1;

    internal static void rQfP93b9D6GkAtUefhfj([In] object obj0, Guid value) => ((PropertyMetadata) obj0).SubTypeUid = value;

    internal static object ocqdN7b9tuUUs37e14Qy([In] object obj0) => (object) ((EntityMetadata) obj0).ViewModelMetadata;

    internal static Guid BHxaGSb9wF2CMrJKn4Lg([In] object obj0) => ((AbstractMetadata) obj0).ModuleUid;

    internal static Guid Jc5v0Bb94pyOyugernvS() => Guid.NewGuid();

    internal static void ebwKYKb96UFZbo9eMBEK([In] object obj0, Guid value) => ((AbstractMetadata) obj0).Uid = value;

    internal static object y54tYUb9HRDqD1yuI3TS([In] object obj0) => (object) ((ClassMetadata) obj0).Namespace;

    internal static void sxyCdbb9AGlPxFTYtSP7([In] object obj0, [In] object obj1) => ((ClassMetadata) obj0).Namespace = (string) obj1;

    internal static object yHx0eDb97ZQdEld1Hf8f([In] object obj0) => (object) ((ClassMetadata) obj0).NamespaceForDisplay;

    internal static void cLFuxub9xymhDZViiMHn([In] object obj0, [In] object obj1) => ((ClassMetadata) obj0).NamespaceForDisplay = (string) obj1;

    internal static void psBHYsb90g78LsEp1ucu([In] object obj0, Guid value) => ((EntityMetadata) obj0).ImplementationUid = value;

    internal static object OJWLMcb9mWy1T2ai3Kdt([In] object obj0) => (object) ((ClassMetadata) obj0).CreateDefaultTableView();

    internal static Guid LAE7Hpb9y5reETi4PX5l([In] object obj0) => ((ClassMetadata) obj0).BaseClassUid;

    internal static bool ApXtOSb9MLRuRuyVK86M([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static object IkDQXwb9JE7bQi6a0nL8([In] object obj0) => (object) ((EntityMetadata) obj0).CreateUidProperty();

    internal static void TrDXsSb99aXcKjIghbY7([In] object obj0) => ((AbstractMetadata) obj0).AfterLoad();

    internal static Guid bsUXS9b9dZsOW9nvqA6r([In] object obj0) => ((IdTypeAttribute) obj0).TypeUid;

    internal static void FN7c6fb9lpZKsUEgrGJD([In] object obj0, Guid value) => ((EntityMetadata) obj0).IdTypeUid = value;

    internal static System.Type kZ2Y2ub9r2rmNOvWuj99([In] RuntimeTypeHandle obj0) => System.Type.GetTypeFromHandle(obj0);

    internal static object xWdkZPb9gtNWHU7xREpe([In] object obj0) => (object) ((EntityAttribute) obj0).TableName;

    internal static void tAUjRXb95rtqbrPhFU60([In] object obj0, [In] object obj1) => ((EntityMetadata) obj0).TableName = (string) obj1;

    internal static object T1RBaZb9jGqJ9pFHRAUO([In] object obj0, [In] int obj1) => (object) ((string) obj0).Substring(obj1);

    internal static Guid P4eRyHb9YsgKQTZ07iSG([In] object obj0) => ((ImplementationUidAttribute) obj0).Uid;

    internal static CopyAction Ew7sn5b9LHrFHKfpApCg([In] object obj0) => ((CopyActionAttribute) obj0).CopyAction;

    internal static bool GYXWE4b9UqgouNX1nIkT([In] object obj0) => ((ShowInCatalogListAttribute) obj0).NeedShow;

    internal static void XeQyMHb9sVDtMqpC08oj([In] object obj0, bool value) => ((EntityMetadata) obj0).ShowInCatalogList = value;

    internal static bool a6Sl1Db9cJ8MtAIjDdhJ([In] object obj0) => ((FilterableAttribute) obj0).Filterable;

    internal static void vHdbBkb9zEsPIt8PRMco([In] object obj0, bool value) => ((EntityMetadata) obj0).Filterable = value;

    internal static bool hgBftQbdFQTxc8uGuTpE([In] object obj0) => ((CacheEntityAttribute) obj0).Enabled;

    internal static void m6CfLsbdBG0hbabpsM4T([In] object obj0, bool value) => ((EntityMetadata) obj0).IsUnique = value;

    internal static bool fOMykkbdWbMZPLcfdcjX([In] object obj0) => ((HideChildItemsTabAttribute) obj0).NeedHide;

    internal static void LoBFLsbdoNMoMO70VHiT([In] object obj0, bool value) => ((EntityMetadata) obj0).HideChildItemsTab = value;

    internal static void JQVfpJbdb0Psh84IQk7J([In] object obj0, bool value) => ((EntityMetadata) obj0).Hierarchical = value;

    internal static HierarchyType Na4DuRbdhRMFSyVorWOn([In] object obj0) => ((HierarchicalAttribute) obj0).HierarchyType;

    internal static void B7FEYZbdGmNWw4wjp6iy([In] object obj0, HierarchyType value) => ((EntityMetadata) obj0).HierarchyType = value;

    internal static void wHlVC2bdEXxCqG659NnF([In] object obj0, Guid value) => ((EntityMetadata) obj0).ParentPropertyUid = value;

    internal static Guid qJVdoSbdfMe9B4oe4tuI([In] object obj0) => ((HierarchicalAttribute) obj0).IsGroupPropertyUid;

    internal static void OmlFbIbdQqXCeMRuOLDH([In] object obj0, Guid value) => ((EntityMetadata) obj0).IsGroupPropertyUid = value;

    internal static bool GCefPVbdC6XrSZW9WgOk([In] object obj0) => ((InstancePermissionAttribute) obj0).Enabled;

    internal static void aoUZ2Fbdvk8afxpj32lp([In] object obj0, bool value) => ((EntityMetadata) obj0).InstancePermissionsSupport = value;

    internal static void k8BiJhbd8gvf9BwTNjwN([In] object obj0, [In] object obj1) => ((EntityMetadata) obj0).PermissionsPropertyName = (string) obj1;

    internal static System.Type oBU7eQbdZsE0laKLGO8n([In] object obj0) => ((FilterTypeAttribute) obj0).FilterType;

    internal static object klJ2Vfbdu0KELvfD4V1D(System.Type type) => (object) type.GetReflectionProperties();

    internal static object HRLsL2bdIi4wO66BKjPO([In] object obj0) => (object) ((EntityMetadata) obj0).Filter;

    internal static void uHu7aXbdVTG2YB83vSFT([In] object obj0, [In] object obj1, [In] object obj2) => ((PropertyMetadata) obj0).LoadFromPropertyInfo((PropertyInfo) obj1, (PropertyMetadata) obj2);

    internal static bool KEZQ1pbdSfnpcdDt0W12([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void F7SfXDbdiaZJrOyaHi7m([In] object obj0, [In] object obj1) => ((EntityMetadata) obj0).Actions = (EntityActionsMetadata) obj1;

    internal static object AKn3LabdRWww6uyU8Ydd(System.Type type, System.Type attributeType, bool inherit) => (object) type.GetReflectionCustomAttributes(attributeType, inherit);

    internal static System.Type luY4dCbdqdrYeoMnf6IJ([In] object obj0) => ((TablePartAttribute) obj0).TablePartType;

    internal static void kAi9VXbdKnTAuSWTm4QJ([In] object obj0, System.Type value) => ((TablePartMetadata) obj0).DeclaringType = value;

    internal static void o1gF4NbdXKddorlqXlai([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static System.Type UcJxLhbdTKIoRmoAo4Pn([In] object obj0) => ((ImplementAttribute) obj0).InterfaceType;

    internal static EntityMetadataType PZdfZcbdkeggfel0yDKp([In] object obj0) => ((EntityMetadataTypeAttribute) obj0).Type;

    internal static System.Type G4ppswbdnRCWxyrbf5li([In] object obj0, [In] object obj1) => ((System.Reflection.Assembly) obj0).GetReflectionType((string) obj1);

    internal static bool BLVeRwbdO7qvo6d4C1W1([In] System.Type obj0, [In] System.Type obj1) => obj0 == obj1;

    internal static bool CaiuSJbd2806THtDdLdT([In] System.Type obj0, [In] System.Type obj1) => obj0 != obj1;

    internal static object lOdcPobde3ox0w7WuctH([In] object obj0) => (object) ((InterfaceImplementationAttribute) obj0).InterfaceTypeName;

    internal static void zSU12RbdPlp5SdyfTrSC([In] object obj0, [In] object obj1) => ((EntityMetadata) obj0).ViewModelMetadata = (DataClassMetadata) obj1;

    internal static bool gxA5fpbd1mI5H7HnfHLx() => Locator.Initialized;

    internal static Guid w8ojd4bdN2h9nP2oNp2p([In] object obj0) => ((EntityMetadata) obj0).ImplementationUid;

    internal static object sMk9Iabd3ltQ9tJG6HDF([In] object obj0, Guid metadataUid) => (object) ((MetadataItemManager) obj0).GetSoftPublishedMetadata(metadataUid);

    internal static int IN0xpWbdpMAt1cDhitZm([In] object obj0) => ((List<EntityMetadata>) obj0).Count;

    internal static void ItvkAkbdaGHmfAu5jPyF([In] object obj0, [In] object obj1) => MetadataSoftPublishHelper.CopyChanges((IMetadata) obj0, (IMetadata) obj1);

    internal static Guid t8hAWabdDTeMjAp2Scjc([In] object obj0) => ((IMetadata) obj0).Uid;

    internal static void cbCwSdbdtHSPulP8HTqR([In] object obj0) => ((EntityMetadata) obj0).InitializeImplDefaultForms();

    internal static bool eItW63bdwOs7L4iR5LUU([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static PublicationType B36o0Hbd4utvh7tjYrWJ([In] object obj0, [In] object obj1) => MetadataSoftPublishHelper.IsEqualsObject(obj0, obj1);

    internal static void axqH2Nbd6sTZrLx8YoTp() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    /// <summary>Информация о типе метаданных</summary>
    [Component]
    private new class Info : IMetadataTypeInfo
    {
      internal static object NCLwuYCAtYOGNCT0ixnW;

      public string Name => (string) EntityMetadata.Info.c9oyEDCA6iooNYua68iP((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(572119659 - -337058038 ^ 909502359));

      public string Description => (string) EntityMetadata.Info.c9oyEDCA6iooNYua68iP(EntityMetadata.Info.z745QuCAHFmEVm25HC1J(-2099751081 ^ -2099382171));

      public System.Type MetadataType => EntityMetadata.Info.eRtlTYCAAZIupB8y7hZA(__typeref (EntityMetadata));

      public System.Type GeneratorType => EntityMetadata.Info.eRtlTYCAAZIupB8y7hZA(__typeref (WrapperEntityGenerator));

      public Info()
      {
        EntityMetadata.Info.XT3IMcCA7HvTJStUSmhR();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static object c9oyEDCA6iooNYua68iP([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

      internal static bool UFtNTeCAwuv5ebc0Misa() => EntityMetadata.Info.NCLwuYCAtYOGNCT0ixnW == null;

      internal static EntityMetadata.Info q4Cd0dCA4NbrbYvIv39U() => (EntityMetadata.Info) EntityMetadata.Info.NCLwuYCAtYOGNCT0ixnW;

      internal static object z745QuCAHFmEVm25HC1J(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static System.Type eRtlTYCAAZIupB8y7hZA([In] RuntimeTypeHandle obj0) => System.Type.GetTypeFromHandle(obj0);

      internal static void XT3IMcCA7HvTJStUSmhR() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}
