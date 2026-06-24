// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Models.ComponentMetadataItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.UI.Models
{
  /// <summary>Элемент метаданных компонента</summary>
  [DisplayFormat(null)]
  [DisplayName("SR.M('Элемент метаданных компонента')")]
  [EleWise.ELMA.Model.Attributes.Uid("ab75cb1d-9214-4646-a9bf-246b85c07226")]
  [TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>4df11525-9310-4e80-b3a9-8e6e78a940fa</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
  [ShowInCatalogList(false)]
  [IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
  [Entity("ComponentMetadataItem")]
  [MetadataType(typeof (EntityMetadata))]
  [ActionsType(typeof (ComponentMetadataItemActions))]
  public class ComponentMetadataItem : Entity<long>
  {
    /// <summary>Уникальный идентификатор данного класса</summary>
    public const string UID_S = "ab75cb1d-9214-4646-a9bf-246b85c07226";
    private static Guid _UID;
    private Guid _uid;
    private DateTime _creationDate;
    private long? _creationAuthorId;
    private object _metadata;
    private ComponentMetadataItemHeader _header;
    private string _comment;
    private ScriptModule _scriptModule;
    private long? _versionNumber;
    private string _assemblyName;
    private bool _isEmulation;
    private ScriptModule _clientScriptModule;
    private bool _isWork;
    private ScriptModule _testScriptModule;
    private string _assemblyVersion;
    private object _signature;
    private ScriptModule _viewScriptModule;
    internal static ComponentMetadataItem cs5n7GBoBSS4ke72mGjQ;

    /// <summary>Создать объект "Элемент метаданных компонента"</summary>
    public ComponentMetadataItem()
    {
      ComponentMetadataItem.FmbH9qBobLQpZGbRZR5k();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this._isWork = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 1 : 2;
            continue;
          case 2:
            goto label_3;
          default:
            this._creationDate = ComponentMetadataItem.CP00nGBoh5BkyKHS6OeR();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Уникальный идентификатор данного класса</summary>
    public static Guid UID => ComponentMetadataItem._UID;

    /// <summary>Уникальный идентификатор</summary>
    [NotNull]
    [SystemProperty]
    [View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
    [EleWise.ELMA.Model.Attributes.Uid("37278917-2fe6-4062-8f08-97b3656aced5")]
    [DisplayName("SR.M('Уникальный идентификатор')")]
    [EntityProperty]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    [GuidSettings(FieldName = "Uid")]
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

    /// <summary>Дата создания</summary>
    [EleWise.ELMA.Model.Attributes.Uid("3953c435-7f83-416d-b6d4-f52a9f9fa779")]
    [Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
    [EntityProperty]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [PropertyHandler("d0c00d8a-e003-427d-9942-f52cfb77b0f0")]
    [DateTimeSettings(SetCurrentDate = true, FieldName = "CreationDate")]
    [DisplayName("SR.M('Дата создания')")]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Order(1)]
    [NotNull]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
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

    /// <summary>Идентификатор автора создания</summary>
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [EntityProperty]
    [Order(2)]
    [Int64Settings(FieldName = "CreationAuthorId")]
    [Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
    [CanBeNull]
    [DisplayName("SR.M('Идентификатор автора создания')")]
    [EleWise.ELMA.Model.Attributes.Uid("3c9fc402-9cfb-4f1a-b1c6-8455e37c6307")]
    public virtual long? CreationAuthorId
    {
      get => this._creationAuthorId;
      set => this._creationAuthorId = value;
    }

    /// <summary>Метаданные</summary>
    [Order(3)]
    [EleWise.ELMA.Model.Attributes.Uid("85b34da2-8433-4b67-8525-99d39bd19151")]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [DisplayName("SR.M('Метаданные')")]
    [Property("66c7898b-e56b-49e0-bfb8-9f9c4a7a0c52")]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [XmlSerializableObjectSettings(FieldName = "Metadata")]
    [EntityProperty]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
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
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntityProperty]
    [EleWise.ELMA.Model.Attributes.Uid("b2f927e0-c5a6-4792-aa1c-66c71d845dcf")]
    [EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Header")]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "6ab192a3-f786-42eb-86f2-a09350be1187")]
    [Order(4)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [DisplayName("SR.M('Заголовок')")]
    public virtual ComponentMetadataItemHeader Header
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
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
    [TextSettings(MaxValueString = "1000", FieldName = "Comment")]
    [StringRangeLength(0, "1000")]
    [Property("317e3d72-9c47-4b68-926d-ba77a2579bc2")]
    [EleWise.ELMA.Model.Attributes.Uid("462c6854-a7eb-4b7b-bc53-3ab72e325e5f")]
    [Order(5)]
    [DisplayName("SR.M('Комментарий')")]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 0;
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
    [EleWise.ELMA.Model.Attributes.Uid("ac6383b9-38a0-46ba-a79f-2950966f06b7")]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [DisplayName("SR.M('Модуль сценариев')")]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "ScriptModule")]
    [Order(9)]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "53eba73b-29a5-4609-9d37-a93e409dc09f")]
    [EntityProperty]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
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
    [Order(6)]
    [EleWise.ELMA.Model.Attributes.Uid("508f8f7f-f2b7-45e0-8e48-18aca53ea122")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
    [Int64Settings(FieldName = "VersionNumber")]
    [DisplayName("SR.M('Номер версии')")]
    [CanBeNull]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    public virtual long? VersionNumber
    {
      get => this._versionNumber;
      set => this._versionNumber = value;
    }

    /// <summary>Имя сборки</summary>
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [EleWise.ELMA.Model.Attributes.Uid("5dc88952-f319-4725-9bfe-b90a59603887")]
    [Order(13)]
    [StringSettings(MaxValueString = "200", FieldName = "AssemblyName")]
    [StringRangeLength(0, "200")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntityProperty]
    [DisplayName("SR.M('Имя сборки')")]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
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

    /// <summary>Является версией для эмуляции</summary>
    [NotNull]
    [Order(7)]
    [EleWise.ELMA.Model.Attributes.Uid("f1cb0a48-8888-41d8-ae36-1a7d6bca126a")]
    [Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [DisplayName("SR.M('Является версией для эмуляции')")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntityProperty]
    [BoolSettings(FieldName = "IsEmulation")]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    public virtual bool IsEmulation
    {
      get => this._isEmulation;
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
              this._isEmulation = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 0;
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

    /// <summary>Клиентский модуль сценариев</summary>
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "53eba73b-29a5-4609-9d37-a93e409dc09f")]
    [EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "ClientScriptModule")]
    [Order(10)]
    [EntityProperty]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.Uid("e0777c1a-a338-425e-9a38-8be31c8ffbf5")]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [DisplayName("SR.M('Клиентский модуль сценариев')")]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    public virtual ScriptModule ClientScriptModule
    {
      get => this._clientScriptModule;
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
              this._clientScriptModule = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
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

    /// <summary>Работает ли версия</summary>
    [Order(8)]
    [NotNull]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.Uid("e20bed2e-c780-4cce-a1b9-6c7d93d73251")]
    [Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [DisplayName("SR.M('Работает ли версия')")]
    [BoolSettings(DefaultValueStr = "True", DisplayType = BoolDisplayType.Checkbox, FieldName = "IsWork")]
    public virtual bool IsWork
    {
      get => this._isWork;
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
              this._isWork = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 0;
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

    /// <summary>Модуль тестовых сценариев</summary>
    [EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "TestScriptModule")]
    [DisplayName("SR.M('Модуль тестовых сценариев')")]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "53eba73b-29a5-4609-9d37-a93e409dc09f")]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [Order(12)]
    [EleWise.ELMA.Model.Attributes.Uid("28f14c14-7544-4df3-b23d-9443f62d6618")]
    [EntityProperty]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    public virtual ScriptModule TestScriptModule
    {
      get => this._testScriptModule;
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
              this._testScriptModule = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
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
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [StringSettings(MaxValueString = "40", FieldName = "AssemblyVersion")]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [DisplayName("SR.M('Версия сборки')")]
    [StringRangeLength(0, "40")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [EntityProperty]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.Uid("1e6c3bb9-e595-4614-bea3-d6e3fe86e37f")]
    [Order(14)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
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

    /// <summary>Сигнатура</summary>
    /// <remarks>Публичная сигнатура компонента</remarks>
    [Order(15)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntityProperty]
    [DisplayName("SR.M('Сигнатура')")]
    [Description("SR.M('Публичная сигнатура компонента')")]
    [Property("66c7898b-e56b-49e0-bfb8-9f9c4a7a0c52")]
    [EleWise.ELMA.Model.Attributes.Uid("a46e9f0b-bfda-4ca4-9116-06367c1b9837")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [XmlSerializableObjectSettings(FieldName = "Signature")]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    public virtual object Signature
    {
      get => this._signature;
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
              this._signature = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
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

    /// <summary>Сценарий представления</summary>
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.Uid("8d67c72a-12ca-453c-9ee6-d0cd82863157")]
    [Order(11)]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "53eba73b-29a5-4609-9d37-a93e409dc09f")]
    [DisplayName("SR.M('Сценарий представления')")]
    [EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "ViewScriptModule")]
    public virtual ScriptModule ViewScriptModule
    {
      get => this._viewScriptModule;
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
              this._viewScriptModule = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
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

    static ComponentMetadataItem()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            ComponentMetadataItem._UID = new Guid((string) ComponentMetadataItem.kPFdNkBoGQsMM4vZVagW(964881585 - -1459193222 ^ -1870883837));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static void FmbH9qBobLQpZGbRZR5k() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static DateTime CP00nGBoh5BkyKHS6OeR() => DateTime.Now;

    internal static bool uulUErBoWI7t5rvQRSHh() => ComponentMetadataItem.cs5n7GBoBSS4ke72mGjQ == null;

    internal static ComponentMetadataItem caVnPZBoo9Z9kiQFnTpy() => ComponentMetadataItem.cs5n7GBoBSS4ke72mGjQ;

    internal static object kPFdNkBoGQsMM4vZVagW(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
