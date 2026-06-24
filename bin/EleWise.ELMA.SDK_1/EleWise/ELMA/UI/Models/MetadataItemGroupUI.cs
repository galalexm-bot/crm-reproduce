// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Models.MetadataItemGroupUI
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
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.Models
{
  /// <summary>Группа элементов метаданных компонентов</summary>
  [TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>d68e41c4-aa8a-441b-8c6c-069026b1809b</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
  [Entity("MetadataItemGroupUI")]
  [InterfaceImplementation("EleWise.ELMA.Model.Entities.ISoftDeletable")]
  [CustomCode(typeof (MetadataItemGroupUI), "EleWise.ELMA.UI.Models.MetadataItemGroupUI.CustomCodeTemplate.cs")]
  [MetadataType(typeof (EntityMetadata))]
  [EleWise.ELMA.Model.Attributes.Uid("73efc2ea-167d-45e8-ac21-ed3b77ab9a2b")]
  [DisplayFormat(null)]
  [IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
  [TitleProperty("35190fb9-6737-4b28-8a7d-6425f70e1dda")]
  [ShowInCatalogList(false)]
  [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Группа элементов метаданных компонентов')")]
  public class MetadataItemGroupUI : Entity<long>, ISoftDeletable
  {
    /// <summary>Уникальный идентификатор данного класса</summary>
    public const string UID_S = "73efc2ea-167d-45e8-ac21-ed3b77ab9a2b";
    internal static Guid _UID;
    private Guid _uid;
    private string _name;
    private Guid _metadataTypeUid;
    private Guid _moduleUid;
    private MetadataItemGroupUI _parent;
    private ISet<MetadataItemGroupUI> _groups;
    private bool _isDeleted;
    private string _displayName;
    private static MetadataItemGroupUI jRD4XHBWNYvKCugYYWm7;

    /// <summary>
    /// Создать объект "Группа элементов метаданных компонентов"
    /// </summary>
    public MetadataItemGroupUI()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            this._metadataTypeUid = new Guid((string) MetadataItemGroupUI.NT3aUmBWa1VximeBUcuB(-1876063057 ^ -1876072021));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
            continue;
          default:
            this._groups = (ISet<MetadataItemGroupUI>) new HashedSet<MetadataItemGroupUI>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 1 : 0;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Уникальный идентификатор данного класса</summary>
    public static Guid UID => MetadataItemGroupUI._UID;

    /// <summary>Уникальный идентификатор</summary>
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Уникальный идентификатор')")]
    [View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
    [EntityProperty]
    [GuidSettings(FieldName = "Uid")]
    [NotNull]
    [EleWise.ELMA.Model.Attributes.Uid("cbaf796d-4b0a-48c9-81a2-6a6a0f7bc99b")]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    [SystemProperty]
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

    /// <summary>Наименование</summary>
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [Required(true)]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [Order(1)]
    [EleWise.ELMA.Model.Attributes.Uid("35190fb9-6737-4b28-8a7d-6425f70e1dda")]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Наименование')")]
    [StringRangeLength(0, "2000")]
    [StringSettings(MaxValueString = "2000", FieldName = "Name")]
    [RequiredField]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 0 : 0;
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

    /// <summary>Тип компонента</summary>
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Required(true)]
    [EleWise.ELMA.Model.Attributes.Uid("cf9c798e-88d2-4d45-960d-41ac6facd188")]
    [Order(2)]
    [NotNull]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Тип компонента')")]
    [RequiredField]
    [GuidSettings(DefaultValueStr = "66457ad6-ce6e-4cd5-ae3a-d46dc83a0e85", FieldName = "MetadataTypeUid")]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
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
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [GuidSettings(FieldName = "ModuleUid")]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    [Order(3)]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Уникальный идентификатор модуля')")]
    [NotNull]
    [EleWise.ELMA.Model.Attributes.Uid("3e2a51d6-7959-439b-a94f-86756de2396f")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
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

    /// <summary>Родительская группа</summary>
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Родительская группа')")]
    [EleWise.ELMA.Model.Attributes.Uid("75b0ae38-3cce-4421-9708-69853c20e065")]
    [EntityProperty]
    [Order(4)]
    [EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Parent")]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "73efc2ea-167d-45e8-ac21-ed3b77ab9a2b")]
    public virtual MetadataItemGroupUI Parent
    {
      get => this._parent;
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
              this._parent = value;
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

    /// <summary>Дочерние группы</summary>
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Order(5)]
    [EntityProperty]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "73efc2ea-167d-45e8-ac21-ed3b77ab9a2b")]
    [EleWise.ELMA.Model.Attributes.Uid("e556d7b5-b042-4f4d-912a-7fac1be34b91")]
    [EntitySettings(RelationType = RelationType.OneToMany, KeyColumnUidStr = "75b0ae38-3cce-4421-9708-69853c20e065", CascadeMode = CascadeMode.SaveUpdate)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Дочерние группы')")]
    public virtual ISet<MetadataItemGroupUI> Groups
    {
      get => this._groups;
      set => this._groups = value;
    }

    /// <summary>Удален</summary>
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [EntityProperty]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Удален')")]
    [Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
    [Order(6)]
    [EleWise.ELMA.Model.Attributes.Uid("7fe38a47-5ed7-4e53-a9c1-9c1de5ab5682")]
    [NotNull]
    [BoolSettings(FieldName = "IsDeleted")]
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

    /// <summary>Отображаемое имя</summary>
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Отображаемое имя')")]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [Order(7)]
    [EleWise.ELMA.Model.Attributes.Uid("de247a4d-3213-4d69-b62f-2bdd9f871dfb")]
    [StringSettings(FieldName = "DisplayName")]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
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

    public override string ToString() => (string) MetadataItemGroupUI.b1mGkABWDtejeC38L3oo((object) this);

    /// <summary>Реально удалить сущность из базы</summary>
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

    static MetadataItemGroupUI()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            MetadataItemGroupUI.wT2DMQBWtdLsKgJoqjWx();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            MetadataItemGroupUI._UID = new Guid((string) MetadataItemGroupUI.NT3aUmBWa1VximeBUcuB(1819636893 << 3 ^ 1672167796));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object NT3aUmBWa1VximeBUcuB(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool c24iZ3BW3VTkGL6DdIG4() => MetadataItemGroupUI.jRD4XHBWNYvKCugYYWm7 == null;

    internal static MetadataItemGroupUI z5sxNsBWpFodPiJimJhx() => MetadataItemGroupUI.jRD4XHBWNYvKCugYYWm7;

    internal static object b1mGkABWDtejeC38L3oo([In] object obj0) => (object) ((MetadataItemGroupUI) obj0).Name;

    internal static void wT2DMQBWtdLsKgJoqjWx() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
