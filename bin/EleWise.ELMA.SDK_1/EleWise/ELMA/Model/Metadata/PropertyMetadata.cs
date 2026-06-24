// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.PropertyMetadata
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Метаданные свойства класса</summary>
  [DataContract]
  [KnownType(typeof (EntityPropertyMetadata))]
  [XmlInclude(typeof (EntityPropertyMetadata))]
  [Serializable]
  public class PropertyMetadata : 
    NamedDocumentedMetadata,
    IPropertyMetadata,
    INamedMetadata,
    IOrderedMetadata,
    IMetadata,
    IXsiType
  {
    private TypeSettings _settings;
    private bool? _nullable;
    [XmlIgnore]
    [NonSerialized]
    private Guid? _Settings_LastTypeUid;
    [XmlIgnore]
    [NonSerialized]
    private Guid? _Settings_LastSubTypeUid;
    [XmlIgnore]
    [NonSerialized]
    private ITypeDescriptor _Settings_LastTypeDescriptor;
    private static PropertyMetadata RtDDbHbdHOOTiNsN1s9l;

    /// <summary>Ctor</summary>
    public PropertyMetadata()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 6;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Handlers = new List<PropertyHandlerInfo>();
            num = 2;
            continue;
          case 2:
            PropertyMetadata.ftrRYGbdMsl1veLo6xt2((object) this, LineAlignment.Left);
            num = 4;
            continue;
          case 3:
            PropertyMetadata.DofdHtbdyn4mLdvxsRCZ((object) this, (object) new PropertyViewSettings());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 1 : 1;
            continue;
          case 4:
            PropertyMetadata.Ut8UOwbdJBbPTONoDuAo((object) this, true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 7 : 4;
            continue;
          case 5:
            goto label_2;
          case 6:
            PropertyMetadata.CfAjJ5bdxPrJXhdgMfv9((object) this, (object) "");
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 9 : 3;
            continue;
          case 7:
            this.Groupable = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 8 : 8;
            continue;
          case 8:
            PropertyMetadata.N8hqX8bd9jHfG1ud0vX7((object) this, 200);
            num = 5;
            continue;
          case 9:
            PropertyMetadata.CxQNHHbd0iWcqWKsKsPC((object) this, (object) "");
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
            continue;
          default:
            PropertyMetadata.DVslkBbdmvC4Y9EDq70X((object) this, (object) "");
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 3;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Uid типа свойства</summary>
    [GuidSettings(FieldName = "TypeUid")]
    [XmlElement("TypeUid")]
    [EleWise.ELMA.Model.Attributes.Uid("{A9A34502-A707-4A65-BF5C-07CA0DE01B35}")]
    [EntityProperty]
    [Property("{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}")]
    [PublicationBehaviour(PublicationType.Restart)]
    [DataMember]
    public virtual Guid TypeUid
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
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

    /// <summary>Uid подтипа свойства</summary>
    [DefaultValue(typeof (Guid), "{00000000-0000-0000-0000-000000000000}")]
    [DataMember]
    [GuidSettings(FieldName = "SubTypeUid")]
    [Property("{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}")]
    [EleWise.ELMA.Model.Attributes.Uid("{41C51647-927A-48CD-84CD-74B4E2A5C228}")]
    [XmlElement("SubTypeUid")]
    [EntityProperty]
    [PublicationBehaviour(PublicationType.Restart)]
    public virtual Guid SubTypeUid
    {
      get => this.\u003CSubTypeUid\u003Ek__BackingField;
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
              this.\u003CSubTypeUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
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
    public virtual bool ShouldSerializeSubTypeUid() => PropertyMetadata.k8YeRXbddlj7vTXEikPu((object) this) != Guid.Empty;

    /// <summary>Настройки свойства</summary>
    [TypeSettingsSettings(FieldName = "Settings")]
    [EntityProperty]
    [PublicationBehaviour(PublicationType.Restart)]
    [XmlElement("Settings")]
    [EleWise.ELMA.Model.Attributes.Uid("{5706615A-FB8F-4C02-BC06-48648F5866AD}")]
    [Property("{6B39BAB6-1274-477B-A4E1-4C699EAB4C75}")]
    [DataMember]
    public virtual TypeSettings Settings
    {
      get
      {
        int num = 24;
        ITypeDescriptor typeDescriptor;
        TypeSettings settings;
        IMetadataService metadataService;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!PropertyMetadata.rCCDC2bdgC2FndbXDFva(this._Settings_LastSubTypeUid.Value, PropertyMetadata.k8YeRXbddlj7vTXEikPu((object) this)))
              {
                num = 7;
                continue;
              }
              goto case 15;
            case 2:
            case 18:
              if (typeDescriptor != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 2 : 5;
                continue;
              }
              goto label_14;
            case 3:
              this._settings = (TypeSettings) Activator.CreateInstance(PropertyMetadata.eyKRH3bdjvxPJ0j0SX42((object) typeDescriptor));
              num = 10;
              continue;
            case 4:
              if (!this._Settings_LastSubTypeUid.HasValue)
              {
                num = 21;
                continue;
              }
              goto case 19;
            case 5:
              if (!PropertyMetadata.cnn4VnbdY1UmKrJBPCnZ(PropertyMetadata.eyKRH3bdjvxPJ0j0SX42((object) typeDescriptor), (Type) null))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 13 : 1;
                continue;
              }
              goto case 25;
            case 6:
              PropertyMetadata.iKgalfbdLfPKKByIghjw((object) this._settings, (object) settings);
              num = 14;
              continue;
            case 7:
            case 8:
            case 21:
            case 26:
              metadataService = (IMetadataService) PropertyMetadata.iV1QhTbd5Jge5ylo0ekY();
              num = 9;
              continue;
            case 9:
              if (metadataService != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 17 : 22;
                continue;
              }
              goto case 2;
            case 10:
              if (settings == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 16 : 14;
                continue;
              }
              goto case 6;
            case 11:
            case 12:
              settings = this._settings;
              num = 3;
              continue;
            case 13:
            case 14:
            case 16:
            case 23:
              goto label_14;
            case 15:
              typeDescriptor = this._Settings_LastTypeDescriptor;
              num = 18;
              continue;
            case 17:
              typeDescriptor = (ITypeDescriptor) null;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 4 : 20;
              continue;
            case 19:
              if (PropertyMetadata.rCCDC2bdgC2FndbXDFva(this._Settings_LastTypeUid.Value, PropertyMetadata.XB9a8Mbdlrsi2mSJAfx6((object) this)))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 1;
                continue;
              }
              goto case 7;
            case 20:
              if (!this._Settings_LastTypeUid.HasValue)
              {
                num = 26;
                continue;
              }
              goto case 4;
            case 22:
              typeDescriptor = metadataService.GetTypeDescriptor(PropertyMetadata.XB9a8Mbdlrsi2mSJAfx6((object) this), PropertyMetadata.k8YeRXbddlj7vTXEikPu((object) this));
              num = 27;
              continue;
            case 24:
              if (!PropertyMetadata.Sttb6CbdrsqkJZcqv0ny(PropertyMetadata.XB9a8Mbdlrsi2mSJAfx6((object) this), Guid.Empty))
              {
                num = 23;
                continue;
              }
              goto case 17;
            case 25:
              if (this._settings == null)
              {
                num = 12;
                continue;
              }
              goto case 29;
            case 27:
              this._Settings_LastTypeDescriptor = typeDescriptor;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
              continue;
            case 28:
              this._Settings_LastSubTypeUid = new Guid?(PropertyMetadata.k8YeRXbddlj7vTXEikPu((object) this));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 2 : 1;
              continue;
            case 29:
              if (PropertyMetadata.cnn4VnbdY1UmKrJBPCnZ(this._settings.GetType(), PropertyMetadata.eyKRH3bdjvxPJ0j0SX42((object) typeDescriptor)))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 11 : 11;
                continue;
              }
              goto label_14;
            default:
              this._Settings_LastTypeUid = new Guid?(PropertyMetadata.XB9a8Mbdlrsi2mSJAfx6((object) this));
              num = 28;
              continue;
          }
        }
