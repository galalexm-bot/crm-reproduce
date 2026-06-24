using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Types.Settings;

namespace EleWise.ELMA.Workflow.Models;

[Filterable]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[DisplayName(typeof(__Resources_ICustomActivity), "DisplayName")]
[DisplayFormat(null)]
[Uid("c83a80c7-9eef-40ff-b3f5-b46a06094869")]
[FilterType(typeof(ICustomActivityFilter))]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>f8c910a1-e653-4366-a7de-2cf3108c2c40</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[TitleProperty("7901d59d-ad3e-4e8f-8e29-6e2394ff4d85")]
[ImplementationUid("04f2fc48-984a-4830-9996-f4132392976f")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[MetadataType(typeof(EntityMetadata))]
[Entity("CustomActivity")]
public interface ICustomActivity : IEntity<long>, IEntity, IIdentified
{
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[SystemProperty]
	[Uid("1e0d937b-fe65-47f9-8dda-8c302344b109")]
	[NotNull]
	[DisplayName(typeof(__Resources_ICustomActivity), "P_Uid_DisplayName")]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[EntityProperty]
	Guid Uid { get; set; }

	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[DisplayName(typeof(__Resources_ICustomActivity), "P_ScriptModule_DisplayName")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "ScriptModule")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "53eba73b-29a5-4609-9d37-a93e409dc09f")]
	[Order(1)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Uid("20f0088b-f83d-4d2d-9684-94aa795e5253")]
	ScriptModule ScriptModule { get; set; }

	[DisplayName(typeof(__Resources_ICustomActivity), "P_Header_DisplayName")]
	[EntityProperty]
	[RequiredField]
	[Uid("1461703d-3c75-4188-ae58-12ec13ead1e1")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Required(true)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "9b83a85f-81ce-4f66-9f74-683799a4f362")]
	[Order(2)]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Header")]
	ICustomActivityHeader Header { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[EntityProperty]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[DisplayName(typeof(__Resources_ICustomActivity), "P_Parameters_DisplayName")]
	[Order(3)]
	[Uid("247308f8-819f-455c-96f4-ec3ea615f792")]
	[EntitySettings(CascadeMode = CascadeMode.All, FieldName = "Parameters")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "c68a3664-8211-4960-b082-7bdc7e24fc9b")]
	CustomActivityParameters Parameters { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[DisplayName(typeof(__Resources_ICustomActivity), "P_CreationDate_DisplayName")]
	[Order(4)]
	[Uid("16039040-882d-433e-ba42-03eb4bceafdc")]
	[NotNull]
	[DateTimeSettings(SetCurrentDate = true, FieldName = "CreationDate")]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[EntityProperty]
	DateTime CreationDate { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_ICustomActivity), "P_VersionNumber_DisplayName")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[NotNull]
	[Order(6)]
	[Uid("1e424122-94cc-4473-a382-8e3dd00d8c6c")]
	[Required(true)]
	[RequiredField]
	[Int64Settings(DefaultValueStr = "0", FieldName = "VersionNumber")]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	long VersionNumber { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_ICustomActivity), "P_CreationAuthor_DisplayName")]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[EntityUserSettings(FieldName = "CreationAuthor")]
	[Uid("f728bc61-83c0-4c80-915f-3faec7b080a7")]
	[EntityProperty]
	[Order(5)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	IUser CreationAuthor { get; set; }
}
