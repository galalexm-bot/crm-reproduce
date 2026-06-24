using System;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Security.Models.API;

[Entity("PublicApplicationToken")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>4bb573aa-665b-41bf-a73e-9e57118724ac</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[ShowInCatalogList(false)]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[DisplayName(typeof(__Resources_IPublicApplicationToken), "DisplayName")]
[DisplayFormat(null)]
[InterfaceImplementation("EleWise.ELMA.API.Models.IPublicApplicationToken")]
[ShowInDesigner(false)]
[Uid("69334e6e-2d55-4665-94e1-1de241bfa9ce")]
[FilterType(typeof(IPublicApplicationTokenFilter))]
[ShowInTypeTree(false)]
[MetadataType(typeof(EntityMetadata))]
[Filterable]
[EntityMetadataType(EntityMetadataType.Interface)]
[CacheEntity]
[ImplementationUid("239503ef-06a0-440c-bd23-e873f5b47a69")]
public interface IPublicApplicationToken : IEntity<long>, IEntity, IIdentified, EleWise.ELMA.API.Models.IPublicApplicationToken
{
	[DisplayName(typeof(__Resources_IPublicApplicationToken), "P_Uid_DisplayName")]
	[GuidSettings(FieldName = "Uid")]
	[EntityProperty]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[NotNull]
	[Uid("33179be2-1248-4e66-952b-1a50c458260f")]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[SystemProperty]
	Guid Uid { get; set; }

	[Required(true)]
	[Order(1)]
	[Uid("bfec7811-b7c0-47c8-9f0b-8e085c9a2f00")]
	[Sortable(false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IPublicApplicationToken), "P_Application_DisplayName")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Application")]
	[RequiredField]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "1817c965-17ce-4463-86b5-08deb0f4b04e")]
	[Filterable]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	new IPublicApplication Application { get; set; }

	[Required(true)]
	[Order(2)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Filterable]
	[Uid("4ad2eb4b-7c6d-48dc-89ff-71c2dcc7a4d7")]
	[EntityProperty]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[RequiredField]
	[StringSettings(MaxValueString = "128", FieldName = "Token")]
	[StringRangeLength(0, "128")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IPublicApplicationToken), "P_Token_DisplayName")]
	new string Token { get; set; }

	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[NotNull]
	[EntityProperty]
	[Filterable]
	[Required(true)]
	[Order(3)]
	[Uid("bcce6641-f826-4615-bed1-ca80ac215953")]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DisplayName(typeof(__Resources_IPublicApplicationToken), "P_Expire_DisplayName")]
	[RequiredField]
	[DateTimeSettings(FieldName = "Expire")]
	new DateTime Expire { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[RequiredField]
	[Filterable]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[NotNull]
	[Order(4)]
	[Uid("66aa129e-ed32-4e5a-a9c1-400234650afb")]
	[BoolSettings(FieldName = "IsSystem")]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[Required(true)]
	[EntityProperty]
	[DisplayName(typeof(__Resources_IPublicApplicationToken), "P_IsSystem_DisplayName")]
	bool IsSystem { get; set; }
}
