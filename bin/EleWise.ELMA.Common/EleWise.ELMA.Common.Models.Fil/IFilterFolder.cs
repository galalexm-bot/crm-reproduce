using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Types.Settings;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Common.Models.Filters;

[MetadataType(typeof(EntityMetadata))]
[Uid("9fe78bd1-0b93-49f1-ad7a-1bb196c8c2ee")]
[DisplayName(typeof(__Resources_IFilterFolder), "DisplayName")]
[AllowCreateHeirs(true)]
[DisplayFormat(null)]
[TitleProperty("42bc60ac-4df6-4fa3-bd1b-00560f7f2541")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>7a07498b-440e-4d55-8563-c7d6a123d77c</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("FilterFolder")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[ImplementationUid("4347ac57-151c-43b7-b6b9-8e0a904e9a58")]
[FilterType(typeof(IFilterFolderFilter))]
public interface IFilterFolder : IEntity<long>, IEntity, IIdentified, IInheritable
{
	[Uid("2b6a89fa-844d-43a7-9f8a-2c922b3d2538")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IFilterFolder), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("42bc60ac-4df6-4fa3-bd1b-00560f7f2541")]
	[Order(1)]
	[Required(true)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "Name")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IFilterFolder), "P_Name_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[FastSearch(true)]
	[Filterable]
	[EntityProperty]
	string Name { get; set; }

	[Uid("b626873b-7535-4f38-8a9e-1ad94578f728")]
	[Order(2)]
	[Required(true)]
	[Property("2df8e9ca-3ac4-4ba5-832f-18f6374397e7")]
	[ReferenceOnEntityTypeSettings(FieldName = "ObjectsType")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IFilterFolder), "P_ObjectsType_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	ReferenceOnEntityType ObjectsType { get; set; }

	[Uid("1bedee0b-ac1f-43b2-8c48-7d407b85cf84")]
	[Order(3)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "9fe78bd1-0b93-49f1-ad7a-1bb196c8c2ee")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "ParentFolder")]
	[DisplayName(typeof(__Resources_IFilterFolder), "P_ParentFolder_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	IFilterFolder ParentFolder { get; set; }

	[Uid("1c2eccc0-e1a1-4e55-b92c-85aea8247dc7")]
	[Order(4)]
	[NotNull]
	[Required(true)]
	[Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "db6d55c0-31b4-4594-97f9-4adb599bc8d9")]
	[EnumSettings(DefaultValueStr = "a77d613b-447f-4015-9f1a-85fe6a756ea7", FieldName = "FilterType")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IFilterFolder), "P_FilterType_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	FilterType FilterType { get; set; }

	[Uid("64366a1f-8280-4d62-a2b0-f370f74f5165")]
	[Order(5)]
	[CanBeNull]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[Int64Settings(FieldName = "Weight")]
	[DisplayName(typeof(__Resources_IFilterFolder), "P_Weight_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	long? Weight { get; set; }

	[Uid("22beab35-81b5-4293-8604-cc03a87e74e5")]
	[Order(6)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "9fe78bd1-0b93-49f1-ad7a-1bb196c8c2ee")]
	[EntitySettings(RelationType = RelationType.OneToMany, KeyColumnUidStr = "1bedee0b-ac1f-43b2-8c48-7d407b85cf84", CascadeMode = CascadeMode.SaveUpdate)]
	[DisplayName(typeof(__Resources_IFilterFolder), "P_SubFolders_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	ISet<IFilterFolder> SubFolders { get; set; }

	[Uid("875da991-530b-40f3-8966-2f67af99c396")]
	[Order(7)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[EntityUserSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "CreationAuthor")]
	[DisplayName(typeof(__Resources_IFilterFolder), "P_CreationAuthor_DisplayName")]
	[PropertyHandler("b05ac6bd-eb8b-474a-a796-b53831a9967e")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	IUser CreationAuthor { get; set; }

	[Uid("3a99fff0-cd27-4030-812c-ff8e9dd423d9")]
	[Order(8)]
	[CanBeNull]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(FieldName = "CreationDate")]
	[DisplayName(typeof(__Resources_IFilterFolder), "P_CreationDate_DisplayName")]
	[PropertyHandler("d0c00d8a-e003-427d-9942-f52cfb77b0f0")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	DateTime? CreationDate { get; set; }

	[Uid("9a5b75d8-938e-4483-96d3-4b26c9ea1e95")]
	[Order(9)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[EntityUserSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "ChangeAuthor")]
	[DisplayName(typeof(__Resources_IFilterFolder), "P_ChangeAuthor_DisplayName")]
	[PropertyHandler("d152e660-1ee9-4b5f-a614-df280e5b3f98")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	IUser ChangeAuthor { get; set; }

	[Uid("339bd499-0dcb-435b-b2e0-1ad198d12e61")]
	[Order(10)]
	[CanBeNull]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(FieldName = "ChangeDate")]
	[DisplayName(typeof(__Resources_IFilterFolder), "P_ChangeDate_DisplayName")]
	[PropertyHandler("12a6c5c4-12f8-4b2e-b7ea-5438974a2d25")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	DateTime? ChangeDate { get; set; }

	[Uid("7e3e970a-1b63-465c-94d5-b3710aa59c0c")]
	[Order(11)]
	[CanBeNull]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Code")]
	[DisplayName(typeof(__Resources_IFilterFolder), "P_Code_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	Guid? Code { get; set; }
}
