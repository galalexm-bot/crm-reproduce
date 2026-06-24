// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Settings.EntitySettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Types.Settings
{
  /// <summary>Настройки типа "Объект"</summary>
  [Serializable]
  public class EntitySettings : SimpleTypeSettings, IRelationTypeSettings
  {
    private static EntitySettings JrynpibBG6b3pZrngF5Z;

    /// <summary>Ctor</summary>
    public EntitySettings()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Deserialization ctor</summary>
    /// <param name="info">Serialization info</param>
    /// <param name="context">Context</param>
    protected EntitySettings(SerializationInfo info, StreamingContext context)
    {
      EntitySettings.fXoItGbBQBGExTEQ004B();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Тип связи</summary>
    [XmlElement("RelationType")]
    [DefaultValue(RelationType.OneToOne)]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (EntitySettings.__Resources), "RelationType")]
    [PublicationBehaviour(PublicationType.Restart)]
    public RelationType RelationType
    {
      get => this.\u003CRelationType\u003Ek__BackingField;
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
              this.\u003CRelationType\u003Ek__BackingField = value;
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

    /// <summary>Название таблицы в БД, содержащей связи N-N</summary>
    [JsonSerializationIgnore]
    [DefaultValue("")]
    [PublicationBehaviour(PublicationType.Restart)]
    [XmlElement("RelationTableName")]
    public string RelationTableName
    {
      get => this.\u003CRelationTableName\u003Ek__BackingField;
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
              this.\u003CRelationTableName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 0 : 0;
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
    /// Название колонки родительского значения таблице связей N-N
    /// </summary>
    [DefaultValue("")]
    [PublicationBehaviour(PublicationType.Restart)]
    [JsonSerializationIgnore]
    [XmlElement("ParentColumnName")]
    public string ParentColumnName
    {
      get => this.\u003CParentColumnName\u003Ek__BackingField;
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
              this.\u003CParentColumnName\u003Ek__BackingField = value;
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

    /// <summary>
    /// Название колонки дочернего значения таблице связей N-N
    /// </summary>
    [JsonSerializationIgnore]
    [XmlElement("ChildColumnName")]
    [PublicationBehaviour(PublicationType.Restart)]
    [DefaultValue("")]
    public string ChildColumnName
    {
      get => this.\u003CChildColumnName\u003Ek__BackingField;
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
              this.\u003CChildColumnName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
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

    /// <summary>Uid свойства, по которому идет join в связи 1-N</summary>
    [PublicationBehaviour(PublicationType.Restart)]
    [XmlIgnore]
    public Guid KeyColumnUid
    {
      get => this.\u003CKeyColumnUid\u003Ek__BackingField;
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
              this.\u003CKeyColumnUid\u003Ek__BackingField = value;
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
    /// Uid свойства, по которому идет join в связи 1-N (для сериализации)
    /// </summary>
    [JsonSerializationIgnore]
    [XmlElement("KeyColumnUid")]
    [DefaultValue("")]
    [PublicationBehaviour(PublicationType.Restart)]
    public string KeyColumnUidStr
    {
      get
      {
        int num = 2;
        Guid keyColumnUid;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_5;
            case 2:
              if (!EntitySettings.TEu9QmbBCqEOmkEVnqfw(this.KeyColumnUid, Guid.Empty))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 1 : 1;
                continue;
              }
              keyColumnUid = this.KeyColumnUid;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return keyColumnUid.ToString();
label_5:
        return "";
      }
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_4;
            case 1:
              this.KeyColumnUid = string.IsNullOrEmpty(value) ? Guid.Empty : new Guid(value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_4:
        return;
label_2:;
      }
    }

    /// <summary>
    /// Режим поведения дочеерних сущностей при операции удаления, сохранения изменений
    /// </summary>
    [PublicationBehaviour(PublicationType.Restart)]
    [DefaultValue(CascadeMode.None)]
    [XmlElement("CascadeMode")]
    [JsonSerializationIgnore]
    public CascadeMode CascadeMode
    {
      get => this.\u003CCascadeMode\u003Ek__BackingField;
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
              this.\u003CCascadeMode\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
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
    /// Генерировать в фильтре список сущностей (в независимости от типа связи)
    /// </summary>
    [PublicationBehaviour(PublicationType.Restart)]
    [XmlElement("GenerateListInFilter")]
    [JsonSerializationIgnore]
    [DefaultValue(false)]
    public bool GenerateListInFilter
    {
      get => this.\u003CGenerateListInFilter\u003Ek__BackingField;
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
              this.\u003CGenerateListInFilter\u003Ek__BackingField = value;
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

    /// <summary>Генерировать в фильтре фильтр выбранной сущности</summary>
    [JsonSerializationIgnore]
    [DefaultValue(false)]
    [XmlElement("GenerateFilterInFilter")]
    [PublicationBehaviour(PublicationType.Restart)]
    public bool GenerateFilterInFilter
    {
      get => this.\u003CGenerateFilterInFilter\u003Ek__BackingField;
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
              this.\u003CGenerateFilterInFilter\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
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

    /// <summary>Показывать при выборе только группы</summary>
    [XmlElement("ShowOnlyGroups")]
    [DefaultValue(false)]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (EntitySettings.__Resources), "ShowOnlyGroups")]
    public bool ShowOnlyGroups
    {
      get => this.\u003CShowOnlyGroups\u003Ek__BackingField;
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
              this.\u003CShowOnlyGroups\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
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

    /// <summary>Глубина отображения иерархического объекта</summary>
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (EntitySettings.__Resources), "HierarchyDeep")]
    [XmlElement("HierarchyDeep")]
    [DefaultValue(0)]
    public int HierarchyDeep
    {
      get => this.\u003CHierarchyDeep\u003Ek__BackingField;
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
              this.\u003CHierarchyDeep\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
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

    /// <summary>Отступ отображения иерархического объекта</summary>
    [DefaultValue(0)]
    [XmlElement("HierarchyIndent")]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (EntitySettings.__Resources), "HierarchyIndent")]
    public int HierarchyIndent
    {
      get => this.\u003CHierarchyIndent\u003Ek__BackingField;
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
              this.\u003CHierarchyIndent\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
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

    /// <summary>Uid свойства-родителя для иерархии</summary>
    [XmlIgnore]
    public Guid HierarchyParentUid
    {
      get => this.\u003CHierarchyParentUid\u003Ek__BackingField;
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
              this.\u003CHierarchyParentUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
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

    /// <summary>Uid свойства-родителя для иерархии (для сериализации)</summary>
    [XmlElement("HierarchyParentUid")]
    [DefaultValue("")]
    [JsonSerializationIgnore]
    public string HierarchyParentUidStr
    {
      get
      {
        int num = 2;
        Guid hierarchyParentUid;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_2;
            case 2:
              if (EntitySettings.TEu9QmbBCqEOmkEVnqfw(this.HierarchyParentUid, Guid.Empty))
              {
                hierarchyParentUid = this.HierarchyParentUid;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
                continue;
              }
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 1 : 0;
              continue;
            default:
              goto label_6;
          }
        }
label_2:
        return "";
label_6:
        return hierarchyParentUid.ToString();
      }
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_4;
            case 1:
              this.HierarchyParentUid = EntitySettings.he8uJNbBvST8GuJxMl2O((object) value) ? Guid.Empty : new Guid(value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_4:
        return;
label_2:;
      }
    }

    /// <summary>Условие выборки на языке EQL</summary>
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (EntitySettings.__Resources), "FilterQuery")]
    [XmlElement("FilterQuery")]
    [DefaultValue("")]
    [PublicationBehaviour(PublicationType.Restart)]
    public string FilterQuery
    {
      get => this.\u003CFilterQuery\u003Ek__BackingField;
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
              this.\u003CFilterQuery\u003Ek__BackingField = value;
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

    /// <summary>Загружать данные с сервера через EQL</summary>
    [XmlElement("IsComputedEqlValue")]
    [DefaultValue(false)]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (EntitySettings.__Resources), "IsComputedEqlValue")]
    public bool IsComputedEqlValue
    {
      get => this.\u003CIsComputedEqlValue\u003Ek__BackingField;
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
              this.\u003CIsComputedEqlValue\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
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

    /// <summary>EQL условие для заполнения выбранных значений</summary>
    [XmlElement("ComputedEqlQuery")]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (EntitySettings.__Resources), "ComputedEqlQuery")]
    [PublicationBehaviour(PublicationType.Restart)]
    [DefaultValue("")]
    public string ComputedEqlQuery
    {
      get => this.\u003CComputedEqlQuery\u003Ek__BackingField;
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
              this.\u003CComputedEqlQuery\u003Ek__BackingField = value;
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

    /// <summary>Использовать сортировку в списке свойства</summary>
    [XmlElement("CanSortProperty")]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (EntitySettings.__Resources), "CanSortProperty")]
    [PublicationBehaviour(PublicationType.Restart)]
    [DefaultValue(false)]
    public bool CanSortProperty
    {
      get => this.\u003CCanSortProperty\u003Ek__BackingField;
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
              this.\u003CCanSortProperty\u003Ek__BackingField = value;
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

    /// <summary>Uid свойства для сортировки (сериализация)</summary>
    [XmlElement("SortPropertyUid")]
    [DefaultValue("")]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (EntitySettings.__Resources), "SortPropertyUid")]
    [PublicationBehaviour(PublicationType.Restart)]
    public string SortPropertyUidStr
    {
      get
      {
        int num = 1;
        Guid sortPropertyUid;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.SortPropertyUid != Guid.Empty)
              {
                sortPropertyUid = this.SortPropertyUid;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 2 : 2;
                continue;
              }
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_6;
            default:
              goto label_2;
          }
        }
