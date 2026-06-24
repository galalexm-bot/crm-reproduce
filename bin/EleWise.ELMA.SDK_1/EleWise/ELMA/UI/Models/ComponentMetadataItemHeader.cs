// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Models.ComponentMetadataItemHeader
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.UI.Models
{
  /// <summary>Заголовок метаданных компонента</summary>
  [TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>f05ec159-fc12-4496-a21b-a7302e065f69</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
  [DisplayFormat(null)]
  [Entity("ComponentMetadataItemHeader")]
  [IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
  [CustomCode(typeof (ComponentMetadataItemHeader), "EleWise.ELMA.UI.Models.ComponentMetadataItemHeader.CustomCodeTemplate.cs")]
  [MetadataType(typeof (EntityMetadata))]
  [EleWise.ELMA.Model.Attributes.Uid("6ab192a3-f786-42eb-86f2-a09350be1187")]
  [ShowInCatalogList(false)]
  [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Заголовок метаданных компонента')")]
  [Filterable]
  [InterfaceImplementation("EleWise.ELMA.Model.Entities.ISoftDeletable")]
  [FilterType(typeof (ComponentMetadataItemHeaderFilter))]
  public class ComponentMetadataItemHeader : Entity<long>, ISoftDeletable
  {
    /// <summary>Уникальный идентификатор данного класса</summary>
    public const string UID_S = "6ab192a3-f786-42eb-86f2-a09350be1187";
    private static Guid _UID;
    private Guid _uid;
    private string _name;
    private string _displayName;
    private string _description;
    private DateTime _creationDate;
    private long? _creationAuthorId;
    private ComponentMetadataItem _draft;
    private ComponentMetadataItem _published;
    private ComponentMetadataItem _emulation;
    private bool _isDeleted;
    private Guid _moduleUid;
    private Guid _metadataTypeUid;
    private MetadataItemGroupUI _group;
    private bool _isDirtyItem;
    private static ComponentMetadataItemHeader atrV3bBWnFSKA7auiS52;

    public virtual bool HardDelete
    {
      get => this.\u003CHardDelete\u003Ek__BackingField;
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
              this.\u003CHardDelete\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
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

    /// <summary>Создать объект "Заголовок метаданных компонента"</summary>
    public ComponentMetadataItemHeader()
    {
      ComponentMetadataItemHeader.R946grBWe27Nl7vpYlA3();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this._creationDate = ComponentMetadataItemHeader.BI3lhTBWPDO3Ywc8qShP();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            this._metadataTypeUid = new Guid((string) ComponentMetadataItemHeader.LpVr0WBW1QjZ3Y8C0tDt(1461825605 - 1531863589 ^ -70014172));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Уникальный идентификатор данного класса</summary>
    public static Guid UID => ComponentMetadataItemHeader._UID;

    /// <summary>Уникальный идентификатор</summary>
    [EleWise.ELMA.Model.Attributes.Uid("2f7a5990-df88-4ee6-8288-c33da714c9b1")]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Уникальный идентификатор')")]
    [EntityProperty]
    [View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
    [NotNull]
    [SystemProperty]
    [GuidSettings(FieldName = "Uid")]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    public virtual Guid Uid
    {
      get => this._uid;
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
              this._uid = value;
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

    /// <summary>Наименование</summary>
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntityProperty]
    [Filterable]
    [FastSearch(true)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [Order(1)]
    [EleWise.ELMA.Model.Attributes.Uid("69de6a95-a922-4eba-9ca8-b18fc6039174")]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Наименование')")]
    [StringRangeLength(0, "100")]
    [StringSettings(MaxValueString = "100", FieldName = "Name")]
    public virtual string Name
    {
      get => this._name;
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
              this._name = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
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

    /// <summary>Отображаемое имя</summary>
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Отображаемое имя')")]
    [StringRangeLength(0, "100")]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Order(2)]
    [EleWise.ELMA.Model.Attributes.Uid("d80153a7-9817-438e-9548-c2309aff3d4b")]
    [StringSettings(MaxValueString = "100", FieldName = "DisplayName")]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [Filterable]
    [EntityProperty]
    [FastSearch(true)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    public virtual string DisplayName
    {
      get => this._displayName;
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
              this._displayName = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 0;
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

    /// <summary>Описание</summary>
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.Uid("bad448ee-e9ea-4232-81f5-dc4c0836e332")]
    [EntityProperty]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [StringSettings(MaxValueString = "500", FieldName = "Description")]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [Order(3)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Описание')")]
    [StringRangeLength(0, "500")]
    public virtual string Description
    {
      get => this._description;
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
              this._description = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
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

    /// <summary>Дата создания</summary>
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Дата создания')")]
    [RequiredField]
    [PropertyHandler("d0c00d8a-e003-427d-9942-f52cfb77b0f0")]
    [EntityProperty]
    [Filterable]
    [NotNull]
    [Order(4)]
    [EleWise.ELMA.Model.Attributes.Uid("e49118f4-9ded-430a-96b1-92d85d6c88db")]
    [DateTimeSettings(SetCurrentDate = true, FieldName = "CreationDate")]
    [Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
    [Required(true)]
    public virtual DateTime CreationDate
    {
      get => this._creationDate;
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
              this._creationDate = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
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

    /// <summary>Идентификатор автора создания</summary>
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Идентификатор автора создания')")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [Int64Settings(FieldName = "CreationAuthorId")]
    [Order(5)]
    [EleWise.ELMA.Model.Attributes.Uid("5110f473-28f0-4219-a671-ca324b2f5bb9")]
    [Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
    [CanBeNull]
    public virtual long? CreationAuthorId
    {
      get => this._creationAuthorId;
      set => this._creationAuthorId = value;
    }

    /// <summary>Черновик</summary>
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [Order(6)]
    [EleWise.ELMA.Model.Attributes.Uid("24063ecb-b965-4f9f-8706-29f0df2d39e2")]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "ab75cb1d-9214-4646-a9bf-246b85c07226")]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Черновик')")]
    [EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Draft")]
    public virtual ComponentMetadataItem Draft
    {
      get => this._draft;
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
              this._draft = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
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

    /// <summary>Опубликованная версия</summary>
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Опубликованная версия')")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Published")]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [EntityProperty]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "ab75cb1d-9214-4646-a9bf-246b85c07226")]
    [Order(7)]
    [EleWise.ELMA.Model.Attributes.Uid("6c0a6c1e-6170-463d-b481-87904bec5469")]
    public virtual ComponentMetadataItem Published
    {
      get => this._published;
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
              this._published = value;
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

    /// <summary>Версия для эмуляции</summary>
    [EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Emulation")]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "ab75cb1d-9214-4646-a9bf-246b85c07226")]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Версия для эмуляции')")]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Order(8)]
    [EntityProperty]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.Uid("7a51c20a-236c-48fe-aad6-df5985612b61")]
    public virtual ComponentMetadataItem Emulation
    {
      get => this._emulation;
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
              this._emulation = value;
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

    /// <summary>Удален</summary>
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Удален')")]
    [NotNull]
    [Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [BoolSettings(FieldName = "IsDeleted")]
    [EleWise.ELMA.Model.Attributes.Uid("702f178d-f721-46bc-ac6c-2d1f5a5efa6e")]
    [Order(9)]
    public virtual bool IsDeleted
    {
      get => this._isDeleted;
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
              this._isDeleted = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
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

    /// <summary>Уникальный идентификатор модуля</summary>
    [GuidSettings(FieldName = "ModuleUid")]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Уникальный идентификатор модуля')")]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [EntityProperty]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.Uid("b7987e57-1b80-401f-9183-2cd83725fa39")]
    [NotNull]
    [Order(10)]
    public virtual Guid ModuleUid
    {
      get => this._moduleUid;
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
              this._moduleUid = value;
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

    /// <summary>Тип Компонента</summary>
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Тип Компонента')")]
    [RequiredField]
    [Filterable]
    [EntityProperty]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Order(11)]
    [NotNull]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.Uid("425a621b-8867-4f96-97f1-8ed6b77b4868")]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    [GuidSettings(DefaultValueStr = "66457ad6-ce6e-4cd5-ae3a-d46dc83a0e85", FieldName = "MetadataTypeUid")]
    [Required(true)]
    public virtual Guid MetadataTypeUid
    {
      get => this._metadataTypeUid;
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
              this._metadataTypeUid = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
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

    /// <summary>Группа</summary>
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [Order(12)]
    [EleWise.ELMA.Model.Attributes.Uid("dc3f934f-5a4c-4228-8f8e-39681e1cb88d")]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "73efc2ea-167d-45e8-ac21-ed3b77ab9a2b")]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Группа')")]
    [EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Group")]
    public virtual MetadataItemGroupUI Group
    {
      get => this._group;
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
              this._group = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
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

    /// <summary>Есть ли неопубликованные изменения</summary>
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [Order(13)]
    [EleWise.ELMA.Model.Attributes.Uid("3e6ab255-2539-47c8-91b7-63d2e4f637c2")]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [NotNull]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Есть ли неопубликованные изменения')")]
    [BoolSettings(FieldName = "IsDirtyItem")]
    [Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
    public virtual bool IsDirtyItem
    {
      get => this._isDirtyItem;
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
              this._isDirtyItem = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
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

    static ComponentMetadataItemHeader()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ComponentMetadataItemHeader.R946grBWe27Nl7vpYlA3();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            ComponentMetadataItemHeader._UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(87862435 ^ 87837171));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static bool T0SKJkBWO27jvPapmr70() => ComponentMetadataItemHeader.atrV3bBWnFSKA7auiS52 == null;

    internal static ComponentMetadataItemHeader TE0VGvBW2ffTAPgC4HRX() => ComponentMetadataItemHeader.atrV3bBWnFSKA7auiS52;

    internal static void R946grBWe27Nl7vpYlA3() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static DateTime BI3lhTBWPDO3Ywc8qShP() => DateTime.Now;

    internal static object LpVr0WBW1QjZ3Y8C0tDt(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
