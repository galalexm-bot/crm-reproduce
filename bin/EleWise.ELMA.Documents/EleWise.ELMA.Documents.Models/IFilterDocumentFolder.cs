using System;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Documents.Models.Folders;

[MetadataType(typeof(EntityMetadata))]
[Uid("68b40223-c96a-4384-8781-fac6c383a970")]
[DisplayName(typeof(__Resources_IFilterDocumentFolder), "DisplayName")]
[BaseClass("b04c011a-27a4-4fab-8bc6-a1a2ab61a1c3")]
[DisplayFormat(null)]
[InterfaceImplementation("EleWise.ELMA.Common.Models.Filters.IFilterBase, EleWise.ELMA.Common")]
[Image(typeof(IFilterDocumentFolder), "folder_filter", 16, ImageFormatType.IconPack, false)]
[CustomCode(typeof(IFilterDocumentFolder), "EleWise.ELMA.Documents.Models.Folders.FilterDocumentFolder.CustomCodeTemplate.cs")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>96e31d2c-5dab-4a84-abf1-e0c8edd02202</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("FilterDocumentFolder")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[ImplementationUid("24894223-0db6-405c-b40c-b29d229ad4a3")]
[FilterType(typeof(IFilterDocumentFolderFilter))]
[ActionsType(typeof(FilterDocumentFolderActions))]
public interface IFilterDocumentFolder : IFolder, IDmsObject, IEntity<long>, IEntity, IIdentified, ISoftDeletable, IInheritable, IUserImageSetable, IFilterBase
{
	[DisplayName(typeof(__Resources_IFilterDocumentFolder_IBaseFilter), "P_FilterFields_DisplayName")]
	new object FilterFields { get; set; }

	[DisplayName(typeof(__Resources_IFilterDocumentFolder_IBaseFilter), "P_SearchFields_DisplayName")]
	new object SearchFields { get; set; }

	[DisplayName(typeof(__Resources_IFilterDocumentFolder_IBaseFilter), "P_Code_DisplayName")]
	new Guid? Code { get; set; }

	new Guid Uid { get; set; }

	[DisplayName(typeof(__Resources_IFilterDocumentFolder_IBaseFilter), "P_Name_DisplayName")]
	new string Name { get; set; }

	[DisplayName(typeof(__Resources_IFilterDocumentFolder_IBaseFilter), "P_ImageUrl_DisplayName")]
	new string ImageUrl { get; set; }

	[Uid("821c7505-8626-40ca-bcf3-a9f1b7e02961")]
	[Property("66c7898b-e56b-49e0-bfb8-9f9c4a7a0c52")]
	[XmlSerializableObjectSettings(FieldName = "DocumentFilter")]
	[DisplayName(typeof(__Resources_IFilterDocumentFolder), "P_DocumentFilter_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[EntityProperty]
	object DocumentFilter { get; set; }

	[Uid("6180bf22-a9fd-4bef-a357-535b1eafffbb")]
	[Order(1)]
	[Property("1911b22d-0ce2-4743-832f-6a44cb0357fe")]
	[BlobSettings(FieldName = "GridState")]
	[DisplayName(typeof(__Resources_IFilterDocumentFolder), "P_GridState_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[EntityProperty]
	new byte[] GridState { get; set; }

	[Uid("957376e8-4ea9-42b1-ad63-f0c002e70e4a")]
	[Order(2)]
	[Property("66c7898b-e56b-49e0-bfb8-9f9c4a7a0c52")]
	[XmlSerializableObjectSettings(FieldName = "FilterColumnState")]
	[DisplayName(typeof(__Resources_IFilterDocumentFolder), "P_FilterColumnState_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[EntityProperty]
	object FilterColumnState { get; set; }

	[Uid("39b1ea76-a467-48e0-87c5-70d38a61d53f")]
	[Order(3)]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "SearchOnOpen")]
	[DisplayName(typeof(__Resources_IFilterDocumentFolder), "P_SearchOnOpen_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[EntityProperty]
	bool SearchOnOpen { get; set; }

	[Uid("123ff9e3-7676-453f-a25a-4909f92b26a6")]
	[Order(4)]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "ExpandSearch")]
	[DisplayName(typeof(__Resources_IFilterDocumentFolder), "P_ExpandSearch_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[EntityProperty]
	new bool ExpandSearch { get; set; }

	[Uid("0b584f67-4cef-4a6b-838b-7ada432b360a")]
	[Order(5)]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "UseDefaultSettings")]
	[DisplayName(typeof(__Resources_IFilterDocumentFolder), "P_UseDefaultSettings_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	new bool UseDefaultSettings { get; set; }

	[Uid("e5260a88-da13-4d7b-9ee0-f884af9f5390")]
	[Order(6)]
	[CanBeNull]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(FieldName = "UseDefaultSettingsDate")]
	[DisplayName(typeof(__Resources_IFilterDocumentFolder), "P_UseDefaultSettingsDate_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	new DateTime? UseDefaultSettingsDate { get; set; }

	[Uid("b3937e4c-8944-491e-9270-126ab8169973")]
	[Order(6)]
	[Property("2df8e9ca-3ac4-4ba5-832f-18f6374397e7")]
	[ReferenceOnEntityTypeSettings(FieldName = "ObjectsType")]
	[DisplayName(typeof(__Resources_IFilterDocumentFolder), "P_ObjectsType_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	new ReferenceOnEntityType ObjectsType { get; set; }

	[Uid("a6d5c416-9bec-4830-aef5-a91c641202b0")]
	[Order(7)]
	[NotNull]
	[Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "db6d55c0-31b4-4594-97f9-4adb599bc8d9")]
	[EnumSettings(FieldName = "FilterType")]
	[DisplayName(typeof(__Resources_IFilterDocumentFolder), "P_FilterType_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	new FilterType FilterType { get; set; }
}
