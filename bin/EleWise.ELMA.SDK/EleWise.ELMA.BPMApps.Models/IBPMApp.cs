using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.BPMApps.Models;

[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("a94fd342-1192-4257-ad11-7c275053b6ea")]
[Uid("dcf06477-edd0-4421-943f-d3319a81a7a2")]
[MetadataType(typeof(EntityMetadata))]
[TitleProperty("8e6d0de4-df7f-4e8b-8735-640c21118688")]
[DisplayFormat(null)]
[DisplayName(typeof(__Resources_IBPMApp), "DisplayName")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>ccaa062f-dd6f-410c-b390-0b08b76d4aa1</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("BPMApp")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
public interface IBPMApp : IEntity<long>, IEntity, IIdentified
{
	[EntityProperty]
	[SystemProperty]
	[GuidSettings(FieldName = "Uid")]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[DisplayName(typeof(__Resources_IBPMApp), "P_Uid_DisplayName")]
	[NotNull]
	[Uid("2f7f312a-4e55-4925-8e0e-ec2d6144770d")]
	Guid Uid { get; set; }

	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[RequiredField]
	[DisplayName(typeof(__Resources_IBPMApp), "P_AppId_DisplayName")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[StringSettings(MaxValueString = "250", FieldName = "AppId")]
	[Order(1)]
	[Uid("8e6d0de4-df7f-4e8b-8735-640c21118688")]
	[StringRangeLength(0, "250")]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[Required(true)]
	string AppId { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IBPMApp), "P_ComponentManifest_DisplayName")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[XmlSerializableObjectSettings(FieldName = "ComponentManifest")]
	[Uid("2f82557d-f17c-4bf9-b006-6f50c7a76497")]
	[Order(3)]
	[Property("66c7898b-e56b-49e0-bfb8-9f9c4a7a0c52")]
	object ComponentManifest { get; set; }

	[XmlSerializableObjectSettings(FieldName = "AppManifest")]
	[Property("66c7898b-e56b-49e0-bfb8-9f9c4a7a0c52")]
	[DisplayName(typeof(__Resources_IBPMApp), "P_AppManifest_DisplayName")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Order(4)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Uid("f6655884-2600-445a-94e4-f2741f87a96c")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	object AppManifest { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IBPMApp), "P_Installed_DisplayName")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[Uid("d615cec3-e6dd-4037-890e-fdcdd64fb2e3")]
	[Order(5)]
	[BoolSettings(FieldName = "Installed")]
	bool Installed { get; set; }

	[DisplayName(typeof(__Resources_IBPMApp), "P_Title_DisplayName")]
	[Uid("177fa656-98a8-47ee-9551-d5a733e3faae")]
	[Order(2)]
	[StringSettings(FieldName = "Title")]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	string Title { get; set; }

	[BlobSettings(FieldName = "IconData")]
	[EntityProperty]
	[Property("1911b22d-0ce2-4743-832f-6a44cb0357fe")]
	[Uid("0121730f-dff2-4b85-a523-e4646e035ddc")]
	[Order(6)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IBPMApp), "P_IconData_DisplayName")]
	byte[] IconData { get; set; }

	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[Uid("10418174-f531-48aa-b196-04fb552db17f")]
	[EntityProperty]
	[DisplayName(typeof(__Resources_IBPMApp), "P_CertificateThumbprints_DisplayName")]
	[StringSettings(FieldName = "CertificateThumbprints")]
	[Order(8)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	string CertificateThumbprints { get; set; }

	[EntityProperty]
	[Uid("ffc10074-7d23-44f4-b59c-f1b3fcca8397")]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Order(7)]
	[StringSettings(FieldName = "IconFileName")]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[DisplayName(typeof(__Resources_IBPMApp), "P_IconFileName_DisplayName")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	string IconFileName { get; set; }

	[Order(9)]
	[Property("1911b22d-0ce2-4743-832f-6a44cb0357fe")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Uid("2ea44e74-98a6-47e3-aa9e-c02f3c1b44c1")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IBPMApp), "P_HelpFileContent_DisplayName")]
	[BlobSettings(FieldName = "HelpFileContent")]
	[EntityProperty]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	byte[] HelpFileContent { get; set; }

	[Order(10)]
	[Uid("55099443-2f3c-453e-9768-fa6fc51168f9")]
	[Property("1911b22d-0ce2-4743-832f-6a44cb0357fe")]
	[EntityProperty]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[BlobSettings(FieldName = "AdditionalFilesContent")]
	[DisplayName(typeof(__Resources_IBPMApp), "P_AdditionalFilesContent_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	byte[] AdditionalFilesContent { get; set; }
}
