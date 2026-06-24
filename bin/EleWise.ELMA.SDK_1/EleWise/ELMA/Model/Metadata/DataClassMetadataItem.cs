// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.DataClassMetadataItem
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
  /// <summary>Элемент метаданных датакласса</summary>
  [EleWise.ELMA.Model.Attributes.Uid("28d9194c-c187-4cd3-acae-36644c0cbbb5")]
  [DisplayName(typeof (__Resources_DataClassMetadataItem), "DisplayName")]
  [MetadataType(typeof (EntityMetadata))]
  [IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
  [ShowInCatalogList(false)]
  [DisplayFormat(null)]
  [Filterable]
  [FilterType(typeof (DataClassMetadataItemFilter))]
  [TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>ffaf2bb7-5f3a-4e1c-a26e-6ae3c3ed2d87</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
  [Entity("DataClassMetadataItem")]
  public class DataClassMetadataItem : Entity<long>
  {
    /// <summary>Уникальный идентификатор данного класса</summary>
    public const string UID_S = "28d9194c-c187-4cd3-acae-36644c0cbbb5";
    private static Guid _UID;
    private Guid _uid;
    private DateTime _creationDate;
    private long? _creationAuthorId;
    private object _metadata;
    private DataClassMetadataItemHeader _header;
    private string _comment;
    private byte[] _assemblyRaw;
    private byte[] _debugRaw;
    private byte[] _documentationRaw;
    private string _assemblyName;
    private string _assemblyVersion;
    private byte[] _clientAssemblyRaw;
    private long? _versionNumber;
    private static DataClassMetadataItem utNACpb3jWhhXfiY1PYu;

    /// <summary>Создать объект "Элемент метаданных датакласса"</summary>
    public DataClassMetadataItem()
    {
      DataClassMetadataItem.CpymDkb3UROeZXBKwfKm();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this._creationDate = DataClassMetadataItem.XOSFRob3s4mhjFHFt2je();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Уникальный идентификатор данного класса</summary>
    public static Guid UID => DataClassMetadataItem._UID;

    /// <summary>Уникальный идентификатор</summary>
    [NotNull]
    [SystemProperty]
    [EntityProperty]
    [EleWise.ELMA.Model.Attributes.Uid("8e58e7b1-d578-4965-8c8f-e75638dbff14")]
    [View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
    [DisplayName(typeof (__Resources_DataClassMetadataItem), "P_Uid_DisplayName")]
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

    /// <summary>Дата создания</summary>
    [Required(true)]
    [Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
    [NotNull]
    [EleWise.ELMA.Model.Attributes.Uid("4c3339a7-93e5-4862-a1b5-2e0ac63cc3e3")]
    [Order(1)]
    [DisplayName(typeof (__Resources_DataClassMetadataItem), "P_CreationDate_DisplayName")]
    [DateTimeSettings(SetCurrentDate = true, FieldName = "CreationDate")]
    [RequiredField]
    [EntityProperty]
    [PropertyHandler("d0c00d8a-e003-427d-9942-f52cfb77b0f0")]
    [Filterable]
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

    /// <summary>Идентификатор автора создания</summary>
    [EntityProperty]
    [CanBeNull]
    [EleWise.ELMA.Model.Attributes.Uid("9d566e43-feb2-482b-b8c1-0eea00e189ee")]
    [DisplayName(typeof (__Resources_DataClassMetadataItem), "P_CreationAuthorId_DisplayName")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
    [Int64Settings(FieldName = "CreationAuthorId")]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Order(2)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    public virtual long? CreationAuthorId
    {
      get => this._creationAuthorId;
      set => this._creationAuthorId = value;
    }

    /// <summary>Метаданные</summary>
    /// <remarks>Сериализованные метаданные</remarks>
    [Description(typeof (__Resources_DataClassMetadataItem), "P_Metadata_Description")]
    [DisplayName(typeof (__Resources_DataClassMetadataItem), "P_Metadata_DisplayName")]
    [EntityProperty]
    [Order(3)]
    [EleWise.ELMA.Model.Attributes.Uid("8946cae6-a5c2-4a01-a077-7cc31e27b13b")]
    [Property("66c7898b-e56b-49e0-bfb8-9f9c4a7a0c52")]
    [XmlSerializableObjectSettings(FieldName = "Metadata")]
    public virtual object Metadata
    {
      get => this._metadata;
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
              this._metadata = value;
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

    /// <summary>Заголовок</summary>
    [EleWise.ELMA.Model.Attributes.Uid("141cf1a3-da06-4cae-b4b8-9c8db42b77a4")]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "85a8928f-0ee2-48aa-8340-db98eb1011eb")]
    [Order(4)]
    [EntitySettings(CascadeMode = CascadeMode.All, FieldName = "Header")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [DisplayName(typeof (__Resources_DataClassMetadataItem), "P_Header_DisplayName")]
    public virtual DataClassMetadataItemHeader Header
    {
      get => this._header;
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
              this._header = value;
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

    /// <summary>Комментарий</summary>
    /// <remarks>Комментарий к опубликованной версии</remarks>
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [Description(typeof (__Resources_DataClassMetadataItem), "P_Comment_Description")]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [Order(5)]
    [EleWise.ELMA.Model.Attributes.Uid("cfd79856-a75d-4bd3-807d-769b1fdbf445")]
    [DisplayName(typeof (__Resources_DataClassMetadataItem), "P_Comment_DisplayName")]
    [StringRangeLength(0, "1000")]
    [StringSettings(MaxValueString = "1000", MultiLine = true, FieldName = "Comment")]
    public virtual string Comment
    {
      get => this._comment;
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
              this._comment = value;
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

    /// <summary>Бинарный код сборки</summary>
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Property("1911b22d-0ce2-4743-832f-6a44cb0357fe")]
    [Order(6)]
    [EleWise.ELMA.Model.Attributes.Uid("775a2d41-b821-4ada-afa1-c23db2d80c84")]
    [BlobSettings(FieldName = "AssemblyRaw")]
    [DisplayName(typeof (__Resources_DataClassMetadataItem), "P_AssemblyRaw_DisplayName")]
    public virtual byte[] AssemblyRaw
    {
      get => this._assemblyRaw;
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
              this._assemblyRaw = value;
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

    /// <summary>Отладочная информация</summary>
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [DisplayName(typeof (__Resources_DataClassMetadataItem), "P_DebugRaw_DisplayName")]
    [Order(7)]
    [EleWise.ELMA.Model.Attributes.Uid("6a6e3177-550d-479a-aa27-ffb173dac160")]
    [BlobSettings(FieldName = "DebugRaw")]
    [Property("1911b22d-0ce2-4743-832f-6a44cb0357fe")]
    public virtual byte[] DebugRaw
    {
      get => this._debugRaw;
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
              this._debugRaw = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 0 : 0;
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

    /// <summary>Документация</summary>
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [DisplayName(typeof (__Resources_DataClassMetadataItem), "P_DocumentationRaw_DisplayName")]
    [Order(8)]
    [EleWise.ELMA.Model.Attributes.Uid("1637827a-1e94-48f2-a4c7-ef69aa519182")]
    [BlobSettings(FieldName = "DocumentationRaw")]
    [Property("1911b22d-0ce2-4743-832f-6a44cb0357fe")]
    public virtual byte[] DocumentationRaw
    {
      get => this._documentationRaw;
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
              this._documentationRaw = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 0;
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

    /// <summary>Имя сборки</summary>
    [DisplayName(typeof (__Resources_DataClassMetadataItem), "P_AssemblyName_DisplayName")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [StringRangeLength(0, "200")]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [StringSettings(MaxValueString = "200", FieldName = "AssemblyName")]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [FastSearch(true)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [EntityProperty]
    [Order(10)]
    [Filterable]
    [EleWise.ELMA.Model.Attributes.Uid("5b91ca93-8145-437e-84d2-d7d2e90b28c8")]
    public virtual string AssemblyName
    {
      get => this._assemblyName;
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
              this._assemblyName = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
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

    /// <summary>Версия сборки</summary>
    [EleWise.ELMA.Model.Attributes.Uid("50771a21-c114-4399-8f28-4736f711dba2")]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [FastSearch(true)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [EntityProperty]
    [Filterable]
    [Order(11)]
    [StringSettings(MaxValueString = "40", FieldName = "AssemblyVersion")]
    [DisplayName(typeof (__Resources_DataClassMetadataItem), "P_AssemblyVersion_DisplayName")]
    [StringRangeLength(0, "40")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    public virtual string AssemblyVersion
    {
      get => this._assemblyVersion;
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
              this._assemblyVersion = value;
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

    /// <summary>Клиентская сборка для билда и автокомплита</summary>
    [EleWise.ELMA.Model.Attributes.Uid("6175a85f-6e3b-482c-8ca6-fbee8d3b827a")]
    [Order(9)]
    [Property("1911b22d-0ce2-4743-832f-6a44cb0357fe")]
    [EntityProperty]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [BlobSettings(FieldName = "ClientAssemblyRaw")]
    [DisplayName(typeof (__Resources_DataClassMetadataItem), "P_ClientAssemblyRaw_DisplayName")]
    public virtual byte[] ClientAssemblyRaw
    {
      get => this._clientAssemblyRaw;
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
              this._clientAssemblyRaw = value;
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

    /// <summary>Номер версии</summary>
    [EleWise.ELMA.Model.Attributes.Uid("e0014785-70c4-4364-b65e-4a6bb0e5afb5")]
    [CanBeNull]
    [Order(12)]
    [EntityProperty]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
    [Int64Settings(FieldName = "VersionNumber")]
    [DisplayName(typeof (__Resources_DataClassMetadataItem), "P_VersionNumber_DisplayName")]
    public virtual long? VersionNumber
    {
      get => this._versionNumber;
      set => this._versionNumber = value;
    }

    static DataClassMetadataItem()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            DataClassMetadataItem._UID = new Guid((string) DataClassMetadataItem.Q1M8WPb3cDf9j9B4xJGj(572119659 - -337058038 ^ 909253325));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    internal static void CpymDkb3UROeZXBKwfKm() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static DateTime XOSFRob3s4mhjFHFt2je() => DateTime.Now;

    internal static bool O0MU58b3Y3q43FWdHcJl() => DataClassMetadataItem.utNACpb3jWhhXfiY1PYu == null;

    internal static DataClassMetadataItem IRI67tb3L3RUAlcsq8qb() => DataClassMetadataItem.utNACpb3jWhhXfiY1PYu;

    internal static object Q1M8WPb3cDf9j9B4xJGj(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
