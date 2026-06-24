// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.DataClassMetadataItemHeader
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
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Заголовок элемента метаданных датакласса</summary>
  [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Заголовок элемента метаданных датакласса')")]
  [EleWise.ELMA.Model.Attributes.Uid("85a8928f-0ee2-48aa-8340-db98eb1011eb")]
  [CustomCode(typeof (DataClassMetadataItemHeader), "EleWise.ELMA.Model.Metadata.DataClassMetadataItemHeader.CustomCodeTemplate.cs")]
  [DisplayFormat(null)]
  [Entity("DataClassMetadataItemHeader")]
  [IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
  [TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>06ab7a23-4831-49a3-a5b5-a51da26cb89d</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
  [TitleProperty("f968532d-e316-4fb9-9bab-8202e5bebd8f")]
  [ShowInCatalogList(false)]
  [MetadataType(typeof (EntityMetadata))]
  [InterfaceImplementation("EleWise.ELMA.Model.Entities.ISoftDeletable")]
  public class DataClassMetadataItemHeader : Entity<long>, ISoftDeletable
  {
    /// <summary>Уникальный идентификатор данного класса</summary>
    public const string UID_S = "85a8928f-0ee2-48aa-8340-db98eb1011eb";
    private static Guid _UID;
    private Guid _uid;
    private string _name;
    private string _displayName;
    private DateTime _creationDate;
    private long? _creationAuthorId;
    private DataClassMetadataItem _draft;
    private DataClassMetadataItem _published;
    private Guid _moduleUid;
    private bool _isDeleted;
    private bool _isDirtyItem;
    private MetadataItemGroupUI _group;
    private static DataClassMetadataItemHeader umQpFobNWqii6RC5SuGM;

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

    /// <summary>
    /// Создать объект "Заголовок элемента метаданных датакласса"
    /// </summary>
    public DataClassMetadataItemHeader()
    {
      DataClassMetadataItemHeader.PJiuTPbNhqOoZhyi4kQF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this._creationDate = DataClassMetadataItemHeader.Ei3d1PbNGmZm4HHnj3T9();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Уникальный идентификатор данного класса</summary>
    public static Guid UID => DataClassMetadataItemHeader._UID;

    /// <summary>Уникальный идентификатор</summary>
    [NotNull]
    [EleWise.ELMA.Model.Attributes.Uid("876e0716-0aa2-4447-9da7-2a074219078a")]
    [EntityProperty]
    [SystemProperty]
    [GuidSettings(FieldName = "Uid")]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
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
    [StringRangeLength(0, "100")]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Наименование')")]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [StringSettings(MaxValueString = "100", FieldName = "Name")]
    [Filterable]
    [FastSearch(true)]
    [EleWise.ELMA.Model.Attributes.Uid("f968532d-e316-4fb9-9bab-8202e5bebd8f")]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [Order(1)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
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

    /// <summary>Отображаемое имя</summary>
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntityProperty]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Отображаемое имя')")]
    [StringRangeLength(0, "100")]
    [Order(2)]
    [StringSettings(MaxValueString = "100", FieldName = "DisplayName")]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [EleWise.ELMA.Model.Attributes.Uid("b5762fe4-fd52-43a4-9d70-987e2b372259")]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
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
    [Order(3)]
    [NotNull]
    [EleWise.ELMA.Model.Attributes.Uid("9f60e2e8-c940-4e4b-9742-a3892823d36d")]
    [Filterable]
    [Required(true)]
    [EntityProperty]
    [DateTimeSettings(SetCurrentDate = true, FieldName = "CreationDate")]
    [Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
    [PropertyHandler("d0c00d8a-e003-427d-9942-f52cfb77b0f0")]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Дата создания')")]
    [RequiredField]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
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
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Идентификатор автора создания')")]
    [CanBeNull]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.Uid("be8b4235-828e-4f1d-a85f-7612082ab5e2")]
    [Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
    [Order(4)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [EntityProperty]
    [Int64Settings(FieldName = "CreationAuthorId")]
    public virtual long? CreationAuthorId
    {
      get => this._creationAuthorId;
      set => this._creationAuthorId = value;
    }

    /// <summary>Черновик</summary>
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Черновик')")]
    [EntityProperty]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [EleWise.ELMA.Model.Attributes.Uid("72c61acf-c559-48fb-acc2-e5fa581e26ee")]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Order(5)]
    [EntitySettings(FieldName = "Draft")]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "28d9194c-c187-4cd3-acae-36644c0cbbb5")]
    public virtual DataClassMetadataItem Draft
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
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
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Order(6)]
    [EleWise.ELMA.Model.Attributes.Uid("0c45128c-f588-4660-af21-8b19a7f6f732")]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "28d9194c-c187-4cd3-acae-36644c0cbbb5")]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Опубликованная версия')")]
    [EntitySettings(FieldName = "Published")]
    public virtual DataClassMetadataItem Published
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
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
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Уникальный идентификатор модуля')")]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [EntityProperty]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.Uid("f654a04f-c686-4122-8741-5440da334d76")]
    [NotNull]
    [Order(7)]
    [GuidSettings(FieldName = "ModuleUid")]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
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

    /// <summary>Удален</summary>
    [Order(8)]
    [BoolSettings(FieldName = "IsDeleted")]
    [Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
    [NotNull]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Удален')")]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.Uid("dd499eab-4cab-483e-ba4f-203ae68cec6d")]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
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
    [EleWise.ELMA.Model.Attributes.Uid("bf9341ed-5e9e-49a2-af4a-833cced9c047")]
    [Order(9)]
    [BoolSettings(FieldName = "IsDirtyItem")]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [EntityProperty]
    [Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [NotNull]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Есть неопубликованные изменения')")]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
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

    /// <summary>Группа</summary>
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "73efc2ea-167d-45e8-ac21-ed3b77ab9a2b")]
    [Order(10)]
    [EleWise.ELMA.Model.Attributes.Uid("a6dd2738-8966-4ff5-b2c4-3de5fe6005de")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 0 : 0;
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

    public override string ToString() => (string) DataClassMetadataItemHeader.oXYQQsbNEAW5uOlyHhNy((object) this);

    static DataClassMetadataItemHeader()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            DataClassMetadataItemHeader.PJiuTPbNhqOoZhyi4kQF();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            DataClassMetadataItemHeader._UID = new Guid((string) DataClassMetadataItemHeader.LAg7RobNftEuCuXEADkC(277947046 - -1479185048 ^ 1756975906));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static bool qaxRlEbNoUqNPmokw3SJ() => DataClassMetadataItemHeader.umQpFobNWqii6RC5SuGM == null;

    internal static DataClassMetadataItemHeader ubbPdPbNbX8ReNLNrgcY() => DataClassMetadataItemHeader.umQpFobNWqii6RC5SuGM;

    internal static void PJiuTPbNhqOoZhyi4kQF() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static DateTime Ei3d1PbNGmZm4HHnj3T9() => DateTime.Now;

    internal static object oXYQQsbNEAW5uOlyHhNy([In] object obj0) => (object) ((DataClassMetadataItemHeader) obj0).Name;

    internal static object LAg7RobNftEuCuXEADkC(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
