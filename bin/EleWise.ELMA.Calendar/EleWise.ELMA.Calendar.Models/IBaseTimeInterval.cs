using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Projects.Models.Resources;

namespace EleWise.ELMA.Calendar.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("e0744cb1-5172-45bf-8858-39ccdfd0a6a0")]
[DisplayName(typeof(__Resources_IBaseTimeInterval), "DisplayName")]
[Description(typeof(__Resources_IBaseTimeInterval), "Description")]
[DisplayFormat(null)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>c8faa551-ecee-48db-a32e-a475d578abbf</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("BaseTimeInterval")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("97d3e90e-90ae-4fc0-9337-e64593bfd99c")]
public interface IBaseTimeInterval : IEntity<long>, IEntity, IIdentified
{
	[Uid("f4a23c45-aba6-4be8-b83f-3c9248a1083d")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IBaseTimeInterval), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("04f38050-17b7-46b5-b112-562fc25a21d1")]
	[Order(1)]
	[NotNull]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(ShowDate = false, FieldName = "Start")]
	[DisplayName(typeof(__Resources_IBaseTimeInterval), "P_Start_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	DateTime Start { get; set; }

	[Uid("87ac2fc1-c906-45c6-8cca-956593954482")]
	[Order(2)]
	[NotNull]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(ShowDate = false, FieldName = "Finish")]
	[DisplayName(typeof(__Resources_IBaseTimeInterval), "P_Finish_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	DateTime Finish { get; set; }

	[Uid("0557d289-9ab6-41e8-9800-bd1104105ba1")]
	[Order(3)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "dedb3fa3-35be-4eb1-b29a-6b995e8b32a5")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Calendar")]
	[DisplayName(typeof(__Resources_IBaseTimeInterval), "P_Calendar_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	IResourceCalendar Calendar { get; set; }
}