label_14:
        return this._settings;
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
              this._settings = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
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

    /// <summary>Может иметь пустое значение</summary>
    [PublicationBehaviour(PublicationType.Restart)]
    [DataMember]
    [XmlElement("Nullable")]
    [EleWise.ELMA.Model.Attributes.Uid("{874E6155-524A-4AF2-83C0-01CB2BFA7395}")]
    [Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
    [EntityProperty]
    [BoolSettings(FieldName = "Nullable")]
    public virtual bool Nullable
    {
      get
      {
        int num1 = 11;
        bool? defaultNullableValue;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            IMetadataService metadataService;
            ITypeDescriptor typeDescriptor;
            object obj;
            switch (num2)
            {
              case 1:
              case 6:
                goto label_16;
              case 2:
                obj = (object) null;
                break;
              case 3:
                goto label_15;
              case 4:
                goto label_9;
              case 5:
                if (metadataService == null)
                  goto case 2;
                else
                  goto label_6;
              case 7:
                defaultNullableValue = typeDescriptor.DefaultNullableValue;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 3 : 0;
                continue;
              case 8:
                defaultNullableValue = typeDescriptor.DefaultNullableValue;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 9 : 3;
                continue;
              case 9:
                if (!defaultNullableValue.HasValue)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 1;
                  continue;
                }
                goto case 7;
              case 10:
                metadataService = (IMetadataService) PropertyMetadata.iV1QhTbd5Jge5ylo0ekY();
                num2 = 5;
                continue;
              case 11:
                if (!this._nullable.HasValue)
                {
                  num2 = 10;
                  continue;
                }
                goto label_9;
              case 12:
                obj = PropertyMetadata.CJnD7KbdUSO69p6RYexl((object) metadataService, this.TypeUid, PropertyMetadata.k8YeRXbddlj7vTXEikPu((object) this));
                break;
              default:
                if (typeDescriptor == null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 1 : 6;
                  continue;
                }
                goto case 8;
            }
            typeDescriptor = (ITypeDescriptor) obj;
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
          }
label_6:
          num1 = 12;
        }
label_9:
        return this._nullable.Value;
label_15:
        return defaultNullableValue.Value;