label_2:
        return "";
label_6:
        return sortPropertyUid.ToString();
      }
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_4;
            case 1:
              this.SortPropertyUid = EntitySettings.he8uJNbBvST8GuJxMl2O((object) value) ? Guid.Empty : new Guid(value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_4:
        return;
label_2:;
      }
    }

    /// <summary>Имя свойства для сортировки</summary>
    [XmlIgnore]
    public Guid SortPropertyUid
    {
      get => this.\u003CSortPropertyUid\u003Ek__BackingField;
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
              this.\u003CSortPropertyUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
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

    /// <summary>Порядок сортировки</summary>
    [XmlElement("SortPropertyOrder")]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (EntitySettings.__Resources), "SortPropertyOrder")]
    [PublicationBehaviour(PublicationType.Restart)]
    [DefaultValue(ListSortDirection.Ascending)]
    public ListSortDirection SortPropertyOrder
    {
      get => this.\u003CSortPropertyOrder\u003Ek__BackingField;
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
              this.\u003CSortPropertyOrder\u003Ek__BackingField = value;
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

    /// <summary>Не давать возможности создавать новый объект с формы</summary>
    [XmlElement("HideCreator")]
    [PublicationBehaviour(PublicationType.Restart)]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (EntitySettings.__Resources), "HideCreator")]
    [DefaultValue(false)]
    public bool HideCreator
    {
      get => this.\u003CHideCreator\u003Ek__BackingField;
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
              this.\u003CHideCreator\u003Ek__BackingField = value;
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

    /// <summary>
    /// Не давать возможности выбирать элемент в отдельном всплывающем окне.
    /// </summary>
    [PublicationBehaviour(PublicationType.Restart)]
    [DefaultValue(false)]
    [XmlElement("HideSelect")]
    public bool HideSelect
    {
      get => this.\u003CHideSelect\u003Ek__BackingField;
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
              this.\u003CHideSelect\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
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
    /// Указать окно, в котором необходимо открыть данную ссылку. Если не указано, то открывается в текущем.
    /// </summary>
    [DefaultValue("")]
    [XmlIgnore]
    public string Target
    {
      get => this.\u003CTarget\u003Ek__BackingField;
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
              this.\u003CTarget\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
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
    [XmlElement("CopyAction")]
    [DefaultValue(CopyAction.Default)]
    [Property("{849C1AC9-4D46-4194-8CBB-43F84ADF9C17}", "ded50eaa-8f9d-4457-b083-60b8b721705b")]
    [JsonSerializationIgnore]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
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
    /// Получить имена полей БД, которые создаются для данного свойства в таблице сущности
    /// </summary>
    /// <returns></returns>
    public override string[] GetFieldNames()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.RelationType != RelationType.OneToOne)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
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
      return new string[1]{ this.FieldName };
label_5:
      return new string[0];
    }

    public override bool Equals(object obj)
    {
      int num1 = 8;
      EntitySettings entitySettings;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!EntitySettings.z3BqmObBZxwPDWHMXRP5((object) this.ChildColumnName, (object) entitySettings.ChildColumnName))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
                continue;
              }
              goto case 9;
            case 2:
              if (this.SortPropertyOrder == entitySettings.SortPropertyOrder)
              {
                num2 = 3;
                continue;
              }
              goto label_22;
            case 3:
              goto label_21;
            case 4:
              if (this.ParentColumnName == entitySettings.ParentColumnName)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 1 : 1;
                continue;
              }
              goto label_22;
            case 5:
              if (EntitySettings.z3BqmObBZxwPDWHMXRP5((object) this.RelationTableName, EntitySettings.p7Mrn6bB8QF1FtSGi7gd((object) entitySettings)))
              {
                num2 = 4;
                continue;
              }
              goto label_22;
            case 7:
              if (entitySettings != null)
              {
                if (base.Equals(obj))
                {
                  num2 = 5;
                  continue;
                }
                goto label_22;
              }
              else
                goto label_4;
            case 8:
              goto label_20;
            case 9:
              if (!EntitySettings.oDyToZbBIhJMMXWShGUx(this.KeyColumnUid, EntitySettings.gt28T1bBuaGUrCqaLPNe((object) entitySettings)))
              {
                num2 = 6;
                continue;
              }
              goto case 10;
            case 10:
              if (this.CanSortProperty == EntitySettings.ghPcFJbBVZbtbUyx54x4((object) entitySettings))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 2 : 0;
                continue;
              }
              goto label_22;
            case 11:
              goto label_7;
            default:
              goto label_22;
          }
        }
