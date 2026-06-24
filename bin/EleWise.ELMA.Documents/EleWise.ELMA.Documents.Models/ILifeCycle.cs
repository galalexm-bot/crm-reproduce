using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Documents.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("9db1b922-f454-4fad-ab00-02651d1e01c2")]
[DisplayName(typeof(__Resources_ILifeCycle), "DisplayName")]
[DisplayFormat("Жизненный цикл")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>a1523932-9ae6-4a24-a97e-c634ccfe9dcd</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("LifeCycle")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("95bc98dc-a3cf-4c47-b8ae-40b0fd1e0e85")]
[CacheEntity]
public interface ILifeCycle : IEntity<long>, IEntity, IIdentified
{
	[Uid("8e12d949-b5b8-47d1-8349-d921039674fd")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_ILifeCycle), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("a9b4d686-5e7a-4d29-80d1-881b0f601210")]
	[Order(1)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "0bf0145b-21ae-4184-80eb-f26c967dcce6")]
	[EntitySettings(RelationType = RelationType.ManyToMany, RelationTableName = "StatusesOfLifeCycle", ParentColumnName = "LifeCycleId", ChildColumnName = "StatusId", CascadeMode = CascadeMode.SaveUpdate)]
	[DisplayName(typeof(__Resources_ILifeCycle), "P_Statuses_DisplayName")]
	[EntityProperty]
	ISet<ILifeCycleStatus> Statuses { get; set; }

	[Uid("d284805c-afa5-4aeb-a984-f2e955317ca0")]
	[Order(2)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "f6f5f441-2cb7-47df-9170-a3e034fec648")]
	[EntitySettings(RelationType = RelationType.OneToMany, KeyColumnUidStr = "fc4bccd2-c220-4f09-a2a9-925e6fbb92e9", CascadeMode = CascadeMode.All)]
	[DisplayName(typeof(__Resources_ILifeCycle), "P_Transitions_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	ISet<ILifeCycleTransition> Transitions { get; set; }

	[Uid("9c00e8ea-269a-4166-aa40-70dbf677767b")]
	[Order(3)]
	[NotNull]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "DocumentType")]
	[DisplayName(typeof(__Resources_ILifeCycle), "P_DocumentType_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	Guid DocumentType { get; set; }

	[Uid("561c8dff-0383-4d5c-aeac-6d9246c92683")]
	[Order(4)]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(DefaultValueStr = "True", FieldName = "IsCustomChangeStatus")]
	[DisplayName(typeof(__Resources_ILifeCycle), "P_IsCustomChangeStatus_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	bool IsCustomChangeStatus { get; set; }

	[Uid("6e9f9934-8fea-456b-9623-facb8bbe668e")]
	[Order(5)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "0bf0145b-21ae-4184-80eb-f26c967dcce6")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "DefaultStatus")]
	[DisplayName(typeof(__Resources_ILifeCycle), "P_DefaultStatus_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	ILifeCycleStatus DefaultStatus { get; set; }
}
