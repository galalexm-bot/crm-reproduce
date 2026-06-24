// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.ClassMetadata
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Metadata.PublicationBehaviours;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Modules.Attributes;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
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
  /// <summary>Метаданные класса</summary>
  [DataContract]
  [XmlRoot("Class")]
  [Serializable]
  public class ClassMetadata : 
    NamedDocumentedMetadata,
    IRootMetadata,
    IMetadata,
    IXsiType,
    ICodeItemMetadata,
    IGroupedMetadata
  {
    /// <summary>Имя свойства "Уникальный идентификатор"</summary>
    public const string UID_PROPERTY_NAME = "Uid";
    private string fullTypeName;
    private string _namespace;
    [NonSerialized]
    private List<FormViewItem> _allForms;
    private ClassDefaultForms _defaultForms;
    private EleWise.ELMA.SR.LocalizableString namespaceForDisplay;
    internal static ClassMetadata S2vmREbyiUOO08f9MM4f;

    /// <summary>Отображаемое пространство имен</summary>
    [EleWise.ELMA.Globalization.Localizable]
    [XmlElement("NamespaceForDisplay")]
    [DefaultValue("")]
    public virtual string NamespaceForDisplay
    {
      get => (string) ClassMetadata.Kn08mrbyKsMLJwmK2rpA((object) this.namespaceForDisplay);
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
              this.namespaceForDisplay = (EleWise.ELMA.SR.LocalizableString) ClassMetadata.b9hhEWbyXYQdaOrkKXmN((object) value);
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

    /// <summary>Пространство имен</summary>
    [DefaultValue("")]
    [EleWise.ELMA.Model.Attributes.Uid("{727138AE-897E-429A-BFBA-F2736C78AAED}")]
    [DataMember]
    [StringSettings(MaxValueString = "2000", FieldName = "Namespace")]
    [Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
    [XmlElement("Namespace")]
    [EntityProperty]
    [PublicationBehaviour(PublicationType.Restart)]
    public virtual string Namespace
    {
      get => this._namespace;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              this._namespace = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            default:
              this.OnNamespaceChanged();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 2 : 0;
              continue;
          }
        }
label_2:;
      }
    }

    /// <summary>Идентификатор группы метаданных (или 0)</summary>
    [EleWise.ELMA.Model.Attributes.Uid("{28D08347-616F-4B53-BFE2-913AA67CF7DC}")]
    [EntityProperty]
    [Int64Settings(FieldName = "GroupId")]
    [XmlElement("GroupId")]
    [Property("{D90A59AF-7E47-48C5-8C4C-DAD04834E6E3}")]
    [DataMember]
    [DefaultValue(0)]
    public virtual long GroupId
    {
      get => this.\u003CGroupId\u003Ek__BackingField;
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
              this.\u003CGroupId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
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

    /// <summary>Показывать в дереве типов</summary>
    [XmlElement("ShowInTypeTree")]
    [DataMember]
    [DefaultValue(true)]
    public virtual bool ShowInTypeTree
    {
      get => this.\u003CShowInTypeTree\u003Ek__BackingField;
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
              this.\u003CShowInTypeTree\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
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

    /// <summary>Показывать в дизайнере ELMA</summary>
    [XmlElement("ShowInDesigner")]
    [DefaultValue(true)]
    [DataMember]
    public virtual bool ShowInDesigner
    {
      get => this.\u003CShowInDesigner\u003Ek__BackingField;
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
              this.\u003CShowInDesigner\u003Ek__BackingField = value;
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

    /// <summary>Uid базового класса</summary>
    [Property("{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}")]
    [EntityProperty]
    [DefaultValue(typeof (Guid), "{00000000-0000-0000-0000-000000000000}")]
    [PublicationBehaviour(PublicationType.Restart)]
    [GuidSettings(FieldName = "BaseClassUid")]
    [XmlElement("BaseClassUid")]
    [EleWise.ELMA.Model.Attributes.Uid("{8A4A8E1E-084D-43D7-81C3-8556F6C0F094}")]
    [DataMember]
    public virtual Guid BaseClassUid
    {
      get => this.\u003CBaseClassUid\u003Ek__BackingField;
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
              this.\u003CBaseClassUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
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
    public virtual bool ShouldSerializeBaseClassUid() => ClassMetadata.nYidoWbykXsDOoYZarOd(ClassMetadata.YZA4m6byTq0IaYdXSpsU((object) this), Guid.Empty);

    /// <summary>Разрешить создавать классы-наследники</summary>
    [DefaultValue(false)]
    [XmlElement("AllowCreateHeirs")]
    [PublicationBehaviour(PublicationType.Delta)]
    public virtual bool AllowCreateHeirs
    {
      get => this.\u003CAllowCreateHeirs\u003Ek__BackingField;
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
              this.\u003CAllowCreateHeirs\u003Ek__BackingField = value;
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

    /// <summary>Свойства класса</summary>
    [PublicationBehaviour(typeof (NotRestartIfCollectionItemAddBehaviour))]
    [XmlArray("Properties")]
    [EleWise.ELMA.Model.Attributes.Uid("{D4B4BB64-7F91-49D4-9051-B25E4CA74AB2}")]
    [DataMember]
    public virtual List<PropertyMetadata> Properties { get; set; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerializeProperties()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (this.Properties == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return ClassMetadata.IywOnLbynVbHaOOkjUtM((object) this.Properties) > 0;
label_5:
      return false;
    }

    /// <summary>
    /// Разница между оригинальным PropertyMetadata и его измененным значением.
    /// Введено для обеспечения возможности редактировать определенные метаданные расширяемой системной сущности
    /// </summary>
    [PublicationBehaviour(PublicationType.Restart)]
    [EleWise.ELMA.Model.Attributes.Uid("{4DB398A9-8063-4535-9BF6-3DEF9537F694}")]
    [DataMember]
    [XmlArray("PropertiesDiffContainer")]
    public virtual List<PropertiesContainer> PropertiesDiffContainer { get; set; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerializePropertiesDiffContainer()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.PropertiesDiffContainer == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
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
      return ClassMetadata.zv3efbbyOxN8a7jWq5LT((object) this.PropertiesDiffContainer) > 0;
label_5:
      return false;
    }

    /// <summary>Схема настроек форм</summary>
    [XmlElement("FormsScheme")]
    [DefaultValue(ClassFormsScheme.Simple)]
    public virtual ClassFormsScheme FormsScheme
    {
      get => this.\u003CFormsScheme\u003Ek__BackingField;
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
              this.\u003CFormsScheme\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 0;
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
    /// Задает формы по умолчанию для различных типов представлений
    /// </summary>
    [XmlElement("DefaultForms")]
    public virtual ClassDefaultForms DefaultForms
    {
      get => this._defaultForms;
      set
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_6;
            case 1:
              goto label_2;
            case 2:
              if (this._defaultForms == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
                continue;
              }
              goto case 4;
            case 3:
              this._defaultForms = value;
              num = 2;
              continue;
            case 4:
              ClassMetadata.VMIB6Xby2I3GWoc4taf9((object) this._defaultForms, (object) this);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 1;
              continue;
            default:
              goto label_8;
          }
        }
label_6:
        return;
label_2:
        return;
label_8:;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerializeDefaultForms()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (ClassMetadata.aaZhMVbyewFSI3wBafF2((object) this) == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 1 : 0;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return ((ClassDefaultForms) ClassMetadata.aaZhMVbyewFSI3wBafF2((object) this)).ShouldSerialize();
label_5:
      return false;
    }

    /// <summary>Наследовать формы от базового класса</summary>
    [XmlElement("InheritForms")]
    [DefaultValue(true)]
    public virtual bool InheritForms
    {
      get => this.\u003CInheritForms\u003Ek__BackingField;
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
              this.\u003CInheritForms\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
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

    /// <summary>Представления в виде формы</summary>
    [XmlArray("Forms")]
    public virtual List<FormViewItem> Forms { get; set; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerializeForms()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.Forms != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return ClassMetadata.lsCg6CbyPEcuYaxikCBF((object) this.Forms) > 0;
label_5:
      return false;
    }

    /// <summary>Преобразования форм</summary>
    [XmlArray("FormTransformations")]
    public virtual List<FormViewItemTransformation> FormTransformations { get; set; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerializeFormTransformations()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.FormTransformations == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
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
      return this.FormTransformations.Count > 0;
label_5:
      return false;
    }

    /// <summary>Представления в виде формы</summary>
    [XmlArray("FormViews")]
    public virtual List<FormView> FormViews { get; set; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerializeFormViews()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (this.FormViews == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 1 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return ClassMetadata.V2bqRoby1Nm0hWDI8urK((object) this.FormViews) > 0;
label_5:
      return false;
    }

    /// <summary>Представления в виде таблиц</summary>
    [XmlArray("TableViews")]
    [TableViewsTypeSettings(FieldName = "TableViews")]
    [EntityProperty]
    [Property("{C039DA91-30DE-4681-84D0-842C17D54BD6}")]
    [EleWise.ELMA.Model.Attributes.Uid("{59673B28-A1D7-4DC2-928E-A4E00E3DCA09}")]
    public virtual List<TableView> TableViews { get; set; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerializeTableViews()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.TableViews != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return ClassMetadata.F2L9YjbyNNDHwyCRbaYc((object) this.TableViews) > 0;
label_5:
      return false;
    }

    /// <summary>
    /// Формат отображения класса на формах. Используется в переопределенной функции ToString()
    /// </summary>
    [XmlElement("DisplayFormat")]
    public virtual string DisplayFormat
    {
      get => this.\u003CDisplayFormat\u003Ek__BackingField;
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
              this.\u003CDisplayFormat\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
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
    /// Уникальный идентификатор свойства, являющегося отображаемым именем сущности
    /// </summary>
    [XmlElement("TitlePropertyUid")]
    [EleWise.ELMA.Model.Attributes.Uid("{0731493C-0549-4B96-B16B-FCD8912E3660}")]
    [DataMember]
    [EntityProperty]
    [GuidSettings(FieldName = "TitlePropertyUid")]
    [Property("{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}")]
    public virtual Guid TitlePropertyUid
    {
      get => this.\u003CTitlePropertyUid\u003Ek__BackingField;
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
              this.\u003CTitlePropertyUid\u003Ek__BackingField = value;
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

    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerializeTitlePropertyUid() => ClassMetadata.nYidoWbykXsDOoYZarOd(this.TitlePropertyUid, Guid.Empty);

    /// <summary>
    /// Полные имена типов с именем сборки (AssemblyQualifiedName) реализуемых интерфейсов
    /// </summary>
    [DefaultValue(null)]
    [XmlElement("ImplementedInterfaces")]
    [PublicationBehaviour(typeof (RestartIfCollectionChanged))]
    public virtual List<string> ImplementedInterfaces { get; set; }

    /// <summary>Кастомный код</summary>
    [DefaultValue("")]
    [PublicationBehaviour(PublicationType.Restart)]
    public virtual string CustomCode
    {
      get => this.\u003CCustomCode\u003Ek__BackingField;
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
              this.\u003CCustomCode\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
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

    /// <summary>Полное имя типа (со сборкой) модуля сценариев</summary>
    [PublicationBehaviour(PublicationType.Delta)]
    [DefaultValue("")]
    public virtual string ScriptModuleTypeName
    {
      get => this.\u003CScriptModuleTypeName\u003Ek__BackingField;
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
              this.\u003CScriptModuleTypeName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 0;
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

    /// <summary>Имя сценария при загрузке формы</summary>
    [DefaultValue("")]
    public virtual string OnViewLoadScriptName
    {
      get => this.\u003COnViewLoadScriptName\u003Ek__BackingField;
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
              this.\u003COnViewLoadScriptName\u003Ek__BackingField = value;
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

    /// <summary>Ctor</summary>
    public ClassMetadata()
    {
      ClassMetadata.mOZYeKby3YBWLnAMYKNC();
      // ISSUE: reference to a compiler-generated field
      this.\u003CShowInTypeTree\u003Ek__BackingField = true;
      // ISSUE: reference to a compiler-generated field
      this.\u003CShowInDesigner\u003Ek__BackingField = true;
      // ISSUE: reference to a compiler-generated field
      this.\u003CProperties\u003Ek__BackingField = new List<PropertyMetadata>();
      // ISSUE: reference to a compiler-generated field
      this.\u003CPropertiesDiffContainer\u003Ek__BackingField = new List<PropertiesContainer>();
      // ISSUE: reference to a compiler-generated field
      this.\u003CInheritForms\u003Ek__BackingField = true;
      // ISSUE: reference to a compiler-generated field
      this.\u003CForms\u003Ek__BackingField = new List<FormViewItem>();
      // ISSUE: reference to a compiler-generated field
      this.\u003CFormTransformations\u003Ek__BackingField = new List<FormViewItemTransformation>();
      // ISSUE: reference to a compiler-generated field
      this.\u003CFormViews\u003Ek__BackingField = new List<FormView>();
      // ISSUE: reference to a compiler-generated field
      this.\u003CTableViews\u003Ek__BackingField = new List<TableView>();
      // ISSUE: reference to a compiler-generated field
      this.\u003CImplementedInterfaces\u003Ek__BackingField = new List<string>();
      // ISSUE: reference to a compiler-generated field
      this.\u003CCustomCode\u003Ek__BackingField = "";
      this.namespaceForDisplay = (EleWise.ELMA.SR.LocalizableString) ClassMetadata.JHYTSLbypH9feifq99H1();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            ClassMetadata.pXw3FEbya0Fk09o7ZqCo((object) this, (object) new ClassDefaultForms());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Получить полное имя типа</summary>
    public virtual string FullTypeName
    {
      get
      {
        int num = 2;
        string fullTypeName1;
        string fullTypeName2;
        while (true)
        {
          switch (num)
          {
            case 1:
              object obj1 = ClassMetadata.MFK1rEbyDP45nrajyx0K((object) this.Namespace) ? (object) string.Empty : ClassMetadata.bQXGp5by49UEZfIemyAU(ClassMetadata.LaN9Ugbyt4xnVB5OkKTf((object) this), ClassMetadata.gXxCexbywJ9LUQCUN2yY(-16752921 ^ -16759773));
              object obj2 = ClassMetadata.BtqGlPby6Uy5jRbNpPO8((object) this);
              this.fullTypeName = fullTypeName1 = (string) obj1 + (string) obj2;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
              continue;
            case 2:
              fullTypeName2 = this.fullTypeName;
              if (fullTypeName2 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 1 : 1;
                continue;
              }
              goto label_2;
            default:
              goto label_6;
          }
        }
label_2:
        return fullTypeName2;
label_6:
        return fullTypeName1;
      }
    }

    /// <summary>Получить имя типа</summary>
    public virtual string TypeName => (string) ClassMetadata.KEu49jbyHyfB5hBPCC2M((object) this);

    /// <summary>
    /// True, если тип метаданных является метаданными интерфейса
    /// </summary>
    public virtual bool IsInterfaceType => false;

    /// <summary>Создать свойство (без добавления в список)</summary>
    /// <param name="initNew">Инициализировать как новое свойство</param>
    /// <returns>Свойство с новым Uid-ом</returns>
    public virtual PropertyMetadata CreateProperty(bool initNew = false)
    {
      int num = 1;
      PropertyMetadata property;
      while (true)
      {
        switch (num)
        {
          case 1:
            property = new PropertyMetadata();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
            continue;
          case 2:
          case 3:
            goto label_5;
          case 4:
            ClassMetadata.FZrHIAbyAlrXmMCqL2L8((object) property);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 2 : 2;
            continue;
          default:
            if (!initNew)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 3 : 3;
              continue;
            }
            goto case 4;
        }
      }
label_5:
      return property;
    }

    /// <summary>Выполнить действия после загрузки объекта метаданных</summary>
    public override void AfterLoad()
    {
      int num1 = 1;
      List<PropertyMetadata>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            base.AfterLoad();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
          case 8:
            if (this.TableViews.Count == 0)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 7 : 7;
              continue;
            }
            goto case 5;
          case 4:
            goto label_19;
          case 5:
            enumerator = this.Properties.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 2 : 2;
            continue;
          case 6:
            this.TableViews = new List<TableView>();
            num1 = 8;
            continue;
          case 7:
            this.TableViews.Add(this.CreateDefaultTableView());
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 5 : 5;
            continue;
          default:
            if (this.TableViews != null)
            {
              num1 = 3;
              continue;
            }
            goto case 6;
        }
      }
label_19:
      return;
label_2:
      try
      {
label_6:
        if (enumerator.MoveNext())
          goto label_4;
        else
          goto label_7;
label_3:
        int num2;
        switch (num2)
        {
          case 1:
            break;
          case 2:
            return;
          default:
            goto label_6;
        }
label_4:
        ClassMetadata.d8Zknoby7Huhd6BcDkFO((object) enumerator.Current);
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
        {
          num2 = 0;
          goto label_3;
        }
        else
          goto label_3;
label_7:
        num2 = 2;
        goto label_3;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
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
    /// <returns></returns>
    public virtual IEnumerable<FormViewItem> GetForms()
    {
      if (this._allForms != null)
        return (IEnumerable<FormViewItem>) this._allForms;
      List<FormViewItem> forms = new List<FormViewItem>();
      ClassDefaultForms defaultForms = new ClassDefaultForms();
      this.GetForms(forms, defaultForms);
      this.GetFormsSettings(defaultForms);
      this._allForms = forms;
      for (int index = 0; index < this._allForms.Count; ++index)
      {
        this._allForms[index] = (FormViewItem) this._allForms[index].Clone();
        this._allForms[index].MetadataUid = new Guid?(this.Uid);
      }
      return (IEnumerable<FormViewItem>) this._allForms;
    }

    public virtual PropertyMetadata GetUidProperty()
    {
      List<PropertyMetadata> properties = this.Properties;
      // ISSUE: reference to a compiler-generated field
      Func<PropertyMetadata, bool> func = ClassMetadata.\u003C\u003Ec.\u003C\u003E9__106_0;
      Func<PropertyMetadata, bool> predicate;
      if (func == null)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        ClassMetadata.\u003C\u003Ec.\u003C\u003E9__106_0 = predicate = (Func<PropertyMetadata, bool>) (p1 => ClassMetadata.\u003C\u003Ec.bPrnFhCHTMp9qO2qHkat((object) p1.Name, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638426237)));
      }
      else
        goto label_1;
label_3:
      return properties.FirstOrDefault<PropertyMetadata>(predicate);
label_1:
      predicate = func;
      goto label_3;
    }

    /// <summary>Загрузить метаданные из скомпилированного типа</summary>
    /// <param name="type">Тип</param>
    /// <param name="inherit">True, если нужно выбирать свойства, включая родительские классы</param>
    public virtual void LoadFromType(Type type, bool inherit = true)
    {
      int num1 = 62;
      while (true)
      {
        int num2 = num1;
        AssemblyModuleAttribute attribute1;
        ClassFormsSchemeAttribute attribute2;
        object[] customAttributes;
        object[] source1;
        IEnumerator<PropertyInfo> enumerator1;
        NamespaceForDisplayAttribute attribute3;
        object[] source2;
        FilterForAttribute attribute4;
        ClassMetadata classMetadata;
        object[] source3;
        IEnumerator<FormAttribute> enumerator2;
        object[] source4;
        ScriptModuleAttribute attribute5;
        TitlePropertyAttribute attribute6;
        ShowInDesignerAttribute attribute7;
        EleWise.ELMA.Model.Attributes.DisplayNameAttribute attribute8;
        IEnumerator<TableViewAttribute> enumerator3;
        Dictionary<Guid, string> dictionary;
        List<OverrideExtensibleClassPropertyAttribute> list1;
        List<OverrideExtensibleClassPropertyAttribute>.Enumerator enumerator4;
        object[] source5;
        IEnumerator<FormTransformationAttribute> enumerator5;
        object[] source6;
        IEnumerator<FormViewAttribute> enumerator6;
        IEnumerator<InterfaceImplementationAttribute> enumerator7;
        CustomCodeAttribute attribute9;
        object[] source7;
        UidAttribute attribute10;
        DisplayFormatAttribute attribute11;
        BaseClassAttribute attribute12;
        GroupIdAttribute attribute13;
        List<Tuple<ViewType, Guid, Guid, Guid, Guid, bool>> list2;
        ShowInTypeTreeAttribute attribute14;
        OnViewLoadScriptNameAttribute attribute15;
        EleWise.ELMA.Model.Attributes.DescriptionAttribute attribute16;
        IEnumerator<ImageAttribute> enumerator8;
        AllowCreateHeirsAttribute attribute17;
        while (true)
        {
          switch (num2)
          {
            case 1:
              ClassMetadata.Suv6RDbycSDoaWyDcxSD((object) this, attribute5 != null ? ClassMetadata.wN6YIhbysWPKGhIlDhd6((object) attribute5) : (object) null);
              num2 = 79;
              continue;
            case 2:
              NamedMetadata.SetDescription((NamedMetadata) this, attribute16 != null ? (EleWise.ELMA.SR.LocalizableString) ClassMetadata.rE4ehIbyl5D1DGP2phJG((object) attribute16) : (EleWise.ELMA.SR.LocalizableString) ClassMetadata.JHYTSLbypH9feifq99H1());
              num2 = 44;
              continue;
            case 3:
              goto label_4;
            case 4:
              goto label_10;
            case 5:
              if (source6.Length != 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 74 : 78;
                continue;
              }
              goto case 55;
            case 6:
            case 25:
            case 91:
label_136:
              attribute9 = AttributeHelper<CustomCodeAttribute>.GetAttribute(type, true);
              num2 = 97;
              continue;
            case 7:
            case 8:
              // ISSUE: type reference
              source1 = (object[]) ClassMetadata.zK2L0vbMoIPSC44f9DH4(type, ClassMetadata.kP6cPSbMW61ismYK9DPH(__typeref (FormAttribute)), false);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 15 : 1;
              continue;
            case 9:
              try
              {
label_103:
                if (enumerator4.MoveNext())
                  goto label_105;
                else
                  goto label_104;
label_99:
                PropertiesContainer propertiesContainer;
                OverrideExtensibleClassPropertyAttribute current;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      this.PropertiesDiffContainer.Add(propertiesContainer);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 4 : 9;
                      continue;
                    case 2:
                      goto label_105;
                    case 3:
                    case 4:
                    case 9:
                      goto label_103;
                    case 5:
                      if (!ClassMetadata.nKWH0DbMIfJucwiyKAw0(ClassMetadata.tj6SYobMuIHDpy7VsLZL((object) current)))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
                        continue;
                      }
                      goto label_103;
                    case 6:
                      if (this.PropertiesDiffContainer.Contains(propertiesContainer))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 1 : 3;
                        continue;
                      }
                      goto case 1;
                    case 7:
                      if (propertiesContainer == null)
                      {
                        num3 = 4;
                        continue;
                      }
                      goto case 6;
                    case 8:
                      goto label_61;
                    default:
                      propertiesContainer = ClassSerializationHelper.DeserializeObjectByXml<PropertiesContainer>((string) ClassMetadata.tj6SYobMuIHDpy7VsLZL((object) current));
                      num3 = 7;
                      continue;
                  }
                }
label_104:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 5 : 8;
                goto label_99;
label_105:
                current = enumerator4.Current;
                num3 = 5;
                goto label_99;
              }
              finally
              {
                enumerator4.Dispose();
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
            case 10:
              if (ClassMetadata.tZC2KubMZV1JSNcpGHOr((object) list1) <= 0)
              {
                num2 = 42;
                continue;
              }
              goto case 98;
            case 11:
              this.Forms = new List<FormViewItem>();
              num2 = 54;
              continue;
            case 12:
              this.ModuleUid = attribute1 == null ? Guid.Empty : attribute1.Uid;
              num2 = 22;
              continue;
            case 13:
              if (source2.Length == 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 64 : 81;
                continue;
              }
              goto case 71;
            case 14:
              if (source3 != null)
              {
                num2 = 108;
                continue;
              }
              goto case 58;
            case 15:
              if (source1 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 16 : 2;
                continue;
              }
              goto case 105;
            case 16:
            case 94:
label_118:
              // ISSUE: type reference
              source3 = (object[]) ClassMetadata.zK2L0vbMoIPSC44f9DH4(type, ClassMetadata.kP6cPSbMW61ismYK9DPH(__typeref (FormTransformationAttribute)), false);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 8 : 14;
              continue;
            case 17:
              this.TitlePropertyUid = attribute6 != null ? attribute6.Uid : Guid.Empty;
              num2 = 51;
              continue;
            case 18:
              ((ClassDefaultForms) ClassMetadata.aaZhMVbyewFSI3wBafF2((object) this)).FromDictionary(list2);
              num2 = 104;
              continue;
            case 19:
              try
              {
label_69:
                if (ClassMetadata.Oh29ewbMbh3pBa5wSCJf((object) enumerator5))
                  goto label_67;
                else
                  goto label_70;
label_66:
                FormTransformationAttribute current;
                int num5;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      goto label_69;
                    case 2:
                      goto label_142;
                    case 3:
                      this.FormTransformations.Add((FormViewItemTransformation) ClassMetadata.kHTFAibMQdGT8HbLOwoD((object) current));
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 1;
                      continue;
                    default:
                      goto label_67;
                  }
                }
label_67:
                current = enumerator5.Current;
                num5 = 3;
                goto label_66;
label_70:
                num5 = 2;
                goto label_66;
              }
              finally
              {
                int num6;
                if (enumerator5 == null)
                  num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 1;
                else
                  goto label_74;
label_73:
                switch (num6)
                {
                  case 1:
                  case 2:
                }
label_74:
                ClassMetadata.FvJ0sPbMhu5GbIHDYUmd((object) enumerator5);
                num6 = 2;
                goto label_73;
              }
            case 20:
              if (source7.Length != 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 32 : 63;
                continue;
              }
              goto case 50;
            case 21:
              try
              {
label_25:
                if (enumerator2.MoveNext())
                  goto label_27;
                else
                  goto label_26;
label_24:
                FormAttribute current;
                int num7;
                while (true)
                {
                  switch (num7)
                  {
                    case 1:
                      goto label_118;
                    case 2:
                      this.Forms.Add(current.Form);
                      num7 = 3;
                      continue;
                    case 3:
                      goto label_25;
                    default:
                      goto label_27;
                  }
                }
label_26:
                num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 1 : 1;
                goto label_24;
label_27:
                current = enumerator2.Current;
                num7 = 2;
                goto label_24;
              }
              finally
              {
                int num8;
                if (enumerator2 == null)
                  num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 0 : 0;
                else
                  goto label_32;
label_31:
                switch (num8)
                {
                  case 2:
                    break;
                  default:
                }
label_32:
                ClassMetadata.FvJ0sPbMhu5GbIHDYUmd((object) enumerator2);
                num8 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
                {
                  num8 = 1;
                  goto label_31;
                }
                else
                  goto label_31;
              }
            case 22:
              ClassMetadata.yBDwiPbyyKHNYZplbMZ1((object) this, !type.IsPublic && !type.IsNestedPublic);
              num2 = 70;
              continue;
            case 23:
              enumerator6 = source7.Cast<FormViewAttribute>().GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 96 : 41;
              continue;
            case 24:
            case 39:
            case 81:
label_93:
              this.Properties = new List<PropertyMetadata>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 23 : 49;
              continue;
            case 26:
              goto label_242;
            case 27:
              ClassMetadata.zRFUiHbyL6did1mTLo8C((object) this, attribute14 == null || attribute14.Visible);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 41 : 59;
              continue;
            case 28:
              list2 = source5.Cast<DefaultFormAttribute>().Select<DefaultFormAttribute, Tuple<ViewType, Guid, Guid, Guid, Guid, bool>>((Func<DefaultFormAttribute, Tuple<ViewType, Guid, Guid, Guid, Guid, bool>>) (a => new Tuple<ViewType, Guid, Guid, Guid, Guid, bool>(a.ViewType, a.ActionUid, a.FormUid, a.GroupUid, a.TargetUid, a.DeletedFromChild))).ToList<Tuple<ViewType, Guid, Guid, Guid, Guid, bool>>();
              num2 = 18;
              continue;
            case 29:
            case 42:
label_61:
              if (classMetadata == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 95 : 26;
                continue;
              }
              goto case 68;
            case 30:
              enumerator3 = source2.Cast<TableViewAttribute>().GetEnumerator();
              num2 = 93;
              continue;
            case 31:
              if (source5 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 28 : 18;
                continue;
              }
              goto case 104;
            case 32:
              attribute1 = AttributeHelper<AssemblyModuleAttribute>.GetAttribute(type.Assembly);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 6 : 12;
              continue;
            case 33:
              if (source6 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 45 : 55;
                continue;
              }
              goto case 5;
            case 34:
              enumerator7 = source6.Cast<InterfaceImplementationAttribute>().GetEnumerator();
              num2 = 48;
              continue;
            case 35:
              if (list1 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 10 : 5;
                continue;
              }
              goto case 29;
            case 36:
label_119:
              // ISSUE: type reference
              list1 = type.GetReflectionCustomAttributes(ClassMetadata.kP6cPSbMW61ismYK9DPH(__typeref (OverrideExtensibleClassPropertyAttribute)), false).Cast<OverrideExtensibleClassPropertyAttribute>().ToList<OverrideExtensibleClassPropertyAttribute>();
              num2 = 35;
              continue;
            case 37:
              goto label_60;
            case 38:
              attribute4 = AttributeHelper<FilterForAttribute>.GetAttribute(type, true);
              num2 = 110;
              continue;
            case 40:
              try
              {
label_157:
                if (ClassMetadata.Oh29ewbMbh3pBa5wSCJf((object) enumerator1))
                  goto label_147;
                else
                  goto label_158;
label_145:
                int num9;
                int num10 = num9;
label_146:
                PropertyMetadata property;
                PropertyMetadata propertyMetadata1;
                PropertyInfo propertyInfo;
                while (true)
                {
                  switch (num10)
                  {
                    case 1:
                      this.Properties.Add(property);
                      num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
                      continue;
                    case 2:
                      property = this.CreateProperty();
                      num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 10 : 0;
                      continue;
                    case 3:
                      propertyInfo = enumerator1.Current;
                      num10 = 2;
                      continue;
                    case 4:
                      goto label_119;
                    case 5:
                      goto label_147;
                    case 6:
                      // ISSUE: type reference
                      if (!ClassMetadata.QbfrH9bMv2h1SgZ2Mylu((object) propertyInfo, ClassMetadata.kP6cPSbMW61ismYK9DPH(__typeref (PropertyAttribute)), true))
                      {
                        num10 = 9;
                        continue;
                      }
                      goto label_159;
                    case 7:
                      ClassMetadata.rMYgNYbM84fJvK5BNeTv((object) property, (object) propertyInfo, (object) propertyMetadata1);
                      num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 1 : 0;
                      continue;
                    case 8:
                    case 11:
                      goto label_159;
                    case 9:
                      goto label_160;
                    case 10:
                      if (classMetadata == null)
                      {
                        num10 = 8;
                        continue;
                      }
                      goto case 6;
                    default:
                      goto label_157;
                  }
                }
label_159:
                PropertyMetadata propertyMetadata2 = (PropertyMetadata) null;
                goto label_161;
label_160:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                propertyMetadata2 = classMetadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => ClassMetadata.\u003C\u003Ec__DisplayClass107_0.hpNZokCHNSUxoQUivKHQ((object) p.Name, ClassMetadata.\u003C\u003Ec__DisplayClass107_0.vXb4fkCH14HKX3PuZaLg((object) propertyInfo))));
label_161:
                propertyMetadata1 = propertyMetadata2;
                num9 = 7;
                goto label_145;
label_147:
                num10 = 2;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
                {
                  num10 = 3;
                  goto label_146;
                }
                else
                  goto label_146;
label_158:
                num9 = 4;
                goto label_145;
              }
              finally
              {
                if (enumerator1 != null)
                {
                  int num11 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0)
                    num11 = 0;
                  while (true)
                  {
                    switch (num11)
                    {
                      case 1:
                        goto label_167;
                      default:
                        ClassMetadata.FvJ0sPbMhu5GbIHDYUmd((object) enumerator1);
                        num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 1 : 0;
                        continue;
                    }
                  }
                }
label_167:;
              }
            case 41:
            case 84:
              source5 = (object[]) ClassMetadata.zK2L0vbMoIPSC44f9DH4(type, typeof (DefaultFormAttribute), false);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 53 : 41;
              continue;
            case 43:
              IEnumerable<DefaultFormSettingAttribute> source8 = customAttributes.Cast<DefaultFormSettingAttribute>();
              // ISSUE: reference to a compiler-generated field
              Func<DefaultFormSettingAttribute, string> func = ClassMetadata.\u003C\u003Ec.\u003C\u003E9__107_2;
              Func<DefaultFormSettingAttribute, string> elementSelector;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                ClassMetadata.\u003C\u003Ec.\u003C\u003E9__107_2 = elementSelector = (Func<DefaultFormSettingAttribute, string>) (a => a.Value);
              }
              else
                goto label_245;
label_244:
              // ISSUE: reference to a compiler-generated method
              dictionary = source8.ToDictionary<DefaultFormSettingAttribute, Guid, string>((Func<DefaultFormSettingAttribute, Guid>) (a => ClassMetadata.\u003C\u003Ec.uSA6P6CHk5AT5TIxcD2K((object) a)), elementSelector);
              num2 = 37;
              continue;
label_245:
              elementSelector = func;
              goto label_244;
            case 44:
              attribute12 = AttributeHelper<BaseClassAttribute>.GetAttribute(type, false);
              num2 = 88;
              continue;
            case 45:
              try
              {
                classMetadata = (ClassMetadata) MetadataLoader.LoadMetadata(ClassMetadata.YP2ChHbyzZYUFnYDcocs((object) attribute4));
                int num12 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
                  num12 = 0;
                switch (num12)
                {
                  default:
                    goto label_117;
                }
              }
              catch (Exception ex)
              {
                int num13 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
                  num13 = 0;
                while (true)
                {
                  switch (num13)
                  {
                    case 1:
                      ClassMetadata.rSgql5bMBuZtvR8lwKs9(ClassMetadata.fLvutabMF8r0auhquvPa(), (object) ex.Message, (object) ex);
                      num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_117;
                  }
                }
              }
            case 46:
              ClassMetadata.ggpeXNbyYo4DCDxkWS3V((object) this, attribute17 != null && ClassMetadata.RiM3PibyjRjTFc0jSHOS((object) attribute17));
              num2 = 101;
              continue;
            case 47:
              ClassMetadata.cehtqDbydHDxJPxk0Z1m((object) this, attribute13 == null ? 0L : attribute13.Id);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 80 : 77;
              continue;
            case 48:
              try
              {
label_193:
                if (ClassMetadata.Oh29ewbMbh3pBa5wSCJf((object) enumerator7))
                  goto label_195;
                else
                  goto label_194;
label_191:
                InterfaceImplementationAttribute current;
                int num14;
                while (true)
                {
                  switch (num14)
                  {
                    case 1:
                      goto label_193;
                    case 2:
                      goto label_195;
                    case 3:
                      goto label_176;
                    default:
                      this.ImplementedInterfaces.Add(current.InterfaceTypeName);
                      num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 1 : 1;
                      continue;
                  }
                }
label_194:
                num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 3 : 3;
                goto label_191;
label_195:
                current = enumerator7.Current;
                num14 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
                {
                  num14 = 0;
                  goto label_191;
                }
                else
                  goto label_191;
              }
              finally
              {
                if (enumerator7 != null)
                {
                  int num15 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
                    num15 = 1;
                  while (true)
                  {
                    switch (num15)
                    {
                      case 1:
                        ClassMetadata.FvJ0sPbMhu5GbIHDYUmd((object) enumerator7);
                        num15 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_202;
                    }
                  }
                }
label_202:;
              }
            case 49:
              enumerator1 = this.GetPropertyInfosWithMetadata(type, inherit).GetEnumerator();
              num2 = 40;
              continue;
            case 50:
label_138:
              source2 = (object[]) ClassMetadata.zK2L0vbMoIPSC44f9DH4(type, typeof (TableViewAttribute), false);
              num2 = 73;
              continue;
            case 51:
              attribute14 = AttributeHelper<ShowInTypeTreeAttribute>.GetAttribute(type, true);
              num2 = 27;
              continue;
            case 52:
            case 103:
label_117:
              // ISSUE: type reference
              source6 = (object[]) ClassMetadata.zK2L0vbMoIPSC44f9DH4(type, ClassMetadata.kP6cPSbMW61ismYK9DPH(__typeref (InterfaceImplementationAttribute)), false);
              num2 = 33;
              continue;
            case 53:
              this.DefaultForms = new ClassDefaultForms();
              num2 = 31;
              continue;
            case 54:
              enumerator2 = source1.Cast<FormAttribute>().GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 21 : 0;
              continue;
            case 55:
            case 60:
label_176:
              source4 = (object[]) ClassMetadata.zK2L0vbMoIPSC44f9DH4(type, typeof (ImageAttribute), false);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 107 : 78;
              continue;
            case 56:
              this.FormTransformations = new List<FormViewItemTransformation>();
              num2 = 89;
              continue;
            case 57:
              goto label_228;
            case 58:
            case 90:
label_142:
              // ISSUE: type reference
              source7 = (object[]) ClassMetadata.zK2L0vbMoIPSC44f9DH4(type, ClassMetadata.kP6cPSbMW61ismYK9DPH(__typeref (FormViewAttribute)), false);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 82 : 81;
              continue;
            case 59:
              attribute7 = AttributeHelper<ShowInDesignerAttribute>.GetAttribute(type, true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 13 : 69;
              continue;
            case 61:
              this.Uid = attribute10 != null ? ClassMetadata.EISJQ3bym6JjVbLfWYPE((object) attribute10) : (!ClassMetadata.mqd2Osbyx93pFPSNb9hC((object) type.FullName) ? ClassMetadata.ekLavlby04OCREvTrY4K((object) type.FullName) : Guid.Empty);
              num2 = 32;
              continue;
            case 62:
              goto label_124;
            case 63:
              this.FormViews = new List<FormView>();
              num2 = 23;
              continue;
            case 64:
              this.Images = new List<MetadataImage>();
              num2 = 100;
              continue;
            case 65:
              this.DisplayFormat = attribute11?.Format;
              num2 = 92;
              continue;
            case 66:
              attribute16 = AttributeHelper<EleWise.ELMA.Model.Attributes.DescriptionAttribute>.GetAttribute(type, true);
              num2 = 2;
              continue;
            case 67:
              classMetadata = (ClassMetadata) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 38 : 13;
              continue;
            case 68:
              if (classMetadata is EntityMetadata)
              {
                num2 = 109;
                continue;
              }
              goto label_232;
            case 69:
              this.ShowInDesigner = attribute7 == null || ClassMetadata.MWXj1IbyUWQ115eRBQPn((object) attribute7);
              num2 = 77;
              continue;
            case 70:
              ClassMetadata.SfmqAPbyJ4GGlNvKL0TY((object) this, ClassMetadata.UJoHyvbyMhcA9fsPluGL((object) type));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 102 : 75;
              continue;
            case 71:
              this.TableViews = new List<TableView>();
              num2 = 30;
              continue;
            case 72:
              if (attribute2 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 84 : 3;
                continue;
              }
              goto case 83;
            case 73:
              if (source2 == null)
              {
                num2 = 39;
                continue;
              }
              goto case 13;
            case 74:
              if (customAttributes == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 6 : 7;
                continue;
              }
              goto case 43;
            case 75:
              ClassMetadata.PyLOGQbyrB3kbuDNooe3((object) this, attribute8 == null ? (object) (EleWise.ELMA.SR.LocalizableString) (string) ClassMetadata.KEu49jbyHyfB5hBPCC2M((object) this) : ClassMetadata.rE4ehIbyl5D1DGP2phJG((object) attribute8));
              num2 = 66;
              continue;
            case 76:
              if (source4.Length == 0)
              {
                num2 = 25;
                continue;
              }
              goto case 64;
            case 77:
              attribute5 = AttributeHelper<ScriptModuleAttribute>.GetAttribute(type, false);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 1 : 1;
              continue;
            case 78:
              this.ImplementedInterfaces = new List<string>();
              num2 = 34;
              continue;
            case 79:
              attribute15 = AttributeHelper<OnViewLoadScriptNameAttribute>.GetAttribute(type, false);
              num2 = 111;
              continue;
            case 80:
              attribute8 = AttributeHelper<EleWise.ELMA.Model.Attributes.DisplayNameAttribute>.GetAttribute(type, true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 75 : 4;
              continue;
            case 82:
              if (source7 != null)
              {
                num2 = 20;
                continue;
              }
              goto case 50;
            case 83:
              ClassMetadata.YNajXBbMfAHHjAfVpBX2((object) this, ClassMetadata.wctHfXbMEMwOR7XLbkU8((object) attribute2));
              num2 = 41;
              continue;
            case 85:
              if (ClassMetadata.YP2ChHbyzZYUFnYDcocs((object) attribute4) != type)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 24 : 45;
                continue;
              }
              goto case 52;
            case 86:
              ClassMetadata.t2j4XubMS8Le2no9dSpp((object) this, (object) ((EntityMetadata) classMetadata).Filter);
              num2 = 26;
              continue;
            case 87:
              ClassMetadata.H5UU5sbMGrbMuLq42iHJ((object) this, (object) attribute9.GetCode());
              num2 = 3;
              continue;
            case 88:
              ClassMetadata.e3EvIeby5jB54XLBjmUt((object) this, attribute12 != null ? ClassMetadata.JtopUwbygG0d4Ws5sm98((object) attribute12) : Guid.Empty);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 58 : 99;
              continue;
            case 89:
              enumerator5 = source3.Cast<FormTransformationAttribute>().GetEnumerator();
              num2 = 19;
              continue;
            case 92:
              goto label_44;
            case 93:
              try
              {
label_49:
                if (ClassMetadata.Oh29ewbMbh3pBa5wSCJf((object) enumerator3))
                  goto label_52;
                else
                  goto label_50;
label_48:
                TableViewAttribute current;
                int num16;
                while (true)
                {
                  switch (num16)
                  {
                    case 1:
                      this.TableViews.Add(current.View);
                      num16 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 3;
                      continue;
                    case 2:
                      goto label_52;
                    case 3:
                      goto label_49;
                    default:
                      goto label_93;
                  }
                }
label_50:
                num16 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
                goto label_48;
label_52:
                current = enumerator3.Current;
                num16 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
                {
                  num16 = 0;
                  goto label_48;
                }
                else
                  goto label_48;
              }
              finally
              {
                if (enumerator3 != null)
                {
                  int num17 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
                    num17 = 1;
                  while (true)
                  {
                    switch (num17)
                    {
                      case 1:
                        ClassMetadata.FvJ0sPbMhu5GbIHDYUmd((object) enumerator3);
                        num17 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_59;
                    }
                  }
                }
label_59:;
              }
            case 95:
              goto label_226;
            case 96:
              try
              {
label_81:
                if (ClassMetadata.Oh29ewbMbh3pBa5wSCJf((object) enumerator6))
                  goto label_83;
                else
                  goto label_82;
label_80:
                FormViewAttribute current;
                int num18;
                while (true)
                {
                  switch (num18)
                  {
                    case 1:
                      goto label_138;
                    case 2:
                      goto label_83;
                    case 3:
                      goto label_81;
                    default:
                      this.FormViews.Add((FormView) ClassMetadata.XcQvb4bMCytHmi7dAbOL((object) current));
                      num18 = 3;
                      continue;
                  }
                }
label_82:
                num18 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 1 : 1;
                goto label_80;
label_83:
                current = enumerator6.Current;
                num18 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
                {
                  num18 = 0;
                  goto label_80;
                }
                else
                  goto label_80;
              }
              finally
              {
                int num19;
                if (enumerator6 == null)
                  num19 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 2 : 2;
                else
                  goto label_89;
label_88:
                switch (num19)
                {
                  case 1:
                    break;
                  default:
                }
label_89:
                enumerator6.Dispose();
                num19 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
                {
                  num19 = 0;
                  goto label_88;
                }
                else
                  goto label_88;
              }
            case 97:
              goto label_115;
            case 98:
              enumerator4 = list1.GetEnumerator();
              num2 = 9;
              continue;
            case 99:
              attribute17 = AttributeHelper<AllowCreateHeirsAttribute>.GetAttribute(type, false);
              num2 = 46;
              continue;
            case 100:
              enumerator8 = source4.Cast<ImageAttribute>().GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
              continue;
            case 101:
              attribute11 = AttributeHelper<DisplayFormatAttribute>.GetAttribute(type, false);
              num2 = 65;
              continue;
            case 102:
              ClassMetadata.griiK2by9q0ebIRUYUDx((object) this, (object) type.Namespace);
              num2 = 112;
              continue;
            case 104:
              customAttributes = type.GetReflectionCustomAttributes(typeof (DefaultFormSettingAttribute), false);
              num2 = 74;
              continue;
            case 105:
              if (source1.Length != 0)
              {
                num2 = 11;
                continue;
              }
              goto case 16;
            case 106:
              this.namespaceForDisplay = attribute3 != null ? (EleWise.ELMA.SR.LocalizableString) ClassMetadata.rE4ehIbyl5D1DGP2phJG((object) attribute3) : (EleWise.ELMA.SR.LocalizableString) ClassMetadata.JHYTSLbypH9feifq99H1();
              num2 = 67;
              continue;
            case 107:
              if (source4 == null)
              {
                num2 = 6;
                continue;
              }
              goto case 76;
            case 108:
              if (source3.Length == 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 49 : 90;
                continue;
              }
              goto case 56;
            case 109:
              if (ClassMetadata.SraP6EbMVJ6NqAkXoRa9((object) (EntityMetadata) classMetadata) == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 57 : 0;
                continue;
              }
              goto case 86;
            case 110:
              if (attribute4 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 52 : 34;
                continue;
              }
              goto case 85;
            case 111:
              this.OnViewLoadScriptName = attribute15?.ScriptName;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 1 : 4;
              continue;
            case 112:
              attribute13 = AttributeHelper<GroupIdAttribute>.GetAttribute(type, false);
              num2 = 47;
              continue;
            default:
              try
              {
label_213:
                if (ClassMetadata.Oh29ewbMbh3pBa5wSCJf((object) enumerator8))
                  goto label_211;
                else
                  goto label_214;
label_210:
                ImageAttribute current;
                int num20;
                while (true)
                {
                  switch (num20)
                  {
                    case 1:
                      goto label_136;
                    case 2:
                      this.Images.Add(new MetadataImage(current));
                      num20 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
                      continue;
                    case 3:
                      goto label_211;
                    default:
                      goto label_213;
                  }
                }
label_211:
                current = enumerator8.Current;
                num20 = 2;
                goto label_210;
label_214:
                num20 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 1;
                goto label_210;
              }
              finally
              {
                int num21;
                if (enumerator8 == null)
                  num21 = 2;
                else
                  goto label_218;
label_217:
                switch (num21)
                {
                  case 1:
                  case 2:
                }
label_218:
                ClassMetadata.FvJ0sPbMhu5GbIHDYUmd((object) enumerator8);
                num21 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
                {
                  num21 = 1;
                  goto label_217;
                }
                else
                  goto label_217;
              }
          }
        }
label_4:
        attribute2 = AttributeHelper<ClassFormsSchemeAttribute>.GetAttribute(type, false);
        num1 = 72;
        continue;
label_10:
        attribute3 = AttributeHelper<NamespaceForDisplayAttribute>.GetAttribute(type, false);
        num1 = 106;
        continue;
label_44:
        attribute6 = AttributeHelper<TitlePropertyAttribute>.GetAttribute(type, false);
        num1 = 17;
        continue;
label_60:
        ((ClassDefaultForms) ClassMetadata.aaZhMVbyewFSI3wBafF2((object) this)).FormSettingsFromDictionary(dictionary);
        num1 = 8;
        continue;
label_115:
        if (attribute9 != null)
        {
          num1 = 87;
          continue;
        }
        goto label_4;
label_124:
        attribute10 = AttributeHelper<UidAttribute>.GetAttribute(type, false);
        num1 = 61;
      }
label_242:
      return;
label_228:
      return;
label_226:
      return;
label_232:;
    }

    protected virtual IEnumerable<PropertyInfo> GetPropertyInfosWithMetadata(
      Type type,
      bool inherit)
    {
      BindingFlags bindingAttr = BindingFlags.Instance | BindingFlags.Public;
      if (!inherit)
        bindingAttr |= BindingFlags.DeclaredOnly;
      return (IEnumerable<PropertyInfo>) type.GetReflectionProperties(bindingAttr);
    }

    /// <summary>Требуют ли изменения в метаданных перезапуска сервера</summary>
    /// <param name="metadata">Измененные метаданные</param>
    /// <returns>True, если требуют</returns>
    public virtual bool IsRestartNeeded(IRootMetadata metadata) => ClassMetadata.xHQqsEbMiVdIiLGIYRP1((object) this, (object) metadata) == PublicationType.Restart;

    /// <summary>Применить изменения, не требующие перезапуска сервера</summary>
    public virtual void ApplyRestartUnrequiredChanges(bool inherit)
    {
      int num = 4;
      while (true)
      {
        ClassMetadata publishedMetadata;
        MetadataItemManager metadataItemManager1;
        MetadataItemManager metadataItemManager2;
        switch (num)
        {
          case 0:
            goto label_11;
          case 1:
            if (metadataItemManager1 != null)
            {
              num = 5;
              continue;
            }
            goto label_2;
          case 2:
            metadataItemManager2 = (MetadataItemManager) null;
            break;
          case 3:
            if (!ClassMetadata.sFvIoPbMRJ9DGN8orLJP())
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 2 : 0;
              continue;
            }
            metadataItemManager2 = Locator.GetService<MetadataItemManager>();
            break;
          case 4:
            this._allForms = (List<FormViewItem>) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 3 : 1;
            continue;
          case 5:
            publishedMetadata = metadataItemManager1.GetSoftPublishedMetadata(ClassMetadata.xx9TxLbMqoIwN4LkvPlh((object) this)) as ClassMetadata;
            num = 6;
            continue;
          case 6:
            if (publishedMetadata == null)
            {
              num = 8;
              continue;
            }
            MetadataSoftPublishHelper.CopyChanges((IMetadata) this, (IMetadata) publishedMetadata);
            num = 7;
            continue;
          case 7:
            goto label_9;
          case 8:
            goto label_7;
          default:
            goto label_18;
        }
        metadataItemManager1 = metadataItemManager2;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 1 : 0;
      }
label_11:
      return;
label_9:
      return;
label_7:
      return;
label_18:
      return;
label_2:;
    }

    /// <summary>При изменении пространства имен</summary>
    protected virtual void OnNamespaceChanged()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.fullTypeName = (string) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <inheritdoc />
    protected override void OnNameChanged()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            base.OnNameChanged();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            this.fullTypeName = (string) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Создать табличное представление по умолчанию</summary>
    /// <returns>Табличное представление</returns>
    protected virtual TableView CreateDefaultTableView()
    {
      TableView defaultTableView = new TableView();
      ClassMetadata.s53xmqbMX5xt7NCvhAPh((object) defaultTableView, ClassMetadata.Xkdkf3bMKlmJAZQ0XQX5());
      defaultTableView.ViewType = ViewType.List;
      return defaultTableView;
    }

    protected virtual void GetFormsSettings(ClassDefaultForms defaultForms)
    {
      int num = 7;
      while (true)
      {
        ClassMetadata classMetadata1;
        ClassMetadata classMetadata2;
        switch (num)
        {
          case 2:
            goto label_7;
          case 3:
            ClassMetadata.vYWgHCbMkm50f0OhLvh1((object) classMetadata1, (object) defaultForms);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 1 : 0;
            continue;
          case 4:
            if (classMetadata1 == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 5:
            classMetadata2 = (ClassMetadata) null;
            break;
          case 6:
            classMetadata2 = (ClassMetadata) ((IMetadataService) ClassMetadata.p8NjsLbMTuhoAu58XjQq()).GetMetadata(ClassMetadata.YZA4m6byTq0IaYdXSpsU((object) this), false);
            break;
          case 7:
            if (ClassMetadata.nYidoWbykXsDOoYZarOd(ClassMetadata.YZA4m6byTq0IaYdXSpsU((object) this), Guid.Empty))
            {
              num = 6;
              continue;
            }
            goto case 5;
          default:
            ClassMetadata.ephy6DbMnRng3WreyKmb((object) this, (object) defaultForms);
            num = 2;
            continue;
        }
        classMetadata1 = classMetadata2;
        num = 4;
      }
label_7:;
    }

    /// <summary>
    /// Получить список форм данного класса (учитывая унаследованные формы и преобразования форм)
    /// </summary>
    protected virtual void GetForms(List<FormViewItem> forms, ClassDefaultForms defaultForms)
    {
      (this.BaseClassUid != Guid.Empty ? (ClassMetadata) MetadataServiceContext.Service.GetMetadata(this.BaseClassUid, false) : (ClassMetadata) null)?.GetForms(forms, defaultForms);
      ClassMetadata.AddForms(forms, this, defaultForms);
    }

    protected static void AddFormsSettings(ClassMetadata metadata, ClassDefaultForms defaultForms)
    {
      int num1 = 2;
      Dictionary<Guid, string>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_19;
          case 1:
            goto label_2;
          case 2:
            enumerator = ((ClassDefaultForms) ClassMetadata.aaZhMVbyewFSI3wBafF2((object) metadata)).FormSettingsToDictionary().GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 1 : 1;
            continue;
          default:
            goto label_15;
        }
      }
label_19:
      return;
label_15:
      return;
label_2:
      try
      {
label_10:
        if (enumerator.MoveNext())
          goto label_12;
        else
          goto label_11;
label_3:
        DefaultFormSetting defaultFormSetting1;
        int num2;
        KeyValuePair<Guid, string> formSetting;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 5:
              ClassMetadata.zpVb6wbM2Wq2qxTG4mY2((object) defaultFormSetting1, (object) formSetting.Value);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
              continue;
            case 2:
              formSetting = enumerator.Current;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 2 : 6;
              continue;
            case 3:
              if (defaultFormSetting1 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 5 : 5;
                continue;
              }
              goto case 7;
            case 4:
              goto label_5;
            case 6:
              defaultFormSetting1 = defaultForms.FormSettings.FirstOrDefault<DefaultFormSetting>((Func<DefaultFormSetting, bool>) (s => s.Uid == formSetting.Key));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 3 : 3;
              continue;
            case 7:
              DefaultFormSetting defaultFormSetting2 = new DefaultFormSetting();
              ClassMetadata.UctuGJbMOlH0H3qUIPI8((object) defaultFormSetting2, formSetting.Key);
              defaultFormSetting1 = defaultFormSetting2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 7 : 8;
              continue;
            case 8:
              defaultForms.FormSettings.Add(defaultFormSetting1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 1;
              continue;
            case 9:
              goto label_12;
            default:
              goto label_10;
          }
        }
label_5:
        return;
label_11:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 4 : 3;
        goto label_3;
label_12:
        num2 = 2;
        goto label_3;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    /// <summary>Добавить в список форм формы из указанных метаданных</summary>
    /// <param name="forms"></param>
    /// <param name="metadata"></param>
    protected static void AddForms(
      List<FormViewItem> forms,
      ClassMetadata metadata,
      ClassDefaultForms defaultForms)
    {
      List<FormViewItemTransformation> list = metadata.FormTransformations.ToList<FormViewItemTransformation>();
      foreach (IEntityMetadataFormTransformation extensionPoint in ComponentManager.Current.GetExtensionPoints<IEntityMetadataFormTransformation>())
        extensionPoint.GetTransformations(list);
      // ISSUE: reference to a compiler-generated method
      foreach (FormViewItemTransformation itemTransformation in list.Where<FormViewItemTransformation>((Func<FormViewItemTransformation, bool>) (t => ClassMetadata.\u003C\u003Ec.FRcSllCHnDoXSNqBCH77((object) t) == Guid.Empty)))
      {
        FormViewItemTransformation transform = itemTransformation;
        FormViewItem formViewItem1 = forms.FirstOrDefault<FormViewItem>((Func<FormViewItem, bool>) (f =>
        {
          int num = 4;
          Guid? uid1;
          Guid uid2;
          while (true)
          {
            switch (num)
            {
              case 1:
                goto label_2;
              case 2:
                goto label_8;
              case 3:
                uid2 = transform.Uid;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
                continue;
              case 4:
                uid1 = f.uid;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 2 : 3;
                continue;
              case 5:
                goto label_9;
              default:
                if (uid1.HasValue)
                {
                  if (uid1.HasValue)
                  {
                    num = 5;
                    continue;
                  }
                  goto label_8;
                }
                else
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 1 : 1;
                  continue;
                }
            }
          }
label_2:
          return false;
label_8:
          return true;
label_9:
          // ISSUE: reference to a compiler-generated method
          return ClassMetadata.\u003C\u003Ec__DisplayClass117_0.lYECvfCHHxgxm4SDDIVU(uid1.GetValueOrDefault(), uid2);
        }));
        if (formViewItem1 != null)
        {
          int index = forms.IndexOf(formViewItem1);
          FormViewItem formViewItem2 = formViewItem1.Transformate((ViewItemTransformation) transform);
          forms[index] = formViewItem2;
        }
      }
      forms.AddRange((IEnumerable<FormViewItem>) metadata.Forms);
      // ISSUE: reference to a compiler-generated method
      IEnumerable<FormViewItemTransformation> childFormTransformations = list.Where<FormViewItemTransformation>((Func<FormViewItemTransformation, bool>) (t => ClassMetadata.\u003C\u003Ec.Hqq0EDCHOXVgCky17LGC(t.NewFormUid, Guid.Empty)));
      foreach (FormViewItemTransformation transform in childFormTransformations)
        ClassMetadata.AddChildForm(forms, childFormTransformations, (object) transform);
      defaultForms.FromDictionary(metadata.DefaultForms.ToDictionary(), false);
      defaultForms.FormSettingsFromDictionary(metadata.DefaultForms.FormSettingsToDictionary(), false);
    }

    private static FormViewItem AddChildForm(
      List<FormViewItem> forms,
      IEnumerable<FormViewItemTransformation> childFormTransformations,
      object transform)
    {
      FormViewItemTransformation transform1 = (FormViewItemTransformation) transform;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      FormViewItem formViewItem1 = forms.FirstOrDefault<FormViewItem>((Func<FormViewItem, bool>) (f => ClassMetadata.\u003C\u003Ec__DisplayClass123_0.mbJB5ECHyE2OSgwpvTmE(ClassMetadata.\u003C\u003Ec__DisplayClass123_0.basPjuCHmOUWF2u1lVN6((object) f), transform1.NewFormUid)));
      if (formViewItem1 != null)
        return formViewItem1;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      FormViewItem formViewItem2 = forms.FirstOrDefault<FormViewItem>((Func<FormViewItem, bool>) (f => ClassMetadata.\u003C\u003Ec__DisplayClass123_0.mbJB5ECHyE2OSgwpvTmE(ClassMetadata.\u003C\u003Ec__DisplayClass123_0.basPjuCHmOUWF2u1lVN6((object) f), transform1.Uid)));
      if (formViewItem2 == null)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        FormViewItemTransformation transform2 = childFormTransformations.FirstOrDefault<FormViewItemTransformation>((Func<FormViewItemTransformation, bool>) (t => ClassMetadata.\u003C\u003Ec__DisplayClass123_0.mbJB5ECHyE2OSgwpvTmE(ClassMetadata.\u003C\u003Ec__DisplayClass123_0.gmys05CHMFORrBXCBRyg((object) t), transform1.Uid)));
        if (transform2 == null)
          return (FormViewItem) null;
        formViewItem2 = ClassMetadata.AddChildForm(forms, childFormTransformations, (object) transform2);
        if (formViewItem2 == null)
          return (FormViewItem) null;
      }
      FormViewItem formViewItem3 = formViewItem2.Transformate((ViewItemTransformation) transform1);
      forms.Add(formViewItem3);
      return formViewItem3;
    }

    internal static object Kn08mrbyKsMLJwmK2rpA([In] object obj0) => (object) (string) (EleWise.ELMA.SR.LocalizableString) obj0;

    internal static bool ClCZlPbyRAE6e4nUamri() => ClassMetadata.S2vmREbyiUOO08f9MM4f == null;

    internal static ClassMetadata tS0MMxbyquHFWARas1iR() => ClassMetadata.S2vmREbyiUOO08f9MM4f;

    internal static object b9hhEWbyXYQdaOrkKXmN([In] object obj0) => (object) (EleWise.ELMA.SR.LocalizableString) (string) obj0;

    internal static Guid YZA4m6byTq0IaYdXSpsU([In] object obj0) => ((ClassMetadata) obj0).BaseClassUid;

    internal static bool nYidoWbykXsDOoYZarOd([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static int IywOnLbynVbHaOOkjUtM([In] object obj0) => ((List<PropertyMetadata>) obj0).Count;

    internal static int zv3efbbyOxN8a7jWq5LT([In] object obj0) => ((List<PropertiesContainer>) obj0).Count;

    internal static void VMIB6Xby2I3GWoc4taf9([In] object obj0, [In] object obj1) => ((ClassDefaultForms) obj0).SetOwner((ClassMetadata) obj1);

    internal static object aaZhMVbyewFSI3wBafF2([In] object obj0) => (object) ((ClassMetadata) obj0).DefaultForms;

    internal static int lsCg6CbyPEcuYaxikCBF([In] object obj0) => ((List<FormViewItem>) obj0).Count;

    internal static int V2bqRoby1Nm0hWDI8urK([In] object obj0) => ((List<FormView>) obj0).Count;

    internal static int F2L9YjbyNNDHwyCRbaYc([In] object obj0) => ((List<TableView>) obj0).Count;

    internal static void mOZYeKby3YBWLnAMYKNC() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object JHYTSLbypH9feifq99H1() => (object) EleWise.ELMA.SR.LocalizableString.Empty;

    internal static void pXw3FEbya0Fk09o7ZqCo([In] object obj0, [In] object obj1) => ((ClassMetadata) obj0).DefaultForms = (ClassDefaultForms) obj1;

    internal static bool MFK1rEbyDP45nrajyx0K([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object LaN9Ugbyt4xnVB5OkKTf([In] object obj0) => (object) ((ClassMetadata) obj0).Namespace;

    internal static object gXxCexbywJ9LUQCUN2yY(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object bQXGp5by49UEZfIemyAU([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object BtqGlPby6Uy5jRbNpPO8([In] object obj0) => (object) ((ClassMetadata) obj0).TypeName;

    internal static object KEu49jbyHyfB5hBPCC2M([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static void FZrHIAbyAlrXmMCqL2L8([In] object obj0) => ((AbstractMetadata) obj0).InitNew();

    internal static void d8Zknoby7Huhd6BcDkFO([In] object obj0) => ((AbstractMetadata) obj0).AfterLoad();

    internal static bool mqd2Osbyx93pFPSNb9hC([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static Guid ekLavlby04OCREvTrY4K([In] object obj0) => ((string) obj0).GetDeterministicGuid();

    internal static Guid EISJQ3bym6JjVbLfWYPE([In] object obj0) => ((UidAttribute) obj0).Uid;

    internal static void yBDwiPbyyKHNYZplbMZ1([In] object obj0, bool value) => ((AbstractMetadata) obj0).Internal = value;

    internal static object UJoHyvbyMhcA9fsPluGL([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static void SfmqAPbyJ4GGlNvKL0TY([In] object obj0, [In] object obj1) => ((NamedMetadata) obj0).Name = (string) obj1;

    internal static void griiK2by9q0ebIRUYUDx([In] object obj0, [In] object obj1) => ((ClassMetadata) obj0).Namespace = (string) obj1;

    internal static void cehtqDbydHDxJPxk0Z1m([In] object obj0, long value) => ((ClassMetadata) obj0).GroupId = value;

    internal static object rE4ehIbyl5D1DGP2phJG([In] object obj0) => (object) ((LocalizedStringAttribute) obj0).LocalizedString;

    internal static void PyLOGQbyrB3kbuDNooe3([In] object obj0, [In] object obj1) => NamedMetadata.SetDisplayName((NamedMetadata) obj0, (EleWise.ELMA.SR.LocalizableString) obj1);

    internal static Guid JtopUwbygG0d4Ws5sm98([In] object obj0) => ((BaseClassAttribute) obj0).BaseClassUid;

    internal static void e3EvIeby5jB54XLBjmUt([In] object obj0, Guid value) => ((ClassMetadata) obj0).BaseClassUid = value;

    internal static bool RiM3PibyjRjTFc0jSHOS([In] object obj0) => ((AllowCreateHeirsAttribute) obj0).Value;

    internal static void ggpeXNbyYo4DCDxkWS3V([In] object obj0, bool value) => ((ClassMetadata) obj0).AllowCreateHeirs = value;

    internal static void zRFUiHbyL6did1mTLo8C([In] object obj0, bool value) => ((ClassMetadata) obj0).ShowInTypeTree = value;

    internal static bool MWXj1IbyUWQ115eRBQPn([In] object obj0) => ((ShowInDesignerAttribute) obj0).Visible;

    internal static object wN6YIhbysWPKGhIlDhd6([In] object obj0) => (object) ((ScriptModuleAttribute) obj0).TypeName;

    internal static void Suv6RDbycSDoaWyDcxSD([In] object obj0, [In] object obj1) => ((ClassMetadata) obj0).ScriptModuleTypeName = (string) obj1;

    internal static Type YP2ChHbyzZYUFnYDcocs([In] object obj0) => ((FilterForAttribute) obj0).EntityType;

    internal static object fLvutabMF8r0auhquvPa() => (object) Logger.Log;

    internal static void rSgql5bMBuZtvR8lwKs9([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Debug(obj1, (Exception) obj2);

    internal static Type kP6cPSbMW61ismYK9DPH([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object zK2L0vbMoIPSC44f9DH4(Type type, Type attributeType, bool inherit) => (object) type.GetReflectionCustomAttributes(attributeType, inherit);

    internal static bool Oh29ewbMbh3pBa5wSCJf([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void FvJ0sPbMhu5GbIHDYUmd([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void H5UU5sbMGrbMuLq42iHJ([In] object obj0, [In] object obj1) => ((ClassMetadata) obj0).CustomCode = (string) obj1;

    internal static ClassFormsScheme wctHfXbMEMwOR7XLbkU8([In] object obj0) => ((ClassFormsSchemeAttribute) obj0).Scheme;

    internal static void YNajXBbMfAHHjAfVpBX2([In] object obj0, ClassFormsScheme value) => ((ClassMetadata) obj0).FormsScheme = value;

    internal static object kHTFAibMQdGT8HbLOwoD([In] object obj0) => (object) ((FormTransformationAttribute) obj0).Transformation;

    internal static object XcQvb4bMCytHmi7dAbOL([In] object obj0) => (object) ((FormViewAttribute) obj0).View;

    internal static bool QbfrH9bMv2h1SgZ2Mylu([In] object obj0, [In] Type obj1, [In] bool obj2) => ((MemberInfo) obj0).IsDefined(obj1, obj2);

    internal static void rMYgNYbM84fJvK5BNeTv([In] object obj0, [In] object obj1, [In] object obj2) => ((PropertyMetadata) obj0).LoadFromPropertyInfo((PropertyInfo) obj1, (PropertyMetadata) obj2);

    internal static int tZC2KubMZV1JSNcpGHOr([In] object obj0) => ((List<OverrideExtensibleClassPropertyAttribute>) obj0).Count;

    internal static object tj6SYobMuIHDpy7VsLZL([In] object obj0) => (object) ((OverrideExtensibleClassPropertyAttribute) obj0).PropertyValue;

    internal static bool nKWH0DbMIfJucwiyKAw0([In] object obj0) => ((string) obj0).IsNullOrEmpty();

    internal static object SraP6EbMVJ6NqAkXoRa9([In] object obj0) => (object) ((EntityMetadata) obj0).Filter;

    internal static void t2j4XubMS8Le2no9dSpp([In] object obj0, [In] object obj1) => MetadataSoftPublishHelper.CopyChanges((IMetadata) obj0, (IMetadata) obj1);

    internal static PublicationType xHQqsEbMiVdIiLGIYRP1([In] object obj0, [In] object obj1) => MetadataSoftPublishHelper.IsEqualsObject(obj0, obj1);

    internal static bool sFvIoPbMRJ9DGN8orLJP() => Locator.Initialized;

    internal static Guid xx9TxLbMqoIwN4LkvPlh([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static Guid Xkdkf3bMKlmJAZQ0XQX5() => Guid.NewGuid();

    internal static void s53xmqbMX5xt7NCvhAPh([In] object obj0, Guid value) => ((TableView) obj0).Uid = value;

    internal static object p8NjsLbMTuhoAu58XjQq() => (object) MetadataServiceContext.Service;

    internal static void vYWgHCbMkm50f0OhLvh1([In] object obj0, [In] object obj1) => ((ClassMetadata) obj0).GetFormsSettings((ClassDefaultForms) obj1);

    internal static void ephy6DbMnRng3WreyKmb([In] object obj0, [In] object obj1) => ClassMetadata.AddFormsSettings((ClassMetadata) obj0, (ClassDefaultForms) obj1);

    internal static void UctuGJbMOlH0H3qUIPI8([In] object obj0, Guid value) => ((DefaultFormSetting) obj0).Uid = value;

    internal static void zpVb6wbM2Wq2qxTG4mY2([In] object obj0, [In] object obj1) => ((DefaultFormSetting) obj0).Value = (string) obj1;

    /// <summary>Информация о типе метаданных</summary>
    [Component]
    private class Info : IMetadataTypeInfo
    {
      internal static object HoFJD5CHZXgSYxw8XXMe;

      public string Name => (string) ClassMetadata.Info.R8nX7wCHVkg3HQh6A15Z((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675727601));

      public string Description => (string) ClassMetadata.Info.R8nX7wCHVkg3HQh6A15Z(ClassMetadata.Info.TdJ7UHCHSxnu8VjReEdQ(1917998801 >> 2 ^ 479279882));

      public Type MetadataType => ClassMetadata.Info.JqVaEiCHi7VTR7ajimeZ(__typeref (ClassMetadata));

      public Type GeneratorType => ClassMetadata.Info.JqVaEiCHi7VTR7ajimeZ(__typeref (ClassGenerator));

      public Info()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static object R8nX7wCHVkg3HQh6A15Z([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

      internal static bool v5YLwUCHu4ss8sADDID6() => ClassMetadata.Info.HoFJD5CHZXgSYxw8XXMe == null;

      internal static ClassMetadata.Info ueu8cCCHIOwhsUNS0foB() => (ClassMetadata.Info) ClassMetadata.Info.HoFJD5CHZXgSYxw8XXMe;

      internal static object TdJ7UHCHSxnu8VjReEdQ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static Type JqVaEiCHi7VTR7ajimeZ([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);
    }
  }
}