label_4:
        num1 = 11;
        continue;
label_20:
        entitySettings = obj as EntitySettings;
        num1 = 7;
      }
label_7:
      return false;
label_21:
      return EntitySettings.oDyToZbBIhJMMXWShGUx(this.SortPropertyUid, EntitySettings.hxHkNAbBSCWU1WA6P3ai((object) entitySettings));
label_22:
      return false;
    }

    /// <summary>Сгенерировать имя таблицы связи N-N</summary>
    /// <param name="entityMetadata">Метаданные сущности</param>
    /// <param name="propName">Метаданные свойства</param>
    /// <returns>Имя таблицы</returns>
    public static string GenerateRelationTableName(EntityMetadata entityMetadata, string propName)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            Contract.ArgumentNotNull((object) propName, (string) EntitySettings.n9toJYbBixUCVXXrSR0K(654297945 ^ 654140859));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
            continue;
          case 2:
            EntitySettings.tdn4f3bBROrVWiLcAm6W((object) entityMetadata, EntitySettings.n9toJYbBixUCVXXrSR0K(712480695 ^ 712317049));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 1;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      StringBuilder stringBuilder = new StringBuilder();
      EntitySettings.HOfb56bBqvGgGEAMiWn7((object) stringBuilder, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-680446928 - -370807692 ^ -309728950));
      object obj = EntitySettings.zoi2HubBKNMCDw2RWKog((object) entityMetadata);
      string name = obj == null ? "" : (string) obj;
      string str = propName;
      if (EntitySettings.Yw182YbBX52iUt6r9K2n((object) name) + EntitySettings.Yw182YbBX52iUt6r9K2n((object) str) > 26)
      {
        if (name.Length > 13)
          name = EntitySettings.GenerateRelationName13((object) name, 13);
        int maxLength = 26 - EntitySettings.Yw182YbBX52iUt6r9K2n((object) name);
        if (EntitySettings.Yw182YbBX52iUt6r9K2n((object) str) > maxLength)
          str = (string) EntitySettings.bippiGbBTmQjY5KsOhVc((object) str, maxLength);
      }
      EntitySettings.HOfb56bBqvGgGEAMiWn7((object) stringBuilder, (object) name);
      EntitySettings.HOfb56bBqvGgGEAMiWn7((object) stringBuilder, EntitySettings.n9toJYbBixUCVXXrSR0K(1012087039 ^ 1012085893));
      stringBuilder.Append(str);
      return stringBuilder.ToString();
    }

    private static string GenerateRelationName13(object name, int maxLength)
    {
      int num1 = 7;
      string relationName13;
      while (true)
      {
        int num2 = num1;
        char[] chArray;
        char ch;
        int index;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (ch > '9')
              {
                num2 = 21;
                continue;
              }
              goto label_21;
            case 2:
              goto label_15;
            case 3:
            case 11:
              goto label_10;
            case 4:
              if (ch > 'Z')
              {
                num2 = 5;
                continue;
              }
              goto label_21;
            case 5:
            case 9:
              if (ch < '0')
              {
                num2 = 10;
                continue;
              }
              goto case 1;
            case 6:
              if (EntitySettings.Yw182YbBX52iUt6r9K2n(name) > maxLength)
              {
                num2 = 25;
                continue;
              }
              goto label_15;
            case 7:
              if (!EntitySettings.he8uJNbBvST8GuJxMl2O(name))
              {
                num2 = 6;
                continue;
              }
              goto label_3;
            case 8:
              index = 0;
              num2 = 16;
              continue;
            case 10:
            case 12:
            case 21:
              goto label_31;
            case 13:
              if (ch < 'A')
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 7 : 9;
                continue;
              }
              goto case 4;
            case 14:
              chArray = (char[]) EntitySettings.A3kR70bBktLeRpQl2N1a(name);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 7 : 8;
              continue;
            case 15:
            case 16:
              if (index >= chArray.Length)
                goto case 24;
              else
                goto label_23;
            case 17:
            case 23:
              ch = chArray[index];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 13 : 11;
              continue;
            case 19:
              if (EntitySettings.Yw182YbBX52iUt6r9K2n((object) relationName13) > maxLength)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 26 : 14;
                continue;
              }
              goto label_10;
            case 20:
              goto label_3;
            case 22:
              goto label_21;
            case 24:
              if (EntitySettings.Yw182YbBX52iUt6r9K2n((object) relationName13) <= 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 0;
                continue;
              }
              goto case 19;
            case 25:
              relationName13 = "";
              num2 = 14;
              continue;
            case 26:
              relationName13 = (string) EntitySettings.hCoApDbBOsTTi2kOvdKh((object) relationName13, 0, maxLength);
              num2 = 11;
              continue;
            default:
              relationName13 = (string) EntitySettings.hCoApDbBOsTTi2kOvdKh(name, 0, maxLength);
              num2 = 3;
              continue;
          }
        }
