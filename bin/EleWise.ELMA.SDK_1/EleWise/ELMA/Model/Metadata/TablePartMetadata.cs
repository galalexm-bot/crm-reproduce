// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.TablePartMetadata
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Mappings;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Метаданные блока</summary>
  [Entity("TablePartMetadata")]
  [EleWise.ELMA.Model.Attributes.Uid("{99D587AC-0574-4ACF-B332-66B4490CAA66}")]
  [BaseClass("{C40FD1D3-F5D9-4323-9E51-42EBFA77E6DC}")]
  [PartialMetadataType]
  [MetadataType(typeof (EntityMetadata))]
  [EleWise.ELMA.Model.Attributes.DisplayName(typeof (__Resources_TablePartMetadata), "DisplayName")]
  [ClassMap(typeof (TablePartMetadataMap))]
  [Serializable]
  public class TablePartMetadata : 
    EntityMetadata,
    IEntityPropertyMetadata,
    IPropertyMetadata,
    INamedMetadata,
    IOrderedMetadata,
    IMetadata,
    IXsiType,
    ITablePartMetadata,
    ITablePartExtension
  {
    /// <summary>UID типа "Метаданные блока"</summary>
    public new const string UID_S = "{99D587AC-0574-4ACF-B332-66B4490CAA66}";
    /// <summary>UID типа "Метаданные блока"</summary>
    public new static readonly Guid UID;
    [NonSerialized]
    private TablePartSettings _settings;
    private static TablePartMetadata wiuF14bHs2ReJGq0RkLK;

    /// <summary>Метаданные сущности, являющейся владельцем блока</summary>
    [Property("{72ED98CA-F260-4671-9BCD-FF1D80235F47}", "{C40FD1D3-F5D9-4323-9E51-42EBFA77E6DC}")]
    [EntityProperty]
    [EntitySettings(RelationType = RelationType.OneToOne, FieldName = "TablePartOwner")]
    [XmlIgnore]
    [EleWise.ELMA.Model.Attributes.Uid("{2533367F-35E0-4B19-9ACD-BEAAE0F0B2CA}")]
    public virtual EntityMetadata TablePartOwner
    {
      get => this.\u003CTablePartOwner\u003Ek__BackingField;
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
              this.\u003CTablePartOwner\u003Ek__BackingField = value;
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

    /// <summary>Uid свойства, генерируемого для блока</summary>
    [EleWise.ELMA.Model.Attributes.Uid("{62FC7EA7-A56B-4CFB-9CE6-A3F09519C1AE}")]
    [PublicationBehaviour(PublicationType.Restart)]
    [Property("{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}")]
    [GuidSettings(FieldName = "TablePartPropertyUid")]
    [EntityProperty]
    public virtual Guid TablePartPropertyUid
    {
      get => this.\u003CTablePartPropertyUid\u003Ek__BackingField;
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
              this.\u003CTablePartPropertyUid\u003Ek__BackingField = value;
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

    /// <summary>Имя свойства, генерируемого для блока</summary>
    [StringSettings(FieldName = "TablePartPropertyName")]
    [EntityProperty]
    [PublicationBehaviour(PublicationType.Restart)]
    [EleWise.ELMA.Model.Attributes.Uid("{628CE3E7-113C-4B07-843F-DDC32038A07D}")]
    [Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
    public virtual string TablePartPropertyName
    {
      get => this.\u003CTablePartPropertyName\u003Ek__BackingField;
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
              this.\u003CTablePartPropertyName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
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

    /// <summary>Порядок блока в списке свойств и блоков</summary>
    [Property("{D6B44BCE-B236-424D-AA74-D80DA3C8DB75}")]
    [Int32Settings(FieldName = "Order")]
    [EntityProperty]
    [XmlElement("Order")]
    [EleWise.ELMA.Model.Attributes.Uid("{441F73D9-D24C-43AA-AF83-B43DB09C67A6}")]
    public virtual int Order
    {
      get => this.\u003COrder\u003Ek__BackingField;
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
              this.\u003COrder\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 0;
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

    /// <summary>Обязательно для заполнения</summary>
    [BoolSettings(FieldName = "Required")]
    [EntityProperty]
    [DefaultValue(false)]
    [XmlElement("Required")]
    [EleWise.ELMA.Model.Attributes.Uid("{A055F817-3192-4ABD-88D2-ABFFEA842783}")]
    [Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
    public virtual bool Required
    {
      get => this.\u003CRequired\u003Ek__BackingField;
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
              this.\u003CRequired\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
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
    [EntityProperty]
    [DefaultValue(false)]
    [XmlElement("Input")]
    [BoolSettings(FieldName = "Input")]
    [EleWise.ELMA.Model.Attributes.Uid("{52F7C948-A505-4E35-A6E9-4A62675D5A5F}")]
    [Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
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
    [XmlElement("Output")]
    [DefaultValue(false)]
    [EntityProperty]
    [EleWise.ELMA.Model.Attributes.Uid("{76AA518E-08FA-407E-BDE9-10AFA18B7010}")]
    [Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
    [BoolSettings(FieldName = "Output")]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 0;
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

    /// <summary>Тип, в котором объявлено данное свойство</summary>
    [XmlIgnore]
    public virtual System.Type DeclaringType
    {
      get => this.\u003CDeclaringType\u003Ek__BackingField;
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
              this.\u003CDeclaringType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
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

    /// <summary>Имя сценария при изменении значения</summary>
    [DefaultValue("")]
    [EntityProperty]
    [Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
    [StringSettings(FieldName = "OnChangeScriptName", MaxValueString = "2147483647")]
    [XmlElement("OnChangeScriptName")]
    [EleWise.ELMA.Model.Attributes.Uid("{F065AF85-2F3A-40BD-B1F1-6CF50DF34FAE}")]
    public virtual string OnChangeScriptName
    {
      get => this.\u003COnChangeScriptName\u003Ek__BackingField;
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
              this.\u003COnChangeScriptName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
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
    [XmlIgnore]
    public override CopyAction CopyAction
    {
      get => CopyAction.Clone;
      set
      {
      }
    }

    /// <summary>Инициализировать новый объект метаданных</summary>
    public override void InitNew()
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        PropertyMetadata property;
        while (true)
        {
          switch (num2)
          {
            case 1:
              base.InitNew();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
              continue;
            case 2:
              List<ViewAttribute> attributes = ((PropertyViewSettings) TablePartMetadata.WXQTO5bACVxBWj510Nxx((object) property)).Attributes;
              ViewAttribute viewAttribute = new ViewAttribute();
              TablePartMetadata.eZO9kRbAvedus4pnByRJ((object) viewAttribute, ViewType.All);
              TablePartMetadata.Nkuo0YbA89W8vT5vaNQS((object) viewAttribute, Visibility.ForceHidden);
              TablePartMetadata.XbaY3ibAZoDiK4We8b1s((object) viewAttribute, true);
              attributes.Add(viewAttribute);
              num2 = 8;
              continue;
            case 3:
              property.IsSystem = true;
              num2 = 6;
              continue;
            case 4:
              TablePartMetadata.cr4UX8bAhdmwTOWlQADq((object) property, TablePartMetadata.SaF3r5bAbnoPUn2M1Zjs((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824457005)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 5 : 3;
              continue;
            case 5:
              TablePartMetadata.AQZ8CObAG9MBiU2PHuFf((object) property, EntityDescriptor.UID);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 11 : 4;
              continue;
            case 6:
              property.Name = (string) TablePartMetadata.tsxMBObAofSuGgsARpd9(-680446928 - -370807692 ^ -309602422);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 4 : 0;
              continue;
            case 7:
              goto label_15;
            case 8:
              goto label_10;
            case 9:
              goto label_3;
            case 10:
              TablePartMetadata.zbccrubAQvLrmIDCAQYP((object) property.ViewSettings.Attributes);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 1 : 2;
              continue;
            case 11:
              goto label_12;
            case 12:
              TablePartMetadata.TuycSkbAWdpG5Z2sijdW((object) this, property.Uid);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 3;
              continue;
            default:
              TablePartMetadata.LCS848bABUNk8VPMLw84((object) this, TablePartMetadata.tELUbRbAFeQINSoYT8jJ());
              num2 = 7;
              continue;
          }
        }
label_10:
        this.Properties.Add(property);
        num1 = 9;
        continue;
label_12:
        PropertyMetadata propertyMetadata = property;
        EntitySettings entitySettings = new EntitySettings();
        TablePartMetadata.SfR4yHbAEQR822Tklqr8((object) entitySettings, RelationType.OneToOne);
        entitySettings.FieldName = (string) TablePartMetadata.tsxMBObAofSuGgsARpd9(-2112703338 ^ -2112740192);
        TablePartMetadata.pmJDfubAfceXJ18ObMet((object) entitySettings, CascadeMode.SaveUpdate);
        propertyMetadata.Settings = (TypeSettings) entitySettings;
        num1 = 10;
        continue;
label_15:
        property = this.CreateProperty(true);
        num1 = 12;
      }
label_3:;
    }

    /// <summary>Выполнить действия после загрузки объекта метаданных</summary>
    public override void AfterLoad()
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        PropertyMetadata propertyMetadata;
        while (true)
        {
          switch (num2)
          {
            case 1:
              propertyMetadata = this.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => TablePartMetadata.GNXsC4bADGZScQ6WmadF(TablePartMetadata.w3UjGybApydZS2gGZoxC((object) p), TablePartMetadata.dsA3KrbAaJW2hHBtHdk4((object) this))));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
              continue;
            case 2:
              base.AfterLoad();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 1;
              continue;
            case 3:
              goto label_12;
            case 4:
              ((EntitySettings) TablePartMetadata.wPUeElbAuY17d11oIyoF((object) propertyMetadata)).CascadeMode = CascadeMode.SaveUpdate;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 2 : 5;
              continue;
            case 5:
              goto label_11;
            case 6:
              if (!(TablePartMetadata.wPUeElbAuY17d11oIyoF((object) propertyMetadata) is EntitySettings))
              {
                num2 = 3;
                continue;
              }
              goto case 4;
            case 7:
              goto label_3;
            default:
              if (propertyMetadata != null)
                goto case 6;
              else
                goto label_10;
          }
        }
label_10:
        num1 = 7;
      }
label_12:
      return;
label_11:
      return;
label_3:;
    }

    /// <summary>Создать свойство (без добавления в список)</summary>
    /// <param name="initNew">Инициализировать как новое свойство</param>
    /// <returns>Свойство с новым Uid-ом</returns>
    public override PropertyMetadata CreateProperty(bool initNew = false)
    {
      int num = 2;
      PropertyMetadata property;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!initNew)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
              continue;
            }
            goto case 5;
          case 2:
            property = base.CreateProperty(initNew);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 1;
            continue;
          case 3:
            List<ViewAttribute> attributes = ((PropertyViewSettings) TablePartMetadata.WXQTO5bACVxBWj510Nxx((object) property)).Attributes;
            ViewAttribute viewAttribute = new ViewAttribute();
            TablePartMetadata.eZO9kRbAvedus4pnByRJ((object) viewAttribute, ViewType.List);
            viewAttribute.Visibility = Visibility.Visible;
            attributes.Add(viewAttribute);
            num = 4;
            continue;
          case 5:
            TablePartMetadata.zbccrubAQvLrmIDCAQYP((object) ((PropertyViewSettings) TablePartMetadata.WXQTO5bACVxBWj510Nxx((object) property)).Attributes);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 3 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return property;
    }

    /// <summary>Загрузить метаданные из скомпилированного типа</summary>
    /// <param name="type">Тип</param>
    /// <param name="inherit">True, если нужно выбирать свойства, включая родительские классы</param>
    public override void LoadFromType(System.Type type, bool inherit = true)
    {
      int num1 = 9;
      while (true)
      {
        int num2 = num1;
        TablePartInfoAttribute attribute1;
        OrderAttribute attribute2;
        OnChangeScriptNameAttribute attribute3;
        RequiredAttribute attribute4;
        while (true)
        {
          switch (num2)
          {
            case 1:
              TablePartMetadata.GDcsbjbAVvcJAH8DX7il((object) this, attribute2 == null ? 0 : attribute2.Order);
              num2 = 3;
              continue;
            case 2:
            case 4:
              attribute2 = AttributeHelper<OrderAttribute>.GetAttribute(type, false);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 1 : 1;
              continue;
            case 3:
              attribute4 = AttributeHelper<RequiredAttribute>.GetAttribute(type, false);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 5 : 2;
              continue;
            case 5:
              TablePartMetadata.AfEgyxbARNN5ZEk02i8P((object) this, attribute4 == null ? TablePartMetadata.YpJ7aHbASfZMYU2Mdphj((object) this) : TablePartMetadata.XPkYeObAi0mpvfapHBxt((object) attribute4));
              num2 = 12;
              continue;
            case 6:
              goto label_16;
            case 7:
              this.ParentPropertyUid = attribute1.ParentPropertyUid;
              num2 = 13;
              continue;
            case 8:
              attribute1 = AttributeHelper<TablePartInfoAttribute>.GetAttribute(type, true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 10 : 1;
              continue;
            case 9:
              goto label_11;
            case 10:
              if (attribute1 == null)
              {
                num2 = 2;
                continue;
              }
              goto case 7;
            case 11:
              this.TablePartPropertyName = (string) TablePartMetadata.LvITXLbAIhcqWs8pSnxv((object) attribute1);
              num2 = 4;
              continue;
            case 12:
              attribute3 = AttributeHelper<OnChangeScriptNameAttribute>.GetAttribute(type, true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 0;
              continue;
            case 13:
              TablePartMetadata.LCS848bABUNk8VPMLw84((object) this, attribute1.TablePartPropertyUid);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 11 : 2;
              continue;
            default:
              TablePartMetadata.YkOFrMbAK4TPYZFWits9((object) this, attribute3 == null ? (object) "" : TablePartMetadata.QcPeHIbAqC8LdFUOMQ5N((object) attribute3));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 6;
              continue;
          }
        }
label_11:
        base.LoadFromType(type, inherit);
        num1 = 8;
      }
label_16:;
    }

    /// <summary>ShouldSerialize Namespace</summary>
    /// <returns></returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerializeNamespace() => false;

    /// <inheritdoc />
    IEntityMetadata ITablePartExtension.TablePartOwner
    {
      get => (IEntityMetadata) TablePartMetadata.tjXHMrbAXdpBaPCX38IG((object) this);
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
              TablePartMetadata.UylupTbATOlHB8av3QUl((object) this, (object) (value as EntityMetadata));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
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

    /// <summary>Создать табличное представление по умолчанию</summary>
    /// <returns>Табличное представление</returns>
    protected override TableView CreateDefaultTableView()
    {
      TableView defaultTableView = base.CreateDefaultTableView();
      TablePartMetadata.mW7ehDbAkR4rxKaKwriU((object) defaultTableView, true);
      TablePartMetadata.f0Cys8bAnVSiW9DUITyA((object) defaultTableView, true);
      TablePartMetadata.suHe86bAOxeicXygxOkG((object) defaultTableView, false);
      TablePartMetadata.vKfUY7bA2a3DRfp5mLNF((object) defaultTableView, true);
      TablePartMetadata.XsFDMUbAeVkxmW9U74oW((object) defaultTableView, true);
      TablePartMetadata.UV5pY7bAPkYBt8ave9wQ((object) defaultTableView, true);
      return defaultTableView;
    }

    string INamedMetadata.Name
    {
      get => (string) TablePartMetadata.RlSI1WbA1N0ULRjyvI77((object) this);
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
              TablePartMetadata.j7d1SibANZnFZVQPIoEs((object) this, (object) value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 0 : 0;
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

    string ITablePartMetadata.Name
    {
      get => (string) TablePartMetadata.hiBpKrbA3NXVcXocWPNl((object) this);
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
              this.Name = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 0;
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

    string IPropertyMetadata.Name
    {
      get => (string) TablePartMetadata.RlSI1WbA1N0ULRjyvI77((object) this);
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
              this.TablePartPropertyName = value;
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
    }

    Guid IPropertyMetadata.PropertyUid
    {
      get => this.TablePartPropertyUid;
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
              this.TablePartPropertyUid = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
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

    Guid IPropertyMetadata.TypeUid
    {
      get => TablePartMetadata.UID;
      set
      {
      }
    }

    Guid IPropertyMetadata.SubTypeUid
    {
      get => Guid.Empty;
      set
      {
      }
    }

    [XmlIgnore]
    TypeSettings IPropertyMetadata.Settings
    {
      get
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 2:
              if (this._settings != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 1;
                continue;
              }
              goto case 3;
            case 3:
              this._settings = new TablePartSettings((ITablePartMetadata) this);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return (TypeSettings) this._settings;
      }
      set
      {
      }
    }

    public TablePartMetadata()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static TablePartMetadata()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            TablePartMetadata.UID = new Guid((string) TablePartMetadata.tsxMBObAofSuGgsARpd9(-1872275253 >> 6 ^ -29100721));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static bool iiJlZkbHcZv4Wjic7YLg() => TablePartMetadata.wiuF14bHs2ReJGq0RkLK == null;

    internal static TablePartMetadata eLaLwjbHzYZe6YSgkqZ0() => TablePartMetadata.wiuF14bHs2ReJGq0RkLK;

    internal static Guid tELUbRbAFeQINSoYT8jJ() => Guid.NewGuid();

    internal static void LCS848bABUNk8VPMLw84([In] object obj0, Guid value) => ((TablePartMetadata) obj0).TablePartPropertyUid = value;

    internal static void TuycSkbAWdpG5Z2sijdW([In] object obj0, Guid value) => ((EntityMetadata) obj0).ParentPropertyUid = value;

    internal static object tsxMBObAofSuGgsARpd9(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object SaF3r5bAbnoPUn2M1Zjs([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static void cr4UX8bAhdmwTOWlQADq([In] object obj0, [In] object obj1) => ((NamedMetadata) obj0).DisplayName = (string) obj1;

    internal static void AQZ8CObAG9MBiU2PHuFf([In] object obj0, Guid value) => ((PropertyMetadata) obj0).TypeUid = value;

    internal static void SfR4yHbAEQR822Tklqr8([In] object obj0, RelationType value) => ((EntitySettings) obj0).RelationType = value;

    internal static void pmJDfubAfceXJ18ObMet([In] object obj0, CascadeMode value) => ((EntitySettings) obj0).CascadeMode = value;

    internal static void zbccrubAQvLrmIDCAQYP([In] object obj0) => ((List<ViewAttribute>) obj0).Clear();

    internal static object WXQTO5bACVxBWj510Nxx([In] object obj0) => (object) ((PropertyMetadata) obj0).ViewSettings;

    internal static void eZO9kRbAvedus4pnByRJ([In] object obj0, ViewType value) => ((ViewAttribute) obj0).ViewType = value;

    internal static void Nkuo0YbA89W8vT5vaNQS([In] object obj0, Visibility value) => ((ViewAttribute) obj0).Visibility = value;

    internal static void XbaY3ibAZoDiK4We8b1s([In] object obj0, bool value) => ((ViewAttribute) obj0).ReadOnly = value;

    internal static object wPUeElbAuY17d11oIyoF([In] object obj0) => (object) ((PropertyMetadata) obj0).Settings;

    internal static object LvITXLbAIhcqWs8pSnxv([In] object obj0) => (object) ((TablePartInfoAttribute) obj0).TablePartPropertyName;

    internal static void GDcsbjbAVvcJAH8DX7il([In] object obj0, int value) => ((TablePartMetadata) obj0).Order = value;

    internal static bool YpJ7aHbASfZMYU2Mdphj([In] object obj0) => ((TablePartMetadata) obj0).Required;

    internal static bool XPkYeObAi0mpvfapHBxt([In] object obj0) => ((RequiredAttribute) obj0).Required;

    internal static void AfEgyxbARNN5ZEk02i8P([In] object obj0, bool value) => ((TablePartMetadata) obj0).Required = value;

    internal static object QcPeHIbAqC8LdFUOMQ5N([In] object obj0) => (object) ((OnChangeScriptNameAttribute) obj0).ScriptName;

    internal static void YkOFrMbAK4TPYZFWits9([In] object obj0, [In] object obj1) => ((TablePartMetadata) obj0).OnChangeScriptName = (string) obj1;

    internal static object tjXHMrbAXdpBaPCX38IG([In] object obj0) => (object) ((TablePartMetadata) obj0).TablePartOwner;

    internal static void UylupTbATOlHB8av3QUl([In] object obj0, [In] object obj1) => ((TablePartMetadata) obj0).TablePartOwner = (EntityMetadata) obj1;

    internal static void mW7ehDbAkR4rxKaKwriU([In] object obj0, bool value) => ((TableView) obj0).Resizeable = value;

    internal static void f0Cys8bAnVSiW9DUITyA([In] object obj0, bool value) => ((TableView) obj0).Groupable = value;

    internal static void suHe86bAOxeicXygxOkG([In] object obj0, bool value) => ((TableView) obj0).GroupableExpand = value;

    internal static void vKfUY7bA2a3DRfp5mLNF([In] object obj0, bool value) => ((TableView) obj0).CanAdd = value;

    internal static void XsFDMUbAeVkxmW9U74oW([In] object obj0, bool value) => ((TableView) obj0).CanEdit = value;

    internal static void UV5pY7bAPkYBt8ave9wQ([In] object obj0, bool value) => ((TableView) obj0).CanDelete = value;

    internal static object RlSI1WbA1N0ULRjyvI77([In] object obj0) => (object) ((TablePartMetadata) obj0).TablePartPropertyName;

    internal static void j7d1SibANZnFZVQPIoEs([In] object obj0, [In] object obj1) => ((TablePartMetadata) obj0).TablePartPropertyName = (string) obj1;

    internal static object hiBpKrbA3NXVcXocWPNl([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static Guid w3UjGybApydZS2gGZoxC([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static Guid dsA3KrbAaJW2hHBtHdk4([In] object obj0) => ((TablePartMetadata) obj0).TablePartPropertyUid;

    internal static bool GNXsC4bADGZScQ6WmadF([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;
  }
}
