using System;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Projects.Models.Resources;

[MetadataType(typeof(EntityMetadata))]
[Uid("dedb3fa3-35be-4eb1-b29a-6b995e8b32a5")]
[DisplayName(typeof(__Resources_IResourceCalendar), "DisplayName")]
[DisplayFormat(null)]
[TitleProperty("59d9b2e3-4a78-40fb-b0d7-259ecad233a4")]
[InterfaceImplementation("EleWise.ELMA.Model.Entities.ISoftDeletable")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>248bb472-8033-47b5-b85b-b8ae0399f67e</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[NamespaceForDisplay("EleWise.ELMA.Calendar.Models")]
[Entity("ResourceCalendar")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[ImplementationUid("e43ed20c-9f2a-44ce-a0cc-bc26dad56f34")]
[FilterType(typeof(IResourceCalendarFilter))]
public interface IResourceCalendar : IEntity<long>, IEntity, IIdentified, ISoftDeletable
{
	[Uid("70903cf8-8e68-4932-b9ba-70c10193a4b6")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IResourceCalendar), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("8a8e920a-9e9d-483c-8c27-40829a2575f8")]
	[Order(2)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "f5049cf3-312f-4dad-9c51-cb200af18b21")]
	[EntitySettings(RelationType = RelationType.OneToMany, KeyColumnUidStr = "590e7e43-b218-413c-bb9b-982fa5393ff3", CascadeMode = CascadeMode.SaveUpdate)]
	[DisplayName(typeof(__Resources_IResourceCalendar), "P_WorkIntervals_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	ISet<IWorkTimeInterval> WorkIntervals { get; set; }

	[Uid("59d9b2e3-4a78-40fb-b0d7-259ecad233a4")]
	[Order(1)]
	[Required(true)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "Name")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IResourceCalendar), "P_Name_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[FastSearch(true)]
	[EntityProperty]
	string Name { get; set; }

	[Uid("c1f203c2-48bb-4fca-8746-d1c46df0128f")]
	[Order(4)]
	[CanBeNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(DefaultValueStr = "True", FieldName = "IsCatalog")]
	[DisplayName(typeof(__Resources_IResourceCalendar), "P_IsCatalog_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	bool? IsCatalog { get; set; }

	[Uid("a9779c0c-17ac-4b96-8f37-a6596c3ed351")]
	[Order(5)]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "IsDeleted")]
	[DisplayName(typeof(__Resources_IResourceCalendar), "P_IsDeleted_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	new bool IsDeleted { get; set; }

	[Uid("03e6abfc-1e74-40d1-a077-f6357d75f6ce")]
	[Order(6)]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "HardDelete")]
	[DisplayName(typeof(__Resources_IResourceCalendar), "P_HardDelete_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	new bool HardDelete { get; set; }

	[Uid("250e89e9-083e-4bee-ae95-94b74232d60e")]
	[Order(3)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "dc93a9af-2619-403e-b75b-bbaa9d64d73b")]
	[EntitySettings(RelationType = RelationType.OneToMany, KeyColumnUidStr = "cba9149d-4d60-4930-a9d8-365d15d6f1ec", CascadeMode = CascadeMode.SaveUpdate)]
	[DisplayName(typeof(__Resources_IResourceCalendar), "P_HolidayIntervals_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	ISet<IHolidayInterval> HolidayIntervals { get; set; }

	[Uid("10e7ae3b-d308-4d7c-a345-050b8aa263bb")]
	[Order(7)]
	[Required(true)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "e0744cb1-5172-45bf-8858-39ccdfd0a6a0")]
	[EntitySettings(RelationType = RelationType.OneToMany, KeyColumnUidStr = "0557d289-9ab6-41e8-9800-bd1104105ba1", CascadeMode = CascadeMode.SaveUpdate)]
	[RequiredField]
	[DisplayName(typeof(__Resources_IResourceCalendar), "P_BaseIntervals_DisplayName")]
	[Description(typeof(__Resources_IResourceCalendar), "P_BaseIntervals_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	ISet<IBaseTimeInterval> BaseIntervals { get; set; }
}
