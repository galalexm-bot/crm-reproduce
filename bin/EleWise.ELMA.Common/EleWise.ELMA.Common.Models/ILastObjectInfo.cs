using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Types.Settings;

namespace EleWise.ELMA.Common.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("58c4fc63-9a1c-4ff5-b1c6-7f6ebfb7ad16")]
[DisplayName(typeof(__Resources_ILastObjectInfo), "DisplayName")]
[DisplayFormat(null)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>06c1d04f-102a-4b05-847a-dd3a254cf1a6</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("LastObjectInfo")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[ImplementationUid("c54ad072-88c5-44b7-92d5-b343b481aeb9")]
[FilterType(typeof(ILastObjectInfoFilter))]
public interface ILastObjectInfo : IEntity<long>, IEntity, IIdentified
{
	[Uid("e26d7f7e-fdd7-4c6e-b376-dba144ad1ef6")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_ILastObjectInfo), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("f74f8beb-8de0-4065-ac96-b9a9b61dcc7e")]
	[Order(1)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[EntityUserSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "User")]
	[DisplayName(typeof(__Resources_ILastObjectInfo), "P_User_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	IUser User { get; set; }

	[Uid("52a672e6-7261-45f4-b794-977c948a73bc")]
	[Order(2)]
	[Property("1f289b26-0607-4bc7-adc0-9ed814c80c90")]
	[ReferenceOnEntitySettings(FieldName = "Object")]
	[DisplayName(typeof(__Resources_ILastObjectInfo), "P_Object_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	ReferenceOnEntity Object { get; set; }

	[Uid("6fa76f9b-76c3-4a76-abda-bc52c5cbfc74")]
	[Order(3)]
	[CanBeNull]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(FieldName = "CreationDate")]
	[DisplayName(typeof(__Resources_ILastObjectInfo), "P_CreationDate_DisplayName")]
	[PropertyHandler("d0c00d8a-e003-427d-9942-f52cfb77b0f0")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	DateTime? CreationDate { get; set; }

	[Uid("b1167a2a-34ed-4886-9c2a-de7a16312f37")]
	[Order(4)]
	[CanBeNull]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(FieldName = "ChangeDate")]
	[DisplayName(typeof(__Resources_ILastObjectInfo), "P_ChangeDate_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	DateTime? ChangeDate { get; set; }

	[Uid("f1ecfa22-4d6a-404a-a24d-220c787c8ace")]
	[Order(5)]
	[Property("2df8e9ca-3ac4-4ba5-832f-18f6374397e7")]
	[ReferenceOnEntityTypeSettings(FieldName = "ObjectType")]
	[DisplayName(typeof(__Resources_ILastObjectInfo), "P_ObjectType_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	ReferenceOnEntityType ObjectType { get; set; }

	[Uid("fea1814f-333f-4dac-8509-365375f54177")]
	[Order(6)]
	[Property("2df8e9ca-3ac4-4ba5-832f-18f6374397e7")]
	[ReferenceOnEntityTypeSettings(FieldName = "RealObjectType")]
	[DisplayName(typeof(__Resources_ILastObjectInfo), "P_RealObjectType_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	ReferenceOnEntityType RealObjectType { get; set; }
}