label_16:
        return !PropertyMetadata.oC1a5dbdsicAI5cjWyGq((object) this);
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
              this._nullable = new bool?(value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 0;
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
    [EleWise.ELMA.Model.Attributes.Uid("{1F411BCF-E8D7-441D-9542-11CB185CB721}")]
    [XmlElement("Required")]
    [Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
    [EntityProperty]
    [BoolSettings(FieldName = "Required")]
    [DefaultValue(false)]
    [DataMember]
    [PublicationBehaviour(PublicationType.Delta)]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
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

    /// <summary>Тип вычисления значения свойства</summary>
    [EleWise.ELMA.Model.Attributes.Uid("{DD6F5099-21D1-40F1-B711-D066687491C4}")]
    [Property("{849C1AC9-4D46-4194-8CBB-43F84ADF9C17}", "{EFE13E18-65B4-4ABE-8D27-53C94571DE75}")]
    [XmlElement("CalculateType")]
    [EntityProperty]
    [PublicationBehaviour(PublicationType.Delta)]
    [DefaultValue(PropertyCalculateType.None)]
    [DataMember]
    [EnumSettings(FieldName = "CalculateType")]
    public virtual PropertyCalculateType CalculateType
    {
      get => this.\u003CCalculateType\u003Ek__BackingField;
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
              this.\u003CCalculateType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
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

    /// <summary>SQL-формула</summary>
    [DefaultValue("")]
    [PublicationBehaviour(PublicationType.Restart)]
    [EntityProperty]
    [Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
    [StringSettings(FieldName = "SQLFormula", MaxValueString = "2147483647")]
    [XmlElement("SQLFormula")]
    [EleWise.ELMA.Model.Attributes.Uid("{79E1F179-10D5-461E-A2A0-A048D709642F}")]
    public virtual string SQLFormula
    {
      get => this.\u003CSQLFormula\u003Ek__BackingField;
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
              this.\u003CSQLFormula\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
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

    /// <summary>Сценарий вычисления</summary>
    [EntityProperty]
    [StringSettings(FieldName = "CalculateScript", MaxValueString = "2147483647")]
    [DefaultValue("")]
    [PublicationBehaviour(PublicationType.Delta)]
    [EditingExtensibleClass]
    [EleWise.ELMA.Model.Attributes.Uid("{0700898A-667A-47A9-8F59-01C1F2AD89A0}")]
    [XmlElement("CalculateScript")]
    [Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
    public virtual string CalculateScript
    {
      get => this.\u003CCalculateScript\u003Ek__BackingField;
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
              this.\u003CCalculateScript\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
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

    /// <summary>Признак, является ли свойство системным</summary>
    [BoolSettings(FieldName = "IsSystem")]
    [DefaultValue(false)]
    [Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
    [EleWise.ELMA.Model.Attributes.Uid("{E88609C0-4E54-4D4D-8A58-CB3398C02A0C}")]
    [EntityProperty]
    [XmlElement("IsSystem")]
    [DataMember]
    public virtual bool IsSystem
    {
      get => this.\u003CIsSystem\u003Ek__BackingField;
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
              this.\u003CIsSystem\u003Ek__BackingField = value;
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
    }

    /// <summary>
    /// Уникальный идентификатор свойства-владельца (например, свойство "Замещаемый пользователь")
    /// </summary>
    [EntityProperty]
    [GuidSettings(FieldName = "OwnerPropertyUid")]
    [DataMember]
    [XmlElement("OwnerPropertyUid")]
    [EleWise.ELMA.Model.Attributes.Uid("{5B27FFB7-C2CB-4A7E-8D9E-AED8140A6589}")]
    [Property("{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}")]
    public virtual Guid OwnerPropertyUid
    {
      get => this.\u003COwnerPropertyUid\u003Ek__BackingField;
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
              this.\u003COwnerPropertyUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
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
    public virtual bool ShouldSerializeOwnerPropertyUid() => PropertyMetadata.Sttb6CbdrsqkJZcqv0ny(PropertyMetadata.Mjh5gCbdcea0Vm6rJGUi((object) this), Guid.Empty);

    /// <summary>Настройки отображения</summary>
    [XmlElement("ViewSettings")]
    [SimpleTypeSettings(FieldName = "ViewSettings")]
    [Property("{66C7898B-E56B-49E0-BFB8-9F9C4A7A0C52}")]
    [EntityProperty]
    [EleWise.ELMA.Model.Attributes.Uid("{7B4310DE-EF68-4057-93CA-6C4301DB0B8C}")]
    public virtual PropertyViewSettings ViewSettings
    {
      get => this.\u003CViewSettings\u003Ek__BackingField;
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
              this.\u003CViewSettings\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 0;
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

    /// <summary>Порядок свойства в списке свойств и блоков</summary>
    [EleWise.ELMA.Model.Attributes.Uid("{8D4B9B4A-B06C-42DB-87CC-09FD659EB912}")]
    [EntityProperty]
    [Int32Settings(FieldName = "Order")]
    [Property("{D6B44BCE-B236-424D-AA74-D80DA3C8DB75}")]
    [XmlElement("Order")]
    [DataMember]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
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

    /// <summary>Ширина колонки в таблице (в пикселях)</summary>
    [EntityProperty]
    [Int32Settings(FieldName = "TableColumnWidth")]
    [Property("{D6B44BCE-B236-424D-AA74-D80DA3C8DB75}")]
    [DefaultValue(200)]
    [EleWise.ELMA.Model.Attributes.Uid("{C038252D-3F3F-4CD0-AE21-02C505BB8EC2}")]
    [XmlElement("TableColumnWidth")]
    public virtual int TableColumnWidth
    {
      get => this.\u003CTableColumnWidth\u003Ek__BackingField;
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
              this.\u003CTableColumnWidth\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 0;
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

    /// <summary>Выравнивание в ячейке таблицы</summary>
    [EnumSettings(FieldName = "TableCellAlignment")]
    [Property("{849C1AC9-4D46-4194-8CBB-43F84ADF9C17}", "fd854dfc-44d7-4232-9408-d193a30c7d6d")]
    [EleWise.ELMA.Model.Attributes.Uid("{3F6C72BB-0851-4C8C-8CF3-D9775DFDBC5E}")]
    [XmlElement("TableCellAlignment")]
    [DefaultValue(LineAlignment.Left)]
    [EntityProperty]
    public virtual LineAlignment TableCellAlignment
    {
      get => this.\u003CTableCellAlignment\u003Ek__BackingField;
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
              this.\u003CTableCellAlignment\u003Ek__BackingField = value;
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

    /// <summary>Возможность сортировки</summary>
    [Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
    [DataMember]
    [EntityProperty]
    [BoolSettings(FieldName = "Sortable")]
    [DefaultValue(true)]
    [EleWise.ELMA.Model.Attributes.Uid("{0D2E132A-6E97-4E9A-BDAB-6119B5BEAE6E}")]
    [XmlElement("Sortable")]
    public virtual bool Sortable
    {
      get => this.\u003CSortable\u003Ek__BackingField;
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
              this.\u003CSortable\u003Ek__BackingField = value;
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

    /// <summary>Возможность группировки</summary>
    [EleWise.ELMA.Model.Attributes.Uid("{55B6659D-BC65-496B-9841-66EC93E4B586}")]
    [Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
    [EntityProperty]
    [DefaultValue(true)]
    [DataMember]
    [XmlElement("Groupable")]
    [BoolSettings(FieldName = "Groupable")]
    public virtual bool Groupable
    {
      get => this.\u003CGroupable\u003Ek__BackingField;
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
              this.\u003CGroupable\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
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

    /// <summary>Обработчики свойства</summary>
    [PublicationBehaviour(PublicationType.Restart)]
    public virtual List<PropertyHandlerInfo> Handlers { get; set; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerializeHandlers()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.Handlers != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return PropertyMetadata.KpwIv9bdzGlBQ8RJcjeR((object) this.Handlers) > 0;
label_5:
      return false;
    }

    /// <summary>Тип, в котором объявлено данное свойство</summary>
    [XmlIgnore]
    public virtual Type DeclaringType
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 0 : 0;
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
    [EleWise.ELMA.Model.Attributes.Uid("{47062245-AA79-44A8-84C2-B3E14DBDDBF6}")]
    [StringSettings(FieldName = "OnChangeScriptName", MaxValueString = "2147483647")]
    [DefaultValue("")]
    [Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
    [XmlElement("OnChangeScriptName")]
    [EntityProperty]
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

    [EleWise.ELMA.Model.Attributes.Uid("{256EE072-B1FD-44D7-B678-B7FDF36FA0E8}")]
    [PublicationBehaviour(PublicationType.Restart)]
    [XmlElement("TypeResolver")]
    [DataMember]
    [Property("{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}")]
    [GuidSettings(FieldName = "TypeResolver")]
    [EntityProperty]
    public virtual Guid TypeResolver
    {
      get => this.\u003CTypeResolver\u003Ek__BackingField;
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
              this.\u003CTypeResolver\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
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
    public virtual bool ShouldSerializeTypeResolver() => PropertyMetadata.Sttb6CbdrsqkJZcqv0ny(this.TypeResolver, Guid.Empty);

    /// <summary>
    /// Используется для установки дополнительных атрибутов на свойства сущностей через файл метаданных, для которых не реализовано визуальной установки
    /// </summary>
    public virtual PropertyMetadataAdditionalAttribute[] AdditionalAttributes
    {
      get => this.\u003CAdditionalAttributes\u003Ek__BackingField;
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
              this.\u003CAdditionalAttributes\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 0 : 0;
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
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.Model.Metadata.PropertyMetadata.AdditionalAttributes" />
    /// </summary>
    /// <returns></returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerializeAdditionalAttributes()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (PropertyMetadata.zPYPnfblFZARgZ4kisr4((object) this) != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return PropertyMetadata.zPYPnfblFZARgZ4kisr4((object) this).Length != 0;
label_3:
      return false;
    }

    /// <summary>Загрузить значения из информации о свойстве класса</summary>
    /// <param name="propertyInfo">Информация о свойстве класса</param>
    /// <param name="filterTargetPropertyMetadata">Метаданные свойства сущности, для которого предназначается данное свойство фильтра</param>
    public virtual void LoadFromPropertyInfo(
      PropertyInfo propertyInfo,
      PropertyMetadata filterTargetPropertyMetadata)
    {
      int num1 = 91;
      XmlReader xmlReader;
      while (true)
      {
        int num2 = num1;
        IEnumerator<ViewAttribute> enumerator1;
        PropertyAttribute attribute1;
        ITypeDescriptor typeDescriptor1;
        IEnumerable<ViewAttribute> source1;
        ITypeDescriptor typeDescriptor2;
        PropertyDeclarationTypeAttribute attribute2;
        OwnerPropertyUidAttribute attribute3;
        PropertyInfo reflectionProperty;
        RequiredAttribute attribute4;
        TypeSettings attribute5;
        PropertyMetadataAdditionalAttributesAttribute attribute6;
        CalculateTypeAttribute attribute7;
        OrderAttribute attribute8;
        IEnumerable<PropertyHandlerAttribute> source2;
        GroupableAttribute attribute9;
        TableColumnWidthAttribute attribute10;
        TypeFilterPropertyResolverAttribute attribute11;
        EleWise.ELMA.Model.Attributes.DescriptionAttribute attribute12;
        TableCellAlignmentAttribute attribute13;
        SystemPropertyAttribute attribute14;
        SQLFormulaAttribute attribute15;
        EleWise.ELMA.Model.Attributes.DisplayNameAttribute attribute16;
        IEnumerator<PropertyHandlerAttribute> enumerator2;
        UidAttribute attribute17;
        SortableAttribute attribute18;
        CalculateScriptAttribute attribute19;
        OnChangeScriptNameAttribute attribute20;
        while (true)
        {
          switch (num2)
          {
            case 1:
              this.OwnerPropertyUid = attribute3 != null ? PropertyMetadata.xNQ6g9blDH17H0RpXreM((object) attribute3) : Guid.Empty;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 55 : 39;
              continue;
            case 2:
              if (typeDescriptor1 == null)
              {
                num2 = 45;
                continue;
              }
              goto case 22;
            case 3:
              PropertyMetadata.KgI8eYblPsisvjq4uNM6((object) this, PropertyMetadata.LbbTnfbleFgAqkDFDW4o((object) attribute16));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 11 : 67;
              continue;
            case 4:
            case 30:
              goto label_80;
            case 5:
              if (source1 == null)
              {
                num2 = 85;
                continue;
              }
              goto case 77;
            case 6:
              attribute18 = AttributeHelper<SortableAttribute>.GetAttribute((MemberInfo) propertyInfo, true);
              num2 = 25;
              continue;
            case 7:
              PropertyMetadata.N8hqX8bd9jHfG1ud0vX7((object) this, 200);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 8 : 0;
              continue;
            case 8:
            case 56:
              attribute13 = AttributeHelper<TableCellAlignmentAttribute>.GetAttribute((MemberInfo) propertyInfo, true);
              num2 = 44;
              continue;
            case 9:
              attribute2 = AttributeHelper<PropertyDeclarationTypeAttribute>.GetAttribute((MemberInfo) propertyInfo, false);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 50 : 37;
              continue;
            case 10:
              if (PropertyMetadata.PKu8Shbl6ywo1lKj1bfc((object) this) == 0)
                goto case 7;
              else
                goto label_119;
            case 11:
              PropertyMetadata.DVslkBbdmvC4Y9EDq70X((object) this, attribute20 == null ? (object) "" : (object) attribute20.ScriptName);
              num2 = 24;
              continue;
            case 12:
              this.CalculateType = attribute7 != null ? attribute7.CalculateType : PropertyCalculateType.None;
              num2 = 33;
              continue;
            case 13:
              attribute17 = AttributeHelper<UidAttribute>.GetAttribute((MemberInfo) propertyInfo, false);
              num2 = 74;
              continue;
            case 14:
              TypeSettings typeSettings = attribute5;
              this.Settings = typeSettings == null ? (TypeSettings) PropertyMetadata.vkqC1VblilZiBQnEvSYu((object) this) : typeSettings;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 81 : 0;
              continue;
            case 15:
              this.Name = (string) PropertyMetadata.Dji1a9blCUR273JFvF1Z((object) propertyInfo);
              num2 = 49;
              continue;
            case 16:
              PropertyMetadata.N8hqX8bd9jHfG1ud0vX7((object) this, attribute10 == null ? 0 : PropertyMetadata.mXPRygbl4qrpHZvFuLmB((object) attribute10));
              num2 = 10;
              continue;
            case 17:
              typeDescriptor1 = (ITypeDescriptor) PropertyMetadata.CJnD7KbdUSO69p6RYexl((object) MetadataServiceContext.Service, PropertyMetadata.XB9a8Mbdlrsi2mSJAfx6((object) filterTargetPropertyMetadata), PropertyMetadata.k8YeRXbddlj7vTXEikPu((object) filterTargetPropertyMetadata));
              num2 = 2;
              continue;
            case 18:
              if (source2 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 31 : 18;
                continue;
              }
              goto case 21;
            case 19:
              PropertyMetadata.TeSmPPblXcgDYO1Oyqi7((object) this, false);
              num2 = 75;
              continue;
            case 20:
              PropertyMetadata.NfNQDfblZSur5w0i9KLF((object) this, attribute1.SubTypeUid);
              num2 = 28;
              continue;
            case 21:
            case 88:
label_55:
              attribute11 = AttributeHelper<TypeFilterPropertyResolverAttribute>.GetAttribute((MemberInfo) propertyInfo, true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 65 : 93;
              continue;
            case 22:
              if (!(PropertyMetadata.tobuk8blkthVLZtEyS3h((object) typeDescriptor1, (object) filterTargetPropertyMetadata, (object) null) != Guid.Empty))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 27 : 57;
                continue;
              }
              goto case 78;
            case 23:
              if (!string.IsNullOrEmpty(this.DisplayName))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 41 : 20;
                continue;
              }
              goto case 52;
            case 24:
              // ISSUE: type reference
              source2 = ((IEnumerable) PropertyMetadata.ro8eX3blxfApR1IHL1qp((object) propertyInfo, PropertyMetadata.dacJG2blthOeJH9Shm78(__typeref (PropertyHandlerAttribute)), true)).Cast<PropertyHandlerAttribute>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 18 : 3;
              continue;
            case 25:
              this.Sortable = attribute18 == null || attribute18.Sortable;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 10 : 43;
              continue;
            case 26:
              attribute5 = AttributeHelper<TypeSettings>.GetAttribute((MemberInfo) propertyInfo, true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 14 : 1;
              continue;
            case 27:
              enumerator2 = source2.GetEnumerator();
              num2 = 62;
              continue;
            case 28:
            case 87:
              if (filterTargetPropertyMetadata == null)
                goto case 38;
              else
                goto label_69;
            case 29:
              xmlReader = XmlReader.Create((TextReader) new StringReader((string) PropertyMetadata.wu8okhbl9U002GSbGDbv((object) attribute6)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 59 : 48;
              continue;
            case 31:
              if (source2.Count<PropertyHandlerAttribute>() <= 0)
              {
                num2 = 21;
                continue;
              }
              goto case 27;
            case 32:
              PropertyMetadata.zhn1jIblImS7fnZ9Lfpa((object) this, PropertyMetadata.v6XqQWbluDDI8dnWhnWK((object) filterTargetPropertyMetadata));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 97 : 21;
              continue;
            case 33:
              attribute19 = AttributeHelper<CalculateScriptAttribute>.GetAttribute((MemberInfo) propertyInfo, true);
              num2 = 82;
              continue;
            case 34:
              typeDescriptor2 = ((IMetadataService) PropertyMetadata.b7LItJblnsg3LB0XDpow()).GetTypeDescriptor(PropertyMetadata.tobuk8blkthVLZtEyS3h((object) typeDescriptor1, (object) filterTargetPropertyMetadata, (object) null), filterTargetPropertyMetadata.SubTypeUid);
              num2 = 69;
              continue;
            case 35:
              PropertyMetadata.kYU9DyblfgsHys65FoVv((object) this, 100000 - (attribute8 != null ? attribute8.Order : 0) - 1000000);
              num2 = 79;
              continue;
            case 36:
              if (attribute16 != null)
              {
                num2 = 3;
                continue;
              }
              goto case 23;
            case 37:
            case 42:
            case 85:
label_54:
              attribute10 = AttributeHelper<TableColumnWidthAttribute>.GetAttribute((MemberInfo) propertyInfo, true);
              num2 = 16;
              continue;
            case 38:
            case 45:
            case 57:
              attribute16 = AttributeHelper<EleWise.ELMA.Model.Attributes.DisplayNameAttribute>.GetAttribute((MemberInfo) propertyInfo, true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 1 : 36;
              continue;
            case 39:
              PropertyMetadata.LiYEqxblhX6cY3bFHDb8((object) this, (object) reflectionProperty, (object) null);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 83 : 12;
              continue;
            case 40:
            case 84:
              if (AttributeHelper<CanBeNullAttribute>.GetAttribute((MemberInfo) propertyInfo, true) == null)
              {
                num2 = 80;
                continue;
              }
              goto case 51;
            case 41:
            case 67:
            case 68:
              attribute12 = AttributeHelper<EleWise.ELMA.Model.Attributes.DescriptionAttribute>.GetAttribute((MemberInfo) propertyInfo, true);
              num2 = 53;
              continue;
            case 43:
              attribute9 = AttributeHelper<GroupableAttribute>.GetAttribute((MemberInfo) propertyInfo, true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 32 : 71;
              continue;
            case 44:
              this.TableCellAlignment = attribute13 == null ? LineAlignment.Left : PropertyMetadata.anI0R2blHbrCGSl2LFjh((object) attribute13);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 6 : 6;
              continue;
            case 46:
              PropertyMetadata.pB1MhjblEGA9cj2s3n7s((object) this, attribute17 != null ? PropertyMetadata.wwDLwcblGfdP87rhIulF((object) attribute17) : PropertyMetadata.TVWqIbblqUIdGsKrTGRA((object) filterTargetPropertyMetadata));
              num2 = 98;
              continue;
            case 47:
              attribute3 = AttributeHelper<OwnerPropertyUidAttribute>.GetAttribute((MemberInfo) propertyInfo, true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 1;
              continue;
            case 48:
              PropertyMetadata.TeSmPPblXcgDYO1Oyqi7((object) this, attribute4 != null ? PropertyMetadata.J67jLCblNpgHlNSJSvw5((object) attribute4) : this.Required);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 65 : 52;
              continue;
            case 49:
              attribute1 = AttributeHelper<PropertyAttribute>.GetAttribute((MemberInfo) propertyInfo, false);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
              continue;
            case 50:
              if (attribute2 == null)
              {
                num2 = 13;
                continue;
              }
              goto case 94;
            case 51:
              this.Nullable = true;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 42 : 89;
              continue;
            case 52:
              PropertyMetadata.zhn1jIblImS7fnZ9Lfpa((object) this, (object) this.Name);
              num2 = 68;
              continue;
            case 53:
              if (attribute12 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 61 : 33;
                continue;
              }
              goto case 26;
            case 54:
              try
              {
label_7:
                if (PropertyMetadata.ptKDqiblw0kRcFxLCu62((object) enumerator1))
                  goto label_5;
                else
                  goto label_8;
label_4:
                ViewAttribute current;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_54;
                    case 2:
                      ((PropertyViewSettings) PropertyMetadata.Qk5wv0blRchur0eYcmoh((object) this)).Attributes.Add(current);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 3 : 3;
                      continue;
                    case 3:
                      goto label_7;
                    default:
                      goto label_5;
                  }
                }
label_5:
                current = enumerator1.Current;
                num3 = 2;
                goto label_4;
label_8:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 1;
                goto label_4;
              }
              finally
              {
                if (enumerator1 != null)
                {
                  int num4 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
                    num4 = 0;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                        goto label_14;
                      default:
                        enumerator1.Dispose();
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 1 : 1;
                        continue;
                    }
                  }
                }
label_14:;
              }
            case 55:
              // ISSUE: type reference
              source1 = propertyInfo.GetCustomAttributes(PropertyMetadata.dacJG2blthOeJH9Shm78(__typeref (ViewAttribute)), true).Cast<ViewAttribute>();
              num2 = 5;
              continue;
            case 58:
              this.Settings = filterTargetPropertyMetadata.Settings != null ? ((TypeSettings) PropertyMetadata.vkqC1VblilZiBQnEvSYu((object) filterTargetPropertyMetadata)).Clone() : (TypeSettings) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 92 : 61;
              continue;
            case 59:
              goto label_16;
            case 60:
              attribute8 = AttributeHelper<OrderAttribute>.GetAttribute((MemberInfo) propertyInfo, false);
              num2 = 35;
              continue;
            case 61:
              PropertyMetadata.xwICvmbl1nZ8bPVF7P70((object) this, PropertyMetadata.LbbTnfbleFgAqkDFDW4o((object) attribute12));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 26 : 19;
              continue;
            case 62:
              try
              {
label_90:
                if (PropertyMetadata.ptKDqiblw0kRcFxLCu62((object) enumerator2))
                  goto label_93;
                else
                  goto label_91;
label_89:
                PropertyHandlerAttribute current;
                int num5;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      goto label_93;
                    case 2:
                      List<PropertyHandlerInfo> handlers = this.Handlers;
                      PropertyHandlerInfo propertyHandlerInfo = new PropertyHandlerInfo();
                      PropertyMetadata.wBwaVwblmrsEtjmNaBlv((object) propertyHandlerInfo, PropertyMetadata.Y50q3Pbl0ATVwYQjKIeX((object) current));
                      handlers.Add(propertyHandlerInfo);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 2 : 3;
                      continue;
                    case 3:
                      goto label_90;
                    default:
                      goto label_55;
                  }
                }
label_91:
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
                goto label_89;
label_93:
                current = enumerator2.Current;
                num5 = 2;
                goto label_89;
              }
              finally
              {
                int num6;
                if (enumerator2 == null)
                  num6 = 2;
                else
                  goto label_97;
label_96:
                switch (num6)
                {
                  case 1:
                    break;
                  default:
                }
label_97:
                PropertyMetadata.XYbmwCblyM9GqsvOL1Yw((object) enumerator2);
                num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
                {
                  num6 = 0;
                  goto label_96;
                }
                else
                  goto label_96;
              }
            case 63:
              if (reflectionProperty != (PropertyInfo) null)
              {
                num2 = 39;
                continue;
              }
              goto case 13;
            case 64:
              PropertyMetadata.CfAjJ5bdxPrJXhdgMfv9((object) this, attribute15 == null ? (object) null : PropertyMetadata.PyVJe9blp5001mFXOtZQ((object) attribute15));
              num2 = 86;
              continue;
            case 65:
              attribute7 = AttributeHelper<CalculateTypeAttribute>.GetAttribute((MemberInfo) propertyInfo, true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 12 : 10;
              continue;
            case 66:
              PropertyMetadata.kQ4S1YblaZrTnwYUNf97((object) this, attribute14 != null);
              num2 = 47;
              continue;
            case 69:
              PropertyMetadata.ERJUA8bl24cg2Ck5C6wE((object) this, PropertyMetadata.ErxgSHblOmDn5iSXROPj((object) typeDescriptor2, (object) filterTargetPropertyMetadata));
              num2 = 38;
              continue;
            case 70:
              attribute15 = AttributeHelper<SQLFormulaAttribute>.GetAttribute((MemberInfo) propertyInfo, true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 36 : 64;
              continue;
            case 71:
              PropertyMetadata.yDtOVMbl7nJAuXbShXGt((object) this, attribute9 == null || PropertyMetadata.UwnPuCblA0c8UaNiKYaU((object) attribute9));
              num2 = 96;
              continue;
            case 72:
              goto label_140;
            case 73:
              PropertyMetadata.t1yg9Ebl8bZhQno9yLg3((object) this, PropertyMetadata.lFMWMDblvIdTaTlErDXR((object) attribute1));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 20 : 4;
              continue;
            case 74:
              PropertyMetadata.pB1MhjblEGA9cj2s3n7s((object) this, attribute17 != null ? PropertyMetadata.wwDLwcblGfdP87rhIulF((object) attribute17) : propertyInfo.Name.GetDeterministicGuid());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 60 : 1;
              continue;
            case 75:
              goto label_63;
            case 76:
              PropertyMetadata.EJtUmqblTqcr04jHdGtq((object) this, false);
              num2 = 40;
              continue;
            case 77:
              if (source1.Count<ViewAttribute>() <= 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 41 : 42;
                continue;
              }
              goto case 99;
            case 78:
              PropertyMetadata.t1yg9Ebl8bZhQno9yLg3((object) this, PropertyMetadata.tobuk8blkthVLZtEyS3h((object) typeDescriptor1, (object) filterTargetPropertyMetadata, (object) null));
              num2 = 34;
              continue;
            case 79:
              PropertyMetadata.kYU9DyblfgsHys65FoVv((object) this, attribute8 == null ? 0 : PropertyMetadata.mtTRkvblQxSjJc0KlTiP((object) attribute8));
              num2 = 15;
              continue;
            case 80:
            case 89:
              attribute4 = AttributeHelper<RequiredAttribute>.GetAttribute((MemberInfo) propertyInfo, true);
              num2 = 48;
              continue;
            case 81:
              if (AttributeHelper<NotNullAttribute>.GetAttribute((MemberInfo) propertyInfo, true) == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 19 : 84;
                continue;
              }
              goto case 76;
            case 82:
              PropertyMetadata.CxQNHHbd0iWcqWKsKsPC((object) this, attribute19 == null ? (object) null : PropertyMetadata.obakw7bl3TPBqYYnUdTF((object) attribute19));
              num2 = 70;
              continue;
            case 83:
              goto label_60;
            case 86:
              attribute14 = AttributeHelper<SystemPropertyAttribute>.GetAttribute((MemberInfo) propertyInfo, true);
              num2 = 66;
              continue;
            case 90:
              PropertyMetadata.CM5jl9bloDp5wShAlCJh((object) this, PropertyMetadata.cU2yhCblWBhshxUvaIgJ((object) propertyInfo));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 9 : 8;
              continue;
            case 91:
              Contract.ArgumentNotNull((object) propertyInfo, (string) PropertyMetadata.uKIF68blBFSbGeAxV0N0(-1978478350 ^ -1978652424));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 88 : 90;
              continue;
            case 92:
              this.ViewSettings = PropertyMetadata.Qk5wv0blRchur0eYcmoh((object) filterTargetPropertyMetadata) == null ? (PropertyViewSettings) null : ClassSerializationHelper.CloneObject<PropertyViewSettings>((PropertyViewSettings) PropertyMetadata.Qk5wv0blRchur0eYcmoh((object) filterTargetPropertyMetadata));
              num2 = 46;
              continue;
            case 93:
              PropertyMetadata.nFJKdablJ1ljdkbDWEtO((object) this, attribute11 != null ? PropertyMetadata.wXJf1VblMT9Mig2JuanI((object) attribute11) : Guid.Empty);
              num2 = 100;
              continue;
            case 94:
              reflectionProperty = PropertyMetadata.qq5E1PblbpPIlmiuA9Kg((object) attribute2).GetReflectionProperty(propertyInfo.Name);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 63 : 14;
              continue;
            case 95:
              if (attribute6 != null)
              {
                num2 = 29;
                continue;
              }
              goto label_137;
            case 96:
              attribute20 = AttributeHelper<OnChangeScriptNameAttribute>.GetAttribute((MemberInfo) propertyInfo, true);
              num2 = 11;
              continue;
            case 97:
              PropertyMetadata.akCAI2blSBV8IgyC4qq9((object) this, PropertyMetadata.Y4w1OWblVUmYvx7Fkfvn((object) filterTargetPropertyMetadata));
              num2 = 58;
              continue;
            case 98:
              PropertyMetadata.kYU9DyblfgsHys65FoVv((object) this, attribute8 == null ? PropertyMetadata.LGhBoWblKoy8w7AqMlrW((object) filterTargetPropertyMetadata) : attribute8.Order);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 9 : 19;
              continue;
            case 99:
              enumerator1 = source1.GetEnumerator();
              num2 = 54;
              continue;
            case 100:
              attribute6 = AttributeHelper<PropertyMetadataAdditionalAttributesAttribute>.GetAttribute((MemberInfo) propertyInfo, true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 80 : 95;
              continue;
            default:
              if (attribute1 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 4 : 1;
                continue;
              }
              goto case 73;
          }
        }
label_63:
        PropertyMetadata.EJtUmqblTqcr04jHdGtq((object) this, true);
        num1 = 17;
        continue;
label_69:
        num1 = 32;
        continue;
label_80:
        this.LoadPropertyTypeWithoutMetadata(propertyInfo);
        num1 = 87;
        continue;
label_119:
        num1 = 56;
      }
label_140:
      return;
label_60:
      return;
label_16:
      try
      {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof (PropertyMetadataAdditionalAttribute[]));
        int num7 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
          num7 = 0;
        while (true)
        {
          switch (num7)
          {
            case 1:
              goto label_135;
            default:
              PropertyMetadata.tPFg5Ebldha3iyvagQfW((object) this, (object) (PropertyMetadataAdditionalAttribute[]) xmlSerializer.Deserialize(xmlReader));
              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 1 : 1;
              continue;
          }
        }
label_135:
        return;
      }
      finally
      {
        if (xmlReader != null)
        {
          int num8 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
            num8 = 0;
          while (true)
          {
            switch (num8)
            {
              case 1:
                goto label_25;
              default:
                PropertyMetadata.XYbmwCblyM9GqsvOL1Yw((object) xmlReader);
                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 1 : 0;
                continue;
            }
          }
        }
label_25:;
      }
label_137:;
    }

    protected bool CheckSimpleType(Type type)
    {
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 2:
            goto label_5;
          case 3:
            goto label_4;
          case 4:
            goto label_6;
          case 5:
            if (!PropertyMetadata.cnn4VnbdY1UmKrJBPCnZ(type, typeof (object)))
            {
              num = 4;
              continue;
            }
            goto case 6;
          case 6:
            // ISSUE: type reference
            if (PropertyMetadata.yXfTQGbllR5w3whLu9Q7(type, PropertyMetadata.dacJG2blthOeJH9Shm78(__typeref (string))))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 1;
              continue;
            }
            break;
        }
        if (type.IsPrimitive)
          num = 2;
        else
          break;
      }
label_4:
      return type.IsValueType;
label_5:
      return true;
label_6:
      return false;
    }

    /// <summary>
    /// Восстановить тип для PropertyMetadata по информации о свойстве
    /// </summary>
    /// <param name="propertyInfo">Информация о свойстве</param>
    protected virtual void LoadPropertyTypeWithoutMetadata(PropertyInfo propertyInfo)
    {
      int num = 1;
      Type type;
      while (true)
      {
        switch (num)
        {
          case 1:
            type = PropertyMetadata.JQmCCtblrRxkcqdKpafD((object) propertyInfo);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            this.LoadPropertyTypeWithoutMetadata(type);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Восстановить тип для PropertyMetadata по типу</summary>
    /// <param name="type">Тип</param>
    protected void LoadPropertyTypeWithoutMetadata(Type type)
    {
      int num = 4;
      TypeHeaderInfo infoByTypeOrNull;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            PropertyMetadata.NfNQDfblZSur5w0i9KLF((object) this, PropertyMetadata.ksGU4Rbl5K9x9f3A4JPe((object) infoByTypeOrNull));
            num = 2;
            continue;
          case 2:
            PropertyMetadata.ERJUA8bl24cg2Ck5C6wE((object) this, PropertyMetadata.FsbKHCbljkHbHFVGLnek((object) infoByTypeOrNull));
            num = 5;
            continue;
          case 3:
            PropertyMetadata.t1yg9Ebl8bZhQno9yLg3((object) this, PropertyMetadata.wujvkmblgB7Rxnou7vDP((object) infoByTypeOrNull));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 1 : 1;
            continue;
          case 4:
            infoByTypeOrNull = ModelHelper.GetTypeInfoByTypeOrNull(type);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 3 : 0;
            continue;
          case 5:
            PropertyMetadata.EJtUmqblTqcr04jHdGtq((object) this, PropertyMetadata.dQXOgyblYAVqMaYivor3((object) infoByTypeOrNull));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
            continue;
          default:
            goto label_8;
        }
      }
label_2:
      return;
label_8:;
    }

    Guid IPropertyMetadata.PropertyUid
    {
      get => this.Uid;
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
              this.Uid = value;
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

    internal static void CfAjJ5bdxPrJXhdgMfv9([In] object obj0, [In] object obj1) => ((PropertyMetadata) obj0).SQLFormula = (string) obj1;

    internal static void CxQNHHbd0iWcqWKsKsPC([In] object obj0, [In] object obj1) => ((PropertyMetadata) obj0).CalculateScript = (string) obj1;

    internal static void DVslkBbdmvC4Y9EDq70X([In] object obj0, [In] object obj1) => ((PropertyMetadata) obj0).OnChangeScriptName = (string) obj1;

    internal static void DofdHtbdyn4mLdvxsRCZ([In] object obj0, [In] object obj1) => ((PropertyMetadata) obj0).ViewSettings = (PropertyViewSettings) obj1;

    internal static void ftrRYGbdMsl1veLo6xt2([In] object obj0, LineAlignment value) => ((PropertyMetadata) obj0).TableCellAlignment = value;

    internal static void Ut8UOwbdJBbPTONoDuAo([In] object obj0, bool value) => ((PropertyMetadata) obj0).Sortable = value;

    internal static void N8hqX8bd9jHfG1ud0vX7([In] object obj0, int value) => ((PropertyMetadata) obj0).TableColumnWidth = value;

    internal static bool BDYk6NbdAwdorkB7Tf06() => PropertyMetadata.RtDDbHbdHOOTiNsN1s9l == null;

    internal static PropertyMetadata LL5NFrbd7JEqZhD9CSud() => PropertyMetadata.RtDDbHbdHOOTiNsN1s9l;

    internal static Guid k8YeRXbddlj7vTXEikPu([In] object obj0) => ((PropertyMetadata) obj0).SubTypeUid;

    internal static Guid XB9a8Mbdlrsi2mSJAfx6([In] object obj0) => ((PropertyMetadata) obj0).TypeUid;

    internal static bool Sttb6CbdrsqkJZcqv0ny([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static bool rCCDC2bdgC2FndbXDFva([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static object iV1QhTbd5Jge5ylo0ekY() => (object) MetadataServiceContext.ServiceOrNull;

    internal static Type eyKRH3bdjvxPJ0j0SX42([In] object obj0) => ((ITypeDescriptor) obj0).SettingsType;

    internal static bool cnn4VnbdY1UmKrJBPCnZ([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static void iKgalfbdLfPKKByIghjw([In] object obj0, [In] object obj1) => ((TypeSettings) obj0).CopyFrom((TypeSettings) obj1);

    internal static object CJnD7KbdUSO69p6RYexl([In] object obj0, Guid typeUid, Guid subTypeUid) => (object) ((IMetadataService) obj0).GetTypeDescriptor(typeUid, subTypeUid);

    internal static bool oC1a5dbdsicAI5cjWyGq([In] object obj0) => ((PropertyMetadata) obj0).Required;

    internal static Guid Mjh5gCbdcea0Vm6rJGUi([In] object obj0) => ((PropertyMetadata) obj0).OwnerPropertyUid;

    internal static int KpwIv9bdzGlBQ8RJcjeR([In] object obj0) => ((List<PropertyHandlerInfo>) obj0).Count;

    internal static object zPYPnfblFZARgZ4kisr4([In] object obj0) => (object) ((PropertyMetadata) obj0).AdditionalAttributes;

    internal static object uKIF68blBFSbGeAxV0N0(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static Type cU2yhCblWBhshxUvaIgJ([In] object obj0) => ((MemberInfo) obj0).DeclaringType;

    internal static void CM5jl9bloDp5wShAlCJh([In] object obj0, Type value) => ((PropertyMetadata) obj0).DeclaringType = value;

    internal static Type qq5E1PblbpPIlmiuA9Kg([In] object obj0) => ((PropertyDeclarationTypeAttribute) obj0).Type;

    internal static void LiYEqxblhX6cY3bFHDb8([In] object obj0, [In] object obj1, [In] object obj2) => ((PropertyMetadata) obj0).LoadFromPropertyInfo((PropertyInfo) obj1, (PropertyMetadata) obj2);

    internal static Guid wwDLwcblGfdP87rhIulF([In] object obj0) => ((UidAttribute) obj0).Uid;

    internal static void pB1MhjblEGA9cj2s3n7s([In] object obj0, Guid value) => ((AbstractMetadata) obj0).Uid = value;

    internal static void kYU9DyblfgsHys65FoVv([In] object obj0, int value) => ((PropertyMetadata) obj0).Order = value;

    internal static int mtTRkvblQxSjJc0KlTiP([In] object obj0) => ((OrderAttribute) obj0).Order;

    internal static object Dji1a9blCUR273JFvF1Z([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static Guid lFMWMDblvIdTaTlErDXR([In] object obj0) => ((PropertyAttribute) obj0).TypeUid;

    internal static void t1yg9Ebl8bZhQno9yLg3([In] object obj0, Guid value) => ((PropertyMetadata) obj0).TypeUid = value;

    internal static void NfNQDfblZSur5w0i9KLF([In] object obj0, Guid value) => ((PropertyMetadata) obj0).SubTypeUid = value;

    internal static object v6XqQWbluDDI8dnWhnWK([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static void zhn1jIblImS7fnZ9Lfpa([In] object obj0, [In] object obj1) => ((NamedMetadata) obj0).DisplayName = (string) obj1;

    internal static object Y4w1OWblVUmYvx7Fkfvn([In] object obj0) => (object) ((NamedMetadata) obj0).Description;

    internal static void akCAI2blSBV8IgyC4qq9([In] object obj0, [In] object obj1) => ((NamedMetadata) obj0).Description = (string) obj1;

    internal static object vkqC1VblilZiBQnEvSYu([In] object obj0) => (object) ((PropertyMetadata) obj0).Settings;

    internal static object Qk5wv0blRchur0eYcmoh([In] object obj0) => (object) ((PropertyMetadata) obj0).ViewSettings;

    internal static Guid TVWqIbblqUIdGsKrTGRA([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static int LGhBoWblKoy8w7AqMlrW([In] object obj0) => ((PropertyMetadata) obj0).Order;

    internal static void TeSmPPblXcgDYO1Oyqi7([In] object obj0, bool value) => ((PropertyMetadata) obj0).Required = value;

    internal static void EJtUmqblTqcr04jHdGtq([In] object obj0, bool value) => ((PropertyMetadata) obj0).Nullable = value;

    internal static Guid tobuk8blkthVLZtEyS3h([In] object obj0, [In] object obj1, [In] object obj2) => ((ITypeDescriptor) obj0).GetFilterType((PropertyMetadata) obj1, (IMetadata) obj2);

    internal static object b7LItJblnsg3LB0XDpow() => (object) MetadataServiceContext.Service;

    internal static object ErxgSHblOmDn5iSXROPj([In] object obj0, [In] object obj1) => (object) ((ITypeDescriptor) obj0).CreateSettingsForFilterProperty((PropertyMetadata) obj1);

    internal static void ERJUA8bl24cg2Ck5C6wE([In] object obj0, [In] object obj1) => ((PropertyMetadata) obj0).Settings = (TypeSettings) obj1;

    internal static object LbbTnfbleFgAqkDFDW4o([In] object obj0) => (object) ((LocalizedStringAttribute) obj0).LocalizedString;

    internal static void KgI8eYblPsisvjq4uNM6([In] object obj0, [In] object obj1) => NamedMetadata.SetDisplayName((NamedMetadata) obj0, (EleWise.ELMA.SR.LocalizableString) obj1);

    internal static void xwICvmbl1nZ8bPVF7P70([In] object obj0, [In] object obj1) => NamedMetadata.SetDescription((NamedMetadata) obj0, (EleWise.ELMA.SR.LocalizableString) obj1);

    internal static bool J67jLCblNpgHlNSJSvw5([In] object obj0) => ((RequiredAttribute) obj0).Required;

    internal static object obakw7bl3TPBqYYnUdTF([In] object obj0) => (object) ((CalculateScriptAttribute) obj0).Script;

    internal static object PyVJe9blp5001mFXOtZQ([In] object obj0) => (object) ((SQLFormulaAttribute) obj0).Formula;

    internal static void kQ4S1YblaZrTnwYUNf97([In] object obj0, bool value) => ((PropertyMetadata) obj0).IsSystem = value;

    internal static Guid xNQ6g9blDH17H0RpXreM([In] object obj0) => ((OwnerPropertyUidAttribute) obj0).Value;

    internal static Type dacJG2blthOeJH9Shm78([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool ptKDqiblw0kRcFxLCu62([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static int mXPRygbl4qrpHZvFuLmB([In] object obj0) => ((TableColumnWidthAttribute) obj0).Value;

    internal static int PKu8Shbl6ywo1lKj1bfc([In] object obj0) => ((PropertyMetadata) obj0).TableColumnWidth;

    internal static LineAlignment anI0R2blHbrCGSl2LFjh([In] object obj0) => ((TableCellAlignmentAttribute) obj0).Value;

    internal static bool UwnPuCblA0c8UaNiKYaU([In] object obj0) => ((GroupableAttribute) obj0).Groupable;

    internal static void yDtOVMbl7nJAuXbShXGt([In] object obj0, bool value) => ((PropertyMetadata) obj0).Groupable = value;

    internal static object ro8eX3blxfApR1IHL1qp([In] object obj0, [In] Type obj1, [In] bool obj2) => (object) ((MemberInfo) obj0).GetCustomAttributes(obj1, obj2);

    internal static Guid Y50q3Pbl0ATVwYQjKIeX([In] object obj0) => ((PropertyHandlerAttribute) obj0).HandlerUid;

    internal static void wBwaVwblmrsEtjmNaBlv([In] object obj0, Guid value) => ((PropertyHandlerInfo) obj0).HandlerUid = value;

    internal static void XYbmwCblyM9GqsvOL1Yw([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static Guid wXJf1VblMT9Mig2JuanI([In] object obj0) => ((TypeFilterPropertyResolverAttribute) obj0).Value;

    internal static void nFJKdablJ1ljdkbDWEtO([In] object obj0, Guid value) => ((PropertyMetadata) obj0).TypeResolver = value;

    internal static object wu8okhbl9U002GSbGDbv([In] object obj0) => (object) ((PropertyMetadataAdditionalAttributesAttribute) obj0).AdditionalAttributes;

    internal static void tPFg5Ebldha3iyvagQfW([In] object obj0, [In] object obj1) => ((PropertyMetadata) obj0).AdditionalAttributes = (PropertyMetadataAdditionalAttribute[]) obj1;

    internal static bool yXfTQGbllR5w3whLu9Q7([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static Type JQmCCtblrRxkcqdKpafD([In] object obj0) => ((PropertyInfo) obj0).PropertyType;

    internal static Guid wujvkmblgB7Rxnou7vDP([In] object obj0) => ((TypeHeaderInfo) obj0).TypeUid;

    internal static Guid ksGU4Rbl5K9x9f3A4JPe([In] object obj0) => ((TypeHeaderInfo) obj0).SubTypeUid;

    internal static object FsbKHCbljkHbHFVGLnek([In] object obj0) => (object) ((TypeHeaderInfo) obj0).Settings;

    internal static bool dQXOgyblYAVqMaYivor3([In] object obj0) => ((TypeHeaderInfo) obj0).Nullable;
  }
}
