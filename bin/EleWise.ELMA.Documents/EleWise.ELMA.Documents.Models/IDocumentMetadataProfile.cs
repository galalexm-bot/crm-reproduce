using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Types;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Types.Settings;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Documents.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("c3fe0ba3-2b4e-4de7-b60b-45a6fa196cb8")]
[DisplayName(typeof(__Resources_IDocumentMetadataProfile), "DisplayName")]
[DisplayFormat(null)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>1726e352-e829-4ad9-98e1-a968bb704097</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("DocumentMetadataProfile")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[ImplementationUid("07e55092-d372-48cd-bc22-92d5c10514b2")]
[CacheEntity]
[FilterType(typeof(IDocumentMetadataProfileFilter))]
public interface IDocumentMetadataProfile : IEntity<long>, IEntity, IIdentified
{
	[Uid("20a3a6e1-63a7-4ec0-b05f-546eef95a587")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IDocumentMetadataProfile), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("ecfbd7dd-bf67-4568-9edb-a0276d332378")]
	[Order(1)]
	[Property("2df8e9ca-3ac4-4ba5-832f-18f6374397e7")]
	[ReferenceOnEntityTypeSettings(FieldName = "DocumentType")]
	[DisplayName(typeof(__Resources_IDocumentMetadataProfile), "P_DocumentType_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	ReferenceOnEntityType DocumentType { get; set; }

	[Uid("4988d219-ace0-4e98-b17a-ea0f8992aa29")]
	[Order(2)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "b04c011a-27a4-4fab-8bc6-a1a2ab61a1c3")]
	[DocumentFolderSettings(SerializedInfos = "", FieldName = "Folder")]
	[DisplayName(typeof(__Resources_IDocumentMetadataProfile), "P_Folder_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	IFolder Folder { get; set; }

	[Uid("b0308050-48ee-445a-92a5-8b239c0b60fc")]
	[Order(3)]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "RestrictChangeFolder")]
	[DisplayName(typeof(__Resources_IDocumentMetadataProfile), "P_RestrictChangeFolder_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	bool RestrictChangeFolder { get; set; }

	[Uid("9e28fe52-2d46-43ae-b1de-6b3065fc0c77")]
	[Order(4)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "6cbc4e67-009c-4486-82f7-d6b0ceeddff6")]
	[EntitySettings(RelationType = RelationType.OneToMany, KeyColumnUidStr = "15385bf5-5883-447e-a6f7-10b4cb4504b8", CascadeMode = CascadeMode.SaveUpdate)]
	[DisplayName(typeof(__Resources_IDocumentMetadataProfile), "P_Permissions_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	ISet<IDmsObjectDefaultPermissions> Permissions { get; set; }

	[Uid("b5567146-faa0-4302-8cd8-2db2848961a9")]
	[Order(5)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[EntityUserSettings(FieldName = "CreationAuthor")]
	[DisplayName(typeof(__Resources_IDocumentMetadataProfile), "P_CreationAuthor_DisplayName")]
	[PropertyHandler("b05ac6bd-eb8b-474a-a796-b53831a9967e")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	IUser CreationAuthor { get; set; }

	[Uid("e4c7f54e-3127-4815-bbfb-6b5182ab8ad5")]
	[Order(6)]
	[NotNull]
	[Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "dc9bee3d-46b9-40a4-a194-d0f2ad7f60cd")]
	[EnumSettings(FieldName = "DefaultPermissionType")]
	[DisplayName(typeof(__Resources_IDocumentMetadataProfile), "P_DefaultPermissionType_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	DocumentDefaultPermissionType DefaultPermissionType { get; set; }

	[Uid("0d7dafb5-4550-41a5-8524-a718d1255911")]
	[Order(7)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "d1bfe6d8-fa26-469a-af73-13b9dab3f4af")]
	[EntitySettings(RelationType = RelationType.OneToMany, KeyColumnUidStr = "2dd5b223-eef6-4301-8129-03e258ca65d5", CascadeMode = CascadeMode.SaveUpdate)]
	[DisplayName(typeof(__Resources_IDocumentMetadataProfile), "P_Templates_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	ISet<IDocumentTemplate> Templates { get; set; }

	[Uid("ff137426-df8d-436e-a2d4-5c483ca270e3")]
	[Order(8)]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(DisplayType = BoolDisplayType.Checkbox, FieldName = "UseCustomHistorySettings")]
	[DisplayName(typeof(__Resources_IDocumentMetadataProfile), "P_UseCustomHistorySettings_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	bool UseCustomHistorySettings { get; set; }

	[Uid("60d995a5-fd98-4810-9395-30967c8ce13a")]
	[Order(9)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "897ce21d-bcda-4a81-beb0-8a03a5f38716")]
	[EntitySettings(RelationType = RelationType.OneToMany, KeyColumnUidStr = "a2b3e362-dfcd-422d-b678-2e815bf5ad88", CascadeMode = CascadeMode.SaveUpdate)]
	[DisplayName(typeof(__Resources_IDocumentMetadataProfile), "P_HistoryViewSettings_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	ISet<IDocumentHistoryProfile> HistoryViewSettings { get; set; }

	[Uid("08dd99f6-4568-4e48-9c70-005429fcfc14")]
	[Order(10)]
	[CanBeNull]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "AuthorDefaultPermissionId")]
	[DisplayName(typeof(__Resources_IDocumentMetadataProfile), "P_AuthorDefaultPermissionId_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	Guid? AuthorDefaultPermissionId { get; set; }

	[Uid("23c8701c-d63e-4fb7-8727-1cc9138b55a3")]
	[Order(11)]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "AuthorAddAccessDefaulPermiss")]
	[DisplayName(typeof(__Resources_IDocumentMetadataProfile), "P_AuthorAddAccessDefaulPermission_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	bool AuthorAddAccessDefaulPermission { get; set; }

	[Uid("e598a36a-80c4-46cc-9b74-ef7b841b09cf")]
	[Order(12)]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(DisplayType = BoolDisplayType.Checkbox, FieldName = "UseCustomActionsSettings")]
	[DisplayName(typeof(__Resources_IDocumentMetadataProfile), "P_UseCustomActionsSettings_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	bool UseCustomActionsSettings { get; set; }

	[Uid("3ed295d0-7b25-418e-a3d4-545087566ad5")]
	[Order(13)]
	[Property("66c7898b-e56b-49e0-bfb8-9f9c4a7a0c52")]
	[XmlSerializableObjectSettings(FieldName = "ActionVisibility")]
	[DisplayName(typeof(__Resources_IDocumentMetadataProfile), "P_ActionVisibility_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	object ActionVisibility { get; set; }
}
