using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Types.Settings;

namespace EleWise.ELMA.Content.Models.Media;

[MetadataType(typeof(EntityMetadata))]
[Uid("976abff1-041c-40b4-ad3d-ff1e32e4f970")]
[DisplayName(typeof(__Resources_IMediaFolder), "DisplayName")]
[DisplayFormat(null)]
[TitleProperty("fd184e13-a2a1-4e6e-9e5e-9620f3111528")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>e49ab883-e5ab-4f6e-8ea8-736dffe39768</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("MediaFolder")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("400fc74e-6b58-4619-a2a5-5b18a06cfd32")]
public interface IMediaFolder : IEntity<long>, IEntity, IIdentified
{
	[Uid("3d586734-fd30-4fac-a3f4-caaf00b9ed82")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IMediaFolder), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("fd184e13-a2a1-4e6e-9e5e-9620f3111528")]
	[Order(1)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(MaxValueString = "2000", FieldName = "Name")]
	[StringRangeLength(0, "2000")]
	[DisplayName(typeof(__Resources_IMediaFolder), "P_Name_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[FastSearch(true)]
	[Filterable]
	[EntityProperty]
	string Name { get; set; }

	[Uid("d1d62443-e309-4e42-8ea3-a31ce1888a86")]
	[Order(2)]
	[CanBeNull]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(SetCurrentDate = true, FieldName = "CreationDate")]
	[DisplayName(typeof(__Resources_IMediaFolder), "P_CreationDate_DisplayName")]
	[PropertyHandler("d0c00d8a-e003-427d-9942-f52cfb77b0f0")]
	[Filterable]
	[EntityProperty]
	DateTime? CreationDate { get; set; }

	[Uid("1da6aaed-debc-45ea-a061-8bf60c31ece3")]
	[Order(3)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[EntityUserSettings(FieldName = "CreationAuthor")]
	[DisplayName(typeof(__Resources_IMediaFolder), "P_CreationAuthor_DisplayName")]
	[PropertyHandler("b05ac6bd-eb8b-474a-a796-b53831a9967e")]
	[Filterable]
	[EntityProperty]
	IUser CreationAuthor { get; set; }

	[Uid("02de6d4c-2be6-493e-abcd-beb63708fce2")]
	[Order(4)]
	[CanBeNull]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(FieldName = "ChangeDate")]
	[DisplayName(typeof(__Resources_IMediaFolder), "P_ChangeDate_DisplayName")]
	[PropertyHandler("12a6c5c4-12f8-4b2e-b7ea-5438974a2d25")]
	[Filterable]
	[EntityProperty]
	DateTime? ChangeDate { get; set; }

	[Uid("9f48e49a-bb5f-4df6-9245-e1f2da8fdca4")]
	[Order(5)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[EntityUserSettings(FieldName = "ChangeAuthor")]
	[DisplayName(typeof(__Resources_IMediaFolder), "P_ChangeAuthor_DisplayName")]
	[PropertyHandler("d152e660-1ee9-4b5f-a614-df280e5b3f98")]
	[Filterable]
	[EntityProperty]
	IUser ChangeAuthor { get; set; }

	[Uid("4755f46f-cfbe-4b0f-a22d-67c6dda669ed")]
	[Order(6)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "976abff1-041c-40b4-ad3d-ff1e32e4f970")]
	[EntitySettings(FieldName = "Parent")]
	[DisplayName(typeof(__Resources_IMediaFolder), "P_Parent_DisplayName")]
	[Description(typeof(__Resources_IMediaFolder), "P_Parent_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	IMediaFolder Parent { get; set; }

	[Uid("d3009866-b683-43f8-af15-5cbcf8c48d6d")]
	[Order(7)]
	[NotNull]
	[Required(true)]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "Deleted")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IMediaFolder), "P_Deleted_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	bool Deleted { get; set; }
}
