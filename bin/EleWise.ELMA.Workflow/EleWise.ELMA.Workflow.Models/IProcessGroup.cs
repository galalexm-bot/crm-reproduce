using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Workflow.Models;

[MetadataType(typeof(EntityMetadata))]
[ImplementationUid("c9ec582e-12bc-496f-a194-e2eeb51d1bce")]
[Entity("ProcessGroup")]
[DisplayName(typeof(__Resources_IProcessGroup), "DisplayName")]
[DisplayFormat("{$Name}")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>8bb2277e-cf3a-4c00-9c4d-d4f0330270f6</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[ShowInCatalogList(false)]
[Uid("864a32fb-9327-4985-bf8a-b7fdb651b152")]
[EntityMetadataType(EntityMetadataType.Interface)]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
public interface IProcessGroup : IEntity<long>, IEntity, IIdentified
{
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[Uid("c7d5a8dd-b980-4844-abdb-4284b8500234")]
	[NotNull]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IProcessGroup), "P_Uid_DisplayName")]
	[EntityProperty]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	Guid Uid { get; set; }

	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[ShowInTable(true)]
	[FastSearch(true)]
	[DisplayName(typeof(__Resources_IProcessGroup), "P_Name_DisplayName")]
	[Required(true)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[Uid("7ea34a78-a78c-4c35-b476-d5d8c937b934")]
	[Order(1)]
	[RequiredField]
	[StringSettings(MaxValueString = "2000", FieldName = "Name")]
	[StringRangeLength(0, "2000")]
	string Name { get; set; }

	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "864a32fb-9327-4985-bf8a-b7fdb651b152")]
	[EntitySettings(FieldName = "Parent")]
	[Uid("1c045b32-5565-40ae-898f-89a1b69acea2")]
	[Order(2)]
	[DisplayName(typeof(__Resources_IProcessGroup), "P_Parent_DisplayName")]
	[EntityProperty]
	IProcessGroup Parent { get; set; }

	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[EntityProperty]
	[Uid("06e9a0ff-ea9e-441f-a389-641bc4bec4c8")]
	[Order(3)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntitySettings(RelationType = RelationType.OneToMany, KeyColumnUidStr = "1c045b32-5565-40ae-898f-89a1b69acea2")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "864a32fb-9327-4985-bf8a-b7fdb651b152")]
	[DisplayName(typeof(__Resources_IProcessGroup), "P_SubGroups_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Description(typeof(__Resources_IProcessGroup), "P_SubGroups_Description")]
	ISet<IProcessGroup> SubGroups { get; set; }

	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntitySettings(RelationType = RelationType.OneToMany, KeyColumnUidStr = "bb48df79-a46a-460f-bd7f-bc23e3c294b7")]
	[Description(typeof(__Resources_IProcessGroup), "P_Processes_Description")]
	[Uid("39aa7f5a-bcc5-42f2-be18-73d8227da798")]
	[DisplayName(typeof(__Resources_IProcessGroup), "P_Processes_DisplayName")]
	[EntityProperty]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "da55965d-02a3-4dfd-8b71-d0c45d82c6a5")]
	[Order(4)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	ISet<IProcessHeader> Processes { get; set; }
}
