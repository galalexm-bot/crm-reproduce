using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Workflow.Models;

[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("ab6f2c21-ecd1-491c-aac0-0fc726d9f02f")]
[Description(typeof(__Resources_IBackgroundOperationInfo), "Description")]
[DisplayFormat(null)]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[DisplayName(typeof(__Resources_IBackgroundOperationInfo), "DisplayName")]
[ShowInDesigner(false)]
[ShowInTypeTree(false)]
[MetadataType(typeof(EntityMetadata))]
[Uid("8d14d117-79ea-442c-8a9f-7df200708e79")]
[Entity("BackgroundOperationInfo")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>c919bdae-1810-4073-a0d7-c7042fb3b2e3</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
public interface IBackgroundOperationInfo : IEntity<long>, IEntity, IIdentified
{
	[Uid("1471795f-9340-47a0-bd7e-8345982e4bd4")]
	[GuidSettings(FieldName = "Uid")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[DisplayName(typeof(__Resources_IBackgroundOperationInfo), "P_Uid_DisplayName")]
	[SystemProperty]
	[NotNull]
	Guid Uid { get; set; }

	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IBackgroundOperationInfo), "P_BoundBookmark_DisplayName")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "BoundBookmark")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Order(1)]
	[Uid("545fce10-19b9-46e2-9de0-db587fdce073")]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "1c56d793-9753-4a56-bc01-790cb0417251")]
	IWorkflowBookmark BoundBookmark { get; set; }

	[DisplayName(typeof(__Resources_IBackgroundOperationInfo), "P_Status_DisplayName")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "1b800f40-10ae-45bc-baa2-33cfbfb29081")]
	[EnumSettings(DefaultValueStr = "f83f208a-bdb2-40ec-8b6e-1057059fa094", FieldName = "Status")]
	[CanBeNull]
	[Uid("66e845fc-ee7b-4a57-870f-212073bd60c8")]
	[Order(2)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	BackgroundOperationStatus? Status { get; set; }

	[BlobSettings(FieldName = "OperationData")]
	[Property("1911b22d-0ce2-4743-832f-6a44cb0357fe")]
	[Uid("4b7ecce8-a985-41ff-ad83-eb2669974850")]
	[Order(3)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Description(typeof(__Resources_IBackgroundOperationInfo), "P_OperationData_Description")]
	[DisplayName(typeof(__Resources_IBackgroundOperationInfo), "P_OperationData_DisplayName")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	byte[] OperationData { get; set; }

	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Uid("6f487416-4e36-4d1e-ac09-23b589c9d82d")]
	[DisplayName(typeof(__Resources_IBackgroundOperationInfo), "P_Result_DisplayName")]
	[Property("1911b22d-0ce2-4743-832f-6a44cb0357fe")]
	[Order(4)]
	[EntityProperty]
	[BlobSettings(FieldName = "Result")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	byte[] Result { get; set; }
}
