// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.FunctionMetadataItemHeader
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Заголовок метаданных функции</summary>
  [ShowInCatalogList(false)]
  [FilterType(typeof (FunctionMetadataItemHeaderFilter))]
  [Filterable]
  [CustomCode(typeof (FunctionMetadataItemHeader), "EleWise.ELMA.Model.Metadata.FunctionMetadataItemHeader.CustomCodeTemplate.cs")]
  [InterfaceImplementation("EleWise.ELMA.Model.Entities.ISoftDeletable")]
  [Entity("FunctionMetadataItemHeader")]
  [TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>b73a460e-ac4b-4a30-9cf7-f866773c24e2</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
  [DisplayFormat(null)]
  [EleWise.ELMA.Model.Attributes.Uid("0997a70d-6b2f-4085-9f50-710b43f65b6c")]
  [MetadataType(typeof (EntityMetadata))]
  [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Заголовок метаданных функции')")]
  [IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
  public class FunctionMetadataItemHeader : Entity<long>, ISoftDeletable
  {
    /// <summary>Уникальный идентификатор данного класса</summary>
    public const string UID_S = "0997a70d-6b2f-4085-9f50-710b43f65b6c";
    private static Guid _UID;
    private Guid _uid;
    private string _name;
    private DateTime _creationDate;
    private long? _creationAuthorId;
    private string _displayName;
    private string _description;
    private FunctionMetadataItem _draft;
    private FunctionMetadataItem _published;
    private bool _isDeleted;
    private Guid _moduleUid;
    private bool _isDirtyItem;
    private MetadataItemGroupUI _group;
    internal static FunctionMetadataItemHeader WMJoHKbNSETTh10oYopR;

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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
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

    /// <summary>Создать объект "Заголовок метаданных функции"</summary>
    public FunctionMetadataItemHeader()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this._creationDate = DateTime.Now;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Уникальный идентификатор данного класса</summary>
    public static Guid UID => FunctionMetadataItemHeader._UID;

    /// <summary>Уникальный идентификатор</summary>
    [GuidSettings(FieldName = "Uid")]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    [EleWise.ELMA.Model.Attributes.Uid("258faf62-1f47-49c7-9665-4a13b1c01376")]
    [SystemProperty]
    [NotNull]
    [EntityProperty]
    [View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Уникальный идентификатор')")]
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
    [StringSettings(MaxValueString = "100", FieldName = "Name")]
    [StringRangeLength(0, "100")]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [Order(1)]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Наименование')")]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [FastSearch(true)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntityProperty]
    [Filterable]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.Uid("b07fc995-c7ba-4c04-aeeb-ba9a8ff23db7")]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
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
    [Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Дата создания')")]
    [Filterable]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [Order(4)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [NotNull]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [PropertyHandler("d0c00d8a-e003-427d-9942-f52cfb77b0f0")]
    [EntityProperty]
    [DateTimeSettings(SetCurrentDate = true, FieldName = "CreationDate")]
    [EleWise.ELMA.Model.Attributes.Uid("0261b28a-56c5-4aeb-ad0f-08fe82311eac")]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 0;
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
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [CanBeNull]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Идентификатор автора создания')")]
    [Int64Settings(FieldName = "CreationAuthor")]
    [Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [Order(5)]
    [EleWise.ELMA.Model.Attributes.Uid("d88e2112-10ab-4649-b53d-dc74a6f59258")]
    public virtual long? CreationAuthorId
    {
      get => this._creationAuthorId;
      set => this._creationAuthorId = value;
    }

    /// <summary>Отображаемое имя</summary>
    [StringRangeLength(0, "100")]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Отображаемое имя')")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [StringSettings(MaxValueString = "100", FieldName = "DisplayName")]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [Order(2)]
    [Filterable]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [FastSearch(true)]
    [EleWise.ELMA.Model.Attributes.Uid("b6c134ab-12ff-45d8-98ea-4b1c774fd327")]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
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
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Описание')")]
    [EntityProperty]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [Order(3)]
    [EleWise.ELMA.Model.Attributes.Uid("d9375aa8-785e-41a1-a4f2-3954e9a32257")]
    [StringRangeLength(0, "500")]
    [StringSettings(MaxValueString = "500", FieldName = "Description")]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
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

    /// <summary>Черновик</summary>
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Черновик')")]
    [EleWise.ELMA.Model.Attributes.Uid("29c1d139-e6c3-4f5c-b316-f20c1dd262d8")]
    [EntityProperty]
    [Order(6)]
    [EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Draft")]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "aeb9c260-42c6-45d3-847d-2bd2017b026f")]
    public virtual FunctionMetadataItem Draft
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
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
    [EntityProperty]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [Order(7)]
    [EleWise.ELMA.Model.Attributes.Uid("ba4a08a6-c893-4131-9bdb-46fcabdf2de2")]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "aeb9c260-42c6-45d3-847d-2bd2017b026f")]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Опубликованная версия')")]
    [EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Published")]
    public virtual FunctionMetadataItem Published
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

    /// <summary>Удалён</summary>
    [EntityProperty]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Удалён')")]
    [EleWise.ELMA.Model.Attributes.Uid("e99ef48b-70ef-42f2-9c2f-90a34302d809")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [BoolSettings(FieldName = "IsDeleted")]
    [Order(8)]
    [NotNull]
    [Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
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

    /// <summary>Уникальный идентификатор модуля</summary>
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [EntityProperty]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    [EleWise.ELMA.Model.Attributes.Uid("e13b9259-0520-44c0-83a3-9d748fd57108")]
    [Order(9)]
    [NotNull]
    [GuidSettings(FieldName = "ModuleUid")]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Уникальный идентификатор модуля')")]
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

    /// <summary>Есть неопубликованные изменения</summary>
    [EntityProperty]
    [NotNull]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [BoolSettings(FieldName = "IsDirtyItem")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Есть неопубликованные изменения')")]
    [Order(10)]
    [EleWise.ELMA.Model.Attributes.Uid("b3b0b91a-f98f-4e8f-a3af-6a6a78c1de43")]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 0 : 0;
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
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [Order(11)]
    [EleWise.ELMA.Model.Attributes.Uid("e6e21cea-a45c-4d4b-877b-3038b1d85443")]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "73efc2ea-167d-45e8-ac21-ed3b77ab9a2b")]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntityProperty]
    [EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Group")]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Группа')")]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 0 : 0;
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

    static FunctionMetadataItemHeader()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            FunctionMetadataItemHeader._UID = new Guid((string) FunctionMetadataItemHeader.ojBuylbNKwBaEumqIIov(-2112703338 ^ -2112859394));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
            continue;
          case 2:
            FunctionMetadataItemHeader.yFfY0ZbNqZ32JMxtjHvY();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool AmyVmibNi2oDLqVaaleK() => FunctionMetadataItemHeader.WMJoHKbNSETTh10oYopR == null;

    internal static FunctionMetadataItemHeader ch0h9JbNRoyJJDLdLffZ() => FunctionMetadataItemHeader.WMJoHKbNSETTh10oYopR;

    internal static void yFfY0ZbNqZ32JMxtjHvY() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object ojBuylbNKwBaEumqIIov(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
