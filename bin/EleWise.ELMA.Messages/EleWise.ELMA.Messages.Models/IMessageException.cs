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

namespace EleWise.ELMA.Messages.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("d3156238-5d05-4d6e-8ea2-b6a54a6a5c65")]
[DisplayName(typeof(__Resources_IMessageException), "DisplayName")]
[DisplayFormat(null)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>829419e8-fc39-42fa-a0c2-de224b9a327c</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("MessageException")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("b95fe9e2-7d0a-44ae-8c34-76d19fc871e1")]
public interface IMessageException : IEntity<long>, IEntity, IIdentified
{
	[Uid("12100285-1a1c-43e5-8258-31e0dfbc2df9")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IMessageException), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("d81244c9-c249-4f32-a4ae-0696ab1f2996")]
	[NotNull]
	[Required(true)]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "ObjectUid")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IMessageException), "P_ObjectUid_DisplayName")]
	[EntityProperty]
	Guid ObjectUid { get; set; }

	[Uid("989726f3-6a5b-4dba-891a-74daeee23e3b")]
	[Order(1)]
	[NotNull]
	[Required(true)]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "ActionUid")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IMessageException), "P_ActionUid_DisplayName")]
	[EntityProperty]
	Guid ActionUid { get; set; }

	[Uid("f9a306fd-e0ef-4f7e-a929-0dc7629128be")]
	[Order(2)]
	[CanBeNull]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "ChannelUid")]
	[DisplayName(typeof(__Resources_IMessageException), "P_ChannelUid_DisplayName")]
	[EntityProperty]
	Guid? ChannelUid { get; set; }

	[Uid("aa825fbc-a2bc-410e-9290-fda063b790b7")]
	[Order(3)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[EntityUserSettings(FieldName = "Author")]
	[DisplayName(typeof(__Resources_IMessageException), "P_Author_DisplayName")]
	[PropertyHandler("b05ac6bd-eb8b-474a-a796-b53831a9967e")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	IUser Author { get; set; }
}
