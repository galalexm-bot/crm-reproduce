using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Documents.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("f6f5f441-2cb7-47df-9170-a3e034fec648")]
[DisplayName(typeof(__Resources_ILifeCycleTransition), "DisplayName")]
[DisplayFormat("{$Name}")]
[TitleProperty("05e4acb2-8d7b-48d4-ac82-a89937a4e140")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>b6f0feb1-77c0-4911-8df8-2ce93050cbbb</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("LifeCycleTransition")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("77481ac5-14fc-44c2-8b06-8e9e1deb7686")]
public interface ILifeCycleTransition : IEntity<long>, IEntity, IIdentified
{
	[Uid("a12f4512-2803-4493-9660-2ff4a1fafa58")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_ILifeCycleTransition), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("05e4acb2-8d7b-48d4-ac82-a89937a4e140")]
	[Order(1)]
	[Required(true)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(MaxValueString = "2000", FieldName = "Name")]
	[RequiredField]
	[StringRangeLength(0, "2000")]
	[DisplayName(typeof(__Resources_ILifeCycleTransition), "P_Name_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	string Name { get; set; }

	[Uid("85caea7e-aabb-4488-a66a-6733458be3ab")]
	[Order(2)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(MultiLine = true, FieldName = "Description")]
	[DisplayName(typeof(__Resources_ILifeCycleTransition), "P_Description_DisplayName")]
	[EntityProperty]
	string Description { get; set; }

	[Uid("a54e1a75-d480-4042-84a1-4e84dc4e80f1")]
	[Order(3)]
	[Required(true)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "0bf0145b-21ae-4184-80eb-f26c967dcce6")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "StartStatus")]
	[RequiredField]
	[DisplayName(typeof(__Resources_ILifeCycleTransition), "P_Start_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	ILifeCycleStatus Start { get; set; }

	[Uid("adc20a3d-e855-40eb-b3e0-08ed5bdf8bd5")]
	[Order(4)]
	[Required(true)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "0bf0145b-21ae-4184-80eb-f26c967dcce6")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "FinishStatus")]
	[RequiredField]
	[DisplayName(typeof(__Resources_ILifeCycleTransition), "P_Finish_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	ILifeCycleStatus Finish { get; set; }

	[Uid("fc4bccd2-c220-4f09-a2a9-925e6fbb92e9")]
	[Order(5)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "9db1b922-f454-4fad-ab00-02651d1e01c2")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "LifeCycle")]
	[DisplayName(typeof(__Resources_ILifeCycleTransition), "P_LifeCycle_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	ILifeCycle LifeCycle { get; set; }
}
