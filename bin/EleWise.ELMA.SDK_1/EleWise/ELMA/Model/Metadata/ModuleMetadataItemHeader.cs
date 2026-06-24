// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.ModuleMetadataItemHeader
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
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Model.Metadata
{
  [TitleProperty("45ad4dc9-7401-4a57-8a8d-0c55759df61c")]
  [InterfaceImplementation("EleWise.ELMA.Model.Entities.ISoftDeletable")]
  [CustomCode(typeof (ModuleMetadataItemHeader), "EleWise.ELMA.Model.Metadata.ModuleMetadataItemHeader.CustomCodeTemplate.cs")]
  [EleWise.ELMA.Model.Attributes.Uid("58dcab94-c60f-491c-8b91-5275e5576ad1")]
  [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Заголовок метаданных модуля')")]
  [DisplayFormat(null)]
  [IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
  [ShowInCatalogList(false)]
  [MetadataType(typeof (EntityMetadata))]
  [TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>018d9e87-6901-4f74-8d39-4fa99af52a3d</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
  [Entity("ModuleMetadataItemHeader")]
  public class ModuleMetadataItemHeader : Entity<long>, ISoftDeletable
  {
    /// <summary>Уникальный идентификатор данного класса</summary>
    public const string UID_S = "58dcab94-c60f-491c-8b91-5275e5576ad1";
    internal static Guid _UID;
    private Guid _uid;
    private string _name;
    private DateTime _creationDate;
    private string _displayName;
    private long? _creationAuthorId;
    private string _description;
    private bool _isDeleted;
    private ModuleMetadataItem _published;
    private ModuleMetadataItem _draft;
    internal static ModuleMetadataItemHeader A4hWBLbN7dmX8XmAyxsU;

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

    /// <summary>Создать объект "Заголовок метаданных модуля"</summary>
    public ModuleMetadataItemHeader()
    {
      ModuleMetadataItemHeader.l5NtSWbNmR9HowmFQij8();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this._creationDate = DateTime.Now;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Уникальный идентификатор данного класса</summary>
    public static Guid UID => ModuleMetadataItemHeader._UID;

    /// <summary>UID</summary>
    [SystemProperty]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    [NotNull]
    [EleWise.ELMA.Model.Attributes.Uid("4ab139a2-991d-4ef3-bf27-4a4e5a139fe2")]
    [GuidSettings(FieldName = "Uid")]
    [EntityProperty]
    [View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('UID')")]
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

    /// <summary>Наименование</summary>
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [FastSearch(true)]
    [EntityProperty]
    [Filterable]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [StringSettings(MaxValueString = "512", FieldName = "Name")]
    [Required(true)]
    [EleWise.ELMA.Model.Attributes.Uid("45ad4dc9-7401-4a57-8a8d-0c55759df61c")]
    [Order(1)]
    [RequiredField]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Наименование')")]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [StringRangeLength(0, "512")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
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
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [PropertyHandler("d0c00d8a-e003-427d-9942-f52cfb77b0f0")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Filterable]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [EntityProperty]
    [EleWise.ELMA.Model.Attributes.Uid("9f3eff0e-c8ff-4aa6-835c-daca21d91040")]
    [NotNull]
    [Order(4)]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Дата создания')")]
    [Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
    [DateTimeSettings(SetCurrentDate = true, FieldName = "CreationDate")]
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

    /// <summary>Отображаемое имя</summary>
    [Order(2)]
    [EleWise.ELMA.Model.Attributes.Uid("e2036e69-87d7-4ad8-881d-21d16883c424")]
    [EntityProperty]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [StringSettings(FieldName = "DisplayName")]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Отображаемое имя')")]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 0;
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
    [Int64Settings(FieldName = "CreationAuthorId")]
    [EleWise.ELMA.Model.Attributes.Uid("dc33ae3b-f44e-4d01-8f7e-7562ed2ad914")]
    [EntityProperty]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Идентификатор автора создания')")]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [CanBeNull]
    [Order(5)]
    public virtual long? CreationAuthorId
    {
      get => this._creationAuthorId;
      set => this._creationAuthorId = value;
    }

    /// <summary>Описание</summary>
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.Uid("03edae85-8e71-46a1-bf8c-a4775755952d")]
    [EntityProperty]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Описание')")]
    [StringSettings(FieldName = "Description")]
    [Order(3)]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
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
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntityProperty]
    [BoolSettings(FieldName = "IsDeleted")]
    [Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Удален')")]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [NotNull]
    [Order(8)]
    [EleWise.ELMA.Model.Attributes.Uid("e5e95598-d738-42da-b25f-a0eb059484b8")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
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

    /// <summary>Опубликованная версия</summary>
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "13937373-6487-40c1-ae91-ecbbf0706ce9")]
    [Order(7)]
    [EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Published")]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.Uid("7c190302-c237-4350-a170-278fefe5ec12")]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Опубликованная версия')")]
    [EntityProperty]
    public virtual ModuleMetadataItem Published
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
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
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Черновик')")]
    [EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Draft")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.Uid("8019f9c4-5497-401d-a10c-c296a69204ce")]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "13937373-6487-40c1-ae91-ecbbf0706ce9")]
    [Order(6)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    public virtual ModuleMetadataItem Draft
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

    public override string ToString() => this.Name;

    static ModuleMetadataItemHeader()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ModuleMetadataItemHeader._UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824461527));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
            continue;
          case 2:
            ModuleMetadataItemHeader.l5NtSWbNmR9HowmFQij8();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool GmF8G2bNxY1uHMlodEK5() => ModuleMetadataItemHeader.A4hWBLbN7dmX8XmAyxsU == null;

    internal static ModuleMetadataItemHeader vpjX2dbN0PCGWPpFyDZB() => ModuleMetadataItemHeader.A4hWBLbN7dmX8XmAyxsU;

    internal static void l5NtSWbNmR9HowmFQij8() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
