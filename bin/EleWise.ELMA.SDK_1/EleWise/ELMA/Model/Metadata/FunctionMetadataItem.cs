// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.FunctionMetadataItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Элемент метаданных функции</summary>
  [TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>4b29c4e1-31b4-45a7-af28-465dc3b3cbd5</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
  [IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
  [Entity("FunctionMetadataItem")]
  [DisplayFormat(null)]
  [EleWise.ELMA.Model.Attributes.Uid("aeb9c260-42c6-45d3-847d-2bd2017b026f")]
  [MetadataType(typeof (EntityMetadata))]
  [DisplayName(typeof (__Resources_FunctionMetadataItem), "DisplayName")]
  [ShowInCatalogList(false)]
  public class FunctionMetadataItem : Entity<long>
  {
    /// <summary>Уникальный идентификатор данного класса</summary>
    public const string UID_S = "aeb9c260-42c6-45d3-847d-2bd2017b026f";
    private static Guid _UID;
    private Guid _uid;
    private FunctionMetadataItemHeader _header;
    private DateTime _creationDate;
    private long? _creationAuthorId;
    private string _comment;
    private object _metadata;
    private ScriptModule _scriptModule;
    private long? _versionNumber;
    private byte[] _assemblyRaw;
    private byte[] _debugRaw;
    private byte[] _documentationRaw;
    private string _assemblyName;
    private string _assemblyVersion;
    internal static FunctionMetadataItem SMRclGbp29yLS0GpHsay;

    /// <summary>Создать объект "Элемент метаданных функции"</summary>
    public FunctionMetadataItem()
    {
      FunctionMetadataItem.Py414rbp1h9F1y8XJDST();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this._creationDate = FunctionMetadataItem.KtZ7tobpNDuQg6r5qYat();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
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
    public static Guid UID => FunctionMetadataItem._UID;

    /// <summary>Уникальный идентификатор</summary>
    [DisplayName(typeof (__Resources_FunctionMetadataItem), "P_Uid_DisplayName")]
    [View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
    [EntityProperty]
    [EleWise.ELMA.Model.Attributes.Uid("28cb7de5-518b-4bef-93c8-ef75f459fb68")]
    [SystemProperty]
    [NotNull]
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

    /// <summary>Заголовок</summary>
    [EleWise.ELMA.Model.Attributes.Uid("765b3673-f9b1-4e1e-8f72-2a28c63ea7e5")]
    [EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Header")]
    [EntityProperty]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Order(3)]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "0997a70d-6b2f-4085-9f50-710b43f65b6c")]
    [DisplayName(typeof (__Resources_FunctionMetadataItem), "P_Header_DisplayName")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    public virtual FunctionMetadataItemHeader Header
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

    /// <summary>Дата создания</summary>
    [EntityProperty]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [Filterable]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [DateTimeSettings(SetCurrentDate = true, FieldName = "CreationDate")]
    [Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
    [PropertyHandler("d0c00d8a-e003-427d-9942-f52cfb77b0f0")]
    [DisplayName(typeof (__Resources_FunctionMetadataItem), "P_CreationDate_DisplayName")]
    [NotNull]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [Order(1)]
    [EleWise.ELMA.Model.Attributes.Uid("038d7dbe-9ba2-45bb-a12a-fafe1853d47d")]
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
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [CanBeNull]
    [Order(2)]
    [EleWise.ELMA.Model.Attributes.Uid("a44bdda6-5d7c-48e7-a76a-b7133f165949")]
    [DisplayName(typeof (__Resources_FunctionMetadataItem), "P_CreationAuthorId_DisplayName")]
    [Int64Settings(FieldName = "CreationAuthorId")]
    [Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
    [EntityProperty]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [Filterable]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    public virtual long? CreationAuthorId
    {
      get => this._creationAuthorId;
      set => this._creationAuthorId = value;
    }

    /// <summary>Комментарий</summary>
    /// <remarks>Комментарий при публикации</remarks>
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [EntityProperty]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [TextSettings(MaxValueString = "1000", FieldName = "Comment")]
    [Property("317e3d72-9c47-4b68-926d-ba77a2579bc2")]
    [EleWise.ELMA.Model.Attributes.Uid("a4c5bf1c-1c0a-4221-8f22-09c93d0bc846")]
    [Description(typeof (__Resources_FunctionMetadataItem), "P_Comment_Description")]
    [DisplayName(typeof (__Resources_FunctionMetadataItem), "P_Comment_DisplayName")]
    [StringRangeLength(0, "1000")]
    [Order(4)]
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

    /// <summary>Метаданные</summary>
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [XmlSerializableObjectSettings(FieldName = "Metadata")]
    [EleWise.ELMA.Model.Attributes.Uid("4ef7f829-406a-4643-8c05-795f8aa62d2a")]
    [Order(5)]
    [Property("66c7898b-e56b-49e0-bfb8-9f9c4a7a0c52")]
    [DisplayName(typeof (__Resources_FunctionMetadataItem), "P_Metadata_DisplayName")]
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

    /// <summary>Модуль сценариев</summary>
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.Uid("09ce0971-4b0b-46c6-9508-c7b556d7984e")]
    [EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "ScriptModule")]
    [DisplayName(typeof (__Resources_FunctionMetadataItem), "P_ScriptModule_DisplayName")]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Order(6)]
    [EntityProperty]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "53eba73b-29a5-4609-9d37-a93e409dc09f")]
    public virtual ScriptModule ScriptModule
    {
      get => this._scriptModule;
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
              this._scriptModule = value;
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

    /// <summary>Номер версии</summary>
    [EntityProperty]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [DisplayName(typeof (__Resources_FunctionMetadataItem), "P_VersionNumber_DisplayName")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Order(7)]
    [EleWise.ELMA.Model.Attributes.Uid("f22b7154-16c9-437a-8d8c-91d8d1f686c5")]
    [Int64Settings(FieldName = "VersionNumber")]
    [Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
    [CanBeNull]
    public virtual long? VersionNumber
    {
      get => this._versionNumber;
      set => this._versionNumber = value;
    }

    /// <summary>Бинарный код сборки</summary>
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [BlobSettings(FieldName = "AssemblyRaw")]
    [DisplayName(typeof (__Resources_FunctionMetadataItem), "P_AssemblyRaw_DisplayName")]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [Order(8)]
    [EntityProperty]
    [EleWise.ELMA.Model.Attributes.Uid("a6e1fdc2-bdbe-496e-8270-015923660a6d")]
    [Property("1911b22d-0ce2-4743-832f-6a44cb0357fe")]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
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

    /// <summary>Отладочная информация</summary>
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [DisplayName(typeof (__Resources_FunctionMetadataItem), "P_DebugRaw_DisplayName")]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntityProperty]
    [EleWise.ELMA.Model.Attributes.Uid("363e1edb-8d47-4a23-b1bd-21087f7198dc")]
    [Order(9)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
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
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [EntityProperty]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [DisplayName(typeof (__Resources_FunctionMetadataItem), "P_DocumentationRaw_DisplayName")]
    [Order(10)]
    [EleWise.ELMA.Model.Attributes.Uid("016e1ab9-f1bf-4dca-b6f1-22c144b79fdd")]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
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
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.Uid("992d9e82-5b3d-4f7d-a827-c97125be2e31")]
    [Order(11)]
    [StringSettings(MaxValueString = "200", FieldName = "AssemblyName")]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [DisplayName(typeof (__Resources_FunctionMetadataItem), "P_AssemblyName_DisplayName")]
    [StringRangeLength(0, "200")]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntityProperty]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
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

    /// <summary>Версия сборки</summary>
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [StringRangeLength(0, "40")]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntityProperty]
    [DisplayName(typeof (__Resources_FunctionMetadataItem), "P_AssemblyVersion_DisplayName")]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [StringSettings(MaxValueString = "40", FieldName = "AssemblyVersion")]
    [Order(12)]
    [EleWise.ELMA.Model.Attributes.Uid("ae8dc598-b684-4dc4-bb1d-b312d23f2cc8")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
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

    static FunctionMetadataItem()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            FunctionMetadataItem.Py414rbp1h9F1y8XJDST();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            FunctionMetadataItem._UID = new Guid((string) FunctionMetadataItem.WPqp2Obp3kZZZEjk6CGE(516838154 ^ 516733146));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static void Py414rbp1h9F1y8XJDST() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static DateTime KtZ7tobpNDuQg6r5qYat() => DateTime.Now;

    internal static bool GQMHQ6bpeyGsPGwU03Ib() => FunctionMetadataItem.SMRclGbp29yLS0GpHsay == null;

    internal static FunctionMetadataItem yUAqacbpPv3CWA5X7VRJ() => FunctionMetadataItem.SMRclGbp29yLS0GpHsay;

    internal static object WPqp2Obp3kZZZEjk6CGE(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