label_21:
        relationName13 = (string) EntitySettings.IC530NbBnEPt8MDB25S8((object) relationName13, (object) ch.ToString());
        num1 = 12;
        continue;
label_23:
        num1 = 17;
        continue;
label_31:
        ++index;
        num1 = 15;
      }
label_3:
      return "";
label_10:
      return relationName13;
label_15:
      return (string) name;
    }

    /// <summary>Тип отображения</summary>
    [XmlElement("DisplayType")]
    [DefaultValue(EntityDisplayType.Standard)]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (EntitySettings.__Resources), "DisplayType")]
    public EntityDisplayType DisplayType
    {
      get => this.\u003CDisplayType\u003Ek__BackingField;
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
              this.\u003CDisplayType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
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
    /// Максимальное количество сущностей для отображения в нестандартных режимах
    /// </summary>
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (EntitySettings.__Resources), "MaxCount")]
    [XmlElement("MaxCount")]
    [DefaultValue(100)]
    public int MaxCount
    {
      get => this.\u003CMaxCount\u003Ek__BackingField;
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
              this.\u003CMaxCount\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
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

    public override void SetTypeSettings(PropertiesContainer dict)
    {
      int num = 3;
      while (true)
      {
        bool? nullable;
        switch (num)
        {
          case 2:
            if (nullable.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 1;
              continue;
            }
            goto case 5;
          case 3:
            if (dict.TryGetValue<bool?>((string) EntitySettings.n9toJYbBixUCVXXrSR0K(~210725948 ^ -210617027), out nullable))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 2;
              continue;
            }
            break;
          case 4:
            goto label_4;
          case 5:
            dict.RemoveProperty((string) EntitySettings.n9toJYbBixUCVXXrSR0K(1149433385 + 173655049 ^ 1323177164));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
            continue;
        }
        base.SetTypeSettings(dict);
        num = 4;
      }
label_4:;
    }

    internal static bool CkjtsWbBEMtlVL6bcnIH() => EntitySettings.JrynpibBG6b3pZrngF5Z == null;

    internal static EntitySettings OQxYDDbBf1OYhKPML0kt() => EntitySettings.JrynpibBG6b3pZrngF5Z;

    internal static void fXoItGbBQBGExTEQ004B() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool TEu9QmbBCqEOmkEVnqfw([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static bool he8uJNbBvST8GuJxMl2O([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object p7Mrn6bB8QF1FtSGi7gd([In] object obj0) => (object) ((EntitySettings) obj0).RelationTableName;

    internal static bool z3BqmObBZxwPDWHMXRP5([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static Guid gt28T1bBuaGUrCqaLPNe([In] object obj0) => ((EntitySettings) obj0).KeyColumnUid;

    internal static bool oDyToZbBIhJMMXWShGUx([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static bool ghPcFJbBVZbtbUyx54x4([In] object obj0) => ((EntitySettings) obj0).CanSortProperty;

    internal static Guid hxHkNAbBSCWU1WA6P3ai([In] object obj0) => ((EntitySettings) obj0).SortPropertyUid;

    internal static object n9toJYbBixUCVXXrSR0K(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void tdn4f3bBROrVWiLcAm6W([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object HOfb56bBqvGgGEAMiWn7([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).Append((string) obj1);

    internal static object zoi2HubBKNMCDw2RWKog([In] object obj0) => (object) ((EntityMetadata) obj0).TableName;

    internal static int Yw182YbBX52iUt6r9K2n([In] object obj0) => ((string) obj0).Length;

    internal static object bippiGbBTmQjY5KsOhVc([In] object obj0, int maxLength) => (object) EntitySettings.GenerateRelationName13(obj0, maxLength);

    internal static object A3kR70bBktLeRpQl2N1a([In] object obj0) => (object) ((string) obj0).ToCharArray();

    internal static object IC530NbBnEPt8MDB25S8([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object hCoApDbBOsTTi2kOvdKh([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);

    private static class __Resources
    {
      internal static object xuTCyxCXSHiKqZQo7g6P;

      public static string RelationType => EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998252038), (object) EntitySettings.__Resources.GetRelationTypeValues());

      public static string ShowOnlyGroups => (string) EntitySettings.__Resources.pVKF9ZCXKbdLIfpaKpH8(EntitySettings.__Resources.COqeEUCXqJAlHAV2m3k3(1581325282 << 3 ^ -233996776));

      public static string HierarchyDeep => (string) EntitySettings.__Resources.pVKF9ZCXKbdLIfpaKpH8(EntitySettings.__Resources.COqeEUCXqJAlHAV2m3k3(-1334993905 ^ -1335345715));

      public static string HierarchyIndent => (string) EntitySettings.__Resources.pVKF9ZCXKbdLIfpaKpH8(EntitySettings.__Resources.COqeEUCXqJAlHAV2m3k3(1819636893 << 3 ^ 1672349426));

      public static string FilterQuery => EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(222162814 ^ 222209706));

      public static string ComputedEqlQuery => (string) EntitySettings.__Resources.pVKF9ZCXKbdLIfpaKpH8(EntitySettings.__Resources.COqeEUCXqJAlHAV2m3k3(-1998538950 ^ -1998252726));

      public static string IsComputedEqlValue => (string) EntitySettings.__Resources.pVKF9ZCXKbdLIfpaKpH8(EntitySettings.__Resources.COqeEUCXqJAlHAV2m3k3(333888594 ^ 1075625116 ^ 1409262126));

      public static string HideCreator => (string) EntitySettings.__Resources.pVKF9ZCXKbdLIfpaKpH8(EntitySettings.__Resources.COqeEUCXqJAlHAV2m3k3(1470440286 ^ 1470136390));

      public static string CanSortProperty => (string) EntitySettings.__Resources.pVKF9ZCXKbdLIfpaKpH8(EntitySettings.__Resources.COqeEUCXqJAlHAV2m3k3(1994213607 >> 4 ^ 124286726));

      public static string SortPropertyUid => EleWise.ELMA.SR.T((string) EntitySettings.__Resources.COqeEUCXqJAlHAV2m3k3(-867826612 ^ -867981322));

      public static string SortPropertyOrder => (string) EntitySettings.__Resources.pVKF9ZCXKbdLIfpaKpH8(EntitySettings.__Resources.COqeEUCXqJAlHAV2m3k3(1149433385 + 173655049 ^ 1322850782));

      public static string IsSortProperty => (string) EntitySettings.__Resources.pVKF9ZCXKbdLIfpaKpH8(EntitySettings.__Resources.COqeEUCXqJAlHAV2m3k3(-1852837372 ^ -1853204976));

      public static string DisplayType => (string) EntitySettings.__Resources.pVKF9ZCXKbdLIfpaKpH8(EntitySettings.__Resources.COqeEUCXqJAlHAV2m3k3(-710283084 ^ -537863435 ^ 173837867));

      public static string MaxCount => (string) EntitySettings.__Resources.pVKF9ZCXKbdLIfpaKpH8(EntitySettings.__Resources.COqeEUCXqJAlHAV2m3k3(372753449 ^ 372400293));

      private static string GetRelationTypeValues()
      {
        int num = 1;
        IEnumerable<string> values;
        while (true)
        {
          switch (num)
          {
            case 1:
              // ISSUE: type reference
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              values = ((EnumMetadata) MetadataLoader.LoadMetadata(EntitySettings.__Resources.KWe0EqCXXSuHsCjPUNeN(__typeref (RelationType)))).Values.Select<EnumValueMetadata, string>((Func<EnumValueMetadata, string>) (v => (string) EntitySettings.__Resources.\u003C\u003Ec.s2A9mbZV7Wbs7YhUPnUj((object) v.Name, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(372753449 ^ 372705167), EntitySettings.__Resources.\u003C\u003Ec.OkqKLUZVA550MvxLLDt8((object) v))));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return string.Join((string) EntitySettings.__Resources.COqeEUCXqJAlHAV2m3k3(333888594 ^ 1075625116 ^ 1408896204), values);
      }

      internal static bool FafHfXCXikgelKvqtuBj() => EntitySettings.__Resources.xuTCyxCXSHiKqZQo7g6P == null;

      internal static EntitySettings.__Resources rtTFbWCXRYMlmPEfsHtV() => (EntitySettings.__Resources) EntitySettings.__Resources.xuTCyxCXSHiKqZQo7g6P;

      internal static object COqeEUCXqJAlHAV2m3k3(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object pVKF9ZCXKbdLIfpaKpH8([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

      internal static Type KWe0EqCXXSuHsCjPUNeN([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);
    }
  }
}
