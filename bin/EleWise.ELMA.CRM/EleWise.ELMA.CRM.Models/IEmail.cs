using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("64b8e9c4-2fa1-4c51-9596-b2df478b72c5")]
[DisplayName(typeof(__Resources_IEmail), "DisplayName")]
[DisplayFormat(null)]
[TitleProperty("eaf5817b-bbcd-47ed-9136-6274de3a73b2")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>29a91bf9-7811-4e3a-9d07-3f3851a20b73</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("Email")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[SaveHistory]
[Filterable]
[ImplementationUid("1e27dd21-d515-4a60-873a-6a39aa30ae13")]
[FilterType(typeof(IEmailFilter))]
public interface IEmail : IEntity<long>, IEntity, IIdentified
{
	[Uid("1cf8dc1e-7d42-49ed-9e18-90428487db20")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IEmail), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("eaf5817b-bbcd-47ed-9136-6274de3a73b2")]
	[Order(1)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "EmailString")]
	[DisplayName(typeof(__Resources_IEmail), "P_EmailString_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[FastSearch(true)]
	[Filterable]
	[EntityProperty]
	string EmailString { get; set; }
}
