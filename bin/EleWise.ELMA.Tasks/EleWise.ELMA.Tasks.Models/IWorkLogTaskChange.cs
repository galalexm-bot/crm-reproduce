using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Tasks.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("da7d347e-7cdf-467f-9898-2b42a0797b2c")]
[DisplayName(typeof(__Resources_IWorkLogTaskChange), "DisplayName")]
[DisplayFormat(null)]
[ShowInTypeTree(false)]
[ShowInDesigner(false)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>b73df027-ed57-4452-bbb1-96c2911f305b</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("WorkLogTaskChange")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("53e70dee-9ab5-42d7-ad1c-0fbc22878a5d")]
public interface IWorkLogTaskChange : IEntity<long>, IEntity, IIdentified
{
	[Uid("91370207-0f76-425a-ac71-0cc8611dc15f")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IWorkLogTaskChange), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("8f5883a7-12fb-469e-92c4-69e34a82fe82")]
	[Order(1)]
	[NotNull]
	[Required(true)]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[Int64Settings(FieldName = "ObjectId")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IWorkLogTaskChange), "P_ObjectId_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	long ObjectId { get; set; }

	[Uid("e8478762-4392-4005-a698-c2d9e032cafd")]
	[Order(2)]
	[NotNull]
	[Required(true)]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "ObjectUID")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IWorkLogTaskChange), "P_ObjectUID_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	Guid ObjectUID { get; set; }

	[Uid("3190ccc3-9f6c-4e7e-b7cb-28473ba6feb9")]
	[Order(3)]
	[NotNull]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[Int64Settings(FieldName = "WorkLogItem")]
	[DisplayName(typeof(__Resources_IWorkLogTaskChange), "P_WorkLogItem_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	long WorkLogItem { get; set; }
}
