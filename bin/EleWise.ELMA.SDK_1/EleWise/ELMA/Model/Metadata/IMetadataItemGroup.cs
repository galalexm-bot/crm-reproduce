// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.IMetadataItemGroup
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
using Iesi.Collections.Generic;
using System;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Группа элементов метаданных</summary>
  [TitleProperty("bd8e2964-aff8-461c-b379-d3993a6d43fa")]
  [Hierarchical(HierarchyType.Elements, "55abde4a-30b0-4c41-8403-2079a13b3992", "74200ecd-a54a-44e6-923a-50810151c759")]
  [EleWise.ELMA.Model.Attributes.DisplayName(typeof (__Resources_IMetadataItemGroup), "DisplayName")]
  [ImplementationUid("b7756394-df2b-42a8-a80b-7c514028550e")]
  [IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
  [EntityMetadataType(EntityMetadataType.Interface)]
  [ShowInCatalogList(false)]
  [Entity("MetadataItemGroup")]
  [ShowInTypeTree(false)]
  [EleWise.ELMA.Model.Attributes.Uid("70825a99-37a6-4ac5-85ec-3eef06262f55")]
  [TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>545cb32b-4f1c-47ae-aef1-b46187046f98</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
  [ShowInDesigner(false)]
  [MetadataType(typeof (EntityMetadata))]
  [DisplayFormat(null)]
  public interface IMetadataItemGroup : IEntity<long>, IEntity, IIdentified
  {
    /// <summary>Уникальный идентификатор</summary>
    [View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
    [EntityProperty]
    [NotNull]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (__Resources_IMetadataItemGroup), "P_Uid_DisplayName")]
    [EleWise.ELMA.Model.Attributes.Uid("e16ccbc7-7479-47ff-931f-51fb446c19bc")]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    [GuidSettings(FieldName = "Uid")]
    [SystemProperty]
    Guid Uid { get; set; }

    /// <summary>Родительский объект</summary>
    [SystemProperty]
    [EntitySettings(FieldName = "Parent")]
    [EntityProperty]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (__Resources_IMetadataItemGroup), "P_Parent_DisplayName")]
    [Order(1)]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "70825a99-37a6-4ac5-85ec-3eef06262f55")]
    [EleWise.ELMA.Model.Attributes.Uid("55abde4a-30b0-4c41-8403-2079a13b3992")]
    IMetadataItemGroup Parent { get; set; }

    /// <summary>Наименование</summary>
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [StringRangeLength(0, "2000")]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (__Resources_IMetadataItemGroup), "P_Name_DisplayName")]
    [EntityProperty]
    [Filterable]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [FastSearch(true)]
    [Order(2)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.Uid("bd8e2964-aff8-461c-b379-d3993a6d43fa")]
    [Required(true)]
    [RequiredField]
    [StringSettings(MaxValueString = "2000", FieldName = "Name")]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    string Name { get; set; }

    /// <summary>Дата создания</summary>
    [Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
    [DateTimeSettings(SetCurrentDate = true, FieldName = "CreationDate")]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (__Resources_IMetadataItemGroup), "P_CreationDate_DisplayName")]
    [NotNull]
    [EntityProperty]
    [EleWise.ELMA.Model.Attributes.Uid("f34e2321-3b1b-46c9-b302-7fa62af5ae4d")]
    [Order(6)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [Filterable]
    [PropertyHandler("d0c00d8a-e003-427d-9942-f52cfb77b0f0")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    DateTime CreationDate { get; set; }

    /// <summary>Идентификатор автора создания</summary>
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [EntityProperty]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (__Resources_IMetadataItemGroup), "P_CreationAuthorId_DisplayName")]
    [Order(7)]
    [EleWise.ELMA.Model.Attributes.Uid("b7fd035f-5114-4ae6-9db8-590dc5b5a89e")]
    [CanBeNull]
    [Int64Settings(FieldName = "CreationAuthorId")]
    [Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
    long? CreationAuthorId { get; set; }

    /// <summary>Подгруппы</summary>
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Order(8)]
    [EleWise.ELMA.Model.Attributes.Uid("45faaab8-304d-4434-8b4b-3f7d845be2fe")]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "70825a99-37a6-4ac5-85ec-3eef06262f55")]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (__Resources_IMetadataItemGroup), "P_SubGroups_DisplayName")]
    [EntitySettings(RelationType = RelationType.OneToMany, KeyColumnUidStr = "55abde4a-30b0-4c41-8403-2079a13b3992")]
    ISet<IMetadataItemGroup> SubGroups { get; set; }

    /// <summary>Пространство имен</summary>
    /// <remarks>Пространство имен, соответствующее данной группе</remarks>
    [StringRangeLength(0, "2000")]
    [EleWise.ELMA.Model.Attributes.Uid("3926b12e-7cf1-4c9c-8483-7d5f057cf1c6")]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (__Resources_IMetadataItemGroup), "P_Namespace_DisplayName")]
    [StringSettings(MaxValueString = "2000", FieldName = "Namespace")]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [Order(4)]
    [EntityProperty]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Description(typeof (__Resources_IMetadataItemGroup), "P_Namespace_Description")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    string Namespace { get; set; }

    /// <summary>Отображаемое имя</summary>
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (__Resources_IMetadataItemGroup), "P_DisplayName_DisplayName")]
    [EntityProperty]
    [StringSettings(FieldName = "DisplayName")]
    [EleWise.ELMA.Model.Attributes.Uid("9c1d2994-04a2-4e27-85c4-deac9471038e")]
    [Order(3)]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    string DisplayName { get; set; }

    /// <summary>Является системной группой</summary>
    [Order(5)]
    [Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
    [NotNull]
    [BoolSettings(FieldName = "IsSystem")]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (__Resources_IMetadataItemGroup), "P_IsSystem_DisplayName")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.Uid("0ac7c0ea-88b9-4449-abe3-ba39181eeb40")]
    [EntityProperty]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    bool IsSystem { get; set; }
  }
}
