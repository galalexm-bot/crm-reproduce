using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Types.Settings;

namespace EleWise.ELMA.Security.Models;

[Uid("bd759aff-f117-40b2-9c01-16b689a6b063")]
[Image(typeof(IReplacementRule), "replacement_rule", 16, ImageFormatType.IconPack, false)]
[MetadataType(typeof(EntityMetadata))]
[EntityMetadataType(EntityMetadataType.Interface)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>c65135e8-ad17-4d9c-8408-0b183de5114f</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("ReplacementRule")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[DisplayName(typeof(__Resources_IReplacementRule), "DisplayName")]
[DisplayFormat(null)]
[FilterType(typeof(IReplacementRuleFilter))]
[Filterable]
[ImplementationUid("de0f13ad-5e29-4b46-938a-e5cbb16a644d")]
public interface IReplacementRule : IEntity<long>, IEntity, IIdentified
{
	[DisplayName(typeof(__Resources_IReplacementRule), "P_Uid_DisplayName")]
	[GuidSettings(FieldName = "Uid")]
	[EntityProperty]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[NotNull]
	[Uid("7badb04a-bc82-4870-8e8b-cadfc150baf3")]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[SystemProperty]
	Guid Uid { get; set; }

	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[Required(true)]
	[Order(1)]
	[StringSettings(FieldName = "Name")]
	[Uid("14aebaaf-5284-4924-9883-8ae19a0843f3")]
	[DisplayName(typeof(__Resources_IReplacementRule), "P_Name_DisplayName")]
	[RequiredField]
	string Name { get; set; }

	[DisplayName(typeof(__Resources_IReplacementRule), "P_Filter_DisplayName")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[EntityProperty]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Order(5)]
	[XmlSerializableObjectSettings(FieldName = "Filter")]
	[Uid("b0e1bebe-3d9b-4547-a365-cf180485b497")]
	[Property("66c7898b-e56b-49e0-bfb8-9f9c4a7a0c52")]
	object Filter { get; set; }

	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[EntityUserSettings(CopyAction = CopyAction.ByRef, FieldName = "TargetUser")]
	[RequiredField]
	[Filterable]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IReplacementRule), "P_TargetUser_DisplayName")]
	[Description(typeof(__Resources_IReplacementRule), "P_TargetUser_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Uid("951adad8-7ded-4aa3-8029-140af5a44103")]
	[EntityProperty]
	[Required(true)]
	[Order(3)]
	IUser TargetUser { get; set; }

	[DisplayName(typeof(__Resources_IReplacementRule), "P_PropertyUid_DisplayName")]
	[GuidSettings(FieldName = "PropertyUid")]
	[Order(4)]
	[Uid("341f1f33-cb0c-4baf-b928-12fe032fba3c")]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[NotNull]
	[Filterable]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	Guid PropertyUid { get; set; }

	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Property("d6b44bce-b236-424d-aa74-d80da3c8db75")]
	[Uid("9655e87d-09c3-4dbd-974e-5f5c4a61ff2f")]
	[Order(6)]
	[DisplayName(typeof(__Resources_IReplacementRule), "P_Order_DisplayName")]
	[NotNull]
	[Int32Settings(FieldName = "Order")]
	int Order { get; set; }

	[Filterable]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[EntityProperty]
	[RequiredField]
	[Uid("a628ce64-9933-40af-a8a3-f34c55bdee93")]
	[Order(2)]
	[Required(true)]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, CopyAction = CopyAction.ByRef, FieldName = "Replacement")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "c4fbe20f-1114-4198-a307-31b65cc84635")]
	[DisplayName(typeof(__Resources_IReplacementRule), "P_Replacement_DisplayName")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	IReplacement Replacement { get; set; }
}
